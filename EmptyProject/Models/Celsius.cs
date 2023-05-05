namespace EmptyProject.Models;

public class Celsius
{
    public int Temperature { get; set; }
    public Celsius(int temperature)
    {
        Temperature = temperature;
    }
    public static implicit operator Celsius(Kelvin temp) => new Celsius(temp.Temperature - 273);
}
