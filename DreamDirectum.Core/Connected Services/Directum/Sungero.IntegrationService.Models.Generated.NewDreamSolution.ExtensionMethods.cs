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
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDto as global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDto> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDto as global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDto> _source,
            long id)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Cast an entity of type global::Sungero.IntegrationService.Models.Generated.CoreEntities.IUserDto to its derived type global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDto
        /// </summary>
        /// <param name="_source">source entity</param>
        public static global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle CastToIEmployeeDto(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Sungero.IntegrationService.Models.Generated.CoreEntities.IUserDto> _source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDto> query = _source.CastTo<global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDto>();
            return new global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle(_source.Context, query.GetPath(null));
        }
        /// <summary>
        /// Cast an entity of type global::Sungero.IntegrationService.Models.Generated.CoreEntities.IRecipientDto to its derived type global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDto
        /// </summary>
        /// <param name="_source">source entity</param>
        public static global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle CastToIEmployeeDto(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::Sungero.IntegrationService.Models.Generated.CoreEntities.IRecipientDto> _source)
        {
            global::Microsoft.OData.Client.DataServiceQuerySingle<global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDto> query = _source.CastTo<global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDto>();
            return new global::Sungero.IntegrationService.Models.Generated.NewDreamSolution.IEmployeeDtoSingle(_source.Context, query.GetPath(null));
        }
    }
}
