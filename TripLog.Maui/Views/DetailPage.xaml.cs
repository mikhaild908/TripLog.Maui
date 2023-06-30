using TripLog.Maui.ViewModels;

namespace TripLog.Maui.Views;

public partial class DetailPage : ContentPage
{
    public DetailPage(DetailViewModel detailViewModel)
    {
        InitializeComponent();
        BindingContext = detailViewModel;

        // TODO: this shouldn't be here
        //var location = new Location(detailViewModel.Entry.Latitude, detailViewModel.Entry.Longitude);
        //var mapSpan = new MapSpan(location, 0.01, 0.01);
        //var map = new Microsoft.Maui.Controls.Maps.Map(mapSpan);
        //map.MoveToRegion(mapSpan);
    }
}
