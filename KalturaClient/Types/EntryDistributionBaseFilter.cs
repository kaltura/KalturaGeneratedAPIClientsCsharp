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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class EntryDistributionBaseFilter : RelatedFilter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string SUBMITTED_AT_GREATER_THAN_OR_EQUAL = "submittedAtGreaterThanOrEqual";
		public const string SUBMITTED_AT_LESS_THAN_OR_EQUAL = "submittedAtLessThanOrEqual";
		public const string ENTRY_ID_EQUAL = "entryIdEqual";
		public const string ENTRY_ID_IN = "entryIdIn";
		public const string DISTRIBUTION_PROFILE_ID_EQUAL = "distributionProfileIdEqual";
		public const string DISTRIBUTION_PROFILE_ID_IN = "distributionProfileIdIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string DIRTY_STATUS_EQUAL = "dirtyStatusEqual";
		public const string DIRTY_STATUS_IN = "dirtyStatusIn";
		public const string SUNRISE_GREATER_THAN_OR_EQUAL = "sunriseGreaterThanOrEqual";
		public const string SUNRISE_LESS_THAN_OR_EQUAL = "sunriseLessThanOrEqual";
		public const string SUNSET_GREATER_THAN_OR_EQUAL = "sunsetGreaterThanOrEqual";
		public const string SUNSET_LESS_THAN_OR_EQUAL = "sunsetLessThanOrEqual";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _SubmittedAtGreaterThanOrEqual = Int32.MinValue;
		private int _SubmittedAtLessThanOrEqual = Int32.MinValue;
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private int _DistributionProfileIdEqual = Int32.MinValue;
		private string _DistributionProfileIdIn = null;
		private EntryDistributionStatus _StatusEqual = (EntryDistributionStatus)Int32.MinValue;
		private string _StatusIn = null;
		private EntryDistributionFlag _DirtyStatusEqual = (EntryDistributionFlag)Int32.MinValue;
		private string _DirtyStatusIn = null;
		private int _SunriseGreaterThanOrEqual = Int32.MinValue;
		private int _SunriseLessThanOrEqual = Int32.MinValue;
		private int _SunsetGreaterThanOrEqual = Int32.MinValue;
		private int _SunsetLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		[JsonProperty]
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		[JsonProperty]
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int SubmittedAtGreaterThanOrEqual
		{
			get { return _SubmittedAtGreaterThanOrEqual; }
			set 
			{ 
				_SubmittedAtGreaterThanOrEqual = value;
				OnPropertyChanged("SubmittedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int SubmittedAtLessThanOrEqual
		{
			get { return _SubmittedAtLessThanOrEqual; }
			set 
			{ 
				_SubmittedAtLessThanOrEqual = value;
				OnPropertyChanged("SubmittedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		[JsonProperty]
		public string EntryIdIn
		{
			get { return _EntryIdIn; }
			set 
			{ 
				_EntryIdIn = value;
				OnPropertyChanged("EntryIdIn");
			}
		}
		[JsonProperty]
		public int DistributionProfileIdEqual
		{
			get { return _DistributionProfileIdEqual; }
			set 
			{ 
				_DistributionProfileIdEqual = value;
				OnPropertyChanged("DistributionProfileIdEqual");
			}
		}
		[JsonProperty]
		public string DistributionProfileIdIn
		{
			get { return _DistributionProfileIdIn; }
			set 
			{ 
				_DistributionProfileIdIn = value;
				OnPropertyChanged("DistributionProfileIdIn");
			}
		}
		[JsonProperty]
		public EntryDistributionStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		[JsonProperty]
		public EntryDistributionFlag DirtyStatusEqual
		{
			get { return _DirtyStatusEqual; }
			set 
			{ 
				_DirtyStatusEqual = value;
				OnPropertyChanged("DirtyStatusEqual");
			}
		}
		[JsonProperty]
		public string DirtyStatusIn
		{
			get { return _DirtyStatusIn; }
			set 
			{ 
				_DirtyStatusIn = value;
				OnPropertyChanged("DirtyStatusIn");
			}
		}
		[JsonProperty]
		public int SunriseGreaterThanOrEqual
		{
			get { return _SunriseGreaterThanOrEqual; }
			set 
			{ 
				_SunriseGreaterThanOrEqual = value;
				OnPropertyChanged("SunriseGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int SunriseLessThanOrEqual
		{
			get { return _SunriseLessThanOrEqual; }
			set 
			{ 
				_SunriseLessThanOrEqual = value;
				OnPropertyChanged("SunriseLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int SunsetGreaterThanOrEqual
		{
			get { return _SunsetGreaterThanOrEqual; }
			set 
			{ 
				_SunsetGreaterThanOrEqual = value;
				OnPropertyChanged("SunsetGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int SunsetLessThanOrEqual
		{
			get { return _SunsetLessThanOrEqual; }
			set 
			{ 
				_SunsetLessThanOrEqual = value;
				OnPropertyChanged("SunsetLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public EntryDistributionBaseFilter()
		{
		}

		public EntryDistributionBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseInt(node["idEqual"].Value<string>());
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["submittedAtGreaterThanOrEqual"] != null)
			{
				this._SubmittedAtGreaterThanOrEqual = ParseInt(node["submittedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["submittedAtLessThanOrEqual"] != null)
			{
				this._SubmittedAtLessThanOrEqual = ParseInt(node["submittedAtLessThanOrEqual"].Value<string>());
			}
			if(node["entryIdEqual"] != null)
			{
				this._EntryIdEqual = node["entryIdEqual"].Value<string>();
			}
			if(node["entryIdIn"] != null)
			{
				this._EntryIdIn = node["entryIdIn"].Value<string>();
			}
			if(node["distributionProfileIdEqual"] != null)
			{
				this._DistributionProfileIdEqual = ParseInt(node["distributionProfileIdEqual"].Value<string>());
			}
			if(node["distributionProfileIdIn"] != null)
			{
				this._DistributionProfileIdIn = node["distributionProfileIdIn"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (EntryDistributionStatus)ParseEnum(typeof(EntryDistributionStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["dirtyStatusEqual"] != null)
			{
				this._DirtyStatusEqual = (EntryDistributionFlag)ParseEnum(typeof(EntryDistributionFlag), node["dirtyStatusEqual"].Value<string>());
			}
			if(node["dirtyStatusIn"] != null)
			{
				this._DirtyStatusIn = node["dirtyStatusIn"].Value<string>();
			}
			if(node["sunriseGreaterThanOrEqual"] != null)
			{
				this._SunriseGreaterThanOrEqual = ParseInt(node["sunriseGreaterThanOrEqual"].Value<string>());
			}
			if(node["sunriseLessThanOrEqual"] != null)
			{
				this._SunriseLessThanOrEqual = ParseInt(node["sunriseLessThanOrEqual"].Value<string>());
			}
			if(node["sunsetGreaterThanOrEqual"] != null)
			{
				this._SunsetGreaterThanOrEqual = ParseInt(node["sunsetGreaterThanOrEqual"].Value<string>());
			}
			if(node["sunsetLessThanOrEqual"] != null)
			{
				this._SunsetLessThanOrEqual = ParseInt(node["sunsetLessThanOrEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryDistributionBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("submittedAtGreaterThanOrEqual", this._SubmittedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("submittedAtLessThanOrEqual", this._SubmittedAtLessThanOrEqual);
			kparams.AddIfNotNull("entryIdEqual", this._EntryIdEqual);
			kparams.AddIfNotNull("entryIdIn", this._EntryIdIn);
			kparams.AddIfNotNull("distributionProfileIdEqual", this._DistributionProfileIdEqual);
			kparams.AddIfNotNull("distributionProfileIdIn", this._DistributionProfileIdIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("dirtyStatusEqual", this._DirtyStatusEqual);
			kparams.AddIfNotNull("dirtyStatusIn", this._DirtyStatusIn);
			kparams.AddIfNotNull("sunriseGreaterThanOrEqual", this._SunriseGreaterThanOrEqual);
			kparams.AddIfNotNull("sunriseLessThanOrEqual", this._SunriseLessThanOrEqual);
			kparams.AddIfNotNull("sunsetGreaterThanOrEqual", this._SunsetGreaterThanOrEqual);
			kparams.AddIfNotNull("sunsetLessThanOrEqual", this._SunsetLessThanOrEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case ID_IN:
					return "IdIn";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case SUBMITTED_AT_GREATER_THAN_OR_EQUAL:
					return "SubmittedAtGreaterThanOrEqual";
				case SUBMITTED_AT_LESS_THAN_OR_EQUAL:
					return "SubmittedAtLessThanOrEqual";
				case ENTRY_ID_EQUAL:
					return "EntryIdEqual";
				case ENTRY_ID_IN:
					return "EntryIdIn";
				case DISTRIBUTION_PROFILE_ID_EQUAL:
					return "DistributionProfileIdEqual";
				case DISTRIBUTION_PROFILE_ID_IN:
					return "DistributionProfileIdIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case DIRTY_STATUS_EQUAL:
					return "DirtyStatusEqual";
				case DIRTY_STATUS_IN:
					return "DirtyStatusIn";
				case SUNRISE_GREATER_THAN_OR_EQUAL:
					return "SunriseGreaterThanOrEqual";
				case SUNRISE_LESS_THAN_OR_EQUAL:
					return "SunriseLessThanOrEqual";
				case SUNSET_GREATER_THAN_OR_EQUAL:
					return "SunsetGreaterThanOrEqual";
				case SUNSET_LESS_THAN_OR_EQUAL:
					return "SunsetLessThanOrEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

