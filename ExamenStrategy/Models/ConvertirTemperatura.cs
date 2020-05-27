using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExamenStrategy.Models
{
    public class ConvertirTemperatura
    {
        private List<double> temperaturas;
        private IConvertidor convertidor; //Estrategia
        private string tipo;

        public ConvertirTemperatura(List<double> temperaturas, IConvertidor convertidor,string tipo)
        {
            this.temperaturas = temperaturas;
            this.convertidor = convertidor;
            this.tipo = tipo;
        }

        public List<double> DatosConvertidos()
        {
            if(temperaturas == null)
            {
                return new List<double>();
            }
            else
            {
                return convertidor.Convertir(temperaturas,tipo);
            }
        }
    }
}
