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
	public class ThumbAssetAddRequestBuilder : RequestBuilder<ThumbAsset>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string THUMB_ASSET = "thumbAsset";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public ThumbAsset ThumbAsset
		{
			set;
			get;
		}

		public ThumbAssetAddRequestBuilder()
			: base("thumbasset", "add")
		{
		}

		public ThumbAssetAddRequestBuilder(string entryId, ThumbAsset thumbAsset)
			: this()
		{
			this.EntryId = entryId;
			this.ThumbAsset = thumbAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("thumbAsset"))
				kparams.AddIfNotNull("thumbAsset", ThumbAsset);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ThumbAsset>(result);
		}
	}

	public class ThumbAssetAddFromImageRequestBuilder : RequestBuilder<ThumbAsset>
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

		public ThumbAssetAddFromImageRequestBuilder()
			: base("thumbasset", "addFromImage")
		{
		}

		public ThumbAssetAddFromImageRequestBuilder(string entryId, Stream fileData)
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
			return ObjectFactory.Create<ThumbAsset>(result);
		}
	}

	public class ThumbAssetAddFromUrlRequestBuilder : RequestBuilder<ThumbAsset>
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

		public ThumbAssetAddFromUrlRequestBuilder()
			: base("thumbasset", "addFromUrl")
		{
		}

		public ThumbAssetAddFromUrlRequestBuilder(string entryId, string url)
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
			return ObjectFactory.Create<ThumbAsset>(result);
		}
	}

	public class ThumbAssetDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string THUMB_ASSET_ID = "thumbAssetId";
		#endregion

		public string ThumbAssetId
		{
			set;
			get;
		}

		public ThumbAssetDeleteRequestBuilder()
			: base("thumbasset", "delete")
		{
		}

		public ThumbAssetDeleteRequestBuilder(string thumbAssetId)
			: this()
		{
			this.ThumbAssetId = thumbAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("thumbAssetId"))
				kparams.AddIfNotNull("thumbAssetId", ThumbAssetId);
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

	public class ThumbAssetExportRequestBuilder : RequestBuilder<FlavorAsset>
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string STORAGE_PROFILE_ID = "storageProfileId";
		#endregion

		public string AssetId
		{
			set;
			get;
		}
		public int StorageProfileId
		{
			set;
			get;
		}

		public ThumbAssetExportRequestBuilder()
			: base("thumbasset", "export")
		{
		}

		public ThumbAssetExportRequestBuilder(string assetId, int storageProfileId)
			: this()
		{
			this.AssetId = assetId;
			this.StorageProfileId = storageProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
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
			return ObjectFactory.Create<FlavorAsset>(result);
		}
	}

	public class ThumbAssetGenerateRequestBuilder : RequestBuilder<ThumbAsset>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string THUMB_PARAMS = "thumbParams";
		public const string SOURCE_ASSET_ID = "sourceAssetId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public ThumbParams ThumbParams
		{
			set;
			get;
		}
		public string SourceAssetId
		{
			set;
			get;
		}

		public ThumbAssetGenerateRequestBuilder()
			: base("thumbasset", "generate")
		{
		}

		public ThumbAssetGenerateRequestBuilder(string entryId, ThumbParams thumbParams, string sourceAssetId)
			: this()
		{
			this.EntryId = entryId;
			this.ThumbParams = thumbParams;
			this.SourceAssetId = sourceAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("thumbParams"))
				kparams.AddIfNotNull("thumbParams", ThumbParams);
			if (!isMapped("sourceAssetId"))
				kparams.AddIfNotNull("sourceAssetId", SourceAssetId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ThumbAsset>(result);
		}
	}

	public class ThumbAssetGenerateByEntryIdRequestBuilder : RequestBuilder<ThumbAsset>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string DEST_THUMB_PARAMS_ID = "destThumbParamsId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int DestThumbParamsId
		{
			set;
			get;
		}

		public ThumbAssetGenerateByEntryIdRequestBuilder()
			: base("thumbasset", "generateByEntryId")
		{
		}

		public ThumbAssetGenerateByEntryIdRequestBuilder(string entryId, int destThumbParamsId)
			: this()
		{
			this.EntryId = entryId;
			this.DestThumbParamsId = destThumbParamsId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("destThumbParamsId"))
				kparams.AddIfNotNull("destThumbParamsId", DestThumbParamsId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ThumbAsset>(result);
		}
	}

	public class ThumbAssetGetRequestBuilder : RequestBuilder<ThumbAsset>
	{
		#region Constants
		public const string THUMB_ASSET_ID = "thumbAssetId";
		#endregion

		public string ThumbAssetId
		{
			set;
			get;
		}

		public ThumbAssetGetRequestBuilder()
			: base("thumbasset", "get")
		{
		}

		public ThumbAssetGetRequestBuilder(string thumbAssetId)
			: this()
		{
			this.ThumbAssetId = thumbAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("thumbAssetId"))
				kparams.AddIfNotNull("thumbAssetId", ThumbAssetId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ThumbAsset>(result);
		}
	}

	public class ThumbAssetGetByEntryIdRequestBuilder : RequestBuilder<IList<ThumbAsset>>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

		public ThumbAssetGetByEntryIdRequestBuilder()
			: base("thumbasset", "getByEntryId")
		{
		}

		public ThumbAssetGetByEntryIdRequestBuilder(string entryId)
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
			IList<ThumbAsset> list = new List<ThumbAsset>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add(ObjectFactory.Create<ThumbAsset>(node));
			}
			return list;
		}
	}

	public class ThumbAssetGetRemotePathsRequestBuilder : RequestBuilder<ListResponse<RemotePath>>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public ThumbAssetGetRemotePathsRequestBuilder()
			: base("thumbasset", "getRemotePaths")
		{
		}

		public ThumbAssetGetRemotePathsRequestBuilder(string id)
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
			return ObjectFactory.Create<ListResponse<RemotePath>>(result);
		}
	}

	public class ThumbAssetGetUrlRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ID = "id";
		public const string STORAGE_ID = "storageId";
		public const string THUMB_PARAMS = "thumbParams";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public int StorageId
		{
			set;
			get;
		}
		public ThumbParams ThumbParams
		{
			set;
			get;
		}

		public ThumbAssetGetUrlRequestBuilder()
			: base("thumbasset", "getUrl")
		{
		}

		public ThumbAssetGetUrlRequestBuilder(string id, int storageId, ThumbParams thumbParams)
			: this()
		{
			this.Id = id;
			this.StorageId = storageId;
			this.ThumbParams = thumbParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("storageId"))
				kparams.AddIfNotNull("storageId", StorageId);
			if (!isMapped("thumbParams"))
				kparams.AddIfNotNull("thumbParams", ThumbParams);
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

	public class ThumbAssetListRequestBuilder : RequestBuilder<ListResponse<ThumbAsset>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public AssetFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public ThumbAssetListRequestBuilder()
			: base("thumbasset", "list")
		{
		}

		public ThumbAssetListRequestBuilder(AssetFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<ThumbAsset>>(result);
		}
	}

	public class ThumbAssetRegenerateRequestBuilder : RequestBuilder<ThumbAsset>
	{
		#region Constants
		public const string THUMB_ASSET_ID = "thumbAssetId";
		#endregion

		public string ThumbAssetId
		{
			set;
			get;
		}

		public ThumbAssetRegenerateRequestBuilder()
			: base("thumbasset", "regenerate")
		{
		}

		public ThumbAssetRegenerateRequestBuilder(string thumbAssetId)
			: this()
		{
			this.ThumbAssetId = thumbAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("thumbAssetId"))
				kparams.AddIfNotNull("thumbAssetId", ThumbAssetId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ThumbAsset>(result);
		}
	}

	public class ThumbAssetSetAsDefaultRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string THUMB_ASSET_ID = "thumbAssetId";
		#endregion

		public string ThumbAssetId
		{
			set;
			get;
		}

		public ThumbAssetSetAsDefaultRequestBuilder()
			: base("thumbasset", "setAsDefault")
		{
		}

		public ThumbAssetSetAsDefaultRequestBuilder(string thumbAssetId)
			: this()
		{
			this.ThumbAssetId = thumbAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("thumbAssetId"))
				kparams.AddIfNotNull("thumbAssetId", ThumbAssetId);
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

	public class ThumbAssetSetContentRequestBuilder : RequestBuilder<ThumbAsset>
	{
		#region Constants
		public const string ID = "id";
		public const string CONTENT_RESOURCE = "contentResource";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public ContentResource ContentResource
		{
			set;
			get;
		}

		public ThumbAssetSetContentRequestBuilder()
			: base("thumbasset", "setContent")
		{
		}

		public ThumbAssetSetContentRequestBuilder(string id, ContentResource contentResource)
			: this()
		{
			this.Id = id;
			this.ContentResource = contentResource;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("contentResource"))
				kparams.AddIfNotNull("contentResource", ContentResource);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ThumbAsset>(result);
		}
	}

	public class ThumbAssetUpdateRequestBuilder : RequestBuilder<ThumbAsset>
	{
		#region Constants
		public const string ID = "id";
		public const string THUMB_ASSET = "thumbAsset";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public ThumbAsset ThumbAsset
		{
			set;
			get;
		}

		public ThumbAssetUpdateRequestBuilder()
			: base("thumbasset", "update")
		{
		}

		public ThumbAssetUpdateRequestBuilder(string id, ThumbAsset thumbAsset)
			: this()
		{
			this.Id = id;
			this.ThumbAsset = thumbAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("thumbAsset"))
				kparams.AddIfNotNull("thumbAsset", ThumbAsset);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ThumbAsset>(result);
		}
	}


	public class ThumbAssetService
	{
		private ThumbAssetService()
		{
		}

		public static ThumbAssetAddRequestBuilder Add(string entryId, ThumbAsset thumbAsset)
		{
			return new ThumbAssetAddRequestBuilder(entryId, thumbAsset);
		}

		public static ThumbAssetAddFromImageRequestBuilder AddFromImage(string entryId, Stream fileData)
		{
			return new ThumbAssetAddFromImageRequestBuilder(entryId, fileData);
		}

		public static ThumbAssetAddFromUrlRequestBuilder AddFromUrl(string entryId, string url)
		{
			return new ThumbAssetAddFromUrlRequestBuilder(entryId, url);
		}

		public static ThumbAssetDeleteRequestBuilder Delete(string thumbAssetId)
		{
			return new ThumbAssetDeleteRequestBuilder(thumbAssetId);
		}

		public static ThumbAssetExportRequestBuilder Export(string assetId, int storageProfileId)
		{
			return new ThumbAssetExportRequestBuilder(assetId, storageProfileId);
		}

		public static ThumbAssetGenerateRequestBuilder Generate(string entryId, ThumbParams thumbParams, string sourceAssetId = null)
		{
			return new ThumbAssetGenerateRequestBuilder(entryId, thumbParams, sourceAssetId);
		}

		public static ThumbAssetGenerateByEntryIdRequestBuilder GenerateByEntryId(string entryId, int destThumbParamsId)
		{
			return new ThumbAssetGenerateByEntryIdRequestBuilder(entryId, destThumbParamsId);
		}

		public static ThumbAssetGetRequestBuilder Get(string thumbAssetId)
		{
			return new ThumbAssetGetRequestBuilder(thumbAssetId);
		}

		public static ThumbAssetGetByEntryIdRequestBuilder GetByEntryId(string entryId)
		{
			return new ThumbAssetGetByEntryIdRequestBuilder(entryId);
		}

		public static ThumbAssetGetRemotePathsRequestBuilder GetRemotePaths(string id)
		{
			return new ThumbAssetGetRemotePathsRequestBuilder(id);
		}

		public static ThumbAssetGetUrlRequestBuilder GetUrl(string id, int storageId = Int32.MinValue, ThumbParams thumbParams = null)
		{
			return new ThumbAssetGetUrlRequestBuilder(id, storageId, thumbParams);
		}

		public static ThumbAssetListRequestBuilder List(AssetFilter filter = null, FilterPager pager = null)
		{
			return new ThumbAssetListRequestBuilder(filter, pager);
		}

		public static ThumbAssetRegenerateRequestBuilder Regenerate(string thumbAssetId)
		{
			return new ThumbAssetRegenerateRequestBuilder(thumbAssetId);
		}

		public static ThumbAssetSetAsDefaultRequestBuilder SetAsDefault(string thumbAssetId)
		{
			return new ThumbAssetSetAsDefaultRequestBuilder(thumbAssetId);
		}

		public static ThumbAssetSetContentRequestBuilder SetContent(string id, ContentResource contentResource)
		{
			return new ThumbAssetSetContentRequestBuilder(id, contentResource);
		}

		public static ThumbAssetUpdateRequestBuilder Update(string id, ThumbAsset thumbAsset)
		{
			return new ThumbAssetUpdateRequestBuilder(id, thumbAsset);
		}
	}
}
