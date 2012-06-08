
namespace GlobalOfficeTools.RIA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies CLItblAclMetadata as the class
    // that carries additional metadata for the CLItblAcl class.
    [MetadataTypeAttribute(typeof(CLItblAcl.CLItblAclMetadata))]
    public partial class CLItblAcl
    {

        // This class allows you to attach custom attributes to properties
        // of the CLItblAcl class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CLItblAclMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CLItblAclMetadata()
            {
            }

            public int AclId { get; set; }

            public int CompanyId { get; set; }

            public string Entity { get; set; }

            public Nullable<int> EntityId { get; set; }

            public string Resource { get; set; }

            public int ResourceId { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies CLItblCompanyMetadata as the class
    // that carries additional metadata for the CLItblCompany class.
    [MetadataTypeAttribute(typeof(CLItblCompany.CLItblCompanyMetadata))]
    public partial class CLItblCompany
    {

        // This class allows you to attach custom attributes to properties
        // of the CLItblCompany class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CLItblCompanyMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CLItblCompanyMetadata()
            {
            }

            public EntityCollection<CLItblCompanyUser> CLItblCompanyUsers { get; set; }

            public int CompanyId { get; set; }

            public string FullName { get; set; }

            public string ShortName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies CLItblCompanyUserMetadata as the class
    // that carries additional metadata for the CLItblCompanyUser class.
    [MetadataTypeAttribute(typeof(CLItblCompanyUser.CLItblCompanyUserMetadata))]
    public partial class CLItblCompanyUser
    {

        // This class allows you to attach custom attributes to properties
        // of the CLItblCompanyUser class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CLItblCompanyUserMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CLItblCompanyUserMetadata()
            {
            }

            public CLItblCompany CLItblCompany { get; set; }

            public CLItblUser CLItblUser { get; set; }

            public int CompanyId { get; set; }

            public int CompanyUserId { get; set; }

            public int EmployeeTypeId { get; set; }

            public int UserId { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies CLItblFederationDetailMetadata as the class
    // that carries additional metadata for the CLItblFederationDetail class.
    [MetadataTypeAttribute(typeof(CLItblFederationDetail.CLItblFederationDetailMetadata))]
    public partial class CLItblFederationDetail
    {

        // This class allows you to attach custom attributes to properties
        // of the CLItblFederationDetail class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CLItblFederationDetailMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CLItblFederationDetailMetadata()
            {
            }

            public CLItblUser CLItblUser { get; set; }

            public int FederationDetailId { get; set; }

            public string FederationId { get; set; }

            public string FederationType { get; set; }

            public string Password { get; set; }

            public int UserId { get; set; }

            public string UserName { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies CLItblReferenceMetadata as the class
    // that carries additional metadata for the CLItblReference class.
    [MetadataTypeAttribute(typeof(CLItblReference.CLItblReferenceMetadata))]
    public partial class CLItblReference
    {

        // This class allows you to attach custom attributes to properties
        // of the CLItblReference class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CLItblReferenceMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CLItblReferenceMetadata()
            {
            }

            public string Code { get; set; }

            public int CompanyId { get; set; }

            public int Id { get; set; }

            public bool IsActive { get; set; }

            public bool IsSystem { get; set; }

            public int ReferenceId { get; set; }

            public string ReferenceTable { get; set; }

            public string Value { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies CLItblUserMetadata as the class
    // that carries additional metadata for the CLItblUser class.
    [MetadataTypeAttribute(typeof(CLItblUser.CLItblUserMetadata))]
    public partial class CLItblUser
    {

        // This class allows you to attach custom attributes to properties
        // of the CLItblUser class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CLItblUserMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private CLItblUserMetadata()
            {
            }

            public EntityCollection<CLItblCompanyUser> CLItblCompanyUsers { get; set; }

            public EntityCollection<CLItblFederationDetail> CLItblFederationDetails { get; set; }

            public string FullName { get; set; }

            public bool IsActive { get; set; }

            public int UserId { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies ENTtblAddressMetadata as the class
    // that carries additional metadata for the ENTtblAddress class.
    [MetadataTypeAttribute(typeof(ENTtblAddress.ENTtblAddressMetadata))]
    public partial class ENTtblAddress
    {

        // This class allows you to attach custom attributes to properties
        // of the ENTtblAddress class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ENTtblAddressMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ENTtblAddressMetadata()
            {
            }

            public int AddressId { get; set; }

            public string AddressLineOne { get; set; }

            public string AddressLineTwo { get; set; }

            public string Country { get; set; }

            public bool IsBillingAddress { get; set; }

            public bool IsShippingAddress { get; set; }

            public string PostalCode { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies ENTtblAddressBookMetadata as the class
    // that carries additional metadata for the ENTtblAddressBook class.
    [MetadataTypeAttribute(typeof(ENTtblAddressBook.ENTtblAddressBookMetadata))]
    public partial class ENTtblAddressBook
    {

        // This class allows you to attach custom attributes to properties
        // of the ENTtblAddressBook class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ENTtblAddressBookMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ENTtblAddressBookMetadata()
            {
            }

            public int EntityAddressBookId { get; set; }

            public int EntityId { get; set; }

            public ENTtblEntity ENTtblEntity { get; set; }

            public int HierarchyId { get; set; }

            public bool IsDefault { get; set; }

            public string Reference { get; set; }

            public int ReferenceId { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies ENTtblContactMetadata as the class
    // that carries additional metadata for the ENTtblContact class.
    [MetadataTypeAttribute(typeof(ENTtblContact.ENTtblContactMetadata))]
    public partial class ENTtblContact
    {

        // This class allows you to attach custom attributes to properties
        // of the ENTtblContact class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ENTtblContactMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ENTtblContactMetadata()
            {
            }

            public int ContactId { get; set; }

            public string Type { get; set; }

            public string Value { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies ENTtblEntityMetadata as the class
    // that carries additional metadata for the ENTtblEntity class.
    [MetadataTypeAttribute(typeof(ENTtblEntity.ENTtblEntityMetadata))]
    public partial class ENTtblEntity
    {

        // This class allows you to attach custom attributes to properties
        // of the ENTtblEntity class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ENTtblEntityMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ENTtblEntityMetadata()
            {
            }

            public int EntityId { get; set; }

            public EntityCollection<ENTtblAddressBook> ENTtblAddressBooks { get; set; }

            public string Name { get; set; }

            public string ShortName { get; set; }

            public string VatNumber { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies ENTtblPersonMetadata as the class
    // that carries additional metadata for the ENTtblPerson class.
    [MetadataTypeAttribute(typeof(ENTtblPerson.ENTtblPersonMetadata))]
    public partial class ENTtblPerson
    {

        // This class allows you to attach custom attributes to properties
        // of the ENTtblPerson class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class ENTtblPersonMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private ENTtblPersonMetadata()
            {
            }

            public string Name { get; set; }

            public string Note { get; set; }

            public int PersonId { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies SYStblMenuMetadata as the class
    // that carries additional metadata for the SYStblMenu class.
    [MetadataTypeAttribute(typeof(SYStblMenu.SYStblMenuMetadata))]
    public partial class SYStblMenu
    {

        // This class allows you to attach custom attributes to properties
        // of the SYStblMenu class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class SYStblMenuMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private SYStblMenuMetadata()
            {
            }

            public string Action { get; set; }

            public string ActionObject { get; set; }

            public string ActionParameters { get; set; }

            public string Image { get; set; }

            public int MenuId { get; set; }

            public int MenuOrder { get; set; }

            public string Name { get; set; }

            public int ParentMenuId { get; set; }

            public string Text { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies SYStblNewsMessageMetadata as the class
    // that carries additional metadata for the SYStblNewsMessage class.
    [MetadataTypeAttribute(typeof(SYStblNewsMessage.SYStblNewsMessageMetadata))]
    public partial class SYStblNewsMessage
    {

        // This class allows you to attach custom attributes to properties
        // of the SYStblNewsMessage class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class SYStblNewsMessageMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private SYStblNewsMessageMetadata()
            {
            }

            public string Message { get; set; }

            public DateTime MessageDate { get; set; }

            public int NewMessageId { get; set; }

            public string Title { get; set; }

            public string Writer { get; set; }
        }
    }

    // The MetadataTypeAttribute identifies SYStblOptionMetadata as the class
    // that carries additional metadata for the SYStblOption class.
    [MetadataTypeAttribute(typeof(SYStblOption.SYStblOptionMetadata))]
    public partial class SYStblOption
    {

        // This class allows you to attach custom attributes to properties
        // of the SYStblOption class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class SYStblOptionMetadata
        {

            // Metadata classes are not meant to be instantiated.
            private SYStblOptionMetadata()
            {
            }

            public int ObjectId { get; set; }

            public int OptionId { get; set; }

            public string OptionKey { get; set; }

            public string OptionType { get; set; }

            public string OptionValue { get; set; }
        }
    }
}
