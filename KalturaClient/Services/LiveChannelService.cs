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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class LiveChannelAddRequestBuilder : RequestBuilder<LiveChannel>
	{
		#region Constants
		public const string LIVE_CHANNEL = "liveChannel";
		#endregion

		public LiveChannel LiveChannel
		{
			set;
			get;
		}

		public LiveChannelAddRequestBuilder()
			: base("livechannel", "add")
		{
		}

		public LiveChannelAddRequestBuilder(LiveChannel liveChannel)
			: this()
		{
			this.LiveChannel = liveChannel;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("liveChannel"))
				kparams.AddIfNotNull("liveChannel", LiveChannel);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LiveChannel>(result);
		}
	}

	public class LiveChannelAppendRecordingRequestBuilder : RequestBuilder<LiveEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string ASSET_ID = "assetId";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		public const string RESOURCE = "resource";
		public const string DURATION = "duration";
		public const string IS_LAST_CHUNK = "isLastChunk";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public string AssetId
		{
			set;
			get;
		}
		public EntryServerNodeType MediaServerIndex
		{
			set;
			get;
		}
		public DataCenterContentResource Resource
		{
			set;
			get;
		}
		public float Duration
		{
			set;
			get;
		}
		public bool IsLastChunk
		{
			set;
			get;
		}

		public LiveChannelAppendRecordingRequestBuilder()
			: base("livechannel", "appendRecording")
		{
		}

		public LiveChannelAppendRecordingRequestBuilder(string entryId, string assetId, EntryServerNodeType mediaServerIndex, DataCenterContentResource resource, float duration, bool isLastChunk)
			: this()
		{
			this.EntryId = entryId;
			this.AssetId = assetId;
			this.MediaServerIndex = mediaServerIndex;
			this.Resource = resource;
			this.Duration = duration;
			this.IsLastChunk = isLastChunk;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
			if (!isMapped("mediaServerIndex"))
				kparams.AddIfNotNull("mediaServerIndex", MediaServerIndex);
			if (!isMapped("resource"))
				kparams.AddIfNotNull("resource", Resource);
			if (!isMapped("duration"))
				kparams.AddIfNotNull("duration", Duration);
			if (!isMapped("isLastChunk"))
				kparams.AddIfNotNull("isLastChunk", IsLastChunk);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LiveEntry>(result);
		}
	}

	public class LiveChannelCreateRecordedEntryRequestBuilder : RequestBuilder<LiveEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		public const string LIVE_ENTRY_STATUS = "liveEntryStatus";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public EntryServerNodeType MediaServerIndex
		{
			set;
			get;
		}
		public EntryServerNodeStatus LiveEntryStatus
		{
			set;
			get;
		}

		public LiveChannelCreateRecordedEntryRequestBuilder()
			: base("livechannel", "createRecordedEntry")
		{
		}

		public LiveChannelCreateRecordedEntryRequestBuilder(string entryId, EntryServerNodeType mediaServerIndex, EntryServerNodeStatus liveEntryStatus)
			: this()
		{
			this.EntryId = entryId;
			this.MediaServerIndex = mediaServerIndex;
			this.LiveEntryStatus = liveEntryStatus;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("mediaServerIndex"))
				kparams.AddIfNotNull("mediaServerIndex", MediaServerIndex);
			if (!isMapped("liveEntryStatus"))
				kparams.AddIfNotNull("liveEntryStatus", LiveEntryStatus);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LiveEntry>(result);
		}
	}

	public class LiveChannelDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public LiveChannelDeleteRequestBuilder()
			: base("livechannel", "delete")
		{
		}

		public LiveChannelDeleteRequestBuilder(string id)
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

	public class LiveChannelGetRequestBuilder : RequestBuilder<LiveChannel>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public LiveChannelGetRequestBuilder()
			: base("livechannel", "get")
		{
		}

		public LiveChannelGetRequestBuilder(string id)
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
			return ObjectFactory.Create<LiveChannel>(result);
		}
	}

	public class LiveChannelIsLiveRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public LiveChannelIsLiveRequestBuilder()
			: base("livechannel", "isLive")
		{
		}

		public LiveChannelIsLiveRequestBuilder(string id)
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
			if (result.InnerText.Equals("1") || result.InnerText.ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class LiveChannelListRequestBuilder : RequestBuilder<ListResponse<LiveChannel>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public LiveChannelFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public LiveChannelListRequestBuilder()
			: base("livechannel", "list")
		{
		}

		public LiveChannelListRequestBuilder(LiveChannelFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<LiveChannel>>(result);
		}
	}

	public class LiveChannelRegisterMediaServerRequestBuilder : RequestBuilder<LiveEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string HOSTNAME = "hostname";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		public const string APPLICATION_NAME = "applicationName";
		public const string LIVE_ENTRY_STATUS = "liveEntryStatus";
		public const string SHOULD_CREATE_RECORDED_ENTRY = "shouldCreateRecordedEntry";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public string Hostname
		{
			set;
			get;
		}
		public EntryServerNodeType MediaServerIndex
		{
			set;
			get;
		}
		public string ApplicationName
		{
			set;
			get;
		}
		public EntryServerNodeStatus LiveEntryStatus
		{
			set;
			get;
		}
		public bool ShouldCreateRecordedEntry
		{
			set;
			get;
		}

		public LiveChannelRegisterMediaServerRequestBuilder()
			: base("livechannel", "registerMediaServer")
		{
		}

		public LiveChannelRegisterMediaServerRequestBuilder(string entryId, string hostname, EntryServerNodeType mediaServerIndex, string applicationName, EntryServerNodeStatus liveEntryStatus, bool shouldCreateRecordedEntry)
			: this()
		{
			this.EntryId = entryId;
			this.Hostname = hostname;
			this.MediaServerIndex = mediaServerIndex;
			this.ApplicationName = applicationName;
			this.LiveEntryStatus = liveEntryStatus;
			this.ShouldCreateRecordedEntry = shouldCreateRecordedEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("hostname"))
				kparams.AddIfNotNull("hostname", Hostname);
			if (!isMapped("mediaServerIndex"))
				kparams.AddIfNotNull("mediaServerIndex", MediaServerIndex);
			if (!isMapped("applicationName"))
				kparams.AddIfNotNull("applicationName", ApplicationName);
			if (!isMapped("liveEntryStatus"))
				kparams.AddIfNotNull("liveEntryStatus", LiveEntryStatus);
			if (!isMapped("shouldCreateRecordedEntry"))
				kparams.AddIfNotNull("shouldCreateRecordedEntry", ShouldCreateRecordedEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LiveEntry>(result);
		}
	}

	public class LiveChannelSetRecordedContentRequestBuilder : RequestBuilder<LiveEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		public const string RESOURCE = "resource";
		public const string DURATION = "duration";
		public const string RECORDED_ENTRY_ID = "recordedEntryId";
		public const string FLAVOR_PARAMS_ID = "flavorParamsId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public EntryServerNodeType MediaServerIndex
		{
			set;
			get;
		}
		public DataCenterContentResource Resource
		{
			set;
			get;
		}
		public float Duration
		{
			set;
			get;
		}
		public string RecordedEntryId
		{
			set;
			get;
		}
		public int FlavorParamsId
		{
			set;
			get;
		}

		public LiveChannelSetRecordedContentRequestBuilder()
			: base("livechannel", "setRecordedContent")
		{
		}

		public LiveChannelSetRecordedContentRequestBuilder(string entryId, EntryServerNodeType mediaServerIndex, DataCenterContentResource resource, float duration, string recordedEntryId, int flavorParamsId)
			: this()
		{
			this.EntryId = entryId;
			this.MediaServerIndex = mediaServerIndex;
			this.Resource = resource;
			this.Duration = duration;
			this.RecordedEntryId = recordedEntryId;
			this.FlavorParamsId = flavorParamsId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("mediaServerIndex"))
				kparams.AddIfNotNull("mediaServerIndex", MediaServerIndex);
			if (!isMapped("resource"))
				kparams.AddIfNotNull("resource", Resource);
			if (!isMapped("duration"))
				kparams.AddIfNotNull("duration", Duration);
			if (!isMapped("recordedEntryId"))
				kparams.AddIfNotNull("recordedEntryId", RecordedEntryId);
			if (!isMapped("flavorParamsId"))
				kparams.AddIfNotNull("flavorParamsId", FlavorParamsId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LiveEntry>(result);
		}
	}

	public class LiveChannelUnregisterMediaServerRequestBuilder : RequestBuilder<LiveEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string HOSTNAME = "hostname";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public string Hostname
		{
			set;
			get;
		}
		public EntryServerNodeType MediaServerIndex
		{
			set;
			get;
		}

		public LiveChannelUnregisterMediaServerRequestBuilder()
			: base("livechannel", "unregisterMediaServer")
		{
		}

		public LiveChannelUnregisterMediaServerRequestBuilder(string entryId, string hostname, EntryServerNodeType mediaServerIndex)
			: this()
		{
			this.EntryId = entryId;
			this.Hostname = hostname;
			this.MediaServerIndex = mediaServerIndex;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("hostname"))
				kparams.AddIfNotNull("hostname", Hostname);
			if (!isMapped("mediaServerIndex"))
				kparams.AddIfNotNull("mediaServerIndex", MediaServerIndex);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LiveEntry>(result);
		}
	}

	public class LiveChannelUpdateRequestBuilder : RequestBuilder<LiveChannel>
	{
		#region Constants
		public const string ID = "id";
		public const string LIVE_CHANNEL = "liveChannel";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public LiveChannel LiveChannel
		{
			set;
			get;
		}

		public LiveChannelUpdateRequestBuilder()
			: base("livechannel", "update")
		{
		}

		public LiveChannelUpdateRequestBuilder(string id, LiveChannel liveChannel)
			: this()
		{
			this.Id = id;
			this.LiveChannel = liveChannel;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("liveChannel"))
				kparams.AddIfNotNull("liveChannel", LiveChannel);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<LiveChannel>(result);
		}
	}

	public class LiveChannelValidateRegisteredMediaServersRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

		public LiveChannelValidateRegisteredMediaServersRequestBuilder()
			: base("livechannel", "validateRegisteredMediaServers")
		{
		}

		public LiveChannelValidateRegisteredMediaServersRequestBuilder(string entryId)
			: this()
		{
			this.EntryId = entryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
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


	public class LiveChannelService
	{
		private LiveChannelService()
		{
		}

		public static LiveChannelAddRequestBuilder Add(LiveChannel liveChannel)
		{
			return new LiveChannelAddRequestBuilder(liveChannel);
		}

		public static LiveChannelAppendRecordingRequestBuilder AppendRecording(string entryId, string assetId, EntryServerNodeType mediaServerIndex, DataCenterContentResource resource, float duration, bool isLastChunk = false)
		{
			return new LiveChannelAppendRecordingRequestBuilder(entryId, assetId, mediaServerIndex, resource, duration, isLastChunk);
		}

		public static LiveChannelCreateRecordedEntryRequestBuilder CreateRecordedEntry(string entryId, EntryServerNodeType mediaServerIndex, EntryServerNodeStatus liveEntryStatus)
		{
			return new LiveChannelCreateRecordedEntryRequestBuilder(entryId, mediaServerIndex, liveEntryStatus);
		}

		public static LiveChannelDeleteRequestBuilder Delete(string id)
		{
			return new LiveChannelDeleteRequestBuilder(id);
		}

		public static LiveChannelGetRequestBuilder Get(string id)
		{
			return new LiveChannelGetRequestBuilder(id);
		}

		public static LiveChannelIsLiveRequestBuilder IsLive(string id)
		{
			return new LiveChannelIsLiveRequestBuilder(id);
		}

		public static LiveChannelListRequestBuilder List(LiveChannelFilter filter = null, FilterPager pager = null)
		{
			return new LiveChannelListRequestBuilder(filter, pager);
		}

		public static LiveChannelRegisterMediaServerRequestBuilder RegisterMediaServer(string entryId, string hostname, EntryServerNodeType mediaServerIndex, string applicationName = null, EntryServerNodeStatus liveEntryStatus = (EntryServerNodeStatus)(1), bool shouldCreateRecordedEntry = true)
		{
			return new LiveChannelRegisterMediaServerRequestBuilder(entryId, hostname, mediaServerIndex, applicationName, liveEntryStatus, shouldCreateRecordedEntry);
		}

		public static LiveChannelSetRecordedContentRequestBuilder SetRecordedContent(string entryId, EntryServerNodeType mediaServerIndex, DataCenterContentResource resource, float duration, string recordedEntryId = null, int flavorParamsId = Int32.MinValue)
		{
			return new LiveChannelSetRecordedContentRequestBuilder(entryId, mediaServerIndex, resource, duration, recordedEntryId, flavorParamsId);
		}

		public static LiveChannelUnregisterMediaServerRequestBuilder UnregisterMediaServer(string entryId, string hostname, EntryServerNodeType mediaServerIndex)
		{
			return new LiveChannelUnregisterMediaServerRequestBuilder(entryId, hostname, mediaServerIndex);
		}

		public static LiveChannelUpdateRequestBuilder Update(string id, LiveChannel liveChannel)
		{
			return new LiveChannelUpdateRequestBuilder(id, liveChannel);
		}

		public static LiveChannelValidateRegisteredMediaServersRequestBuilder ValidateRegisteredMediaServers(string entryId)
		{
			return new LiveChannelValidateRegisteredMediaServersRequestBuilder(entryId);
		}
	}
}
