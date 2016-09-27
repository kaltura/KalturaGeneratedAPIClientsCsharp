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
	public class KalturaEntryDistributionBaseFilter : KalturaRelatedFilter
	{
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
		private KalturaEntryDistributionStatus _StatusEqual = (KalturaEntryDistributionStatus)Int32.MinValue;
		private string _StatusIn = null;
		private KalturaEntryDistributionFlag _DirtyStatusEqual = (KalturaEntryDistributionFlag)Int32.MinValue;
		private string _DirtyStatusIn = null;
		private int _SunriseGreaterThanOrEqual = Int32.MinValue;
		private int _SunriseLessThanOrEqual = Int32.MinValue;
		private int _SunsetGreaterThanOrEqual = Int32.MinValue;
		private int _SunsetLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		public int IdEqual
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
		public int SubmittedAtGreaterThanOrEqual
		{
			get { return _SubmittedAtGreaterThanOrEqual; }
			set 
			{ 
				_SubmittedAtGreaterThanOrEqual = value;
				OnPropertyChanged("SubmittedAtGreaterThanOrEqual");
			}
		}
		public int SubmittedAtLessThanOrEqual
		{
			get { return _SubmittedAtLessThanOrEqual; }
			set 
			{ 
				_SubmittedAtLessThanOrEqual = value;
				OnPropertyChanged("SubmittedAtLessThanOrEqual");
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
		public int DistributionProfileIdEqual
		{
			get { return _DistributionProfileIdEqual; }
			set 
			{ 
				_DistributionProfileIdEqual = value;
				OnPropertyChanged("DistributionProfileIdEqual");
			}
		}
		public string DistributionProfileIdIn
		{
			get { return _DistributionProfileIdIn; }
			set 
			{ 
				_DistributionProfileIdIn = value;
				OnPropertyChanged("DistributionProfileIdIn");
			}
		}
		public KalturaEntryDistributionStatus StatusEqual
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
		public KalturaEntryDistributionFlag DirtyStatusEqual
		{
			get { return _DirtyStatusEqual; }
			set 
			{ 
				_DirtyStatusEqual = value;
				OnPropertyChanged("DirtyStatusEqual");
			}
		}
		public string DirtyStatusIn
		{
			get { return _DirtyStatusIn; }
			set 
			{ 
				_DirtyStatusIn = value;
				OnPropertyChanged("DirtyStatusIn");
			}
		}
		public int SunriseGreaterThanOrEqual
		{
			get { return _SunriseGreaterThanOrEqual; }
			set 
			{ 
				_SunriseGreaterThanOrEqual = value;
				OnPropertyChanged("SunriseGreaterThanOrEqual");
			}
		}
		public int SunriseLessThanOrEqual
		{
			get { return _SunriseLessThanOrEqual; }
			set 
			{ 
				_SunriseLessThanOrEqual = value;
				OnPropertyChanged("SunriseLessThanOrEqual");
			}
		}
		public int SunsetGreaterThanOrEqual
		{
			get { return _SunsetGreaterThanOrEqual; }
			set 
			{ 
				_SunsetGreaterThanOrEqual = value;
				OnPropertyChanged("SunsetGreaterThanOrEqual");
			}
		}
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
		public KalturaEntryDistributionBaseFilter()
		{
		}

		public KalturaEntryDistributionBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this._IdIn = txt;
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
					case "submittedAtGreaterThanOrEqual":
						this._SubmittedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "submittedAtLessThanOrEqual":
						this._SubmittedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "entryIdEqual":
						this._EntryIdEqual = txt;
						continue;
					case "entryIdIn":
						this._EntryIdIn = txt;
						continue;
					case "distributionProfileIdEqual":
						this._DistributionProfileIdEqual = ParseInt(txt);
						continue;
					case "distributionProfileIdIn":
						this._DistributionProfileIdIn = txt;
						continue;
					case "statusEqual":
						this._StatusEqual = (KalturaEntryDistributionStatus)ParseEnum(typeof(KalturaEntryDistributionStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "dirtyStatusEqual":
						this._DirtyStatusEqual = (KalturaEntryDistributionFlag)ParseEnum(typeof(KalturaEntryDistributionFlag), txt);
						continue;
					case "dirtyStatusIn":
						this._DirtyStatusIn = txt;
						continue;
					case "sunriseGreaterThanOrEqual":
						this._SunriseGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "sunriseLessThanOrEqual":
						this._SunriseLessThanOrEqual = ParseInt(txt);
						continue;
					case "sunsetGreaterThanOrEqual":
						this._SunsetGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "sunsetLessThanOrEqual":
						this._SunsetLessThanOrEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

