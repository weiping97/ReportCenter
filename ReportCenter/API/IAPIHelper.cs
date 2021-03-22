using ReportCenter.Models;
using System.Threading.Tasks;

namespace ReportCenter.API
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> AuthenticateUser(string username, string password);
        Task GetLoggedInUserInfo(string token);
        void InitializeClient();
    }
}