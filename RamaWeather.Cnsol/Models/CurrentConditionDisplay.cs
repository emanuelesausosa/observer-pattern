using System;
using RamaWeather.Cnsol.Interfaces;

namespace RamaWeather.Cnsol.Models
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float _temperature, _humidity;
        private ISubject _weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            _weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions {0} degrees and {1} humidity", _temperature, _humidity);
        }
    }
}