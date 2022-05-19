namespace Repository.Models.Cheques
{
    public class CustomerCheque : Cheque
    {
        public CustomerCheque(string companyName, int legalEntityCode, string address, string vATRegistrationNumber, string billingType, int chequeNumber, double totalAmount) : base(companyName, legalEntityCode, address, vATRegistrationNumber, billingType, chequeNumber, totalAmount)
        {
        }
    }
}
