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
	public class CaptionParamsAddRequestBuilder : RequestBuilder<CaptionParams>
	{
		#region Constants
		public const string CAPTION_PARAMS = "captionParams";
		#endregion

		public CaptionParams CaptionParams { get; set; }

		public CaptionParamsAddRequestBuilder()
			: base("caption_captionparams", "add")
		{
		}

		public CaptionParamsAddRequestBuilder(CaptionParams captionParams)
			: this()
		{
			this.CaptionParams = captionParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("captionParams"))
				kparams.AddIfNotNull("captionParams", CaptionParams);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CaptionParams>(result);
		}
	}

	public class CaptionParamsDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public CaptionParamsDeleteRequestBuilder()
			: base("caption_captionparams", "delete")
		{
		}

		public CaptionParamsDeleteRequestBuilder(int id)
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

	public class CaptionParamsGetRequestBuilder : RequestBuilder<CaptionParams>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public CaptionParamsGetRequestBuilder()
			: base("caption_captionparams", "get")
		{
		}

		public CaptionParamsGetRequestBuilder(int id)
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
			return ObjectFactory.Create<CaptionParams>(result);
		}
	}

	public class CaptionParamsListRequestBuilder : RequestBuilder<ListResponse<CaptionParams>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public CaptionParamsFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public CaptionParamsListRequestBuilder()
			: base("caption_captionparams", "list")
		{
		}

		public CaptionParamsListRequestBuilder(CaptionParamsFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<CaptionParams>>(result);
		}
	}

	public class CaptionParamsUpdateRequestBuilder : RequestBuilder<CaptionParams>
	{
		#region Constants
		public const string ID = "id";
		public const string CAPTION_PARAMS = "captionParams";
		#endregion

		public int Id { get; set; }
		public CaptionParams CaptionParams { get; set; }

		public CaptionParamsUpdateRequestBuilder()
			: base("caption_captionparams", "update")
		{
		}

		public CaptionParamsUpdateRequestBuilder(int id, CaptionParams captionParams)
			: this()
		{
			this.Id = id;
			this.CaptionParams = captionParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("captionParams"))
				kparams.AddIfNotNull("captionParams", CaptionParams);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CaptionParams>(result);
		}
	}


	public class CaptionParamsService
	{
		private CaptionParamsService()
		{
		}

		public static CaptionParamsAddRequestBuilder Add(CaptionParams captionParams)
		{
			return new CaptionParamsAddRequestBuilder(captionParams);
		}

		public static CaptionParamsDeleteRequestBuilder Delete(int id)
		{
			return new CaptionParamsDeleteRequestBuilder(id);
		}

		public static CaptionParamsGetRequestBuilder Get(int id)
		{
			return new CaptionParamsGetRequestBuilder(id);
		}

		public static CaptionParamsListRequestBuilder List(CaptionParamsFilter filter = null, FilterPager pager = null)
		{
			return new CaptionParamsListRequestBuilder(filter, pager);
		}

		public static CaptionParamsUpdateRequestBuilder Update(int id, CaptionParams captionParams)
		{
			return new CaptionParamsUpdateRequestBuilder(id, captionParams);
		}
	}
}
