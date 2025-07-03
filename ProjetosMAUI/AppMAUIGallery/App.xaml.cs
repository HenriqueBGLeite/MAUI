namespace AppMAUIGallery
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Application.Current.RequestedThemeChanged += Current_RequestedThemeChanged;
        }

        private void Current_RequestedThemeChanged(object? sender, AppThemeChangedEventArgs e)
        {
            if (e.RequestedTheme == AppTheme.Light)
                App.Current.MainPage.DisplayAlert("Troca de tema", "Trocou para o tema claro", "OK");
            else
                App.Current.MainPage.DisplayAlert("Troca de tema", "Trocou para o tema escuro", "OK");
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppFlyout());
        }
    }
}