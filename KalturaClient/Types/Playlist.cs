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
	public class Playlist : BaseEntry
	{
		#region Constants
		public const string PLAYLIST_CONTENT = "playlistContent";
		public const string FILTERS = "filters";
		public const string TOTAL_RESULTS = "totalResults";
		public const string PLAYLIST_TYPE = "playlistType";
		public const string PLAYS = "plays";
		public const string VIEWS = "views";
		public const string DURATION = "duration";
		public const string EXECUTE_URL = "executeUrl";
		#endregion

		#region Private Fields
		private string _PlaylistContent = null;
		private IList<MediaEntryFilterForPlaylist> _Filters;
		private int _TotalResults = Int32.MinValue;
		private PlaylistType _PlaylistType = (PlaylistType)Int32.MinValue;
		private int _Plays = Int32.MinValue;
		private int _Views = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private string _ExecuteUrl = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string PlaylistContent
		{
			get { return _PlaylistContent; }
			set 
			{ 
				_PlaylistContent = value;
				OnPropertyChanged("PlaylistContent");
			}
		}
		[JsonProperty]
		public IList<MediaEntryFilterForPlaylist> Filters
		{
			get { return _Filters; }
			set 
			{ 
				_Filters = value;
				OnPropertyChanged("Filters");
			}
		}
		[JsonProperty]
		public int TotalResults
		{
			get { return _TotalResults; }
			set 
			{ 
				_TotalResults = value;
				OnPropertyChanged("TotalResults");
			}
		}
		[JsonProperty]
		public PlaylistType PlaylistType
		{
			get { return _PlaylistType; }
			set 
			{ 
				_PlaylistType = value;
				OnPropertyChanged("PlaylistType");
			}
		}
		[JsonProperty]
		public int Plays
		{
			get { return _Plays; }
			private set 
			{ 
				_Plays = value;
				OnPropertyChanged("Plays");
			}
		}
		[JsonProperty]
		public int Views
		{
			get { return _Views; }
			private set 
			{ 
				_Views = value;
				OnPropertyChanged("Views");
			}
		}
		[JsonProperty]
		public int Duration
		{
			get { return _Duration; }
			private set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		[JsonProperty]
		public string ExecuteUrl
		{
			get { return _ExecuteUrl; }
			private set 
			{ 
				_ExecuteUrl = value;
				OnPropertyChanged("ExecuteUrl");
			}
		}
		#endregion

		#region CTor
		public Playlist()
		{
		}

		public Playlist(JToken node) : base(node)
		{
			if(node["playlistContent"] != null)
			{
				this._PlaylistContent = node["playlistContent"].Value<string>();
			}
			if(node["filters"] != null)
			{
				this._Filters = new List<MediaEntryFilterForPlaylist>();
				foreach(var arrayNode in node["filters"].Children())
				{
					this._Filters.Add(ObjectFactory.Create<MediaEntryFilterForPlaylist>(arrayNode));
				}
			}
			if(node["totalResults"] != null)
			{
				this._TotalResults = ParseInt(node["totalResults"].Value<string>());
			}
			if(node["playlistType"] != null)
			{
				this._PlaylistType = (PlaylistType)ParseEnum(typeof(PlaylistType), node["playlistType"].Value<string>());
			}
			if(node["plays"] != null)
			{
				this._Plays = ParseInt(node["plays"].Value<string>());
			}
			if(node["views"] != null)
			{
				this._Views = ParseInt(node["views"].Value<string>());
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseInt(node["duration"].Value<string>());
			}
			if(node["executeUrl"] != null)
			{
				this._ExecuteUrl = node["executeUrl"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPlaylist");
			kparams.AddIfNotNull("playlistContent", this._PlaylistContent);
			kparams.AddIfNotNull("filters", this._Filters);
			kparams.AddIfNotNull("totalResults", this._TotalResults);
			kparams.AddIfNotNull("playlistType", this._PlaylistType);
			kparams.AddIfNotNull("plays", this._Plays);
			kparams.AddIfNotNull("views", this._Views);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("executeUrl", this._ExecuteUrl);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PLAYLIST_CONTENT:
					return "PlaylistContent";
				case FILTERS:
					return "Filters";
				case TOTAL_RESULTS:
					return "TotalResults";
				case PLAYLIST_TYPE:
					return "PlaylistType";
				case PLAYS:
					return "Plays";
				case VIEWS:
					return "Views";
				case DURATION:
					return "Duration";
				case EXECUTE_URL:
					return "ExecuteUrl";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

