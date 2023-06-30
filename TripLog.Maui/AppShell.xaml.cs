using TripLog.Maui.Views;

namespace TripLog.Maui;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(NewEntryPage), typeof(NewEntryPage));
        Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
    }
}

