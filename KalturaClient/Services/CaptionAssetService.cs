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
	public class CaptionAssetAddRequestBuilder : RequestBuilder<CaptionAsset>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CAPTION_ASSET = "captionAsset";
		#endregion

		public string EntryId { get; set; }
		public CaptionAsset CaptionAsset { get; set; }

		public CaptionAssetAddRequestBuilder()
			: base("caption_captionasset", "add")
		{
		}

		public CaptionAssetAddRequestBuilder(string entryId, CaptionAsset captionAsset)
			: this()
		{
			this.EntryId = entryId;
			this.CaptionAsset = captionAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("captionAsset"))
				kparams.AddIfNotNull("captionAsset", CaptionAsset);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CaptionAsset>(result);
		}
	}

	public class CaptionAssetDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string CAPTION_ASSET_ID = "captionAssetId";
		#endregion

		public string CaptionAssetId { get; set; }

		public CaptionAssetDeleteRequestBuilder()
			: base("caption_captionasset", "delete")
		{
		}

		public CaptionAssetDeleteRequestBuilder(string captionAssetId)
			: this()
		{
			this.CaptionAssetId = captionAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("captionAssetId"))
				kparams.AddIfNotNull("captionAssetId", CaptionAssetId);
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

	public class CaptionAssetExportRequestBuilder : RequestBuilder<FlavorAsset>
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string STORAGE_PROFILE_ID = "storageProfileId";
		#endregion

		public string AssetId { get; set; }
		public int StorageProfileId { get; set; }

		public CaptionAssetExportRequestBuilder()
			: base("caption_captionasset", "export")
		{
		}

		public CaptionAssetExportRequestBuilder(string assetId, int storageProfileId)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<FlavorAsset>(result);
		}
	}

	public class CaptionAssetGetRequestBuilder : RequestBuilder<CaptionAsset>
	{
		#region Constants
		public const string CAPTION_ASSET_ID = "captionAssetId";
		#endregion

		public string CaptionAssetId { get; set; }

		public CaptionAssetGetRequestBuilder()
			: base("caption_captionasset", "get")
		{
		}

		public CaptionAssetGetRequestBuilder(string captionAssetId)
			: this()
		{
			this.CaptionAssetId = captionAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("captionAssetId"))
				kparams.AddIfNotNull("captionAssetId", CaptionAssetId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CaptionAsset>(result);
		}
	}

	public class CaptionAssetGetRemotePathsRequestBuilder : RequestBuilder<ListResponse<RemotePath>>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id { get; set; }

		public CaptionAssetGetRemotePathsRequestBuilder()
			: base("caption_captionasset", "getRemotePaths")
		{
		}

		public CaptionAssetGetRemotePathsRequestBuilder(string id)
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
			return ObjectFactory.Create<ListResponse<RemotePath>>(result);
		}
	}

	public class CaptionAssetGetUrlRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ID = "id";
		public const string STORAGE_ID = "storageId";
		#endregion

		public string Id { get; set; }
		public int StorageId { get; set; }

		public CaptionAssetGetUrlRequestBuilder()
			: base("caption_captionasset", "getUrl")
		{
		}

		public CaptionAssetGetUrlRequestBuilder(string id, int storageId)
			: this()
		{
			this.Id = id;
			this.StorageId = storageId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("storageId"))
				kparams.AddIfNotNull("storageId", StorageId);
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

	public class CaptionAssetListRequestBuilder : RequestBuilder<ListResponse<CaptionAsset>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public AssetFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public CaptionAssetListRequestBuilder()
			: base("caption_captionasset", "list")
		{
		}

		public CaptionAssetListRequestBuilder(AssetFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<CaptionAsset>>(result);
		}
	}

	public class CaptionAssetSetAsDefaultRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string CAPTION_ASSET_ID = "captionAssetId";
		#endregion

		public string CaptionAssetId { get; set; }

		public CaptionAssetSetAsDefaultRequestBuilder()
			: base("caption_captionasset", "setAsDefault")
		{
		}

		public CaptionAssetSetAsDefaultRequestBuilder(string captionAssetId)
			: this()
		{
			this.CaptionAssetId = captionAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("captionAssetId"))
				kparams.AddIfNotNull("captionAssetId", CaptionAssetId);
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

	public class CaptionAssetSetContentRequestBuilder : RequestBuilder<CaptionAsset>
	{
		#region Constants
		public const string ID = "id";
		public const string CONTENT_RESOURCE = "contentResource";
		#endregion

		public string Id { get; set; }
		public ContentResource ContentResource { get; set; }

		public CaptionAssetSetContentRequestBuilder()
			: base("caption_captionasset", "setContent")
		{
		}

		public CaptionAssetSetContentRequestBuilder(string id, ContentResource contentResource)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CaptionAsset>(result);
		}
	}

	public class CaptionAssetUpdateRequestBuilder : RequestBuilder<CaptionAsset>
	{
		#region Constants
		public const string ID = "id";
		public const string CAPTION_ASSET = "captionAsset";
		#endregion

		public string Id { get; set; }
		public CaptionAsset CaptionAsset { get; set; }

		public CaptionAssetUpdateRequestBuilder()
			: base("caption_captionasset", "update")
		{
		}

		public CaptionAssetUpdateRequestBuilder(string id, CaptionAsset captionAsset)
			: this()
		{
			this.Id = id;
			this.CaptionAsset = captionAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("captionAsset"))
				kparams.AddIfNotNull("captionAsset", CaptionAsset);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CaptionAsset>(result);
		}
	}


	public class CaptionAssetService
	{
		private CaptionAssetService()
		{
		}

		public static CaptionAssetAddRequestBuilder Add(string entryId, CaptionAsset captionAsset)
		{
			return new CaptionAssetAddRequestBuilder(entryId, captionAsset);
		}

		public static CaptionAssetDeleteRequestBuilder Delete(string captionAssetId)
		{
			return new CaptionAssetDeleteRequestBuilder(captionAssetId);
		}

		public static CaptionAssetExportRequestBuilder Export(string assetId, int storageProfileId)
		{
			return new CaptionAssetExportRequestBuilder(assetId, storageProfileId);
		}

		public static CaptionAssetGetRequestBuilder Get(string captionAssetId)
		{
			return new CaptionAssetGetRequestBuilder(captionAssetId);
		}

		public static CaptionAssetGetRemotePathsRequestBuilder GetRemotePaths(string id)
		{
			return new CaptionAssetGetRemotePathsRequestBuilder(id);
		}

		public static CaptionAssetGetUrlRequestBuilder GetUrl(string id, int storageId = Int32.MinValue)
		{
			return new CaptionAssetGetUrlRequestBuilder(id, storageId);
		}

		public static CaptionAssetListRequestBuilder List(AssetFilter filter = null, FilterPager pager = null)
		{
			return new CaptionAssetListRequestBuilder(filter, pager);
		}

		public static CaptionAssetSetAsDefaultRequestBuilder SetAsDefault(string captionAssetId)
		{
			return new CaptionAssetSetAsDefaultRequestBuilder(captionAssetId);
		}

		public static CaptionAssetSetContentRequestBuilder SetContent(string id, ContentResource contentResource)
		{
			return new CaptionAssetSetContentRequestBuilder(id, contentResource);
		}

		public static CaptionAssetUpdateRequestBuilder Update(string id, CaptionAsset captionAsset)
		{
			return new CaptionAssetUpdateRequestBuilder(id, captionAsset);
		}
	}
}
