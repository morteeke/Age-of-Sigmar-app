using Age_of_Sigmar_app.ViewModels;

namespace Age_of_Sigmar_app.Views;

public partial class CreateArmyView : ContentPage
{
	public CreateArmyView(ArmyListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}