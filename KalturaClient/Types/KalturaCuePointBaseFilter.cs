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
	public class KalturaCuePointBaseFilter : KalturaRelatedFilter
	{
		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private KalturaCuePointType _CuePointTypeEqual = null;
		private string _CuePointTypeIn = null;
		private KalturaCuePointStatus _StatusEqual = (KalturaCuePointStatus)Int32.MinValue;
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
		private KalturaNullableBoolean _ForceStopEqual = (KalturaNullableBoolean)Int32.MinValue;
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
		public KalturaCuePointType CuePointTypeEqual
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
		public KalturaCuePointStatus StatusEqual
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
		public KalturaNullableBoolean ForceStopEqual
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
		public KalturaCuePointBaseFilter()
		{
		}

		public KalturaCuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = txt;
						continue;
					case "idIn":
						this._IdIn = txt;
						continue;
					case "cuePointTypeEqual":
						this._CuePointTypeEqual = (KalturaCuePointType)KalturaStringEnum.Parse(typeof(KalturaCuePointType), txt);
						continue;
					case "cuePointTypeIn":
						this._CuePointTypeIn = txt;
						continue;
					case "statusEqual":
						this._StatusEqual = (KalturaCuePointStatus)ParseEnum(typeof(KalturaCuePointStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "entryIdEqual":
						this._EntryIdEqual = txt;
						continue;
					case "entryIdIn":
						this._EntryIdIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "triggeredAtGreaterThanOrEqual":
						this._TriggeredAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "triggeredAtLessThanOrEqual":
						this._TriggeredAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "tagsLike":
						this._TagsLike = txt;
						continue;
					case "tagsMultiLikeOr":
						this._TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this._TagsMultiLikeAnd = txt;
						continue;
					case "startTimeGreaterThanOrEqual":
						this._StartTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "startTimeLessThanOrEqual":
						this._StartTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "userIdEqual":
						this._UserIdEqual = txt;
						continue;
					case "userIdIn":
						this._UserIdIn = txt;
						continue;
					case "partnerSortValueEqual":
						this._PartnerSortValueEqual = ParseInt(txt);
						continue;
					case "partnerSortValueIn":
						this._PartnerSortValueIn = txt;
						continue;
					case "partnerSortValueGreaterThanOrEqual":
						this._PartnerSortValueGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "partnerSortValueLessThanOrEqual":
						this._PartnerSortValueLessThanOrEqual = ParseInt(txt);
						continue;
					case "forceStopEqual":
						this._ForceStopEqual = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "systemNameEqual":
						this._SystemNameEqual = txt;
						continue;
					case "systemNameIn":
						this._SystemNameIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

