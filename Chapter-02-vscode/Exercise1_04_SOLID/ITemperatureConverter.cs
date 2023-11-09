public interface ITemperatureConverter
{
    TemperatureUnit Unit { get; }
    Temperature ToC(Temperature temperature);
    Temperature FromC(Temperature temperature);
}