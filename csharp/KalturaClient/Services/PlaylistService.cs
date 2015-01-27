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
// Copyright (C) 2006-2011  Kaltura Inc.
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

namespace Kaltura
{

	public class KalturaPlaylistService : KalturaServiceBase
	{
	public KalturaPlaylistService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaPlaylist Add(KalturaPlaylist playlist)
		{
			return this.Add(playlist, false);
		}

		public KalturaPlaylist Add(KalturaPlaylist playlist, bool updateStats)
		{
			KalturaParams kparams = new KalturaParams();
			if (playlist != null)
				kparams.Add("playlist", playlist.ToParams());
			kparams.AddBoolIfNotNull("updateStats", updateStats);
			_Client.QueueServiceCall("playlist", "add", "KalturaPlaylist", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPlaylist)KalturaObjectFactory.Create(result, "KalturaPlaylist");
		}

		public KalturaPlaylist Get(string id)
		{
			return this.Get(id, -1);
		}

		public KalturaPlaylist Get(string id, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("playlist", "get", "KalturaPlaylist", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPlaylist)KalturaObjectFactory.Create(result, "KalturaPlaylist");
		}

		public KalturaPlaylist Update(string id, KalturaPlaylist playlist)
		{
			return this.Update(id, playlist, false);
		}

		public KalturaPlaylist Update(string id, KalturaPlaylist playlist, bool updateStats)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (playlist != null)
				kparams.Add("playlist", playlist.ToParams());
			kparams.AddBoolIfNotNull("updateStats", updateStats);
			_Client.QueueServiceCall("playlist", "update", "KalturaPlaylist", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPlaylist)KalturaObjectFactory.Create(result, "KalturaPlaylist");
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			_Client.QueueServiceCall("playlist", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaPlaylist Clone(string id)
		{
			return this.Clone(id, null);
		}

		public KalturaPlaylist Clone(string id, KalturaPlaylist newPlaylist)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			if (newPlaylist != null)
				kparams.Add("newPlaylist", newPlaylist.ToParams());
			_Client.QueueServiceCall("playlist", "clone", "KalturaPlaylist", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPlaylist)KalturaObjectFactory.Create(result, "KalturaPlaylist");
		}

		public KalturaPlaylistListResponse List()
		{
			return this.List(null);
		}

		public KalturaPlaylistListResponse List(KalturaPlaylistFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaPlaylistListResponse List(KalturaPlaylistFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("playlist", "list", "KalturaPlaylistListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPlaylistListResponse)KalturaObjectFactory.Create(result, "KalturaPlaylistListResponse");
		}

		public IList<KalturaBaseEntry> Execute(string id)
		{
			return this.Execute(id, "");
		}

		public IList<KalturaBaseEntry> Execute(string id, string detailed)
		{
			return this.Execute(id, detailed, null);
		}

		public IList<KalturaBaseEntry> Execute(string id, string detailed, KalturaContext playlistContext)
		{
			return this.Execute(id, detailed, playlistContext, null);
		}

		public IList<KalturaBaseEntry> Execute(string id, string detailed, KalturaContext playlistContext, KalturaMediaEntryFilterForPlaylist filter)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("id", id);
			kparams.AddStringIfNotNull("detailed", detailed);
			if (playlistContext != null)
				kparams.Add("playlistContext", playlistContext.ToParams());
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			_Client.QueueServiceCall("playlist", "execute", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaBaseEntry> list = new List<KalturaBaseEntry>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaBaseEntry)KalturaObjectFactory.Create(node, "KalturaBaseEntry"));
			}
			return list;
		}

		public IList<KalturaBaseEntry> ExecuteFromContent(KalturaPlaylistType playlistType, string playlistContent)
		{
			return this.ExecuteFromContent(playlistType, playlistContent, "");
		}

		public IList<KalturaBaseEntry> ExecuteFromContent(KalturaPlaylistType playlistType, string playlistContent, string detailed)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddEnumIfNotNull("playlistType", playlistType);
			kparams.AddStringIfNotNull("playlistContent", playlistContent);
			kparams.AddStringIfNotNull("detailed", detailed);
			_Client.QueueServiceCall("playlist", "executeFromContent", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaBaseEntry> list = new List<KalturaBaseEntry>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaBaseEntry)KalturaObjectFactory.Create(node, "KalturaBaseEntry"));
			}
			return list;
		}

		public IList<KalturaBaseEntry> ExecuteFromFilters(IList<KalturaMediaEntryFilterForPlaylist> filters, int totalResults)
		{
			return this.ExecuteFromFilters(filters, totalResults, "");
		}

		public IList<KalturaBaseEntry> ExecuteFromFilters(IList<KalturaMediaEntryFilterForPlaylist> filters, int totalResults, string detailed)
		{
			KalturaParams kparams = new KalturaParams();
			foreach(KalturaMediaEntryFilterForPlaylist obj in filters)
			{
				kparams.Add("filters", obj.ToParams());
			}
			kparams.AddIntIfNotNull("totalResults", totalResults);
			kparams.AddStringIfNotNull("detailed", detailed);
			_Client.QueueServiceCall("playlist", "executeFromFilters", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaBaseEntry> list = new List<KalturaBaseEntry>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaBaseEntry)KalturaObjectFactory.Create(node, "KalturaBaseEntry"));
			}
			return list;
		}

		public KalturaPlaylist GetStatsFromContent(KalturaPlaylistType playlistType, string playlistContent)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddEnumIfNotNull("playlistType", playlistType);
			kparams.AddStringIfNotNull("playlistContent", playlistContent);
			_Client.QueueServiceCall("playlist", "getStatsFromContent", "KalturaPlaylist", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPlaylist)KalturaObjectFactory.Create(result, "KalturaPlaylist");
		}
	}
}
