using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using GlobalOfficeTools.Globals;
using GlobalOfficeTools.Interfaces.Models;
using GlobalOfficeTools.VS2012.Web;

namespace GlobalOfficeTools.Models
{
    [Export(typeof(ISystemModel))]
    public class SystemModel : ISystemModel
    {
        #region Private Fields
        private IGlobals _globals;
        #endregion

        #region Constructor
        [ImportingConstructor]
        public SystemModel([Import(typeof(IGlobals))] IGlobals globals)
        {
            _globals = globals;
        }
        #endregion

        #region ISystemModel Implementation
        public void ListUserOptions(CLItblUser user, Action<IEnumerable<SYStblOption>> callBack)
        {
            _globals.CurrentContext.Load(_globals.CurrentContext.GetOptionsQuery("USER", user.UserId), loadOp => { callBack(loadOp.Entities); }, null);
        }
        public void ListCompanyOptions(CLItblCompany company, Action<IEnumerable<SYStblOption>> callBack)
        {
            _globals.CurrentContext.Load(_globals.CurrentContext.GetOptionsQuery("COMPANY", company.CompanyId), loadOp => { callBack(loadOp.Entities); }, null);
        }

        public void ListCompanyMenu(CLItblCompany company, Action<IEnumerable<SYStblMenu>> callBack)
        {
            _globals.CurrentContext.Load(_globals.CurrentContext.ListCompanyMenuQuery(company.CompanyId), loadOp => { callBack(loadOp.Entities); }, null);
        }
        #endregion
    }
}
