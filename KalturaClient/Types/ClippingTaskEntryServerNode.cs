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
	public class ClippingTaskEntryServerNode : TaskEntryServerNode
	{
		#region Constants
		public const string CLIP_ATTRIBUTES = "clipAttributes";
		public const string CLIPPED_ENTRY_ID = "clippedEntryId";
		public const string LIVE_ENTRY_ID = "liveEntryId";
		#endregion

		#region Private Fields
		private ClipAttributes _ClipAttributes;
		private string _ClippedEntryId = null;
		private string _LiveEntryId = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ClipAttributesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ClipAttributes ClipAttributes
		{
			get { return _ClipAttributes; }
			set 
			{ 
				_ClipAttributes = value;
				OnPropertyChanged("ClipAttributes");
			}
		}
		/// <summary>
		/// Use ClippedEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ClippedEntryId
		{
			get { return _ClippedEntryId; }
			set 
			{ 
				_ClippedEntryId = value;
				OnPropertyChanged("ClippedEntryId");
			}
		}
		/// <summary>
		/// Use LiveEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LiveEntryId
		{
			get { return _LiveEntryId; }
			set 
			{ 
				_LiveEntryId = value;
				OnPropertyChanged("LiveEntryId");
			}
		}
		#endregion

		#region CTor
		public ClippingTaskEntryServerNode()
		{
		}

		public ClippingTaskEntryServerNode(JToken node) : base(node)
		{
			if(node["clipAttributes"] != null)
			{
				this._ClipAttributes = ObjectFactory.Create<ClipAttributes>(node["clipAttributes"]);
			}
			if(node["clippedEntryId"] != null)
			{
				this._ClippedEntryId = node["clippedEntryId"].Value<string>();
			}
			if(node["liveEntryId"] != null)
			{
				this._LiveEntryId = node["liveEntryId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaClippingTaskEntryServerNode");
			kparams.AddIfNotNull("clipAttributes", this._ClipAttributes);
			kparams.AddIfNotNull("clippedEntryId", this._ClippedEntryId);
			kparams.AddIfNotNull("liveEntryId", this._LiveEntryId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CLIP_ATTRIBUTES:
					return "ClipAttributes";
				case CLIPPED_ENTRY_ID:
					return "ClippedEntryId";
				case LIVE_ENTRY_ID:
					return "LiveEntryId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

