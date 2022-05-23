using System;
using System.Collections.Generic;
using System.IO;

namespace Repository.Models.Cheques
{
    public class FiscalCheque : Cheque
    {
        public string FiscalText { get; set; }

        public FiscalCheque(string fiscalText, string companyName, int legalEntityCode, string address, string vATRegistrationNumber, DateTime printTime, List<OrderProduct> orderedProductsList, decimal amountToPay, string servicedPerson)
        {
            FiscalText = fiscalText;
            CompanyName = companyName;
            LegalEntityCode = legalEntityCode;
            Address = address;
            VATRegistrationNumber = vATRegistrationNumber;
            PrintTime = printTime;
            OrderedProductsList = orderedProductsList;
            AmountToPay = amountToPay;
            ServicedPerson = servicedPerson;
        }

        public void PrintFiscalChequeToTxtFile(string fiscalChequeFilePath)
        {
            if (!Directory.Exists(Path.GetDirectoryName(fiscalChequeFilePath)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(fiscalChequeFilePath));
            }

            string text = $"{CompanyName}\r\nPVM: {LegalEntityCode}\r\n{Address}\r\n{VATRegistrationNumber}\r\n{PrintTime}\r\n\r\nProducts List:\r\n\r\n";

            foreach (var x in OrderedProductsList)
            {
                text += $"\"{ x.Product.Name }\" { x.Product.CurrentPrice }Eu X { x.Quantity }\r\n";
            }
            text += $"\r\nTOTAL: { AmountToPay }Eu\r\n\r\nWaiter/Waitress: { ServicedPerson }\r\n{ FiscalText }\r\n";

            File.WriteAllText(fiscalChequeFilePath, text);
        }
    }
}
