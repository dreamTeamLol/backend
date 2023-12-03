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
    /// There are no comments for ICounterpartyExchangeBoxesDtoSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ICounterpartyExchangeBoxesDtoSingle")]
    public partial class ICounterpartyExchangeBoxesDtoSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<ICounterpartyExchangeBoxesDto>
    {
        /// <summary>
        /// Initialize a new ICounterpartyExchangeBoxesDtoSingle object.
        /// </summary>
        public ICounterpartyExchangeBoxesDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ICounterpartyExchangeBoxesDtoSingle object.
        /// </summary>
        public ICounterpartyExchangeBoxesDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ICounterpartyExchangeBoxesDtoSingle object.
        /// </summary>
        public ICounterpartyExchangeBoxesDtoSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<ICounterpartyExchangeBoxesDto> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Counterparty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Counterparty")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyDtoSingle Counterparty
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Counterparty == null))
                {
                    this._Counterparty = new global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyDtoSingle(this.Context, GetPath("Counterparty"));
                }
                return this._Counterparty;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyDtoSingle _Counterparty;
        /// <summary>
        /// There are no comments for Box in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Box")]
        public virtual global::Sungero.IntegrationService.Models.Generated.ExchangeCore.IBusinessUnitBoxDtoSingle Box
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Box == null))
                {
                    this._Box = new global::Sungero.IntegrationService.Models.Generated.ExchangeCore.IBusinessUnitBoxDtoSingle(this.Context, GetPath("Box"));
                }
                return this._Box;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.ExchangeCore.IBusinessUnitBoxDtoSingle _Box;
    }
    /// <summary>
    /// There are no comments for ICounterpartyExchangeBoxesDto in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("ICounterpartyExchangeBoxesDto")]
    public partial class ICounterpartyExchangeBoxesDto : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new ICounterpartyExchangeBoxesDto object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static ICounterpartyExchangeBoxesDto CreateICounterpartyExchangeBoxesDto(long ID)
        {
            ICounterpartyExchangeBoxesDto iCounterpartyExchangeBoxesDto = new ICounterpartyExchangeBoxesDto();
            iCounterpartyExchangeBoxesDto.Id = ID;
            return iCounterpartyExchangeBoxesDto;
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
        /// There are no comments for Property OrganizationId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("OrganizationId")]
        public virtual string OrganizationId
        {
            get
            {
                return this._OrganizationId;
            }
            set
            {
                this.OnOrganizationIdChanging(value);
                this._OrganizationId = value;
                this.OnOrganizationIdChanged();
                this.OnPropertyChanged("OrganizationId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _OrganizationId;
        partial void OnOrganizationIdChanging(string value);
        partial void OnOrganizationIdChanged();
        /// <summary>
        /// There are no comments for Property InvitationText in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("InvitationText")]
        public virtual string InvitationText
        {
            get
            {
                return this._InvitationText;
            }
            set
            {
                this.OnInvitationTextChanging(value);
                this._InvitationText = value;
                this.OnInvitationTextChanged();
                this.OnPropertyChanged("InvitationText");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _InvitationText;
        partial void OnInvitationTextChanging(string value);
        partial void OnInvitationTextChanged();
        /// <summary>
        /// There are no comments for Property IsDefault in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsDefault")]
        public virtual global::System.Nullable<bool> IsDefault
        {
            get
            {
                return this._IsDefault;
            }
            set
            {
                this.OnIsDefaultChanging(value);
                this._IsDefault = value;
                this.OnIsDefaultChanged();
                this.OnPropertyChanged("IsDefault");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsDefault;
        partial void OnIsDefaultChanging(global::System.Nullable<bool> value);
        partial void OnIsDefaultChanged();
        /// <summary>
        /// There are no comments for Property CounterpartyBox in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CounterpartyBox")]
        public virtual string CounterpartyBox
        {
            get
            {
                return this._CounterpartyBox;
            }
            set
            {
                this.OnCounterpartyBoxChanging(value);
                this._CounterpartyBox = value;
                this.OnCounterpartyBoxChanged();
                this.OnPropertyChanged("CounterpartyBox");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CounterpartyBox;
        partial void OnCounterpartyBoxChanging(string value);
        partial void OnCounterpartyBoxChanged();
        /// <summary>
        /// There are no comments for Property IsRoaming in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("IsRoaming")]
        public virtual global::System.Nullable<bool> IsRoaming
        {
            get
            {
                return this._IsRoaming;
            }
            set
            {
                this.OnIsRoamingChanging(value);
                this._IsRoaming = value;
                this.OnIsRoamingChanged();
                this.OnPropertyChanged("IsRoaming");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _IsRoaming;
        partial void OnIsRoamingChanging(global::System.Nullable<bool> value);
        partial void OnIsRoamingChanged();
        /// <summary>
        /// There are no comments for Property FtsId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("FtsId")]
        public virtual string FtsId
        {
            get
            {
                return this._FtsId;
            }
            set
            {
                this.OnFtsIdChanging(value);
                this._FtsId = value;
                this.OnFtsIdChanged();
                this.OnPropertyChanged("FtsId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _FtsId;
        partial void OnFtsIdChanging(string value);
        partial void OnFtsIdChanged();
        /// <summary>
        /// There are no comments for Property CounterpartyBranchId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CounterpartyBranchId")]
        public virtual string CounterpartyBranchId
        {
            get
            {
                return this._CounterpartyBranchId;
            }
            set
            {
                this.OnCounterpartyBranchIdChanging(value);
                this._CounterpartyBranchId = value;
                this.OnCounterpartyBranchIdChanged();
                this.OnPropertyChanged("CounterpartyBranchId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CounterpartyBranchId;
        partial void OnCounterpartyBranchIdChanging(string value);
        partial void OnCounterpartyBranchIdChanged();
        /// <summary>
        /// There are no comments for Property CounterpartyParentBranchId in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("CounterpartyParentBranchId")]
        public virtual string CounterpartyParentBranchId
        {
            get
            {
                return this._CounterpartyParentBranchId;
            }
            set
            {
                this.OnCounterpartyParentBranchIdChanging(value);
                this._CounterpartyParentBranchId = value;
                this.OnCounterpartyParentBranchIdChanged();
                this.OnPropertyChanged("CounterpartyParentBranchId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _CounterpartyParentBranchId;
        partial void OnCounterpartyParentBranchIdChanging(string value);
        partial void OnCounterpartyParentBranchIdChanged();
        /// <summary>
        /// There are no comments for Property Counterparty in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Counterparty")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyDto Counterparty
        {
            get
            {
                return this._Counterparty;
            }
            set
            {
                this.OnCounterpartyChanging(value);
                this._Counterparty = value;
                this.OnCounterpartyChanged();
                this.OnPropertyChanged("Counterparty");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyDto _Counterparty;
        partial void OnCounterpartyChanging(global::Sungero.IntegrationService.Models.Generated.Parties.ICounterpartyDto value);
        partial void OnCounterpartyChanged();
        /// <summary>
        /// There are no comments for Property Box in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Box")]
        public virtual global::Sungero.IntegrationService.Models.Generated.ExchangeCore.IBusinessUnitBoxDto Box
        {
            get
            {
                return this._Box;
            }
            set
            {
                this.OnBoxChanging(value);
                this._Box = value;
                this.OnBoxChanged();
                this.OnPropertyChanged("Box");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.ExchangeCore.IBusinessUnitBoxDto _Box;
        partial void OnBoxChanging(global::Sungero.IntegrationService.Models.Generated.ExchangeCore.IBusinessUnitBoxDto value);
        partial void OnBoxChanged();
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
