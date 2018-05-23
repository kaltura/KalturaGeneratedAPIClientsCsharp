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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class EntryVendorTask : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string VENDOR_PARTNER_ID = "vendorPartnerId";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string QUEUE_TIME = "queueTime";
		public const string FINISH_TIME = "finishTime";
		public const string ENTRY_ID = "entryId";
		public const string STATUS = "status";
		public const string REACH_PROFILE_ID = "reachProfileId";
		public const string CATALOG_ITEM_ID = "catalogItemId";
		public const string PRICE = "price";
		public const string USER_ID = "userId";
		public const string MODERATING_USER = "moderatingUser";
		public const string ERR_DESCRIPTION = "errDescription";
		public const string ACCESS_KEY = "accessKey";
		public const string VERSION = "version";
		public const string NOTES = "notes";
		public const string DICTIONARY = "dictionary";
		public const string CONTEXT = "context";
		public const string ACCURACY = "accuracy";
		public const string OUTPUT_OBJECT_ID = "outputObjectId";
		public const string PARTNER_DATA = "partnerData";
		public const string CREATION_MODE = "creationMode";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _VendorPartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _QueueTime = Int32.MinValue;
		private int _FinishTime = Int32.MinValue;
		private string _EntryId = null;
		private EntryVendorTaskStatus _Status = (EntryVendorTaskStatus)Int32.MinValue;
		private int _ReachProfileId = Int32.MinValue;
		private int _CatalogItemId = Int32.MinValue;
		private int _Price = Int32.MinValue;
		private string _UserId = null;
		private string _ModeratingUser = null;
		private string _ErrDescription = null;
		private string _AccessKey = null;
		private string _Version = null;
		private string _Notes = null;
		private string _Dictionary = null;
		private string _Context = null;
		private int _Accuracy = Int32.MinValue;
		private string _OutputObjectId = null;
		private string _PartnerData = null;
		private EntryVendorTaskCreationMode _CreationMode = (EntryVendorTaskCreationMode)Int32.MinValue;
		#endregion

		#region Properties
		public long Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int VendorPartnerId
		{
			get { return _VendorPartnerId; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int QueueTime
		{
			get { return _QueueTime; }
		}
		public int FinishTime
		{
			get { return _FinishTime; }
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
		public EntryVendorTaskStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public int ReachProfileId
		{
			get { return _ReachProfileId; }
			set 
			{ 
				_ReachProfileId = value;
				OnPropertyChanged("ReachProfileId");
			}
		}
		public int CatalogItemId
		{
			get { return _CatalogItemId; }
			set 
			{ 
				_CatalogItemId = value;
				OnPropertyChanged("CatalogItemId");
			}
		}
		public int Price
		{
			get { return _Price; }
		}
		public string UserId
		{
			get { return _UserId; }
		}
		public string ModeratingUser
		{
			get { return _ModeratingUser; }
		}
		public string ErrDescription
		{
			get { return _ErrDescription; }
			set 
			{ 
				_ErrDescription = value;
				OnPropertyChanged("ErrDescription");
			}
		}
		public string AccessKey
		{
			get { return _AccessKey; }
		}
		public string Version
		{
			get { return _Version; }
		}
		public string Notes
		{
			get { return _Notes; }
			set 
			{ 
				_Notes = value;
				OnPropertyChanged("Notes");
			}
		}
		public string Dictionary
		{
			get { return _Dictionary; }
		}
		public string Context
		{
			get { return _Context; }
			set 
			{ 
				_Context = value;
				OnPropertyChanged("Context");
			}
		}
		public int Accuracy
		{
			get { return _Accuracy; }
			set 
			{ 
				_Accuracy = value;
				OnPropertyChanged("Accuracy");
			}
		}
		public string OutputObjectId
		{
			get { return _OutputObjectId; }
			set 
			{ 
				_OutputObjectId = value;
				OnPropertyChanged("OutputObjectId");
			}
		}
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		public EntryVendorTaskCreationMode CreationMode
		{
			get { return _CreationMode; }
		}
		#endregion

		#region CTor
		public EntryVendorTask()
		{
		}

		public EntryVendorTask(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseLong(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "vendorPartnerId":
						this._VendorPartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "queueTime":
						this._QueueTime = ParseInt(propertyNode.InnerText);
						continue;
					case "finishTime":
						this._FinishTime = ParseInt(propertyNode.InnerText);
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (EntryVendorTaskStatus)ParseEnum(typeof(EntryVendorTaskStatus), propertyNode.InnerText);
						continue;
					case "reachProfileId":
						this._ReachProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "catalogItemId":
						this._CatalogItemId = ParseInt(propertyNode.InnerText);
						continue;
					case "price":
						this._Price = ParseInt(propertyNode.InnerText);
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "moderatingUser":
						this._ModeratingUser = propertyNode.InnerText;
						continue;
					case "errDescription":
						this._ErrDescription = propertyNode.InnerText;
						continue;
					case "accessKey":
						this._AccessKey = propertyNode.InnerText;
						continue;
					case "version":
						this._Version = propertyNode.InnerText;
						continue;
					case "notes":
						this._Notes = propertyNode.InnerText;
						continue;
					case "dictionary":
						this._Dictionary = propertyNode.InnerText;
						continue;
					case "context":
						this._Context = propertyNode.InnerText;
						continue;
					case "accuracy":
						this._Accuracy = ParseInt(propertyNode.InnerText);
						continue;
					case "outputObjectId":
						this._OutputObjectId = propertyNode.InnerText;
						continue;
					case "partnerData":
						this._PartnerData = propertyNode.InnerText;
						continue;
					case "creationMode":
						this._CreationMode = (EntryVendorTaskCreationMode)ParseEnum(typeof(EntryVendorTaskCreationMode), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaEntryVendorTask");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("vendorPartnerId", this._VendorPartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("queueTime", this._QueueTime);
			kparams.AddIfNotNull("finishTime", this._FinishTime);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("reachProfileId", this._ReachProfileId);
			kparams.AddIfNotNull("catalogItemId", this._CatalogItemId);
			kparams.AddIfNotNull("price", this._Price);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("moderatingUser", this._ModeratingUser);
			kparams.AddIfNotNull("errDescription", this._ErrDescription);
			kparams.AddIfNotNull("accessKey", this._AccessKey);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("notes", this._Notes);
			kparams.AddIfNotNull("dictionary", this._Dictionary);
			kparams.AddIfNotNull("context", this._Context);
			kparams.AddIfNotNull("accuracy", this._Accuracy);
			kparams.AddIfNotNull("outputObjectId", this._OutputObjectId);
			kparams.AddIfNotNull("partnerData", this._PartnerData);
			kparams.AddIfNotNull("creationMode", this._CreationMode);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case VENDOR_PARTNER_ID:
					return "VendorPartnerId";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case QUEUE_TIME:
					return "QueueTime";
				case FINISH_TIME:
					return "FinishTime";
				case ENTRY_ID:
					return "EntryId";
				case STATUS:
					return "Status";
				case REACH_PROFILE_ID:
					return "ReachProfileId";
				case CATALOG_ITEM_ID:
					return "CatalogItemId";
				case PRICE:
					return "Price";
				case USER_ID:
					return "UserId";
				case MODERATING_USER:
					return "ModeratingUser";
				case ERR_DESCRIPTION:
					return "ErrDescription";
				case ACCESS_KEY:
					return "AccessKey";
				case VERSION:
					return "Version";
				case NOTES:
					return "Notes";
				case DICTIONARY:
					return "Dictionary";
				case CONTEXT:
					return "Context";
				case ACCURACY:
					return "Accuracy";
				case OUTPUT_OBJECT_ID:
					return "OutputObjectId";
				case PARTNER_DATA:
					return "PartnerData";
				case CREATION_MODE:
					return "CreationMode";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

