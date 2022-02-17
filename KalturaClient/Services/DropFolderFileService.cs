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
	public class DropFolderFileAddRequestBuilder : RequestBuilder<DropFolderFile>
	{
		#region Constants
		public const string DROP_FOLDER_FILE = "dropFolderFile";
		#endregion

		public DropFolderFile DropFolderFile { get; set; }

		public DropFolderFileAddRequestBuilder()
			: base("dropfolder_dropfolderfile", "add")
		{
		}

		public DropFolderFileAddRequestBuilder(DropFolderFile dropFolderFile)
			: this()
		{
			this.DropFolderFile = dropFolderFile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dropFolderFile"))
				kparams.AddIfNotNull("dropFolderFile", DropFolderFile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DropFolderFile>(result);
		}
	}

	public class DropFolderFileDeleteRequestBuilder : RequestBuilder<DropFolderFile>
	{
		#region Constants
		public const string DROP_FOLDER_FILE_ID = "dropFolderFileId";
		#endregion

		public int DropFolderFileId { get; set; }

		public DropFolderFileDeleteRequestBuilder()
			: base("dropfolder_dropfolderfile", "delete")
		{
		}

		public DropFolderFileDeleteRequestBuilder(int dropFolderFileId)
			: this()
		{
			this.DropFolderFileId = dropFolderFileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dropFolderFileId"))
				kparams.AddIfNotNull("dropFolderFileId", DropFolderFileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DropFolderFile>(result);
		}
	}

	public class DropFolderFileGetRequestBuilder : RequestBuilder<DropFolderFile>
	{
		#region Constants
		public const string DROP_FOLDER_FILE_ID = "dropFolderFileId";
		#endregion

		public int DropFolderFileId { get; set; }

		public DropFolderFileGetRequestBuilder()
			: base("dropfolder_dropfolderfile", "get")
		{
		}

		public DropFolderFileGetRequestBuilder(int dropFolderFileId)
			: this()
		{
			this.DropFolderFileId = dropFolderFileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dropFolderFileId"))
				kparams.AddIfNotNull("dropFolderFileId", DropFolderFileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DropFolderFile>(result);
		}
	}

	public class DropFolderFileIgnoreRequestBuilder : RequestBuilder<DropFolderFile>
	{
		#region Constants
		public const string DROP_FOLDER_FILE_ID = "dropFolderFileId";
		#endregion

		public int DropFolderFileId { get; set; }

		public DropFolderFileIgnoreRequestBuilder()
			: base("dropfolder_dropfolderfile", "ignore")
		{
		}

		public DropFolderFileIgnoreRequestBuilder(int dropFolderFileId)
			: this()
		{
			this.DropFolderFileId = dropFolderFileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dropFolderFileId"))
				kparams.AddIfNotNull("dropFolderFileId", DropFolderFileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DropFolderFile>(result);
		}
	}

	public class DropFolderFileListRequestBuilder : RequestBuilder<ListResponse<DropFolderFile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public DropFolderFileFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public DropFolderFileListRequestBuilder()
			: base("dropfolder_dropfolderfile", "list")
		{
		}

		public DropFolderFileListRequestBuilder(DropFolderFileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<DropFolderFile>>(result);
		}
	}

	public class DropFolderFileUpdateRequestBuilder : RequestBuilder<DropFolderFile>
	{
		#region Constants
		public const string DROP_FOLDER_FILE_ID = "dropFolderFileId";
		public const string DROP_FOLDER_FILE = "dropFolderFile";
		#endregion

		public int DropFolderFileId { get; set; }
		public DropFolderFile DropFolderFile { get; set; }

		public DropFolderFileUpdateRequestBuilder()
			: base("dropfolder_dropfolderfile", "update")
		{
		}

		public DropFolderFileUpdateRequestBuilder(int dropFolderFileId, DropFolderFile dropFolderFile)
			: this()
		{
			this.DropFolderFileId = dropFolderFileId;
			this.DropFolderFile = dropFolderFile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dropFolderFileId"))
				kparams.AddIfNotNull("dropFolderFileId", DropFolderFileId);
			if (!isMapped("dropFolderFile"))
				kparams.AddIfNotNull("dropFolderFile", DropFolderFile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DropFolderFile>(result);
		}
	}

	public class DropFolderFileUpdateStatusRequestBuilder : RequestBuilder<DropFolderFile>
	{
		#region Constants
		public const string DROP_FOLDER_FILE_ID = "dropFolderFileId";
		public const string STATUS = "status";
		#endregion

		public int DropFolderFileId { get; set; }
		public DropFolderFileStatus Status { get; set; }

		public DropFolderFileUpdateStatusRequestBuilder()
			: base("dropfolder_dropfolderfile", "updateStatus")
		{
		}

		public DropFolderFileUpdateStatusRequestBuilder(int dropFolderFileId, DropFolderFileStatus status)
			: this()
		{
			this.DropFolderFileId = dropFolderFileId;
			this.Status = status;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dropFolderFileId"))
				kparams.AddIfNotNull("dropFolderFileId", DropFolderFileId);
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
			return ObjectFactory.Create<DropFolderFile>(result);
		}
	}


	public class DropFolderFileService
	{
		private DropFolderFileService()
		{
		}

		public static DropFolderFileAddRequestBuilder Add(DropFolderFile dropFolderFile)
		{
			return new DropFolderFileAddRequestBuilder(dropFolderFile);
		}

		public static DropFolderFileDeleteRequestBuilder Delete(int dropFolderFileId)
		{
			return new DropFolderFileDeleteRequestBuilder(dropFolderFileId);
		}

		public static DropFolderFileGetRequestBuilder Get(int dropFolderFileId)
		{
			return new DropFolderFileGetRequestBuilder(dropFolderFileId);
		}

		public static DropFolderFileIgnoreRequestBuilder Ignore(int dropFolderFileId)
		{
			return new DropFolderFileIgnoreRequestBuilder(dropFolderFileId);
		}

		public static DropFolderFileListRequestBuilder List(DropFolderFileFilter filter = null, FilterPager pager = null)
		{
			return new DropFolderFileListRequestBuilder(filter, pager);
		}

		public static DropFolderFileUpdateRequestBuilder Update(int dropFolderFileId, DropFolderFile dropFolderFile)
		{
			return new DropFolderFileUpdateRequestBuilder(dropFolderFileId, dropFolderFile);
		}

		public static DropFolderFileUpdateStatusRequestBuilder UpdateStatus(int dropFolderFileId, DropFolderFileStatus status)
		{
			return new DropFolderFileUpdateStatusRequestBuilder(dropFolderFileId, status);
		}
	}
}
