﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 26.11.2023 2:59:27
namespace Sungero.IntegrationService.Models.Generated.Parties
{
    /// <summary>
    /// There are no comments for ICounterpartyDtoSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ICounterpartyDtoSingle")]
    public partial class ICounterpartyDtoSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ICounterpartyDto>
    {
        /// <summary>
        /// Initialize a new ICounterpartyDtoSingle object.
        /// </summary>
        public ICounterpartyDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ICounterpartyDtoSingle object.
        /// </summary>
        public ICounterpartyDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ICounterpartyDtoSingle object.
        /// </summary>
        public ICounterpartyDtoSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ICounterpartyDto> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for City in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("City")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Commons.ICityDtoSingle City
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._City == null))
                {
                    this._City = new global::Sungero.IntegrationService.Models.Generated.Commons.ICityDtoSingle(this.Context, GetPath("City"));
                }
                return this._City;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Commons.ICityDtoSingle _City;
        /// <summary>
        /// There are no comments for Region in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Region")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDtoSingle Region
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Region == null))
                {
                    this._Region = new global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDtoSingle(this.Context, GetPath("Region"));
                }
                return this._Region;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDtoSingle _Region;
        /// <summary>
        /// There are no comments for Bank in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Bank")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Parties.IBankDtoSingle Bank
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Bank == null))
                {
                    this._Bank = new global::Sungero.IntegrationService.Models.Generated.Parties.IBankDtoSingle(this.Context, GetPath("Bank"));
                }
                return this._Bank;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Parties.IBankDtoSingle _Bank;
        /// <summary>
        /// There are no comments for ExchangeBoxes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("ExchangeBoxes")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyExchangeBoxesDto> ExchangeBoxes
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._ExchangeBoxes == null))
                {
                    this._ExchangeBoxes = Context.CreateQuery<global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyExchangeBoxesDto>(GetPath("ExchangeBoxes"));
                }
                return this._ExchangeBoxes;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyExchangeBoxesDto> _ExchangeBoxes;
        /// <summary>
        /// There are no comments for Responsible in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Responsible")]
        public virtual global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDtoSingle Responsible
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Responsible == null))
                {
                    this._Responsible = new global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDtoSingle(this.Context, GetPath("Responsible"));
                }
                return this._Responsible;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDtoSingle _Responsible;
        /// <summary>
        /// There are no comments for Kind in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Kind")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyKindDtoSingle Kind
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Kind == null))
                {
                    this._Kind = new global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyKindDtoSingle(this.Context, GetPath("Kind"));
                }
                return this._Kind;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyKindDtoSingle _Kind;
    }
    /// <summary>
    /// There are no comments for ICounterpartyDto in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ICounterpartyDto")]
    public partial class ICounterpartyDto : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ICounterpartyDto object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ICounterpartyDto CreateICounterpartyDto(long ID)
        {
            ICounterpartyDto iCounterpartyDto = new ICounterpartyDto();
            iCounterpartyDto.Id = ID;
            return iCounterpartyDto;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Id is required.")]
        public virtual long Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private long _Id;
        partial void OnIdChanging(long value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Status in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Status")]
        public virtual string Status
        {
            get
            {
                return this._Status;
            }
            set
            {
                this.OnStatusChanging(value);
                this._Status = value;
                this.OnStatusChanged();
                this.OnPropertyChanged("Status");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Status;
        partial void OnStatusChanging(string value);
        partial void OnStatusChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Name")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property TIN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("TIN")]
        public virtual string TIN
        {
            get
            {
                return this._TIN;
            }
            set
            {
                this.OnTINChanging(value);
                this._TIN = value;
                this.OnTINChanged();
                this.OnPropertyChanged("TIN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _TIN;
        partial void OnTINChanging(string value);
        partial void OnTINChanged();
        /// <summary>
        /// There are no comments for Property LegalAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LegalAddress")]
        public virtual string LegalAddress
        {
            get
            {
                return this._LegalAddress;
            }
            set
            {
                this.OnLegalAddressChanging(value);
                this._LegalAddress = value;
                this.OnLegalAddressChanged();
                this.OnPropertyChanged("LegalAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LegalAddress;
        partial void OnLegalAddressChanging(string value);
        partial void OnLegalAddressChanged();
        /// <summary>
        /// There are no comments for Property PostalAddress in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PostalAddress")]
        public virtual string PostalAddress
        {
            get
            {
                return this._PostalAddress;
            }
            set
            {
                this.OnPostalAddressChanging(value);
                this._PostalAddress = value;
                this.OnPostalAddressChanged();
                this.OnPropertyChanged("PostalAddress");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PostalAddress;
        partial void OnPostalAddressChanging(string value);
        partial void OnPostalAddressChanged();
        /// <summary>
        /// There are no comments for Property Phones in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Phones")]
        public virtual string Phones
        {
            get
            {
                return this._Phones;
            }
            set
            {
                this.OnPhonesChanging(value);
                this._Phones = value;
                this.OnPhonesChanged();
                this.OnPropertyChanged("Phones");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Phones;
        partial void OnPhonesChanging(string value);
        partial void OnPhonesChanged();
        /// <summary>
        /// There are no comments for Property Email in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Email")]
        public virtual string Email
        {
            get
            {
                return this._Email;
            }
            set
            {
                this.OnEmailChanging(value);
                this._Email = value;
                this.OnEmailChanged();
                this.OnPropertyChanged("Email");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Email;
        partial void OnEmailChanging(string value);
        partial void OnEmailChanged();
        /// <summary>
        /// There are no comments for Property Homepage in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Homepage")]
        public virtual string Homepage
        {
            get
            {
                return this._Homepage;
            }
            set
            {
                this.OnHomepageChanging(value);
                this._Homepage = value;
                this.OnHomepageChanged();
                this.OnPropertyChanged("Homepage");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Homepage;
        partial void OnHomepageChanging(string value);
        partial void OnHomepageChanged();
        /// <summary>
        /// There are no comments for Property Note in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Note")]
        public virtual string Note
        {
            get
            {
                return this._Note;
            }
            set
            {
                this.OnNoteChanging(value);
                this._Note = value;
                this.OnNoteChanged();
                this.OnPropertyChanged("Note");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Note;
        partial void OnNoteChanging(string value);
        partial void OnNoteChanged();
        /// <summary>
        /// There are no comments for Property Nonresident in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Nonresident")]
        public virtual global::System.Nullable<bool> Nonresident
        {
            get
            {
                return this._Nonresident;
            }
            set
            {
                this.OnNonresidentChanging(value);
                this._Nonresident = value;
                this.OnNonresidentChanged();
                this.OnPropertyChanged("Nonresident");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _Nonresident;
        partial void OnNonresidentChanging(global::System.Nullable<bool> value);
        partial void OnNonresidentChanged();
        /// <summary>
        /// There are no comments for Property PSRN in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PSRN")]
        public virtual string PSRN
        {
            get
            {
                return this._PSRN;
            }
            set
            {
                this.OnPSRNChanging(value);
                this._PSRN = value;
                this.OnPSRNChanged();
                this.OnPropertyChanged("PSRN");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PSRN;
        partial void OnPSRNChanging(string value);
        partial void OnPSRNChanged();
        /// <summary>
        /// There are no comments for Property NCEO in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NCEO")]
        public virtual string NCEO
        {
            get
            {
                return this._NCEO;
            }
            set
            {
                this.OnNCEOChanging(value);
                this._NCEO = value;
                this.OnNCEOChanged();
                this.OnPropertyChanged("NCEO");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NCEO;
        partial void OnNCEOChanging(string value);
        partial void OnNCEOChanged();
        /// <summary>
        /// There are no comments for Property NCEA in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NCEA")]
        public virtual string NCEA
        {
            get
            {
                return this._NCEA;
            }
            set
            {
                this.OnNCEAChanging(value);
                this._NCEA = value;
                this.OnNCEAChanged();
                this.OnPropertyChanged("NCEA");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _NCEA;
        partial void OnNCEAChanging(string value);
        partial void OnNCEAChanged();
        /// <summary>
        /// There are no comments for Property Account in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Account")]
        public virtual string Account
        {
            get
            {
                return this._Account;
            }
            set
            {
                this.OnAccountChanging(value);
                this._Account = value;
                this.OnAccountChanged();
                this.OnPropertyChanged("Account");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Account;
        partial void OnAccountChanging(string value);
        partial void OnAccountChanged();
        /// <summary>
        /// There are no comments for Property CanExchange in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CanExchange")]
        public virtual global::System.Nullable<bool> CanExchange
        {
            get
            {
                return this._CanExchange;
            }
            set
            {
                this.OnCanExchangeChanging(value);
                this._CanExchange = value;
                this.OnCanExchangeChanged();
                this.OnPropertyChanged("CanExchange");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _CanExchange;
        partial void OnCanExchangeChanging(global::System.Nullable<bool> value);
        partial void OnCanExchangeChanged();
        /// <summary>
        /// There are no comments for Property Code in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Code")]
        public virtual string Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                this.OnCodeChanging(value);
                this._Code = value;
                this.OnCodeChanged();
                this.OnPropertyChanged("Code");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Code;
        partial void OnCodeChanging(string value);
        partial void OnCodeChanged();
        /// <summary>
        /// There are no comments for Property ExternalId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExternalId")]
        public virtual string ExternalId
        {
            get
            {
                return this._ExternalId;
            }
            set
            {
                this.OnExternalIdChanging(value);
                this._ExternalId = value;
                this.OnExternalIdChanged();
                this.OnPropertyChanged("ExternalId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ExternalId;
        partial void OnExternalIdChanging(string value);
        partial void OnExternalIdChanged();
        /// <summary>
        /// There are no comments for Property City in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("City")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Commons.ICityDto City
        {
            get
            {
                return this._City;
            }
            set
            {
                this.OnCityChanging(value);
                this._City = value;
                this.OnCityChanged();
                this.OnPropertyChanged("City");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Commons.ICityDto _City;
        partial void OnCityChanging(global::Sungero.IntegrationService.Models.Generated.Commons.ICityDto value);
        partial void OnCityChanged();
        /// <summary>
        /// There are no comments for Property Region in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Region")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDto Region
        {
            get
            {
                return this._Region;
            }
            set
            {
                this.OnRegionChanging(value);
                this._Region = value;
                this.OnRegionChanged();
                this.OnPropertyChanged("Region");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDto _Region;
        partial void OnRegionChanging(global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDto value);
        partial void OnRegionChanged();
        /// <summary>
        /// There are no comments for Property Bank in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Bank")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Parties.IBankDto Bank
        {
            get
            {
                return this._Bank;
            }
            set
            {
                this.OnBankChanging(value);
                this._Bank = value;
                this.OnBankChanged();
                this.OnPropertyChanged("Bank");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Parties.IBankDto _Bank;
        partial void OnBankChanging(global::Sungero.IntegrationService.Models.Generated.Parties.IBankDto value);
        partial void OnBankChanged();
        /// <summary>
        /// There are no comments for Property ExchangeBoxes in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ExchangeBoxes")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyExchangeBoxesDto> ExchangeBoxes
        {
            get
            {
                return this._ExchangeBoxes;
            }
            set
            {
                this.OnExchangeBoxesChanging(value);
                this._ExchangeBoxes = value;
                this.OnExchangeBoxesChanged();
                this.OnPropertyChanged("ExchangeBoxes");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyExchangeBoxesDto> _ExchangeBoxes = new global::Microsoft.OData.Client.DataServiceCollection<global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyExchangeBoxesDto>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnExchangeBoxesChanging(global::Microsoft.OData.Client.DataServiceCollection<global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyExchangeBoxesDto> value);
        partial void OnExchangeBoxesChanged();
        /// <summary>
        /// There are no comments for Property Responsible in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Responsible")]
        public virtual global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDto Responsible
        {
            get
            {
                return this._Responsible;
            }
            set
            {
                this.OnResponsibleChanging(value);
                this._Responsible = value;
                this.OnResponsibleChanged();
                this.OnPropertyChanged("Responsible");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDto _Responsible;
        partial void OnResponsibleChanging(global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDto value);
        partial void OnResponsibleChanged();
        /// <summary>
        /// There are no comments for Property Kind in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Kind")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyKindDto Kind
        {
            get
            {
                return this._Kind;
            }
            set
            {
                this.OnKindChanging(value);
                this._Kind = value;
                this.OnKindChanged();
                this.OnPropertyChanged("Kind");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyKindDto _Kind;
        partial void OnKindChanging(global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyKindDto value);
        partial void OnKindChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}
