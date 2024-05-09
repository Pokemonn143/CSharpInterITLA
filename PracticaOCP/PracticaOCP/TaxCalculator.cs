namespace PracticaOCP
{
    public abstract class TaxCalculator
    {
       
        public abstract decimal CalculateTax();

    }

    public class TaxIndia : TaxCalculator
    {
        private decimal TaxAmount = 0m;
        private decimal TaxeableIncome = 0;
        private decimal income = 0;
        private decimal deduction = 0;
        private decimal TaxRate = 1.5m;

        public  TaxIndia(decimal I, decimal D) 
        {
            this.income = I;
            this.deduction = D;
        }
        public override decimal CalculateTax()
        {
            TaxeableIncome = income - deduction;
            TaxAmount = TaxeableIncome * TaxRate;
            return TaxAmount;
        }
    }

    public class TaxUSA: TaxCalculator
    {
        private decimal TaxAmount = 0m;
        private decimal TaxeableIncome = 0;
        private decimal income = 0;
        private decimal deduction = 0;
        private decimal TaxRate = 1.9m;

        public TaxUSA(decimal I, decimal D)
        {
            this.income = I;
            this.deduction = D;
        }
        public override decimal CalculateTax()
        {
            TaxeableIncome = income - deduction;
            TaxAmount = TaxeableIncome * TaxRate;
            return TaxAmount;
        }
    }

    public class TaxUK : TaxCalculator
    {

        private decimal TaxAmount = 0m;
        private decimal TaxeableIncome = 0;
        private decimal income = 0;
        private decimal deduction = 0;
        private decimal TaxRate = 1.2m;

        public TaxUK(decimal I, decimal D)
        {
            this.income = I;
            this.deduction = D;
        }
        public override decimal CalculateTax()
        {
            TaxeableIncome = income - deduction;
            TaxAmount = TaxeableIncome * TaxRate;
            return TaxAmount;
        }
    }
}


