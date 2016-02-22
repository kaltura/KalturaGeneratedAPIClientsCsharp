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
	public class KalturaCodeCuePointBaseFilter : KalturaCuePointFilter
	{
		#region Private Fields
		private string _CodeLike = null;
		private string _CodeMultiLikeOr = null;
		private string _CodeMultiLikeAnd = null;
		private string _CodeEqual = null;
		private string _CodeIn = null;
		private string _DescriptionLike = null;
		private string _DescriptionMultiLikeOr = null;
		private string _DescriptionMultiLikeAnd = null;
		private int _EndTimeGreaterThanOrEqual = Int32.MinValue;
		private int _EndTimeLessThanOrEqual = Int32.MinValue;
		private int _DurationGreaterThanOrEqual = Int32.MinValue;
		private int _DurationLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		public string CodeLike
		{
			get { return _CodeLike; }
			set 
			{ 
				_CodeLike = value;
				OnPropertyChanged("CodeLike");
			}
		}
		public string CodeMultiLikeOr
		{
			get { return _CodeMultiLikeOr; }
			set 
			{ 
				_CodeMultiLikeOr = value;
				OnPropertyChanged("CodeMultiLikeOr");
			}
		}
		public string CodeMultiLikeAnd
		{
			get { return _CodeMultiLikeAnd; }
			set 
			{ 
				_CodeMultiLikeAnd = value;
				OnPropertyChanged("CodeMultiLikeAnd");
			}
		}
		public string CodeEqual
		{
			get { return _CodeEqual; }
			set 
			{ 
				_CodeEqual = value;
				OnPropertyChanged("CodeEqual");
			}
		}
		public string CodeIn
		{
			get { return _CodeIn; }
			set 
			{ 
				_CodeIn = value;
				OnPropertyChanged("CodeIn");
			}
		}
		public string DescriptionLike
		{
			get { return _DescriptionLike; }
			set 
			{ 
				_DescriptionLike = value;
				OnPropertyChanged("DescriptionLike");
			}
		}
		public string DescriptionMultiLikeOr
		{
			get { return _DescriptionMultiLikeOr; }
			set 
			{ 
				_DescriptionMultiLikeOr = value;
				OnPropertyChanged("DescriptionMultiLikeOr");
			}
		}
		public string DescriptionMultiLikeAnd
		{
			get { return _DescriptionMultiLikeAnd; }
			set 
			{ 
				_DescriptionMultiLikeAnd = value;
				OnPropertyChanged("DescriptionMultiLikeAnd");
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
		public KalturaCodeCuePointBaseFilter()
		{
		}

		public KalturaCodeCuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "codeLike":
						this.CodeLike = txt;
						continue;
					case "codeMultiLikeOr":
						this.CodeMultiLikeOr = txt;
						continue;
					case "codeMultiLikeAnd":
						this.CodeMultiLikeAnd = txt;
						continue;
					case "codeEqual":
						this.CodeEqual = txt;
						continue;
					case "codeIn":
						this.CodeIn = txt;
						continue;
					case "descriptionLike":
						this.DescriptionLike = txt;
						continue;
					case "descriptionMultiLikeOr":
						this.DescriptionMultiLikeOr = txt;
						continue;
					case "descriptionMultiLikeAnd":
						this.DescriptionMultiLikeAnd = txt;
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
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCodeCuePointBaseFilter");
			kparams.AddIfNotNull("codeLike", this.CodeLike);
			kparams.AddIfNotNull("codeMultiLikeOr", this.CodeMultiLikeOr);
			kparams.AddIfNotNull("codeMultiLikeAnd", this.CodeMultiLikeAnd);
			kparams.AddIfNotNull("codeEqual", this.CodeEqual);
			kparams.AddIfNotNull("codeIn", this.CodeIn);
			kparams.AddIfNotNull("descriptionLike", this.DescriptionLike);
			kparams.AddIfNotNull("descriptionMultiLikeOr", this.DescriptionMultiLikeOr);
			kparams.AddIfNotNull("descriptionMultiLikeAnd", this.DescriptionMultiLikeAnd);
			kparams.AddIfNotNull("endTimeGreaterThanOrEqual", this.EndTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("endTimeLessThanOrEqual", this.EndTimeLessThanOrEqual);
			kparams.AddIfNotNull("durationGreaterThanOrEqual", this.DurationGreaterThanOrEqual);
			kparams.AddIfNotNull("durationLessThanOrEqual", this.DurationLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

