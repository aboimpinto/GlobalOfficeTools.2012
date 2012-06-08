
namespace GlobalOfficeTools.VS2012.Web
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Linq;
    using System.ServiceModel.DomainServices.EntityFramework;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // Implements application logic using the dbGlobalOfficeToolsEntities2 context.
    // TODO: Add your application logic to these methods or in additional methods.
    // TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
    // Also consider adding roles to restrict access as appropriate.
    // [RequiresAuthentication]
    [EnableClientAccess()]
    public partial class GlobalOfficeToolsDomainService : LinqToEntitiesDomainService<dbGlobalOfficeToolsEntities2>
    {

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'CLItblAcls' query.
        [Query(IsDefault = true)]
        public IQueryable<CLItblAcl> GetCLItblAcls()
        {
            return this.ObjectContext.CLItblAcls;
        }

        public void InsertCLItblAcl(CLItblAcl cLItblAcl)
        {
            if ((cLItblAcl.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblAcl, EntityState.Added);
            }
            else
            {
                this.ObjectContext.CLItblAcls.AddObject(cLItblAcl);
            }
        }

        public void UpdateCLItblAcl(CLItblAcl currentCLItblAcl)
        {
            this.ObjectContext.CLItblAcls.AttachAsModified(currentCLItblAcl, this.ChangeSet.GetOriginal(currentCLItblAcl));
        }

        public void DeleteCLItblAcl(CLItblAcl cLItblAcl)
        {
            if ((cLItblAcl.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblAcl, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.CLItblAcls.Attach(cLItblAcl);
                this.ObjectContext.CLItblAcls.DeleteObject(cLItblAcl);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'CLItblCompanies' query.
        [Query(IsDefault = true)]
        public IQueryable<CLItblCompany> GetCLItblCompanies()
        {
            return this.ObjectContext.CLItblCompanies;
        }

        public void InsertCLItblCompany(CLItblCompany cLItblCompany)
        {
            if ((cLItblCompany.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblCompany, EntityState.Added);
            }
            else
            {
                this.ObjectContext.CLItblCompanies.AddObject(cLItblCompany);
            }
        }

        public void UpdateCLItblCompany(CLItblCompany currentCLItblCompany)
        {
            this.ObjectContext.CLItblCompanies.AttachAsModified(currentCLItblCompany, this.ChangeSet.GetOriginal(currentCLItblCompany));
        }

        public void DeleteCLItblCompany(CLItblCompany cLItblCompany)
        {
            if ((cLItblCompany.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblCompany, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.CLItblCompanies.Attach(cLItblCompany);
                this.ObjectContext.CLItblCompanies.DeleteObject(cLItblCompany);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'CLItblCompanyUsers' query.
        [Query(IsDefault = true)]
        public IQueryable<CLItblCompanyUser> GetCLItblCompanyUsers()
        {
            return this.ObjectContext.CLItblCompanyUsers;
        }

        public void InsertCLItblCompanyUser(CLItblCompanyUser cLItblCompanyUser)
        {
            if ((cLItblCompanyUser.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblCompanyUser, EntityState.Added);
            }
            else
            {
                this.ObjectContext.CLItblCompanyUsers.AddObject(cLItblCompanyUser);
            }
        }

        public void UpdateCLItblCompanyUser(CLItblCompanyUser currentCLItblCompanyUser)
        {
            this.ObjectContext.CLItblCompanyUsers.AttachAsModified(currentCLItblCompanyUser, this.ChangeSet.GetOriginal(currentCLItblCompanyUser));
        }

        public void DeleteCLItblCompanyUser(CLItblCompanyUser cLItblCompanyUser)
        {
            if ((cLItblCompanyUser.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblCompanyUser, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.CLItblCompanyUsers.Attach(cLItblCompanyUser);
                this.ObjectContext.CLItblCompanyUsers.DeleteObject(cLItblCompanyUser);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'CLItblFederationDetails' query.
        [Query(IsDefault = true)]
        public IQueryable<CLItblFederationDetail> GetCLItblFederationDetails()
        {
            return this.ObjectContext.CLItblFederationDetails;
        }

        public void InsertCLItblFederationDetail(CLItblFederationDetail cLItblFederationDetail)
        {
            if ((cLItblFederationDetail.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblFederationDetail, EntityState.Added);
            }
            else
            {
                this.ObjectContext.CLItblFederationDetails.AddObject(cLItblFederationDetail);
            }
        }

        public void UpdateCLItblFederationDetail(CLItblFederationDetail currentCLItblFederationDetail)
        {
            this.ObjectContext.CLItblFederationDetails.AttachAsModified(currentCLItblFederationDetail, this.ChangeSet.GetOriginal(currentCLItblFederationDetail));
        }

        public void DeleteCLItblFederationDetail(CLItblFederationDetail cLItblFederationDetail)
        {
            if ((cLItblFederationDetail.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblFederationDetail, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.CLItblFederationDetails.Attach(cLItblFederationDetail);
                this.ObjectContext.CLItblFederationDetails.DeleteObject(cLItblFederationDetail);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'CLItblReferences' query.
        [Query(IsDefault = true)]
        public IQueryable<CLItblReference> GetCLItblReferences()
        {
            return this.ObjectContext.CLItblReferences;
        }

        public void InsertCLItblReference(CLItblReference cLItblReference)
        {
            if ((cLItblReference.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblReference, EntityState.Added);
            }
            else
            {
                this.ObjectContext.CLItblReferences.AddObject(cLItblReference);
            }
        }

        public void UpdateCLItblReference(CLItblReference currentCLItblReference)
        {
            this.ObjectContext.CLItblReferences.AttachAsModified(currentCLItblReference, this.ChangeSet.GetOriginal(currentCLItblReference));
        }

        public void DeleteCLItblReference(CLItblReference cLItblReference)
        {
            if ((cLItblReference.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblReference, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.CLItblReferences.Attach(cLItblReference);
                this.ObjectContext.CLItblReferences.DeleteObject(cLItblReference);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'CLItblUsers' query.
        [Query(IsDefault = true)]
        public IQueryable<CLItblUser> GetCLItblUsers()
        {
            return this.ObjectContext.CLItblUsers;
        }

        public void InsertCLItblUser(CLItblUser cLItblUser)
        {
            if ((cLItblUser.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblUser, EntityState.Added);
            }
            else
            {
                this.ObjectContext.CLItblUsers.AddObject(cLItblUser);
            }
        }

        public void UpdateCLItblUser(CLItblUser currentCLItblUser)
        {
            this.ObjectContext.CLItblUsers.AttachAsModified(currentCLItblUser, this.ChangeSet.GetOriginal(currentCLItblUser));
        }

        public void DeleteCLItblUser(CLItblUser cLItblUser)
        {
            if ((cLItblUser.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(cLItblUser, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.CLItblUsers.Attach(cLItblUser);
                this.ObjectContext.CLItblUsers.DeleteObject(cLItblUser);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ENTtblAddresses' query.
        [Query(IsDefault = true)]
        public IQueryable<ENTtblAddress> GetENTtblAddresses()
        {
            return this.ObjectContext.ENTtblAddresses;
        }

        public void InsertENTtblAddress(ENTtblAddress eNTtblAddress)
        {
            if ((eNTtblAddress.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(eNTtblAddress, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ENTtblAddresses.AddObject(eNTtblAddress);
            }
        }

        public void UpdateENTtblAddress(ENTtblAddress currentENTtblAddress)
        {
            this.ObjectContext.ENTtblAddresses.AttachAsModified(currentENTtblAddress, this.ChangeSet.GetOriginal(currentENTtblAddress));
        }

        public void DeleteENTtblAddress(ENTtblAddress eNTtblAddress)
        {
            if ((eNTtblAddress.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(eNTtblAddress, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ENTtblAddresses.Attach(eNTtblAddress);
                this.ObjectContext.ENTtblAddresses.DeleteObject(eNTtblAddress);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ENTtblAddressBooks' query.
        [Query(IsDefault = true)]
        public IQueryable<ENTtblAddressBook> GetENTtblAddressBooks()
        {
            return this.ObjectContext.ENTtblAddressBooks;
        }

        public void InsertENTtblAddressBook(ENTtblAddressBook eNTtblAddressBook)
        {
            if ((eNTtblAddressBook.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(eNTtblAddressBook, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ENTtblAddressBooks.AddObject(eNTtblAddressBook);
            }
        }

        public void UpdateENTtblAddressBook(ENTtblAddressBook currentENTtblAddressBook)
        {
            this.ObjectContext.ENTtblAddressBooks.AttachAsModified(currentENTtblAddressBook, this.ChangeSet.GetOriginal(currentENTtblAddressBook));
        }

        public void DeleteENTtblAddressBook(ENTtblAddressBook eNTtblAddressBook)
        {
            if ((eNTtblAddressBook.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(eNTtblAddressBook, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ENTtblAddressBooks.Attach(eNTtblAddressBook);
                this.ObjectContext.ENTtblAddressBooks.DeleteObject(eNTtblAddressBook);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ENTtblContacts' query.
        [Query(IsDefault = true)]
        public IQueryable<ENTtblContact> GetENTtblContacts()
        {
            return this.ObjectContext.ENTtblContacts;
        }

        public void InsertENTtblContact(ENTtblContact eNTtblContact)
        {
            if ((eNTtblContact.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(eNTtblContact, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ENTtblContacts.AddObject(eNTtblContact);
            }
        }

        public void UpdateENTtblContact(ENTtblContact currentENTtblContact)
        {
            this.ObjectContext.ENTtblContacts.AttachAsModified(currentENTtblContact, this.ChangeSet.GetOriginal(currentENTtblContact));
        }

        public void DeleteENTtblContact(ENTtblContact eNTtblContact)
        {
            if ((eNTtblContact.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(eNTtblContact, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ENTtblContacts.Attach(eNTtblContact);
                this.ObjectContext.ENTtblContacts.DeleteObject(eNTtblContact);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ENTtblEntities' query.
        [Query(IsDefault = true)]
        public IQueryable<ENTtblEntity> GetENTtblEntities()
        {
            return this.ObjectContext.ENTtblEntities;
        }

        public void InsertENTtblEntity(ENTtblEntity eNTtblEntity)
        {
            if ((eNTtblEntity.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(eNTtblEntity, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ENTtblEntities.AddObject(eNTtblEntity);
            }
        }

        public void UpdateENTtblEntity(ENTtblEntity currentENTtblEntity)
        {
            this.ObjectContext.ENTtblEntities.AttachAsModified(currentENTtblEntity, this.ChangeSet.GetOriginal(currentENTtblEntity));
        }

        public void DeleteENTtblEntity(ENTtblEntity eNTtblEntity)
        {
            if ((eNTtblEntity.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(eNTtblEntity, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ENTtblEntities.Attach(eNTtblEntity);
                this.ObjectContext.ENTtblEntities.DeleteObject(eNTtblEntity);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'ENTtblPersons' query.
        [Query(IsDefault = true)]
        public IQueryable<ENTtblPerson> GetENTtblPersons()
        {
            return this.ObjectContext.ENTtblPersons;
        }

        public void InsertENTtblPerson(ENTtblPerson eNTtblPerson)
        {
            if ((eNTtblPerson.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(eNTtblPerson, EntityState.Added);
            }
            else
            {
                this.ObjectContext.ENTtblPersons.AddObject(eNTtblPerson);
            }
        }

        public void UpdateENTtblPerson(ENTtblPerson currentENTtblPerson)
        {
            this.ObjectContext.ENTtblPersons.AttachAsModified(currentENTtblPerson, this.ChangeSet.GetOriginal(currentENTtblPerson));
        }

        public void DeleteENTtblPerson(ENTtblPerson eNTtblPerson)
        {
            if ((eNTtblPerson.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(eNTtblPerson, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.ENTtblPersons.Attach(eNTtblPerson);
                this.ObjectContext.ENTtblPersons.DeleteObject(eNTtblPerson);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'SYStblMenus' query.
        [Query(IsDefault = true)]
        public IQueryable<SYStblMenu> GetSYStblMenus()
        {
            return this.ObjectContext.SYStblMenus;
        }

        public void InsertSYStblMenu(SYStblMenu sYStblMenu)
        {
            if ((sYStblMenu.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sYStblMenu, EntityState.Added);
            }
            else
            {
                this.ObjectContext.SYStblMenus.AddObject(sYStblMenu);
            }
        }

        public void UpdateSYStblMenu(SYStblMenu currentSYStblMenu)
        {
            this.ObjectContext.SYStblMenus.AttachAsModified(currentSYStblMenu, this.ChangeSet.GetOriginal(currentSYStblMenu));
        }

        public void DeleteSYStblMenu(SYStblMenu sYStblMenu)
        {
            if ((sYStblMenu.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sYStblMenu, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.SYStblMenus.Attach(sYStblMenu);
                this.ObjectContext.SYStblMenus.DeleteObject(sYStblMenu);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'SYStblNewsMessages' query.
        [Query(IsDefault = true)]
        public IQueryable<SYStblNewsMessage> GetSYStblNewsMessages()
        {
            return this.ObjectContext.SYStblNewsMessages;
        }

        public void InsertSYStblNewsMessage(SYStblNewsMessage sYStblNewsMessage)
        {
            if ((sYStblNewsMessage.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sYStblNewsMessage, EntityState.Added);
            }
            else
            {
                this.ObjectContext.SYStblNewsMessages.AddObject(sYStblNewsMessage);
            }
        }

        public void UpdateSYStblNewsMessage(SYStblNewsMessage currentSYStblNewsMessage)
        {
            this.ObjectContext.SYStblNewsMessages.AttachAsModified(currentSYStblNewsMessage, this.ChangeSet.GetOriginal(currentSYStblNewsMessage));
        }

        public void DeleteSYStblNewsMessage(SYStblNewsMessage sYStblNewsMessage)
        {
            if ((sYStblNewsMessage.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sYStblNewsMessage, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.SYStblNewsMessages.Attach(sYStblNewsMessage);
                this.ObjectContext.SYStblNewsMessages.DeleteObject(sYStblNewsMessage);
            }
        }

        // TODO:
        // Consider constraining the results of your query method.  If you need additional input you can
        // add parameters to this method or create additional query methods with different names.
        // To support paging you will need to add ordering to the 'SYStblOptions' query.
        [Query(IsDefault = true)]
        public IQueryable<SYStblOption> GetSYStblOptions()
        {
            return this.ObjectContext.SYStblOptions;
        }

        public void InsertSYStblOption(SYStblOption sYStblOption)
        {
            if ((sYStblOption.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sYStblOption, EntityState.Added);
            }
            else
            {
                this.ObjectContext.SYStblOptions.AddObject(sYStblOption);
            }
        }

        public void UpdateSYStblOption(SYStblOption currentSYStblOption)
        {
            this.ObjectContext.SYStblOptions.AttachAsModified(currentSYStblOption, this.ChangeSet.GetOriginal(currentSYStblOption));
        }

        public void DeleteSYStblOption(SYStblOption sYStblOption)
        {
            if ((sYStblOption.EntityState != EntityState.Detached))
            {
                this.ObjectContext.ObjectStateManager.ChangeObjectState(sYStblOption, EntityState.Deleted);
            }
            else
            {
                this.ObjectContext.SYStblOptions.Attach(sYStblOption);
                this.ObjectContext.SYStblOptions.DeleteObject(sYStblOption);
            }
        }
    }
}


