using AppTask.Libraries.Authentications;
using AppTask.Views;
using Microsoft.Maui.Platform;

namespace AppTask
{
    public partial class App : Application
    {
        public static IServiceProvider ServiceProvider { get; private set; } = default!;

        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            CustomHandler();
            ServiceProvider = serviceProvider;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            if (UserAuth.GetUserLogged() == null)
            {
                var loginPage = ServiceProvider.GetRequiredService<LoginPage>();
                return new Window(loginPage);
            }

            var startPage = ServiceProvider.GetRequiredService<StartPage>();
            return new Window(new NavigationPage(startPage));
        }

        private void CustomHandler()
        {
            EntryNoBorder();
            DatePickerNoBorder();
        }

        private static void EntryNoBorder()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
            {
#if ANDROID
                //Android
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
#elif IOS || MACCATALYST
                //iOS || MACCATALYST
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
                //Windows - Não funciona 100%
                handler.PlatformView.BorderThickness = new Thickness(0).ToPlatform();
#endif
            });
        }

        private static void DatePickerNoBorder()
        {
            Microsoft.Maui.Handlers.DatePickerHandler.Mapper.AppendToMapping("NoBorder", (handler, view) =>
            {
#if ANDROID
                //Android
                handler.PlatformView.BackgroundTintList = Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToPlatform());
#elif IOS || MACCATALYST
                //iOS || MACCATALYST
                //handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#elif WINDOWS
                //Windows - Não funciona 100%
                handler.PlatformView.BorderThickness = new Thickness(0).ToPlatform();
#endif
            });
        }
    }
}