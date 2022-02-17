// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class AuditTrailBaseFilter : RelatedFilter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string PARSED_AT_GREATER_THAN_OR_EQUAL = "parsedAtGreaterThanOrEqual";
		public const string PARSED_AT_LESS_THAN_OR_EQUAL = "parsedAtLessThanOrEqual";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string AUDIT_OBJECT_TYPE_EQUAL = "auditObjectTypeEqual";
		public const string AUDIT_OBJECT_TYPE_IN = "auditObjectTypeIn";
		public const string OBJECT_ID_EQUAL = "objectIdEqual";
		public const string OBJECT_ID_IN = "objectIdIn";
		public const string RELATED_OBJECT_ID_EQUAL = "relatedObjectIdEqual";
		public const string RELATED_OBJECT_ID_IN = "relatedObjectIdIn";
		public const string RELATED_OBJECT_TYPE_EQUAL = "relatedObjectTypeEqual";
		public const string RELATED_OBJECT_TYPE_IN = "relatedObjectTypeIn";
		public const string ENTRY_ID_EQUAL = "entryIdEqual";
		public const string ENTRY_ID_IN = "entryIdIn";
		public const string MASTER_PARTNER_ID_EQUAL = "masterPartnerIdEqual";
		public const string MASTER_PARTNER_ID_IN = "masterPartnerIdIn";
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string PARTNER_ID_IN = "partnerIdIn";
		public const string REQUEST_ID_EQUAL = "requestIdEqual";
		public const string REQUEST_ID_IN = "requestIdIn";
		public const string USER_ID_EQUAL = "userIdEqual";
		public const string USER_ID_IN = "userIdIn";
		public const string ACTION_EQUAL = "actionEqual";
		public const string ACTION_IN = "actionIn";
		public const string KS_EQUAL = "ksEqual";
		public const string CONTEXT_EQUAL = "contextEqual";
		public const string CONTEXT_IN = "contextIn";
		public const string ENTRY_POINT_EQUAL = "entryPointEqual";
		public const string ENTRY_POINT_IN = "entryPointIn";
		public const string SERVER_NAME_EQUAL = "serverNameEqual";
		public const string SERVER_NAME_IN = "serverNameIn";
		public const string IP_ADDRESS_EQUAL = "ipAddressEqual";
		public const string IP_ADDRESS_IN = "ipAddressIn";
		public const string CLIENT_TAG_EQUAL = "clientTagEqual";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _ParsedAtGreaterThanOrEqual = Int32.MinValue;
		private int _ParsedAtLessThanOrEqual = Int32.MinValue;
		private AuditTrailStatus _StatusEqual = (AuditTrailStatus)Int32.MinValue;
		private string _StatusIn = null;
		private AuditTrailObjectType _AuditObjectTypeEqual = null;
		private string _AuditObjectTypeIn = null;
		private string _ObjectIdEqual = null;
		private string _ObjectIdIn = null;
		private string _RelatedObjectIdEqual = null;
		private string _RelatedObjectIdIn = null;
		private AuditTrailObjectType _RelatedObjectTypeEqual = null;
		private string _RelatedObjectTypeIn = null;
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private int _MasterPartnerIdEqual = Int32.MinValue;
		private string _MasterPartnerIdIn = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _RequestIdEqual = null;
		private string _RequestIdIn = null;
		private string _UserIdEqual = null;
		private string _UserIdIn = null;
		private AuditTrailAction _ActionEqual = null;
		private string _ActionIn = null;
		private string _KsEqual = null;
		private AuditTrailContext _ContextEqual = (AuditTrailContext)Int32.MinValue;
		private string _ContextIn = null;
		private string _EntryPointEqual = null;
		private string _EntryPointIn = null;
		private string _ServerNameEqual = null;
		private string _ServerNameIn = null;
		private string _IpAddressEqual = null;
		private string _IpAddressIn = null;
		private string _ClientTagEqual = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		/// <summary>
		/// Use CreatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use CreatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use ParsedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ParsedAtGreaterThanOrEqual
		{
			get { return _ParsedAtGreaterThanOrEqual; }
			set 
			{ 
				_ParsedAtGreaterThanOrEqual = value;
				OnPropertyChanged("ParsedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use ParsedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ParsedAtLessThanOrEqual
		{
			get { return _ParsedAtLessThanOrEqual; }
			set 
			{ 
				_ParsedAtLessThanOrEqual = value;
				OnPropertyChanged("ParsedAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use StatusEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AuditTrailStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		/// <summary>
		/// Use StatusInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		/// <summary>
		/// Use AuditObjectTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AuditTrailObjectType AuditObjectTypeEqual
		{
			get { return _AuditObjectTypeEqual; }
			set 
			{ 
				_AuditObjectTypeEqual = value;
				OnPropertyChanged("AuditObjectTypeEqual");
			}
		}
		/// <summary>
		/// Use AuditObjectTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AuditObjectTypeIn
		{
			get { return _AuditObjectTypeIn; }
			set 
			{ 
				_AuditObjectTypeIn = value;
				OnPropertyChanged("AuditObjectTypeIn");
			}
		}
		/// <summary>
		/// Use ObjectIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectIdEqual
		{
			get { return _ObjectIdEqual; }
			set 
			{ 
				_ObjectIdEqual = value;
				OnPropertyChanged("ObjectIdEqual");
			}
		}
		/// <summary>
		/// Use ObjectIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectIdIn
		{
			get { return _ObjectIdIn; }
			set 
			{ 
				_ObjectIdIn = value;
				OnPropertyChanged("ObjectIdIn");
			}
		}
		/// <summary>
		/// Use RelatedObjectIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RelatedObjectIdEqual
		{
			get { return _RelatedObjectIdEqual; }
			set 
			{ 
				_RelatedObjectIdEqual = value;
				OnPropertyChanged("RelatedObjectIdEqual");
			}
		}
		/// <summary>
		/// Use RelatedObjectIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RelatedObjectIdIn
		{
			get { return _RelatedObjectIdIn; }
			set 
			{ 
				_RelatedObjectIdIn = value;
				OnPropertyChanged("RelatedObjectIdIn");
			}
		}
		/// <summary>
		/// Use RelatedObjectTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AuditTrailObjectType RelatedObjectTypeEqual
		{
			get { return _RelatedObjectTypeEqual; }
			set 
			{ 
				_RelatedObjectTypeEqual = value;
				OnPropertyChanged("RelatedObjectTypeEqual");
			}
		}
		/// <summary>
		/// Use RelatedObjectTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RelatedObjectTypeIn
		{
			get { return _RelatedObjectTypeIn; }
			set 
			{ 
				_RelatedObjectTypeIn = value;
				OnPropertyChanged("RelatedObjectTypeIn");
			}
		}
		/// <summary>
		/// Use EntryIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		/// <summary>
		/// Use EntryIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIdIn
		{
			get { return _EntryIdIn; }
			set 
			{ 
				_EntryIdIn = value;
				OnPropertyChanged("EntryIdIn");
			}
		}
		/// <summary>
		/// Use MasterPartnerIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MasterPartnerIdEqual
		{
			get { return _MasterPartnerIdEqual; }
			set 
			{ 
				_MasterPartnerIdEqual = value;
				OnPropertyChanged("MasterPartnerIdEqual");
			}
		}
		/// <summary>
		/// Use MasterPartnerIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MasterPartnerIdIn
		{
			get { return _MasterPartnerIdIn; }
			set 
			{ 
				_MasterPartnerIdIn = value;
				OnPropertyChanged("MasterPartnerIdIn");
			}
		}
		/// <summary>
		/// Use PartnerIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		/// <summary>
		/// Use PartnerIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		/// <summary>
		/// Use RequestIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RequestIdEqual
		{
			get { return _RequestIdEqual; }
			set 
			{ 
				_RequestIdEqual = value;
				OnPropertyChanged("RequestIdEqual");
			}
		}
		/// <summary>
		/// Use RequestIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RequestIdIn
		{
			get { return _RequestIdIn; }
			set 
			{ 
				_RequestIdIn = value;
				OnPropertyChanged("RequestIdIn");
			}
		}
		/// <summary>
		/// Use UserIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		/// <summary>
		/// Use UserIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		/// <summary>
		/// Use ActionEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AuditTrailAction ActionEqual
		{
			get { return _ActionEqual; }
			set 
			{ 
				_ActionEqual = value;
				OnPropertyChanged("ActionEqual");
			}
		}
		/// <summary>
		/// Use ActionInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ActionIn
		{
			get { return _ActionIn; }
			set 
			{ 
				_ActionIn = value;
				OnPropertyChanged("ActionIn");
			}
		}
		/// <summary>
		/// Use KsEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string KsEqual
		{
			get { return _KsEqual; }
			set 
			{ 
				_KsEqual = value;
				OnPropertyChanged("KsEqual");
			}
		}
		/// <summary>
		/// Use ContextEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AuditTrailContext ContextEqual
		{
			get { return _ContextEqual; }
			set 
			{ 
				_ContextEqual = value;
				OnPropertyChanged("ContextEqual");
			}
		}
		/// <summary>
		/// Use ContextInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ContextIn
		{
			get { return _ContextIn; }
			set 
			{ 
				_ContextIn = value;
				OnPropertyChanged("ContextIn");
			}
		}
		/// <summary>
		/// Use EntryPointEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryPointEqual
		{
			get { return _EntryPointEqual; }
			set 
			{ 
				_EntryPointEqual = value;
				OnPropertyChanged("EntryPointEqual");
			}
		}
		/// <summary>
		/// Use EntryPointInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryPointIn
		{
			get { return _EntryPointIn; }
			set 
			{ 
				_EntryPointIn = value;
				OnPropertyChanged("EntryPointIn");
			}
		}
		/// <summary>
		/// Use ServerNameEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServerNameEqual
		{
			get { return _ServerNameEqual; }
			set 
			{ 
				_ServerNameEqual = value;
				OnPropertyChanged("ServerNameEqual");
			}
		}
		/// <summary>
		/// Use ServerNameInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServerNameIn
		{
			get { return _ServerNameIn; }
			set 
			{ 
				_ServerNameIn = value;
				OnPropertyChanged("ServerNameIn");
			}
		}
		/// <summary>
		/// Use IpAddressEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IpAddressEqual
		{
			get { return _IpAddressEqual; }
			set 
			{ 
				_IpAddressEqual = value;
				OnPropertyChanged("IpAddressEqual");
			}
		}
		/// <summary>
		/// Use IpAddressInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IpAddressIn
		{
			get { return _IpAddressIn; }
			set 
			{ 
				_IpAddressIn = value;
				OnPropertyChanged("IpAddressIn");
			}
		}
		/// <summary>
		/// Use ClientTagEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ClientTagEqual
		{
			get { return _ClientTagEqual; }
			set 
			{ 
				_ClientTagEqual = value;
				OnPropertyChanged("ClientTagEqual");
			}
		}
		#endregion

		#region CTor
		public AuditTrailBaseFilter()
		{
		}

		public AuditTrailBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseInt(node["idEqual"].Value<string>());
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["parsedAtGreaterThanOrEqual"] != null)
			{
				this._ParsedAtGreaterThanOrEqual = ParseInt(node["parsedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["parsedAtLessThanOrEqual"] != null)
			{
				this._ParsedAtLessThanOrEqual = ParseInt(node["parsedAtLessThanOrEqual"].Value<string>());
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (AuditTrailStatus)ParseEnum(typeof(AuditTrailStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["auditObjectTypeEqual"] != null)
			{
				this._AuditObjectTypeEqual = (AuditTrailObjectType)StringEnum.Parse(typeof(AuditTrailObjectType), node["auditObjectTypeEqual"].Value<string>());
			}
			if(node["auditObjectTypeIn"] != null)
			{
				this._AuditObjectTypeIn = node["auditObjectTypeIn"].Value<string>();
			}
			if(node["objectIdEqual"] != null)
			{
				this._ObjectIdEqual = node["objectIdEqual"].Value<string>();
			}
			if(node["objectIdIn"] != null)
			{
				this._ObjectIdIn = node["objectIdIn"].Value<string>();
			}
			if(node["relatedObjectIdEqual"] != null)
			{
				this._RelatedObjectIdEqual = node["relatedObjectIdEqual"].Value<string>();
			}
			if(node["relatedObjectIdIn"] != null)
			{
				this._RelatedObjectIdIn = node["relatedObjectIdIn"].Value<string>();
			}
			if(node["relatedObjectTypeEqual"] != null)
			{
				this._RelatedObjectTypeEqual = (AuditTrailObjectType)StringEnum.Parse(typeof(AuditTrailObjectType), node["relatedObjectTypeEqual"].Value<string>());
			}
			if(node["relatedObjectTypeIn"] != null)
			{
				this._RelatedObjectTypeIn = node["relatedObjectTypeIn"].Value<string>();
			}
			if(node["entryIdEqual"] != null)
			{
				this._EntryIdEqual = node["entryIdEqual"].Value<string>();
			}
			if(node["entryIdIn"] != null)
			{
				this._EntryIdIn = node["entryIdIn"].Value<string>();
			}
			if(node["masterPartnerIdEqual"] != null)
			{
				this._MasterPartnerIdEqual = ParseInt(node["masterPartnerIdEqual"].Value<string>());
			}
			if(node["masterPartnerIdIn"] != null)
			{
				this._MasterPartnerIdIn = node["masterPartnerIdIn"].Value<string>();
			}
			if(node["partnerIdEqual"] != null)
			{
				this._PartnerIdEqual = ParseInt(node["partnerIdEqual"].Value<string>());
			}
			if(node["partnerIdIn"] != null)
			{
				this._PartnerIdIn = node["partnerIdIn"].Value<string>();
			}
			if(node["requestIdEqual"] != null)
			{
				this._RequestIdEqual = node["requestIdEqual"].Value<string>();
			}
			if(node["requestIdIn"] != null)
			{
				this._RequestIdIn = node["requestIdIn"].Value<string>();
			}
			if(node["userIdEqual"] != null)
			{
				this._UserIdEqual = node["userIdEqual"].Value<string>();
			}
			if(node["userIdIn"] != null)
			{
				this._UserIdIn = node["userIdIn"].Value<string>();
			}
			if(node["actionEqual"] != null)
			{
				this._ActionEqual = (AuditTrailAction)StringEnum.Parse(typeof(AuditTrailAction), node["actionEqual"].Value<string>());
			}
			if(node["actionIn"] != null)
			{
				this._ActionIn = node["actionIn"].Value<string>();
			}
			if(node["ksEqual"] != null)
			{
				this._KsEqual = node["ksEqual"].Value<string>();
			}
			if(node["contextEqual"] != null)
			{
				this._ContextEqual = (AuditTrailContext)ParseEnum(typeof(AuditTrailContext), node["contextEqual"].Value<string>());
			}
			if(node["contextIn"] != null)
			{
				this._ContextIn = node["contextIn"].Value<string>();
			}
			if(node["entryPointEqual"] != null)
			{
				this._EntryPointEqual = node["entryPointEqual"].Value<string>();
			}
			if(node["entryPointIn"] != null)
			{
				this._EntryPointIn = node["entryPointIn"].Value<string>();
			}
			if(node["serverNameEqual"] != null)
			{
				this._ServerNameEqual = node["serverNameEqual"].Value<string>();
			}
			if(node["serverNameIn"] != null)
			{
				this._ServerNameIn = node["serverNameIn"].Value<string>();
			}
			if(node["ipAddressEqual"] != null)
			{
				this._IpAddressEqual = node["ipAddressEqual"].Value<string>();
			}
			if(node["ipAddressIn"] != null)
			{
				this._IpAddressIn = node["ipAddressIn"].Value<string>();
			}
			if(node["clientTagEqual"] != null)
			{
				this._ClientTagEqual = node["clientTagEqual"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAuditTrailBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("parsedAtGreaterThanOrEqual", this._ParsedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("parsedAtLessThanOrEqual", this._ParsedAtLessThanOrEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("auditObjectTypeEqual", this._AuditObjectTypeEqual);
			kparams.AddIfNotNull("auditObjectTypeIn", this._AuditObjectTypeIn);
			kparams.AddIfNotNull("objectIdEqual", this._ObjectIdEqual);
			kparams.AddIfNotNull("objectIdIn", this._ObjectIdIn);
			kparams.AddIfNotNull("relatedObjectIdEqual", this._RelatedObjectIdEqual);
			kparams.AddIfNotNull("relatedObjectIdIn", this._RelatedObjectIdIn);
			kparams.AddIfNotNull("relatedObjectTypeEqual", this._RelatedObjectTypeEqual);
			kparams.AddIfNotNull("relatedObjectTypeIn", this._RelatedObjectTypeIn);
			kparams.AddIfNotNull("entryIdEqual", this._EntryIdEqual);
			kparams.AddIfNotNull("entryIdIn", this._EntryIdIn);
			kparams.AddIfNotNull("masterPartnerIdEqual", this._MasterPartnerIdEqual);
			kparams.AddIfNotNull("masterPartnerIdIn", this._MasterPartnerIdIn);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this._PartnerIdIn);
			kparams.AddIfNotNull("requestIdEqual", this._RequestIdEqual);
			kparams.AddIfNotNull("requestIdIn", this._RequestIdIn);
			kparams.AddIfNotNull("userIdEqual", this._UserIdEqual);
			kparams.AddIfNotNull("userIdIn", this._UserIdIn);
			kparams.AddIfNotNull("actionEqual", this._ActionEqual);
			kparams.AddIfNotNull("actionIn", this._ActionIn);
			kparams.AddIfNotNull("ksEqual", this._KsEqual);
			kparams.AddIfNotNull("contextEqual", this._ContextEqual);
			kparams.AddIfNotNull("contextIn", this._ContextIn);
			kparams.AddIfNotNull("entryPointEqual", this._EntryPointEqual);
			kparams.AddIfNotNull("entryPointIn", this._EntryPointIn);
			kparams.AddIfNotNull("serverNameEqual", this._ServerNameEqual);
			kparams.AddIfNotNull("serverNameIn", this._ServerNameIn);
			kparams.AddIfNotNull("ipAddressEqual", this._IpAddressEqual);
			kparams.AddIfNotNull("ipAddressIn", this._IpAddressIn);
			kparams.AddIfNotNull("clientTagEqual", this._ClientTagEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case PARSED_AT_GREATER_THAN_OR_EQUAL:
					return "ParsedAtGreaterThanOrEqual";
				case PARSED_AT_LESS_THAN_OR_EQUAL:
					return "ParsedAtLessThanOrEqual";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case AUDIT_OBJECT_TYPE_EQUAL:
					return "AuditObjectTypeEqual";
				case AUDIT_OBJECT_TYPE_IN:
					return "AuditObjectTypeIn";
				case OBJECT_ID_EQUAL:
					return "ObjectIdEqual";
				case OBJECT_ID_IN:
					return "ObjectIdIn";
				case RELATED_OBJECT_ID_EQUAL:
					return "RelatedObjectIdEqual";
				case RELATED_OBJECT_ID_IN:
					return "RelatedObjectIdIn";
				case RELATED_OBJECT_TYPE_EQUAL:
					return "RelatedObjectTypeEqual";
				case RELATED_OBJECT_TYPE_IN:
					return "RelatedObjectTypeIn";
				case ENTRY_ID_EQUAL:
					return "EntryIdEqual";
				case ENTRY_ID_IN:
					return "EntryIdIn";
				case MASTER_PARTNER_ID_EQUAL:
					return "MasterPartnerIdEqual";
				case MASTER_PARTNER_ID_IN:
					return "MasterPartnerIdIn";
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case PARTNER_ID_IN:
					return "PartnerIdIn";
				case REQUEST_ID_EQUAL:
					return "RequestIdEqual";
				case REQUEST_ID_IN:
					return "RequestIdIn";
				case USER_ID_EQUAL:
					return "UserIdEqual";
				case USER_ID_IN:
					return "UserIdIn";
				case ACTION_EQUAL:
					return "ActionEqual";
				case ACTION_IN:
					return "ActionIn";
				case KS_EQUAL:
					return "KsEqual";
				case CONTEXT_EQUAL:
					return "ContextEqual";
				case CONTEXT_IN:
					return "ContextIn";
				case ENTRY_POINT_EQUAL:
					return "EntryPointEqual";
				case ENTRY_POINT_IN:
					return "EntryPointIn";
				case SERVER_NAME_EQUAL:
					return "ServerNameEqual";
				case SERVER_NAME_IN:
					return "ServerNameIn";
				case IP_ADDRESS_EQUAL:
					return "IpAddressEqual";
				case IP_ADDRESS_IN:
					return "IpAddressIn";
				case CLIENT_TAG_EQUAL:
					return "ClientTagEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

