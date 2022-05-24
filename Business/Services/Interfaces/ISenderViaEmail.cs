namespace Business.Services.Interfaces
{
    public interface ISenderViaEmail
    {
        void SendChequeViaEmail(string emailAddress);
    }
}