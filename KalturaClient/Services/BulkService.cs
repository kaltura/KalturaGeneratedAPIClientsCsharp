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
	public class BulkAbortRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public BulkAbortRequestBuilder()
			: base("bulkupload_bulk", "abort")
		{
		}

		public BulkAbortRequestBuilder(int id)
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
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class BulkGetRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public BulkGetRequestBuilder()
			: base("bulkupload_bulk", "get")
		{
		}

		public BulkGetRequestBuilder(int id)
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
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class BulkListRequestBuilder : RequestBuilder<ListResponse<BulkUpload>>
	{
		#region Constants
		public const string BULK_UPLOAD_FILTER = "bulkUploadFilter";
		public const string PAGER = "pager";
		#endregion

		public BulkUploadFilter BulkUploadFilter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public BulkListRequestBuilder()
			: base("bulkupload_bulk", "list")
		{
		}

		public BulkListRequestBuilder(BulkUploadFilter bulkUploadFilter, FilterPager pager)
			: this()
		{
			this.BulkUploadFilter = bulkUploadFilter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("bulkUploadFilter"))
				kparams.AddIfNotNull("bulkUploadFilter", BulkUploadFilter);
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
			return ObjectFactory.Create<ListResponse<BulkUpload>>(result);
		}
	}


	public class BulkService
	{
		private BulkService()
		{
		}

		public static BulkAbortRequestBuilder Abort(int id)
		{
			return new BulkAbortRequestBuilder(id);
		}

		public static BulkGetRequestBuilder Get(int id)
		{
			return new BulkGetRequestBuilder(id);
		}

		public static BulkListRequestBuilder List(BulkUploadFilter bulkUploadFilter = null, FilterPager pager = null)
		{
			return new BulkListRequestBuilder(bulkUploadFilter, pager);
		}
	}
}
