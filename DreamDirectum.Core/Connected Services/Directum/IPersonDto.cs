﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 05.01.2024 23:02:18
namespace Sungero.IntegrationService.Models.Generated.Parties
{
    /// <summary>
    /// There are no comments for IPersonDtoSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("IPersonDtoSingle")]
    public partial class IPersonDtoSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<IPersonDto>
    {
        /// <summary>
        /// Initialize a new IPersonDtoSingle object.
        /// </summary>
        public IPersonDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new IPersonDtoSingle object.
        /// </summary>
        public IPersonDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new IPersonDtoSingle object.
        /// </summary>
        public IPersonDtoSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<IPersonDto> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Citizenship in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Citizenship")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDtoSingle Citizenship
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Citizenship == null))
                {
                    this._Citizenship = new global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDtoSingle(this.Context, GetPath("Citizenship"));
                }
                return this._Citizenship;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDtoSingle _Citizenship;
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
        /// There are no comments for Responsible in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Responsible")]
        public virtual global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle Responsible
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Responsible == null))
                {
                    this._Responsible = new global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle(this.Context, GetPath("Responsible"));
                }
                return this._Responsible;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle _Responsible;
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
    /// There are no comments for IPersonDto in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("IPersonDto")]
    public partial class IPersonDto : ICounterpartyDto
    {
        /// <summary>
        /// Create a new IPersonDto object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static IPersonDto CreateIPersonDto(long ID)
        {
            IPersonDto iPersonDto = new IPersonDto();
            iPersonDto.Id = ID;
            return iPersonDto;
        }
        /// <summary>
        /// There are no comments for Property LastName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("LastName")]
        public virtual string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this.OnLastNameChanging(value);
                this._LastName = value;
                this.OnLastNameChanged();
                this.OnPropertyChanged("LastName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _LastName;
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        /// <summary>
        /// There are no comments for Property FirstName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FirstName")]
        public virtual string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this.OnFirstNameChanging(value);
                this._FirstName = value;
                this.OnFirstNameChanged();
                this.OnPropertyChanged("FirstName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FirstName;
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        /// <summary>
        /// There are no comments for Property MiddleName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("MiddleName")]
        public virtual string MiddleName
        {
            get
            {
                return this._MiddleName;
            }
            set
            {
                this.OnMiddleNameChanging(value);
                this._MiddleName = value;
                this.OnMiddleNameChanged();
                this.OnPropertyChanged("MiddleName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _MiddleName;
        partial void OnMiddleNameChanging(string value);
        partial void OnMiddleNameChanged();
        /// <summary>
        /// There are no comments for Property DateOfBirth in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("DateOfBirth")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> DateOfBirth
        {
            get
            {
                return this._DateOfBirth;
            }
            set
            {
                this.OnDateOfBirthChanging(value);
                this._DateOfBirth = value;
                this.OnDateOfBirthChanged();
                this.OnPropertyChanged("DateOfBirth");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _DateOfBirth;
        partial void OnDateOfBirthChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnDateOfBirthChanged();
        /// <summary>
        /// There are no comments for Property INILA in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("INILA")]
        public virtual string INILA
        {
            get
            {
                return this._INILA;
            }
            set
            {
                this.OnINILAChanging(value);
                this._INILA = value;
                this.OnINILAChanged();
                this.OnPropertyChanged("INILA");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _INILA;
        partial void OnINILAChanging(string value);
        partial void OnINILAChanged();
        /// <summary>
        /// There are no comments for Property ShortName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ShortName")]
        public virtual string ShortName
        {
            get
            {
                return this._ShortName;
            }
            set
            {
                this.OnShortNameChanging(value);
                this._ShortName = value;
                this.OnShortNameChanged();
                this.OnPropertyChanged("ShortName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ShortName;
        partial void OnShortNameChanging(string value);
        partial void OnShortNameChanged();
        /// <summary>
        /// There are no comments for Property Sex in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Sex")]
        public virtual string Sex
        {
            get
            {
                return this._Sex;
            }
            set
            {
                this.OnSexChanging(value);
                this._Sex = value;
                this.OnSexChanged();
                this.OnPropertyChanged("Sex");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Sex;
        partial void OnSexChanging(string value);
        partial void OnSexChanged();
        /// <summary>
        /// There are no comments for Property Citizenship in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Citizenship")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDto Citizenship
        {
            get
            {
                return this._Citizenship;
            }
            set
            {
                this.OnCitizenshipChanging(value);
                this._Citizenship = value;
                this.OnCitizenshipChanged();
                this.OnPropertyChanged("Citizenship");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDto _Citizenship;
        partial void OnCitizenshipChanging(global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDto value);
        partial void OnCitizenshipChanged();
    }
}
