using System.Collections.Generic;
using RamaWeather.Cnsol.Interfaces;

namespace RamaWeather.Cnsol.Models
{
    public class WeatherData : ISubject
    {
        private readonly List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }
        
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature, _humidity, _pressure);
            }
        }

        private void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float pTemp, float pHumidity, float pPressure)
        {
            _temperature = pTemp;
            _humidity = pHumidity;
            _pressure = pPressure;
            
            MeasurementsChanged();
        }
    }
}