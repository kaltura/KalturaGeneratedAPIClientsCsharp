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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class CuePointAddRequestBuilder : RequestBuilder<CuePoint>
	{
		#region Constants
		public const string CUE_POINT = "cuePoint";
		#endregion

		public CuePoint CuePoint { get; set; }

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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CuePoint>(result);
		}
	}

	public class CuePointAddFromBulkRequestBuilder : RequestBuilder<ListResponse<CuePoint>>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		#endregion

		public Stream FileData { get; set; }
		public string FileData_FileName { get; set; }

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
			kfiles.Add("fileData", new FileData(FileData, FileData_FileName));
			return kfiles;
		}

		public override object Deserialize(JToken result)
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

		public string Id { get; set; }
		public string EntryId { get; set; }

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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CuePoint>(result);
		}
	}

	public class CuePointCountRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public CuePointFilter Filter { get; set; }

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

		public override object Deserialize(JToken result)
		{
			return result.Value<int>();
		}
	}

	public class CuePointDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id { get; set; }

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

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class CuePointGetRequestBuilder : RequestBuilder<CuePoint>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id { get; set; }

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

		public override object Deserialize(JToken result)
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

		public CuePointFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

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

		public override object Deserialize(JToken result)
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

		public string Id { get; set; }
		public CuePoint CuePoint { get; set; }

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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CuePoint>(result);
		}
	}

	public class CuePointUpdateCuePointsTimesRequestBuilder : RequestBuilder<CuePoint>
	{
		#region Constants
		public const string ID = "id";
		public const string START_TIME = "startTime";
		public const string END_TIME = "endTime";
		#endregion

		public string Id { get; set; }
		public int StartTime { get; set; }
		public int EndTime { get; set; }

		public CuePointUpdateCuePointsTimesRequestBuilder()
			: base("cuepoint_cuepoint", "updateCuePointsTimes")
		{
		}

		public CuePointUpdateCuePointsTimesRequestBuilder(string id, int startTime, int endTime)
			: this()
		{
			this.Id = id;
			this.StartTime = startTime;
			this.EndTime = endTime;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("startTime"))
				kparams.AddIfNotNull("startTime", StartTime);
			if (!isMapped("endTime"))
				kparams.AddIfNotNull("endTime", EndTime);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CuePoint>(result);
		}
	}

	public class CuePointUpdateStatusRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		public const string STATUS = "status";
		#endregion

		public string Id { get; set; }
		public CuePointStatus Status { get; set; }

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

		public override object Deserialize(JToken result)
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

		public static CuePointUpdateCuePointsTimesRequestBuilder UpdateCuePointsTimes(string id, int startTime, int endTime = Int32.MinValue)
		{
			return new CuePointUpdateCuePointsTimesRequestBuilder(id, startTime, endTime);
		}

		public static CuePointUpdateStatusRequestBuilder UpdateStatus(string id, CuePointStatus status)
		{
			return new CuePointUpdateStatusRequestBuilder(id, status);
		}
	}
}
