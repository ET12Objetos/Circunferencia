using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjemploCircunferenciaObjetos
{
    public class Circunferencia
    {
        //atributo
        public double radio;

        //métodos
        public Circunferencia(double unRadio)
        {
            radio = unRadio;
        }

        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }

        public double CalcularPerimetro()
        {
            return Math.PI * 2 * radio;
        }
    }
}