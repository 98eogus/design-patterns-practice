using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice.Observer
{
    public class WeatherSubject : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private float _temperature;

        public void Register(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void SetTemperature(float temp)
        {
            _temperature = temp;
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }
    }
}
