using TripLog.Maui.ViewModels;

namespace TripLog.Maui.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainViewModel mainViewModel)
	{
		InitializeComponent();
        BindingContext = mainViewModel;
    }
}