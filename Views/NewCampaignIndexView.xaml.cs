using Age_of_Sigmar_app.ViewModels;

namespace Age_of_Sigmar_app.Views;

public partial class NewCampaignIndexView : ContentPage
{
	public NewCampaignIndexView(PathToGloryViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}