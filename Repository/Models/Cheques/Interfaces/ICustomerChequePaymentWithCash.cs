namespace Repository.Models.Cheques.Interfaces
{
    public interface ICustomerChequePaymentWithCash
    {
        string Advertisement { get; set; }
        decimal AmountGiven { get; set; }
        decimal Change { get; set; }
        string MethodOfPayment { get; set; }

        void PrintCustomerChequeToTxtFile(string customerChequeFilePath);
    }
}