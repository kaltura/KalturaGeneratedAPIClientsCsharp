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
	public class KalturaExternalMediaEntry : KalturaMediaEntry
	{
		#region Private Fields
		private KalturaExternalMediaSourceType _ExternalSourceType = null;
		private string _AssetParamsIds = null;
		#endregion

		#region Properties
		public KalturaExternalMediaSourceType ExternalSourceType
		{
			get { return _ExternalSourceType; }
			set 
			{ 
				_ExternalSourceType = value;
				OnPropertyChanged("ExternalSourceType");
			}
		}
		public string AssetParamsIds
		{
			get { return _AssetParamsIds; }
			set 
			{ 
				_AssetParamsIds = value;
				OnPropertyChanged("AssetParamsIds");
			}
		}
		#endregion

		#region CTor
		public KalturaExternalMediaEntry()
		{
		}

		public KalturaExternalMediaEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "externalSourceType":
						this.ExternalSourceType = (KalturaExternalMediaSourceType)KalturaStringEnum.Parse(typeof(KalturaExternalMediaSourceType), txt);
						continue;
					case "assetParamsIds":
						this.AssetParamsIds = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaExternalMediaEntry");
			kparams.AddStringEnumIfNotNull("externalSourceType", this.ExternalSourceType);
			kparams.AddStringIfNotNull("assetParamsIds", this.AssetParamsIds);
			return kparams;
		}
		#endregion
	}
}

