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
	public class FlavorAssetAddRequestBuilder : RequestBuilder<FlavorAsset>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string FLAVOR_ASSET = "flavorAsset";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public FlavorAsset FlavorAsset
		{
			set;
			get;
		}

		public FlavorAssetAddRequestBuilder()
			: base("flavorasset", "add")
		{
		}

		public FlavorAssetAddRequestBuilder(string entryId, FlavorAsset flavorAsset)
			: this()
		{
			this.EntryId = entryId;
			this.FlavorAsset = flavorAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("flavorAsset"))
				kparams.AddIfNotNull("flavorAsset", FlavorAsset);
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

	public class FlavorAssetConvertRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string FLAVOR_PARAMS_ID = "flavorParamsId";
		public const string PRIORITY = "priority";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public int FlavorParamsId
		{
			set;
			get;
		}
		public int Priority
		{
			set;
			get;
		}

		public FlavorAssetConvertRequestBuilder()
			: base("flavorasset", "convert")
		{
		}

		public FlavorAssetConvertRequestBuilder(string entryId, int flavorParamsId, int priority)
			: this()
		{
			this.EntryId = entryId;
			this.FlavorParamsId = flavorParamsId;
			this.Priority = priority;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("flavorParamsId"))
				kparams.AddIfNotNull("flavorParamsId", FlavorParamsId);
			if (!isMapped("priority"))
				kparams.AddIfNotNull("priority", Priority);
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

	public class FlavorAssetDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public FlavorAssetDeleteRequestBuilder()
			: base("flavorasset", "delete")
		{
		}

		public FlavorAssetDeleteRequestBuilder(string id)
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

	public class FlavorAssetDeleteLocalContentRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		#endregion

		public string AssetId
		{
			set;
			get;
		}

		public FlavorAssetDeleteLocalContentRequestBuilder()
			: base("flavorasset", "deleteLocalContent")
		{
		}

		public FlavorAssetDeleteLocalContentRequestBuilder(string assetId)
			: this()
		{
			this.AssetId = assetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
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

	public class FlavorAssetExportRequestBuilder : RequestBuilder<FlavorAsset>
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

		public FlavorAssetExportRequestBuilder()
			: base("flavorasset", "export")
		{
		}

		public FlavorAssetExportRequestBuilder(string assetId, int storageProfileId)
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

	public class FlavorAssetGetRequestBuilder : RequestBuilder<FlavorAsset>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public FlavorAssetGetRequestBuilder()
			: base("flavorasset", "get")
		{
		}

		public FlavorAssetGetRequestBuilder(string id)
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
			return ObjectFactory.Create<FlavorAsset>(result);
		}
	}

	public class FlavorAssetGetByEntryIdRequestBuilder : RequestBuilder<IList<FlavorAsset>>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

		public FlavorAssetGetByEntryIdRequestBuilder()
			: base("flavorasset", "getByEntryId")
		{
		}

		public FlavorAssetGetByEntryIdRequestBuilder(string entryId)
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
			IList<FlavorAsset> list = new List<FlavorAsset>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add(ObjectFactory.Create<FlavorAsset>(node));
			}
			return list;
		}
	}

	public class FlavorAssetGetDownloadUrlRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ID = "id";
		public const string USE_CDN = "useCdn";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public bool UseCdn
		{
			set;
			get;
		}

		public FlavorAssetGetDownloadUrlRequestBuilder()
			: base("flavorasset", "getDownloadUrl")
		{
		}

		public FlavorAssetGetDownloadUrlRequestBuilder(string id, bool useCdn)
			: this()
		{
			this.Id = id;
			this.UseCdn = useCdn;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("useCdn"))
				kparams.AddIfNotNull("useCdn", UseCdn);
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

	public class FlavorAssetGetFlavorAssetsWithParamsRequestBuilder : RequestBuilder<IList<FlavorAssetWithParams>>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

		public FlavorAssetGetFlavorAssetsWithParamsRequestBuilder()
			: base("flavorasset", "getFlavorAssetsWithParams")
		{
		}

		public FlavorAssetGetFlavorAssetsWithParamsRequestBuilder(string entryId)
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
			IList<FlavorAssetWithParams> list = new List<FlavorAssetWithParams>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add(ObjectFactory.Create<FlavorAssetWithParams>(node));
			}
			return list;
		}
	}

	public class FlavorAssetGetRemotePathsRequestBuilder : RequestBuilder<ListResponse<RemotePath>>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public FlavorAssetGetRemotePathsRequestBuilder()
			: base("flavorasset", "getRemotePaths")
		{
		}

		public FlavorAssetGetRemotePathsRequestBuilder(string id)
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

	public class FlavorAssetGetUrlRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ID = "id";
		public const string STORAGE_ID = "storageId";
		public const string FORCE_PROXY = "forceProxy";
		public const string OPTIONS = "options";
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
		public bool ForceProxy
		{
			set;
			get;
		}
		public FlavorAssetUrlOptions Options
		{
			set;
			get;
		}

		public FlavorAssetGetUrlRequestBuilder()
			: base("flavorasset", "getUrl")
		{
		}

		public FlavorAssetGetUrlRequestBuilder(string id, int storageId, bool forceProxy, FlavorAssetUrlOptions options)
			: this()
		{
			this.Id = id;
			this.StorageId = storageId;
			this.ForceProxy = forceProxy;
			this.Options = options;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("storageId"))
				kparams.AddIfNotNull("storageId", StorageId);
			if (!isMapped("forceProxy"))
				kparams.AddIfNotNull("forceProxy", ForceProxy);
			if (!isMapped("options"))
				kparams.AddIfNotNull("options", Options);
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

	public class FlavorAssetGetWebPlayableByEntryIdRequestBuilder : RequestBuilder<IList<FlavorAsset>>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

		public FlavorAssetGetWebPlayableByEntryIdRequestBuilder()
			: base("flavorasset", "getWebPlayableByEntryId")
		{
		}

		public FlavorAssetGetWebPlayableByEntryIdRequestBuilder(string entryId)
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
			IList<FlavorAsset> list = new List<FlavorAsset>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add(ObjectFactory.Create<FlavorAsset>(node));
			}
			return list;
		}
	}

	public class FlavorAssetListRequestBuilder : RequestBuilder<ListResponse<FlavorAsset>>
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

		public FlavorAssetListRequestBuilder()
			: base("flavorasset", "list")
		{
		}

		public FlavorAssetListRequestBuilder(AssetFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<FlavorAsset>>(result);
		}
	}

	public class FlavorAssetReconvertRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public FlavorAssetReconvertRequestBuilder()
			: base("flavorasset", "reconvert")
		{
		}

		public FlavorAssetReconvertRequestBuilder(string id)
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

	public class FlavorAssetServeAdStitchCmdRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string FFPROBE_JSON = "ffprobeJson";
		public const string DURATION = "duration";
		#endregion

		public string AssetId
		{
			set;
			get;
		}
		public string FfprobeJson
		{
			set;
			get;
		}
		public string Duration
		{
			set;
			get;
		}

		public FlavorAssetServeAdStitchCmdRequestBuilder()
			: base("flavorasset", "serveAdStitchCmd")
		{
		}

		public FlavorAssetServeAdStitchCmdRequestBuilder(string assetId, string ffprobeJson, string duration)
			: this()
		{
			this.AssetId = assetId;
			this.FfprobeJson = ffprobeJson;
			this.Duration = duration;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
			if (!isMapped("ffprobeJson"))
				kparams.AddIfNotNull("ffprobeJson", FfprobeJson);
			if (!isMapped("duration"))
				kparams.AddIfNotNull("duration", Duration);
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

	public class FlavorAssetSetAsSourceRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		#endregion

		public string AssetId
		{
			set;
			get;
		}

		public FlavorAssetSetAsSourceRequestBuilder()
			: base("flavorasset", "setAsSource")
		{
		}

		public FlavorAssetSetAsSourceRequestBuilder(string assetId)
			: this()
		{
			this.AssetId = assetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetId"))
				kparams.AddIfNotNull("assetId", AssetId);
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

	public class FlavorAssetSetContentRequestBuilder : RequestBuilder<FlavorAsset>
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

		public FlavorAssetSetContentRequestBuilder()
			: base("flavorasset", "setContent")
		{
		}

		public FlavorAssetSetContentRequestBuilder(string id, ContentResource contentResource)
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
			return ObjectFactory.Create<FlavorAsset>(result);
		}
	}

	public class FlavorAssetUpdateRequestBuilder : RequestBuilder<FlavorAsset>
	{
		#region Constants
		public const string ID = "id";
		public const string FLAVOR_ASSET = "flavorAsset";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public FlavorAsset FlavorAsset
		{
			set;
			get;
		}

		public FlavorAssetUpdateRequestBuilder()
			: base("flavorasset", "update")
		{
		}

		public FlavorAssetUpdateRequestBuilder(string id, FlavorAsset flavorAsset)
			: this()
		{
			this.Id = id;
			this.FlavorAsset = flavorAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("flavorAsset"))
				kparams.AddIfNotNull("flavorAsset", FlavorAsset);
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


	public class FlavorAssetService
	{
		private FlavorAssetService()
		{
		}

		public static FlavorAssetAddRequestBuilder Add(string entryId, FlavorAsset flavorAsset)
		{
			return new FlavorAssetAddRequestBuilder(entryId, flavorAsset);
		}

		public static FlavorAssetConvertRequestBuilder Convert(string entryId, int flavorParamsId, int priority = 0)
		{
			return new FlavorAssetConvertRequestBuilder(entryId, flavorParamsId, priority);
		}

		public static FlavorAssetDeleteRequestBuilder Delete(string id)
		{
			return new FlavorAssetDeleteRequestBuilder(id);
		}

		public static FlavorAssetDeleteLocalContentRequestBuilder DeleteLocalContent(string assetId)
		{
			return new FlavorAssetDeleteLocalContentRequestBuilder(assetId);
		}

		public static FlavorAssetExportRequestBuilder Export(string assetId, int storageProfileId)
		{
			return new FlavorAssetExportRequestBuilder(assetId, storageProfileId);
		}

		public static FlavorAssetGetRequestBuilder Get(string id)
		{
			return new FlavorAssetGetRequestBuilder(id);
		}

		public static FlavorAssetGetByEntryIdRequestBuilder GetByEntryId(string entryId)
		{
			return new FlavorAssetGetByEntryIdRequestBuilder(entryId);
		}

		public static FlavorAssetGetDownloadUrlRequestBuilder GetDownloadUrl(string id, bool useCdn = false)
		{
			return new FlavorAssetGetDownloadUrlRequestBuilder(id, useCdn);
		}

		public static FlavorAssetGetFlavorAssetsWithParamsRequestBuilder GetFlavorAssetsWithParams(string entryId)
		{
			return new FlavorAssetGetFlavorAssetsWithParamsRequestBuilder(entryId);
		}

		public static FlavorAssetGetRemotePathsRequestBuilder GetRemotePaths(string id)
		{
			return new FlavorAssetGetRemotePathsRequestBuilder(id);
		}

		public static FlavorAssetGetUrlRequestBuilder GetUrl(string id, int storageId = Int32.MinValue, bool forceProxy = false, FlavorAssetUrlOptions options = null)
		{
			return new FlavorAssetGetUrlRequestBuilder(id, storageId, forceProxy, options);
		}

		public static FlavorAssetGetWebPlayableByEntryIdRequestBuilder GetWebPlayableByEntryId(string entryId)
		{
			return new FlavorAssetGetWebPlayableByEntryIdRequestBuilder(entryId);
		}

		public static FlavorAssetListRequestBuilder List(AssetFilter filter = null, FilterPager pager = null)
		{
			return new FlavorAssetListRequestBuilder(filter, pager);
		}

		public static FlavorAssetReconvertRequestBuilder Reconvert(string id)
		{
			return new FlavorAssetReconvertRequestBuilder(id);
		}

		public static FlavorAssetServeAdStitchCmdRequestBuilder ServeAdStitchCmd(string assetId, string ffprobeJson = null, string duration = null)
		{
			return new FlavorAssetServeAdStitchCmdRequestBuilder(assetId, ffprobeJson, duration);
		}

		public static FlavorAssetSetAsSourceRequestBuilder SetAsSource(string assetId)
		{
			return new FlavorAssetSetAsSourceRequestBuilder(assetId);
		}

		public static FlavorAssetSetContentRequestBuilder SetContent(string id, ContentResource contentResource)
		{
			return new FlavorAssetSetContentRequestBuilder(id, contentResource);
		}

		public static FlavorAssetUpdateRequestBuilder Update(string id, FlavorAsset flavorAsset)
		{
			return new FlavorAssetUpdateRequestBuilder(id, flavorAsset);
		}
	}
}
