using TaskList;
using TaskList.MVVM.ViewModel;
using TaskList.MVVM.Views;

namespace TaskList
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
                });

            builder.Services.AddSingleton<DataViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<PantallaDetalle>();

            return builder.Build();
        }
    }
}








