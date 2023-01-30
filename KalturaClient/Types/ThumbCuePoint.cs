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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class ThumbCuePoint : CuePoint
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string DESCRIPTION = "description";
		public const string TITLE = "title";
		public const string SUB_TYPE = "subType";
		#endregion

		#region Private Fields
		private string _AssetId = null;
		private string _Description = null;
		private string _Title = null;
		private ThumbCuePointSubType _SubType = (ThumbCuePointSubType)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use AssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use TitleAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		/// <summary>
		/// Use SubTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ThumbCuePointSubType SubType
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
		public ThumbCuePoint()
		{
		}

		public ThumbCuePoint(JToken node) : base(node)
		{
			if(node["assetId"] != null)
			{
				this._AssetId = node["assetId"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["title"] != null)
			{
				this._Title = node["title"].Value<string>();
			}
			if(node["subType"] != null)
			{
				this._SubType = (ThumbCuePointSubType)ParseEnum(typeof(ThumbCuePointSubType), node["subType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaThumbCuePoint");
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("title", this._Title);
			kparams.AddIfNotNull("subType", this._SubType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_ID:
					return "AssetId";
				case DESCRIPTION:
					return "Description";
				case TITLE:
					return "Title";
				case SUB_TYPE:
					return "SubType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

