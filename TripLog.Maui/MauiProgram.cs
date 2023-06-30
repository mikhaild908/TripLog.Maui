using Microsoft.Extensions.Logging;
using TripLog.Maui.Services;
using TripLog.Maui.ViewModels;
using TripLog.Maui.Views;

namespace TripLog.Maui;

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
			})
		  .UseMauiMaps();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<INavigationService, NavigationService>();

		// UI registration
		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<NewEntryPage>();
        builder.Services.AddTransient<DetailPage>();

        // View-Model registration
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<NewEntryViewModel>();
        builder.Services.AddTransient<DetailViewModel>();

        return builder.Build();
	}
}

