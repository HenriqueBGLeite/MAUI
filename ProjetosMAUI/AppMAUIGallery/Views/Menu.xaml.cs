using AppMAUIGallery.Repositories;

namespace AppMAUIGallery.Views;

public partial class Menu : ContentPage
{
	private IGroupComponentRepository _repository;

	public Menu()
	{
		InitializeComponent();

		_repository = new GroupComponentRepository();

		MenuCollection.ItemsSource = _repository.GetGroupComponent();
    }

	private void OnTapComponent(object sender, TappedEventArgs e)
	{
		var page = (Type)e.Parameter;

		((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage((Page)Activator.CreateInstance(page));
		((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }

    private void OnTapInicio(object sender, TappedEventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new NavigationPage(new AppMAUIGallery.Views.MainPage());
        ((FlyoutPage)App.Current.MainPage).IsPresented = false;
    }
}