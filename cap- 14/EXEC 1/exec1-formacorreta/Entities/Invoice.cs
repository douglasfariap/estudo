using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exec1_formacorreta.Entities {
    class Invoice {
        public double basicPayment { get; set; }
        public double tax { get; set; }
        public double TotalPayment { get; set; }

        public Invoice(double basicPayment, double tax, double totalPayment)
        {
            this.basicPayment = basicPayment;
            this.tax = tax;
            TotalPayment = totalPayment;
        }
    }
}
