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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class MixingAddRequestBuilder : RequestBuilder<MixEntry>
	{
		#region Constants
		public const string MIX_ENTRY = "mixEntry";
		#endregion

		public MixEntry MixEntry { get; set; }

		public MixingAddRequestBuilder()
			: base("mixing", "add")
		{
		}

		public MixingAddRequestBuilder(MixEntry mixEntry)
			: this()
		{
			this.MixEntry = mixEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("mixEntry"))
				kparams.AddIfNotNull("mixEntry", MixEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<MixEntry>(result);
		}
	}

	public class MixingAnonymousRankRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string RANK = "rank";
		#endregion

		public string EntryId { get; set; }
		public int Rank { get; set; }

		public MixingAnonymousRankRequestBuilder()
			: base("mixing", "anonymousRank")
		{
		}

		public MixingAnonymousRankRequestBuilder(string entryId, int rank)
			: this()
		{
			this.EntryId = entryId;
			this.Rank = rank;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("rank"))
				kparams.AddIfNotNull("rank", Rank);
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

	public class MixingAppendMediaEntryRequestBuilder : RequestBuilder<MixEntry>
	{
		#region Constants
		public const string MIX_ENTRY_ID = "mixEntryId";
		public const string MEDIA_ENTRY_ID = "mediaEntryId";
		#endregion

		public string MixEntryId { get; set; }
		public string MediaEntryId { get; set; }

		public MixingAppendMediaEntryRequestBuilder()
			: base("mixing", "appendMediaEntry")
		{
		}

		public MixingAppendMediaEntryRequestBuilder(string mixEntryId, string mediaEntryId)
			: this()
		{
			this.MixEntryId = mixEntryId;
			this.MediaEntryId = mediaEntryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("mixEntryId"))
				kparams.AddIfNotNull("mixEntryId", MixEntryId);
			if (!isMapped("mediaEntryId"))
				kparams.AddIfNotNull("mediaEntryId", MediaEntryId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<MixEntry>(result);
		}
	}

	public class MixingCloneRequestBuilder : RequestBuilder<MixEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public MixingCloneRequestBuilder()
			: base("mixing", "clone")
		{
		}

		public MixingCloneRequestBuilder(string entryId)
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
			return ObjectFactory.Create<MixEntry>(result);
		}
	}

	public class MixingCountRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public MediaEntryFilter Filter { get; set; }

		public MixingCountRequestBuilder()
			: base("mixing", "count")
		{
		}

		public MixingCountRequestBuilder(MediaEntryFilter filter)
			: this()
		{
			this.Filter = filter;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<int>();
		}
	}

	public class MixingDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public MixingDeleteRequestBuilder()
			: base("mixing", "delete")
		{
		}

		public MixingDeleteRequestBuilder(string entryId)
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

	public class MixingGetRequestBuilder : RequestBuilder<MixEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string VERSION = "version";
		#endregion

		public string EntryId { get; set; }
		public int Version { get; set; }

		public MixingGetRequestBuilder()
			: base("mixing", "get")
		{
		}

		public MixingGetRequestBuilder(string entryId, int version)
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
			return ObjectFactory.Create<MixEntry>(result);
		}
	}

	public class MixingGetMixesByMediaIdRequestBuilder : RequestBuilder<IList<MixEntry>>
	{
		#region Constants
		public const string MEDIA_ENTRY_ID = "mediaEntryId";
		#endregion

		public string MediaEntryId { get; set; }

		public MixingGetMixesByMediaIdRequestBuilder()
			: base("mixing", "getMixesByMediaId")
		{
		}

		public MixingGetMixesByMediaIdRequestBuilder(string mediaEntryId)
			: this()
		{
			this.MediaEntryId = mediaEntryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("mediaEntryId"))
				kparams.AddIfNotNull("mediaEntryId", MediaEntryId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			IList<MixEntry> list = new List<MixEntry>();
			foreach(var node in result.Children())
			{
				//TODO: Deserilize Array;
				list.Add(ObjectFactory.Create<MixEntry>(node));
			}
			return list;
		}
	}

	public class MixingGetReadyMediaEntriesRequestBuilder : RequestBuilder<IList<MediaEntry>>
	{
		#region Constants
		public const string MIX_ID = "mixId";
		public const string VERSION = "version";
		#endregion

		public string MixId { get; set; }
		public int Version { get; set; }

		public MixingGetReadyMediaEntriesRequestBuilder()
			: base("mixing", "getReadyMediaEntries")
		{
		}

		public MixingGetReadyMediaEntriesRequestBuilder(string mixId, int version)
			: this()
		{
			this.MixId = mixId;
			this.Version = version;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("mixId"))
				kparams.AddIfNotNull("mixId", MixId);
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
			IList<MediaEntry> list = new List<MediaEntry>();
			foreach(var node in result.Children())
			{
				//TODO: Deserilize Array;
				list.Add(ObjectFactory.Create<MediaEntry>(node));
			}
			return list;
		}
	}

	public class MixingListRequestBuilder : RequestBuilder<ListResponse<MixEntry>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public MixEntryFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public MixingListRequestBuilder()
			: base("mixing", "list")
		{
		}

		public MixingListRequestBuilder(MixEntryFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<MixEntry>>(result);
		}
	}

	public class MixingUpdateRequestBuilder : RequestBuilder<MixEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string MIX_ENTRY = "mixEntry";
		#endregion

		public string EntryId { get; set; }
		public MixEntry MixEntry { get; set; }

		public MixingUpdateRequestBuilder()
			: base("mixing", "update")
		{
		}

		public MixingUpdateRequestBuilder(string entryId, MixEntry mixEntry)
			: this()
		{
			this.EntryId = entryId;
			this.MixEntry = mixEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("mixEntry"))
				kparams.AddIfNotNull("mixEntry", MixEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<MixEntry>(result);
		}
	}


	public class MixingService
	{
		private MixingService()
		{
		}

		public static MixingAddRequestBuilder Add(MixEntry mixEntry)
		{
			return new MixingAddRequestBuilder(mixEntry);
		}

		public static MixingAnonymousRankRequestBuilder AnonymousRank(string entryId, int rank)
		{
			return new MixingAnonymousRankRequestBuilder(entryId, rank);
		}

		public static MixingAppendMediaEntryRequestBuilder AppendMediaEntry(string mixEntryId, string mediaEntryId)
		{
			return new MixingAppendMediaEntryRequestBuilder(mixEntryId, mediaEntryId);
		}

		public static MixingCloneRequestBuilder Clone(string entryId)
		{
			return new MixingCloneRequestBuilder(entryId);
		}

		public static MixingCountRequestBuilder Count(MediaEntryFilter filter = null)
		{
			return new MixingCountRequestBuilder(filter);
		}

		public static MixingDeleteRequestBuilder Delete(string entryId)
		{
			return new MixingDeleteRequestBuilder(entryId);
		}

		public static MixingGetRequestBuilder Get(string entryId, int version = -1)
		{
			return new MixingGetRequestBuilder(entryId, version);
		}

		public static MixingGetMixesByMediaIdRequestBuilder GetMixesByMediaId(string mediaEntryId)
		{
			return new MixingGetMixesByMediaIdRequestBuilder(mediaEntryId);
		}

		public static MixingGetReadyMediaEntriesRequestBuilder GetReadyMediaEntries(string mixId, int version = -1)
		{
			return new MixingGetReadyMediaEntriesRequestBuilder(mixId, version);
		}

		public static MixingListRequestBuilder List(MixEntryFilter filter = null, FilterPager pager = null)
		{
			return new MixingListRequestBuilder(filter, pager);
		}

		public static MixingUpdateRequestBuilder Update(string entryId, MixEntry mixEntry)
		{
			return new MixingUpdateRequestBuilder(entryId, mixEntry);
		}
	}
}
