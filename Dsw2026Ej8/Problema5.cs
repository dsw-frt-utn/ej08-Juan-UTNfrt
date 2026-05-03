using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal amount;

        public decimal GetAmount()
        {
            return amount;
        }

        public void SetAmount(decimal amount)
        {
            this.amount = amount;
        }

        public virtual decimal CalculateTotal()
        {
            return amount;
        }
    }

    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return GetAmount();
        }
    }

    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return GetAmount() * 0.90m;
        }
    }

    public class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {
            return sale.CalculateTotal();
        }
    }
}
