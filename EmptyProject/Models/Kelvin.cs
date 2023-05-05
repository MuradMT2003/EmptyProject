namespace EmptyProject.Models;

public class Kelvin
{
    public int Temperature { get; set; }
    public Kelvin(int temperature)
    {
        Temperature = temperature;
    }
    public static implicit operator Kelvin(Celsius temp) => new Kelvin(temp.Temperature + 273);
    
}
