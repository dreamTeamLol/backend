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
namespace Sungero.IntegrationService.Models.Generated.Commons
{
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.Commons.ICityDto as global::Sungero.IntegrationService.Models.Generated.Commons.ICityDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::Sungero.IntegrationService.Models.Generated.Commons.ICityDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Commons.ICityDto> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::Sungero.IntegrationService.Models.Generated.Commons.ICityDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.Commons.ICityDto as global::Sungero.IntegrationService.Models.Generated.Commons.ICityDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Sungero.IntegrationService.Models.Generated.Commons.ICityDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Commons.ICityDto> _source,
            long id)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Sungero.IntegrationService.Models.Generated.Commons.ICityDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDto as global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDto> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDto as global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDto> _source,
            long id)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Sungero.IntegrationService.Models.Generated.Commons.ICountryDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDto as global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDto> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDto as global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDto> _source,
            long id)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Sungero.IntegrationService.Models.Generated.Commons.IRegionDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
    }
}
