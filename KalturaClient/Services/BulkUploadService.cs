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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class BulkUploadAbortRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public BulkUploadAbortRequestBuilder()
			: base("bulkupload", "abort")
		{
		}

		public BulkUploadAbortRequestBuilder(long id)
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
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class BulkUploadAddRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string CSV_FILE_DATA = "csvFileData";
		public const string BULK_UPLOAD_TYPE = "bulkUploadType";
		public const string UPLOADED_BY = "uploadedBy";
		public const string FILE_NAME = "fileName";
		#endregion

		public int ConversionProfileId { get; set; }
		public Stream CsvFileData { get; set; }
		public string CsvFileData_FileName { get; set; }
		public BulkUploadType BulkUploadType { get; set; }
		public string UploadedBy { get; set; }
		public string FileName { get; set; }

		public BulkUploadAddRequestBuilder()
			: base("bulkupload", "add")
		{
		}

		public BulkUploadAddRequestBuilder(int conversionProfileId, Stream csvFileData, BulkUploadType bulkUploadType, string uploadedBy, string fileName)
			: this()
		{
			this.ConversionProfileId = conversionProfileId;
			this.CsvFileData = csvFileData;
			this.BulkUploadType = bulkUploadType;
			this.UploadedBy = uploadedBy;
			this.FileName = fileName;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("conversionProfileId"))
				kparams.AddIfNotNull("conversionProfileId", ConversionProfileId);
			if (!isMapped("bulkUploadType"))
				kparams.AddIfNotNull("bulkUploadType", BulkUploadType);
			if (!isMapped("uploadedBy"))
				kparams.AddIfNotNull("uploadedBy", UploadedBy);
			if (!isMapped("fileName"))
				kparams.AddIfNotNull("fileName", FileName);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("csvFileData", new FileData(CsvFileData, CsvFileData_FileName));
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class BulkUploadGetRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public long Id { get; set; }

		public BulkUploadGetRequestBuilder()
			: base("bulkupload", "get")
		{
		}

		public BulkUploadGetRequestBuilder(long id)
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
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class BulkUploadListRequestBuilder : RequestBuilder<ListResponse<BulkUpload>>
	{
		#region Constants
		public const string PAGER = "pager";
		#endregion

		public FilterPager Pager { get; set; }

		public BulkUploadListRequestBuilder()
			: base("bulkupload", "list")
		{
		}

		public BulkUploadListRequestBuilder(FilterPager pager)
			: this()
		{
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
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
			return ObjectFactory.Create<ListResponse<BulkUpload>>(result);
		}
	}


	public class BulkUploadService
	{
		private BulkUploadService()
		{
		}

		public static BulkUploadAbortRequestBuilder Abort(long id)
		{
			return new BulkUploadAbortRequestBuilder(id);
		}

		public static BulkUploadAddRequestBuilder Add(int conversionProfileId, Stream csvFileData, BulkUploadType bulkUploadType = null, string uploadedBy = null, string fileName = null)
		{
			return new BulkUploadAddRequestBuilder(conversionProfileId, csvFileData, bulkUploadType, uploadedBy, fileName);
		}

		public static BulkUploadGetRequestBuilder Get(long id)
		{
			return new BulkUploadGetRequestBuilder(id);
		}

		public static BulkUploadListRequestBuilder List(FilterPager pager = null)
		{
			return new BulkUploadListRequestBuilder(pager);
		}
	}
}
