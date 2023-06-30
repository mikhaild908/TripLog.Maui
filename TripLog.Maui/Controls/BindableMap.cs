// Source: https://dev.to/ilsonosli/net-maui-map-data-5hej

using System.Collections;
using Microsoft.Maui.Maps;
using Microsoft.Maui.Controls.Maps;
using System.Net.NetworkInformation;

namespace TripLog.Maui.Controls
{
    public class BindableMap : Microsoft.Maui.Controls.Maps.Map
    {
        public static readonly BindableProperty PinSourceProperty =
            BindableProperty.Create("PinSource",
                typeof(IMapPin),
                typeof(Microsoft.Maui.Controls.Maps.Map),
                null,
                propertyChanged: OnPinSourceChanged);

        public IMapPin PinSource
        {
            get { return (IMapPin)GetValue(PinSourceProperty); }
            set { SetValue(PinSourceProperty, value); }
        }

        static void OnPinSourceChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var map = bindable as BindableMap;

            /*
            if (oldValue != null)
                foreach (IMapPin pin in oldValue as IEnumerable)
                {
                    map.Pins.Remove(pin as Microsoft.Maui.Controls.Maps.Pin);
                }

            if (newValue != null)
                foreach (IMapPin pin in newValue as IEnumerable)
                {
                    map.Pins.Add(pin as Microsoft.Maui.Controls.Maps.Pin);
                }
            */

            if (oldValue != null)
            {
                map.Pins.Remove(oldValue as Pin);
            }

            if (newValue != null)
            {
                var thePin = newValue as Pin;
                map.Pins.Add(thePin);
                map.MoveToRegion(new MapSpan(thePin.Location, 0.01, 0.01));
            }
        }

        public BindableMap() : base(new MapSpan(new Location(38.8895, -77.0352), 0.01, 0.01))
        {

        }

        public void BindablePins_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            
            foreach (IMapPin pin in e.OldItems ?? new List<IMapPin>())
            {
                this.Pins.Remove(pin as Pin);
            }

            foreach (IMapPin pin in e?.NewItems ?? new List<IMapPin>())
            {
                this.Pins.Add(pin as Pin);
            }   
        }
    }
}

