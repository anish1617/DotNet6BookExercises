class CelsiusConverter : ITemperatureConverter
{
    public TemperatureUnit Unit => TemperatureUnit.C;

    public Temperature FromC(Temperature temperature)
    {
        return temperature;
    }

    public Temperature ToC(Temperature temperature)
    {
        return temperature;
    }
}