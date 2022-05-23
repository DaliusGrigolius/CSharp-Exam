using System;
using System.Collections.Generic;

namespace Repository.Models.Cheques
{
    public class ChequePaymentWithCard : Cheque
    {
        public string MethodOfPayment { get; set; }

        public ChequePaymentWithCard(string companyName, int legalEntityCode, string address, string vATRegistrationNumber, DateTime printTime, List<OrderProduct> orderedProductsList, decimal amountToPay, string methodOfPayment, string servicedPerson)
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
        }
    }
}
