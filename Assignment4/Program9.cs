using System;

delegate double ConvertTemperature(double celsius);

class Program9
{
    static double ToFahrenheit(double c) => (c * 9 / 5) + 32;
    static double ToKelvin(double c) => c + 273.15;

    static void Main()
    {
        double celsius = 25;

        ConvertTemperature ct = ToFahrenheit;
        Console.WriteLine("25°C in Fahrenheit: " + ct(celsius));

        ct = ToKelvin;
        Console.WriteLine("25°C in Kelvin: " + ct(celsius));
    }
}
