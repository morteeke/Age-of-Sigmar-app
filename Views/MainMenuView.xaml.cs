using Age_of_Sigmar_app.ViewModels;

namespace Age_of_Sigmar_app.Views;

public partial class MainMenuView : ContentPage
{
	public MainMenuView(MainMenuViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}