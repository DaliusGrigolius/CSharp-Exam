namespace Repository.Models.Cheques.Interfaces
{
    public interface IFiscalCheque
    {
        string FiscalText { get; set; }

        void PrintFiscalChequeToTxtFile(string fiscalChequeFilePath);
    }
}