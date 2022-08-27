namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        #region Fields

        private readonly string _mailFrom = string.Empty;
        private readonly string _mailTo = string.Empty;

        #endregion Fields

        #region Constructors

        public LocalMailService(IConfiguration configuration)
        {
            _mailFrom = configuration["mailSettings:mailToAddress"];
            _mailTo = configuration["mailSettings:mailFromAddress"];
        }

        #endregion Constructors

        #region Methods

        public void Send(string subject, string message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                $"with {nameof(LocalMailService)}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }

        #endregion Methods
    }
}