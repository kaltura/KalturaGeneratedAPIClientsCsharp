// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
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
	public class ThumbAsset : Asset
	{
		#region Constants
		public const string THUMB_PARAMS_ID = "thumbParamsId";
		public const string WIDTH = "width";
		public const string HEIGHT = "height";
		public const string STATUS = "status";
		#endregion

		#region Private Fields
		private int _ThumbParamsId = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private ThumbAssetStatus _Status = (ThumbAssetStatus)Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int ThumbParamsId
		{
			get { return _ThumbParamsId; }
			set 
			{ 
				_ThumbParamsId = value;
				OnPropertyChanged("ThumbParamsId");
			}
		}
		[JsonProperty]
		public int Width
		{
			get { return _Width; }
			private set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		[JsonProperty]
		public int Height
		{
			get { return _Height; }
			private set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		[JsonProperty]
		public ThumbAssetStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		#endregion

		#region CTor
		public ThumbAsset()
		{
		}

		public ThumbAsset(JToken node) : base(node)
		{
			if(node["thumbParamsId"] != null)
			{
				this._ThumbParamsId = ParseInt(node["thumbParamsId"].Value<string>());
			}
			if(node["width"] != null)
			{
				this._Width = ParseInt(node["width"].Value<string>());
			}
			if(node["height"] != null)
			{
				this._Height = ParseInt(node["height"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (ThumbAssetStatus)ParseEnum(typeof(ThumbAssetStatus), node["status"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaThumbAsset");
			kparams.AddIfNotNull("thumbParamsId", this._ThumbParamsId);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("height", this._Height);
			kparams.AddIfNotNull("status", this._Status);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case THUMB_PARAMS_ID:
					return "ThumbParamsId";
				case WIDTH:
					return "Width";
				case HEIGHT:
					return "Height";
				case STATUS:
					return "Status";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

