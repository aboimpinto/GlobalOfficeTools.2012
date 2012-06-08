using System;
using System.Collections.Generic;
using GlobalOfficeTools.VS2012.Web;

namespace GlobalOfficeTools.Interfaces.Models
{
    public interface IClientModel
    {
        void AuthenticateUser(string userName, string password, Action<CLItblUser> callBack);
        void ListUserCompanies(CLItblUser user, Action<IEnumerable<CLItblCompany>> callBack);
    }
}
