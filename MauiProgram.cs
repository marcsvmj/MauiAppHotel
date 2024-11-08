using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("PlaywriteGBS.ttf", "PlayFont");
                    fonts.AddFont("PlaywriteGBS-Italic.ttf", "PlayItalic");
                    fonts.AddFont("DancingScript.ttf", "DanceFont");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
