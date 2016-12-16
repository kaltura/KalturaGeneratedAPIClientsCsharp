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
	public class AttachmentAssetAddRequestBuilder : RequestBuilder<AttachmentAsset>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string ATTACHMENT_ASSET = "attachmentAsset";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public AttachmentAsset AttachmentAsset
		{
			set;
			get;
		}

		public AttachmentAssetAddRequestBuilder()
			: base("attachment_attachmentasset", "add")
		{
		}

		public AttachmentAssetAddRequestBuilder(string entryId, AttachmentAsset attachmentAsset)
			: this()
		{
			this.EntryId = entryId;
			this.AttachmentAsset = attachmentAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("attachmentAsset"))
				kparams.AddIfNotNull("attachmentAsset", AttachmentAsset);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<AttachmentAsset>(result);
		}
	}

	public class AttachmentAssetSetContentRequestBuilder : RequestBuilder<AttachmentAsset>
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

		public AttachmentAssetSetContentRequestBuilder()
			: base("attachment_attachmentasset", "setContent")
		{
		}

		public AttachmentAssetSetContentRequestBuilder(string id, ContentResource contentResource)
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
			return ObjectFactory.Create<AttachmentAsset>(result);
		}
	}

	public class AttachmentAssetUpdateRequestBuilder : RequestBuilder<AttachmentAsset>
	{
		#region Constants
		public const string ID = "id";
		public const string ATTACHMENT_ASSET = "attachmentAsset";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public AttachmentAsset AttachmentAsset
		{
			set;
			get;
		}

		public AttachmentAssetUpdateRequestBuilder()
			: base("attachment_attachmentasset", "update")
		{
		}

		public AttachmentAssetUpdateRequestBuilder(string id, AttachmentAsset attachmentAsset)
			: this()
		{
			this.Id = id;
			this.AttachmentAsset = attachmentAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("attachmentAsset"))
				kparams.AddIfNotNull("attachmentAsset", AttachmentAsset);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<AttachmentAsset>(result);
		}
	}

	public class AttachmentAssetGetUrlRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ID = "id";
		public const string STORAGE_ID = "storageId";
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

		public AttachmentAssetGetUrlRequestBuilder()
			: base("attachment_attachmentasset", "getUrl")
		{
		}

		public AttachmentAssetGetUrlRequestBuilder(string id, int storageId)
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

		public override object Deserialize(XmlElement result)
		{
			return result.InnerText;
		}
	}

	public class AttachmentAssetGetRemotePathsRequestBuilder : RequestBuilder<ListResponse<RemotePath>>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public AttachmentAssetGetRemotePathsRequestBuilder()
			: base("attachment_attachmentasset", "getRemotePaths")
		{
		}

		public AttachmentAssetGetRemotePathsRequestBuilder(string id)
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

	public class AttachmentAssetGetRequestBuilder : RequestBuilder<AttachmentAsset>
	{
		#region Constants
		public const string ATTACHMENT_ASSET_ID = "attachmentAssetId";
		#endregion

		public string AttachmentAssetId
		{
			set;
			get;
		}

		public AttachmentAssetGetRequestBuilder()
			: base("attachment_attachmentasset", "get")
		{
		}

		public AttachmentAssetGetRequestBuilder(string attachmentAssetId)
			: this()
		{
			this.AttachmentAssetId = attachmentAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("attachmentAssetId"))
				kparams.AddIfNotNull("attachmentAssetId", AttachmentAssetId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<AttachmentAsset>(result);
		}
	}

	public class AttachmentAssetListRequestBuilder : RequestBuilder<ListResponse<AttachmentAsset>>
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

		public AttachmentAssetListRequestBuilder()
			: base("attachment_attachmentasset", "list")
		{
		}

		public AttachmentAssetListRequestBuilder(AssetFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<AttachmentAsset>>(result);
		}
	}

	public class AttachmentAssetDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ATTACHMENT_ASSET_ID = "attachmentAssetId";
		#endregion

		public string AttachmentAssetId
		{
			set;
			get;
		}

		public AttachmentAssetDeleteRequestBuilder()
			: base("attachment_attachmentasset", "delete")
		{
		}

		public AttachmentAssetDeleteRequestBuilder(string attachmentAssetId)
			: this()
		{
			this.AttachmentAssetId = attachmentAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("attachmentAssetId"))
				kparams.AddIfNotNull("attachmentAssetId", AttachmentAssetId);
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


	public class AttachmentAssetService
	{
		private AttachmentAssetService()
		{
		}

		public static AttachmentAssetAddRequestBuilder Add(string entryId, AttachmentAsset attachmentAsset)
		{
			return new AttachmentAssetAddRequestBuilder(entryId, attachmentAsset);
		}

		public static AttachmentAssetSetContentRequestBuilder SetContent(string id, ContentResource contentResource)
		{
			return new AttachmentAssetSetContentRequestBuilder(id, contentResource);
		}

		public static AttachmentAssetUpdateRequestBuilder Update(string id, AttachmentAsset attachmentAsset)
		{
			return new AttachmentAssetUpdateRequestBuilder(id, attachmentAsset);
		}

		public static AttachmentAssetGetUrlRequestBuilder GetUrl(string id, int storageId = Int32.MinValue)
		{
			return new AttachmentAssetGetUrlRequestBuilder(id, storageId);
		}

		public static AttachmentAssetGetRemotePathsRequestBuilder GetRemotePaths(string id)
		{
			return new AttachmentAssetGetRemotePathsRequestBuilder(id);
		}

		public static AttachmentAssetGetRequestBuilder Get(string attachmentAssetId)
		{
			return new AttachmentAssetGetRequestBuilder(attachmentAssetId);
		}

		public static AttachmentAssetListRequestBuilder List(AssetFilter filter = null, FilterPager pager = null)
		{
			return new AttachmentAssetListRequestBuilder(filter, pager);
		}

		public static AttachmentAssetDeleteRequestBuilder Delete(string attachmentAssetId)
		{
			return new AttachmentAssetDeleteRequestBuilder(attachmentAssetId);
		}
	}
}
