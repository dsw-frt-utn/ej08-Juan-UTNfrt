using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int cantidad = 0;

            void ProcesarNota(int? nota)
            {
                if (nota.HasValue && nota.Value >= 0 && nota.Value <= 10)
                {
                    suma += nota.Value;
                    cantidad++;
                }
            }

            ProcesarNota(nota1);
            ProcesarNota(nota2);
            ProcesarNota(nota3);

            if(cantidad == 0)
            {
                return 0;
            }
            
            return (double)suma /  cantidad;
        }
    }
}
