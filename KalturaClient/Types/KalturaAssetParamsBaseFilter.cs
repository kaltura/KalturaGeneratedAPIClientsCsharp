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
	public class KalturaAssetParamsBaseFilter : KalturaRelatedFilter
	{
		#region Private Fields
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		private KalturaNullableBoolean _IsSystemDefaultEqual = (KalturaNullableBoolean)Int32.MinValue;
		private string _TagsEqual = null;
		#endregion

		#region Properties
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
		public KalturaNullableBoolean IsSystemDefaultEqual
		{
			get { return _IsSystemDefaultEqual; }
			set 
			{ 
				_IsSystemDefaultEqual = value;
				OnPropertyChanged("IsSystemDefaultEqual");
			}
		}
		public string TagsEqual
		{
			get { return _TagsEqual; }
			set 
			{ 
				_TagsEqual = value;
				OnPropertyChanged("TagsEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaAssetParamsBaseFilter()
		{
		}

		public KalturaAssetParamsBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "systemNameEqual":
						this.SystemNameEqual = txt;
						continue;
					case "systemNameIn":
						this.SystemNameIn = txt;
						continue;
					case "isSystemDefaultEqual":
						this.IsSystemDefaultEqual = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "tagsEqual":
						this.TagsEqual = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAssetParamsBaseFilter");
			kparams.AddStringIfNotNull("systemNameEqual", this.SystemNameEqual);
			kparams.AddStringIfNotNull("systemNameIn", this.SystemNameIn);
			kparams.AddEnumIfNotNull("isSystemDefaultEqual", this.IsSystemDefaultEqual);
			kparams.AddStringIfNotNull("tagsEqual", this.TagsEqual);
			return kparams;
		}
		#endregion
	}
}

