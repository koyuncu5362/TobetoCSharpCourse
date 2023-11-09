using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class LegalCustomer:Customer
    {
        public int Id { get; set; }
        public string CustomerNo { get; set; }
        public string TaxNo { get; set; }
        public string CompanyName { get; set; }
    }
}
