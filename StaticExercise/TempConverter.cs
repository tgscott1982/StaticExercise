using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise;

public static class TempConverter
{




    public static double FahrenheitToCelsius(double number)
    {
        var result = (number - 32) / 1.8;
        return result;
    }



    public static double CelsiusToFahrenheit(double number)
    {
        var result = (number * 9) / 5 + 32;
        return result;
    }







}
