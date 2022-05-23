using Repository.Models;
using Repository.Models.Cheques;
using System.Collections.Generic;

namespace Repository.Serializer
{
    public interface ISerializer
    {
        void WriteChequePaymentWithCardToFile(List<ChequePaymentWithCard> chequePaymentWithCardList, string filePath);
        void WriteChequePaymentWithCashToFile(List<ChequePaymentWithCash> chequePaymentWithCashList, string filePath);
        void WriteFiscalChequeToFile(List<FiscalCheque> fiscalChequesList, string filePath);
        void WriteOrderDataToFile(List<Order> ordersList, string filePath);
    }
}