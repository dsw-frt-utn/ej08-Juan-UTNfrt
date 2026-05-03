using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int valorCopia = originalValue;

            valorCopia++;
            Product productRef = product;
            productRef.Update("Nueva Descripcion de prueba");

            return $"{originalValue}-{valorCopia}-{product.GetDescription()}";

        }
    }
}
