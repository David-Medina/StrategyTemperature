using System;
using System.Collections.Generic;
using ExamenStrategy.Models;

namespace ExamenStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IConvertidor strategy = null;
            var temperaturas = new List<double> { 25, 13.5, 122.31, 56.87, 33, 12, 40, 190.67 };
            Console.WriteLine("Conversiones");
            //Fahrenheit
            Console.WriteLine("Celsius a fahrenheit");
            strategy = new Fahrenheit();
            var Convertir = new ConvertirTemperatura(temperaturas, strategy, "celsius");
            var res = Convertir.DatosConvertidos();
            foreach(var valor in res)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Kelvin a fahrenheit");
            strategy = new Fahrenheit();
            Convertir = new ConvertirTemperatura(temperaturas, strategy, "kelvin");
            res = Convertir.DatosConvertidos();
            foreach (var valor in res)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Kelvin
            Console.WriteLine("Celsius a kelvin");
            strategy = new Kelvin();
            Convertir = new ConvertirTemperatura(temperaturas, strategy, "celsius");
            res = Convertir.DatosConvertidos();
            foreach (var valor in res)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Fahrenheit a kelvin");
            strategy = new Kelvin();
            Convertir = new ConvertirTemperatura(temperaturas, strategy, "fahrenheit");
            res = Convertir.DatosConvertidos();
            foreach (var valor in res)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine();
            Console.WriteLine();

            //Celsius
            Console.WriteLine("Kelvin a Celsius");
            strategy = new Celsius();
            Convertir = new ConvertirTemperatura(temperaturas, strategy,"kelvin");
            res = Convertir.DatosConvertidos();
            foreach (var valor in res)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Fahrenheit a Celsius");
            strategy = new Celsius();
            Convertir = new ConvertirTemperatura(temperaturas, strategy, "Fahrenheit");
            res = Convertir.DatosConvertidos();
            foreach (var valor in res)
            {
                Console.WriteLine(valor);
            }
            Console.WriteLine();
            Console.WriteLine();


        }
    }
}
