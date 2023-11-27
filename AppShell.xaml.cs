using Age_of_Sigmar_app.Views;

namespace Age_of_Sigmar_app;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(ArmyListView), typeof(ArmyListView));
		Routing.RegisterRoute(nameof(CreateArmyView), typeof(CreateArmyView));
	}
}
