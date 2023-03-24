using MauiTestApp.Services;
using MauiTestApp.View;

namespace MauiTestApp;

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

		//Build Services
		builder.Services.AddSingleton<MonkeyService>();

		//Build ViewModels
		builder.Services.AddSingleton<MonkeyVM>();
		builder.Services.AddTransient<MonkeyDetailsVM>();

		//Build App Pages
		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<DetailsPage>();

		return builder.Build();
	}
}
