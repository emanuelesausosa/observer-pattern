using System;
using RamaWeather.Cnsol.Models;

namespace RamaWeather.Cnsol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Rama Weather app");
            
            WeatherData weatherData = new WeatherData();
            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weatherData);
            
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(152, 41, 4.4f);
            weatherData.SetMeasurements(74, 2388, 30.4f);
            
        }
    }
}