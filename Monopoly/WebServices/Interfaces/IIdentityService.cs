namespace Monopoly.WebServices.Interfaces
{
    using System.Threading.Tasks;
    using Monopoly.WebServices.Results;

    public interface IIdentityService
    {
        Task<AuthentificationResult> RegisterAsync(string email, string userName, string password);

        Task<AuthentificationResult> LoginAsync(string email, string password);

        Task<AuthentificationResult> RefreshTokenAsync(string token, string refreshToken);
    }
}