using Age_of_Sigmar_app.Models;
using Age_of_Sigmar_app.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Age_of_Sigmar_app.ViewModels
{
    public partial class ArmyListViewModel:BaseViewModel
    {
        [ObservableProperty]
        string allegiance;

        [ObservableProperty]
        Army army;

        [ObservableProperty]
        ObservableCollection<Army> armyList;

        public ArmyListViewModel()
        {
            Title = "Army List";

            Army = new();
            ArmyList = new();
        }

        [RelayCommand]
        public void GoToCreateArmyView()
        {
            Debug.WriteLine("NEW ARMY BUTTON CLICKED");

            Shell.Current.GoToAsync(nameof(CreateArmyView), true);
        }

        [RelayCommand]
        public void GoToChooseAllegianceView()
        {
            Shell.Current.GoToAsync(nameof(ChooseAllegianceView), true);
        }

        [RelayCommand]
        public void GoToArmyView()
        {
            Debug.WriteLine("GO TO ARMY DETAIL PAGE");
        }

        [RelayCommand]
        public async Task SaveArmy()
        {
            if(Army == null)
            {
                return;
            }

            ArmyList.Add(Army);
            await Shell.Current.GoToAsync("../..", true);   //Title changes but doesn't show right view 'ArmyListView'
        }
    }
}
