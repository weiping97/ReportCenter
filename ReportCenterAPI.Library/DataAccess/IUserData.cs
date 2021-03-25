using ReportCenterAPI.Library.Models;
using System.Collections.Generic;

namespace ReportCenterAPI.Library.DataAccess
{
    public interface IUserData
    {
        List<UserModel> GetUserById(string Id);
    }
}