namespace Repository.Models.Cheques.Interfaces
{
    public interface IRestaurantChequePaymentWithCard
    {
        string MethodOfPayment { get; set; }

        void PrintRestaurantChequeToTxtFile(string customerChequeFilePath);
    }
}