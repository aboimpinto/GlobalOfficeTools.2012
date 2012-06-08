using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalOfficeTools.VS2012.Web
{
    public partial class GlobalOfficeToolsDomainService
    {
        public CLItblUser GetAuthenticatedUser(string userName, string password) 
        {
            var userAux = (from x in this.ObjectContext.CLItblFederationDetails
                           where
                             x.UserName == userName &&
                             x.FederationType == "LOCAL"
                           select new { x.CLItblUser, x.Password }).FirstOrDefault();

            //var userAux = (from x in this.ObjectContext.CLItblUsers.Include("CLItblFederationDetails").Include("CLItblUserOption")
            //               join federationDetail in this.ObjectContext.CLItblFederationDetails on x.UserId equals federationDetail.UserId
            //               where
            //                  federationDetail.FederationType == "LOCAL" &&
            //                  federationDetail.UserName == userName
            //               select new { x, x.CLItblFederationDetails.);

            // [TODO] Right now it's using Plain/Text password. Need to review this to incress security
            if (userAux.Password.Equals(password, System.StringComparison.InvariantCultureIgnoreCase))
                return userAux.CLItblUser;
            else
                return null;
        }
        public IEnumerable<CLItblCompany> ListUserCompanies(int userId) 
        {
            return from companies in this.ObjectContext.CLItblCompanies
                   join userCompanies in this.ObjectContext.CLItblCompanyUsers on companies.CompanyId equals userCompanies.CompanyId
                   where userCompanies.UserId == userId
                   select companies;
        }
    }
}