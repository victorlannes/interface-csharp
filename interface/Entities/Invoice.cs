using System.Globalization;

namespace curso.Entities
{
     class Invoice {

        public double BasicPaymanet { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPaymanet, double tax) {
            BasicPaymanet = basicPaymanet;
            Tax = tax;
        }

        public double TotalPayment {
            get { return BasicPaymanet + Tax; }
        }

        public override string ToString() {
            return "Basic payment: " + BasicPaymanet.ToString("F2", CultureInfo.InvariantCulture) + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture) + "\nTotal payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
