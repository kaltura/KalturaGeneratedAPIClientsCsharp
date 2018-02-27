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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class MediaAddRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string ENTRY = "entry";
		#endregion

		public MediaEntry Entry
		{
			set;
			get;
		}

		public MediaAddRequestBuilder()
			: base("media", "add")
		{
		}

		public MediaAddRequestBuilder(MediaEntry entry)
			: this()
		{
			this.Entry = entry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entry"))
				kparams.AddIfNotNull("entry", Entry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaAddContentRequestBuilder : RequestBuilder<MediaEntry>
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

		public MediaAddContentRequestBuilder()
			: base("media", "addContent")
		{
		}

		public MediaAddContentRequestBuilder(string entryId, Resource resource)
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
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaAddFromBulkRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string MEDIA_ENTRY = "mediaEntry";
		public const string URL = "url";
		public const string BULK_UPLOAD_ID = "bulkUploadId";
		#endregion

		public MediaEntry MediaEntry
		{
			set;
			get;
		}
		public string Url
		{
			set;
			get;
		}
		public int BulkUploadId
		{
			set;
			get;
		}

		public MediaAddFromBulkRequestBuilder()
			: base("media", "addFromBulk")
		{
		}

		public MediaAddFromBulkRequestBuilder(MediaEntry mediaEntry, string url, int bulkUploadId)
			: this()
		{
			this.MediaEntry = mediaEntry;
			this.Url = url;
			this.BulkUploadId = bulkUploadId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("mediaEntry"))
				kparams.AddIfNotNull("mediaEntry", MediaEntry);
			if (!isMapped("url"))
				kparams.AddIfNotNull("url", Url);
			if (!isMapped("bulkUploadId"))
				kparams.AddIfNotNull("bulkUploadId", BulkUploadId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaAddFromEntryRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string SOURCE_ENTRY_ID = "sourceEntryId";
		public const string MEDIA_ENTRY = "mediaEntry";
		public const string SOURCE_FLAVOR_PARAMS_ID = "sourceFlavorParamsId";
		#endregion

		public string SourceEntryId
		{
			set;
			get;
		}
		public MediaEntry MediaEntry
		{
			set;
			get;
		}
		public int SourceFlavorParamsId
		{
			set;
			get;
		}

		public MediaAddFromEntryRequestBuilder()
			: base("media", "addFromEntry")
		{
		}

		public MediaAddFromEntryRequestBuilder(string sourceEntryId, MediaEntry mediaEntry, int sourceFlavorParamsId)
			: this()
		{
			this.SourceEntryId = sourceEntryId;
			this.MediaEntry = mediaEntry;
			this.SourceFlavorParamsId = sourceFlavorParamsId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("sourceEntryId"))
				kparams.AddIfNotNull("sourceEntryId", SourceEntryId);
			if (!isMapped("mediaEntry"))
				kparams.AddIfNotNull("mediaEntry", MediaEntry);
			if (!isMapped("sourceFlavorParamsId"))
				kparams.AddIfNotNull("sourceFlavorParamsId", SourceFlavorParamsId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaAddFromFlavorAssetRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string SOURCE_FLAVOR_ASSET_ID = "sourceFlavorAssetId";
		public const string MEDIA_ENTRY = "mediaEntry";
		#endregion

		public string SourceFlavorAssetId
		{
			set;
			get;
		}
		public MediaEntry MediaEntry
		{
			set;
			get;
		}

		public MediaAddFromFlavorAssetRequestBuilder()
			: base("media", "addFromFlavorAsset")
		{
		}

		public MediaAddFromFlavorAssetRequestBuilder(string sourceFlavorAssetId, MediaEntry mediaEntry)
			: this()
		{
			this.SourceFlavorAssetId = sourceFlavorAssetId;
			this.MediaEntry = mediaEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("sourceFlavorAssetId"))
				kparams.AddIfNotNull("sourceFlavorAssetId", SourceFlavorAssetId);
			if (!isMapped("mediaEntry"))
				kparams.AddIfNotNull("mediaEntry", MediaEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaAddFromRecordedWebcamRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string MEDIA_ENTRY = "mediaEntry";
		public const string WEBCAM_TOKEN_ID = "webcamTokenId";
		#endregion

		public MediaEntry MediaEntry
		{
			set;
			get;
		}
		public string WebcamTokenId
		{
			set;
			get;
		}

		public MediaAddFromRecordedWebcamRequestBuilder()
			: base("media", "addFromRecordedWebcam")
		{
		}

		public MediaAddFromRecordedWebcamRequestBuilder(MediaEntry mediaEntry, string webcamTokenId)
			: this()
		{
			this.MediaEntry = mediaEntry;
			this.WebcamTokenId = webcamTokenId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("mediaEntry"))
				kparams.AddIfNotNull("mediaEntry", MediaEntry);
			if (!isMapped("webcamTokenId"))
				kparams.AddIfNotNull("webcamTokenId", WebcamTokenId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaAddFromSearchResultRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string MEDIA_ENTRY = "mediaEntry";
		public const string SEARCH_RESULT = "searchResult";
		#endregion

		public MediaEntry MediaEntry
		{
			set;
			get;
		}
		public SearchResult SearchResult
		{
			set;
			get;
		}

		public MediaAddFromSearchResultRequestBuilder()
			: base("media", "addFromSearchResult")
		{
		}

		public MediaAddFromSearchResultRequestBuilder(MediaEntry mediaEntry, SearchResult searchResult)
			: this()
		{
			this.MediaEntry = mediaEntry;
			this.SearchResult = searchResult;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("mediaEntry"))
				kparams.AddIfNotNull("mediaEntry", MediaEntry);
			if (!isMapped("searchResult"))
				kparams.AddIfNotNull("searchResult", SearchResult);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaAddFromUploadedFileRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string MEDIA_ENTRY = "mediaEntry";
		public const string UPLOAD_TOKEN_ID = "uploadTokenId";
		#endregion

		public MediaEntry MediaEntry
		{
			set;
			get;
		}
		public string UploadTokenId
		{
			set;
			get;
		}

		public MediaAddFromUploadedFileRequestBuilder()
			: base("media", "addFromUploadedFile")
		{
		}

		public MediaAddFromUploadedFileRequestBuilder(MediaEntry mediaEntry, string uploadTokenId)
			: this()
		{
			this.MediaEntry = mediaEntry;
			this.UploadTokenId = uploadTokenId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("mediaEntry"))
				kparams.AddIfNotNull("mediaEntry", MediaEntry);
			if (!isMapped("uploadTokenId"))
				kparams.AddIfNotNull("uploadTokenId", UploadTokenId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaAddFromUrlRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string MEDIA_ENTRY = "mediaEntry";
		public const string URL = "url";
		#endregion

		public MediaEntry MediaEntry
		{
			set;
			get;
		}
		public string Url
		{
			set;
			get;
		}

		public MediaAddFromUrlRequestBuilder()
			: base("media", "addFromUrl")
		{
		}

		public MediaAddFromUrlRequestBuilder(MediaEntry mediaEntry, string url)
			: this()
		{
			this.MediaEntry = mediaEntry;
			this.Url = url;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("mediaEntry"))
				kparams.AddIfNotNull("mediaEntry", MediaEntry);
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
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaAnonymousRankRequestBuilder : RequestBuilder<object>
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

		public MediaAnonymousRankRequestBuilder()
			: base("media", "anonymousRank")
		{
		}

		public MediaAnonymousRankRequestBuilder(string entryId, int rank)
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

	public class MediaApproveRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

		public MediaApproveRequestBuilder()
			: base("media", "approve")
		{
		}

		public MediaApproveRequestBuilder(string entryId)
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

	public class MediaApproveReplaceRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

		public MediaApproveReplaceRequestBuilder()
			: base("media", "approveReplace")
		{
		}

		public MediaApproveReplaceRequestBuilder(string entryId)
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
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaBulkUploadAddRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		public const string BULK_UPLOAD_DATA = "bulkUploadData";
		public const string BULK_UPLOAD_ENTRY_DATA = "bulkUploadEntryData";
		#endregion

		public Stream FileData
		{
			set;
			get;
		}
		public BulkUploadJobData BulkUploadData
		{
			set;
			get;
		}
		public BulkUploadEntryData BulkUploadEntryData
		{
			set;
			get;
		}

		public MediaBulkUploadAddRequestBuilder()
			: base("media", "bulkUploadAdd")
		{
		}

		public MediaBulkUploadAddRequestBuilder(Stream fileData, BulkUploadJobData bulkUploadData, BulkUploadEntryData bulkUploadEntryData)
			: this()
		{
			this.FileData = fileData;
			this.BulkUploadData = bulkUploadData;
			this.BulkUploadEntryData = bulkUploadEntryData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("bulkUploadData"))
				kparams.AddIfNotNull("bulkUploadData", BulkUploadData);
			if (!isMapped("bulkUploadEntryData"))
				kparams.AddIfNotNull("bulkUploadEntryData", BulkUploadEntryData);
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
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class MediaCancelReplaceRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

		public MediaCancelReplaceRequestBuilder()
			: base("media", "cancelReplace")
		{
		}

		public MediaCancelReplaceRequestBuilder(string entryId)
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
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaConvertRequestBuilder : RequestBuilder<long>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string DYNAMIC_CONVERSION_ATTRIBUTES = "dynamicConversionAttributes";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int ConversionProfileId
		{
			set;
			get;
		}
		public IList<ConversionAttribute> DynamicConversionAttributes
		{
			set;
			get;
		}

		public MediaConvertRequestBuilder()
			: base("media", "convert")
		{
		}

		public MediaConvertRequestBuilder(string entryId, int conversionProfileId, IList<ConversionAttribute> dynamicConversionAttributes)
			: this()
		{
			this.EntryId = entryId;
			this.ConversionProfileId = conversionProfileId;
			this.DynamicConversionAttributes = dynamicConversionAttributes;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("conversionProfileId"))
				kparams.AddIfNotNull("conversionProfileId", ConversionProfileId);
			if (!isMapped("dynamicConversionAttributes"))
				kparams.AddIfNotNull("dynamicConversionAttributes", DynamicConversionAttributes);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return long.Parse(result.InnerText);
		}
	}

	public class MediaCountRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public MediaEntryFilter Filter
		{
			set;
			get;
		}

		public MediaCountRequestBuilder()
			: base("media", "count")
		{
		}

		public MediaCountRequestBuilder(MediaEntryFilter filter)
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

	public class MediaDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

		public MediaDeleteRequestBuilder()
			: base("media", "delete")
		{
		}

		public MediaDeleteRequestBuilder(string entryId)
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

	public class MediaFlagRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string MODERATION_FLAG = "moderationFlag";
		#endregion

		public ModerationFlag ModerationFlag
		{
			set;
			get;
		}

		public MediaFlagRequestBuilder()
			: base("media", "flag")
		{
		}

		public MediaFlagRequestBuilder(ModerationFlag moderationFlag)
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

	public class MediaGetRequestBuilder : RequestBuilder<MediaEntry>
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

		public MediaGetRequestBuilder()
			: base("media", "get")
		{
		}

		public MediaGetRequestBuilder(string entryId, int version)
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
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaGetMrssRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string EXTENDING_ITEMS_ARRAY = "extendingItemsArray";
		public const string FEATURES = "features";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public IList<ExtendingItemMrssParameter> ExtendingItemsArray
		{
			set;
			get;
		}
		public string Features
		{
			set;
			get;
		}

		public MediaGetMrssRequestBuilder()
			: base("media", "getMrss")
		{
		}

		public MediaGetMrssRequestBuilder(string entryId, IList<ExtendingItemMrssParameter> extendingItemsArray, string features)
			: this()
		{
			this.EntryId = entryId;
			this.ExtendingItemsArray = extendingItemsArray;
			this.Features = features;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("extendingItemsArray"))
				kparams.AddIfNotNull("extendingItemsArray", ExtendingItemsArray);
			if (!isMapped("features"))
				kparams.AddIfNotNull("features", Features);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return result.InnerText;
		}
	}

	public class MediaListRequestBuilder : RequestBuilder<ListResponse<MediaEntry>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public MediaEntryFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public MediaListRequestBuilder()
			: base("media", "list")
		{
		}

		public MediaListRequestBuilder(MediaEntryFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<MediaEntry>>(result);
		}
	}

	public class MediaListFlagsRequestBuilder : RequestBuilder<ListResponse<ModerationFlag>>
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

		public MediaListFlagsRequestBuilder()
			: base("media", "listFlags")
		{
		}

		public MediaListFlagsRequestBuilder(string entryId, FilterPager pager)
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

	public class MediaRejectRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

		public MediaRejectRequestBuilder()
			: base("media", "reject")
		{
		}

		public MediaRejectRequestBuilder(string entryId)
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

	public class MediaRequestConversionRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string FILE_FORMAT = "fileFormat";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public string FileFormat
		{
			set;
			get;
		}

		public MediaRequestConversionRequestBuilder()
			: base("media", "requestConversion")
		{
		}

		public MediaRequestConversionRequestBuilder(string entryId, string fileFormat)
			: this()
		{
			this.EntryId = entryId;
			this.FileFormat = fileFormat;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("fileFormat"))
				kparams.AddIfNotNull("fileFormat", FileFormat);
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

	public class MediaUpdateRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string MEDIA_ENTRY = "mediaEntry";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public MediaEntry MediaEntry
		{
			set;
			get;
		}

		public MediaUpdateRequestBuilder()
			: base("media", "update")
		{
		}

		public MediaUpdateRequestBuilder(string entryId, MediaEntry mediaEntry)
			: this()
		{
			this.EntryId = entryId;
			this.MediaEntry = mediaEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("mediaEntry"))
				kparams.AddIfNotNull("mediaEntry", MediaEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaUpdateContentRequestBuilder : RequestBuilder<MediaEntry>
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

		public MediaUpdateContentRequestBuilder()
			: base("media", "updateContent")
		{
		}

		public MediaUpdateContentRequestBuilder(string entryId, Resource resource, int conversionProfileId, EntryReplacementOptions advancedOptions)
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
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaUpdateThumbnailRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string TIME_OFFSET = "timeOffset";
		public const string FLAVOR_PARAMS_ID = "flavorParamsId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int TimeOffset
		{
			set;
			get;
		}
		public int FlavorParamsId
		{
			set;
			get;
		}

		public MediaUpdateThumbnailRequestBuilder()
			: base("media", "updateThumbnail")
		{
		}

		public MediaUpdateThumbnailRequestBuilder(string entryId, int timeOffset, int flavorParamsId)
			: this()
		{
			this.EntryId = entryId;
			this.TimeOffset = timeOffset;
			this.FlavorParamsId = flavorParamsId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("timeOffset"))
				kparams.AddIfNotNull("timeOffset", TimeOffset);
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
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaUpdateThumbnailFromSourceEntryRequestBuilder : RequestBuilder<MediaEntry>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string SOURCE_ENTRY_ID = "sourceEntryId";
		public const string TIME_OFFSET = "timeOffset";
		public const string FLAVOR_PARAMS_ID = "flavorParamsId";
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
		public int FlavorParamsId
		{
			set;
			get;
		}

		public MediaUpdateThumbnailFromSourceEntryRequestBuilder()
			: base("media", "updateThumbnailFromSourceEntry")
		{
		}

		public MediaUpdateThumbnailFromSourceEntryRequestBuilder(string entryId, string sourceEntryId, int timeOffset, int flavorParamsId)
			: this()
		{
			this.EntryId = entryId;
			this.SourceEntryId = sourceEntryId;
			this.TimeOffset = timeOffset;
			this.FlavorParamsId = flavorParamsId;
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
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaUpdateThumbnailFromUrlRequestBuilder : RequestBuilder<BaseEntry>
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

		public MediaUpdateThumbnailFromUrlRequestBuilder()
			: base("media", "updateThumbnailFromUrl")
		{
		}

		public MediaUpdateThumbnailFromUrlRequestBuilder(string entryId, string url)
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

	public class MediaUpdateThumbnailJpegRequestBuilder : RequestBuilder<MediaEntry>
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

		public MediaUpdateThumbnailJpegRequestBuilder()
			: base("media", "updateThumbnailJpeg")
		{
		}

		public MediaUpdateThumbnailJpegRequestBuilder(string entryId, Stream fileData)
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
			return ObjectFactory.Create<MediaEntry>(result);
		}
	}

	public class MediaUploadRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		#endregion

		public Stream FileData
		{
			set;
			get;
		}

		public MediaUploadRequestBuilder()
			: base("media", "upload")
		{
		}

		public MediaUploadRequestBuilder(Stream fileData)
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


	public class MediaService
	{
		private MediaService()
		{
		}

		public static MediaAddRequestBuilder Add(MediaEntry entry)
		{
			return new MediaAddRequestBuilder(entry);
		}

		public static MediaAddContentRequestBuilder AddContent(string entryId, Resource resource = null)
		{
			return new MediaAddContentRequestBuilder(entryId, resource);
		}

		public static MediaAddFromBulkRequestBuilder AddFromBulk(MediaEntry mediaEntry, string url, int bulkUploadId)
		{
			return new MediaAddFromBulkRequestBuilder(mediaEntry, url, bulkUploadId);
		}

		public static MediaAddFromEntryRequestBuilder AddFromEntry(string sourceEntryId, MediaEntry mediaEntry = null, int sourceFlavorParamsId = Int32.MinValue)
		{
			return new MediaAddFromEntryRequestBuilder(sourceEntryId, mediaEntry, sourceFlavorParamsId);
		}

		public static MediaAddFromFlavorAssetRequestBuilder AddFromFlavorAsset(string sourceFlavorAssetId, MediaEntry mediaEntry = null)
		{
			return new MediaAddFromFlavorAssetRequestBuilder(sourceFlavorAssetId, mediaEntry);
		}

		public static MediaAddFromRecordedWebcamRequestBuilder AddFromRecordedWebcam(MediaEntry mediaEntry, string webcamTokenId)
		{
			return new MediaAddFromRecordedWebcamRequestBuilder(mediaEntry, webcamTokenId);
		}

		public static MediaAddFromSearchResultRequestBuilder AddFromSearchResult(MediaEntry mediaEntry = null, SearchResult searchResult = null)
		{
			return new MediaAddFromSearchResultRequestBuilder(mediaEntry, searchResult);
		}

		public static MediaAddFromUploadedFileRequestBuilder AddFromUploadedFile(MediaEntry mediaEntry, string uploadTokenId)
		{
			return new MediaAddFromUploadedFileRequestBuilder(mediaEntry, uploadTokenId);
		}

		public static MediaAddFromUrlRequestBuilder AddFromUrl(MediaEntry mediaEntry, string url)
		{
			return new MediaAddFromUrlRequestBuilder(mediaEntry, url);
		}

		public static MediaAnonymousRankRequestBuilder AnonymousRank(string entryId, int rank)
		{
			return new MediaAnonymousRankRequestBuilder(entryId, rank);
		}

		public static MediaApproveRequestBuilder Approve(string entryId)
		{
			return new MediaApproveRequestBuilder(entryId);
		}

		public static MediaApproveReplaceRequestBuilder ApproveReplace(string entryId)
		{
			return new MediaApproveReplaceRequestBuilder(entryId);
		}

		public static MediaBulkUploadAddRequestBuilder BulkUploadAdd(Stream fileData, BulkUploadJobData bulkUploadData = null, BulkUploadEntryData bulkUploadEntryData = null)
		{
			return new MediaBulkUploadAddRequestBuilder(fileData, bulkUploadData, bulkUploadEntryData);
		}

		public static MediaCancelReplaceRequestBuilder CancelReplace(string entryId)
		{
			return new MediaCancelReplaceRequestBuilder(entryId);
		}

		public static MediaConvertRequestBuilder Convert(string entryId, int conversionProfileId = Int32.MinValue, IList<ConversionAttribute> dynamicConversionAttributes = null)
		{
			return new MediaConvertRequestBuilder(entryId, conversionProfileId, dynamicConversionAttributes);
		}

		public static MediaCountRequestBuilder Count(MediaEntryFilter filter = null)
		{
			return new MediaCountRequestBuilder(filter);
		}

		public static MediaDeleteRequestBuilder Delete(string entryId)
		{
			return new MediaDeleteRequestBuilder(entryId);
		}

		public static MediaFlagRequestBuilder Flag(ModerationFlag moderationFlag)
		{
			return new MediaFlagRequestBuilder(moderationFlag);
		}

		public static MediaGetRequestBuilder Get(string entryId, int version = -1)
		{
			return new MediaGetRequestBuilder(entryId, version);
		}

		public static MediaGetMrssRequestBuilder GetMrss(string entryId, IList<ExtendingItemMrssParameter> extendingItemsArray = null, string features = null)
		{
			return new MediaGetMrssRequestBuilder(entryId, extendingItemsArray, features);
		}

		public static MediaListRequestBuilder List(MediaEntryFilter filter = null, FilterPager pager = null)
		{
			return new MediaListRequestBuilder(filter, pager);
		}

		public static MediaListFlagsRequestBuilder ListFlags(string entryId, FilterPager pager = null)
		{
			return new MediaListFlagsRequestBuilder(entryId, pager);
		}

		public static MediaRejectRequestBuilder Reject(string entryId)
		{
			return new MediaRejectRequestBuilder(entryId);
		}

		public static MediaRequestConversionRequestBuilder RequestConversion(string entryId, string fileFormat)
		{
			return new MediaRequestConversionRequestBuilder(entryId, fileFormat);
		}

		public static MediaUpdateRequestBuilder Update(string entryId, MediaEntry mediaEntry)
		{
			return new MediaUpdateRequestBuilder(entryId, mediaEntry);
		}

		public static MediaUpdateContentRequestBuilder UpdateContent(string entryId, Resource resource, int conversionProfileId = Int32.MinValue, EntryReplacementOptions advancedOptions = null)
		{
			return new MediaUpdateContentRequestBuilder(entryId, resource, conversionProfileId, advancedOptions);
		}

		public static MediaUpdateThumbnailRequestBuilder UpdateThumbnail(string entryId, int timeOffset, int flavorParamsId = Int32.MinValue)
		{
			return new MediaUpdateThumbnailRequestBuilder(entryId, timeOffset, flavorParamsId);
		}

		public static MediaUpdateThumbnailFromSourceEntryRequestBuilder UpdateThumbnailFromSourceEntry(string entryId, string sourceEntryId, int timeOffset, int flavorParamsId = Int32.MinValue)
		{
			return new MediaUpdateThumbnailFromSourceEntryRequestBuilder(entryId, sourceEntryId, timeOffset, flavorParamsId);
		}

		public static MediaUpdateThumbnailFromUrlRequestBuilder UpdateThumbnailFromUrl(string entryId, string url)
		{
			return new MediaUpdateThumbnailFromUrlRequestBuilder(entryId, url);
		}

		public static MediaUpdateThumbnailJpegRequestBuilder UpdateThumbnailJpeg(string entryId, Stream fileData)
		{
			return new MediaUpdateThumbnailJpegRequestBuilder(entryId, fileData);
		}

		public static MediaUploadRequestBuilder Upload(Stream fileData)
		{
			return new MediaUploadRequestBuilder(fileData);
		}
	}
}
