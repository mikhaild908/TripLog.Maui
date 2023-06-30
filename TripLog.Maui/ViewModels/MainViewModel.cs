using System.Collections.ObjectModel;
using TripLog.Maui.Models;
using TripLog.Maui.Services;

using CommunityToolkit.Mvvm.Input;
using TripLog.Maui.Views;
using Microsoft.Maui.Controls.Maps;

namespace TripLog.Maui.ViewModels
{
	public partial class MainViewModel : BaseViewModel
	{
        public ObservableCollection<TripLogEntry> LogEntries { get; private set; } = new();

        public MainViewModel(INavigationService navigationService) : base(navigationService)
        {
            LogEntries = new ObservableCollection<TripLogEntry>
            {
                new TripLogEntry
                {
                    Title = "Washington Monument",
                    Notes = "Amazing!",
                    Rating = 3,
                    Date = new DateTime(2019, 2, 5),
                    Latitude = 38.8895,
                    Longitude = -77.0352,
                    Pin = new Pin { Location = new Location(38.8895, -77.0352), Label = "Washington Monument" }
                },
                new TripLogEntry
                {
                    Title = "Statue of Liberty",
                    Notes = "Inspiring!",
                    Rating = 4,
                    Date = new DateTime(2019, 4, 13),
                    Latitude = 40.6892,
                    Longitude = -74.0444,
                    Pin = new Pin { Location = new Location(40.6892, -74.0444), Label = "Statue of Liberty" }
                },
                new TripLogEntry
                {
                    Title = "Golden Gate Bridge",
                    Notes = "Foggy, but beautiful.",
                    Rating = 5,
                    Date = new DateTime(2019, 4, 26),
                    Latitude = 37.8268,
                    Longitude = -122.4798,
                    Pin = new Pin { Location = new Location(37.8268, -122.4798), Label = "Golden Gate Bridge" }
                }
            };
        }

        [RelayCommand]
        public void NavigateToNewEntryPage()
        {
            NavigationService.NavigateToAsync(nameof(NewEntryPage));
        }
        
        [RelayCommand]
        public void NavigateToDetailPage(TripLogEntry tripLogEntry)
        {
            NavigationService.NavigateToAsync(nameof(DetailPage), new Dictionary<string, object> { { "TripLogEntry", tripLogEntry } });
        }
    }
}

