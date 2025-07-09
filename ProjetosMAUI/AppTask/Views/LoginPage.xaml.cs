using AppTask.Database.Repositories;
using AppTask.Libraries.Authentications;
using AppTask.Libraries.Validations;
using AppTask.Models;
using AppTask.Services;

namespace AppTask.Views;

public partial class LoginPage : ContentPage
{
	private IUserService _service;
	private IUserModelRepository _repository;

    public LoginPage(IUserService service, IUserModelRepository repositorry)
    {
        InitializeComponent();

        _service = service;
        _repository = repositorry;
    }

    private async void NextAction(object sender, EventArgs e)
    {
        AILoading.IsVisible = true;
        EntryEmail.IsEnabled = false;
        LblEmailValidateMessage.IsVisible = false;

        try
        {
            var email = GetEmailFromEntry();

            if (email == null || !EmailValidate.IsValidEmail(email))
            {
                ShowInvalidEmailMessage();
                return;
            }

            await _service.GetAccessToken(email);

            GoToStep2();
        }
        catch (HttpRequestException)
        {
            await ShowNetworkErrorAlert();
            EntryEmail.IsEnabled = true;
            //Logs...
        }
        catch (Exception)
        {
            await ShowUnexoectedErrorAlert();
            EntryEmail.IsEnabled = true;
            //Logs...
        }
        finally
        {
            AILoading.IsVisible = false;
        }
    }

    private async void AccessAction(object sender, EventArgs e)
    {
        AILoading.IsVisible = true;
        LblAccessTokenValidateMessage.IsVisible = false;
        EntryAccessToken.IsEnabled = false;

        try
        {
            var email = GetEmailFromEntry();
            var accessToken = EntryAccessToken.Text?.Trim();

            if (accessToken == null)
            {
                LblAccessTokenValidateMessage.IsVisible = true;
                AILoading.IsVisible = false;
                return;
            }

            UserModel userApi = await _service.ValidateAccessToken(new UserModel { Email = email, AccessToken = accessToken });

            if (userApi == null)
            {
                LblAccessTokenValidateMessage.IsVisible = true;
                return;
            }

            AddOrUpdateUserInDatabase(userApi);

            UserAuth.SetUserLogged(userApi);
            var startPage = Handler.MauiContext.Services.GetService<StartPage>();

            App.Current.MainPage = new NavigationPage(startPage);
        }
        catch (HttpRequestException)
        {
            await ShowNetworkErrorAlert();
            EntryAccessToken.IsEnabled = true;
            //Logs...
        }
        catch (Exception)
        {
            await ShowUnexoectedErrorAlert();
            EntryAccessToken.IsEnabled = true;
            //Logs...
        }
        finally
        {
            EntryAccessToken.IsEnabled = true;
            AILoading.IsVisible = false;
        }
    }

    private string GetEmailFromEntry()
    {
        return EntryEmail.Text?.Trim().ToLower();
    }

    private void ShowInvalidEmailMessage()
    {
        EntryEmail.IsEnabled = true;
        LblEmailValidateMessage.IsVisible = true;
        AILoading.IsVisible = false;
    }

    private void GoToStep2()
    {
        EntryEmail.IsEnabled = false;
        BtnNext.IsVisible = false;
        Step2.IsVisible = true;
        AILoading.IsVisible = false;
    }

    private async Task ShowUnexoectedErrorAlert()
    {
        await DisplayAlert("Opps! Erro inesperado!", "Houve um erro no aplicativo, tente realizar o procedimento novamente.", "OK");
    }

    private async Task ShowNetworkErrorAlert()
    {
        await DisplayAlert("Opps! Erro na rede!", "Não conseguimos comunicar com o servidor! Tente novamente mais tarde!", "OK");
    }

    private void AddOrUpdateUserInDatabase(UserModel userApi)
    {
        var userDb = _repository.GetByEmail(userApi.Email);

        if (userDb == null)
            _repository.Add(userApi);
        else
            _repository.Update(userApi);
    }
}