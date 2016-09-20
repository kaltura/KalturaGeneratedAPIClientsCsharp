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

namespace Kaltura
{
	public class KalturaStorageProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Desciption = null;
		private KalturaStorageProfileStatus _Status = (KalturaStorageProfileStatus)Int32.MinValue;
		private KalturaStorageProfileProtocol _Protocol = null;
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
		private IList<KalturaKeyValue> _PathManagerParams;
		private int _Trigger = Int32.MinValue;
		private int _DeliveryPriority = Int32.MinValue;
		private KalturaStorageProfileDeliveryStatus _DeliveryStatus = (KalturaStorageProfileDeliveryStatus)Int32.MinValue;
		private KalturaStorageProfileReadyBehavior _ReadyBehavior = (KalturaStorageProfileReadyBehavior)Int32.MinValue;
		private int _AllowAutoDelete = Int32.MinValue;
		private bool? _CreateFileLink = null;
		private IList<KalturaRule> _Rules;
		private IList<KalturaKeyValue> _DeliveryProfileIds;
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
		public KalturaStorageProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaStorageProfileProtocol Protocol
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
		public new IList<KalturaKeyValue> PathManagerParams
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
		public KalturaStorageProfileDeliveryStatus DeliveryStatus
		{
			get { return _DeliveryStatus; }
			set 
			{ 
				_DeliveryStatus = value;
				OnPropertyChanged("DeliveryStatus");
			}
		}
		public KalturaStorageProfileReadyBehavior ReadyBehavior
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
		public new IList<KalturaRule> Rules
		{
			get { return _Rules; }
			set 
			{ 
				_Rules = value;
				OnPropertyChanged("Rules");
			}
		}
		public new IList<KalturaKeyValue> DeliveryProfileIds
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
		public KalturaStorageProfile()
		{
		}

		public KalturaStorageProfile(XmlElement node) : base(node)
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
						this._Status = (KalturaStorageProfileStatus)ParseEnum(typeof(KalturaStorageProfileStatus), txt);
						continue;
					case "protocol":
						this._Protocol = (KalturaStorageProfileProtocol)KalturaStringEnum.Parse(typeof(KalturaStorageProfileProtocol), txt);
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
						this._PathManagerParams = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._PathManagerParams.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
					case "trigger":
						this._Trigger = ParseInt(txt);
						continue;
					case "deliveryPriority":
						this._DeliveryPriority = ParseInt(txt);
						continue;
					case "deliveryStatus":
						this._DeliveryStatus = (KalturaStorageProfileDeliveryStatus)ParseEnum(typeof(KalturaStorageProfileDeliveryStatus), txt);
						continue;
					case "readyBehavior":
						this._ReadyBehavior = (KalturaStorageProfileReadyBehavior)ParseEnum(typeof(KalturaStorageProfileReadyBehavior), txt);
						continue;
					case "allowAutoDelete":
						this._AllowAutoDelete = ParseInt(txt);
						continue;
					case "createFileLink":
						this._CreateFileLink = ParseBool(txt);
						continue;
					case "rules":
						this._Rules = new List<KalturaRule>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Rules.Add((KalturaRule)KalturaObjectFactory.Create(arrayNode, "KalturaRule"));
						}
						continue;
					case "deliveryProfileIds":
						this._DeliveryProfileIds = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._DeliveryProfileIds.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
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
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaStorageProfile");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("systemName", this.SystemName);
			kparams.AddIfNotNull("desciption", this.Desciption);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("protocol", this.Protocol);
			kparams.AddIfNotNull("storageUrl", this.StorageUrl);
			kparams.AddIfNotNull("storageBaseDir", this.StorageBaseDir);
			kparams.AddIfNotNull("storageUsername", this.StorageUsername);
			kparams.AddIfNotNull("storagePassword", this.StoragePassword);
			kparams.AddIfNotNull("storageFtpPassiveMode", this.StorageFtpPassiveMode);
			kparams.AddIfNotNull("minFileSize", this.MinFileSize);
			kparams.AddIfNotNull("maxFileSize", this.MaxFileSize);
			kparams.AddIfNotNull("flavorParamsIds", this.FlavorParamsIds);
			kparams.AddIfNotNull("maxConcurrentConnections", this.MaxConcurrentConnections);
			kparams.AddIfNotNull("pathManagerClass", this.PathManagerClass);
			kparams.AddIfNotNull("pathManagerParams", this.PathManagerParams);
			kparams.AddIfNotNull("trigger", this.Trigger);
			kparams.AddIfNotNull("deliveryPriority", this.DeliveryPriority);
			kparams.AddIfNotNull("deliveryStatus", this.DeliveryStatus);
			kparams.AddIfNotNull("readyBehavior", this.ReadyBehavior);
			kparams.AddIfNotNull("allowAutoDelete", this.AllowAutoDelete);
			kparams.AddIfNotNull("createFileLink", this.CreateFileLink);
			kparams.AddIfNotNull("rules", this.Rules);
			kparams.AddIfNotNull("deliveryProfileIds", this.DeliveryProfileIds);
			kparams.AddIfNotNull("privateKey", this.PrivateKey);
			kparams.AddIfNotNull("publicKey", this.PublicKey);
			kparams.AddIfNotNull("passPhrase", this.PassPhrase);
			kparams.AddIfNotNull("shouldExportThumbs", this.ShouldExportThumbs);
			return kparams;
		}
		#endregion
	}
}

