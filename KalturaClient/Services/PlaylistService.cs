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
// Copyright (C) 2006-2016  Kaltura Inc.
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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class PlaylistAddRequestBuilder : RequestBuilder<Playlist>
	{
		#region Constants
		public const string PLAYLIST = "playlist";
		public const string UPDATE_STATS = "updateStats";
		#endregion

		public Playlist Playlist
		{
			set;
			get;
		}
		public bool UpdateStats
		{
			set;
			get;
		}

		public PlaylistAddRequestBuilder()
			: base("playlist", "add")
		{
		}

		public PlaylistAddRequestBuilder(Playlist playlist, bool updateStats)
			: this()
		{
			this.Playlist = playlist;
			this.UpdateStats = updateStats;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("playlist"))
				kparams.AddIfNotNull("playlist", Playlist);
			if (!isMapped("updateStats"))
				kparams.AddIfNotNull("updateStats", UpdateStats);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Playlist>(result);
		}
	}

	public class PlaylistGetRequestBuilder : RequestBuilder<Playlist>
	{
		#region Constants
		public const string ID = "id";
		public const string VERSION = "version";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public int Version
		{
			set;
			get;
		}

		public PlaylistGetRequestBuilder()
			: base("playlist", "get")
		{
		}

		public PlaylistGetRequestBuilder(string id, int version)
			: this()
		{
			this.Id = id;
			this.Version = version;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("version"))
				kparams.AddIfNotNull("version", Version);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Playlist>(result);
		}
	}

	public class PlaylistUpdateRequestBuilder : RequestBuilder<Playlist>
	{
		#region Constants
		public const string ID = "id";
		public const string PLAYLIST = "playlist";
		public const string UPDATE_STATS = "updateStats";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public Playlist Playlist
		{
			set;
			get;
		}
		public bool UpdateStats
		{
			set;
			get;
		}

		public PlaylistUpdateRequestBuilder()
			: base("playlist", "update")
		{
		}

		public PlaylistUpdateRequestBuilder(string id, Playlist playlist, bool updateStats)
			: this()
		{
			this.Id = id;
			this.Playlist = playlist;
			this.UpdateStats = updateStats;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("playlist"))
				kparams.AddIfNotNull("playlist", Playlist);
			if (!isMapped("updateStats"))
				kparams.AddIfNotNull("updateStats", UpdateStats);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Playlist>(result);
		}
	}

	public class PlaylistDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public PlaylistDeleteRequestBuilder()
			: base("playlist", "delete")
		{
		}

		public PlaylistDeleteRequestBuilder(string id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class PlaylistCloneRequestBuilder : RequestBuilder<Playlist>
	{
		#region Constants
		public const string ID = "id";
		public const string NEW_PLAYLIST = "newPlaylist";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public Playlist NewPlaylist
		{
			set;
			get;
		}

		public PlaylistCloneRequestBuilder()
			: base("playlist", "clone")
		{
		}

		public PlaylistCloneRequestBuilder(string id, Playlist newPlaylist)
			: this()
		{
			this.Id = id;
			this.NewPlaylist = newPlaylist;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("newPlaylist"))
				kparams.AddIfNotNull("newPlaylist", NewPlaylist);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Playlist>(result);
		}
	}

	public class PlaylistListRequestBuilder : RequestBuilder<ListResponse<Playlist>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public PlaylistFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public PlaylistListRequestBuilder()
			: base("playlist", "list")
		{
		}

		public PlaylistListRequestBuilder(PlaylistFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<Playlist>>(result);
		}
	}

	public class PlaylistExecuteRequestBuilder : RequestBuilder<IList<BaseEntry>>
	{
		#region Constants
		public const string ID = "id";
		public const string DETAILED = "detailed";
		public const string PLAYLIST_CONTEXT = "playlistContext";
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public string Detailed
		{
			set;
			get;
		}
		public Context PlaylistContext
		{
			set;
			get;
		}
		public MediaEntryFilterForPlaylist Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public PlaylistExecuteRequestBuilder()
			: base("playlist", "execute")
		{
		}

		public PlaylistExecuteRequestBuilder(string id, string detailed, Context playlistContext, MediaEntryFilterForPlaylist filter, FilterPager pager)
			: this()
		{
			this.Id = id;
			this.Detailed = detailed;
			this.PlaylistContext = playlistContext;
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("detailed"))
				kparams.AddIfNotNull("detailed", Detailed);
			if (!isMapped("playlistContext"))
				kparams.AddIfNotNull("playlistContext", PlaylistContext);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			IList<BaseEntry> list = new List<BaseEntry>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add(ObjectFactory.Create<BaseEntry>(node));
			}
			return list;
		}
	}

	public class PlaylistExecuteFromContentRequestBuilder : RequestBuilder<IList<BaseEntry>>
	{
		#region Constants
		public const string PLAYLIST_TYPE = "playlistType";
		public const string PLAYLIST_CONTENT = "playlistContent";
		public const string DETAILED = "detailed";
		public const string PAGER = "pager";
		#endregion

		public PlaylistType PlaylistType
		{
			set;
			get;
		}
		public string PlaylistContent
		{
			set;
			get;
		}
		public string Detailed
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public PlaylistExecuteFromContentRequestBuilder()
			: base("playlist", "executeFromContent")
		{
		}

		public PlaylistExecuteFromContentRequestBuilder(PlaylistType playlistType, string playlistContent, string detailed, FilterPager pager)
			: this()
		{
			this.PlaylistType = playlistType;
			this.PlaylistContent = playlistContent;
			this.Detailed = detailed;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("playlistType"))
				kparams.AddIfNotNull("playlistType", PlaylistType);
			if (!isMapped("playlistContent"))
				kparams.AddIfNotNull("playlistContent", PlaylistContent);
			if (!isMapped("detailed"))
				kparams.AddIfNotNull("detailed", Detailed);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			IList<BaseEntry> list = new List<BaseEntry>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add(ObjectFactory.Create<BaseEntry>(node));
			}
			return list;
		}
	}

	public class PlaylistExecuteFromFiltersRequestBuilder : RequestBuilder<IList<BaseEntry>>
	{
		#region Constants
		public const string FILTERS = "filters";
		public const string TOTAL_RESULTS = "totalResults";
		public const string DETAILED = "detailed";
		public const string PAGER = "pager";
		#endregion

		public IList<MediaEntryFilterForPlaylist> Filters
		{
			set;
			get;
		}
		public int TotalResults
		{
			set;
			get;
		}
		public string Detailed
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public PlaylistExecuteFromFiltersRequestBuilder()
			: base("playlist", "executeFromFilters")
		{
		}

		public PlaylistExecuteFromFiltersRequestBuilder(IList<MediaEntryFilterForPlaylist> filters, int totalResults, string detailed, FilterPager pager)
			: this()
		{
			this.Filters = filters;
			this.TotalResults = totalResults;
			this.Detailed = detailed;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filters"))
				kparams.AddIfNotNull("filters", Filters);
			if (!isMapped("totalResults"))
				kparams.AddIfNotNull("totalResults", TotalResults);
			if (!isMapped("detailed"))
				kparams.AddIfNotNull("detailed", Detailed);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			IList<BaseEntry> list = new List<BaseEntry>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add(ObjectFactory.Create<BaseEntry>(node));
			}
			return list;
		}
	}

	public class PlaylistGetStatsFromContentRequestBuilder : RequestBuilder<Playlist>
	{
		#region Constants
		public const string PLAYLIST_TYPE = "playlistType";
		public const string PLAYLIST_CONTENT = "playlistContent";
		#endregion

		public PlaylistType PlaylistType
		{
			set;
			get;
		}
		public string PlaylistContent
		{
			set;
			get;
		}

		public PlaylistGetStatsFromContentRequestBuilder()
			: base("playlist", "getStatsFromContent")
		{
		}

		public PlaylistGetStatsFromContentRequestBuilder(PlaylistType playlistType, string playlistContent)
			: this()
		{
			this.PlaylistType = playlistType;
			this.PlaylistContent = playlistContent;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("playlistType"))
				kparams.AddIfNotNull("playlistType", PlaylistType);
			if (!isMapped("playlistContent"))
				kparams.AddIfNotNull("playlistContent", PlaylistContent);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Playlist>(result);
		}
	}


	public class PlaylistService
	{
		private PlaylistService()
		{
		}

		public static PlaylistAddRequestBuilder Add(Playlist playlist, bool updateStats = false)
		{
			return new PlaylistAddRequestBuilder(playlist, updateStats);
		}

		public static PlaylistGetRequestBuilder Get(string id, int version = -1)
		{
			return new PlaylistGetRequestBuilder(id, version);
		}

		public static PlaylistUpdateRequestBuilder Update(string id, Playlist playlist, bool updateStats = false)
		{
			return new PlaylistUpdateRequestBuilder(id, playlist, updateStats);
		}

		public static PlaylistDeleteRequestBuilder Delete(string id)
		{
			return new PlaylistDeleteRequestBuilder(id);
		}

		public static PlaylistCloneRequestBuilder Clone(string id, Playlist newPlaylist = null)
		{
			return new PlaylistCloneRequestBuilder(id, newPlaylist);
		}

		public static PlaylistListRequestBuilder List(PlaylistFilter filter = null, FilterPager pager = null)
		{
			return new PlaylistListRequestBuilder(filter, pager);
		}

		public static PlaylistExecuteRequestBuilder Execute(string id, string detailed = "", Context playlistContext = null, MediaEntryFilterForPlaylist filter = null, FilterPager pager = null)
		{
			return new PlaylistExecuteRequestBuilder(id, detailed, playlistContext, filter, pager);
		}

		public static PlaylistExecuteFromContentRequestBuilder ExecuteFromContent(PlaylistType playlistType, string playlistContent, string detailed = "", FilterPager pager = null)
		{
			return new PlaylistExecuteFromContentRequestBuilder(playlistType, playlistContent, detailed, pager);
		}

		public static PlaylistExecuteFromFiltersRequestBuilder ExecuteFromFilters(IList<MediaEntryFilterForPlaylist> filters, int totalResults, string detailed = "1", FilterPager pager = null)
		{
			return new PlaylistExecuteFromFiltersRequestBuilder(filters, totalResults, detailed, pager);
		}

		public static PlaylistGetStatsFromContentRequestBuilder GetStatsFromContent(PlaylistType playlistType, string playlistContent)
		{
			return new PlaylistGetStatsFromContentRequestBuilder(playlistType, playlistContent);
		}
	}
}
