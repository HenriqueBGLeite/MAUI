namespace AppMAUIGallery.Views.Utils;

public partial class PlatformIdiomPage : ContentPage
{
	public PlatformIdiomPage()
	{
		InitializeComponent();

        #if WINDOWS
            DisplayAlert("Condi��es de compila��o", "Esta mensagem � executada apenas no windows usando condi��es de compila��o.", "OK");
        #endif

        if (DeviceInfo.Current.Platform == DevicePlatform.WinUI) 
		{
			DisplayAlert("Windows", "Esta mensagem � exclusiva do Windows", "OK");
		}

        if (DeviceInfo.Current.Idiom == DeviceIdiom.Desktop)
        {
            DisplayAlert("Desktop", "Esta mensagem � exclusiva do Desktop", "OK");
        }
    }
}