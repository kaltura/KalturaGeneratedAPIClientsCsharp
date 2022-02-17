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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class PlaylistFilter : PlaylistBaseFilter
	{
		#region Constants
		public const string PLAY_LIST_TYPE_EQUAL = "playListTypeEqual";
		public const string PLAY_LIST_TYPE_IN = "playListTypeIn";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private PlaylistType _PlayListTypeEqual = (PlaylistType)Int32.MinValue;
		private string _PlayListTypeIn = null;
		private PlaylistOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use PlayListTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PlaylistType PlayListTypeEqual
		{
			get { return _PlayListTypeEqual; }
			set 
			{ 
				_PlayListTypeEqual = value;
				OnPropertyChanged("PlayListTypeEqual");
			}
		}
		/// <summary>
		/// Use PlayListTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PlayListTypeIn
		{
			get { return _PlayListTypeIn; }
			set 
			{ 
				_PlayListTypeIn = value;
				OnPropertyChanged("PlayListTypeIn");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new PlaylistOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public PlaylistFilter()
		{
		}

		public PlaylistFilter(JToken node) : base(node)
		{
			if(node["playListTypeEqual"] != null)
			{
				this._PlayListTypeEqual = (PlaylistType)ParseEnum(typeof(PlaylistType), node["playListTypeEqual"].Value<string>());
			}
			if(node["playListTypeIn"] != null)
			{
				this._PlayListTypeIn = node["playListTypeIn"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (PlaylistOrderBy)StringEnum.Parse(typeof(PlaylistOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPlaylistFilter");
			kparams.AddIfNotNull("playListTypeEqual", this._PlayListTypeEqual);
			kparams.AddIfNotNull("playListTypeIn", this._PlayListTypeIn);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PLAY_LIST_TYPE_EQUAL:
					return "PlayListTypeEqual";
				case PLAY_LIST_TYPE_IN:
					return "PlayListTypeIn";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

