namespace TaxPayersExercice.Entities
{
    class Company : Taxpayer
    {
        public int EmployeesNumber { get; set; }

        public Company(string name, double anualIncome, int employeesNumber)
            :base(name, anualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double TaxesPaid()
        {
            if(EmployeesNumber > 10)
            {
                return AnualIncome * 0.14; 
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
