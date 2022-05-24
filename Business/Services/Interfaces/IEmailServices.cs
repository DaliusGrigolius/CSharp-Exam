namespace Business.Services.Interfaces
{
    public interface IEmailServices
    {
        void SendChequeViaEmail(string emailAddress);
    }
}