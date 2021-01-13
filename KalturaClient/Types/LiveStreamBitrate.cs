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
	public class LiveStreamBitrate : ObjectBase
	{
		#region Constants
		public const string BITRATE = "bitrate";
		public const string WIDTH = "width";
		public const string HEIGHT = "height";
		public const string TAGS = "tags";
		#endregion

		#region Private Fields
		private int _Bitrate = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private string _Tags = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int Bitrate
		{
			get { return _Bitrate; }
			set 
			{ 
				_Bitrate = value;
				OnPropertyChanged("Bitrate");
			}
		}
		[JsonProperty]
		public int Width
		{
			get { return _Width; }
			set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		[JsonProperty]
		public int Height
		{
			get { return _Height; }
			set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		[JsonProperty]
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		#endregion

		#region CTor
		public LiveStreamBitrate()
		{
		}

		public LiveStreamBitrate(JToken node) : base(node)
		{
			if(node["bitrate"] != null)
			{
				this._Bitrate = ParseInt(node["bitrate"].Value<string>());
			}
			if(node["width"] != null)
			{
				this._Width = ParseInt(node["width"].Value<string>());
			}
			if(node["height"] != null)
			{
				this._Height = ParseInt(node["height"].Value<string>());
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveStreamBitrate");
			kparams.AddIfNotNull("bitrate", this._Bitrate);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("height", this._Height);
			kparams.AddIfNotNull("tags", this._Tags);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case BITRATE:
					return "Bitrate";
				case WIDTH:
					return "Width";
				case HEIGHT:
					return "Height";
				case TAGS:
					return "Tags";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

