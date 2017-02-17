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
	public class FileAssetAddRequestBuilder : RequestBuilder<FileAsset>
	{
		#region Constants
		public const string FILE_ASSET = "fileAsset";
		#endregion

		public FileAsset FileAsset
		{
			set;
			get;
		}

		public FileAssetAddRequestBuilder()
			: base("fileasset", "add")
		{
		}

		public FileAssetAddRequestBuilder(FileAsset fileAsset)
			: this()
		{
			this.FileAsset = fileAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("fileAsset"))
				kparams.AddIfNotNull("fileAsset", FileAsset);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<FileAsset>(result);
		}
	}

	public class FileAssetDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public FileAssetDeleteRequestBuilder()
			: base("fileasset", "delete")
		{
		}

		public FileAssetDeleteRequestBuilder(int id)
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

	public class FileAssetGetRequestBuilder : RequestBuilder<FileAsset>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public FileAssetGetRequestBuilder()
			: base("fileasset", "get")
		{
		}

		public FileAssetGetRequestBuilder(int id)
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
			return ObjectFactory.Create<FileAsset>(result);
		}
	}

	public class FileAssetListRequestBuilder : RequestBuilder<ListResponse<FileAsset>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public FileAssetFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public FileAssetListRequestBuilder()
			: base("fileasset", "list")
		{
		}

		public FileAssetListRequestBuilder(FileAssetFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<FileAsset>>(result);
		}
	}

	public class FileAssetSetContentRequestBuilder : RequestBuilder<FileAsset>
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

		public FileAssetSetContentRequestBuilder()
			: base("fileasset", "setContent")
		{
		}

		public FileAssetSetContentRequestBuilder(string id, ContentResource contentResource)
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
			return ObjectFactory.Create<FileAsset>(result);
		}
	}

	public class FileAssetUpdateRequestBuilder : RequestBuilder<FileAsset>
	{
		#region Constants
		public const string ID = "id";
		public const string FILE_ASSET = "fileAsset";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public FileAsset FileAsset
		{
			set;
			get;
		}

		public FileAssetUpdateRequestBuilder()
			: base("fileasset", "update")
		{
		}

		public FileAssetUpdateRequestBuilder(int id, FileAsset fileAsset)
			: this()
		{
			this.Id = id;
			this.FileAsset = fileAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("fileAsset"))
				kparams.AddIfNotNull("fileAsset", FileAsset);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<FileAsset>(result);
		}
	}


	public class FileAssetService
	{
		private FileAssetService()
		{
		}

		public static FileAssetAddRequestBuilder Add(FileAsset fileAsset)
		{
			return new FileAssetAddRequestBuilder(fileAsset);
		}

		public static FileAssetDeleteRequestBuilder Delete(int id)
		{
			return new FileAssetDeleteRequestBuilder(id);
		}

		public static FileAssetGetRequestBuilder Get(int id)
		{
			return new FileAssetGetRequestBuilder(id);
		}

		public static FileAssetListRequestBuilder List(FileAssetFilter filter, FilterPager pager = null)
		{
			return new FileAssetListRequestBuilder(filter, pager);
		}

		public static FileAssetSetContentRequestBuilder SetContent(string id, ContentResource contentResource)
		{
			return new FileAssetSetContentRequestBuilder(id, contentResource);
		}

		public static FileAssetUpdateRequestBuilder Update(int id, FileAsset fileAsset)
		{
			return new FileAssetUpdateRequestBuilder(id, fileAsset);
		}
	}
}
