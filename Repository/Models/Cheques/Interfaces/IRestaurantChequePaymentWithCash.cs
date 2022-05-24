namespace Repository.Models.Cheques.Interfaces
{
    public interface IRestaurantChequePaymentWithCash
    {
        decimal Change { get; set; }
        public decimal AmountGiven { get; set; }
        string MethodOfPayment { get; set; }

        void PrintRestaurantChequeToTxtFile(string customerChequeFilePath);
    }
}