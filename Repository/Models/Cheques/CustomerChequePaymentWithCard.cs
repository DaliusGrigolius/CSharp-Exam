using Repository.Models.Cheques.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Repository.Models.Cheques
{
    public class CustomerChequePaymentWithCard : Cheque, ICustomerChequePaymentWithCard
    {
        public string MethodOfPayment { get; set; }
        public string Advertisement { get; set; }

        public CustomerChequePaymentWithCard(string companyName, int legalEntityCode, string address, string vATRegistrationNumber, DateTime printTime, List<OrderProduct> orderedProductsList, decimal amountToPay, string methodOfPayment, string servicedPerson, string advertisement)
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
            Advertisement = advertisement;
        }

        public void PrintCustomerChequeToTxtFile(string customerChequeFilePath)
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
            text += $"\r\nTOTAL: {AmountToPay}Eu\r\n{MethodOfPayment}\r\n\r\nWaiter/Waitress: {ServicedPerson}\r\n---------------------------------------\r\n{Advertisement}\r\n";

            File.WriteAllText(customerChequeFilePath, text);
        }
    }
}
