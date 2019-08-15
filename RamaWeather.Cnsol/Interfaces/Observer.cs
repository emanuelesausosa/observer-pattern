namespace RamaWeather.Cnsol.Interfaces
{
    public interface IObserver
    {
        void Update( float temperature,
        float humidity,
        float pressure);
    }
}