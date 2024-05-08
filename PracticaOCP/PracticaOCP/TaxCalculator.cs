using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaOCP
{
    public abstract class TaxCalculator
    {
       
        public abstract decimal CalculateTax();

    }

    public class TaxIndia : TaxCalculator
    {
        public decimal TaxAmount = 10;
        public decimal TaxeableIncome = 0;
        public decimal income = 0;
        public decimal deduction = 30;
        public override decimal CalculateTax()
        {
            TaxeableIncome = income - deduction;
            TaxAmount = TaxeableIncome * 1.07;
            return TaxAmount;
        }
    }

    public class TaxUSA: TaxCalculator
    {

        public override decimal CalculateTax()
        {
            throw new NotImplementedException();
        }
    }

    public class TaxUK : TaxCalculator
    {

        public override decimal CalculateTax()
        {
            throw new NotImplementedException();
        }
    }
}


