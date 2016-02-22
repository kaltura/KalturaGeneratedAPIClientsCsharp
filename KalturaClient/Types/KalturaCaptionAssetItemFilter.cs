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
	public class KalturaCaptionAssetItemFilter : KalturaCaptionAssetFilter
	{
		#region Private Fields
		private string _ContentLike = null;
		private string _ContentMultiLikeOr = null;
		private string _ContentMultiLikeAnd = null;
		private string _PartnerDescriptionLike = null;
		private string _PartnerDescriptionMultiLikeOr = null;
		private string _PartnerDescriptionMultiLikeAnd = null;
		private KalturaLanguage _LanguageEqual = null;
		private string _LanguageIn = null;
		private string _LabelEqual = null;
		private string _LabelIn = null;
		private int _StartTimeGreaterThanOrEqual = Int32.MinValue;
		private int _StartTimeLessThanOrEqual = Int32.MinValue;
		private int _EndTimeGreaterThanOrEqual = Int32.MinValue;
		private int _EndTimeLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		public string ContentLike
		{
			get { return _ContentLike; }
			set 
			{ 
				_ContentLike = value;
				OnPropertyChanged("ContentLike");
			}
		}
		public string ContentMultiLikeOr
		{
			get { return _ContentMultiLikeOr; }
			set 
			{ 
				_ContentMultiLikeOr = value;
				OnPropertyChanged("ContentMultiLikeOr");
			}
		}
		public string ContentMultiLikeAnd
		{
			get { return _ContentMultiLikeAnd; }
			set 
			{ 
				_ContentMultiLikeAnd = value;
				OnPropertyChanged("ContentMultiLikeAnd");
			}
		}
		public string PartnerDescriptionLike
		{
			get { return _PartnerDescriptionLike; }
			set 
			{ 
				_PartnerDescriptionLike = value;
				OnPropertyChanged("PartnerDescriptionLike");
			}
		}
		public string PartnerDescriptionMultiLikeOr
		{
			get { return _PartnerDescriptionMultiLikeOr; }
			set 
			{ 
				_PartnerDescriptionMultiLikeOr = value;
				OnPropertyChanged("PartnerDescriptionMultiLikeOr");
			}
		}
		public string PartnerDescriptionMultiLikeAnd
		{
			get { return _PartnerDescriptionMultiLikeAnd; }
			set 
			{ 
				_PartnerDescriptionMultiLikeAnd = value;
				OnPropertyChanged("PartnerDescriptionMultiLikeAnd");
			}
		}
		public KalturaLanguage LanguageEqual
		{
			get { return _LanguageEqual; }
			set 
			{ 
				_LanguageEqual = value;
				OnPropertyChanged("LanguageEqual");
			}
		}
		public string LanguageIn
		{
			get { return _LanguageIn; }
			set 
			{ 
				_LanguageIn = value;
				OnPropertyChanged("LanguageIn");
			}
		}
		public string LabelEqual
		{
			get { return _LabelEqual; }
			set 
			{ 
				_LabelEqual = value;
				OnPropertyChanged("LabelEqual");
			}
		}
		public string LabelIn
		{
			get { return _LabelIn; }
			set 
			{ 
				_LabelIn = value;
				OnPropertyChanged("LabelIn");
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
		#endregion

		#region CTor
		public KalturaCaptionAssetItemFilter()
		{
		}

		public KalturaCaptionAssetItemFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "contentLike":
						this.ContentLike = txt;
						continue;
					case "contentMultiLikeOr":
						this.ContentMultiLikeOr = txt;
						continue;
					case "contentMultiLikeAnd":
						this.ContentMultiLikeAnd = txt;
						continue;
					case "partnerDescriptionLike":
						this.PartnerDescriptionLike = txt;
						continue;
					case "partnerDescriptionMultiLikeOr":
						this.PartnerDescriptionMultiLikeOr = txt;
						continue;
					case "partnerDescriptionMultiLikeAnd":
						this.PartnerDescriptionMultiLikeAnd = txt;
						continue;
					case "languageEqual":
						this.LanguageEqual = (KalturaLanguage)KalturaStringEnum.Parse(typeof(KalturaLanguage), txt);
						continue;
					case "languageIn":
						this.LanguageIn = txt;
						continue;
					case "labelEqual":
						this.LabelEqual = txt;
						continue;
					case "labelIn":
						this.LabelIn = txt;
						continue;
					case "startTimeGreaterThanOrEqual":
						this.StartTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "startTimeLessThanOrEqual":
						this.StartTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "endTimeGreaterThanOrEqual":
						this.EndTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "endTimeLessThanOrEqual":
						this.EndTimeLessThanOrEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCaptionAssetItemFilter");
			kparams.AddIfNotNull("contentLike", this.ContentLike);
			kparams.AddIfNotNull("contentMultiLikeOr", this.ContentMultiLikeOr);
			kparams.AddIfNotNull("contentMultiLikeAnd", this.ContentMultiLikeAnd);
			kparams.AddIfNotNull("partnerDescriptionLike", this.PartnerDescriptionLike);
			kparams.AddIfNotNull("partnerDescriptionMultiLikeOr", this.PartnerDescriptionMultiLikeOr);
			kparams.AddIfNotNull("partnerDescriptionMultiLikeAnd", this.PartnerDescriptionMultiLikeAnd);
			kparams.AddIfNotNull("languageEqual", this.LanguageEqual);
			kparams.AddIfNotNull("languageIn", this.LanguageIn);
			kparams.AddIfNotNull("labelEqual", this.LabelEqual);
			kparams.AddIfNotNull("labelIn", this.LabelIn);
			kparams.AddIfNotNull("startTimeGreaterThanOrEqual", this.StartTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("startTimeLessThanOrEqual", this.StartTimeLessThanOrEqual);
			kparams.AddIfNotNull("endTimeGreaterThanOrEqual", this.EndTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("endTimeLessThanOrEqual", this.EndTimeLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

