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
namespace Sungero.IntegrationService.Models.Generated.DreamSolution
{
    /// <summary>
    /// There are no comments for IEmployeeMutationsStudentDtoSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("IEmployeeMutationsStudentDtoSingle")]
    public partial class IEmployeeMutationsStudentDtoSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<IEmployeeMutationsStudentDto>
    {
        /// <summary>
        /// Initialize a new IEmployeeMutationsStudentDtoSingle object.
        /// </summary>
        public IEmployeeMutationsStudentDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new IEmployeeMutationsStudentDtoSingle object.
        /// </summary>
        public IEmployeeMutationsStudentDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new IEmployeeMutationsStudentDtoSingle object.
        /// </summary>
        public IEmployeeMutationsStudentDtoSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<IEmployeeMutationsStudentDto> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Employee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Employee")]
        public virtual global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDtoSingle Employee
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Employee == null))
                {
                    this._Employee = new global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDtoSingle(this.Context, GetPath("Employee"));
                }
                return this._Employee;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDtoSingle _Employee;
        /// <summary>
        /// There are no comments for Kind in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Kind")]
        public virtual global::Sungero.IntegrationService.Models.Generated.EmployeeModule.IEmployeeMutationKindDtoSingle Kind
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Kind == null))
                {
                    this._Kind = new global::Sungero.IntegrationService.Models.Generated.EmployeeModule.IEmployeeMutationKindDtoSingle(this.Context, GetPath("Kind"));
                }
                return this._Kind;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.EmployeeModule.IEmployeeMutationKindDtoSingle _Kind;
    }
    /// <summary>
    /// There are no comments for IEmployeeMutationsStudentDto in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("IEmployeeMutationsStudentDto")]
    public partial class IEmployeeMutationsStudentDto : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new IEmployeeMutationsStudentDto object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static IEmployeeMutationsStudentDto CreateIEmployeeMutationsStudentDto(long ID)
        {
            IEmployeeMutationsStudentDto iEmployeeMutationsStudentDto = new IEmployeeMutationsStudentDto();
            iEmployeeMutationsStudentDto.Id = ID;
            return iEmployeeMutationsStudentDto;
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
        /// There are no comments for Property AppliedDate in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("AppliedDate")]
        public virtual global::System.Nullable<global::System.DateTimeOffset> AppliedDate
        {
            get
            {
                return this._AppliedDate;
            }
            set
            {
                this.OnAppliedDateChanging(value);
                this._AppliedDate = value;
                this.OnAppliedDateChanged();
                this.OnPropertyChanged("AppliedDate");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Nullable<global::System.DateTimeOffset> _AppliedDate;
        partial void OnAppliedDateChanging(global::System.Nullable<global::System.DateTimeOffset> value);
        partial void OnAppliedDateChanged();
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
        /// There are no comments for Property Employee in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Employee")]
        public virtual global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDto Employee
        {
            get
            {
                return this._Employee;
            }
            set
            {
                this.OnEmployeeChanging(value);
                this._Employee = value;
                this.OnEmployeeChanged();
                this.OnPropertyChanged("Employee");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDto _Employee;
        partial void OnEmployeeChanging(global::Sungero.IntegrationService.Models.Generated.DreamSolution.IEmployeeDto value);
        partial void OnEmployeeChanged();
        /// <summary>
        /// There are no comments for Property Kind in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Kind")]
        public virtual global::Sungero.IntegrationService.Models.Generated.EmployeeModule.IEmployeeMutationKindDto Kind
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
        private global::Sungero.IntegrationService.Models.Generated.EmployeeModule.IEmployeeMutationKindDto _Kind;
        partial void OnKindChanging(global::Sungero.IntegrationService.Models.Generated.EmployeeModule.IEmployeeMutationKindDto value);
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
