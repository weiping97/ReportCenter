using ReportCenter.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace ReportCenter.API
{
    public interface IAPIHelper
    {
        HttpClient ApiClient { get; }

        Task<AuthenticatedUser> AuthenticateUser(string username, string password);
        Task GetLoggedInUserInfo(string token);
        void InitializeClient();
    }
}