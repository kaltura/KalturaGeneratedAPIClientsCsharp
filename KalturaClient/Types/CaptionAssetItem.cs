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
	public class CaptionAssetItem : ObjectBase
	{
		#region Constants
		public const string ASSET = "asset";
		public const string ENTRY = "entry";
		public const string START_TIME = "startTime";
		public const string END_TIME = "endTime";
		public const string CONTENT = "content";
		#endregion

		#region Private Fields
		private CaptionAsset _Asset;
		private BaseEntry _Entry;
		private int _StartTime = Int32.MinValue;
		private int _EndTime = Int32.MinValue;
		private string _Content = null;
		#endregion

		#region Properties
		[JsonProperty]
		public CaptionAsset Asset
		{
			get { return _Asset; }
			set 
			{ 
				_Asset = value;
				OnPropertyChanged("Asset");
			}
		}
		[JsonProperty]
		public BaseEntry Entry
		{
			get { return _Entry; }
			set 
			{ 
				_Entry = value;
				OnPropertyChanged("Entry");
			}
		}
		[JsonProperty]
		public int StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		[JsonProperty]
		public int EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		[JsonProperty]
		public string Content
		{
			get { return _Content; }
			set 
			{ 
				_Content = value;
				OnPropertyChanged("Content");
			}
		}
		#endregion

		#region CTor
		public CaptionAssetItem()
		{
		}

		public CaptionAssetItem(JToken node) : base(node)
		{
			if(node["asset"] != null)
			{
				this._Asset = ObjectFactory.Create<CaptionAsset>(node["asset"]);
			}
			if(node["entry"] != null)
			{
				this._Entry = ObjectFactory.Create<BaseEntry>(node["entry"]);
			}
			if(node["startTime"] != null)
			{
				this._StartTime = ParseInt(node["startTime"].Value<string>());
			}
			if(node["endTime"] != null)
			{
				this._EndTime = ParseInt(node["endTime"].Value<string>());
			}
			if(node["content"] != null)
			{
				this._Content = node["content"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCaptionAssetItem");
			kparams.AddIfNotNull("asset", this._Asset);
			kparams.AddIfNotNull("entry", this._Entry);
			kparams.AddIfNotNull("startTime", this._StartTime);
			kparams.AddIfNotNull("endTime", this._EndTime);
			kparams.AddIfNotNull("content", this._Content);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET:
					return "Asset";
				case ENTRY:
					return "Entry";
				case START_TIME:
					return "StartTime";
				case END_TIME:
					return "EndTime";
				case CONTENT:
					return "Content";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

