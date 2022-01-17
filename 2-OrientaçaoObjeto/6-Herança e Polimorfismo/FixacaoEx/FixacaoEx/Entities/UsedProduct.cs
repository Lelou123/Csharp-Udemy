using System;
using System.Globalization;

namespace FixacaoEx.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufacturedDate { get; set; }
        public UsedProduct()
        {

        }

        public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
        {
            ManufacturedDate = manufacturedDate;
        }

        public override string priceTag()
        {
            return
                Name
                + " (used) $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufactured date: "
                + ManufacturedDate.ToShortDateString()
            +" )";
        }
    }
}
