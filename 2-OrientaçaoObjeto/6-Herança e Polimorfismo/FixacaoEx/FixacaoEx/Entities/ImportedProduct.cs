using System.Globalization;

namespace FixacaoEx.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFees { get; set; }
        
        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFees) : base(name, price)
        {
            CustomFees = customFees;
        }
        
        public double TotalPrice()
        {
            return CustomFees + Price;
        }

        public override string priceTag()
        {
            return Name
                + " $ "
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " (Custom Fees: $ "
                + CustomFees.ToString("F2", CultureInfo.InvariantCulture)
                + " )";
        }
    }
}
