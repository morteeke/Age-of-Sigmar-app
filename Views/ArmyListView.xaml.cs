using Age_of_Sigmar_app.ViewModels;

namespace Age_of_Sigmar_app.Views;

public partial class ArmyListView : ContentPage
{
	public ArmyListView(ArmyListViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}