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
namespace Sungero.IntegrationService.Models.Generated.NewDreamSolution
{
    /// <summary>
    /// There are no comments for IEmployeeDtoSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("IEmployeeDtoSingle")]
    public partial class IEmployeeDtoSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<IEmployeeDto>
    {
        /// <summary>
        /// Initialize a new IEmployeeDtoSingle object.
        /// </summary>
        public IEmployeeDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new IEmployeeDtoSingle object.
        /// </summary>
        public IEmployeeDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new IEmployeeDtoSingle object.
        /// </summary>
        public IEmployeeDtoSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<IEmployeeDto> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Person")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Parties.IPersonDtoSingle Person
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Person == null))
                {
                    this._Person = new global::Sungero.IntegrationService.Models.Generated.Parties.IPersonDtoSingle(this.Context, GetPath("Person"));
                }
                return this._Person;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Parties.IPersonDtoSingle _Person;
        /// <summary>
        /// There are no comments for Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Department")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Company.IDepartmentDtoSingle Department
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Department == null))
                {
                    this._Department = new global::Sungero.IntegrationService.Models.Generated.Company.IDepartmentDtoSingle(this.Context, GetPath("Department"));
                }
                return this._Department;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Company.IDepartmentDtoSingle _Department;
        /// <summary>
        /// There are no comments for JobTitle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("JobTitle")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Company.IJobTitleDtoSingle JobTitle
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._JobTitle == null))
                {
                    this._JobTitle = new global::Sungero.IntegrationService.Models.Generated.Company.IJobTitleDtoSingle(this.Context, GetPath("JobTitle"));
                }
                return this._JobTitle;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Company.IJobTitleDtoSingle _JobTitle;
        /// <summary>
        /// There are no comments for Login in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Login")]
        public virtual global::Sungero.IntegrationService.Models.Generated.CoreEntities.ILoginDtoSingle Login
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Login == null))
                {
                    this._Login = new global::Sungero.IntegrationService.Models.Generated.CoreEntities.ILoginDtoSingle(this.Context, GetPath("Login"));
                }
                return this._Login;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.CoreEntities.ILoginDtoSingle _Login;
        /// <summary>
        /// There are no comments for PersonalPhoto in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonalPhoto")]
        public virtual global::Sungero.IntegrationService.Generator.IBinaryObjectDtoSingle PersonalPhoto
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._PersonalPhoto == null))
                {
                    this._PersonalPhoto = new global::Sungero.IntegrationService.Generator.IBinaryObjectDtoSingle(this.Context, GetPath("PersonalPhoto"));
                }
                return this._PersonalPhoto;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Generator.IBinaryObjectDtoSingle _PersonalPhoto;
    }
    /// <summary>
    /// There are no comments for IEmployeeDto in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("IEmployeeDto")]
    public partial class IEmployeeDto : global::Sungero.IntegrationService.Models.Generated.CoreEntities.IUserDto
    {
        /// <summary>
        /// Create a new IEmployeeDto object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static IEmployeeDto CreateIEmployeeDto(long ID)
        {
            IEmployeeDto iEmployeeDto = new IEmployeeDto();
            iEmployeeDto.Id = ID;
            return iEmployeeDto;
        }
        /// <summary>
        /// There are no comments for Property Phone in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Phone")]
        public virtual string Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                this.OnPhoneChanging(value);
                this._Phone = value;
                this.OnPhoneChanged();
                this.OnPropertyChanged("Phone");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Phone;
        partial void OnPhoneChanging(string value);
        partial void OnPhoneChanged();
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
        /// There are no comments for Property NeedNotifyExpiredAssignments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NeedNotifyExpiredAssignments")]
        public virtual global::System.Nullable<bool> NeedNotifyExpiredAssignments
        {
            get
            {
                return this._NeedNotifyExpiredAssignments;
            }
            set
            {
                this.OnNeedNotifyExpiredAssignmentsChanging(value);
                this._NeedNotifyExpiredAssignments = value;
                this.OnNeedNotifyExpiredAssignmentsChanged();
                this.OnPropertyChanged("NeedNotifyExpiredAssignments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _NeedNotifyExpiredAssignments;
        partial void OnNeedNotifyExpiredAssignmentsChanging(global::System.Nullable<bool> value);
        partial void OnNeedNotifyExpiredAssignmentsChanged();
        /// <summary>
        /// There are no comments for Property NeedNotifyNewAssignments in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NeedNotifyNewAssignments")]
        public virtual global::System.Nullable<bool> NeedNotifyNewAssignments
        {
            get
            {
                return this._NeedNotifyNewAssignments;
            }
            set
            {
                this.OnNeedNotifyNewAssignmentsChanging(value);
                this._NeedNotifyNewAssignments = value;
                this.OnNeedNotifyNewAssignmentsChanged();
                this.OnPropertyChanged("NeedNotifyNewAssignments");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _NeedNotifyNewAssignments;
        partial void OnNeedNotifyNewAssignmentsChanging(global::System.Nullable<bool> value);
        partial void OnNeedNotifyNewAssignmentsChanged();
        /// <summary>
        /// There are no comments for Property PersonnelNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonnelNumber")]
        public virtual string PersonnelNumber
        {
            get
            {
                return this._PersonnelNumber;
            }
            set
            {
                this.OnPersonnelNumberChanging(value);
                this._PersonnelNumber = value;
                this.OnPersonnelNumberChanged();
                this.OnPropertyChanged("PersonnelNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonnelNumber;
        partial void OnPersonnelNumberChanging(string value);
        partial void OnPersonnelNumberChanged();
        /// <summary>
        /// There are no comments for Property NeedNotifyAssignmentsSummary in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("NeedNotifyAssignmentsSummary")]
        public virtual global::System.Nullable<bool> NeedNotifyAssignmentsSummary
        {
            get
            {
                return this._NeedNotifyAssignmentsSummary;
            }
            set
            {
                this.OnNeedNotifyAssignmentsSummaryChanging(value);
                this._NeedNotifyAssignmentsSummary = value;
                this.OnNeedNotifyAssignmentsSummaryChanged();
                this.OnPropertyChanged("NeedNotifyAssignmentsSummary");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<bool> _NeedNotifyAssignmentsSummary;
        partial void OnNeedNotifyAssignmentsSummaryChanging(global::System.Nullable<bool> value);
        partial void OnNeedNotifyAssignmentsSummaryChanged();
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
        /// There are no comments for Property Person in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Person")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Parties.IPersonDto Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this.OnPersonChanging(value);
                this._Person = value;
                this.OnPersonChanged();
                this.OnPropertyChanged("Person");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Parties.IPersonDto _Person;
        partial void OnPersonChanging(global::Sungero.IntegrationService.Models.Generated.Parties.IPersonDto value);
        partial void OnPersonChanged();
        /// <summary>
        /// There are no comments for Property Department in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Department")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Company.IDepartmentDto Department
        {
            get
            {
                return this._Department;
            }
            set
            {
                this.OnDepartmentChanging(value);
                this._Department = value;
                this.OnDepartmentChanged();
                this.OnPropertyChanged("Department");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Company.IDepartmentDto _Department;
        partial void OnDepartmentChanging(global::Sungero.IntegrationService.Models.Generated.Company.IDepartmentDto value);
        partial void OnDepartmentChanged();
        /// <summary>
        /// There are no comments for Property JobTitle in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("JobTitle")]
        public virtual global::Sungero.IntegrationService.Models.Generated.Company.IJobTitleDto JobTitle
        {
            get
            {
                return this._JobTitle;
            }
            set
            {
                this.OnJobTitleChanging(value);
                this._JobTitle = value;
                this.OnJobTitleChanged();
                this.OnPropertyChanged("JobTitle");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.Company.IJobTitleDto _JobTitle;
        partial void OnJobTitleChanging(global::Sungero.IntegrationService.Models.Generated.Company.IJobTitleDto value);
        partial void OnJobTitleChanged();
    }
}
