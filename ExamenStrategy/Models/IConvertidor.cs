using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenStrategy.Models
{
    public interface IConvertidor
    {
        List<double> Convertir(List<double> temperatura,string tipo); 
    }
}
