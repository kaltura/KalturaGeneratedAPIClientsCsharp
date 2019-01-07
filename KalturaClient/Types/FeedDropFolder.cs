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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class FeedDropFolder : DropFolder
	{
		#region Constants
		public const string ITEM_HANDLING_LIMIT = "itemHandlingLimit";
		public const string FEED_ITEM_INFO = "feedItemInfo";
		#endregion

		#region Private Fields
		private int _ItemHandlingLimit = Int32.MinValue;
		private FeedItemInfo _FeedItemInfo;
		#endregion

		#region Properties
		[JsonProperty]
		public int ItemHandlingLimit
		{
			get { return _ItemHandlingLimit; }
			set 
			{ 
				_ItemHandlingLimit = value;
				OnPropertyChanged("ItemHandlingLimit");
			}
		}
		[JsonProperty]
		public FeedItemInfo FeedItemInfo
		{
			get { return _FeedItemInfo; }
			set 
			{ 
				_FeedItemInfo = value;
				OnPropertyChanged("FeedItemInfo");
			}
		}
		#endregion

		#region CTor
		public FeedDropFolder()
		{
		}

		public FeedDropFolder(JToken node) : base(node)
		{
			if(node["itemHandlingLimit"] != null)
			{
				this._ItemHandlingLimit = ParseInt(node["itemHandlingLimit"].Value<string>());
			}
			if(node["feedItemInfo"] != null)
			{
				this._FeedItemInfo = ObjectFactory.Create<FeedItemInfo>(node["feedItemInfo"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFeedDropFolder");
			kparams.AddIfNotNull("itemHandlingLimit", this._ItemHandlingLimit);
			kparams.AddIfNotNull("feedItemInfo", this._FeedItemInfo);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ITEM_HANDLING_LIMIT:
					return "ItemHandlingLimit";
				case FEED_ITEM_INFO:
					return "FeedItemInfo";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

