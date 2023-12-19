using Age_of_Sigmar_app.Models;
using Age_of_Sigmar_app.Models.ApiModels;
using Age_of_Sigmar_app.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;

namespace Age_of_Sigmar_app.ViewModels
{

    public partial class PathToGloryViewModel:BaseViewModel
    {
        [ObservableProperty]
        public Campaign campaign;

        [ObservableProperty]
        ObservableCollection<Campaign> campaignList;

        [ObservableProperty]
        ObservableCollection<Allegiance> allegianceList;
        [ObservableProperty]
        ObservableCollection<Allegiance> subfactionList;


        HttpClient client;

        public PathToGloryViewModel() 
        {
            CampaignList = new();
            client = new();
            AllegianceList = new();
            SubfactionList = new();
        }

        [RelayCommand]
        public void GoToNewCampaign()
        {
            Campaign = new();
            GetAllegiances();
            Shell.Current.GoToAsync(nameof(NewCampaignIndexView), true);
        }

        [RelayCommand]
        public void GoToNewCampaignSubfaction(Allegiance allegiance)
        {

            Debug.WriteLine(allegiance.name);
            Campaign.Faction = allegiance.name;

            Shell.Current.GoToAsync(nameof(NewCampaignSubfactionView), true);
        }

        private async void GetAllegiances()
        {
            AllegianceList.Clear();

            var apiUrl = "https://aos-api.com/allegiances";

            var response = await client.GetStringAsync(apiUrl);

            var data = JsonSerializer.Deserialize<List<Allegiance>>(response);

            foreach(var item in data )
            {
                AllegianceList.Add(item);
            }

        }
        private async void GetSubfactionsByAllegiance(Allegiance allegiance)
        {
            
        }
    }
}
