using System;
using System.Collections.Generic;
using System.Text;

namespace TaxPayersExercice.Entities
{
    class Individual : Taxpayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            :base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            double total;
            if (AnualIncome < 2000.00)
                total = AnualIncome * 0.15;
            else
                total = AnualIncome * 0.25;
            if (HealthExpenditures > 0)
                return total - (HealthExpenditures / 2);
            else
                return total;

        }
    }
}
