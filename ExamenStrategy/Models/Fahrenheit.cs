using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenStrategy.Models
{
    public class Fahrenheit : IConvertidor
    {
        private List<double> TempCelsius = new List<double>();
        private double convertidor;
      
        public List<double> Convertir(List<double> temperatura, string tipo)
        {
            tipo.ToLower();
            if (tipo == "celsius")
            {
                foreach (var temp in temperatura)
                {
                    convertidor = (temp * (9 / 5)) + 32;
                    TempCelsius.Append(convertidor);
                }
                return TempCelsius;
            }
            else
            {
                foreach (var temp in temperatura)
                {
                    convertidor = ((temp - 273.15)*(9/5)) + 32;
                    TempCelsius.Append(convertidor);
                }
                return TempCelsius;
            }
        }
    }
}
