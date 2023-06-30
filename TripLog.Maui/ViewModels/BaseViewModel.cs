using System;
using CommunityToolkit.Mvvm.ComponentModel;
using TripLog.Maui.Services;

namespace TripLog.Maui.ViewModels
{
	public partial class BaseViewModel : ObservableObject
	{
        protected readonly INavigationService NavigationService;

        [ObservableProperty]
        string title;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotLoading))]
        bool isLoading;

        public bool IsNotLoading => !IsLoading;

        public BaseViewModel()
        {

        }

        public BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}

