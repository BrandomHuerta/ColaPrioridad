using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaPrioridad
{
    public class ElementoPrioridad
    {
        public int Valor { get; set; }        // el dato real (no define la prioridad)
        public int Prioridad { get; set; }    // la prioridad asociada (define el orden)

        public ElementoPrioridad(int valor, int prioridad)
        {
            Valor = valor;
            Prioridad = prioridad;
        }

        public override string ToString()
        {
            return $"Valor: {Valor} | Prioridad: {Prioridad}";
        }
    }
}
