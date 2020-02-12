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
// Copyright (C) 2006-2020  Kaltura Inc.
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
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class LiveStreamAddRequestBuilder : RequestBuilder<LiveStreamEntry>
	{
		#region Constants
		public const string LIVE_STREAM_ENTRY = "liveStreamEntry";
		public const string SOURCE_TYPE = "sourceType";
		#endregion

		public LiveStreamEntry LiveStreamEntry { get; set; }
		public SourceType SourceType { get; set; }

		public LiveStreamAddRequestBuilder()
			: base("livestream", "add")
		{
		}

		public LiveStreamAddRequestBuilder(LiveStreamEntry liveStreamEntry, SourceType sourceType)
			: this()
		{
			this.LiveStreamEntry = liveStreamEntry;
			this.SourceType = sourceType;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("liveStreamEntry"))
				kparams.AddIfNotNull("liveStreamEntry", LiveStreamEntry);
			if (!isMapped("sourceType"))
				kparams.AddIfNotNull("sourceType", SourceType);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveStreamEntry>(result);
		}
	}

	public class LiveStreamAddLiveStreamPushPublishConfigurationRequestBuilder : RequestBuilder<LiveStreamEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string PROTOCOL = "protocol";
		public const string URL = "url";
		public const string LIVE_STREAM_CONFIGURATION = "liveStreamConfiguration";
		#endregion

		public string EntryId { get; set; }
		public PlaybackProtocol Protocol { get; set; }
		public string Url { get; set; }
		public LiveStreamConfiguration LiveStreamConfiguration { get; set; }

		public LiveStreamAddLiveStreamPushPublishConfigurationRequestBuilder()
			: base("livestream", "addLiveStreamPushPublishConfiguration")
		{
		}

		public LiveStreamAddLiveStreamPushPublishConfigurationRequestBuilder(string entryId, PlaybackProtocol protocol, string url, LiveStreamConfiguration liveStreamConfiguration)
			: this()
		{
			this.EntryId = entryId;
			this.Protocol = protocol;
			this.Url = url;
			this.LiveStreamConfiguration = liveStreamConfiguration;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("protocol"))
				kparams.AddIfNotNull("protocol", Protocol);
			if (!isMapped("url"))
				kparams.AddIfNotNull("url", Url);
			if (!isMapped("liveStreamConfiguration"))
				kparams.AddIfNotNull("liveStreamConfiguration", LiveStreamConfiguration);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveStreamEntry>(result);
		}
	}

	public class LiveStreamAppendRecordingRequestBuilder : RequestBuilder<LiveEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string ASSET_ID = "assetId";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		public const string RESOURCE = "resource";
		public const string DURATION = "duration";
		public const string IS_LAST_CHUNK = "isLastChunk";
		#endregion

		public string EntryId { get; set; }
		public string AssetId { get; set; }
		public EntryServerNodeType MediaServerIndex { get; set; }
		public DataCenterContentResource Resource { get; set; }
		public float Duration { get; set; }
		public bool IsLastChunk { get; set; }

		public LiveStreamAppendRecordingRequestBuilder()
			: base("livestream", "appendRecording")
		{
		}

		public LiveStreamAppendRecordingRequestBuilder(string entryId, string assetId, EntryServerNodeType mediaServerIndex, DataCenterContentResource resource, float duration, bool isLastChunk)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveEntry>(result);
		}
	}

	public class LiveStreamArchiveRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string LIVE_ENTRY_ID = "liveEntryId";
		public const string VOD_ENTRY_ID = "vodEntryId";
		#endregion

		public string LiveEntryId { get; set; }
		public string VodEntryId { get; set; }

		public LiveStreamArchiveRequestBuilder()
			: base("livestream", "archive")
		{
		}

		public LiveStreamArchiveRequestBuilder(string liveEntryId, string vodEntryId)
			: this()
		{
			this.LiveEntryId = liveEntryId;
			this.VodEntryId = vodEntryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("liveEntryId"))
				kparams.AddIfNotNull("liveEntryId", LiveEntryId);
			if (!isMapped("vodEntryId"))
				kparams.AddIfNotNull("vodEntryId", VodEntryId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			if (result.Value<string>().Equals("1") || result.Value<string>().ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class LiveStreamAuthenticateRequestBuilder : RequestBuilder<LiveStreamEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string TOKEN = "token";
		public const string HOSTNAME = "hostname";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		public const string APPLICATION_NAME = "applicationName";
		#endregion

		public string EntryId { get; set; }
		public string Token { get; set; }
		public string Hostname { get; set; }
		public EntryServerNodeType MediaServerIndex { get; set; }
		public string ApplicationName { get; set; }

		public LiveStreamAuthenticateRequestBuilder()
			: base("livestream", "authenticate")
		{
		}

		public LiveStreamAuthenticateRequestBuilder(string entryId, string token, string hostname, EntryServerNodeType mediaServerIndex, string applicationName)
			: this()
		{
			this.EntryId = entryId;
			this.Token = token;
			this.Hostname = hostname;
			this.MediaServerIndex = mediaServerIndex;
			this.ApplicationName = applicationName;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("token"))
				kparams.AddIfNotNull("token", Token);
			if (!isMapped("hostname"))
				kparams.AddIfNotNull("hostname", Hostname);
			if (!isMapped("mediaServerIndex"))
				kparams.AddIfNotNull("mediaServerIndex", MediaServerIndex);
			if (!isMapped("applicationName"))
				kparams.AddIfNotNull("applicationName", ApplicationName);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveStreamEntry>(result);
		}
	}

	public class LiveStreamCreatePeriodicSyncPointsRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string INTERVAL = "interval";
		public const string DURATION = "duration";
		#endregion

		public string EntryId { get; set; }
		public int Interval { get; set; }
		public int Duration { get; set; }

		public LiveStreamCreatePeriodicSyncPointsRequestBuilder()
			: base("livestream", "createPeriodicSyncPoints")
		{
		}

		public LiveStreamCreatePeriodicSyncPointsRequestBuilder(string entryId, int interval, int duration)
			: this()
		{
			this.EntryId = entryId;
			this.Interval = interval;
			this.Duration = duration;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("interval"))
				kparams.AddIfNotNull("interval", Interval);
			if (!isMapped("duration"))
				kparams.AddIfNotNull("duration", Duration);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class LiveStreamCreateRecordedEntryRequestBuilder : RequestBuilder<LiveEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		public const string LIVE_ENTRY_STATUS = "liveEntryStatus";
		#endregion

		public string EntryId { get; set; }
		public EntryServerNodeType MediaServerIndex { get; set; }
		public EntryServerNodeStatus LiveEntryStatus { get; set; }

		public LiveStreamCreateRecordedEntryRequestBuilder()
			: base("livestream", "createRecordedEntry")
		{
		}

		public LiveStreamCreateRecordedEntryRequestBuilder(string entryId, EntryServerNodeType mediaServerIndex, EntryServerNodeStatus liveEntryStatus)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveEntry>(result);
		}
	}

	public class LiveStreamDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public LiveStreamDeleteRequestBuilder()
			: base("livestream", "delete")
		{
		}

		public LiveStreamDeleteRequestBuilder(string entryId)
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

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class LiveStreamGetRequestBuilder : RequestBuilder<LiveStreamEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string VERSION = "version";
		#endregion

		public string EntryId { get; set; }
		public int Version { get; set; }

		public LiveStreamGetRequestBuilder()
			: base("livestream", "get")
		{
		}

		public LiveStreamGetRequestBuilder(string entryId, int version)
			: this()
		{
			this.EntryId = entryId;
			this.Version = version;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("version"))
				kparams.AddIfNotNull("version", Version);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveStreamEntry>(result);
		}
	}

	public class LiveStreamGetDetailsRequestBuilder : RequestBuilder<LiveStreamDetails>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id { get; set; }

		public LiveStreamGetDetailsRequestBuilder()
			: base("livestream", "getDetails")
		{
		}

		public LiveStreamGetDetailsRequestBuilder(string id)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveStreamDetails>(result);
		}
	}

	public class LiveStreamIsLiveRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string ID = "id";
		public const string PROTOCOL = "protocol";
		#endregion

		public string Id { get; set; }
		public PlaybackProtocol Protocol { get; set; }

		public LiveStreamIsLiveRequestBuilder()
			: base("livestream", "isLive")
		{
		}

		public LiveStreamIsLiveRequestBuilder(string id, PlaybackProtocol protocol)
			: this()
		{
			this.Id = id;
			this.Protocol = protocol;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("protocol"))
				kparams.AddIfNotNull("protocol", Protocol);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			if (result.Value<string>().Equals("1") || result.Value<string>().ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class LiveStreamListRequestBuilder : RequestBuilder<ListResponse<LiveStreamEntry>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public LiveStreamEntryFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public LiveStreamListRequestBuilder()
			: base("livestream", "list")
		{
		}

		public LiveStreamListRequestBuilder(LiveStreamEntryFilter filter, FilterPager pager)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<LiveStreamEntry>>(result);
		}
	}

	public class LiveStreamRegenerateStreamTokenRequestBuilder : RequestBuilder<LiveEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public LiveStreamRegenerateStreamTokenRequestBuilder()
			: base("livestream", "regenerateStreamToken")
		{
		}

		public LiveStreamRegenerateStreamTokenRequestBuilder(string entryId)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveEntry>(result);
		}
	}

	public class LiveStreamRegisterMediaServerRequestBuilder : RequestBuilder<LiveEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string HOSTNAME = "hostname";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		public const string APPLICATION_NAME = "applicationName";
		public const string LIVE_ENTRY_STATUS = "liveEntryStatus";
		public const string SHOULD_CREATE_RECORDED_ENTRY = "shouldCreateRecordedEntry";
		#endregion

		public string EntryId { get; set; }
		public string Hostname { get; set; }
		public EntryServerNodeType MediaServerIndex { get; set; }
		public string ApplicationName { get; set; }
		public EntryServerNodeStatus LiveEntryStatus { get; set; }
		public bool ShouldCreateRecordedEntry { get; set; }

		public LiveStreamRegisterMediaServerRequestBuilder()
			: base("livestream", "registerMediaServer")
		{
		}

		public LiveStreamRegisterMediaServerRequestBuilder(string entryId, string hostname, EntryServerNodeType mediaServerIndex, string applicationName, EntryServerNodeStatus liveEntryStatus, bool shouldCreateRecordedEntry)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveEntry>(result);
		}
	}

	public class LiveStreamRemoveLiveStreamPushPublishConfigurationRequestBuilder : RequestBuilder<LiveStreamEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string PROTOCOL = "protocol";
		#endregion

		public string EntryId { get; set; }
		public PlaybackProtocol Protocol { get; set; }

		public LiveStreamRemoveLiveStreamPushPublishConfigurationRequestBuilder()
			: base("livestream", "removeLiveStreamPushPublishConfiguration")
		{
		}

		public LiveStreamRemoveLiveStreamPushPublishConfigurationRequestBuilder(string entryId, PlaybackProtocol protocol)
			: this()
		{
			this.EntryId = entryId;
			this.Protocol = protocol;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("protocol"))
				kparams.AddIfNotNull("protocol", Protocol);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveStreamEntry>(result);
		}
	}

	public class LiveStreamSetRecordedContentRequestBuilder : RequestBuilder<LiveEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		public const string RESOURCE = "resource";
		public const string DURATION = "duration";
		public const string RECORDED_ENTRY_ID = "recordedEntryId";
		public const string FLAVOR_PARAMS_ID = "flavorParamsId";
		#endregion

		public string EntryId { get; set; }
		public EntryServerNodeType MediaServerIndex { get; set; }
		public DataCenterContentResource Resource { get; set; }
		public float Duration { get; set; }
		public string RecordedEntryId { get; set; }
		public int FlavorParamsId { get; set; }

		public LiveStreamSetRecordedContentRequestBuilder()
			: base("livestream", "setRecordedContent")
		{
		}

		public LiveStreamSetRecordedContentRequestBuilder(string entryId, EntryServerNodeType mediaServerIndex, DataCenterContentResource resource, float duration, string recordedEntryId, int flavorParamsId)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveEntry>(result);
		}
	}

	public class LiveStreamUnregisterMediaServerRequestBuilder : RequestBuilder<LiveEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string HOSTNAME = "hostname";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		#endregion

		public string EntryId { get; set; }
		public string Hostname { get; set; }
		public EntryServerNodeType MediaServerIndex { get; set; }

		public LiveStreamUnregisterMediaServerRequestBuilder()
			: base("livestream", "unregisterMediaServer")
		{
		}

		public LiveStreamUnregisterMediaServerRequestBuilder(string entryId, string hostname, EntryServerNodeType mediaServerIndex)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveEntry>(result);
		}
	}

	public class LiveStreamUpdateRequestBuilder : RequestBuilder<LiveStreamEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string LIVE_STREAM_ENTRY = "liveStreamEntry";
		#endregion

		public string EntryId { get; set; }
		public LiveStreamEntry LiveStreamEntry { get; set; }

		public LiveStreamUpdateRequestBuilder()
			: base("livestream", "update")
		{
		}

		public LiveStreamUpdateRequestBuilder(string entryId, LiveStreamEntry liveStreamEntry)
			: this()
		{
			this.EntryId = entryId;
			this.LiveStreamEntry = liveStreamEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("liveStreamEntry"))
				kparams.AddIfNotNull("liveStreamEntry", LiveStreamEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveStreamEntry>(result);
		}
	}

	public class LiveStreamUpdateOfflineThumbnailFromUrlRequestBuilder : RequestBuilder<LiveStreamEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string URL = "url";
		#endregion

		public string EntryId { get; set; }
		public string Url { get; set; }

		public LiveStreamUpdateOfflineThumbnailFromUrlRequestBuilder()
			: base("livestream", "updateOfflineThumbnailFromUrl")
		{
		}

		public LiveStreamUpdateOfflineThumbnailFromUrlRequestBuilder(string entryId, string url)
			: this()
		{
			this.EntryId = entryId;
			this.Url = url;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("url"))
				kparams.AddIfNotNull("url", Url);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveStreamEntry>(result);
		}
	}

	public class LiveStreamUpdateOfflineThumbnailJpegRequestBuilder : RequestBuilder<LiveStreamEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string FILE_DATA = "fileData";
		#endregion

		public string EntryId { get; set; }
		public Stream FileData { get; set; }
		public string FileData_FileName { get; set; }

		public LiveStreamUpdateOfflineThumbnailJpegRequestBuilder()
			: base("livestream", "updateOfflineThumbnailJpeg")
		{
		}

		public LiveStreamUpdateOfflineThumbnailJpegRequestBuilder(string entryId, Stream fileData)
			: this()
		{
			this.EntryId = entryId;
			this.FileData = fileData;
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
			kfiles.Add("fileData", new FileData(FileData, FileData_FileName));
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<LiveStreamEntry>(result);
		}
	}

	public class LiveStreamValidateRegisteredMediaServersRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public LiveStreamValidateRegisteredMediaServersRequestBuilder()
			: base("livestream", "validateRegisteredMediaServers")
		{
		}

		public LiveStreamValidateRegisteredMediaServersRequestBuilder(string entryId)
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

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}


	public class LiveStreamService
	{
		private LiveStreamService()
		{
		}

		public static LiveStreamAddRequestBuilder Add(LiveStreamEntry liveStreamEntry, SourceType sourceType = null)
		{
			return new LiveStreamAddRequestBuilder(liveStreamEntry, sourceType);
		}

		public static LiveStreamAddLiveStreamPushPublishConfigurationRequestBuilder AddLiveStreamPushPublishConfiguration(string entryId, PlaybackProtocol protocol, string url = null, LiveStreamConfiguration liveStreamConfiguration = null)
		{
			return new LiveStreamAddLiveStreamPushPublishConfigurationRequestBuilder(entryId, protocol, url, liveStreamConfiguration);
		}

		public static LiveStreamAppendRecordingRequestBuilder AppendRecording(string entryId, string assetId, EntryServerNodeType mediaServerIndex, DataCenterContentResource resource, float duration, bool isLastChunk = false)
		{
			return new LiveStreamAppendRecordingRequestBuilder(entryId, assetId, mediaServerIndex, resource, duration, isLastChunk);
		}

		public static LiveStreamArchiveRequestBuilder Archive(string liveEntryId, string vodEntryId)
		{
			return new LiveStreamArchiveRequestBuilder(liveEntryId, vodEntryId);
		}

		public static LiveStreamAuthenticateRequestBuilder Authenticate(string entryId, string token, string hostname = null, EntryServerNodeType mediaServerIndex = null, string applicationName = null)
		{
			return new LiveStreamAuthenticateRequestBuilder(entryId, token, hostname, mediaServerIndex, applicationName);
		}

		public static LiveStreamCreatePeriodicSyncPointsRequestBuilder CreatePeriodicSyncPoints(string entryId, int interval, int duration)
		{
			return new LiveStreamCreatePeriodicSyncPointsRequestBuilder(entryId, interval, duration);
		}

		public static LiveStreamCreateRecordedEntryRequestBuilder CreateRecordedEntry(string entryId, EntryServerNodeType mediaServerIndex, EntryServerNodeStatus liveEntryStatus)
		{
			return new LiveStreamCreateRecordedEntryRequestBuilder(entryId, mediaServerIndex, liveEntryStatus);
		}

		public static LiveStreamDeleteRequestBuilder Delete(string entryId)
		{
			return new LiveStreamDeleteRequestBuilder(entryId);
		}

		public static LiveStreamGetRequestBuilder Get(string entryId, int version = -1)
		{
			return new LiveStreamGetRequestBuilder(entryId, version);
		}

		public static LiveStreamGetDetailsRequestBuilder GetDetails(string id)
		{
			return new LiveStreamGetDetailsRequestBuilder(id);
		}

		public static LiveStreamIsLiveRequestBuilder IsLive(string id, PlaybackProtocol protocol)
		{
			return new LiveStreamIsLiveRequestBuilder(id, protocol);
		}

		public static LiveStreamListRequestBuilder List(LiveStreamEntryFilter filter = null, FilterPager pager = null)
		{
			return new LiveStreamListRequestBuilder(filter, pager);
		}

		public static LiveStreamRegenerateStreamTokenRequestBuilder RegenerateStreamToken(string entryId)
		{
			return new LiveStreamRegenerateStreamTokenRequestBuilder(entryId);
		}

		public static LiveStreamRegisterMediaServerRequestBuilder RegisterMediaServer(string entryId, string hostname, EntryServerNodeType mediaServerIndex, string applicationName = null, EntryServerNodeStatus liveEntryStatus = (EntryServerNodeStatus)(1), bool shouldCreateRecordedEntry = true)
		{
			return new LiveStreamRegisterMediaServerRequestBuilder(entryId, hostname, mediaServerIndex, applicationName, liveEntryStatus, shouldCreateRecordedEntry);
		}

		public static LiveStreamRemoveLiveStreamPushPublishConfigurationRequestBuilder RemoveLiveStreamPushPublishConfiguration(string entryId, PlaybackProtocol protocol)
		{
			return new LiveStreamRemoveLiveStreamPushPublishConfigurationRequestBuilder(entryId, protocol);
		}

		public static LiveStreamSetRecordedContentRequestBuilder SetRecordedContent(string entryId, EntryServerNodeType mediaServerIndex, DataCenterContentResource resource, float duration, string recordedEntryId = null, int flavorParamsId = Int32.MinValue)
		{
			return new LiveStreamSetRecordedContentRequestBuilder(entryId, mediaServerIndex, resource, duration, recordedEntryId, flavorParamsId);
		}

		public static LiveStreamUnregisterMediaServerRequestBuilder UnregisterMediaServer(string entryId, string hostname, EntryServerNodeType mediaServerIndex)
		{
			return new LiveStreamUnregisterMediaServerRequestBuilder(entryId, hostname, mediaServerIndex);
		}

		public static LiveStreamUpdateRequestBuilder Update(string entryId, LiveStreamEntry liveStreamEntry)
		{
			return new LiveStreamUpdateRequestBuilder(entryId, liveStreamEntry);
		}

		public static LiveStreamUpdateOfflineThumbnailFromUrlRequestBuilder UpdateOfflineThumbnailFromUrl(string entryId, string url)
		{
			return new LiveStreamUpdateOfflineThumbnailFromUrlRequestBuilder(entryId, url);
		}

		public static LiveStreamUpdateOfflineThumbnailJpegRequestBuilder UpdateOfflineThumbnailJpeg(string entryId, Stream fileData)
		{
			return new LiveStreamUpdateOfflineThumbnailJpegRequestBuilder(entryId, fileData);
		}

		public static LiveStreamValidateRegisteredMediaServersRequestBuilder ValidateRegisteredMediaServers(string entryId)
		{
			return new LiveStreamValidateRegisteredMediaServersRequestBuilder(entryId);
		}
	}
}
