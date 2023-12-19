using Age_of_Sigmar_app.ViewModels;

namespace Age_of_Sigmar_app.Views;

public partial class PathToGlorySummaryView : ContentPage
{
	public PathToGlorySummaryView(PathToGloryViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}