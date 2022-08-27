namespace CityInfo.API.Services
{
    public interface IMailService
    {
        #region Methods

        void Send(string subject, string message);

        #endregion Methods
    }
}