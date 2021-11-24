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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class UploadTokenAddRequestBuilder : RequestBuilder<UploadToken>
	{
		#region Constants
		public const string UPLOAD_TOKEN = "uploadToken";
		#endregion

		public UploadToken UploadToken { get; set; }

		public UploadTokenAddRequestBuilder()
			: base("uploadtoken", "add")
		{
		}

		public UploadTokenAddRequestBuilder(UploadToken uploadToken)
			: this()
		{
			this.UploadToken = uploadToken;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("uploadToken"))
				kparams.AddIfNotNull("uploadToken", UploadToken);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<UploadToken>(result);
		}
	}

	public class UploadTokenDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string UPLOAD_TOKEN_ID = "uploadTokenId";
		#endregion

		public string UploadTokenId { get; set; }

		public UploadTokenDeleteRequestBuilder()
			: base("uploadtoken", "delete")
		{
		}

		public UploadTokenDeleteRequestBuilder(string uploadTokenId)
			: this()
		{
			this.UploadTokenId = uploadTokenId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("uploadTokenId"))
				kparams.AddIfNotNull("uploadTokenId", UploadTokenId);
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

	public class UploadTokenGetRequestBuilder : RequestBuilder<UploadToken>
	{
		#region Constants
		public const string UPLOAD_TOKEN_ID = "uploadTokenId";
		#endregion

		public string UploadTokenId { get; set; }

		public UploadTokenGetRequestBuilder()
			: base("uploadtoken", "get")
		{
		}

		public UploadTokenGetRequestBuilder(string uploadTokenId)
			: this()
		{
			this.UploadTokenId = uploadTokenId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("uploadTokenId"))
				kparams.AddIfNotNull("uploadTokenId", UploadTokenId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<UploadToken>(result);
		}
	}

	public class UploadTokenListRequestBuilder : RequestBuilder<ListResponse<UploadToken>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public UploadTokenFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public UploadTokenListRequestBuilder()
			: base("uploadtoken", "list")
		{
		}

		public UploadTokenListRequestBuilder(UploadTokenFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<UploadToken>>(result);
		}
	}

	public class UploadTokenUploadRequestBuilder : RequestBuilder<UploadToken>
	{
		#region Constants
		public const string UPLOAD_TOKEN_ID = "uploadTokenId";
		public const string FILE_DATA = "fileData";
		public const string RESUME = "resume";
		public const string FINAL_CHUNK = "finalChunk";
		public const string RESUME_AT = "resumeAt";
		#endregion

		public string UploadTokenId { get; set; }
		public Stream FileData { get; set; }
		public string FileData_FileName { get; set; }
		public bool Resume { get; set; }
		public bool FinalChunk { get; set; }
		public double ResumeAt { get; set; }

		public UploadTokenUploadRequestBuilder()
			: base("uploadtoken", "upload")
		{
		}

		public UploadTokenUploadRequestBuilder(string uploadTokenId, Stream fileData, bool resume, bool finalChunk, double resumeAt)
			: this()
		{
			this.UploadTokenId = uploadTokenId;
			this.FileData = fileData;
			this.Resume = resume;
			this.FinalChunk = finalChunk;
			this.ResumeAt = resumeAt;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("uploadTokenId"))
				kparams.AddIfNotNull("uploadTokenId", UploadTokenId);
			if (!isMapped("resume"))
				kparams.AddIfNotNull("resume", Resume);
			if (!isMapped("finalChunk"))
				kparams.AddIfNotNull("finalChunk", FinalChunk);
			if (!isMapped("resumeAt"))
				kparams.AddIfNotNull("resumeAt", ResumeAt);
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
			return ObjectFactory.Create<UploadToken>(result);
		}
	}


	public class UploadTokenService
	{
		private UploadTokenService()
		{
		}

		public static UploadTokenAddRequestBuilder Add(UploadToken uploadToken = null)
		{
			return new UploadTokenAddRequestBuilder(uploadToken);
		}

		public static UploadTokenDeleteRequestBuilder Delete(string uploadTokenId)
		{
			return new UploadTokenDeleteRequestBuilder(uploadTokenId);
		}

		public static UploadTokenGetRequestBuilder Get(string uploadTokenId)
		{
			return new UploadTokenGetRequestBuilder(uploadTokenId);
		}

		public static UploadTokenListRequestBuilder List(UploadTokenFilter filter = null, FilterPager pager = null)
		{
			return new UploadTokenListRequestBuilder(filter, pager);
		}

		public static UploadTokenUploadRequestBuilder Upload(string uploadTokenId, Stream fileData, bool resume = false, bool finalChunk = true, double resumeAt = -1)
		{
			return new UploadTokenUploadRequestBuilder(uploadTokenId, fileData, resume, finalChunk, resumeAt);
		}
	}
}
