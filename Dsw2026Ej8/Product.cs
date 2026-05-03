using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Product
    {
        private long code;
        private string description;
        private bool active;
        private double price;
        private float tax = 0.21f;
        private int stock;
        private char presentation;
        private DateTime date;
        private bool internalUse;


        public Product(long code, string description, double price, char presentation)
        {

            this.code = code;
            this.description = description;
            this.price = price;

            if (presentation == 'I' || presentation == 'S' || presentation == 'K' || presentation == 'E' || presentation == 'P')
            {
                this.presentation = presentation;
            }
            else
            {
                this.presentation = 'I';
            }

            this.active = true;
            this.internalUse = false;
            this.date = DateTime.Now;
        }

        public long GetCode()
        {
            return code;
        }
        public string GetDescription()
        {
            return description;
        }
        public bool GetActive()
        {
            return active;
        }
        public double GetPrice()
        {
            return price;
        }
        public float GetTax()
        {
            return tax;
        }
        public int GetStock()
        {
            return stock;
        }
        public char GetPresentation()
        {
            return presentation;
        }
        public DateTime GetDate()
        {
            return date;
        }
        public bool GetInternal()
        {
            return internalUse;
        }

        public void SetInternal(bool isInternal)
        {
            this.internalUse = isInternal;
        }
        public void SetTax(float newTax)
        {
            this.tax = newTax;
        }

        public void Deactivate()
        {
            this.active = false;
        }

        public double GetFinalPrice()
        {
            return price + (price * tax);
        }

        public string GetDetailedInfo()
        {
            string stockMessage;

            if (active && stock > 0)
            {
                stockMessage = "Disponible";
            }
            else if (!active)
            {
                stockMessage = "No Disponible";
            }
            else
            {
                stockMessage = "No hay Stock";
            }

            return $"[{code}] {description} [{presentation}]: {GetFinalPrice():C} {stockMessage}";
        }

        public void IncreaseStock() => stock++;
        public void DecreaseStock()
        {
            if (stock > 0)
            {
                stock--;
            }
        }

        public void IncreaseStock(int amount)
        {
            stock += amount;
        }

        public double GetPricePerFraction(int fractions)
        {
            if (presentation == 'K' && fractions > 0)
            {
                return price / fractions;
            }
            return 0;
        }

        public string GetPackaging()
        {
            switch (presentation)
            {
                case 'I': return "Envase Individual";
                case 'S': return "Empaque Secundario";
                case 'K': return "Pack";
                case 'E': return "Eco-friendly";
                case 'P': return "Premium";
                default: return "Desconocido";
            }
        }


        public void Update(string description, double price = 0, float tax = 0.21f)
        {
            this.description = description;
            if (price != 0)
            {
                this.price = price;
            }

            if (this.tax != tax)
            {
                this.tax = tax;
            }
        }
    }
}
