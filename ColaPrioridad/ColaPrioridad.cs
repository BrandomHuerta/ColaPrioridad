using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaPrioridad
{
    public class ColaPrioridad
    {
        private List<ElementoPrioridad> elementos;

        public ColaPrioridad()
        {
            elementos = new List<ElementoPrioridad>();
        }

        // Insertar un nuevo elemento con su prioridad
        public void Encolar(ElementoPrioridad elemento)
        {
            elementos.Add(elemento);
        }

        // Eliminar el elemento con MAYOR valor de PRIORIDAD (no el mayor valor del dato)
        public ElementoPrioridad Desencolar()
        {
            if (elementos.Count == 0)
                throw new InvalidOperationException("La cola está vacía.");

            int indiceMayor = 0;

            // 🔹 Comparación basada en PRIORIDAD, no en el valor
            for (int i = 1; i < elementos.Count; i++)
            {
                if (elementos[i].Prioridad > elementos[indiceMayor].Prioridad)
                    indiceMayor = i;
            }

            ElementoPrioridad eliminado = elementos[indiceMayor];
            elementos.RemoveAt(indiceMayor);
            return eliminado;
        }

        // Mostrar el contenido actual
        public string Mostrar()
        {
            if (elementos.Count == 0)
                return "Cola vacía.";

            StringBuilder sb = new StringBuilder("Estado actual de la cola de prioridad:\n");
            foreach (var e in elementos)
            {
                sb.AppendLine(e.ToString());
            }
            return sb.ToString();
        }
    }
}
