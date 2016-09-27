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
	public class KalturaSourceFileSyncDescriptor : KalturaFileSyncDescriptor
	{
		#region Private Fields
		private string _ActualFileSyncLocalPath = null;
		private string _AssetId = null;
		private int _AssetParamsId = Int32.MinValue;
		#endregion

		#region Properties
		public string ActualFileSyncLocalPath
		{
			get { return _ActualFileSyncLocalPath; }
			set 
			{ 
				_ActualFileSyncLocalPath = value;
				OnPropertyChanged("ActualFileSyncLocalPath");
			}
		}
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
			set 
			{ 
				_AssetParamsId = value;
				OnPropertyChanged("AssetParamsId");
			}
		}
		#endregion

		#region CTor
		public KalturaSourceFileSyncDescriptor()
		{
		}

		public KalturaSourceFileSyncDescriptor(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "actualFileSyncLocalPath":
						this._ActualFileSyncLocalPath = txt;
						continue;
					case "assetId":
						this._AssetId = txt;
						continue;
					case "assetParamsId":
						this._AssetParamsId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSourceFileSyncDescriptor");
			kparams.AddIfNotNull("actualFileSyncLocalPath", this._ActualFileSyncLocalPath);
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("assetParamsId", this._AssetParamsId);
			return kparams;
		}
		#endregion
	}
}

