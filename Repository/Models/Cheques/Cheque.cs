using System;
using System.Collections.Generic;

namespace Repository.Models.Cheques
{
    public class Cheque
    {
        public string CompanyName { get; set; }
        public int LegalEntityCode { get; set; }
        public string Address { get; set; }
        public string VATRegistrationNumber { get; set; }
        public DateTime PrintTime { get; set; }
        public List<OrderProduct> OrderedProductsList { get; set; }
        public decimal AmountToPay { get; set; }
        public string ServicedPerson { get; set; }
    }
}
