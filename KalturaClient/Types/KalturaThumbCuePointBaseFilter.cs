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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaThumbCuePointBaseFilter : KalturaCuePointFilter
	{
		#region Private Fields
		private string _DescriptionLike = null;
		private string _DescriptionMultiLikeOr = null;
		private string _DescriptionMultiLikeAnd = null;
		private string _TitleLike = null;
		private string _TitleMultiLikeOr = null;
		private string _TitleMultiLikeAnd = null;
		private KalturaThumbCuePointSubType _SubTypeEqual = (KalturaThumbCuePointSubType)Int32.MinValue;
		private string _SubTypeIn = null;
		#endregion

		#region Properties
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
		public KalturaThumbCuePointSubType SubTypeEqual
		{
			get { return _SubTypeEqual; }
			set 
			{ 
				_SubTypeEqual = value;
				OnPropertyChanged("SubTypeEqual");
			}
		}
		public string SubTypeIn
		{
			get { return _SubTypeIn; }
			set 
			{ 
				_SubTypeIn = value;
				OnPropertyChanged("SubTypeIn");
			}
		}
		#endregion

		#region CTor
		public KalturaThumbCuePointBaseFilter()
		{
		}

		public KalturaThumbCuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "descriptionLike":
						this.DescriptionLike = txt;
						continue;
					case "descriptionMultiLikeOr":
						this.DescriptionMultiLikeOr = txt;
						continue;
					case "descriptionMultiLikeAnd":
						this.DescriptionMultiLikeAnd = txt;
						continue;
					case "titleLike":
						this.TitleLike = txt;
						continue;
					case "titleMultiLikeOr":
						this.TitleMultiLikeOr = txt;
						continue;
					case "titleMultiLikeAnd":
						this.TitleMultiLikeAnd = txt;
						continue;
					case "subTypeEqual":
						this.SubTypeEqual = (KalturaThumbCuePointSubType)ParseEnum(typeof(KalturaThumbCuePointSubType), txt);
						continue;
					case "subTypeIn":
						this.SubTypeIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaThumbCuePointBaseFilter");
			kparams.AddStringIfNotNull("descriptionLike", this.DescriptionLike);
			kparams.AddStringIfNotNull("descriptionMultiLikeOr", this.DescriptionMultiLikeOr);
			kparams.AddStringIfNotNull("descriptionMultiLikeAnd", this.DescriptionMultiLikeAnd);
			kparams.AddStringIfNotNull("titleLike", this.TitleLike);
			kparams.AddStringIfNotNull("titleMultiLikeOr", this.TitleMultiLikeOr);
			kparams.AddStringIfNotNull("titleMultiLikeAnd", this.TitleMultiLikeAnd);
			kparams.AddEnumIfNotNull("subTypeEqual", this.SubTypeEqual);
			kparams.AddStringIfNotNull("subTypeIn", this.SubTypeIn);
			return kparams;
		}
		#endregion
	}
}

