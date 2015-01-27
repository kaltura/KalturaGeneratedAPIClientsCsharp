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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaEntryDistribution : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _SubmittedAt = Int32.MinValue;
		private string _EntryId = null;
		private int _PartnerId = Int32.MinValue;
		private int _DistributionProfileId = Int32.MinValue;
		private KalturaEntryDistributionStatus _Status = (KalturaEntryDistributionStatus)Int32.MinValue;
		private KalturaEntryDistributionSunStatus _SunStatus = (KalturaEntryDistributionSunStatus)Int32.MinValue;
		private KalturaEntryDistributionFlag _DirtyStatus = (KalturaEntryDistributionFlag)Int32.MinValue;
		private string _ThumbAssetIds = null;
		private string _FlavorAssetIds = null;
		private string _AssetIds = null;
		private int _Sunrise = Int32.MinValue;
		private int _Sunset = Int32.MinValue;
		private string _RemoteId = null;
		private int _Plays = Int32.MinValue;
		private int _Views = Int32.MinValue;
		private IList<KalturaDistributionValidationError> _ValidationErrors;
		private KalturaBatchJobErrorTypes _ErrorType = (KalturaBatchJobErrorTypes)Int32.MinValue;
		private int _ErrorNumber = Int32.MinValue;
		private string _ErrorDescription = null;
		private KalturaNullableBoolean _HasSubmitResultsLog = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _HasSubmitSentDataLog = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _HasUpdateResultsLog = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _HasUpdateSentDataLog = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _HasDeleteResultsLog = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _HasDeleteSentDataLog = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		public int SubmittedAt
		{
			get { return _SubmittedAt; }
			set 
			{ 
				_SubmittedAt = value;
				OnPropertyChanged("SubmittedAt");
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
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
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
		public KalturaEntryDistributionStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaEntryDistributionSunStatus SunStatus
		{
			get { return _SunStatus; }
			set 
			{ 
				_SunStatus = value;
				OnPropertyChanged("SunStatus");
			}
		}
		public KalturaEntryDistributionFlag DirtyStatus
		{
			get { return _DirtyStatus; }
			set 
			{ 
				_DirtyStatus = value;
				OnPropertyChanged("DirtyStatus");
			}
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
			set 
			{ 
				_RemoteId = value;
				OnPropertyChanged("RemoteId");
			}
		}
		public int Plays
		{
			get { return _Plays; }
			set 
			{ 
				_Plays = value;
				OnPropertyChanged("Plays");
			}
		}
		public int Views
		{
			get { return _Views; }
			set 
			{ 
				_Views = value;
				OnPropertyChanged("Views");
			}
		}
		public IList<KalturaDistributionValidationError> ValidationErrors
		{
			get { return _ValidationErrors; }
			set 
			{ 
				_ValidationErrors = value;
				OnPropertyChanged("ValidationErrors");
			}
		}
		public KalturaBatchJobErrorTypes ErrorType
		{
			get { return _ErrorType; }
			set 
			{ 
				_ErrorType = value;
				OnPropertyChanged("ErrorType");
			}
		}
		public int ErrorNumber
		{
			get { return _ErrorNumber; }
			set 
			{ 
				_ErrorNumber = value;
				OnPropertyChanged("ErrorNumber");
			}
		}
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		public KalturaNullableBoolean HasSubmitResultsLog
		{
			get { return _HasSubmitResultsLog; }
			set 
			{ 
				_HasSubmitResultsLog = value;
				OnPropertyChanged("HasSubmitResultsLog");
			}
		}
		public KalturaNullableBoolean HasSubmitSentDataLog
		{
			get { return _HasSubmitSentDataLog; }
			set 
			{ 
				_HasSubmitSentDataLog = value;
				OnPropertyChanged("HasSubmitSentDataLog");
			}
		}
		public KalturaNullableBoolean HasUpdateResultsLog
		{
			get { return _HasUpdateResultsLog; }
			set 
			{ 
				_HasUpdateResultsLog = value;
				OnPropertyChanged("HasUpdateResultsLog");
			}
		}
		public KalturaNullableBoolean HasUpdateSentDataLog
		{
			get { return _HasUpdateSentDataLog; }
			set 
			{ 
				_HasUpdateSentDataLog = value;
				OnPropertyChanged("HasUpdateSentDataLog");
			}
		}
		public KalturaNullableBoolean HasDeleteResultsLog
		{
			get { return _HasDeleteResultsLog; }
			set 
			{ 
				_HasDeleteResultsLog = value;
				OnPropertyChanged("HasDeleteResultsLog");
			}
		}
		public KalturaNullableBoolean HasDeleteSentDataLog
		{
			get { return _HasDeleteSentDataLog; }
			set 
			{ 
				_HasDeleteSentDataLog = value;
				OnPropertyChanged("HasDeleteSentDataLog");
			}
		}
		#endregion

		#region CTor
		public KalturaEntryDistribution()
		{
		}

		public KalturaEntryDistribution(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "submittedAt":
						this.SubmittedAt = ParseInt(txt);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "distributionProfileId":
						this.DistributionProfileId = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaEntryDistributionStatus)ParseEnum(typeof(KalturaEntryDistributionStatus), txt);
						continue;
					case "sunStatus":
						this.SunStatus = (KalturaEntryDistributionSunStatus)ParseEnum(typeof(KalturaEntryDistributionSunStatus), txt);
						continue;
					case "dirtyStatus":
						this.DirtyStatus = (KalturaEntryDistributionFlag)ParseEnum(typeof(KalturaEntryDistributionFlag), txt);
						continue;
					case "thumbAssetIds":
						this.ThumbAssetIds = txt;
						continue;
					case "flavorAssetIds":
						this.FlavorAssetIds = txt;
						continue;
					case "assetIds":
						this.AssetIds = txt;
						continue;
					case "sunrise":
						this.Sunrise = ParseInt(txt);
						continue;
					case "sunset":
						this.Sunset = ParseInt(txt);
						continue;
					case "remoteId":
						this.RemoteId = txt;
						continue;
					case "plays":
						this.Plays = ParseInt(txt);
						continue;
					case "views":
						this.Views = ParseInt(txt);
						continue;
					case "validationErrors":
						this.ValidationErrors = new List<KalturaDistributionValidationError>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.ValidationErrors.Add((KalturaDistributionValidationError)KalturaObjectFactory.Create(arrayNode, "KalturaDistributionValidationError"));
						}
						continue;
					case "errorType":
						this.ErrorType = (KalturaBatchJobErrorTypes)ParseEnum(typeof(KalturaBatchJobErrorTypes), txt);
						continue;
					case "errorNumber":
						this.ErrorNumber = ParseInt(txt);
						continue;
					case "errorDescription":
						this.ErrorDescription = txt;
						continue;
					case "hasSubmitResultsLog":
						this.HasSubmitResultsLog = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "hasSubmitSentDataLog":
						this.HasSubmitSentDataLog = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "hasUpdateResultsLog":
						this.HasUpdateResultsLog = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "hasUpdateSentDataLog":
						this.HasUpdateSentDataLog = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "hasDeleteResultsLog":
						this.HasDeleteResultsLog = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "hasDeleteSentDataLog":
						this.HasDeleteSentDataLog = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEntryDistribution");
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIntIfNotNull("submittedAt", this.SubmittedAt);
			kparams.AddStringIfNotNull("entryId", this.EntryId);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddIntIfNotNull("distributionProfileId", this.DistributionProfileId);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddEnumIfNotNull("sunStatus", this.SunStatus);
			kparams.AddEnumIfNotNull("dirtyStatus", this.DirtyStatus);
			kparams.AddStringIfNotNull("thumbAssetIds", this.ThumbAssetIds);
			kparams.AddStringIfNotNull("flavorAssetIds", this.FlavorAssetIds);
			kparams.AddStringIfNotNull("assetIds", this.AssetIds);
			kparams.AddIntIfNotNull("sunrise", this.Sunrise);
			kparams.AddIntIfNotNull("sunset", this.Sunset);
			kparams.AddStringIfNotNull("remoteId", this.RemoteId);
			kparams.AddIntIfNotNull("plays", this.Plays);
			kparams.AddIntIfNotNull("views", this.Views);
			if (this.ValidationErrors != null)
			{
				if (this.ValidationErrors.Count == 0)
				{
					kparams.Add("validationErrors:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaDistributionValidationError item in this.ValidationErrors)
					{
						kparams.Add("validationErrors:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddEnumIfNotNull("errorType", this.ErrorType);
			kparams.AddIntIfNotNull("errorNumber", this.ErrorNumber);
			kparams.AddStringIfNotNull("errorDescription", this.ErrorDescription);
			kparams.AddEnumIfNotNull("hasSubmitResultsLog", this.HasSubmitResultsLog);
			kparams.AddEnumIfNotNull("hasSubmitSentDataLog", this.HasSubmitSentDataLog);
			kparams.AddEnumIfNotNull("hasUpdateResultsLog", this.HasUpdateResultsLog);
			kparams.AddEnumIfNotNull("hasUpdateSentDataLog", this.HasUpdateSentDataLog);
			kparams.AddEnumIfNotNull("hasDeleteResultsLog", this.HasDeleteResultsLog);
			kparams.AddEnumIfNotNull("hasDeleteSentDataLog", this.HasDeleteSentDataLog);
			return kparams;
		}
		#endregion
	}
}

