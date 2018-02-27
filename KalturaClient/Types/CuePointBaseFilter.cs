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
	public class CuePointBaseFilter : RelatedFilter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string CUE_POINT_TYPE_EQUAL = "cuePointTypeEqual";
		public const string CUE_POINT_TYPE_IN = "cuePointTypeIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string ENTRY_ID_EQUAL = "entryIdEqual";
		public const string ENTRY_ID_IN = "entryIdIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string TRIGGERED_AT_GREATER_THAN_OR_EQUAL = "triggeredAtGreaterThanOrEqual";
		public const string TRIGGERED_AT_LESS_THAN_OR_EQUAL = "triggeredAtLessThanOrEqual";
		public const string TAGS_LIKE = "tagsLike";
		public const string TAGS_MULTI_LIKE_OR = "tagsMultiLikeOr";
		public const string TAGS_MULTI_LIKE_AND = "tagsMultiLikeAnd";
		public const string START_TIME_GREATER_THAN_OR_EQUAL = "startTimeGreaterThanOrEqual";
		public const string START_TIME_LESS_THAN_OR_EQUAL = "startTimeLessThanOrEqual";
		public const string USER_ID_EQUAL = "userIdEqual";
		public const string USER_ID_IN = "userIdIn";
		public const string PARTNER_SORT_VALUE_EQUAL = "partnerSortValueEqual";
		public const string PARTNER_SORT_VALUE_IN = "partnerSortValueIn";
		public const string PARTNER_SORT_VALUE_GREATER_THAN_OR_EQUAL = "partnerSortValueGreaterThanOrEqual";
		public const string PARTNER_SORT_VALUE_LESS_THAN_OR_EQUAL = "partnerSortValueLessThanOrEqual";
		public const string FORCE_STOP_EQUAL = "forceStopEqual";
		public const string SYSTEM_NAME_EQUAL = "systemNameEqual";
		public const string SYSTEM_NAME_IN = "systemNameIn";
		#endregion

		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private CuePointType _CuePointTypeEqual = null;
		private string _CuePointTypeIn = null;
		private CuePointStatus _StatusEqual = (CuePointStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _TriggeredAtGreaterThanOrEqual = Int32.MinValue;
		private int _TriggeredAtLessThanOrEqual = Int32.MinValue;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private int _StartTimeGreaterThanOrEqual = Int32.MinValue;
		private int _StartTimeLessThanOrEqual = Int32.MinValue;
		private string _UserIdEqual = null;
		private string _UserIdIn = null;
		private int _PartnerSortValueEqual = Int32.MinValue;
		private string _PartnerSortValueIn = null;
		private int _PartnerSortValueGreaterThanOrEqual = Int32.MinValue;
		private int _PartnerSortValueLessThanOrEqual = Int32.MinValue;
		private NullableBoolean _ForceStopEqual = (NullableBoolean)Int32.MinValue;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		#endregion

		#region Properties
		public string IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public CuePointType CuePointTypeEqual
		{
			get { return _CuePointTypeEqual; }
			set 
			{ 
				_CuePointTypeEqual = value;
				OnPropertyChanged("CuePointTypeEqual");
			}
		}
		public string CuePointTypeIn
		{
			get { return _CuePointTypeIn; }
			set 
			{ 
				_CuePointTypeIn = value;
				OnPropertyChanged("CuePointTypeIn");
			}
		}
		public CuePointStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		public string EntryIdIn
		{
			get { return _EntryIdIn; }
			set 
			{ 
				_EntryIdIn = value;
				OnPropertyChanged("EntryIdIn");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public int TriggeredAtGreaterThanOrEqual
		{
			get { return _TriggeredAtGreaterThanOrEqual; }
			set 
			{ 
				_TriggeredAtGreaterThanOrEqual = value;
				OnPropertyChanged("TriggeredAtGreaterThanOrEqual");
			}
		}
		public int TriggeredAtLessThanOrEqual
		{
			get { return _TriggeredAtLessThanOrEqual; }
			set 
			{ 
				_TriggeredAtLessThanOrEqual = value;
				OnPropertyChanged("TriggeredAtLessThanOrEqual");
			}
		}
		public string TagsLike
		{
			get { return _TagsLike; }
			set 
			{ 
				_TagsLike = value;
				OnPropertyChanged("TagsLike");
			}
		}
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
			}
		}
		public int StartTimeGreaterThanOrEqual
		{
			get { return _StartTimeGreaterThanOrEqual; }
			set 
			{ 
				_StartTimeGreaterThanOrEqual = value;
				OnPropertyChanged("StartTimeGreaterThanOrEqual");
			}
		}
		public int StartTimeLessThanOrEqual
		{
			get { return _StartTimeLessThanOrEqual; }
			set 
			{ 
				_StartTimeLessThanOrEqual = value;
				OnPropertyChanged("StartTimeLessThanOrEqual");
			}
		}
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		public int PartnerSortValueEqual
		{
			get { return _PartnerSortValueEqual; }
			set 
			{ 
				_PartnerSortValueEqual = value;
				OnPropertyChanged("PartnerSortValueEqual");
			}
		}
		public string PartnerSortValueIn
		{
			get { return _PartnerSortValueIn; }
			set 
			{ 
				_PartnerSortValueIn = value;
				OnPropertyChanged("PartnerSortValueIn");
			}
		}
		public int PartnerSortValueGreaterThanOrEqual
		{
			get { return _PartnerSortValueGreaterThanOrEqual; }
			set 
			{ 
				_PartnerSortValueGreaterThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueGreaterThanOrEqual");
			}
		}
		public int PartnerSortValueLessThanOrEqual
		{
			get { return _PartnerSortValueLessThanOrEqual; }
			set 
			{ 
				_PartnerSortValueLessThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueLessThanOrEqual");
			}
		}
		public NullableBoolean ForceStopEqual
		{
			get { return _ForceStopEqual; }
			set 
			{ 
				_ForceStopEqual = value;
				OnPropertyChanged("ForceStopEqual");
			}
		}
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		#endregion

		#region CTor
		public CuePointBaseFilter()
		{
		}

		public CuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = propertyNode.InnerText;
						continue;
					case "idIn":
						this._IdIn = propertyNode.InnerText;
						continue;
					case "cuePointTypeEqual":
						this._CuePointTypeEqual = (CuePointType)StringEnum.Parse(typeof(CuePointType), propertyNode.InnerText);
						continue;
					case "cuePointTypeIn":
						this._CuePointTypeIn = propertyNode.InnerText;
						continue;
					case "statusEqual":
						this._StatusEqual = (CuePointStatus)ParseEnum(typeof(CuePointStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "entryIdEqual":
						this._EntryIdEqual = propertyNode.InnerText;
						continue;
					case "entryIdIn":
						this._EntryIdIn = propertyNode.InnerText;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "triggeredAtGreaterThanOrEqual":
						this._TriggeredAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "triggeredAtLessThanOrEqual":
						this._TriggeredAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "tagsLike":
						this._TagsLike = propertyNode.InnerText;
						continue;
					case "tagsMultiLikeOr":
						this._TagsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "tagsMultiLikeAnd":
						this._TagsMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "startTimeGreaterThanOrEqual":
						this._StartTimeGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "startTimeLessThanOrEqual":
						this._StartTimeLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "userIdEqual":
						this._UserIdEqual = propertyNode.InnerText;
						continue;
					case "userIdIn":
						this._UserIdIn = propertyNode.InnerText;
						continue;
					case "partnerSortValueEqual":
						this._PartnerSortValueEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerSortValueIn":
						this._PartnerSortValueIn = propertyNode.InnerText;
						continue;
					case "partnerSortValueGreaterThanOrEqual":
						this._PartnerSortValueGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerSortValueLessThanOrEqual":
						this._PartnerSortValueLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "forceStopEqual":
						this._ForceStopEqual = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "systemNameEqual":
						this._SystemNameEqual = propertyNode.InnerText;
						continue;
					case "systemNameIn":
						this._SystemNameIn = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaCuePointBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("cuePointTypeEqual", this._CuePointTypeEqual);
			kparams.AddIfNotNull("cuePointTypeIn", this._CuePointTypeIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("entryIdEqual", this._EntryIdEqual);
			kparams.AddIfNotNull("entryIdIn", this._EntryIdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("triggeredAtGreaterThanOrEqual", this._TriggeredAtGreaterThanOrEqual);
			kparams.AddIfNotNull("triggeredAtLessThanOrEqual", this._TriggeredAtLessThanOrEqual);
			kparams.AddIfNotNull("tagsLike", this._TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this._TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this._TagsMultiLikeAnd);
			kparams.AddIfNotNull("startTimeGreaterThanOrEqual", this._StartTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("startTimeLessThanOrEqual", this._StartTimeLessThanOrEqual);
			kparams.AddIfNotNull("userIdEqual", this._UserIdEqual);
			kparams.AddIfNotNull("userIdIn", this._UserIdIn);
			kparams.AddIfNotNull("partnerSortValueEqual", this._PartnerSortValueEqual);
			kparams.AddIfNotNull("partnerSortValueIn", this._PartnerSortValueIn);
			kparams.AddIfNotNull("partnerSortValueGreaterThanOrEqual", this._PartnerSortValueGreaterThanOrEqual);
			kparams.AddIfNotNull("partnerSortValueLessThanOrEqual", this._PartnerSortValueLessThanOrEqual);
			kparams.AddIfNotNull("forceStopEqual", this._ForceStopEqual);
			kparams.AddIfNotNull("systemNameEqual", this._SystemNameEqual);
			kparams.AddIfNotNull("systemNameIn", this._SystemNameIn);
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
				case CUE_POINT_TYPE_EQUAL:
					return "CuePointTypeEqual";
				case CUE_POINT_TYPE_IN:
					return "CuePointTypeIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case ENTRY_ID_EQUAL:
					return "EntryIdEqual";
				case ENTRY_ID_IN:
					return "EntryIdIn";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case TRIGGERED_AT_GREATER_THAN_OR_EQUAL:
					return "TriggeredAtGreaterThanOrEqual";
				case TRIGGERED_AT_LESS_THAN_OR_EQUAL:
					return "TriggeredAtLessThanOrEqual";
				case TAGS_LIKE:
					return "TagsLike";
				case TAGS_MULTI_LIKE_OR:
					return "TagsMultiLikeOr";
				case TAGS_MULTI_LIKE_AND:
					return "TagsMultiLikeAnd";
				case START_TIME_GREATER_THAN_OR_EQUAL:
					return "StartTimeGreaterThanOrEqual";
				case START_TIME_LESS_THAN_OR_EQUAL:
					return "StartTimeLessThanOrEqual";
				case USER_ID_EQUAL:
					return "UserIdEqual";
				case USER_ID_IN:
					return "UserIdIn";
				case PARTNER_SORT_VALUE_EQUAL:
					return "PartnerSortValueEqual";
				case PARTNER_SORT_VALUE_IN:
					return "PartnerSortValueIn";
				case PARTNER_SORT_VALUE_GREATER_THAN_OR_EQUAL:
					return "PartnerSortValueGreaterThanOrEqual";
				case PARTNER_SORT_VALUE_LESS_THAN_OR_EQUAL:
					return "PartnerSortValueLessThanOrEqual";
				case FORCE_STOP_EQUAL:
					return "ForceStopEqual";
				case SYSTEM_NAME_EQUAL:
					return "SystemNameEqual";
				case SYSTEM_NAME_IN:
					return "SystemNameIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

