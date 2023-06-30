using Microsoft.Maui.Controls.Maps;
using Microsoft.Maui.Maps;

namespace TripLog.Maui.Models
{
	public class TripLogEntry
	{
        public string Title { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Date { get; set; }
        public int Rating { get; set; }
        public string Notes { get; set; }
        public Location Coordinates { get; set; }
        public Pin Pin { get; set; }
    }
}

