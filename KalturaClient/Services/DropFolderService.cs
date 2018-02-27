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
	public class DropFolderAddRequestBuilder : RequestBuilder<DropFolder>
	{
		#region Constants
		public const string DROP_FOLDER = "dropFolder";
		#endregion

		public DropFolder DropFolder
		{
			set;
			get;
		}

		public DropFolderAddRequestBuilder()
			: base("dropfolder_dropfolder", "add")
		{
		}

		public DropFolderAddRequestBuilder(DropFolder dropFolder)
			: this()
		{
			this.DropFolder = dropFolder;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dropFolder"))
				kparams.AddIfNotNull("dropFolder", DropFolder);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DropFolder>(result);
		}
	}

	public class DropFolderDeleteRequestBuilder : RequestBuilder<DropFolder>
	{
		#region Constants
		public const string DROP_FOLDER_ID = "dropFolderId";
		#endregion

		public int DropFolderId
		{
			set;
			get;
		}

		public DropFolderDeleteRequestBuilder()
			: base("dropfolder_dropfolder", "delete")
		{
		}

		public DropFolderDeleteRequestBuilder(int dropFolderId)
			: this()
		{
			this.DropFolderId = dropFolderId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dropFolderId"))
				kparams.AddIfNotNull("dropFolderId", DropFolderId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DropFolder>(result);
		}
	}

	public class DropFolderFreeExclusiveDropFolderRequestBuilder : RequestBuilder<DropFolder>
	{
		#region Constants
		public const string DROP_FOLDER_ID = "dropFolderId";
		public const string ERROR_CODE = "errorCode";
		public const string ERROR_DESCRIPTION = "errorDescription";
		#endregion

		public int DropFolderId
		{
			set;
			get;
		}
		public string ErrorCode
		{
			set;
			get;
		}
		public string ErrorDescription
		{
			set;
			get;
		}

		public DropFolderFreeExclusiveDropFolderRequestBuilder()
			: base("dropfolder_dropfolder", "freeExclusiveDropFolder")
		{
		}

		public DropFolderFreeExclusiveDropFolderRequestBuilder(int dropFolderId, string errorCode, string errorDescription)
			: this()
		{
			this.DropFolderId = dropFolderId;
			this.ErrorCode = errorCode;
			this.ErrorDescription = errorDescription;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dropFolderId"))
				kparams.AddIfNotNull("dropFolderId", DropFolderId);
			if (!isMapped("errorCode"))
				kparams.AddIfNotNull("errorCode", ErrorCode);
			if (!isMapped("errorDescription"))
				kparams.AddIfNotNull("errorDescription", ErrorDescription);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DropFolder>(result);
		}
	}

	public class DropFolderGetRequestBuilder : RequestBuilder<DropFolder>
	{
		#region Constants
		public const string DROP_FOLDER_ID = "dropFolderId";
		#endregion

		public int DropFolderId
		{
			set;
			get;
		}

		public DropFolderGetRequestBuilder()
			: base("dropfolder_dropfolder", "get")
		{
		}

		public DropFolderGetRequestBuilder(int dropFolderId)
			: this()
		{
			this.DropFolderId = dropFolderId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dropFolderId"))
				kparams.AddIfNotNull("dropFolderId", DropFolderId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DropFolder>(result);
		}
	}

	public class DropFolderGetExclusiveDropFolderRequestBuilder : RequestBuilder<DropFolder>
	{
		#region Constants
		public const string TAG = "tag";
		public const string MAX_TIME = "maxTime";
		#endregion

		public string Tag
		{
			set;
			get;
		}
		public int MaxTime
		{
			set;
			get;
		}

		public DropFolderGetExclusiveDropFolderRequestBuilder()
			: base("dropfolder_dropfolder", "getExclusiveDropFolder")
		{
		}

		public DropFolderGetExclusiveDropFolderRequestBuilder(string tag, int maxTime)
			: this()
		{
			this.Tag = tag;
			this.MaxTime = maxTime;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("tag"))
				kparams.AddIfNotNull("tag", Tag);
			if (!isMapped("maxTime"))
				kparams.AddIfNotNull("maxTime", MaxTime);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DropFolder>(result);
		}
	}

	public class DropFolderListRequestBuilder : RequestBuilder<ListResponse<DropFolder>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public DropFolderFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public DropFolderListRequestBuilder()
			: base("dropfolder_dropfolder", "list")
		{
		}

		public DropFolderListRequestBuilder(DropFolderFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<DropFolder>>(result);
		}
	}

	public class DropFolderUpdateRequestBuilder : RequestBuilder<DropFolder>
	{
		#region Constants
		public const string DROP_FOLDER_ID = "dropFolderId";
		public const string DROP_FOLDER = "dropFolder";
		#endregion

		public int DropFolderId
		{
			set;
			get;
		}
		public DropFolder DropFolder
		{
			set;
			get;
		}

		public DropFolderUpdateRequestBuilder()
			: base("dropfolder_dropfolder", "update")
		{
		}

		public DropFolderUpdateRequestBuilder(int dropFolderId, DropFolder dropFolder)
			: this()
		{
			this.DropFolderId = dropFolderId;
			this.DropFolder = dropFolder;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("dropFolderId"))
				kparams.AddIfNotNull("dropFolderId", DropFolderId);
			if (!isMapped("dropFolder"))
				kparams.AddIfNotNull("dropFolder", DropFolder);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<DropFolder>(result);
		}
	}


	public class DropFolderService
	{
		private DropFolderService()
		{
		}

		public static DropFolderAddRequestBuilder Add(DropFolder dropFolder)
		{
			return new DropFolderAddRequestBuilder(dropFolder);
		}

		public static DropFolderDeleteRequestBuilder Delete(int dropFolderId)
		{
			return new DropFolderDeleteRequestBuilder(dropFolderId);
		}

		public static DropFolderFreeExclusiveDropFolderRequestBuilder FreeExclusiveDropFolder(int dropFolderId, string errorCode = null, string errorDescription = null)
		{
			return new DropFolderFreeExclusiveDropFolderRequestBuilder(dropFolderId, errorCode, errorDescription);
		}

		public static DropFolderGetRequestBuilder Get(int dropFolderId)
		{
			return new DropFolderGetRequestBuilder(dropFolderId);
		}

		public static DropFolderGetExclusiveDropFolderRequestBuilder GetExclusiveDropFolder(string tag, int maxTime)
		{
			return new DropFolderGetExclusiveDropFolderRequestBuilder(tag, maxTime);
		}

		public static DropFolderListRequestBuilder List(DropFolderFilter filter = null, FilterPager pager = null)
		{
			return new DropFolderListRequestBuilder(filter, pager);
		}

		public static DropFolderUpdateRequestBuilder Update(int dropFolderId, DropFolder dropFolder)
		{
			return new DropFolderUpdateRequestBuilder(dropFolderId, dropFolder);
		}
	}
}
