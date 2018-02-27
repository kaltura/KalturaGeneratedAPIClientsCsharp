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
		public int SubmittedAt
		{
			get { return _SubmittedAt; }
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
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int DistributionProfileId
		{
			get { return _DistributionProfileId; }
			set 
			{ 
				_DistributionProfileId = value;
				OnPropertyChanged("DistributionProfileId");
			}
		}
		public EntryDistributionStatus Status
		{
			get { return _Status; }
		}
		public EntryDistributionSunStatus SunStatus
		{
			get { return _SunStatus; }
		}
		public EntryDistributionFlag DirtyStatus
		{
			get { return _DirtyStatus; }
		}
		public string ThumbAssetIds
		{
			get { return _ThumbAssetIds; }
			set 
			{ 
				_ThumbAssetIds = value;
				OnPropertyChanged("ThumbAssetIds");
			}
		}
		public string FlavorAssetIds
		{
			get { return _FlavorAssetIds; }
			set 
			{ 
				_FlavorAssetIds = value;
				OnPropertyChanged("FlavorAssetIds");
			}
		}
		public string AssetIds
		{
			get { return _AssetIds; }
			set 
			{ 
				_AssetIds = value;
				OnPropertyChanged("AssetIds");
			}
		}
		public int Sunrise
		{
			get { return _Sunrise; }
			set 
			{ 
				_Sunrise = value;
				OnPropertyChanged("Sunrise");
			}
		}
		public int Sunset
		{
			get { return _Sunset; }
			set 
			{ 
				_Sunset = value;
				OnPropertyChanged("Sunset");
			}
		}
		public string RemoteId
		{
			get { return _RemoteId; }
		}
		public int Plays
		{
			get { return _Plays; }
		}
		public int Views
		{
			get { return _Views; }
		}
		public IList<DistributionValidationError> ValidationErrors
		{
			get { return _ValidationErrors; }
			set 
			{ 
				_ValidationErrors = value;
				OnPropertyChanged("ValidationErrors");
			}
		}
		public BatchJobErrorTypes ErrorType
		{
			get { return _ErrorType; }
		}
		public int ErrorNumber
		{
			get { return _ErrorNumber; }
		}
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
		}
		public NullableBoolean HasSubmitResultsLog
		{
			get { return _HasSubmitResultsLog; }
		}
		public NullableBoolean HasSubmitSentDataLog
		{
			get { return _HasSubmitSentDataLog; }
		}
		public NullableBoolean HasUpdateResultsLog
		{
			get { return _HasUpdateResultsLog; }
		}
		public NullableBoolean HasUpdateSentDataLog
		{
			get { return _HasUpdateSentDataLog; }
		}
		public NullableBoolean HasDeleteResultsLog
		{
			get { return _HasDeleteResultsLog; }
		}
		public NullableBoolean HasDeleteSentDataLog
		{
			get { return _HasDeleteSentDataLog; }
		}
		#endregion

		#region CTor
		public EntryDistribution()
		{
		}

		public EntryDistribution(XmlElement node) : base(node)
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
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "submittedAt":
						this._SubmittedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "distributionProfileId":
						this._DistributionProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (EntryDistributionStatus)ParseEnum(typeof(EntryDistributionStatus), propertyNode.InnerText);
						continue;
					case "sunStatus":
						this._SunStatus = (EntryDistributionSunStatus)ParseEnum(typeof(EntryDistributionSunStatus), propertyNode.InnerText);
						continue;
					case "dirtyStatus":
						this._DirtyStatus = (EntryDistributionFlag)ParseEnum(typeof(EntryDistributionFlag), propertyNode.InnerText);
						continue;
					case "thumbAssetIds":
						this._ThumbAssetIds = propertyNode.InnerText;
						continue;
					case "flavorAssetIds":
						this._FlavorAssetIds = propertyNode.InnerText;
						continue;
					case "assetIds":
						this._AssetIds = propertyNode.InnerText;
						continue;
					case "sunrise":
						this._Sunrise = ParseInt(propertyNode.InnerText);
						continue;
					case "sunset":
						this._Sunset = ParseInt(propertyNode.InnerText);
						continue;
					case "remoteId":
						this._RemoteId = propertyNode.InnerText;
						continue;
					case "plays":
						this._Plays = ParseInt(propertyNode.InnerText);
						continue;
					case "views":
						this._Views = ParseInt(propertyNode.InnerText);
						continue;
					case "validationErrors":
						this._ValidationErrors = new List<DistributionValidationError>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._ValidationErrors.Add(ObjectFactory.Create<DistributionValidationError>(arrayNode));
						}
						continue;
					case "errorType":
						this._ErrorType = (BatchJobErrorTypes)ParseEnum(typeof(BatchJobErrorTypes), propertyNode.InnerText);
						continue;
					case "errorNumber":
						this._ErrorNumber = ParseInt(propertyNode.InnerText);
						continue;
					case "errorDescription":
						this._ErrorDescription = propertyNode.InnerText;
						continue;
					case "hasSubmitResultsLog":
						this._HasSubmitResultsLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "hasSubmitSentDataLog":
						this._HasSubmitSentDataLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "hasUpdateResultsLog":
						this._HasUpdateResultsLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "hasUpdateSentDataLog":
						this._HasUpdateSentDataLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "hasDeleteResultsLog":
						this._HasDeleteResultsLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "hasDeleteSentDataLog":
						this._HasDeleteSentDataLog = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
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

