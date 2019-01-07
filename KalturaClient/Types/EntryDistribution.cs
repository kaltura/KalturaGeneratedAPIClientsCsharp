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
	public class EntryDistribution : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string SUBMITTED_AT = "submittedAt";
		public const string ENTRY_ID = "entryId";
		public const string PARTNER_ID = "partnerId";
		public const string DISTRIBUTION_PROFILE_ID = "distributionProfileId";
		public const string STATUS = "status";
		public const string SUN_STATUS = "sunStatus";
		public const string DIRTY_STATUS = "dirtyStatus";
		public const string THUMB_ASSET_IDS = "thumbAssetIds";
		public const string FLAVOR_ASSET_IDS = "flavorAssetIds";
		public const string ASSET_IDS = "assetIds";
		public const string SUNRISE = "sunrise";
		public const string SUNSET = "sunset";
		public const string REMOTE_ID = "remoteId";
		public const string PLAYS = "plays";
		public const string VIEWS = "views";
		public const string VALIDATION_ERRORS = "validationErrors";
		public const string ERROR_TYPE = "errorType";
		public const string ERROR_NUMBER = "errorNumber";
		public const string ERROR_DESCRIPTION = "errorDescription";
		public const string HAS_SUBMIT_RESULTS_LOG = "hasSubmitResultsLog";
		public const string HAS_SUBMIT_SENT_DATA_LOG = "hasSubmitSentDataLog";
		public const string HAS_UPDATE_RESULTS_LOG = "hasUpdateResultsLog";
		public const string HAS_UPDATE_SENT_DATA_LOG = "hasUpdateSentDataLog";
		public const string HAS_DELETE_RESULTS_LOG = "hasDeleteResultsLog";
		public const string HAS_DELETE_SENT_DATA_LOG = "hasDeleteSentDataLog";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _SubmittedAt = Int32.MinValue;
		private string _EntryId = null;
		private int _PartnerId = Int32.MinValue;
		private int _DistributionProfileId = Int32.MinValue;
		private EntryDistributionStatus _Status = (EntryDistributionStatus)Int32.MinValue;
		private EntryDistributionSunStatus _SunStatus = (EntryDistributionSunStatus)Int32.MinValue;
		private EntryDistributionFlag _DirtyStatus = (EntryDistributionFlag)Int32.MinValue;
		private string _ThumbAssetIds = null;
		private string _FlavorAssetIds = null;
		private string _AssetIds = null;
		private int _Sunrise = Int32.MinValue;
		private int _Sunset = Int32.MinValue;
		private string _RemoteId = null;
		private int _Plays = Int32.MinValue;
		private int _Views = Int32.MinValue;
		private IList<DistributionValidationError> _ValidationErrors;
		private BatchJobErrorTypes _ErrorType = (BatchJobErrorTypes)Int32.MinValue;
		private int _ErrorNumber = Int32.MinValue;
		private string _ErrorDescription = null;
		private NullableBoolean _HasSubmitResultsLog = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _HasSubmitSentDataLog = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _HasUpdateResultsLog = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _HasUpdateSentDataLog = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _HasDeleteResultsLog = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _HasDeleteSentDataLog = (NullableBoolean)Int32.MinValue;
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
		public int SubmittedAt
		{
			get { return _SubmittedAt; }
			private set 
			{ 
				_SubmittedAt = value;
				OnPropertyChanged("SubmittedAt");
			}
		}
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
		public int DistributionProfileId
		{
			get { return _DistributionProfileId; }
			set 
			{ 
				_DistributionProfileId = value;
				OnPropertyChanged("DistributionProfileId");
			}
		}
		[JsonProperty]
		public EntryDistributionStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public EntryDistributionSunStatus SunStatus
		{
			get { return _SunStatus; }
			private set 
			{ 
				_SunStatus = value;
				OnPropertyChanged("SunStatus");
			}
		}
		[JsonProperty]
		public EntryDistributionFlag DirtyStatus
		{
			get { return _DirtyStatus; }
			private set 
			{ 
				_DirtyStatus = value;
				OnPropertyChanged("DirtyStatus");
			}
		}
		[JsonProperty]
		public string ThumbAssetIds
		{
			get { return _ThumbAssetIds; }
			set 
			{ 
				_ThumbAssetIds = value;
				OnPropertyChanged("ThumbAssetIds");
			}
		}
		[JsonProperty]
		public string FlavorAssetIds
		{
			get { return _FlavorAssetIds; }
			set 
			{ 
				_FlavorAssetIds = value;
				OnPropertyChanged("FlavorAssetIds");
			}
		}
		[JsonProperty]
		public string AssetIds
		{
			get { return _AssetIds; }
			set 
			{ 
				_AssetIds = value;
				OnPropertyChanged("AssetIds");
			}
		}
		[JsonProperty]
		public int Sunrise
		{
			get { return _Sunrise; }
			set 
			{ 
				_Sunrise = value;
				OnPropertyChanged("Sunrise");
			}
		}
		[JsonProperty]
		public int Sunset
		{
			get { return _Sunset; }
			set 
			{ 
				_Sunset = value;
				OnPropertyChanged("Sunset");
			}
		}
		[JsonProperty]
		public string RemoteId
		{
			get { return _RemoteId; }
			private set 
			{ 
				_RemoteId = value;
				OnPropertyChanged("RemoteId");
			}
		}
		[JsonProperty]
		public int Plays
		{
			get { return _Plays; }
			private set 
			{ 
				_Plays = value;
				OnPropertyChanged("Plays");
			}
		}
		[JsonProperty]
		public int Views
		{
			get { return _Views; }
			private set 
			{ 
				_Views = value;
				OnPropertyChanged("Views");
			}
		}
		[JsonProperty]
		public IList<DistributionValidationError> ValidationErrors
		{
			get { return _ValidationErrors; }
			set 
			{ 
				_ValidationErrors = value;
				OnPropertyChanged("ValidationErrors");
			}
		}
		[JsonProperty]
		public BatchJobErrorTypes ErrorType
		{
			get { return _ErrorType; }
			private set 
			{ 
				_ErrorType = value;
				OnPropertyChanged("ErrorType");
			}
		}
		[JsonProperty]
		public int ErrorNumber
		{
			get { return _ErrorNumber; }
			private set 
			{ 
				_ErrorNumber = value;
				OnPropertyChanged("ErrorNumber");
			}
		}
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
		[JsonProperty]
		public NullableBoolean HasSubmitResultsLog
		{
			get { return _HasSubmitResultsLog; }
			private set 
			{ 
				_HasSubmitResultsLog = value;
				OnPropertyChanged("HasSubmitResultsLog");
			}
		}
		[JsonProperty]
		public NullableBoolean HasSubmitSentDataLog
		{
			get { return _HasSubmitSentDataLog; }
			private set 
			{ 
				_HasSubmitSentDataLog = value;
				OnPropertyChanged("HasSubmitSentDataLog");
			}
		}
		[JsonProperty]
		public NullableBoolean HasUpdateResultsLog
		{
			get { return _HasUpdateResultsLog; }
			private set 
			{ 
				_HasUpdateResultsLog = value;
				OnPropertyChanged("HasUpdateResultsLog");
			}
		}
		[JsonProperty]
		public NullableBoolean HasUpdateSentDataLog
		{
			get { return _HasUpdateSentDataLog; }
			private set 
			{ 
				_HasUpdateSentDataLog = value;
				OnPropertyChanged("HasUpdateSentDataLog");
			}
		}
		[JsonProperty]
		public NullableBoolean HasDeleteResultsLog
		{
			get { return _HasDeleteResultsLog; }
			private set 
			{ 
				_HasDeleteResultsLog = value;
				OnPropertyChanged("HasDeleteResultsLog");
			}
		}
		[JsonProperty]
		public NullableBoolean HasDeleteSentDataLog
		{
			get { return _HasDeleteSentDataLog; }
			private set 
			{ 
				_HasDeleteSentDataLog = value;
				OnPropertyChanged("HasDeleteSentDataLog");
			}
		}
		#endregion

		#region CTor
		public EntryDistribution()
		{
		}

		public EntryDistribution(JToken node) : base(node)
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
			if(node["submittedAt"] != null)
			{
				this._SubmittedAt = ParseInt(node["submittedAt"].Value<string>());
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["distributionProfileId"] != null)
			{
				this._DistributionProfileId = ParseInt(node["distributionProfileId"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (EntryDistributionStatus)ParseEnum(typeof(EntryDistributionStatus), node["status"].Value<string>());
			}
			if(node["sunStatus"] != null)
			{
				this._SunStatus = (EntryDistributionSunStatus)ParseEnum(typeof(EntryDistributionSunStatus), node["sunStatus"].Value<string>());
			}
			if(node["dirtyStatus"] != null)
			{
				this._DirtyStatus = (EntryDistributionFlag)ParseEnum(typeof(EntryDistributionFlag), node["dirtyStatus"].Value<string>());
			}
			if(node["thumbAssetIds"] != null)
			{
				this._ThumbAssetIds = node["thumbAssetIds"].Value<string>();
			}
			if(node["flavorAssetIds"] != null)
			{
				this._FlavorAssetIds = node["flavorAssetIds"].Value<string>();
			}
			if(node["assetIds"] != null)
			{
				this._AssetIds = node["assetIds"].Value<string>();
			}
			if(node["sunrise"] != null)
			{
				this._Sunrise = ParseInt(node["sunrise"].Value<string>());
			}
			if(node["sunset"] != null)
			{
				this._Sunset = ParseInt(node["sunset"].Value<string>());
			}
			if(node["remoteId"] != null)
			{
				this._RemoteId = node["remoteId"].Value<string>();
			}
			if(node["plays"] != null)
			{
				this._Plays = ParseInt(node["plays"].Value<string>());
			}
			if(node["views"] != null)
			{
				this._Views = ParseInt(node["views"].Value<string>());
			}
			if(node["validationErrors"] != null)
			{
				this._ValidationErrors = new List<DistributionValidationError>();
				foreach(var arrayNode in node["validationErrors"].Children())
				{
					this._ValidationErrors.Add(ObjectFactory.Create<DistributionValidationError>(arrayNode));
				}
			}
			if(node["errorType"] != null)
			{
				this._ErrorType = (BatchJobErrorTypes)ParseEnum(typeof(BatchJobErrorTypes), node["errorType"].Value<string>());
			}
			if(node["errorNumber"] != null)
			{
				this._ErrorNumber = ParseInt(node["errorNumber"].Value<string>());
			}
			if(node["errorDescription"] != null)
			{
				this._ErrorDescription = node["errorDescription"].Value<string>();
			}
			if(node["hasSubmitResultsLog"] != null)
			{
				this._HasSubmitResultsLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["hasSubmitResultsLog"].Value<string>());
			}
			if(node["hasSubmitSentDataLog"] != null)
			{
				this._HasSubmitSentDataLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["hasSubmitSentDataLog"].Value<string>());
			}
			if(node["hasUpdateResultsLog"] != null)
			{
				this._HasUpdateResultsLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["hasUpdateResultsLog"].Value<string>());
			}
			if(node["hasUpdateSentDataLog"] != null)
			{
				this._HasUpdateSentDataLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["hasUpdateSentDataLog"].Value<string>());
			}
			if(node["hasDeleteResultsLog"] != null)
			{
				this._HasDeleteResultsLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["hasDeleteResultsLog"].Value<string>());
			}
			if(node["hasDeleteSentDataLog"] != null)
			{
				this._HasDeleteSentDataLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["hasDeleteSentDataLog"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryDistribution");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("submittedAt", this._SubmittedAt);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("distributionProfileId", this._DistributionProfileId);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("sunStatus", this._SunStatus);
			kparams.AddIfNotNull("dirtyStatus", this._DirtyStatus);
			kparams.AddIfNotNull("thumbAssetIds", this._ThumbAssetIds);
			kparams.AddIfNotNull("flavorAssetIds", this._FlavorAssetIds);
			kparams.AddIfNotNull("assetIds", this._AssetIds);
			kparams.AddIfNotNull("sunrise", this._Sunrise);
			kparams.AddIfNotNull("sunset", this._Sunset);
			kparams.AddIfNotNull("remoteId", this._RemoteId);
			kparams.AddIfNotNull("plays", this._Plays);
			kparams.AddIfNotNull("views", this._Views);
			kparams.AddIfNotNull("validationErrors", this._ValidationErrors);
			kparams.AddIfNotNull("errorType", this._ErrorType);
			kparams.AddIfNotNull("errorNumber", this._ErrorNumber);
			kparams.AddIfNotNull("errorDescription", this._ErrorDescription);
			kparams.AddIfNotNull("hasSubmitResultsLog", this._HasSubmitResultsLog);
			kparams.AddIfNotNull("hasSubmitSentDataLog", this._HasSubmitSentDataLog);
			kparams.AddIfNotNull("hasUpdateResultsLog", this._HasUpdateResultsLog);
			kparams.AddIfNotNull("hasUpdateSentDataLog", this._HasUpdateSentDataLog);
			kparams.AddIfNotNull("hasDeleteResultsLog", this._HasDeleteResultsLog);
			kparams.AddIfNotNull("hasDeleteSentDataLog", this._HasDeleteSentDataLog);
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
				case SUBMITTED_AT:
					return "SubmittedAt";
				case ENTRY_ID:
					return "EntryId";
				case PARTNER_ID:
					return "PartnerId";
				case DISTRIBUTION_PROFILE_ID:
					return "DistributionProfileId";
				case STATUS:
					return "Status";
				case SUN_STATUS:
					return "SunStatus";
				case DIRTY_STATUS:
					return "DirtyStatus";
				case THUMB_ASSET_IDS:
					return "ThumbAssetIds";
				case FLAVOR_ASSET_IDS:
					return "FlavorAssetIds";
				case ASSET_IDS:
					return "AssetIds";
				case SUNRISE:
					return "Sunrise";
				case SUNSET:
					return "Sunset";
				case REMOTE_ID:
					return "RemoteId";
				case PLAYS:
					return "Plays";
				case VIEWS:
					return "Views";
				case VALIDATION_ERRORS:
					return "ValidationErrors";
				case ERROR_TYPE:
					return "ErrorType";
				case ERROR_NUMBER:
					return "ErrorNumber";
				case ERROR_DESCRIPTION:
					return "ErrorDescription";
				case HAS_SUBMIT_RESULTS_LOG:
					return "HasSubmitResultsLog";
				case HAS_SUBMIT_SENT_DATA_LOG:
					return "HasSubmitSentDataLog";
				case HAS_UPDATE_RESULTS_LOG:
					return "HasUpdateResultsLog";
				case HAS_UPDATE_SENT_DATA_LOG:
					return "HasUpdateSentDataLog";
				case HAS_DELETE_RESULTS_LOG:
					return "HasDeleteResultsLog";
				case HAS_DELETE_SENT_DATA_LOG:
					return "HasDeleteSentDataLog";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

