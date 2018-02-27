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
	public class MetadataAddRequestBuilder : RequestBuilder<Metadata>
	{
		#region Constants
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string OBJECT_TYPE = "objectType";
		public const string OBJECT_ID = "objectId";
		public const string XML_DATA = "xmlData";
		#endregion

		public int MetadataProfileId
		{
			set;
			get;
		}
		public MetadataObjectType ObjectType
		{
			set;
			get;
		}
		public string ObjectId
		{
			set;
			get;
		}
		public string XmlData
		{
			set;
			get;
		}

		public MetadataAddRequestBuilder()
			: base("metadata_metadata", "add")
		{
		}

		public MetadataAddRequestBuilder(int metadataProfileId, MetadataObjectType objectType, string objectId, string xmlData)
			: this()
		{
			this.MetadataProfileId = metadataProfileId;
			this.ObjectType = objectType;
			this.ObjectId = objectId;
			this.XmlData = xmlData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("metadataProfileId"))
				kparams.AddIfNotNull("metadataProfileId", MetadataProfileId);
			if (!isMapped("objectType"))
				kparams.AddIfNotNull("objectType", ObjectType);
			if (!isMapped("objectId"))
				kparams.AddIfNotNull("objectId", ObjectId);
			if (!isMapped("xmlData"))
				kparams.AddIfNotNull("xmlData", XmlData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Metadata>(result);
		}
	}

	public class MetadataAddFromBulkRequestBuilder : RequestBuilder<Metadata>
	{
		#region Constants
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string OBJECT_TYPE = "objectType";
		public const string OBJECT_ID = "objectId";
		public const string URL = "url";
		#endregion

		public int MetadataProfileId
		{
			set;
			get;
		}
		public MetadataObjectType ObjectType
		{
			set;
			get;
		}
		public string ObjectId
		{
			set;
			get;
		}
		public string Url
		{
			set;
			get;
		}

		public MetadataAddFromBulkRequestBuilder()
			: base("metadata_metadata", "addFromBulk")
		{
		}

		public MetadataAddFromBulkRequestBuilder(int metadataProfileId, MetadataObjectType objectType, string objectId, string url)
			: this()
		{
			this.MetadataProfileId = metadataProfileId;
			this.ObjectType = objectType;
			this.ObjectId = objectId;
			this.Url = url;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("metadataProfileId"))
				kparams.AddIfNotNull("metadataProfileId", MetadataProfileId);
			if (!isMapped("objectType"))
				kparams.AddIfNotNull("objectType", ObjectType);
			if (!isMapped("objectId"))
				kparams.AddIfNotNull("objectId", ObjectId);
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
			return ObjectFactory.Create<Metadata>(result);
		}
	}

	public class MetadataAddFromFileRequestBuilder : RequestBuilder<Metadata>
	{
		#region Constants
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string OBJECT_TYPE = "objectType";
		public const string OBJECT_ID = "objectId";
		public const string XML_FILE = "xmlFile";
		#endregion

		public int MetadataProfileId
		{
			set;
			get;
		}
		public MetadataObjectType ObjectType
		{
			set;
			get;
		}
		public string ObjectId
		{
			set;
			get;
		}
		public Stream XmlFile
		{
			set;
			get;
		}

		public MetadataAddFromFileRequestBuilder()
			: base("metadata_metadata", "addFromFile")
		{
		}

		public MetadataAddFromFileRequestBuilder(int metadataProfileId, MetadataObjectType objectType, string objectId, Stream xmlFile)
			: this()
		{
			this.MetadataProfileId = metadataProfileId;
			this.ObjectType = objectType;
			this.ObjectId = objectId;
			this.XmlFile = xmlFile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("metadataProfileId"))
				kparams.AddIfNotNull("metadataProfileId", MetadataProfileId);
			if (!isMapped("objectType"))
				kparams.AddIfNotNull("objectType", ObjectType);
			if (!isMapped("objectId"))
				kparams.AddIfNotNull("objectId", ObjectId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("xmlFile", XmlFile);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Metadata>(result);
		}
	}

	public class MetadataAddFromUrlRequestBuilder : RequestBuilder<Metadata>
	{
		#region Constants
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string OBJECT_TYPE = "objectType";
		public const string OBJECT_ID = "objectId";
		public const string URL = "url";
		#endregion

		public int MetadataProfileId
		{
			set;
			get;
		}
		public MetadataObjectType ObjectType
		{
			set;
			get;
		}
		public string ObjectId
		{
			set;
			get;
		}
		public string Url
		{
			set;
			get;
		}

		public MetadataAddFromUrlRequestBuilder()
			: base("metadata_metadata", "addFromUrl")
		{
		}

		public MetadataAddFromUrlRequestBuilder(int metadataProfileId, MetadataObjectType objectType, string objectId, string url)
			: this()
		{
			this.MetadataProfileId = metadataProfileId;
			this.ObjectType = objectType;
			this.ObjectId = objectId;
			this.Url = url;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("metadataProfileId"))
				kparams.AddIfNotNull("metadataProfileId", MetadataProfileId);
			if (!isMapped("objectType"))
				kparams.AddIfNotNull("objectType", ObjectType);
			if (!isMapped("objectId"))
				kparams.AddIfNotNull("objectId", ObjectId);
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
			return ObjectFactory.Create<Metadata>(result);
		}
	}

	public class MetadataDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public MetadataDeleteRequestBuilder()
			: base("metadata_metadata", "delete")
		{
		}

		public MetadataDeleteRequestBuilder(int id)
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

	public class MetadataGetRequestBuilder : RequestBuilder<Metadata>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public MetadataGetRequestBuilder()
			: base("metadata_metadata", "get")
		{
		}

		public MetadataGetRequestBuilder(int id)
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
			return ObjectFactory.Create<Metadata>(result);
		}
	}

	public class MetadataIndexRequestBuilder : RequestBuilder<int>
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

		public MetadataIndexRequestBuilder()
			: base("metadata_metadata", "index")
		{
		}

		public MetadataIndexRequestBuilder(string id, bool shouldUpdate)
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

	public class MetadataInvalidateRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		public const string VERSION = "version";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public int Version
		{
			set;
			get;
		}

		public MetadataInvalidateRequestBuilder()
			: base("metadata_metadata", "invalidate")
		{
		}

		public MetadataInvalidateRequestBuilder(int id, int version)
			: this()
		{
			this.Id = id;
			this.Version = version;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
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
			return null;
		}
	}

	public class MetadataListRequestBuilder : RequestBuilder<ListResponse<Metadata>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public MetadataFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public MetadataListRequestBuilder()
			: base("metadata_metadata", "list")
		{
		}

		public MetadataListRequestBuilder(MetadataFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<Metadata>>(result);
		}
	}

	public class MetadataUpdateRequestBuilder : RequestBuilder<Metadata>
	{
		#region Constants
		public const string ID = "id";
		public const string XML_DATA = "xmlData";
		public const string VERSION = "version";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public string XmlData
		{
			set;
			get;
		}
		public int Version
		{
			set;
			get;
		}

		public MetadataUpdateRequestBuilder()
			: base("metadata_metadata", "update")
		{
		}

		public MetadataUpdateRequestBuilder(int id, string xmlData, int version)
			: this()
		{
			this.Id = id;
			this.XmlData = xmlData;
			this.Version = version;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("xmlData"))
				kparams.AddIfNotNull("xmlData", XmlData);
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
			return ObjectFactory.Create<Metadata>(result);
		}
	}

	public class MetadataUpdateFromFileRequestBuilder : RequestBuilder<Metadata>
	{
		#region Constants
		public const string ID = "id";
		public const string XML_FILE = "xmlFile";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public Stream XmlFile
		{
			set;
			get;
		}

		public MetadataUpdateFromFileRequestBuilder()
			: base("metadata_metadata", "updateFromFile")
		{
		}

		public MetadataUpdateFromFileRequestBuilder(int id, Stream xmlFile)
			: this()
		{
			this.Id = id;
			this.XmlFile = xmlFile;
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
			kfiles.Add("xmlFile", XmlFile);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Metadata>(result);
		}
	}

	public class MetadataUpdateFromXSLRequestBuilder : RequestBuilder<Metadata>
	{
		#region Constants
		public const string ID = "id";
		public const string XSL_FILE = "xslFile";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public Stream XslFile
		{
			set;
			get;
		}

		public MetadataUpdateFromXSLRequestBuilder()
			: base("metadata_metadata", "updateFromXSL")
		{
		}

		public MetadataUpdateFromXSLRequestBuilder(int id, Stream xslFile)
			: this()
		{
			this.Id = id;
			this.XslFile = xslFile;
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
			kfiles.Add("xslFile", XslFile);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<Metadata>(result);
		}
	}


	public class MetadataService
	{
		private MetadataService()
		{
		}

		public static MetadataAddRequestBuilder Add(int metadataProfileId, MetadataObjectType objectType, string objectId, string xmlData)
		{
			return new MetadataAddRequestBuilder(metadataProfileId, objectType, objectId, xmlData);
		}

		public static MetadataAddFromBulkRequestBuilder AddFromBulk(int metadataProfileId, MetadataObjectType objectType, string objectId, string url)
		{
			return new MetadataAddFromBulkRequestBuilder(metadataProfileId, objectType, objectId, url);
		}

		public static MetadataAddFromFileRequestBuilder AddFromFile(int metadataProfileId, MetadataObjectType objectType, string objectId, Stream xmlFile)
		{
			return new MetadataAddFromFileRequestBuilder(metadataProfileId, objectType, objectId, xmlFile);
		}

		public static MetadataAddFromUrlRequestBuilder AddFromUrl(int metadataProfileId, MetadataObjectType objectType, string objectId, string url)
		{
			return new MetadataAddFromUrlRequestBuilder(metadataProfileId, objectType, objectId, url);
		}

		public static MetadataDeleteRequestBuilder Delete(int id)
		{
			return new MetadataDeleteRequestBuilder(id);
		}

		public static MetadataGetRequestBuilder Get(int id)
		{
			return new MetadataGetRequestBuilder(id);
		}

		public static MetadataIndexRequestBuilder Index(string id, bool shouldUpdate)
		{
			return new MetadataIndexRequestBuilder(id, shouldUpdate);
		}

		public static MetadataInvalidateRequestBuilder Invalidate(int id, int version = Int32.MinValue)
		{
			return new MetadataInvalidateRequestBuilder(id, version);
		}

		public static MetadataListRequestBuilder List(MetadataFilter filter = null, FilterPager pager = null)
		{
			return new MetadataListRequestBuilder(filter, pager);
		}

		public static MetadataUpdateRequestBuilder Update(int id, string xmlData = null, int version = Int32.MinValue)
		{
			return new MetadataUpdateRequestBuilder(id, xmlData, version);
		}

		public static MetadataUpdateFromFileRequestBuilder UpdateFromFile(int id, Stream xmlFile = null)
		{
			return new MetadataUpdateFromFileRequestBuilder(id, xmlFile);
		}

		public static MetadataUpdateFromXSLRequestBuilder UpdateFromXSL(int id, Stream xslFile)
		{
			return new MetadataUpdateFromXSLRequestBuilder(id, xslFile);
		}
	}
}
