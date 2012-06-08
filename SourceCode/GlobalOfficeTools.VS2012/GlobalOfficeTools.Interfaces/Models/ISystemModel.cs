using System;
using System.Collections.Generic;
using GlobalOfficeTools.VS2012.Web;

namespace GlobalOfficeTools.Interfaces.Models
{
    public interface ISystemModel
    {
        void ListUserOptions(CLItblUser user, Action<IEnumerable<SYStblOption>> callBack);
        void ListCompanyOptions(CLItblCompany company, Action<IEnumerable<SYStblOption>> callBack);
        void ListCompanyMenu(CLItblCompany company, Action<IEnumerable<SYStblMenu>> callBack);
    }
}
