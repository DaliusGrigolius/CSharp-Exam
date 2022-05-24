namespace Repository.Models.Cheques.Interfaces
{
    public interface ICustomerChequePaymentWithCard
    {
        string Advertisement { get; set; }
        string MethodOfPayment { get; set; }

        void PrintCustomerChequeToTxtFile(string customerChequeFilePath);
    }
}