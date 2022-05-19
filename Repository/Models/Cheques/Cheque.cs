namespace Repository.Models.Cheques
{
    public abstract class Cheque
    {
        public string CompanyName { get; set; }
        public int LegalEntityCode { get; set; }
        public string Address { get; set; }
        public string VATRegistrationNumber { get; set; }
        public string BillingType { get; set; }
        public int ChequeNumber { get; set; }
        public double TotalAmount { get; set; }

        public Cheque(string companyName, int legalEntityCode, string address, string vATRegistrationNumber, string billingType, int chequeNumber, double totalAmount)
        {
            CompanyName = companyName;
            LegalEntityCode = legalEntityCode;
            Address = address;
            VATRegistrationNumber = vATRegistrationNumber;
            BillingType = billingType;
            ChequeNumber = chequeNumber;
            TotalAmount = totalAmount;
        }
    }
}
