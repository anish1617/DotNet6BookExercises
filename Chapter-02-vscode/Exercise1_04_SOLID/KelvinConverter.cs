class KelvinConverter : ITemperatureConverter
{
    public const double AbsoluteZero = -273.15;

    public TemperatureUnit Unit => TemperatureUnit.K;

    public Temperature FromC(Temperature temperature)
    {
        return new(temperature.Degrees - AbsoluteZero, Unit);
    }

    public Temperature ToC(Temperature temperature)
    {
        return new(temperature.Degrees + AbsoluteZero, TemperatureUnit.C);
    }
}