using System;
namespace TripLog.Maui.Services
{
	public interface INavigationService
	{
        //Task InitializeAsync();
        Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null);
    }
}

