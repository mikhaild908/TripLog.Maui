// TODO: refactor MVVM

using System.ComponentModel;
using TripLog.Maui.ViewModels;

namespace TripLog.Maui.Views;

public partial class NewEntryPage : ContentPage
{
    NewEntryViewModel ViewModel => BindingContext as NewEntryViewModel;

    public NewEntryPage(NewEntryViewModel newEntryViewModel)
    {
        InitializeComponent();

        BindingContextChanged += Page_BindingContextChanged;

        BindingContext = newEntryViewModel;
    }

    void Page_BindingContextChanged(object sender, EventArgs e)
    {
        ViewModel.ErrorsChanged += ViewModel_ErrorsChanged;
    }

    void ViewModel_ErrorsChanged(object sender, DataErrorsChangedEventArgs e)
    {
        var propHasErrors = (ViewModel.GetErrors(e.PropertyName) as List<string>)?.Any() == true;

        switch (e.PropertyName)
        {
            case nameof(ViewModel.Title):
                title.LabelColor = propHasErrors
                    ? Color.FromRgb(255, 0 ,0) : Color.FromRgb(0, 0, 0);
                break;
            case nameof(ViewModel.Rating):
                rating.LabelColor = propHasErrors
                    ? Color.FromRgb(255, 0, 0) : Color.FromRgb(0, 0, 0);
                break;
            default:
                break;
        }
    }
}
