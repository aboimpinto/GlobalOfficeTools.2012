using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using GlobalOfficeTools.Globals;
using GlobalOfficeTools.Interfaces.Models;
using GlobalOfficeTools.VS2012.Web;

namespace GlobalOfficeTools.Models
{
    [Export(typeof(IClientModel))]
    public class ClientModel : IClientModel
    {
        #region Private Fields 
        private IGlobals _globals;
        #endregion

        #region Contructor 
        [ImportingConstructor]
        public ClientModel([Import(typeof(IGlobals))] IGlobals globals) 
        {
            _globals = globals;
        }
        #endregion

        #region IClientModel Implementation 
        public void AuthenticateUser(string userName, string password, Action<CLItblUser> callBack) 
        {
            _globals.CurrentContext.Load(_globals.CurrentContext.GetAuthenticatedUserQuery(userName, password), loadOp =>
            {
                if (loadOp.Entities.Count() == 0)
                    callBack(null);
                else
                    callBack(loadOp.Entities.FirstOrDefault());

            }, null);
        }
        public void ListUserCompanies(CLItblUser user, Action<IEnumerable<CLItblCompany>> callBack) 
        {
            _globals.CurrentContext.Load(_globals.CurrentContext.ListUserCompaniesQuery(user.UserId), loadOp =>
            {
                callBack(loadOp.Entities);
            }, null);
        }
        #endregion
    }
}
