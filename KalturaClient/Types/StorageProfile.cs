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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class StorageProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string DESCIPTION = "desciption";
		public const string STATUS = "status";
		public const string PROTOCOL = "protocol";
		public const string STORAGE_URL = "storageUrl";
		public const string STORAGE_BASE_DIR = "storageBaseDir";
		public const string STORAGE_USERNAME = "storageUsername";
		public const string STORAGE_PASSWORD = "storagePassword";
		public const string STORAGE_FTP_PASSIVE_MODE = "storageFtpPassiveMode";
		public const string MIN_FILE_SIZE = "minFileSize";
		public const string MAX_FILE_SIZE = "maxFileSize";
		public const string FLAVOR_PARAMS_IDS = "flavorParamsIds";
		public const string MAX_CONCURRENT_CONNECTIONS = "maxConcurrentConnections";
		public const string PATH_MANAGER_CLASS = "pathManagerClass";
		public const string PATH_MANAGER_PARAMS = "pathManagerParams";
		public const string TRIGGER = "trigger";
		public const string DELIVERY_PRIORITY = "deliveryPriority";
		public const string DELIVERY_STATUS = "deliveryStatus";
		public const string READY_BEHAVIOR = "readyBehavior";
		public const string ALLOW_AUTO_DELETE = "allowAutoDelete";
		public const string CREATE_FILE_LINK = "createFileLink";
		public const string RULES = "rules";
		public const string DELIVERY_PROFILE_IDS = "deliveryProfileIds";
		public const string PRIVATE_KEY = "privateKey";
		public const string PUBLIC_KEY = "publicKey";
		public const string PASS_PHRASE = "passPhrase";
		public const string SHOULD_EXPORT_THUMBS = "shouldExportThumbs";
		public const string MAPPED_PACKAGER_URL = "mappedPackagerUrl";
		public const string REGULAR_PACKAGER_URL = "regularPackagerUrl";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Desciption = null;
		private StorageProfileStatus _Status = (StorageProfileStatus)Int32.MinValue;
		private StorageProfileProtocol _Protocol = null;
		private string _StorageUrl = null;
		private string _StorageBaseDir = null;
		private string _StorageUsername = null;
		private string _StoragePassword = null;
		private bool? _StorageFtpPassiveMode = null;
		private int _MinFileSize = Int32.MinValue;
		private int _MaxFileSize = Int32.MinValue;
		private string _FlavorParamsIds = null;
		private int _MaxConcurrentConnections = Int32.MinValue;
		private string _PathManagerClass = null;
		private IList<KeyValue> _PathManagerParams;
		private int _Trigger = Int32.MinValue;
		private int _DeliveryPriority = Int32.MinValue;
		private StorageProfileDeliveryStatus _DeliveryStatus = (StorageProfileDeliveryStatus)Int32.MinValue;
		private StorageProfileReadyBehavior _ReadyBehavior = (StorageProfileReadyBehavior)Int32.MinValue;
		private int _AllowAutoDelete = Int32.MinValue;
		private bool? _CreateFileLink = null;
		private IList<Rule> _Rules;
		private IList<KeyValue> _DeliveryProfileIds;
		private string _PrivateKey = null;
		private string _PublicKey = null;
		private string _PassPhrase = null;
		private bool? _ShouldExportThumbs = null;
		private string _MappedPackagerUrl = null;
		private string _RegularPackagerUrl = null;
		#endregion

		#region Properties
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
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
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
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		[JsonProperty]
		public string Desciption
		{
			get { return _Desciption; }
			set 
			{ 
				_Desciption = value;
				OnPropertyChanged("Desciption");
			}
		}
		[JsonProperty]
		public StorageProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public StorageProfileProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		[JsonProperty]
		public string StorageUrl
		{
			get { return _StorageUrl; }
			set 
			{ 
				_StorageUrl = value;
				OnPropertyChanged("StorageUrl");
			}
		}
		[JsonProperty]
		public string StorageBaseDir
		{
			get { return _StorageBaseDir; }
			set 
			{ 
				_StorageBaseDir = value;
				OnPropertyChanged("StorageBaseDir");
			}
		}
		[JsonProperty]
		public string StorageUsername
		{
			get { return _StorageUsername; }
			set 
			{ 
				_StorageUsername = value;
				OnPropertyChanged("StorageUsername");
			}
		}
		[JsonProperty]
		public string StoragePassword
		{
			get { return _StoragePassword; }
			set 
			{ 
				_StoragePassword = value;
				OnPropertyChanged("StoragePassword");
			}
		}
		[JsonProperty]
		public bool? StorageFtpPassiveMode
		{
			get { return _StorageFtpPassiveMode; }
			set 
			{ 
				_StorageFtpPassiveMode = value;
				OnPropertyChanged("StorageFtpPassiveMode");
			}
		}
		[JsonProperty]
		public int MinFileSize
		{
			get { return _MinFileSize; }
			set 
			{ 
				_MinFileSize = value;
				OnPropertyChanged("MinFileSize");
			}
		}
		[JsonProperty]
		public int MaxFileSize
		{
			get { return _MaxFileSize; }
			set 
			{ 
				_MaxFileSize = value;
				OnPropertyChanged("MaxFileSize");
			}
		}
		[JsonProperty]
		public string FlavorParamsIds
		{
			get { return _FlavorParamsIds; }
			set 
			{ 
				_FlavorParamsIds = value;
				OnPropertyChanged("FlavorParamsIds");
			}
		}
		[JsonProperty]
		public int MaxConcurrentConnections
		{
			get { return _MaxConcurrentConnections; }
			set 
			{ 
				_MaxConcurrentConnections = value;
				OnPropertyChanged("MaxConcurrentConnections");
			}
		}
		[JsonProperty]
		public string PathManagerClass
		{
			get { return _PathManagerClass; }
			set 
			{ 
				_PathManagerClass = value;
				OnPropertyChanged("PathManagerClass");
			}
		}
		[JsonProperty]
		public IList<KeyValue> PathManagerParams
		{
			get { return _PathManagerParams; }
			set 
			{ 
				_PathManagerParams = value;
				OnPropertyChanged("PathManagerParams");
			}
		}
		[JsonProperty]
		public int Trigger
		{
			get { return _Trigger; }
			set 
			{ 
				_Trigger = value;
				OnPropertyChanged("Trigger");
			}
		}
		[JsonProperty]
		public int DeliveryPriority
		{
			get { return _DeliveryPriority; }
			set 
			{ 
				_DeliveryPriority = value;
				OnPropertyChanged("DeliveryPriority");
			}
		}
		[JsonProperty]
		public StorageProfileDeliveryStatus DeliveryStatus
		{
			get { return _DeliveryStatus; }
			set 
			{ 
				_DeliveryStatus = value;
				OnPropertyChanged("DeliveryStatus");
			}
		}
		[JsonProperty]
		public StorageProfileReadyBehavior ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		[JsonProperty]
		public int AllowAutoDelete
		{
			get { return _AllowAutoDelete; }
			set 
			{ 
				_AllowAutoDelete = value;
				OnPropertyChanged("AllowAutoDelete");
			}
		}
		[JsonProperty]
		public bool? CreateFileLink
		{
			get { return _CreateFileLink; }
			set 
			{ 
				_CreateFileLink = value;
				OnPropertyChanged("CreateFileLink");
			}
		}
		[JsonProperty]
		public IList<Rule> Rules
		{
			get { return _Rules; }
			set 
			{ 
				_Rules = value;
				OnPropertyChanged("Rules");
			}
		}
		[JsonProperty]
		public IList<KeyValue> DeliveryProfileIds
		{
			get { return _DeliveryProfileIds; }
			set 
			{ 
				_DeliveryProfileIds = value;
				OnPropertyChanged("DeliveryProfileIds");
			}
		}
		[JsonProperty]
		public string PrivateKey
		{
			get { return _PrivateKey; }
			set 
			{ 
				_PrivateKey = value;
				OnPropertyChanged("PrivateKey");
			}
		}
		[JsonProperty]
		public string PublicKey
		{
			get { return _PublicKey; }
			set 
			{ 
				_PublicKey = value;
				OnPropertyChanged("PublicKey");
			}
		}
		[JsonProperty]
		public string PassPhrase
		{
			get { return _PassPhrase; }
			set 
			{ 
				_PassPhrase = value;
				OnPropertyChanged("PassPhrase");
			}
		}
		[JsonProperty]
		public bool? ShouldExportThumbs
		{
			get { return _ShouldExportThumbs; }
			set 
			{ 
				_ShouldExportThumbs = value;
				OnPropertyChanged("ShouldExportThumbs");
			}
		}
		[JsonProperty]
		public string MappedPackagerUrl
		{
			get { return _MappedPackagerUrl; }
			set 
			{ 
				_MappedPackagerUrl = value;
				OnPropertyChanged("MappedPackagerUrl");
			}
		}
		[JsonProperty]
		public string RegularPackagerUrl
		{
			get { return _RegularPackagerUrl; }
			set 
			{ 
				_RegularPackagerUrl = value;
				OnPropertyChanged("RegularPackagerUrl");
			}
		}
		#endregion

		#region CTor
		public StorageProfile()
		{
		}

		public StorageProfile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["desciption"] != null)
			{
				this._Desciption = node["desciption"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (StorageProfileStatus)ParseEnum(typeof(StorageProfileStatus), node["status"].Value<string>());
			}
			if(node["protocol"] != null)
			{
				this._Protocol = (StorageProfileProtocol)StringEnum.Parse(typeof(StorageProfileProtocol), node["protocol"].Value<string>());
			}
			if(node["storageUrl"] != null)
			{
				this._StorageUrl = node["storageUrl"].Value<string>();
			}
			if(node["storageBaseDir"] != null)
			{
				this._StorageBaseDir = node["storageBaseDir"].Value<string>();
			}
			if(node["storageUsername"] != null)
			{
				this._StorageUsername = node["storageUsername"].Value<string>();
			}
			if(node["storagePassword"] != null)
			{
				this._StoragePassword = node["storagePassword"].Value<string>();
			}
			if(node["storageFtpPassiveMode"] != null)
			{
				this._StorageFtpPassiveMode = ParseBool(node["storageFtpPassiveMode"].Value<string>());
			}
			if(node["minFileSize"] != null)
			{
				this._MinFileSize = ParseInt(node["minFileSize"].Value<string>());
			}
			if(node["maxFileSize"] != null)
			{
				this._MaxFileSize = ParseInt(node["maxFileSize"].Value<string>());
			}
			if(node["flavorParamsIds"] != null)
			{
				this._FlavorParamsIds = node["flavorParamsIds"].Value<string>();
			}
			if(node["maxConcurrentConnections"] != null)
			{
				this._MaxConcurrentConnections = ParseInt(node["maxConcurrentConnections"].Value<string>());
			}
			if(node["pathManagerClass"] != null)
			{
				this._PathManagerClass = node["pathManagerClass"].Value<string>();
			}
			if(node["pathManagerParams"] != null)
			{
				this._PathManagerParams = new List<KeyValue>();
				foreach(var arrayNode in node["pathManagerParams"].Children())
				{
					this._PathManagerParams.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["trigger"] != null)
			{
				this._Trigger = ParseInt(node["trigger"].Value<string>());
			}
			if(node["deliveryPriority"] != null)
			{
				this._DeliveryPriority = ParseInt(node["deliveryPriority"].Value<string>());
			}
			if(node["deliveryStatus"] != null)
			{
				this._DeliveryStatus = (StorageProfileDeliveryStatus)ParseEnum(typeof(StorageProfileDeliveryStatus), node["deliveryStatus"].Value<string>());
			}
			if(node["readyBehavior"] != null)
			{
				this._ReadyBehavior = (StorageProfileReadyBehavior)ParseEnum(typeof(StorageProfileReadyBehavior), node["readyBehavior"].Value<string>());
			}
			if(node["allowAutoDelete"] != null)
			{
				this._AllowAutoDelete = ParseInt(node["allowAutoDelete"].Value<string>());
			}
			if(node["createFileLink"] != null)
			{
				this._CreateFileLink = ParseBool(node["createFileLink"].Value<string>());
			}
			if(node["rules"] != null)
			{
				this._Rules = new List<Rule>();
				foreach(var arrayNode in node["rules"].Children())
				{
					this._Rules.Add(ObjectFactory.Create<Rule>(arrayNode));
				}
			}
			if(node["deliveryProfileIds"] != null)
			{
				this._DeliveryProfileIds = new List<KeyValue>();
				foreach(var arrayNode in node["deliveryProfileIds"].Children())
				{
					this._DeliveryProfileIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["privateKey"] != null)
			{
				this._PrivateKey = node["privateKey"].Value<string>();
			}
			if(node["publicKey"] != null)
			{
				this._PublicKey = node["publicKey"].Value<string>();
			}
			if(node["passPhrase"] != null)
			{
				this._PassPhrase = node["passPhrase"].Value<string>();
			}
			if(node["shouldExportThumbs"] != null)
			{
				this._ShouldExportThumbs = ParseBool(node["shouldExportThumbs"].Value<string>());
			}
			if(node["mappedPackagerUrl"] != null)
			{
				this._MappedPackagerUrl = node["mappedPackagerUrl"].Value<string>();
			}
			if(node["regularPackagerUrl"] != null)
			{
				this._RegularPackagerUrl = node["regularPackagerUrl"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaStorageProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("desciption", this._Desciption);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("protocol", this._Protocol);
			kparams.AddIfNotNull("storageUrl", this._StorageUrl);
			kparams.AddIfNotNull("storageBaseDir", this._StorageBaseDir);
			kparams.AddIfNotNull("storageUsername", this._StorageUsername);
			kparams.AddIfNotNull("storagePassword", this._StoragePassword);
			kparams.AddIfNotNull("storageFtpPassiveMode", this._StorageFtpPassiveMode);
			kparams.AddIfNotNull("minFileSize", this._MinFileSize);
			kparams.AddIfNotNull("maxFileSize", this._MaxFileSize);
			kparams.AddIfNotNull("flavorParamsIds", this._FlavorParamsIds);
			kparams.AddIfNotNull("maxConcurrentConnections", this._MaxConcurrentConnections);
			kparams.AddIfNotNull("pathManagerClass", this._PathManagerClass);
			kparams.AddIfNotNull("pathManagerParams", this._PathManagerParams);
			kparams.AddIfNotNull("trigger", this._Trigger);
			kparams.AddIfNotNull("deliveryPriority", this._DeliveryPriority);
			kparams.AddIfNotNull("deliveryStatus", this._DeliveryStatus);
			kparams.AddIfNotNull("readyBehavior", this._ReadyBehavior);
			kparams.AddIfNotNull("allowAutoDelete", this._AllowAutoDelete);
			kparams.AddIfNotNull("createFileLink", this._CreateFileLink);
			kparams.AddIfNotNull("rules", this._Rules);
			kparams.AddIfNotNull("deliveryProfileIds", this._DeliveryProfileIds);
			kparams.AddIfNotNull("privateKey", this._PrivateKey);
			kparams.AddIfNotNull("publicKey", this._PublicKey);
			kparams.AddIfNotNull("passPhrase", this._PassPhrase);
			kparams.AddIfNotNull("shouldExportThumbs", this._ShouldExportThumbs);
			kparams.AddIfNotNull("mappedPackagerUrl", this._MappedPackagerUrl);
			kparams.AddIfNotNull("regularPackagerUrl", this._RegularPackagerUrl);
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
				case UPDATED_AT:
					return "UpdatedAt";
				case PARTNER_ID:
					return "PartnerId";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case DESCIPTION:
					return "Desciption";
				case STATUS:
					return "Status";
				case PROTOCOL:
					return "Protocol";
				case STORAGE_URL:
					return "StorageUrl";
				case STORAGE_BASE_DIR:
					return "StorageBaseDir";
				case STORAGE_USERNAME:
					return "StorageUsername";
				case STORAGE_PASSWORD:
					return "StoragePassword";
				case STORAGE_FTP_PASSIVE_MODE:
					return "StorageFtpPassiveMode";
				case MIN_FILE_SIZE:
					return "MinFileSize";
				case MAX_FILE_SIZE:
					return "MaxFileSize";
				case FLAVOR_PARAMS_IDS:
					return "FlavorParamsIds";
				case MAX_CONCURRENT_CONNECTIONS:
					return "MaxConcurrentConnections";
				case PATH_MANAGER_CLASS:
					return "PathManagerClass";
				case PATH_MANAGER_PARAMS:
					return "PathManagerParams";
				case TRIGGER:
					return "Trigger";
				case DELIVERY_PRIORITY:
					return "DeliveryPriority";
				case DELIVERY_STATUS:
					return "DeliveryStatus";
				case READY_BEHAVIOR:
					return "ReadyBehavior";
				case ALLOW_AUTO_DELETE:
					return "AllowAutoDelete";
				case CREATE_FILE_LINK:
					return "CreateFileLink";
				case RULES:
					return "Rules";
				case DELIVERY_PROFILE_IDS:
					return "DeliveryProfileIds";
				case PRIVATE_KEY:
					return "PrivateKey";
				case PUBLIC_KEY:
					return "PublicKey";
				case PASS_PHRASE:
					return "PassPhrase";
				case SHOULD_EXPORT_THUMBS:
					return "ShouldExportThumbs";
				case MAPPED_PACKAGER_URL:
					return "MappedPackagerUrl";
				case REGULAR_PACKAGER_URL:
					return "RegularPackagerUrl";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

