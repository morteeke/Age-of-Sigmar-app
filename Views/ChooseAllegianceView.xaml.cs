using Age_of_Sigmar_app.ViewModels;

namespace Age_of_Sigmar_app.Views;

public partial class ChooseAllegianceView : ContentPage
{
	public ChooseAllegianceView(ArmyListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}