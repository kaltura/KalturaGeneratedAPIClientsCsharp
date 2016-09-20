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
	public class KalturaThumbCuePoint : KalturaCuePoint
	{
		#region Private Fields
		private string _AssetId = null;
		private string _Description = null;
		private string _Title = null;
		private KalturaThumbCuePointSubType _SubType = (KalturaThumbCuePointSubType)Int32.MinValue;
		#endregion

		#region Properties
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		public KalturaThumbCuePointSubType SubType
		{
			get { return _SubType; }
			set 
			{ 
				_SubType = value;
				OnPropertyChanged("SubType");
			}
		}
		#endregion

		#region CTor
		public KalturaThumbCuePoint()
		{
		}

		public KalturaThumbCuePoint(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "assetId":
						this._AssetId = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "title":
						this._Title = txt;
						continue;
					case "subType":
						this._SubType = (KalturaThumbCuePointSubType)ParseEnum(typeof(KalturaThumbCuePointSubType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaThumbCuePoint");
			kparams.AddIfNotNull("assetId", this.AssetId);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("title", this.Title);
			kparams.AddIfNotNull("subType", this.SubType);
			return kparams;
		}
		#endregion
	}
}

