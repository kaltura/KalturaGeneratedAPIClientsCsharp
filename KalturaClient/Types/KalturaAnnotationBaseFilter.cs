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
	public class KalturaAnnotationBaseFilter : KalturaCuePointFilter
	{
		#region Private Fields
		private string _ParentIdEqual = null;
		private string _ParentIdIn = null;
		private string _TextLike = null;
		private string _TextMultiLikeOr = null;
		private string _TextMultiLikeAnd = null;
		private int _EndTimeGreaterThanOrEqual = Int32.MinValue;
		private int _EndTimeLessThanOrEqual = Int32.MinValue;
		private int _DurationGreaterThanOrEqual = Int32.MinValue;
		private int _DurationLessThanOrEqual = Int32.MinValue;
		private KalturaNullableBoolean _IsPublicEqual = (KalturaNullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public string ParentIdEqual
		{
			get { return _ParentIdEqual; }
			set 
			{ 
				_ParentIdEqual = value;
				OnPropertyChanged("ParentIdEqual");
			}
		}
		public string ParentIdIn
		{
			get { return _ParentIdIn; }
			set 
			{ 
				_ParentIdIn = value;
				OnPropertyChanged("ParentIdIn");
			}
		}
		public string TextLike
		{
			get { return _TextLike; }
			set 
			{ 
				_TextLike = value;
				OnPropertyChanged("TextLike");
			}
		}
		public string TextMultiLikeOr
		{
			get { return _TextMultiLikeOr; }
			set 
			{ 
				_TextMultiLikeOr = value;
				OnPropertyChanged("TextMultiLikeOr");
			}
		}
		public string TextMultiLikeAnd
		{
			get { return _TextMultiLikeAnd; }
			set 
			{ 
				_TextMultiLikeAnd = value;
				OnPropertyChanged("TextMultiLikeAnd");
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
		public KalturaNullableBoolean IsPublicEqual
		{
			get { return _IsPublicEqual; }
			set 
			{ 
				_IsPublicEqual = value;
				OnPropertyChanged("IsPublicEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaAnnotationBaseFilter()
		{
		}

		public KalturaAnnotationBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "parentIdEqual":
						this.ParentIdEqual = txt;
						continue;
					case "parentIdIn":
						this.ParentIdIn = txt;
						continue;
					case "textLike":
						this.TextLike = txt;
						continue;
					case "textMultiLikeOr":
						this.TextMultiLikeOr = txt;
						continue;
					case "textMultiLikeAnd":
						this.TextMultiLikeAnd = txt;
						continue;
					case "endTimeGreaterThanOrEqual":
						this.EndTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "endTimeLessThanOrEqual":
						this.EndTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "durationGreaterThanOrEqual":
						this.DurationGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "durationLessThanOrEqual":
						this.DurationLessThanOrEqual = ParseInt(txt);
						continue;
					case "isPublicEqual":
						this.IsPublicEqual = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAnnotationBaseFilter");
			kparams.AddIfNotNull("parentIdEqual", this.ParentIdEqual);
			kparams.AddIfNotNull("parentIdIn", this.ParentIdIn);
			kparams.AddIfNotNull("textLike", this.TextLike);
			kparams.AddIfNotNull("textMultiLikeOr", this.TextMultiLikeOr);
			kparams.AddIfNotNull("textMultiLikeAnd", this.TextMultiLikeAnd);
			kparams.AddIfNotNull("endTimeGreaterThanOrEqual", this.EndTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("endTimeLessThanOrEqual", this.EndTimeLessThanOrEqual);
			kparams.AddIfNotNull("durationGreaterThanOrEqual", this.DurationGreaterThanOrEqual);
			kparams.AddIfNotNull("durationLessThanOrEqual", this.DurationLessThanOrEqual);
			kparams.AddIfNotNull("isPublicEqual", this.IsPublicEqual);
			return kparams;
		}
		#endregion
	}
}

