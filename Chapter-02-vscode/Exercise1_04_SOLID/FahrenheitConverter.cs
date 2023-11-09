class FahrenheitConverter : ITemperatureConverter
{
    public TemperatureUnit Unit => TemperatureUnit.F;

    public Temperature FromC(Temperature temperature)
    {
        return new(9.0 / 5 * temperature.Degrees + 32, Unit);
    }

    public Temperature ToC(Temperature temperature)
    {
        return new(5.0 / 9 * (temperature.Degrees - 32), TemperatureUnit.C);
    }
}