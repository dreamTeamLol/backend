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
namespace Sungero.IntegrationService.Models.Generated.CoreEntities
{
    /// <summary>
    /// There are no comments for IUserDtoSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("IUserDtoSingle")]
    public partial class IUserDtoSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<IUserDto>
    {
        /// <summary>
        /// Initialize a new IUserDtoSingle object.
        /// </summary>
        public IUserDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new IUserDtoSingle object.
        /// </summary>
        public IUserDtoSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new IUserDtoSingle object.
        /// </summary>
        public IUserDtoSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<IUserDto> query)
            : base(query) {}

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
    /// There are no comments for IUserDto in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("IUserDto")]
    public partial class IUserDto : IRecipientDto
    {
        /// <summary>
        /// Create a new IUserDto object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static IUserDto CreateIUserDto(long ID)
        {
            IUserDto iUserDto = new IUserDto();
            iUserDto.Id = ID;
            return iUserDto;
        }
        /// <summary>
        /// There are no comments for Property PersonalPhotoHash in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonalPhotoHash")]
        public virtual string PersonalPhotoHash
        {
            get
            {
                return this._PersonalPhotoHash;
            }
            set
            {
                this.OnPersonalPhotoHashChanging(value);
                this._PersonalPhotoHash = value;
                this.OnPersonalPhotoHashChanged();
                this.OnPropertyChanged("PersonalPhotoHash");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _PersonalPhotoHash;
        partial void OnPersonalPhotoHashChanging(string value);
        partial void OnPersonalPhotoHashChanged();
        /// <summary>
        /// There are no comments for Property Login in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Login")]
        public virtual global::Sungero.IntegrationService.Models.Generated.CoreEntities.ILoginDto Login
        {
            get
            {
                return this._Login;
            }
            set
            {
                this.OnLoginChanging(value);
                this._Login = value;
                this.OnLoginChanged();
                this.OnPropertyChanged("Login");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Models.Generated.CoreEntities.ILoginDto _Login;
        partial void OnLoginChanging(global::Sungero.IntegrationService.Models.Generated.CoreEntities.ILoginDto value);
        partial void OnLoginChanged();
        /// <summary>
        /// There are no comments for Property PersonalPhoto in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("PersonalPhoto")]
        public virtual global::Sungero.IntegrationService.Generator.IBinaryObjectDto PersonalPhoto
        {
            get
            {
                return this._PersonalPhoto;
            }
            set
            {
                this.OnPersonalPhotoChanging(value);
                this._PersonalPhoto = value;
                this.OnPersonalPhotoChanged();
                this.OnPropertyChanged("PersonalPhoto");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Sungero.IntegrationService.Generator.IBinaryObjectDto _PersonalPhoto;
        partial void OnPersonalPhotoChanging(global::Sungero.IntegrationService.Generator.IBinaryObjectDto value);
        partial void OnPersonalPhotoChanged();
    }
}
