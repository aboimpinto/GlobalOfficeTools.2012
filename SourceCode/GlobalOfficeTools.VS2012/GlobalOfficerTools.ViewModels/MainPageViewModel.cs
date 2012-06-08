using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using GalaSoft.MvvmLight.Command;
using GlobalOfficeTools.Globals;
using GlobalOfficeTools.Interfaces.Models;
using GlobalOfficeTools.Interfaces.ViewModels;
using GlobalOfficeTools.VS2012.Web;
using IMAGO.MvvmLib;
using IMAGO.MvvmLocator;

namespace GlobalOfficerTools.ViewModels
{
    [ExportViewModel("IMainPageViewModel")]
    public class MainPageViewModel : IMAGOViewModelBase, IMainPageViewModel
    {
        #region Private Fields 
        private IClientModel _clientModel;
        private ISystemModel _systemModel;
        private IGlobals _globals;

        private string _userName;
        private string _password;

        private string _softwareVersion;
        private string _loginUserName;
        private CLItblCompany _activeCompany;

        private bool _loginBoxVisibility;
        private bool _userDetailBoxVisibility;
        private bool _errorMessageVisibility;

        private bool _menuVisibility;
        private IEnumerable<SYStblMenu> _customMenu;
        #endregion

        #region Constructor 
        [ImportingConstructor]
        public MainPageViewModel(
            [Import(typeof(IClientModel))] IClientModel clientModel, 
            [Import(typeof(ISystemModel))] ISystemModel systemModel, 
            [Import(typeof(IGlobals))] IGlobals globals) 
        {
            _clientModel = clientModel;
            _systemModel = systemModel;
            _globals = globals;

            this.LoginBoxVisibility = true;
            this.UserDetailsBoxVisibility = false;
            this.ErrorMessageVisibility = false;

            LoginCommand = new RelayCommand(LoginCommandAction);

            this.UserName = "esqueleto";

            this.MenuItemCommand = new RelayCommand<SYStblMenu>((menuItemClicked) =>
            {
                switch (menuItemClicked.Action)
                {
                    case "VIEW":
                        this.NavigateView(menuItemClicked.ActionObject, menuItemClicked.Name);
                        break;
                    case "DIALOG":
                        break;
                    default:
                        throw new Exception(string.Format("Don't know what to do with the navigation action {0} ", menuItemClicked.Action));
                }
            });
        }
        #endregion

        #region IMainPageViewModel Implementation 
        public string UserName 
        {
            get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged(() => UserName);
            }
        }
        public string Password 
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged(() => Password);
            }
        }

        public string SoftwareVersion 
        {
            get { return _softwareVersion; }
            set
            {
                _softwareVersion = value;
                RaisePropertyChanged(() => _softwareVersion);
            }
        }
        public string LoginUserName 
        {
            get { return _loginUserName; }
            set
            {
                _loginUserName = value;
                RaisePropertyChanged(() => LoginUserName);
            }
        }
        public CLItblCompany ActiveCompany 
        {
            get { return _activeCompany; }
            set
            {
                _activeCompany = value;
                RaisePropertyChanged(() => ActiveCompany);
            }
        }

        public bool LoginBoxVisibility 
        {
            get { return _loginBoxVisibility; }
            set
            {
                _loginBoxVisibility = value;
                RaisePropertyChanged(() => LoginBoxVisibility);
            }
        }
        public bool UserDetailsBoxVisibility 
        {
            get { return _userDetailBoxVisibility; }
            set
            {
                _userDetailBoxVisibility = value;
                RaisePropertyChanged(() => UserDetailsBoxVisibility);
            }

        }
        public bool ErrorMessageVisibility 
        {
            get { return _errorMessageVisibility; }
            set
            {
                _errorMessageVisibility = value;
                RaisePropertyChanged(() => ErrorMessageVisibility);
            }
        }

        public RelayCommand LoginCommand { get; private set; }

        public bool MenuVisibility 
        {
            get { return _menuVisibility; }
            set
            {
                _menuVisibility = value;
                RaisePropertyChanged(() => MenuVisibility);
            }
        }
        public IEnumerable<SYStblMenu> CustomMenu 
        {
            get { return _customMenu; }
            set
            {
                _customMenu = value;
                RaisePropertyChanged(() => CustomMenu);
            }
        }
        public RelayCommand<SYStblMenu> MenuItemCommand { get; private set; }
        #endregion

        #region Private Methods 
        private void LoginCommandAction() 
        {
            if (string.IsNullOrEmpty(this.UserName) || string.IsNullOrEmpty(this.Password))
            {
                this.ErrorMessageVisibility = true;
            }
            else
            {
                SubscribeIsBusyAction(callback =>
                {
                    _clientModel.AuthenticateUser(this.UserName, this.Password, result =>
                    {
                        if (result == null) this.ErrorMessageVisibility = true;
                        else
                        {
                            _globals.ConnectedUser = result;
                            this.LoginUserName = _globals.ConnectedUser.FullName;

                            _systemModel.ListUserOptions(_globals.ConnectedUser, resultUserOptions =>
                            {
                                _globals.UserOptions = resultUserOptions;
                                // load the companies
                                _clientModel.ListUserCompanies(_globals.ConnectedUser, resultUserCompanies =>
                                {
                                    _globals.UserCompanies = resultUserCompanies;
                                    this.ActiveCompany = _globals.CompanySelected = (from x in _globals.UserCompanies
                                                                                     where x.CompanyId == int.Parse(_globals.GetUserOption("DefaultCompanyId").OptionValue)
                                                                                     select x).FirstOrDefault();

                                    if (_globals.CompanySelected == null)
                                    {
                                        // TODO : do something here. This error should never happen
                                        throw new Exception("The company selected does not exist in the database, please contact the system administrator.");
                                    }
                                    else
                                    {
                                        _systemModel.ListCompanyOptions(_globals.CompanySelected, resultCompanyOptions =>
                                        {
                                            _globals.CompanyOptions = resultCompanyOptions;

                                            this.ErrorMessageVisibility = false;
                                            this.LoginBoxVisibility = false;
                                            this.UserDetailsBoxVisibility = true;

                                            // Get the Menu For the Company
                                            _systemModel.ListCompanyMenu(_globals.CompanySelected, resultMenu =>
                                            {
                                                this.CustomMenu = resultMenu;
                                                this.MenuVisibility = true;
                                                callback();
                                            });
                                        });
                                    }
                                });
                            });
                        }
                    });
                });
            }
        } 
        #endregion
    }
}
