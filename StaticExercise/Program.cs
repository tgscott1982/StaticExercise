using StaticExercise;




var celsius1 = TempConverter.FahrenheitToCelsius(0);
var celsius2 = TempConverter.FahrenheitToCelsius(100);

Console.WriteLine("0 degrees and 100 degrees Fahrenheit converted to Celsius are respectively:\n");
Console.WriteLine(celsius1);
Console.WriteLine(celsius2);


var fahrenheit1 = TempConverter.CelsiusToFahrenheit(0);
var fahrenheit2 = TempConverter.CelsiusToFahrenheit(100);

Console.WriteLine();
Console.WriteLine("Here we convert the same values of 0 degrees and 100 degrees Celsius to Fahrenhet, respectively:\n");
Console.WriteLine(fahrenheit1);
Console.WriteLine(fahrenheit2);

Console.WriteLine();
Console.WriteLine("Or...Fahrenheit to Celsius (50)\n");
Console.WriteLine(TempConverter.FahrenheitToCelsius(50));
Console.WriteLine("\nAnd Celsius to Fahrenheit (50)\n");
Console.WriteLine(TempConverter.CelsiusToFahrenheit(50));
