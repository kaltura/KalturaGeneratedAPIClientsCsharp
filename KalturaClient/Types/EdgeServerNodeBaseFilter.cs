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
	public class EdgeServerNodeBaseFilter : DeliveryServerNodeFilter
	{
		#region Constants
		public const string PLAYBACK_DOMAIN_LIKE = "playbackDomainLike";
		public const string PLAYBACK_DOMAIN_MULTI_LIKE_OR = "playbackDomainMultiLikeOr";
		public const string PLAYBACK_DOMAIN_MULTI_LIKE_AND = "playbackDomainMultiLikeAnd";
		#endregion

		#region Private Fields
		private string _PlaybackDomainLike = null;
		private string _PlaybackDomainMultiLikeOr = null;
		private string _PlaybackDomainMultiLikeAnd = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use PlaybackDomainLikeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PlaybackDomainLike
		{
			get { return _PlaybackDomainLike; }
			set 
			{ 
				_PlaybackDomainLike = value;
				OnPropertyChanged("PlaybackDomainLike");
			}
		}
		/// <summary>
		/// Use PlaybackDomainMultiLikeOrAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PlaybackDomainMultiLikeOr
		{
			get { return _PlaybackDomainMultiLikeOr; }
			set 
			{ 
				_PlaybackDomainMultiLikeOr = value;
				OnPropertyChanged("PlaybackDomainMultiLikeOr");
			}
		}
		/// <summary>
		/// Use PlaybackDomainMultiLikeAndAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PlaybackDomainMultiLikeAnd
		{
			get { return _PlaybackDomainMultiLikeAnd; }
			set 
			{ 
				_PlaybackDomainMultiLikeAnd = value;
				OnPropertyChanged("PlaybackDomainMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public EdgeServerNodeBaseFilter()
		{
		}

		public EdgeServerNodeBaseFilter(JToken node) : base(node)
		{
			if(node["playbackDomainLike"] != null)
			{
				this._PlaybackDomainLike = node["playbackDomainLike"].Value<string>();
			}
			if(node["playbackDomainMultiLikeOr"] != null)
			{
				this._PlaybackDomainMultiLikeOr = node["playbackDomainMultiLikeOr"].Value<string>();
			}
			if(node["playbackDomainMultiLikeAnd"] != null)
			{
				this._PlaybackDomainMultiLikeAnd = node["playbackDomainMultiLikeAnd"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEdgeServerNodeBaseFilter");
			kparams.AddIfNotNull("playbackDomainLike", this._PlaybackDomainLike);
			kparams.AddIfNotNull("playbackDomainMultiLikeOr", this._PlaybackDomainMultiLikeOr);
			kparams.AddIfNotNull("playbackDomainMultiLikeAnd", this._PlaybackDomainMultiLikeAnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PLAYBACK_DOMAIN_LIKE:
					return "PlaybackDomainLike";
				case PLAYBACK_DOMAIN_MULTI_LIKE_OR:
					return "PlaybackDomainMultiLikeOr";
				case PLAYBACK_DOMAIN_MULTI_LIKE_AND:
					return "PlaybackDomainMultiLikeAnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

