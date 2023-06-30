using System;
using CommunityToolkit.Mvvm.ComponentModel;
using TripLog.Maui.Models;
using TripLog.Maui.Services;

namespace TripLog.Maui.ViewModels
{
	public partial class NewEntryViewModel : BaseValidationViewModel
    {
        [ObservableProperty]
        string _title;

        [ObservableProperty]
        double _latitude;

        [ObservableProperty]
        double _longitude;

        [ObservableProperty]
        DateTime _date;

        [ObservableProperty]
        int _rating;

        [ObservableProperty]
        string _notes;
        
        Command _saveCommand;
        public Command SaveCommand => _saveCommand ?? (_saveCommand = new Command(Save, CanSave));

        public NewEntryViewModel(INavigationService navigationService) : base(navigationService)
        {
            Date = DateTime.Today;
            Rating = 1;
        }

        void Save()
        {
            var newItem = new TripLogEntry
            {
                Title = Title,
                Latitude = Latitude,
                Longitude = Longitude,
                Date = Date,
                Rating = Rating,
                Notes = Notes
            };

            // TODO: Persist entry
        }

        bool CanSave() => !string.IsNullOrWhiteSpace(Title) && !HasErrors;
    }
}

