using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double imposto;
        public double SalarioLiquido()
        {
            return SalarioBruto - imposto;
        }
        public void AumentarSalario(double porc)
        {
            SalarioBruto = SalarioBruto +(SalarioBruto * porc / 100);
        }

        public override string ToString()
        {
            return  Nome+ ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
