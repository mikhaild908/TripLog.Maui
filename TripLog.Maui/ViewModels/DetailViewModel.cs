using CommunityToolkit.Mvvm.ComponentModel;
using TripLog.Maui.Models;
using TripLog.Maui.Services;

namespace TripLog.Maui.ViewModels
{
    [QueryProperty(nameof(Entry), "TripLogEntry")]
	public partial class DetailViewModel : BaseViewModel
	{
        [ObservableProperty]
        TripLogEntry _entry;

        public DetailViewModel(INavigationService navigationService) : base(navigationService)
        {
            
        }
    }
}

