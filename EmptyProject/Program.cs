using EmptyProject.Models;
Celsius celsius = new Celsius(10);
Kelvin kel = celsius;
Celsius celsius1 = kel;
Console.WriteLine(kel.Temperature);
Console.WriteLine(celsius1.Temperature);


