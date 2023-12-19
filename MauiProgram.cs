using Age_of_Sigmar_app.ViewModels;
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
                fonts.AddFont("Mechanoid Warrior.ttf", "TitleFont");
            });

        builder.Services.AddSingleton<ArmyListViewModel>();
        builder.Services.AddSingleton<ArmyListView>();

		builder.Services.AddSingleton<MainMenuViewModel>();
        builder.Services.AddSingleton<MainMenuView>();

        builder.Services.AddSingleton<PathToGlorySummaryView>();
		builder.Services.AddSingleton<PathToGloryViewModel>();

        builder.Services.AddTransient<ChooseAllegianceView>();

        builder.Services.AddTransient<CreateArmyView>();
        builder.Services.AddTransient<NewCampaignIndexView>();
        builder.Services.AddTransient<NewCampaignSubfactionView>();

        return builder.Build();
	}
}
