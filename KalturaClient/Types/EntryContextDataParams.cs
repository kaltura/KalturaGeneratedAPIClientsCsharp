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
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class EntryContextDataParams : AccessControlScope
	{
		#region Constants
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string FLAVOR_TAGS = "flavorTags";
		public const string STREAMER_TYPE = "streamerType";
		public const string MEDIA_PROTOCOL = "mediaProtocol";
		#endregion

		#region Private Fields
		private string _FlavorAssetId = null;
		private string _FlavorTags = null;
		private string _StreamerType = null;
		private string _MediaProtocol = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		[JsonProperty]
		public string FlavorTags
		{
			get { return _FlavorTags; }
			set 
			{ 
				_FlavorTags = value;
				OnPropertyChanged("FlavorTags");
			}
		}
		[JsonProperty]
		public string StreamerType
		{
			get { return _StreamerType; }
			set 
			{ 
				_StreamerType = value;
				OnPropertyChanged("StreamerType");
			}
		}
		[JsonProperty]
		public string MediaProtocol
		{
			get { return _MediaProtocol; }
			set 
			{ 
				_MediaProtocol = value;
				OnPropertyChanged("MediaProtocol");
			}
		}
		#endregion

		#region CTor
		public EntryContextDataParams()
		{
		}

		public EntryContextDataParams(JToken node) : base(node)
		{
			if(node["flavorAssetId"] != null)
			{
				this._FlavorAssetId = node["flavorAssetId"].Value<string>();
			}
			if(node["flavorTags"] != null)
			{
				this._FlavorTags = node["flavorTags"].Value<string>();
			}
			if(node["streamerType"] != null)
			{
				this._StreamerType = node["streamerType"].Value<string>();
			}
			if(node["mediaProtocol"] != null)
			{
				this._MediaProtocol = node["mediaProtocol"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryContextDataParams");
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("flavorTags", this._FlavorTags);
			kparams.AddIfNotNull("streamerType", this._StreamerType);
			kparams.AddIfNotNull("mediaProtocol", this._MediaProtocol);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case FLAVOR_TAGS:
					return "FlavorTags";
				case STREAMER_TYPE:
					return "StreamerType";
				case MEDIA_PROTOCOL:
					return "MediaProtocol";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

