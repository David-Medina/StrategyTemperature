using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace ExamenStrategy.Models
{
    public class Celsius : IConvertidor
    {
        private List<double> Convertido = new List<double>();
        private double convertidor;

        public List<double> Convertir(List<double> temperatura, string tipo)
        {
            tipo.ToLower();
            if (tipo == "fahrenheit")
            {
                foreach(var temp in temperatura)
                {
                    convertidor = (temp - 32) * (5 / 9);
                    Convertido.Add(convertidor);
                }
                return Convertido;
            }
            else
            {
                foreach (var temp in temperatura)
                {
                    convertidor = temp - 273.15;
                    Convertido.Add(convertidor);
                }
                return Convertido;
            }
        }
    }
}
