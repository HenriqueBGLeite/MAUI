using Microsoft.Extensions.Logging;

namespace AppMAUIGallery
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("BitcountGridDouble_Cursive-Medium.ttf", "BitcountMedium");
                    fonts.AddFont("BitcountGridDouble_Roman-Bold.ttf", "BitcountBold");
                    fonts.AddFont("fonteDiferenciada.ttf", "FonteDiferente");
                    fonts.AddFont("Icons.ttf", "Icons");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
