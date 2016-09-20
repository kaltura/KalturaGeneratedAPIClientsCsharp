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
	public class KalturaAdCuePointBaseFilter : KalturaCuePointFilter
	{
		#region Private Fields
		private KalturaAdProtocolType _ProtocolTypeEqual = null;
		private string _ProtocolTypeIn = null;
		private string _TitleLike = null;
		private string _TitleMultiLikeOr = null;
		private string _TitleMultiLikeAnd = null;
		private int _EndTimeGreaterThanOrEqual = Int32.MinValue;
		private int _EndTimeLessThanOrEqual = Int32.MinValue;
		private int _DurationGreaterThanOrEqual = Int32.MinValue;
		private int _DurationLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaAdProtocolType ProtocolTypeEqual
		{
			get { return _ProtocolTypeEqual; }
			set 
			{ 
				_ProtocolTypeEqual = value;
				OnPropertyChanged("ProtocolTypeEqual");
			}
		}
		public string ProtocolTypeIn
		{
			get { return _ProtocolTypeIn; }
			set 
			{ 
				_ProtocolTypeIn = value;
				OnPropertyChanged("ProtocolTypeIn");
			}
		}
		public string TitleLike
		{
			get { return _TitleLike; }
			set 
			{ 
				_TitleLike = value;
				OnPropertyChanged("TitleLike");
			}
		}
		public string TitleMultiLikeOr
		{
			get { return _TitleMultiLikeOr; }
			set 
			{ 
				_TitleMultiLikeOr = value;
				OnPropertyChanged("TitleMultiLikeOr");
			}
		}
		public string TitleMultiLikeAnd
		{
			get { return _TitleMultiLikeAnd; }
			set 
			{ 
				_TitleMultiLikeAnd = value;
				OnPropertyChanged("TitleMultiLikeAnd");
			}
		}
		public int EndTimeGreaterThanOrEqual
		{
			get { return _EndTimeGreaterThanOrEqual; }
			set 
			{ 
				_EndTimeGreaterThanOrEqual = value;
				OnPropertyChanged("EndTimeGreaterThanOrEqual");
			}
		}
		public int EndTimeLessThanOrEqual
		{
			get { return _EndTimeLessThanOrEqual; }
			set 
			{ 
				_EndTimeLessThanOrEqual = value;
				OnPropertyChanged("EndTimeLessThanOrEqual");
			}
		}
		public int DurationGreaterThanOrEqual
		{
			get { return _DurationGreaterThanOrEqual; }
			set 
			{ 
				_DurationGreaterThanOrEqual = value;
				OnPropertyChanged("DurationGreaterThanOrEqual");
			}
		}
		public int DurationLessThanOrEqual
		{
			get { return _DurationLessThanOrEqual; }
			set 
			{ 
				_DurationLessThanOrEqual = value;
				OnPropertyChanged("DurationLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaAdCuePointBaseFilter()
		{
		}

		public KalturaAdCuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "protocolTypeEqual":
						this._ProtocolTypeEqual = (KalturaAdProtocolType)KalturaStringEnum.Parse(typeof(KalturaAdProtocolType), txt);
						continue;
					case "protocolTypeIn":
						this._ProtocolTypeIn = txt;
						continue;
					case "titleLike":
						this._TitleLike = txt;
						continue;
					case "titleMultiLikeOr":
						this._TitleMultiLikeOr = txt;
						continue;
					case "titleMultiLikeAnd":
						this._TitleMultiLikeAnd = txt;
						continue;
					case "endTimeGreaterThanOrEqual":
						this._EndTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "endTimeLessThanOrEqual":
						this._EndTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "durationGreaterThanOrEqual":
						this._DurationGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "durationLessThanOrEqual":
						this._DurationLessThanOrEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAdCuePointBaseFilter");
			kparams.AddIfNotNull("protocolTypeEqual", this.ProtocolTypeEqual);
			kparams.AddIfNotNull("protocolTypeIn", this.ProtocolTypeIn);
			kparams.AddIfNotNull("titleLike", this.TitleLike);
			kparams.AddIfNotNull("titleMultiLikeOr", this.TitleMultiLikeOr);
			kparams.AddIfNotNull("titleMultiLikeAnd", this.TitleMultiLikeAnd);
			kparams.AddIfNotNull("endTimeGreaterThanOrEqual", this.EndTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("endTimeLessThanOrEqual", this.EndTimeLessThanOrEqual);
			kparams.AddIfNotNull("durationGreaterThanOrEqual", this.DurationGreaterThanOrEqual);
			kparams.AddIfNotNull("durationLessThanOrEqual", this.DurationLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

