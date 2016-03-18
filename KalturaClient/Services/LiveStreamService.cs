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

	public class KalturaLiveStreamService : KalturaServiceBase
	{
	public KalturaLiveStreamService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaLiveStreamEntry Add(KalturaLiveStreamEntry liveStreamEntry)
		{
			return this.Add(liveStreamEntry, null);
		}

		public KalturaLiveStreamEntry Add(KalturaLiveStreamEntry liveStreamEntry, KalturaSourceType sourceType)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("liveStreamEntry", liveStreamEntry);
			kparams.AddIfNotNull("sourceType", sourceType);
			_Client.QueueServiceCall("livestream", "add", "KalturaLiveStreamEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result, "KalturaLiveStreamEntry");
		}

		public KalturaLiveStreamEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaLiveStreamEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("version", version);
			_Client.QueueServiceCall("livestream", "get", "KalturaLiveStreamEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result, "KalturaLiveStreamEntry");
		}

		public KalturaLiveStreamEntry Authenticate(string entryId, string token)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("token", token);
			_Client.QueueServiceCall("livestream", "authenticate", "KalturaLiveStreamEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result, "KalturaLiveStreamEntry");
		}

		public KalturaLiveStreamEntry Update(string entryId, KalturaLiveStreamEntry liveStreamEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("liveStreamEntry", liveStreamEntry);
			_Client.QueueServiceCall("livestream", "update", "KalturaLiveStreamEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result, "KalturaLiveStreamEntry");
		}

		public void Delete(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("livestream", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaLiveStreamListResponse List()
		{
			return this.List(null);
		}

		public KalturaLiveStreamListResponse List(KalturaLiveStreamEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaLiveStreamListResponse List(KalturaLiveStreamEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("livestream", "list", "KalturaLiveStreamListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamListResponse)KalturaObjectFactory.Create(result, "KalturaLiveStreamListResponse");
		}

		public KalturaLiveStreamEntry UpdateOfflineThumbnailJpeg(string entryId, Stream fileData)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			_Client.QueueServiceCall("livestream", "updateOfflineThumbnailJpeg", "KalturaLiveStreamEntry", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result, "KalturaLiveStreamEntry");
		}

		public KalturaLiveStreamEntry UpdateOfflineThumbnailFromUrl(string entryId, string url)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("url", url);
			_Client.QueueServiceCall("livestream", "updateOfflineThumbnailFromUrl", "KalturaLiveStreamEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result, "KalturaLiveStreamEntry");
		}

		public bool IsLive(string id, KalturaPlaybackProtocol protocol)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("protocol", protocol);
			_Client.QueueServiceCall("livestream", "isLive", null, kparams);
			if (this._Client.IsMultiRequest)
				return false;
			XmlElement result = _Client.DoQueue();
			if (result.InnerText == "1")
				return true;
			return false;
		}

		public KalturaLiveStreamEntry AddLiveStreamPushPublishConfiguration(string entryId, KalturaPlaybackProtocol protocol)
		{
			return this.AddLiveStreamPushPublishConfiguration(entryId, protocol, null);
		}

		public KalturaLiveStreamEntry AddLiveStreamPushPublishConfiguration(string entryId, KalturaPlaybackProtocol protocol, string url)
		{
			return this.AddLiveStreamPushPublishConfiguration(entryId, protocol, url, null);
		}

		public KalturaLiveStreamEntry AddLiveStreamPushPublishConfiguration(string entryId, KalturaPlaybackProtocol protocol, string url, KalturaLiveStreamConfiguration liveStreamConfiguration)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("protocol", protocol);
			kparams.AddIfNotNull("url", url);
			kparams.AddIfNotNull("liveStreamConfiguration", liveStreamConfiguration);
			_Client.QueueServiceCall("livestream", "addLiveStreamPushPublishConfiguration", "KalturaLiveStreamEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result, "KalturaLiveStreamEntry");
		}

		public KalturaLiveStreamEntry RemoveLiveStreamPushPublishConfiguration(string entryId, KalturaPlaybackProtocol protocol)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("protocol", protocol);
			_Client.QueueServiceCall("livestream", "removeLiveStreamPushPublishConfiguration", "KalturaLiveStreamEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveStreamEntry)KalturaObjectFactory.Create(result, "KalturaLiveStreamEntry");
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
			_Client.QueueServiceCall("livestream", "appendRecording", "KalturaLiveEntry", kparams);
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
			_Client.QueueServiceCall("livestream", "registerMediaServer", "KalturaLiveEntry", kparams);
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
			_Client.QueueServiceCall("livestream", "unregisterMediaServer", "KalturaLiveEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaLiveEntry)KalturaObjectFactory.Create(result, "KalturaLiveEntry");
		}

		public void ValidateRegisteredMediaServers(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("livestream", "validateRegisteredMediaServers", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void CreatePeriodicSyncPoints(string entryId, int interval, int duration)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("interval", interval);
			kparams.AddIfNotNull("duration", duration);
			_Client.QueueServiceCall("livestream", "createPeriodicSyncPoints", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
