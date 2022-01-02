using System.Globalization;


namespace Depósito
{
    internal class Conta
    {
        public string Nome { get; set; }
        public double Saldo { get; private set; }
        public int NumeroConta { get; private set; }
        public Conta(int numero, string nome, double quant)
        {
            Nome = nome;
            Deposito(quant);
            NumeroConta = numero;
        }

        public void Deposito(double quantia)
        {
            Saldo = Saldo + quantia;
        }
        public void Saque(double quantia)
        {
            Saldo = (Saldo - quantia) - 5.00;
        }

        public override string ToString()
        {
            return "Conta " + NumeroConta
                + " Titular: " + Nome
                + ", Saldo: $" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
