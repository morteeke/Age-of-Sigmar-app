﻿using Age_of_Sigmar_app.Models;
using Age_of_Sigmar_app.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_of_Sigmar_app.ViewModels
{
    public partial class ArmyListViewModel:BaseViewModel
    {
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
        public async Task GoToArmyView()
        {
            Debug.WriteLine("GO TO ARMY DETAIL PAGE");
        }

        [RelayCommand]
        public async Task SaveArmyAsync()
        {
            if(Army == null)
            {
                return;
            }

            ArmyList.Add(Army);
            await GoBackAsync();
        }
    }
}
