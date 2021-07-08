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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class AuditTrail : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CREATED_AT = "createdAt";
		public const string PARSED_AT = "parsedAt";
		public const string STATUS = "status";
		public const string AUDIT_OBJECT_TYPE = "auditObjectType";
		public const string OBJECT_ID = "objectId";
		public const string RELATED_OBJECT_ID = "relatedObjectId";
		public const string RELATED_OBJECT_TYPE = "relatedObjectType";
		public const string ENTRY_ID = "entryId";
		public const string MASTER_PARTNER_ID = "masterPartnerId";
		public const string PARTNER_ID = "partnerId";
		public const string REQUEST_ID = "requestId";
		public const string USER_ID = "userId";
		public const string ACTION = "action";
		public const string DATA = "data";
		public const string KS = "ks";
		public const string CONTEXT = "context";
		public const string ENTRY_POINT = "entryPoint";
		public const string SERVER_NAME = "serverName";
		public const string IP_ADDRESS = "ipAddress";
		public const string USER_AGENT = "userAgent";
		public const string CLIENT_TAG = "clientTag";
		public const string DESCRIPTION = "description";
		public const string ERROR_DESCRIPTION = "errorDescription";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _ParsedAt = Int32.MinValue;
		private AuditTrailStatus _Status = (AuditTrailStatus)Int32.MinValue;
		private AuditTrailObjectType _AuditObjectType = null;
		private string _ObjectId = null;
		private string _RelatedObjectId = null;
		private AuditTrailObjectType _RelatedObjectType = null;
		private string _EntryId = null;
		private int _MasterPartnerId = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _RequestId = null;
		private string _UserId = null;
		private AuditTrailAction _Action = null;
		private AuditTrailInfo _Data;
		private string _Ks = null;
		private AuditTrailContext _Context = (AuditTrailContext)Int32.MinValue;
		private string _EntryPoint = null;
		private string _ServerName = null;
		private string _IpAddress = null;
		private string _UserAgent = null;
		private string _ClientTag = null;
		private string _Description = null;
		private string _ErrorDescription = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		/// <summary>
		/// Use ParsedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ParsedAt
		{
			get { return _ParsedAt; }
			private set 
			{ 
				_ParsedAt = value;
				OnPropertyChanged("ParsedAt");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AuditTrailStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use AuditObjectTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AuditTrailObjectType AuditObjectType
		{
			get { return _AuditObjectType; }
			set 
			{ 
				_AuditObjectType = value;
				OnPropertyChanged("AuditObjectType");
			}
		}
		/// <summary>
		/// Use ObjectIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		/// <summary>
		/// Use RelatedObjectIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RelatedObjectId
		{
			get { return _RelatedObjectId; }
			set 
			{ 
				_RelatedObjectId = value;
				OnPropertyChanged("RelatedObjectId");
			}
		}
		/// <summary>
		/// Use RelatedObjectTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AuditTrailObjectType RelatedObjectType
		{
			get { return _RelatedObjectType; }
			set 
			{ 
				_RelatedObjectType = value;
				OnPropertyChanged("RelatedObjectType");
			}
		}
		/// <summary>
		/// Use EntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		/// <summary>
		/// Use MasterPartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MasterPartnerId
		{
			get { return _MasterPartnerId; }
			private set 
			{ 
				_MasterPartnerId = value;
				OnPropertyChanged("MasterPartnerId");
			}
		}
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		/// <summary>
		/// Use RequestIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RequestId
		{
			get { return _RequestId; }
			private set 
			{ 
				_RequestId = value;
				OnPropertyChanged("RequestId");
			}
		}
		/// <summary>
		/// Use UserIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		/// <summary>
		/// Use ActionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AuditTrailAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		/// <summary>
		/// Use DataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AuditTrailInfo Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		/// <summary>
		/// Use KsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Ks
		{
			get { return _Ks; }
			private set 
			{ 
				_Ks = value;
				OnPropertyChanged("Ks");
			}
		}
		/// <summary>
		/// Use ContextAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AuditTrailContext Context
		{
			get { return _Context; }
			private set 
			{ 
				_Context = value;
				OnPropertyChanged("Context");
			}
		}
		/// <summary>
		/// Use EntryPointAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryPoint
		{
			get { return _EntryPoint; }
			private set 
			{ 
				_EntryPoint = value;
				OnPropertyChanged("EntryPoint");
			}
		}
		/// <summary>
		/// Use ServerNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServerName
		{
			get { return _ServerName; }
			private set 
			{ 
				_ServerName = value;
				OnPropertyChanged("ServerName");
			}
		}
		/// <summary>
		/// Use IpAddressAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IpAddress
		{
			get { return _IpAddress; }
			private set 
			{ 
				_IpAddress = value;
				OnPropertyChanged("IpAddress");
			}
		}
		/// <summary>
		/// Use UserAgentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserAgent
		{
			get { return _UserAgent; }
			private set 
			{ 
				_UserAgent = value;
				OnPropertyChanged("UserAgent");
			}
		}
		/// <summary>
		/// Use ClientTagAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ClientTag
		{
			get { return _ClientTag; }
			set 
			{ 
				_ClientTag = value;
				OnPropertyChanged("ClientTag");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use ErrorDescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			private set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		#endregion

		#region CTor
		public AuditTrail()
		{
		}

		public AuditTrail(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["parsedAt"] != null)
			{
				this._ParsedAt = ParseInt(node["parsedAt"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (AuditTrailStatus)ParseEnum(typeof(AuditTrailStatus), node["status"].Value<string>());
			}
			if(node["auditObjectType"] != null)
			{
				this._AuditObjectType = (AuditTrailObjectType)StringEnum.Parse(typeof(AuditTrailObjectType), node["auditObjectType"].Value<string>());
			}
			if(node["objectId"] != null)
			{
				this._ObjectId = node["objectId"].Value<string>();
			}
			if(node["relatedObjectId"] != null)
			{
				this._RelatedObjectId = node["relatedObjectId"].Value<string>();
			}
			if(node["relatedObjectType"] != null)
			{
				this._RelatedObjectType = (AuditTrailObjectType)StringEnum.Parse(typeof(AuditTrailObjectType), node["relatedObjectType"].Value<string>());
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["masterPartnerId"] != null)
			{
				this._MasterPartnerId = ParseInt(node["masterPartnerId"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["requestId"] != null)
			{
				this._RequestId = node["requestId"].Value<string>();
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["action"] != null)
			{
				this._Action = (AuditTrailAction)StringEnum.Parse(typeof(AuditTrailAction), node["action"].Value<string>());
			}
			if(node["data"] != null)
			{
				this._Data = ObjectFactory.Create<AuditTrailInfo>(node["data"]);
			}
			if(node["ks"] != null)
			{
				this._Ks = node["ks"].Value<string>();
			}
			if(node["context"] != null)
			{
				this._Context = (AuditTrailContext)ParseEnum(typeof(AuditTrailContext), node["context"].Value<string>());
			}
			if(node["entryPoint"] != null)
			{
				this._EntryPoint = node["entryPoint"].Value<string>();
			}
			if(node["serverName"] != null)
			{
				this._ServerName = node["serverName"].Value<string>();
			}
			if(node["ipAddress"] != null)
			{
				this._IpAddress = node["ipAddress"].Value<string>();
			}
			if(node["userAgent"] != null)
			{
				this._UserAgent = node["userAgent"].Value<string>();
			}
			if(node["clientTag"] != null)
			{
				this._ClientTag = node["clientTag"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["errorDescription"] != null)
			{
				this._ErrorDescription = node["errorDescription"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAuditTrail");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("parsedAt", this._ParsedAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("auditObjectType", this._AuditObjectType);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("relatedObjectId", this._RelatedObjectId);
			kparams.AddIfNotNull("relatedObjectType", this._RelatedObjectType);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("masterPartnerId", this._MasterPartnerId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("requestId", this._RequestId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("action", this._Action);
			kparams.AddIfNotNull("data", this._Data);
			kparams.AddIfNotNull("ks", this._Ks);
			kparams.AddIfNotNull("context", this._Context);
			kparams.AddIfNotNull("entryPoint", this._EntryPoint);
			kparams.AddIfNotNull("serverName", this._ServerName);
			kparams.AddIfNotNull("ipAddress", this._IpAddress);
			kparams.AddIfNotNull("userAgent", this._UserAgent);
			kparams.AddIfNotNull("clientTag", this._ClientTag);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("errorDescription", this._ErrorDescription);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CREATED_AT:
					return "CreatedAt";
				case PARSED_AT:
					return "ParsedAt";
				case STATUS:
					return "Status";
				case AUDIT_OBJECT_TYPE:
					return "AuditObjectType";
				case OBJECT_ID:
					return "ObjectId";
				case RELATED_OBJECT_ID:
					return "RelatedObjectId";
				case RELATED_OBJECT_TYPE:
					return "RelatedObjectType";
				case ENTRY_ID:
					return "EntryId";
				case MASTER_PARTNER_ID:
					return "MasterPartnerId";
				case PARTNER_ID:
					return "PartnerId";
				case REQUEST_ID:
					return "RequestId";
				case USER_ID:
					return "UserId";
				case ACTION:
					return "Action";
				case DATA:
					return "Data";
				case KS:
					return "Ks";
				case CONTEXT:
					return "Context";
				case ENTRY_POINT:
					return "EntryPoint";
				case SERVER_NAME:
					return "ServerName";
				case IP_ADDRESS:
					return "IpAddress";
				case USER_AGENT:
					return "UserAgent";
				case CLIENT_TAG:
					return "ClientTag";
				case DESCRIPTION:
					return "Description";
				case ERROR_DESCRIPTION:
					return "ErrorDescription";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

