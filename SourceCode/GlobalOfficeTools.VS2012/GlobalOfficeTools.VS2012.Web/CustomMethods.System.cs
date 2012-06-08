using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GlobalOfficeTools.VS2012.Web
{
    public partial class GlobalOfficeToolsDomainService
    {
        public IQueryable<SYStblOption> GetOptions(string optionsType, int objectId)
        {
            return from x in this.ObjectContext.SYStblOptions
                   where
                    x.OptionType.Equals(optionsType) &&
                    x.ObjectId == objectId
                   select x;
        }

        public IQueryable<SYStblMenu> ListCompanyMenu(int companyId)
        {
            // TODO [2012/06/03]: at this point we have only one menu for all companyes. In the future should be a Menu defined for each Company and for each segment of business
            return from x in this.ObjectContext.SYStblMenus
                   where x.ParentMenuId == -1
                   orderby x.MenuOrder
                   select x;
        }
    }
}