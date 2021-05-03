using System;
using System.Collections.Generic;
using System.Text;

namespace TaxPayersExercice.Entities
{
    abstract class Taxpayer
    {
        public string Name { get; protected set; }
        public double AnualIncome { get; protected set; }

        protected Taxpayer()
        {
        }

        protected Taxpayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();
    }
}
