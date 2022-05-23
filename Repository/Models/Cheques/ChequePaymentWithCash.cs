using System;
using System.Collections.Generic;

namespace Repository.Models.Cheques
{
    public class ChequePaymentWithCash : Cheque
    {
        public string MethodOfPayment { get; set; }
        public decimal Change { get; set; }

        public ChequePaymentWithCash(string companyName, int legalEntityCode, string address, string vATRegistrationNumber, DateTime printTime, List<OrderProduct> orderedProductsList, decimal amountToPay, string methodOfPayment, decimal change, string servicedPerson)
        {
            CompanyName = companyName;
            LegalEntityCode = legalEntityCode;
            Address = address;
            VATRegistrationNumber = vATRegistrationNumber;
            PrintTime = printTime;
            OrderedProductsList = orderedProductsList;
            AmountToPay = amountToPay;
            MethodOfPayment = methodOfPayment;
            Change = change;
            ServicedPerson = servicedPerson;
        }
    }
}
