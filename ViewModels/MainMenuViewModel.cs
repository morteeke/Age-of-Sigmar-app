using CommunityToolkit.Mvvm.Input;
using Age_of_Sigmar_app.Views;
using System.Diagnostics;

namespace Age_of_Sigmar_app.ViewModels
{
    public partial class MainMenuViewModel:BaseViewModel
    {
        [RelayCommand]
        public void GoToPathToGlory()
        {
            Shell.Current.GoToAsync(nameof(PathToGlorySummaryView), true);
        }

        [RelayCommand]
        public void GoToArmyList()
        {
            Shell.Current.GoToAsync(nameof(ArmyListView), true);
        }
    }
}
