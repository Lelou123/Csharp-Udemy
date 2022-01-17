using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosAbstratosFixacao.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }
        

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            
            if (AnualIncome < 20000.00 && AnualIncome > 0.0)
            {
                if(HealthExpenditures > 0)
                {
                    return (AnualIncome * 0.15) - (HealthExpenditures * 0.5);
                }
                else
                {
                    return AnualIncome * 0.15;
                }
            }
            else 
            {
                if (HealthExpenditures > 0)
                {
                    return (AnualIncome * 0.25) - (HealthExpenditures * 0.5);
                }
                else
                {
                    return AnualIncome * 0.25;
                }
            }
        }
    }
}
