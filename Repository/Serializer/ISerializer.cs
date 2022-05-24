using Repository.Models;
using Repository.Models.Cheques;
using System.Collections.Generic;

namespace Repository.Serializer
{
    public interface ISerializer
    {
        void WriteChequePaymentWithCardToFile(List<CustomerChequePaymentWithCard> chequePaymentWithCardList, string filePath);
        void WriteChequePaymentWithCashToFile(List<CustomerChequePaymentWithCash> chequePaymentWithCashList, string filePath);
        void WriteOrderDataToFile(List<Order> ordersList, string filePath);
    }
}