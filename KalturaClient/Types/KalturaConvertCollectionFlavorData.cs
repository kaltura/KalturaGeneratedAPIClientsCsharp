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
	public class KalturaConvertCollectionFlavorData : KalturaObjectBase
	{
		#region Private Fields
		private string _FlavorAssetId = null;
		private int _FlavorParamsOutputId = Int32.MinValue;
		private int _ReadyBehavior = Int32.MinValue;
		private int _VideoBitrate = Int32.MinValue;
		private int _AudioBitrate = Int32.MinValue;
		private string _DestFileSyncLocalPath = null;
		private string _DestFileSyncRemoteUrl = null;
		#endregion

		#region Properties
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public int FlavorParamsOutputId
		{
			get { return _FlavorParamsOutputId; }
			set 
			{ 
				_FlavorParamsOutputId = value;
				OnPropertyChanged("FlavorParamsOutputId");
			}
		}
		public int ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		public int VideoBitrate
		{
			get { return _VideoBitrate; }
			set 
			{ 
				_VideoBitrate = value;
				OnPropertyChanged("VideoBitrate");
			}
		}
		public int AudioBitrate
		{
			get { return _AudioBitrate; }
			set 
			{ 
				_AudioBitrate = value;
				OnPropertyChanged("AudioBitrate");
			}
		}
		public string DestFileSyncLocalPath
		{
			get { return _DestFileSyncLocalPath; }
			set 
			{ 
				_DestFileSyncLocalPath = value;
				OnPropertyChanged("DestFileSyncLocalPath");
			}
		}
		public string DestFileSyncRemoteUrl
		{
			get { return _DestFileSyncRemoteUrl; }
			set 
			{ 
				_DestFileSyncRemoteUrl = value;
				OnPropertyChanged("DestFileSyncRemoteUrl");
			}
		}
		#endregion

		#region CTor
		public KalturaConvertCollectionFlavorData()
		{
		}

		public KalturaConvertCollectionFlavorData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorAssetId":
						this._FlavorAssetId = txt;
						continue;
					case "flavorParamsOutputId":
						this._FlavorParamsOutputId = ParseInt(txt);
						continue;
					case "readyBehavior":
						this._ReadyBehavior = ParseInt(txt);
						continue;
					case "videoBitrate":
						this._VideoBitrate = ParseInt(txt);
						continue;
					case "audioBitrate":
						this._AudioBitrate = ParseInt(txt);
						continue;
					case "destFileSyncLocalPath":
						this._DestFileSyncLocalPath = txt;
						continue;
					case "destFileSyncRemoteUrl":
						this._DestFileSyncRemoteUrl = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConvertCollectionFlavorData");
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("flavorParamsOutputId", this._FlavorParamsOutputId);
			kparams.AddIfNotNull("readyBehavior", this._ReadyBehavior);
			kparams.AddIfNotNull("videoBitrate", this._VideoBitrate);
			kparams.AddIfNotNull("audioBitrate", this._AudioBitrate);
			kparams.AddIfNotNull("destFileSyncLocalPath", this._DestFileSyncLocalPath);
			kparams.AddIfNotNull("destFileSyncRemoteUrl", this._DestFileSyncRemoteUrl);
			return kparams;
		}
		#endregion
	}
}

