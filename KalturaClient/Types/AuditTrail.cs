// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2017  Kaltura Inc.
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
		public int Id
		{
			get { return _Id; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int ParsedAt
		{
			get { return _ParsedAt; }
		}
		public AuditTrailStatus Status
		{
			get { return _Status; }
		}
		public AuditTrailObjectType AuditObjectType
		{
			get { return _AuditObjectType; }
			set 
			{ 
				_AuditObjectType = value;
				OnPropertyChanged("AuditObjectType");
			}
		}
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		public string RelatedObjectId
		{
			get { return _RelatedObjectId; }
			set 
			{ 
				_RelatedObjectId = value;
				OnPropertyChanged("RelatedObjectId");
			}
		}
		public AuditTrailObjectType RelatedObjectType
		{
			get { return _RelatedObjectType; }
			set 
			{ 
				_RelatedObjectType = value;
				OnPropertyChanged("RelatedObjectType");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public int MasterPartnerId
		{
			get { return _MasterPartnerId; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public string RequestId
		{
			get { return _RequestId; }
		}
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public AuditTrailAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		public AuditTrailInfo Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		public string Ks
		{
			get { return _Ks; }
		}
		public AuditTrailContext Context
		{
			get { return _Context; }
		}
		public string EntryPoint
		{
			get { return _EntryPoint; }
		}
		public string ServerName
		{
			get { return _ServerName; }
		}
		public string IpAddress
		{
			get { return _IpAddress; }
		}
		public string UserAgent
		{
			get { return _UserAgent; }
		}
		public string ClientTag
		{
			get { return _ClientTag; }
			set 
			{ 
				_ClientTag = value;
				OnPropertyChanged("ClientTag");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
		}
		#endregion

		#region CTor
		public AuditTrail()
		{
		}

		public AuditTrail(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "parsedAt":
						this._ParsedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (AuditTrailStatus)ParseEnum(typeof(AuditTrailStatus), propertyNode.InnerText);
						continue;
					case "auditObjectType":
						this._AuditObjectType = (AuditTrailObjectType)StringEnum.Parse(typeof(AuditTrailObjectType), propertyNode.InnerText);
						continue;
					case "objectId":
						this._ObjectId = propertyNode.InnerText;
						continue;
					case "relatedObjectId":
						this._RelatedObjectId = propertyNode.InnerText;
						continue;
					case "relatedObjectType":
						this._RelatedObjectType = (AuditTrailObjectType)StringEnum.Parse(typeof(AuditTrailObjectType), propertyNode.InnerText);
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "masterPartnerId":
						this._MasterPartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "requestId":
						this._RequestId = propertyNode.InnerText;
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "action":
						this._Action = (AuditTrailAction)StringEnum.Parse(typeof(AuditTrailAction), propertyNode.InnerText);
						continue;
					case "data":
						this._Data = ObjectFactory.Create<AuditTrailInfo>(propertyNode);
						continue;
					case "ks":
						this._Ks = propertyNode.InnerText;
						continue;
					case "context":
						this._Context = (AuditTrailContext)ParseEnum(typeof(AuditTrailContext), propertyNode.InnerText);
						continue;
					case "entryPoint":
						this._EntryPoint = propertyNode.InnerText;
						continue;
					case "serverName":
						this._ServerName = propertyNode.InnerText;
						continue;
					case "ipAddress":
						this._IpAddress = propertyNode.InnerText;
						continue;
					case "userAgent":
						this._UserAgent = propertyNode.InnerText;
						continue;
					case "clientTag":
						this._ClientTag = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "errorDescription":
						this._ErrorDescription = propertyNode.InnerText;
						continue;
				}
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

