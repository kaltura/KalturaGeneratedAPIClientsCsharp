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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class ContentDistributionSearchItem : SearchItem
	{
		#region Constants
		public const string NO_DISTRIBUTION_PROFILES = "noDistributionProfiles";
		public const string DISTRIBUTION_PROFILE_ID = "distributionProfileId";
		public const string DISTRIBUTION_SUN_STATUS = "distributionSunStatus";
		public const string ENTRY_DISTRIBUTION_FLAG = "entryDistributionFlag";
		public const string ENTRY_DISTRIBUTION_STATUS = "entryDistributionStatus";
		public const string HAS_ENTRY_DISTRIBUTION_VALIDATION_ERRORS = "hasEntryDistributionValidationErrors";
		public const string ENTRY_DISTRIBUTION_VALIDATION_ERRORS = "entryDistributionValidationErrors";
		#endregion

		#region Private Fields
		private bool? _NoDistributionProfiles = null;
		private int _DistributionProfileId = Int32.MinValue;
		private EntryDistributionSunStatus _DistributionSunStatus = (EntryDistributionSunStatus)Int32.MinValue;
		private EntryDistributionFlag _EntryDistributionFlag = (EntryDistributionFlag)Int32.MinValue;
		private EntryDistributionStatus _EntryDistributionStatus = (EntryDistributionStatus)Int32.MinValue;
		private bool? _HasEntryDistributionValidationErrors = null;
		private string _EntryDistributionValidationErrors = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use NoDistributionProfilesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? NoDistributionProfiles
		{
			get { return _NoDistributionProfiles; }
			set 
			{ 
				_NoDistributionProfiles = value;
				OnPropertyChanged("NoDistributionProfiles");
			}
		}
		/// <summary>
		/// Use DistributionProfileIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use DistributionSunStatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryDistributionSunStatus DistributionSunStatus
		{
			get { return _DistributionSunStatus; }
			set 
			{ 
				_DistributionSunStatus = value;
				OnPropertyChanged("DistributionSunStatus");
			}
		}
		/// <summary>
		/// Use EntryDistributionFlagAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryDistributionFlag EntryDistributionFlag
		{
			get { return _EntryDistributionFlag; }
			set 
			{ 
				_EntryDistributionFlag = value;
				OnPropertyChanged("EntryDistributionFlag");
			}
		}
		/// <summary>
		/// Use EntryDistributionStatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryDistributionStatus EntryDistributionStatus
		{
			get { return _EntryDistributionStatus; }
			set 
			{ 
				_EntryDistributionStatus = value;
				OnPropertyChanged("EntryDistributionStatus");
			}
		}
		/// <summary>
		/// Use HasEntryDistributionValidationErrorsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? HasEntryDistributionValidationErrors
		{
			get { return _HasEntryDistributionValidationErrors; }
			set 
			{ 
				_HasEntryDistributionValidationErrors = value;
				OnPropertyChanged("HasEntryDistributionValidationErrors");
			}
		}
		/// <summary>
		/// Use EntryDistributionValidationErrorsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryDistributionValidationErrors
		{
			get { return _EntryDistributionValidationErrors; }
			set 
			{ 
				_EntryDistributionValidationErrors = value;
				OnPropertyChanged("EntryDistributionValidationErrors");
			}
		}
		#endregion

		#region CTor
		public ContentDistributionSearchItem()
		{
		}

		public ContentDistributionSearchItem(JToken node) : base(node)
		{
			if(node["noDistributionProfiles"] != null)
			{
				this._NoDistributionProfiles = ParseBool(node["noDistributionProfiles"].Value<string>());
			}
			if(node["distributionProfileId"] != null)
			{
				this._DistributionProfileId = ParseInt(node["distributionProfileId"].Value<string>());
			}
			if(node["distributionSunStatus"] != null)
			{
				this._DistributionSunStatus = (EntryDistributionSunStatus)ParseEnum(typeof(EntryDistributionSunStatus), node["distributionSunStatus"].Value<string>());
			}
			if(node["entryDistributionFlag"] != null)
			{
				this._EntryDistributionFlag = (EntryDistributionFlag)ParseEnum(typeof(EntryDistributionFlag), node["entryDistributionFlag"].Value<string>());
			}
			if(node["entryDistributionStatus"] != null)
			{
				this._EntryDistributionStatus = (EntryDistributionStatus)ParseEnum(typeof(EntryDistributionStatus), node["entryDistributionStatus"].Value<string>());
			}
			if(node["hasEntryDistributionValidationErrors"] != null)
			{
				this._HasEntryDistributionValidationErrors = ParseBool(node["hasEntryDistributionValidationErrors"].Value<string>());
			}
			if(node["entryDistributionValidationErrors"] != null)
			{
				this._EntryDistributionValidationErrors = node["entryDistributionValidationErrors"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaContentDistributionSearchItem");
			kparams.AddIfNotNull("noDistributionProfiles", this._NoDistributionProfiles);
			kparams.AddIfNotNull("distributionProfileId", this._DistributionProfileId);
			kparams.AddIfNotNull("distributionSunStatus", this._DistributionSunStatus);
			kparams.AddIfNotNull("entryDistributionFlag", this._EntryDistributionFlag);
			kparams.AddIfNotNull("entryDistributionStatus", this._EntryDistributionStatus);
			kparams.AddIfNotNull("hasEntryDistributionValidationErrors", this._HasEntryDistributionValidationErrors);
			kparams.AddIfNotNull("entryDistributionValidationErrors", this._EntryDistributionValidationErrors);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case NO_DISTRIBUTION_PROFILES:
					return "NoDistributionProfiles";
				case DISTRIBUTION_PROFILE_ID:
					return "DistributionProfileId";
				case DISTRIBUTION_SUN_STATUS:
					return "DistributionSunStatus";
				case ENTRY_DISTRIBUTION_FLAG:
					return "EntryDistributionFlag";
				case ENTRY_DISTRIBUTION_STATUS:
					return "EntryDistributionStatus";
				case HAS_ENTRY_DISTRIBUTION_VALIDATION_ERRORS:
					return "HasEntryDistributionValidationErrors";
				case ENTRY_DISTRIBUTION_VALIDATION_ERRORS:
					return "EntryDistributionValidationErrors";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

