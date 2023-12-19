using Age_of_Sigmar_app.Views;

namespace Age_of_Sigmar_app;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		//Routing.RegisterRoute(nameof(ArmyListView), typeof(ArmyListView));
        Routing.RegisterRoute(nameof(ChooseAllegianceView), typeof(ChooseAllegianceView));
        Routing.RegisterRoute(nameof(CreateArmyView), typeof(CreateArmyView)); //nameof(ChooseAllegianceView)+"/"+
        Routing.RegisterRoute(nameof(PathToGlorySummaryView), typeof(PathToGlorySummaryView));
        Routing.RegisterRoute(nameof(NewCampaignIndexView), typeof(NewCampaignIndexView));
        Routing.RegisterRoute(nameof(NewCampaignSubfactionView), typeof(NewCampaignSubfactionView));
    }
}
