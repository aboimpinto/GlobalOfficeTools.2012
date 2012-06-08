using System.Collections.Generic;
using GlobalOfficeTools.VS2012.Web;

namespace GlobalOfficeTools.Globals
{
    public interface IGlobals
    {
        GlobalOfficeToolsDomainContext CurrentContext { get; set; }
        CLItblUser ConnectedUser { get; set; }
        IEnumerable<CLItblCompany> UserCompanies { get; set; }
        IEnumerable<SYStblOption> UserOptions { get; set; }
        IEnumerable<SYStblOption> CompanyOptions { get; set; }

        CLItblCompany CompanySelected { get; set; }

        SYStblOption GetUserOption(string key);
        SYStblOption GetCompanyOption(string key);
    }
}
