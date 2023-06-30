using System;

namespace TripLog.Maui.Services
{
	public class NavigationService : INavigationService
	{
		public NavigationService()
		{
		}

        public Task NavigateToAsync(string route, IDictionary<string, object> routeParameters = null)
        {
			if (routeParameters != null)
			{
				return Shell.Current.GoToAsync(route, routeParameters);
			}

			return Shell.Current.GoToAsync(route);
        }
    }
}

