using Age_of_Sigmar_app.ViewModels;

namespace Age_of_Sigmar_app.Views;

public partial class NewCampaignSubfactionView : ContentPage
{
	public NewCampaignSubfactionView(PathToGloryViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}