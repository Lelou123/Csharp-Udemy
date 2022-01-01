using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    internal class Notas
    {
        public double Primeira;
        public double Segunda;
        public double Terceira;
        public string Nome;
        public double NotaFinal()
        {
            return Primeira + Segunda + Terceira;   
        }
        public bool Aprovado()
        {
            if(NotaFinal() >= 60.00)
            {
                return true;
            } 
            else return false;
        }
        public double Resultado()
        {
            if(Aprovado())
            {
                return 0.0;
            }
            else return 60.0 - NotaFinal();
        }
    }
}
