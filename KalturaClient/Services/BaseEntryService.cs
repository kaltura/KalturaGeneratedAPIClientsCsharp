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
	public class BaseEntryAddRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY = "entry";
		public const string TYPE = "type";
		#endregion

		public BaseEntry Entry
		{
			set;
			get;
		}
		public EntryType Type
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
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

		public string EntryId
		{
			set;
			get;
		}
		public Resource Resource
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
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

		public BaseEntry Entry
		{
			set;
			get;
		}
		public string UploadTokenId
		{
			set;
			get;
		}
		public EntryType Type
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryGetRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string VERSION = "version";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int Version
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryGetRemotePathsRequestBuilder : RequestBuilder<ListResponse<RemotePath>>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<RemotePath>>(result);
		}
	}

	public class BaseEntryUpdateRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string BASE_ENTRY = "baseEntry";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public BaseEntry BaseEntry
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
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

		public string EntryId
		{
			set;
			get;
		}
		public Resource Resource
		{
			set;
			get;
		}
		public int ConversionProfileId
		{
			set;
			get;
		}
		public EntryReplacementOptions AdvancedOptions
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryGetByIdsRequestBuilder : RequestBuilder<IList<BaseEntry>>
	{
		#region Constants
		public const string ENTRY_IDS = "entryIds";
		#endregion

		public string EntryIds
		{
			set;
			get;
		}

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

	public class BaseEntryDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class BaseEntryListRequestBuilder : RequestBuilder<ListResponse<BaseEntry>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public BaseEntryFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
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

		public string RefId
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<BaseEntry>>(result);
		}
	}

	public class BaseEntryCountRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public BaseEntryFilter Filter
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return int.Parse(result.InnerText);
		}
	}

	public class BaseEntryUploadRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		#endregion

		public Stream FileData
		{
			set;
			get;
		}

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
			kfiles.Add("fileData", FileData);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return result.InnerText;
		}
	}

	public class BaseEntryUpdateThumbnailJpegRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string FILE_DATA = "fileData";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public Stream FileData
		{
			set;
			get;
		}

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
			kfiles.Add("fileData", FileData);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
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

		public string EntryId
		{
			set;
			get;
		}
		public string Url
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
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

		public string EntryId
		{
			set;
			get;
		}
		public string SourceEntryId
		{
			set;
			get;
		}
		public int TimeOffset
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryFlagRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string MODERATION_FLAG = "moderationFlag";
		#endregion

		public ModerationFlag ModerationFlag
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class BaseEntryRejectRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class BaseEntryApproveRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class BaseEntryListFlagsRequestBuilder : RequestBuilder<ListResponse<ModerationFlag>>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string PAGER = "pager";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<ModerationFlag>>(result);
		}
	}

	public class BaseEntryAnonymousRankRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string RANK = "rank";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int Rank
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class BaseEntryGetContextDataRequestBuilder : RequestBuilder<EntryContextDataResult>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CONTEXT_DATA_PARAMS = "contextDataParams";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public EntryContextDataParams ContextDataParams
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<EntryContextDataResult>(result);
		}
	}

	public class BaseEntryExportRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string STORAGE_PROFILE_ID = "storageProfileId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int StorageProfileId
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryIndexRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string ID = "id";
		public const string SHOULD_UPDATE = "shouldUpdate";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public bool ShouldUpdate
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return int.Parse(result.InnerText);
		}
	}

	public class BaseEntryCloneRequestBuilder : RequestBuilder<BaseEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CLONE_OPTIONS = "cloneOptions";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public IList<BaseEntryCloneOptionItem> CloneOptions
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<BaseEntry>(result);
		}
	}

	public class BaseEntryGetPlaybackContextRequestBuilder : RequestBuilder<PlaybackContext>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CONTEXT_DATA_PARAMS = "contextDataParams";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public PlaybackContextOptions ContextDataParams
		{
			set;
			get;
		}

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

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<PlaybackContext>(result);
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

		public static BaseEntryGetRequestBuilder Get(string entryId, int version = -1)
		{
			return new BaseEntryGetRequestBuilder(entryId, version);
		}

		public static BaseEntryGetRemotePathsRequestBuilder GetRemotePaths(string entryId)
		{
			return new BaseEntryGetRemotePathsRequestBuilder(entryId);
		}

		public static BaseEntryUpdateRequestBuilder Update(string entryId, BaseEntry baseEntry)
		{
			return new BaseEntryUpdateRequestBuilder(entryId, baseEntry);
		}

		public static BaseEntryUpdateContentRequestBuilder UpdateContent(string entryId, Resource resource, int conversionProfileId = Int32.MinValue, EntryReplacementOptions advancedOptions = null)
		{
			return new BaseEntryUpdateContentRequestBuilder(entryId, resource, conversionProfileId, advancedOptions);
		}

		public static BaseEntryGetByIdsRequestBuilder GetByIds(string entryIds)
		{
			return new BaseEntryGetByIdsRequestBuilder(entryIds);
		}

		public static BaseEntryDeleteRequestBuilder Delete(string entryId)
		{
			return new BaseEntryDeleteRequestBuilder(entryId);
		}

		public static BaseEntryListRequestBuilder List(BaseEntryFilter filter = null, FilterPager pager = null)
		{
			return new BaseEntryListRequestBuilder(filter, pager);
		}

		public static BaseEntryListByReferenceIdRequestBuilder ListByReferenceId(string refId, FilterPager pager = null)
		{
			return new BaseEntryListByReferenceIdRequestBuilder(refId, pager);
		}

		public static BaseEntryCountRequestBuilder Count(BaseEntryFilter filter = null)
		{
			return new BaseEntryCountRequestBuilder(filter);
		}

		public static BaseEntryUploadRequestBuilder Upload(Stream fileData)
		{
			return new BaseEntryUploadRequestBuilder(fileData);
		}

		public static BaseEntryUpdateThumbnailJpegRequestBuilder UpdateThumbnailJpeg(string entryId, Stream fileData)
		{
			return new BaseEntryUpdateThumbnailJpegRequestBuilder(entryId, fileData);
		}

		public static BaseEntryUpdateThumbnailFromUrlRequestBuilder UpdateThumbnailFromUrl(string entryId, string url)
		{
			return new BaseEntryUpdateThumbnailFromUrlRequestBuilder(entryId, url);
		}

		public static BaseEntryUpdateThumbnailFromSourceEntryRequestBuilder UpdateThumbnailFromSourceEntry(string entryId, string sourceEntryId, int timeOffset)
		{
			return new BaseEntryUpdateThumbnailFromSourceEntryRequestBuilder(entryId, sourceEntryId, timeOffset);
		}

		public static BaseEntryFlagRequestBuilder Flag(ModerationFlag moderationFlag)
		{
			return new BaseEntryFlagRequestBuilder(moderationFlag);
		}

		public static BaseEntryRejectRequestBuilder Reject(string entryId)
		{
			return new BaseEntryRejectRequestBuilder(entryId);
		}

		public static BaseEntryApproveRequestBuilder Approve(string entryId)
		{
			return new BaseEntryApproveRequestBuilder(entryId);
		}

		public static BaseEntryListFlagsRequestBuilder ListFlags(string entryId, FilterPager pager = null)
		{
			return new BaseEntryListFlagsRequestBuilder(entryId, pager);
		}

		public static BaseEntryAnonymousRankRequestBuilder AnonymousRank(string entryId, int rank)
		{
			return new BaseEntryAnonymousRankRequestBuilder(entryId, rank);
		}

		public static BaseEntryGetContextDataRequestBuilder GetContextData(string entryId, EntryContextDataParams contextDataParams)
		{
			return new BaseEntryGetContextDataRequestBuilder(entryId, contextDataParams);
		}

		public static BaseEntryExportRequestBuilder Export(string entryId, int storageProfileId)
		{
			return new BaseEntryExportRequestBuilder(entryId, storageProfileId);
		}

		public static BaseEntryIndexRequestBuilder Index(string id, bool shouldUpdate = true)
		{
			return new BaseEntryIndexRequestBuilder(id, shouldUpdate);
		}

		public static BaseEntryCloneRequestBuilder Clone(string entryId, IList<BaseEntryCloneOptionItem> cloneOptions = null)
		{
			return new BaseEntryCloneRequestBuilder(entryId, cloneOptions);
		}

		public static BaseEntryGetPlaybackContextRequestBuilder GetPlaybackContext(string entryId, PlaybackContextOptions contextDataParams)
		{
			return new BaseEntryGetPlaybackContextRequestBuilder(entryId, contextDataParams);
		}
	}
}
