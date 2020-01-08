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
	public class UploadGetUploadedFileTokenByFileNameRequestBuilder : RequestBuilder<UploadResponse>
	{
		#region Constants
		public const string FILE_NAME = "fileName";
		#endregion

		public string FileName { get; set; }

		public UploadGetUploadedFileTokenByFileNameRequestBuilder()
			: base("upload", "getUploadedFileTokenByFileName")
		{
		}

		public UploadGetUploadedFileTokenByFileNameRequestBuilder(string fileName)
			: this()
		{
			this.FileName = fileName;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("fileName"))
				kparams.AddIfNotNull("fileName", FileName);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<UploadResponse>(result);
		}
	}

	public class UploadUploadRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string FILE_DATA = "fileData";
		#endregion

		public Stream FileData { get; set; }
		public string FileData_FileName { get; set; }

		public UploadUploadRequestBuilder()
			: base("upload", "upload")
		{
		}

		public UploadUploadRequestBuilder(Stream fileData)
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
			return result.Value<string>();
		}
	}


	public class UploadService
	{
		private UploadService()
		{
		}

		public static UploadGetUploadedFileTokenByFileNameRequestBuilder GetUploadedFileTokenByFileName(string fileName)
		{
			return new UploadGetUploadedFileTokenByFileNameRequestBuilder(fileName);
		}

		public static UploadUploadRequestBuilder Upload(Stream fileData)
		{
			return new UploadUploadRequestBuilder(fileData);
		}
	}
}
