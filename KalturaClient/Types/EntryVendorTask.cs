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
		public const string TASK_JOB_DATA = "taskJobData";
		public const string EXPECTED_FINISH_TIME = "expectedFinishTime";
		public const string SERVICE_TYPE = "serviceType";
		public const string SERVICE_FEATURE = "serviceFeature";
		public const string TURN_AROUND_TIME = "turnAroundTime";
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
		private double _Price = Double.MinValue;
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
		private VendorTaskData _TaskJobData;
		private int _ExpectedFinishTime = Int32.MinValue;
		private VendorServiceType _ServiceType = (VendorServiceType)Int32.MinValue;
		private VendorServiceFeature _ServiceFeature = (VendorServiceFeature)Int32.MinValue;
		private VendorServiceTurnAroundTime _TurnAroundTime = (VendorServiceTurnAroundTime)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
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
		/// Use VendorPartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VendorPartnerId
		{
			get { return _VendorPartnerId; }
			private set 
			{ 
				_VendorPartnerId = value;
				OnPropertyChanged("VendorPartnerId");
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
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use QueueTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int QueueTime
		{
			get { return _QueueTime; }
			private set 
			{ 
				_QueueTime = value;
				OnPropertyChanged("QueueTime");
			}
		}
		/// <summary>
		/// Use FinishTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FinishTime
		{
			get { return _FinishTime; }
			private set 
			{ 
				_FinishTime = value;
				OnPropertyChanged("FinishTime");
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
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryVendorTaskStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use ReachProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ReachProfileId
		{
			get { return _ReachProfileId; }
			set 
			{ 
				_ReachProfileId = value;
				OnPropertyChanged("ReachProfileId");
			}
		}
		/// <summary>
		/// Use CatalogItemIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CatalogItemId
		{
			get { return _CatalogItemId; }
			set 
			{ 
				_CatalogItemId = value;
				OnPropertyChanged("CatalogItemId");
			}
		}
		/// <summary>
		/// Use PriceAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double Price
		{
			get { return _Price; }
			private set 
			{ 
				_Price = value;
				OnPropertyChanged("Price");
			}
		}
		/// <summary>
		/// Use UserIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserId
		{
			get { return _UserId; }
			private set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		/// <summary>
		/// Use ModeratingUserAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ModeratingUser
		{
			get { return _ModeratingUser; }
			private set 
			{ 
				_ModeratingUser = value;
				OnPropertyChanged("ModeratingUser");
			}
		}
		/// <summary>
		/// Use ErrDescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ErrDescription
		{
			get { return _ErrDescription; }
			set 
			{ 
				_ErrDescription = value;
				OnPropertyChanged("ErrDescription");
			}
		}
		/// <summary>
		/// Use AccessKeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AccessKey
		{
			get { return _AccessKey; }
			private set 
			{ 
				_AccessKey = value;
				OnPropertyChanged("AccessKey");
			}
		}
		/// <summary>
		/// Use VersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Version
		{
			get { return _Version; }
			private set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		/// <summary>
		/// Use NotesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Notes
		{
			get { return _Notes; }
			set 
			{ 
				_Notes = value;
				OnPropertyChanged("Notes");
			}
		}
		/// <summary>
		/// Use DictionaryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Dictionary
		{
			get { return _Dictionary; }
			private set 
			{ 
				_Dictionary = value;
				OnPropertyChanged("Dictionary");
			}
		}
		/// <summary>
		/// Use ContextAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Context
		{
			get { return _Context; }
			set 
			{ 
				_Context = value;
				OnPropertyChanged("Context");
			}
		}
		/// <summary>
		/// Use AccuracyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Accuracy
		{
			get { return _Accuracy; }
			set 
			{ 
				_Accuracy = value;
				OnPropertyChanged("Accuracy");
			}
		}
		/// <summary>
		/// Use OutputObjectIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OutputObjectId
		{
			get { return _OutputObjectId; }
			set 
			{ 
				_OutputObjectId = value;
				OnPropertyChanged("OutputObjectId");
			}
		}
		/// <summary>
		/// Use PartnerDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		/// <summary>
		/// Use CreationModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryVendorTaskCreationMode CreationMode
		{
			get { return _CreationMode; }
			private set 
			{ 
				_CreationMode = value;
				OnPropertyChanged("CreationMode");
			}
		}
		/// <summary>
		/// Use TaskJobDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorTaskData TaskJobData
		{
			get { return _TaskJobData; }
			set 
			{ 
				_TaskJobData = value;
				OnPropertyChanged("TaskJobData");
			}
		}
		/// <summary>
		/// Use ExpectedFinishTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ExpectedFinishTime
		{
			get { return _ExpectedFinishTime; }
			private set 
			{ 
				_ExpectedFinishTime = value;
				OnPropertyChanged("ExpectedFinishTime");
			}
		}
		/// <summary>
		/// Use ServiceTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorServiceType ServiceType
		{
			get { return _ServiceType; }
			private set 
			{ 
				_ServiceType = value;
				OnPropertyChanged("ServiceType");
			}
		}
		/// <summary>
		/// Use ServiceFeatureAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorServiceFeature ServiceFeature
		{
			get { return _ServiceFeature; }
			private set 
			{ 
				_ServiceFeature = value;
				OnPropertyChanged("ServiceFeature");
			}
		}
		/// <summary>
		/// Use TurnAroundTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorServiceTurnAroundTime TurnAroundTime
		{
			get { return _TurnAroundTime; }
			private set 
			{ 
				_TurnAroundTime = value;
				OnPropertyChanged("TurnAroundTime");
			}
		}
		#endregion

		#region CTor
		public EntryVendorTask()
		{
		}

		public EntryVendorTask(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["vendorPartnerId"] != null)
			{
				this._VendorPartnerId = ParseInt(node["vendorPartnerId"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["queueTime"] != null)
			{
				this._QueueTime = ParseInt(node["queueTime"].Value<string>());
			}
			if(node["finishTime"] != null)
			{
				this._FinishTime = ParseInt(node["finishTime"].Value<string>());
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (EntryVendorTaskStatus)ParseEnum(typeof(EntryVendorTaskStatus), node["status"].Value<string>());
			}
			if(node["reachProfileId"] != null)
			{
				this._ReachProfileId = ParseInt(node["reachProfileId"].Value<string>());
			}
			if(node["catalogItemId"] != null)
			{
				this._CatalogItemId = ParseInt(node["catalogItemId"].Value<string>());
			}
			if(node["price"] != null)
			{
				this._Price = ParseDouble(node["price"].Value<string>());
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["moderatingUser"] != null)
			{
				this._ModeratingUser = node["moderatingUser"].Value<string>();
			}
			if(node["errDescription"] != null)
			{
				this._ErrDescription = node["errDescription"].Value<string>();
			}
			if(node["accessKey"] != null)
			{
				this._AccessKey = node["accessKey"].Value<string>();
			}
			if(node["version"] != null)
			{
				this._Version = node["version"].Value<string>();
			}
			if(node["notes"] != null)
			{
				this._Notes = node["notes"].Value<string>();
			}
			if(node["dictionary"] != null)
			{
				this._Dictionary = node["dictionary"].Value<string>();
			}
			if(node["context"] != null)
			{
				this._Context = node["context"].Value<string>();
			}
			if(node["accuracy"] != null)
			{
				this._Accuracy = ParseInt(node["accuracy"].Value<string>());
			}
			if(node["outputObjectId"] != null)
			{
				this._OutputObjectId = node["outputObjectId"].Value<string>();
			}
			if(node["partnerData"] != null)
			{
				this._PartnerData = node["partnerData"].Value<string>();
			}
			if(node["creationMode"] != null)
			{
				this._CreationMode = (EntryVendorTaskCreationMode)ParseEnum(typeof(EntryVendorTaskCreationMode), node["creationMode"].Value<string>());
			}
			if(node["taskJobData"] != null)
			{
				this._TaskJobData = ObjectFactory.Create<VendorTaskData>(node["taskJobData"]);
			}
			if(node["expectedFinishTime"] != null)
			{
				this._ExpectedFinishTime = ParseInt(node["expectedFinishTime"].Value<string>());
			}
			if(node["serviceType"] != null)
			{
				this._ServiceType = (VendorServiceType)ParseEnum(typeof(VendorServiceType), node["serviceType"].Value<string>());
			}
			if(node["serviceFeature"] != null)
			{
				this._ServiceFeature = (VendorServiceFeature)ParseEnum(typeof(VendorServiceFeature), node["serviceFeature"].Value<string>());
			}
			if(node["turnAroundTime"] != null)
			{
				this._TurnAroundTime = (VendorServiceTurnAroundTime)ParseEnum(typeof(VendorServiceTurnAroundTime), node["turnAroundTime"].Value<string>());
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
			kparams.AddIfNotNull("taskJobData", this._TaskJobData);
			kparams.AddIfNotNull("expectedFinishTime", this._ExpectedFinishTime);
			kparams.AddIfNotNull("serviceType", this._ServiceType);
			kparams.AddIfNotNull("serviceFeature", this._ServiceFeature);
			kparams.AddIfNotNull("turnAroundTime", this._TurnAroundTime);
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
				case TASK_JOB_DATA:
					return "TaskJobData";
				case EXPECTED_FINISH_TIME:
					return "ExpectedFinishTime";
				case SERVICE_TYPE:
					return "ServiceType";
				case SERVICE_FEATURE:
					return "ServiceFeature";
				case TURN_AROUND_TIME:
					return "TurnAroundTime";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

