namespace Repository.Models.Cheques
{
    internal class RestaurantCheque : Cheque
    {
        public RestaurantCheque(string companyName, int legalEntityCode, string address, string vATRegistrationNumber, string billingType, int chequeNumber, double totalAmount) : base(companyName, legalEntityCode, address, vATRegistrationNumber, billingType, chequeNumber, totalAmount)
        {
        }
    }
}
