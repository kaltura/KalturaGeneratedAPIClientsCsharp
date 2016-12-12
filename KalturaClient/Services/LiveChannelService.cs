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

namespace Kaltura
{

	public class KalturaLiveChannelService : KalturaServiceBase
	{
	public KalturaLiveChannelService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaLiveChannel Add(KalturaLiveChannel liveChannel)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("liveChannel", liveChannel);
			_Client.QueueServiceCall("livechannel", "add", "KalturaLiveChannel", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveChannel)KalturaObjectFactory.Create(result, "KalturaLiveChannel");
		}

		public KalturaLiveChannel Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("livechannel", "get", "KalturaLiveChannel", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveChannel)KalturaObjectFactory.Create(result, "KalturaLiveChannel");
		}

		public KalturaLiveChannel Update(string id, KalturaLiveChannel liveChannel)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("liveChannel", liveChannel);
			_Client.QueueServiceCall("livechannel", "update", "KalturaLiveChannel", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveChannel)KalturaObjectFactory.Create(result, "KalturaLiveChannel");
		}

		public void Delete(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("livechannel", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaLiveChannelListResponse List()
		{
			return this.List(null);
		}

		public KalturaLiveChannelListResponse List(KalturaLiveChannelFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaLiveChannelListResponse List(KalturaLiveChannelFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("livechannel", "list", "KalturaLiveChannelListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveChannelListResponse)KalturaObjectFactory.Create(result, "KalturaLiveChannelListResponse");
		}

		public bool IsLive(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("livechannel", "isLive", null, kparams);
			if (this._Client.IsMultiRequest)
				return false;
			XmlElement result = _Client.DoQueue();
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}

		public KalturaLiveEntry AppendRecording(string entryId, string assetId, KalturaEntryServerNodeType mediaServerIndex, KalturaDataCenterContentResource resource, float duration)
		{
			return this.AppendRecording(entryId, assetId, mediaServerIndex, resource, duration, false);
		}

		public KalturaLiveEntry AppendRecording(string entryId, string assetId, KalturaEntryServerNodeType mediaServerIndex, KalturaDataCenterContentResource resource, float duration, bool isLastChunk)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("assetId", assetId);
			kparams.AddIfNotNull("mediaServerIndex", mediaServerIndex);
			kparams.AddIfNotNull("resource", resource);
			kparams.AddIfNotNull("duration", duration);
			kparams.AddIfNotNull("isLastChunk", isLastChunk);
			_Client.QueueServiceCall("livechannel", "appendRecording", "KalturaLiveEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveEntry)KalturaObjectFactory.Create(result, "KalturaLiveEntry");
		}

		public KalturaLiveEntry RegisterMediaServer(string entryId, string hostname, KalturaEntryServerNodeType mediaServerIndex)
		{
			return this.RegisterMediaServer(entryId, hostname, mediaServerIndex, null);
		}

		public KalturaLiveEntry RegisterMediaServer(string entryId, string hostname, KalturaEntryServerNodeType mediaServerIndex, string applicationName)
		{
			return this.RegisterMediaServer(entryId, hostname, mediaServerIndex, applicationName, (KalturaEntryServerNodeStatus)(1));
		}

		public KalturaLiveEntry RegisterMediaServer(string entryId, string hostname, KalturaEntryServerNodeType mediaServerIndex, string applicationName, KalturaEntryServerNodeStatus liveEntryStatus)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("hostname", hostname);
			kparams.AddIfNotNull("mediaServerIndex", mediaServerIndex);
			kparams.AddIfNotNull("applicationName", applicationName);
			kparams.AddIfNotNull("liveEntryStatus", liveEntryStatus);
			_Client.QueueServiceCall("livechannel", "registerMediaServer", "KalturaLiveEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveEntry)KalturaObjectFactory.Create(result, "KalturaLiveEntry");
		}

		public KalturaLiveEntry UnregisterMediaServer(string entryId, string hostname, KalturaEntryServerNodeType mediaServerIndex)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("hostname", hostname);
			kparams.AddIfNotNull("mediaServerIndex", mediaServerIndex);
			_Client.QueueServiceCall("livechannel", "unregisterMediaServer", "KalturaLiveEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveEntry)KalturaObjectFactory.Create(result, "KalturaLiveEntry");
		}

		public void ValidateRegisteredMediaServers(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("livechannel", "validateRegisteredMediaServers", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaLiveEntry SetRecordedContent(string entryId, KalturaEntryServerNodeType mediaServerIndex, KalturaDataCenterContentResource resource, float duration)
		{
			return this.SetRecordedContent(entryId, mediaServerIndex, resource, duration, null);
		}

		public KalturaLiveEntry SetRecordedContent(string entryId, KalturaEntryServerNodeType mediaServerIndex, KalturaDataCenterContentResource resource, float duration, string recordedEntryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("mediaServerIndex", mediaServerIndex);
			kparams.AddIfNotNull("resource", resource);
			kparams.AddIfNotNull("duration", duration);
			kparams.AddIfNotNull("recordedEntryId", recordedEntryId);
			_Client.QueueServiceCall("livechannel", "setRecordedContent", "KalturaLiveEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveEntry)KalturaObjectFactory.Create(result, "KalturaLiveEntry");
		}
	}
}
