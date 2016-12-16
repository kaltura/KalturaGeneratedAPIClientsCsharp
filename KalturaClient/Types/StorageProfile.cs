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
// Copyright (C) 2006-2016  Kaltura Inc.
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
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public string Desciption
		{
			get { return _Desciption; }
			set 
			{ 
				_Desciption = value;
				OnPropertyChanged("Desciption");
			}
		}
		public StorageProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public StorageProfileProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		public string StorageUrl
		{
			get { return _StorageUrl; }
			set 
			{ 
				_StorageUrl = value;
				OnPropertyChanged("StorageUrl");
			}
		}
		public string StorageBaseDir
		{
			get { return _StorageBaseDir; }
			set 
			{ 
				_StorageBaseDir = value;
				OnPropertyChanged("StorageBaseDir");
			}
		}
		public string StorageUsername
		{
			get { return _StorageUsername; }
			set 
			{ 
				_StorageUsername = value;
				OnPropertyChanged("StorageUsername");
			}
		}
		public string StoragePassword
		{
			get { return _StoragePassword; }
			set 
			{ 
				_StoragePassword = value;
				OnPropertyChanged("StoragePassword");
			}
		}
		public bool? StorageFtpPassiveMode
		{
			get { return _StorageFtpPassiveMode; }
			set 
			{ 
				_StorageFtpPassiveMode = value;
				OnPropertyChanged("StorageFtpPassiveMode");
			}
		}
		public int MinFileSize
		{
			get { return _MinFileSize; }
			set 
			{ 
				_MinFileSize = value;
				OnPropertyChanged("MinFileSize");
			}
		}
		public int MaxFileSize
		{
			get { return _MaxFileSize; }
			set 
			{ 
				_MaxFileSize = value;
				OnPropertyChanged("MaxFileSize");
			}
		}
		public string FlavorParamsIds
		{
			get { return _FlavorParamsIds; }
			set 
			{ 
				_FlavorParamsIds = value;
				OnPropertyChanged("FlavorParamsIds");
			}
		}
		public int MaxConcurrentConnections
		{
			get { return _MaxConcurrentConnections; }
			set 
			{ 
				_MaxConcurrentConnections = value;
				OnPropertyChanged("MaxConcurrentConnections");
			}
		}
		public string PathManagerClass
		{
			get { return _PathManagerClass; }
			set 
			{ 
				_PathManagerClass = value;
				OnPropertyChanged("PathManagerClass");
			}
		}
		public IList<KeyValue> PathManagerParams
		{
			get { return _PathManagerParams; }
			set 
			{ 
				_PathManagerParams = value;
				OnPropertyChanged("PathManagerParams");
			}
		}
		public int Trigger
		{
			get { return _Trigger; }
			set 
			{ 
				_Trigger = value;
				OnPropertyChanged("Trigger");
			}
		}
		public int DeliveryPriority
		{
			get { return _DeliveryPriority; }
			set 
			{ 
				_DeliveryPriority = value;
				OnPropertyChanged("DeliveryPriority");
			}
		}
		public StorageProfileDeliveryStatus DeliveryStatus
		{
			get { return _DeliveryStatus; }
			set 
			{ 
				_DeliveryStatus = value;
				OnPropertyChanged("DeliveryStatus");
			}
		}
		public StorageProfileReadyBehavior ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		public int AllowAutoDelete
		{
			get { return _AllowAutoDelete; }
			set 
			{ 
				_AllowAutoDelete = value;
				OnPropertyChanged("AllowAutoDelete");
			}
		}
		public bool? CreateFileLink
		{
			get { return _CreateFileLink; }
			set 
			{ 
				_CreateFileLink = value;
				OnPropertyChanged("CreateFileLink");
			}
		}
		public IList<Rule> Rules
		{
			get { return _Rules; }
			set 
			{ 
				_Rules = value;
				OnPropertyChanged("Rules");
			}
		}
		public IList<KeyValue> DeliveryProfileIds
		{
			get { return _DeliveryProfileIds; }
			set 
			{ 
				_DeliveryProfileIds = value;
				OnPropertyChanged("DeliveryProfileIds");
			}
		}
		public string PrivateKey
		{
			get { return _PrivateKey; }
			set 
			{ 
				_PrivateKey = value;
				OnPropertyChanged("PrivateKey");
			}
		}
		public string PublicKey
		{
			get { return _PublicKey; }
			set 
			{ 
				_PublicKey = value;
				OnPropertyChanged("PublicKey");
			}
		}
		public string PassPhrase
		{
			get { return _PassPhrase; }
			set 
			{ 
				_PassPhrase = value;
				OnPropertyChanged("PassPhrase");
			}
		}
		public bool? ShouldExportThumbs
		{
			get { return _ShouldExportThumbs; }
			set 
			{ 
				_ShouldExportThumbs = value;
				OnPropertyChanged("ShouldExportThumbs");
			}
		}
		#endregion

		#region CTor
		public StorageProfile()
		{
		}

		public StorageProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "systemName":
						this._SystemName = txt;
						continue;
					case "desciption":
						this._Desciption = txt;
						continue;
					case "status":
						this._Status = (StorageProfileStatus)ParseEnum(typeof(StorageProfileStatus), txt);
						continue;
					case "protocol":
						this._Protocol = (StorageProfileProtocol)StringEnum.Parse(typeof(StorageProfileProtocol), txt);
						continue;
					case "storageUrl":
						this._StorageUrl = txt;
						continue;
					case "storageBaseDir":
						this._StorageBaseDir = txt;
						continue;
					case "storageUsername":
						this._StorageUsername = txt;
						continue;
					case "storagePassword":
						this._StoragePassword = txt;
						continue;
					case "storageFtpPassiveMode":
						this._StorageFtpPassiveMode = ParseBool(txt);
						continue;
					case "minFileSize":
						this._MinFileSize = ParseInt(txt);
						continue;
					case "maxFileSize":
						this._MaxFileSize = ParseInt(txt);
						continue;
					case "flavorParamsIds":
						this._FlavorParamsIds = txt;
						continue;
					case "maxConcurrentConnections":
						this._MaxConcurrentConnections = ParseInt(txt);
						continue;
					case "pathManagerClass":
						this._PathManagerClass = txt;
						continue;
					case "pathManagerParams":
						this._PathManagerParams = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._PathManagerParams.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "trigger":
						this._Trigger = ParseInt(txt);
						continue;
					case "deliveryPriority":
						this._DeliveryPriority = ParseInt(txt);
						continue;
					case "deliveryStatus":
						this._DeliveryStatus = (StorageProfileDeliveryStatus)ParseEnum(typeof(StorageProfileDeliveryStatus), txt);
						continue;
					case "readyBehavior":
						this._ReadyBehavior = (StorageProfileReadyBehavior)ParseEnum(typeof(StorageProfileReadyBehavior), txt);
						continue;
					case "allowAutoDelete":
						this._AllowAutoDelete = ParseInt(txt);
						continue;
					case "createFileLink":
						this._CreateFileLink = ParseBool(txt);
						continue;
					case "rules":
						this._Rules = new List<Rule>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Rules.Add(ObjectFactory.Create<Rule>(arrayNode));
						}
						continue;
					case "deliveryProfileIds":
						this._DeliveryProfileIds = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._DeliveryProfileIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "privateKey":
						this._PrivateKey = txt;
						continue;
					case "publicKey":
						this._PublicKey = txt;
						continue;
					case "passPhrase":
						this._PassPhrase = txt;
						continue;
					case "shouldExportThumbs":
						this._ShouldExportThumbs = ParseBool(txt);
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

