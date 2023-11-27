﻿using Age_of_Sigmar_app.ViewModels;
using Age_of_Sigmar_app.Views;

namespace Age_of_Sigmar_app;

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

		builder.Services.AddSingleton<ArmyListView>();
		builder.Services.AddSingleton<ArmyListViewModel>();

		builder.Services.AddTransient<CreateArmyView>();

		return builder.Build();
	}
}