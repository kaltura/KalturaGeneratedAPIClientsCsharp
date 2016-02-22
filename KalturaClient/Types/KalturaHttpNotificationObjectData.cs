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
	public class KalturaHttpNotificationObjectData : KalturaHttpNotificationData
	{
		#region Private Fields
		private string _ApiObjectType = null;
		private KalturaResponseType _Format = (KalturaResponseType)Int32.MinValue;
		private bool? _IgnoreNull = false;
		private string _Code = null;
		#endregion

		#region Properties
		public string ApiObjectType
		{
			get { return _ApiObjectType; }
			set 
			{ 
				_ApiObjectType = value;
				OnPropertyChanged("ApiObjectType");
			}
		}
		public KalturaResponseType Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		public bool? IgnoreNull
		{
			get { return _IgnoreNull; }
			set 
			{ 
				_IgnoreNull = value;
				OnPropertyChanged("IgnoreNull");
			}
		}
		public string Code
		{
			get { return _Code; }
			set 
			{ 
				_Code = value;
				OnPropertyChanged("Code");
			}
		}
		#endregion

		#region CTor
		public KalturaHttpNotificationObjectData()
		{
		}

		public KalturaHttpNotificationObjectData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "apiObjectType":
						this.ApiObjectType = txt;
						continue;
					case "format":
						this.Format = (KalturaResponseType)ParseEnum(typeof(KalturaResponseType), txt);
						continue;
					case "ignoreNull":
						this.IgnoreNull = ParseBool(txt);
						continue;
					case "code":
						this.Code = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaHttpNotificationObjectData");
			kparams.AddIfNotNull("apiObjectType", this.ApiObjectType);
			kparams.AddIfNotNull("format", this.Format);
			kparams.AddIfNotNull("ignoreNull", this.IgnoreNull);
			kparams.AddIfNotNull("code", this.Code);
			return kparams;
		}
		#endregion
	}
}

