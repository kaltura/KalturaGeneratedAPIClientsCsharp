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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class BaseEntryAddRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY = "entry";
		public const string TYPE = "type";
		#endregion

		public BaseEntry Entry { get; set; }
		public EntryType Type { get; set; }

		public BaseEntryAddRequestBuilder()
			: base("baseentry", "add")
		{
		}

		public BaseEntryAddRequestBuilder(BaseEntry entry, EntryType type)
			: this()
		{
			this.Entry = entry;
			this.Type = type;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entry"))
				kparams.AddIfNotNull("entry", Entry);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryAddContentRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string RESOURCE = "resource";
		#endregion

		public string EntryId { get; set; }
		public Resource Resource { get; set; }

		public BaseEntryAddContentRequestBuilder()
			: base("baseentry", "addContent")
		{
		}

		public BaseEntryAddContentRequestBuilder(string entryId, Resource resource)
			: this()
		{
			this.EntryId = entryId;
			this.Resource = resource;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("resource"))
				kparams.AddIfNotNull("resource", Resource);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryAddFromUploadedFileRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY = "entry";
		public const string UPLOAD_TOKEN_ID = "uploadTokenId";
		public const string TYPE = "type";
		#endregion

		public BaseEntry Entry { get; set; }
		public string UploadTokenId { get; set; }
		public EntryType Type { get; set; }

		public BaseEntryAddFromUploadedFileRequestBuilder()
			: base("baseentry", "addFromUploadedFile")
		{
		}

		public BaseEntryAddFromUploadedFileRequestBuilder(BaseEntry entry, string uploadTokenId, EntryType type)
			: this()
		{
			this.Entry = entry;
			this.UploadTokenId = uploadTokenId;
			this.Type = type;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entry"))
				kparams.AddIfNotNull("entry", Entry);
			if (!isMapped("uploadTokenId"))
				kparams.AddIfNotNull("uploadTokenId", UploadTokenId);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryAnonymousRankRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string RANK = "rank";
		#endregion

		public string EntryId { get; set; }
		public int Rank { get; set; }

		public BaseEntryAnonymousRankRequestBuilder()
			: base("baseentry", "anonymousRank")
		{
		}

		public BaseEntryAnonymousRankRequestBuilder(string entryId, int rank)
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

	public class BaseEntryApproveRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public BaseEntryApproveRequestBuilder()
			: base("baseentry", "approve")
		{
		}

		public BaseEntryApproveRequestBuilder(string entryId)
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

	public class BaseEntryCloneRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CLONE_OPTIONS = "cloneOptions";
		#endregion

		public string EntryId { get; set; }
		public IList<BaseEntryCloneOptionItem> CloneOptions { get; set; }

		public BaseEntryCloneRequestBuilder()
			: base("baseentry", "clone")
		{
		}

		public BaseEntryCloneRequestBuilder(string entryId, IList<BaseEntryCloneOptionItem> cloneOptions)
			: this()
		{
			this.EntryId = entryId;
			this.CloneOptions = cloneOptions;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("cloneOptions"))
				kparams.AddIfNotNull("cloneOptions", CloneOptions);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryCountRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public BaseEntryFilter Filter { get; set; }

		public BaseEntryCountRequestBuilder()
			: base("baseentry", "count")
		{
		}

		public BaseEntryCountRequestBuilder(BaseEntryFilter filter)
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

	public class BaseEntryDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public BaseEntryDeleteRequestBuilder()
			: base("baseentry", "delete")
		{
		}

		public BaseEntryDeleteRequestBuilder(string entryId)
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

	public class BaseEntryExportRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string STORAGE_PROFILE_ID = "storageProfileId";
		#endregion

		public string EntryId { get; set; }
		public int StorageProfileId { get; set; }

		public BaseEntryExportRequestBuilder()
			: base("baseentry", "export")
		{
		}

		public BaseEntryExportRequestBuilder(string entryId, int storageProfileId)
			: this()
		{
			this.EntryId = entryId;
			this.StorageProfileId = storageProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("storageProfileId"))
				kparams.AddIfNotNull("storageProfileId", StorageProfileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryExportToCsvRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string ADDITIONAL_FIELDS = "additionalFields";
		public const string MAPPED_FIELDS = "mappedFields";
		#endregion

		public BaseEntryFilter Filter { get; set; }
		public int MetadataProfileId { get; set; }
		public IList<CsvAdditionalFieldInfo> AdditionalFields { get; set; }
		public IList<KeyValue> MappedFields { get; set; }

		public BaseEntryExportToCsvRequestBuilder()
			: base("baseentry", "exportToCsv")
		{
		}

		public BaseEntryExportToCsvRequestBuilder(BaseEntryFilter filter, int metadataProfileId, IList<CsvAdditionalFieldInfo> additionalFields, IList<KeyValue> mappedFields)
			: this()
		{
			this.Filter = filter;
			this.MetadataProfileId = metadataProfileId;
			this.AdditionalFields = additionalFields;
			this.MappedFields = mappedFields;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("metadataProfileId"))
				kparams.AddIfNotNull("metadataProfileId", MetadataProfileId);
			if (!isMapped("additionalFields"))
				kparams.AddIfNotNull("additionalFields", AdditionalFields);
			if (!isMapped("mappedFields"))
				kparams.AddIfNotNull("mappedFields", MappedFields);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class BaseEntryFlagRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string MODERATION_FLAG = "moderationFlag";
		#endregion

		public ModerationFlag ModerationFlag { get; set; }

		public BaseEntryFlagRequestBuilder()
			: base("baseentry", "flag")
		{
		}

		public BaseEntryFlagRequestBuilder(ModerationFlag moderationFlag)
			: this()
		{
			this.ModerationFlag = moderationFlag;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("moderationFlag"))
				kparams.AddIfNotNull("moderationFlag", ModerationFlag);
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

	public class BaseEntryGetRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string VERSION = "version";
		#endregion

		public string EntryId { get; set; }
		public int Version { get; set; }

		public BaseEntryGetRequestBuilder()
			: base("baseentry", "get")
		{
		}

		public BaseEntryGetRequestBuilder(string entryId, int version)
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
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryGetByIdsRequestBuilder : RequestBuilder<IList<BaseEntry>>
	{
		#region Constants
		public const string ENTRY_IDS = "entryIds";
		#endregion

		public string EntryIds { get; set; }

		public BaseEntryGetByIdsRequestBuilder()
			: base("baseentry", "getByIds")
		{
		}

		public BaseEntryGetByIdsRequestBuilder(string entryIds)
			: this()
		{
			this.EntryIds = entryIds;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryIds"))
				kparams.AddIfNotNull("entryIds", EntryIds);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			IList<BaseEntry> list = new List<BaseEntry>();
			foreach(var node in result.Children())
			{
				//TODO: Deserilize Array;
				list.Add(ObjectFactory.Create<BaseEntry>(node));
			}
			return list;
		}
	}

	public class BaseEntryGetContextDataRequestBuilder : RequestBuilder<EntryContextDataResult>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CONTEXT_DATA_PARAMS = "contextDataParams";
		#endregion

		public string EntryId { get; set; }
		public EntryContextDataParams ContextDataParams { get; set; }

		public BaseEntryGetContextDataRequestBuilder()
			: base("baseentry", "getContextData")
		{
		}

		public BaseEntryGetContextDataRequestBuilder(string entryId, EntryContextDataParams contextDataParams)
			: this()
		{
			this.EntryId = entryId;
			this.ContextDataParams = contextDataParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("contextDataParams"))
				kparams.AddIfNotNull("contextDataParams", ContextDataParams);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<EntryContextDataResult>(result);
		}
	}

	public class BaseEntryGetPlaybackContextRequestBuilder : RequestBuilder<PlaybackContext>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CONTEXT_DATA_PARAMS = "contextDataParams";
		#endregion

		public string EntryId { get; set; }
		public PlaybackContextOptions ContextDataParams { get; set; }

		public BaseEntryGetPlaybackContextRequestBuilder()
			: base("baseentry", "getPlaybackContext")
		{
		}

		public BaseEntryGetPlaybackContextRequestBuilder(string entryId, PlaybackContextOptions contextDataParams)
			: this()
		{
			this.EntryId = entryId;
			this.ContextDataParams = contextDataParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("contextDataParams"))
				kparams.AddIfNotNull("contextDataParams", ContextDataParams);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PlaybackContext>(result);
		}
	}

	public class BaseEntryGetRemotePathsRequestBuilder : RequestBuilder<ListResponse<RemotePath>>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public BaseEntryGetRemotePathsRequestBuilder()
			: base("baseentry", "getRemotePaths")
		{
		}

		public BaseEntryGetRemotePathsRequestBuilder(string entryId)
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
			return ObjectFactory.Create<ListResponse<RemotePath>>(result);
		}
	}

	public class BaseEntryIndexRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string ID = "id";
		public const string SHOULD_UPDATE = "shouldUpdate";
		#endregion

		public string Id { get; set; }
		public bool ShouldUpdate { get; set; }

		public BaseEntryIndexRequestBuilder()
			: base("baseentry", "index")
		{
		}

		public BaseEntryIndexRequestBuilder(string id, bool shouldUpdate)
			: this()
		{
			this.Id = id;
			this.ShouldUpdate = shouldUpdate;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("shouldUpdate"))
				kparams.AddIfNotNull("shouldUpdate", ShouldUpdate);
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

	public class BaseEntryListRequestBuilder : RequestBuilder<ListResponse<BaseEntry>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public BaseEntryFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public BaseEntryListRequestBuilder()
			: base("baseentry", "list")
		{
		}

		public BaseEntryListRequestBuilder(BaseEntryFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<BaseEntry>>(result);
		}
	}

	public class BaseEntryListByReferenceIdRequestBuilder : RequestBuilder<ListResponse<BaseEntry>>
	{
		#region Constants
		public const string REF_ID = "refId";
		public const string PAGER = "pager";
		#endregion

		public string RefId { get; set; }
		public FilterPager Pager { get; set; }

		public BaseEntryListByReferenceIdRequestBuilder()
			: base("baseentry", "listByReferenceId")
		{
		}

		public BaseEntryListByReferenceIdRequestBuilder(string refId, FilterPager pager)
			: this()
		{
			this.RefId = refId;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("refId"))
				kparams.AddIfNotNull("refId", RefId);
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
			return ObjectFactory.Create<ListResponse<BaseEntry>>(result);
		}
	}

	public class BaseEntryListFlagsRequestBuilder : RequestBuilder<ListResponse<ModerationFlag>>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string PAGER = "pager";
		#endregion

		public string EntryId { get; set; }
		public FilterPager Pager { get; set; }

		public BaseEntryListFlagsRequestBuilder()
			: base("baseentry", "listFlags")
		{
		}

		public BaseEntryListFlagsRequestBuilder(string entryId, FilterPager pager)
			: this()
		{
			this.EntryId = entryId;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
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
			return ObjectFactory.Create<ListResponse<ModerationFlag>>(result);
		}
	}

	public class BaseEntryRejectRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public BaseEntryRejectRequestBuilder()
			: base("baseentry", "reject")
		{
		}

		public BaseEntryRejectRequestBuilder(string entryId)
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

	public class BaseEntryUpdateRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string BASE_ENTRY = "baseEntry";
		#endregion

		public string EntryId { get; set; }
		public BaseEntry BaseEntry { get; set; }

		public BaseEntryUpdateRequestBuilder()
			: base("baseentry", "update")
		{
		}

		public BaseEntryUpdateRequestBuilder(string entryId, BaseEntry baseEntry)
			: this()
		{
			this.EntryId = entryId;
			this.BaseEntry = baseEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("baseEntry"))
				kparams.AddIfNotNull("baseEntry", BaseEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryUpdateContentRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string RESOURCE = "resource";
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string ADVANCED_OPTIONS = "advancedOptions";
		#endregion

		public string EntryId { get; set; }
		public Resource Resource { get; set; }
		public int ConversionProfileId { get; set; }
		public EntryReplacementOptions AdvancedOptions { get; set; }

		public BaseEntryUpdateContentRequestBuilder()
			: base("baseentry", "updateContent")
		{
		}

		public BaseEntryUpdateContentRequestBuilder(string entryId, Resource resource, int conversionProfileId, EntryReplacementOptions advancedOptions)
			: this()
		{
			this.EntryId = entryId;
			this.Resource = resource;
			this.ConversionProfileId = conversionProfileId;
			this.AdvancedOptions = advancedOptions;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("resource"))
				kparams.AddIfNotNull("resource", Resource);
			if (!isMapped("conversionProfileId"))
				kparams.AddIfNotNull("conversionProfileId", ConversionProfileId);
			if (!isMapped("advancedOptions"))
				kparams.AddIfNotNull("advancedOptions", AdvancedOptions);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryUpdateThumbnailFromSourceEntryRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string SOURCE_ENTRY_ID = "sourceEntryId";
		public const string TIME_OFFSET = "timeOffset";
		#endregion

		public string EntryId { get; set; }
		public string SourceEntryId { get; set; }
		public int TimeOffset { get; set; }

		public BaseEntryUpdateThumbnailFromSourceEntryRequestBuilder()
			: base("baseentry", "updateThumbnailFromSourceEntry")
		{
		}

		public BaseEntryUpdateThumbnailFromSourceEntryRequestBuilder(string entryId, string sourceEntryId, int timeOffset)
			: this()
		{
			this.EntryId = entryId;
			this.SourceEntryId = sourceEntryId;
			this.TimeOffset = timeOffset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("sourceEntryId"))
				kparams.AddIfNotNull("sourceEntryId", SourceEntryId);
			if (!isMapped("timeOffset"))
				kparams.AddIfNotNull("timeOffset", TimeOffset);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryUpdateThumbnailFromUrlRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string URL = "url";
		#endregion

		public string EntryId { get; set; }
		public string Url { get; set; }

		public BaseEntryUpdateThumbnailFromUrlRequestBuilder()
			: base("baseentry", "updateThumbnailFromUrl")
		{
		}

		public BaseEntryUpdateThumbnailFromUrlRequestBuilder(string entryId, string url)
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
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryUpdateThumbnailJpegRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string FILE_DATA = "fileData";
		#endregion

		public string EntryId { get; set; }
		public Stream FileData { get; set; }
		public string FileData_FileName { get; set; }

		public BaseEntryUpdateThumbnailJpegRequestBuilder()
			: base("baseentry", "updateThumbnailJpeg")
		{
		}

		public BaseEntryUpdateThumbnailJpegRequestBuilder(string entryId, Stream fileData)
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
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryUploadRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		#endregion

		public Stream FileData { get; set; }
		public string FileData_FileName { get; set; }

		public BaseEntryUploadRequestBuilder()
			: base("baseentry", "upload")
		{
		}

		public BaseEntryUploadRequestBuilder(Stream fileData)
			: this()
		{
			this.FileData = fileData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
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
			return result.Value<string>();
		}
	}


	public class BaseEntryService
	{
		private BaseEntryService()
		{
		}

		public static BaseEntryAddRequestBuilder Add(BaseEntry entry, EntryType type = null)
		{
			return new BaseEntryAddRequestBuilder(entry, type);
		}

		public static BaseEntryAddContentRequestBuilder AddContent(string entryId, Resource resource)
		{
			return new BaseEntryAddContentRequestBuilder(entryId, resource);
		}

		public static BaseEntryAddFromUploadedFileRequestBuilder AddFromUploadedFile(BaseEntry entry, string uploadTokenId, EntryType type = null)
		{
			return new BaseEntryAddFromUploadedFileRequestBuilder(entry, uploadTokenId, type);
		}

		public static BaseEntryAnonymousRankRequestBuilder AnonymousRank(string entryId, int rank)
		{
			return new BaseEntryAnonymousRankRequestBuilder(entryId, rank);
		}

		public static BaseEntryApproveRequestBuilder Approve(string entryId)
		{
			return new BaseEntryApproveRequestBuilder(entryId);
		}

		public static BaseEntryCloneRequestBuilder Clone(string entryId, IList<BaseEntryCloneOptionItem> cloneOptions = null)
		{
			return new BaseEntryCloneRequestBuilder(entryId, cloneOptions);
		}

		public static BaseEntryCountRequestBuilder Count(BaseEntryFilter filter = null)
		{
			return new BaseEntryCountRequestBuilder(filter);
		}

		public static BaseEntryDeleteRequestBuilder Delete(string entryId)
		{
			return new BaseEntryDeleteRequestBuilder(entryId);
		}

		public static BaseEntryExportRequestBuilder Export(string entryId, int storageProfileId)
		{
			return new BaseEntryExportRequestBuilder(entryId, storageProfileId);
		}

		public static BaseEntryExportToCsvRequestBuilder ExportToCsv(BaseEntryFilter filter = null, int metadataProfileId = Int32.MinValue, IList<CsvAdditionalFieldInfo> additionalFields = null, IList<KeyValue> mappedFields = null)
		{
			return new BaseEntryExportToCsvRequestBuilder(filter, metadataProfileId, additionalFields, mappedFields);
		}

		public static BaseEntryFlagRequestBuilder Flag(ModerationFlag moderationFlag)
		{
			return new BaseEntryFlagRequestBuilder(moderationFlag);
		}

		public static BaseEntryGetRequestBuilder Get(string entryId, int version = -1)
		{
			return new BaseEntryGetRequestBuilder(entryId, version);
		}

		public static BaseEntryGetByIdsRequestBuilder GetByIds(string entryIds)
		{
			return new BaseEntryGetByIdsRequestBuilder(entryIds);
		}

		public static BaseEntryGetContextDataRequestBuilder GetContextData(string entryId, EntryContextDataParams contextDataParams)
		{
			return new BaseEntryGetContextDataRequestBuilder(entryId, contextDataParams);
		}

		public static BaseEntryGetPlaybackContextRequestBuilder GetPlaybackContext(string entryId, PlaybackContextOptions contextDataParams)
		{
			return new BaseEntryGetPlaybackContextRequestBuilder(entryId, contextDataParams);
		}

		public static BaseEntryGetRemotePathsRequestBuilder GetRemotePaths(string entryId)
		{
			return new BaseEntryGetRemotePathsRequestBuilder(entryId);
		}

		public static BaseEntryIndexRequestBuilder Index(string id, bool shouldUpdate = true)
		{
			return new BaseEntryIndexRequestBuilder(id, shouldUpdate);
		}

		public static BaseEntryListRequestBuilder List(BaseEntryFilter filter = null, FilterPager pager = null)
		{
			return new BaseEntryListRequestBuilder(filter, pager);
		}

		public static BaseEntryListByReferenceIdRequestBuilder ListByReferenceId(string refId, FilterPager pager = null)
		{
			return new BaseEntryListByReferenceIdRequestBuilder(refId, pager);
		}

		public static BaseEntryListFlagsRequestBuilder ListFlags(string entryId, FilterPager pager = null)
		{
			return new BaseEntryListFlagsRequestBuilder(entryId, pager);
		}

		public static BaseEntryRejectRequestBuilder Reject(string entryId)
		{
			return new BaseEntryRejectRequestBuilder(entryId);
		}

		public static BaseEntryUpdateRequestBuilder Update(string entryId, BaseEntry baseEntry)
		{
			return new BaseEntryUpdateRequestBuilder(entryId, baseEntry);
		}

		public static BaseEntryUpdateContentRequestBuilder UpdateContent(string entryId, Resource resource, int conversionProfileId = Int32.MinValue, EntryReplacementOptions advancedOptions = null)
		{
			return new BaseEntryUpdateContentRequestBuilder(entryId, resource, conversionProfileId, advancedOptions);
		}

		public static BaseEntryUpdateThumbnailFromSourceEntryRequestBuilder UpdateThumbnailFromSourceEntry(string entryId, string sourceEntryId, int timeOffset)
		{
			return new BaseEntryUpdateThumbnailFromSourceEntryRequestBuilder(entryId, sourceEntryId, timeOffset);
		}

		public static BaseEntryUpdateThumbnailFromUrlRequestBuilder UpdateThumbnailFromUrl(string entryId, string url)
		{
			return new BaseEntryUpdateThumbnailFromUrlRequestBuilder(entryId, url);
		}

		public static BaseEntryUpdateThumbnailJpegRequestBuilder UpdateThumbnailJpeg(string entryId, Stream fileData)
		{
			return new BaseEntryUpdateThumbnailJpegRequestBuilder(entryId, fileData);
		}

		public static BaseEntryUploadRequestBuilder Upload(Stream fileData)
		{
			return new BaseEntryUploadRequestBuilder(fileData);
		}
	}
}
