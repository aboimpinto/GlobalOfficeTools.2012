using System.Linq;
using System.ComponentModel.Composition;
using System.Collections.Generic;
using GlobalOfficeTools.VS2012.Web;

namespace GlobalOfficeTools.Globals
{
    [Export(typeof(IGlobals))]
    [PartCreationPolicy(CreationPolicy.Shared)] 
    public class Globals : IGlobals
    {
        #region Constructor 
        public Globals()
        {
            // initialize some objects
            //this.CurrentContext = new YPADomainContext();
            this.CurrentContext = new GlobalOfficeToolsDomainContext();
        }
        #endregion

        #region IGlobals Implementation 
        public GlobalOfficeToolsDomainContext CurrentContext { get; set; }
        public CLItblUser ConnectedUser { get; set; }
        //public CLItblUserOption UserOptions { get; set; }
        public IEnumerable<CLItblCompany> UserCompanies { get; set; }
        public IEnumerable<SYStblOption> UserOptions { get; set; }
        public IEnumerable<SYStblOption> CompanyOptions { get; set; }

        public CLItblCompany CompanySelected { get; set; }

        public SYStblOption GetUserOption(string key)
        {
            return (from x in this.UserOptions
                    where x.OptionKey == key
                    select x).FirstOrDefault();
        }
        public SYStblOption GetCompanyOption(string key)
        {
            return (from x in this.CompanyOptions
                    where x.OptionKey == key
                    select x).FirstOrDefault();
        }
        #endregion
    }
}
