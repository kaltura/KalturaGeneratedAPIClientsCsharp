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

	public class KalturaMixingService : KalturaServiceBase
	{
	public KalturaMixingService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaMixEntry Add(KalturaMixEntry mixEntry)
		{
			KalturaParams kparams = new KalturaParams();
			if (mixEntry != null)
				kparams.Add("mixEntry", mixEntry.ToParams());
			_Client.QueueServiceCall("mixing", "add", "KalturaMixEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMixEntry)KalturaObjectFactory.Create(result, "KalturaMixEntry");
		}

		public KalturaMixEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaMixEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("mixing", "get", "KalturaMixEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMixEntry)KalturaObjectFactory.Create(result, "KalturaMixEntry");
		}

		public KalturaMixEntry Update(string entryId, KalturaMixEntry mixEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			if (mixEntry != null)
				kparams.Add("mixEntry", mixEntry.ToParams());
			_Client.QueueServiceCall("mixing", "update", "KalturaMixEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMixEntry)KalturaObjectFactory.Create(result, "KalturaMixEntry");
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("mixing", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaMixListResponse List()
		{
			return this.List(null);
		}

		public KalturaMixListResponse List(KalturaMixEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaMixListResponse List(KalturaMixEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("mixing", "list", "KalturaMixListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMixListResponse)KalturaObjectFactory.Create(result, "KalturaMixListResponse");
		}

		public int Count()
		{
			return this.Count(null);
		}

		public int Count(KalturaMediaEntryFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			_Client.QueueServiceCall("mixing", "count", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public KalturaMixEntry Clone(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("mixing", "clone", "KalturaMixEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMixEntry)KalturaObjectFactory.Create(result, "KalturaMixEntry");
		}

		public KalturaMixEntry AppendMediaEntry(string mixEntryId, string mediaEntryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("mixEntryId", mixEntryId);
			kparams.AddStringIfNotNull("mediaEntryId", mediaEntryId);
			_Client.QueueServiceCall("mixing", "appendMediaEntry", "KalturaMixEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMixEntry)KalturaObjectFactory.Create(result, "KalturaMixEntry");
		}

		public IList<KalturaMixEntry> GetMixesByMediaId(string mediaEntryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("mediaEntryId", mediaEntryId);
			_Client.QueueServiceCall("mixing", "getMixesByMediaId", "KalturaMixEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaMixEntry> list = new List<KalturaMixEntry>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaMixEntry)KalturaObjectFactory.Create(node, "KalturaMixEntry"));
			}
			return list;
		}

		public IList<KalturaMediaEntry> GetReadyMediaEntries(string mixId)
		{
			return this.GetReadyMediaEntries(mixId, -1);
		}

		public IList<KalturaMediaEntry> GetReadyMediaEntries(string mixId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("mixId", mixId);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("mixing", "getReadyMediaEntries", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaMediaEntry> list = new List<KalturaMediaEntry>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaMediaEntry)KalturaObjectFactory.Create(node, "KalturaMediaEntry"));
			}
			return list;
		}

		public void AnonymousRank(string entryId, int rank)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("rank", rank);
			_Client.QueueServiceCall("mixing", "anonymousRank", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
