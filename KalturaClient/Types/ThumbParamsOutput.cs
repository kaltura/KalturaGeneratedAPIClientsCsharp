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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class ThumbParamsOutput : ThumbParams
	{
		#region Constants
		public const string THUMB_PARAMS_ID = "thumbParamsId";
		public const string THUMB_PARAMS_VERSION = "thumbParamsVersion";
		public const string THUMB_ASSET_ID = "thumbAssetId";
		public const string THUMB_ASSET_VERSION = "thumbAssetVersion";
		public const string ROTATE = "rotate";
		#endregion

		#region Private Fields
		private int _ThumbParamsId = Int32.MinValue;
		private string _ThumbParamsVersion = null;
		private string _ThumbAssetId = null;
		private string _ThumbAssetVersion = null;
		private int _Rotate = Int32.MinValue;
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
		public string ThumbParamsVersion
		{
			get { return _ThumbParamsVersion; }
			set 
			{ 
				_ThumbParamsVersion = value;
				OnPropertyChanged("ThumbParamsVersion");
			}
		}
		[JsonProperty]
		public string ThumbAssetId
		{
			get { return _ThumbAssetId; }
			set 
			{ 
				_ThumbAssetId = value;
				OnPropertyChanged("ThumbAssetId");
			}
		}
		[JsonProperty]
		public string ThumbAssetVersion
		{
			get { return _ThumbAssetVersion; }
			set 
			{ 
				_ThumbAssetVersion = value;
				OnPropertyChanged("ThumbAssetVersion");
			}
		}
		[JsonProperty]
		public int Rotate
		{
			get { return _Rotate; }
			set 
			{ 
				_Rotate = value;
				OnPropertyChanged("Rotate");
			}
		}
		#endregion

		#region CTor
		public ThumbParamsOutput()
		{
		}

		public ThumbParamsOutput(JToken node) : base(node)
		{
			if(node["thumbParamsId"] != null)
			{
				this._ThumbParamsId = ParseInt(node["thumbParamsId"].Value<string>());
			}
			if(node["thumbParamsVersion"] != null)
			{
				this._ThumbParamsVersion = node["thumbParamsVersion"].Value<string>();
			}
			if(node["thumbAssetId"] != null)
			{
				this._ThumbAssetId = node["thumbAssetId"].Value<string>();
			}
			if(node["thumbAssetVersion"] != null)
			{
				this._ThumbAssetVersion = node["thumbAssetVersion"].Value<string>();
			}
			if(node["rotate"] != null)
			{
				this._Rotate = ParseInt(node["rotate"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaThumbParamsOutput");
			kparams.AddIfNotNull("thumbParamsId", this._ThumbParamsId);
			kparams.AddIfNotNull("thumbParamsVersion", this._ThumbParamsVersion);
			kparams.AddIfNotNull("thumbAssetId", this._ThumbAssetId);
			kparams.AddIfNotNull("thumbAssetVersion", this._ThumbAssetVersion);
			kparams.AddIfNotNull("rotate", this._Rotate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case THUMB_PARAMS_ID:
					return "ThumbParamsId";
				case THUMB_PARAMS_VERSION:
					return "ThumbParamsVersion";
				case THUMB_ASSET_ID:
					return "ThumbAssetId";
				case THUMB_ASSET_VERSION:
					return "ThumbAssetVersion";
				case ROTATE:
					return "Rotate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

