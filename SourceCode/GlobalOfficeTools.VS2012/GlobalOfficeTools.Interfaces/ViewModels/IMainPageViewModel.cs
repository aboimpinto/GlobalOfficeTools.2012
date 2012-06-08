using System.Collections.Generic;
using GalaSoft.MvvmLight.Command;
using GlobalOfficeTools.VS2012.Web;

namespace GlobalOfficeTools.Interfaces.ViewModels
{
    public interface IMainPageViewModel
    {
        string UserName { get; set; }
        string Password { get; set; }

        string SoftwareVersion { get; set; }
        string LoginUserName { get; set; }
        CLItblCompany ActiveCompany { get; set; }

        bool LoginBoxVisibility { get; set; }
        bool UserDetailsBoxVisibility { get; set; }
        bool ErrorMessageVisibility { get; set; }

        RelayCommand LoginCommand { get; }

        bool MenuVisibility { get; set; }
        IEnumerable<SYStblMenu> CustomMenu { get; set; }
        RelayCommand<SYStblMenu> MenuItemCommand { get; }
    }
}
