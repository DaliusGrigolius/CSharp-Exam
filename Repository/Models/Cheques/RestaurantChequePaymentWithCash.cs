using Repository.Models.Cheques.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Repository.Models.Cheques
{
    public class RestaurantChequePaymentWithCash : Cheque, IRestaurantChequePaymentWithCash
    {
        public string MethodOfPayment { get; set; }
        public decimal AmountGiven { get; set; }
        public decimal Change { get; set; }

        public RestaurantChequePaymentWithCash(string companyName, int legalEntityCode, string address, string vATRegistrationNumber, DateTime printTime, List<OrderProduct> orderedProductsList, decimal amountToPay, string methodOfPayment, string servicedPerson, decimal change, decimal amountGiven)
        {
            CompanyName = companyName;
            LegalEntityCode = legalEntityCode;
            Address = address;
            VATRegistrationNumber = vATRegistrationNumber;
            PrintTime = printTime;
            OrderedProductsList = orderedProductsList;
            AmountToPay = amountToPay;
            MethodOfPayment = methodOfPayment;
            ServicedPerson = servicedPerson;
            Change = change;
            AmountGiven = amountGiven;
        }

        public void PrintRestaurantChequeToTxtFile(string customerChequeFilePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(customerChequeFilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(customerChequeFilePath));
            }

            string text = $"{CompanyName}\r\nPVM: {LegalEntityCode}\r\n{Address}\r\n{VATRegistrationNumber}\r\n{PrintTime}\r\n\r\nProducts List:\r\n\r\n";

            foreach (var x in OrderedProductsList)
            {
                text += $"\"{x.Product.Name}\" {x.Product.CurrentPrice}Eu X {x.Quantity}\r\n";
            }
            text += $"\r\nTOTAL: {AmountToPay}Eu\r\n{MethodOfPayment}\r\nAmount given: {AmountGiven}\r\nChange: {Change}Eu\r\n\r\nWaiter/Waitress: {ServicedPerson}\r\n---------------------------------------\r\n";

            File.WriteAllText(customerChequeFilePath, text);
        }
    }
}
