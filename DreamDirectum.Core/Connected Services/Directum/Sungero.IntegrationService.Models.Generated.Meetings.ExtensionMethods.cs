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
namespace Sungero.IntegrationService.Models.Generated.Meetings
{
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingDto as global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingDto> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingDto as global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingDto> _source,
            long id)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingMembersDto as global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingMembersDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingMembersDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingMembersDto> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingMembersDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingMembersDto as global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingMembersDtoSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingMembersDtoSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingMembersDto> _source,
            long id)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::Sungero.IntegrationService.Models.Generated.Meetings.IMeetingMembersDtoSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
    }
}
