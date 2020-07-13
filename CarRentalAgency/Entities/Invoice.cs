using System.Globalization;

namespace CarRentalAgency.Entities
{
    class Invoice
    {
        internal double BasicPayment { get; set; }
        internal double Tax { get; set; }

        internal Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        internal double TotalPayment 
        {
            get { return BasicPayment + Tax; }    
        }

        public override string ToString()
        {
            return "Basic payment: " + BasicPayment.ToString("F2", CultureInfo.InvariantCulture) 
                + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture) 
                + "\nTotal payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
