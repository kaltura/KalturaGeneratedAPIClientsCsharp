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
	public class CuePointAddRequestBuilder : RequestBuilder<CuePoint>
	{
		#region Constants
		public const string CUE_POINT = "cuePoint";
		#endregion

		public CuePoint CuePoint
		{
			set;
			get;
		}

		public CuePointAddRequestBuilder()
			: base("cuepoint_cuepoint", "add")
		{
		}

		public CuePointAddRequestBuilder(CuePoint cuePoint)
			: this()
		{
			this.CuePoint = cuePoint;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("cuePoint"))
				kparams.AddIfNotNull("cuePoint", CuePoint);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<CuePoint>(result);
		}
	}

	public class CuePointAddFromBulkRequestBuilder : RequestBuilder<ListResponse<CuePoint>>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		#endregion

		public Stream FileData
		{
			set;
			get;
		}

		public CuePointAddFromBulkRequestBuilder()
			: base("cuepoint_cuepoint", "addFromBulk")
		{
		}

		public CuePointAddFromBulkRequestBuilder(Stream fileData)
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
			return ObjectFactory.Create<ListResponse<CuePoint>>(result);
		}
	}

	public class CuePointCloneRequestBuilder : RequestBuilder<CuePoint>
	{
		#region Constants
		public const string ID = "id";
		public const string ENTRY_ID = "entryId";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public string EntryId
		{
			set;
			get;
		}

		public CuePointCloneRequestBuilder()
			: base("cuepoint_cuepoint", "clone")
		{
		}

		public CuePointCloneRequestBuilder(string id, string entryId)
			: this()
		{
			this.Id = id;
			this.EntryId = entryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
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
			return ObjectFactory.Create<CuePoint>(result);
		}
	}

	public class CuePointCountRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public CuePointFilter Filter
		{
			set;
			get;
		}

		public CuePointCountRequestBuilder()
			: base("cuepoint_cuepoint", "count")
		{
		}

		public CuePointCountRequestBuilder(CuePointFilter filter)
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

	public class CuePointDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public CuePointDeleteRequestBuilder()
			: base("cuepoint_cuepoint", "delete")
		{
		}

		public CuePointDeleteRequestBuilder(string id)
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

	public class CuePointGetRequestBuilder : RequestBuilder<CuePoint>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public CuePointGetRequestBuilder()
			: base("cuepoint_cuepoint", "get")
		{
		}

		public CuePointGetRequestBuilder(string id)
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
			return ObjectFactory.Create<CuePoint>(result);
		}
	}

	public class CuePointListRequestBuilder : RequestBuilder<ListResponse<CuePoint>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public CuePointFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public CuePointListRequestBuilder()
			: base("cuepoint_cuepoint", "list")
		{
		}

		public CuePointListRequestBuilder(CuePointFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<CuePoint>>(result);
		}
	}

	public class CuePointUpdateRequestBuilder : RequestBuilder<CuePoint>
	{
		#region Constants
		public const string ID = "id";
		public const string CUE_POINT = "cuePoint";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public CuePoint CuePoint
		{
			set;
			get;
		}

		public CuePointUpdateRequestBuilder()
			: base("cuepoint_cuepoint", "update")
		{
		}

		public CuePointUpdateRequestBuilder(string id, CuePoint cuePoint)
			: this()
		{
			this.Id = id;
			this.CuePoint = cuePoint;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("cuePoint"))
				kparams.AddIfNotNull("cuePoint", CuePoint);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<CuePoint>(result);
		}
	}

	public class CuePointUpdateStatusRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		public const string STATUS = "status";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public CuePointStatus Status
		{
			set;
			get;
		}

		public CuePointUpdateStatusRequestBuilder()
			: base("cuepoint_cuepoint", "updateStatus")
		{
		}

		public CuePointUpdateStatusRequestBuilder(string id, CuePointStatus status)
			: this()
		{
			this.Id = id;
			this.Status = status;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("status"))
				kparams.AddIfNotNull("status", Status);
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


	public class CuePointService
	{
		private CuePointService()
		{
		}

		public static CuePointAddRequestBuilder Add(CuePoint cuePoint)
		{
			return new CuePointAddRequestBuilder(cuePoint);
		}

		public static CuePointAddFromBulkRequestBuilder AddFromBulk(Stream fileData)
		{
			return new CuePointAddFromBulkRequestBuilder(fileData);
		}

		public static CuePointCloneRequestBuilder Clone(string id, string entryId)
		{
			return new CuePointCloneRequestBuilder(id, entryId);
		}

		public static CuePointCountRequestBuilder Count(CuePointFilter filter = null)
		{
			return new CuePointCountRequestBuilder(filter);
		}

		public static CuePointDeleteRequestBuilder Delete(string id)
		{
			return new CuePointDeleteRequestBuilder(id);
		}

		public static CuePointGetRequestBuilder Get(string id)
		{
			return new CuePointGetRequestBuilder(id);
		}

		public static CuePointListRequestBuilder List(CuePointFilter filter = null, FilterPager pager = null)
		{
			return new CuePointListRequestBuilder(filter, pager);
		}

		public static CuePointUpdateRequestBuilder Update(string id, CuePoint cuePoint)
		{
			return new CuePointUpdateRequestBuilder(id, cuePoint);
		}

		public static CuePointUpdateStatusRequestBuilder UpdateStatus(string id, CuePointStatus status)
		{
			return new CuePointUpdateStatusRequestBuilder(id, status);
		}
	}
}
