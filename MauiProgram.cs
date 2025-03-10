using Microsoft.Extensions.Logging;
using DotNet.Meteor.HotReload.Plugin;
using Navigation_Between.Service;
using Navigation_Between.Interface;

namespace Navigation_Between;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
#if DEBUG
			.EnableHotReload()
#endif
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
		// Dodawanie serwisów, by byly ogólnodostępne w aplikacji 
		builder.Services.AddSingleton<DataService>();
		builder.Services.AddSingleton<IAlertService, AlertService>();

		return builder.Build();
	}
}
