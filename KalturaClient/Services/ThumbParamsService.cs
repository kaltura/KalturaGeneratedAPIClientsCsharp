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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class ThumbParamsAddRequestBuilder : RequestBuilder<ThumbParams>
	{
		#region Constants
		public const string THUMB_PARAMS = "thumbParams";
		#endregion

		public ThumbParams ThumbParams
		{
			set;
			get;
		}

		public ThumbParamsAddRequestBuilder()
			: base("thumbparams", "add")
		{
		}

		public ThumbParamsAddRequestBuilder(ThumbParams thumbParams)
			: this()
		{
			this.ThumbParams = thumbParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("thumbParams"))
				kparams.AddIfNotNull("thumbParams", ThumbParams);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ThumbParams>(result);
		}
	}

	public class ThumbParamsDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public ThumbParamsDeleteRequestBuilder()
			: base("thumbparams", "delete")
		{
		}

		public ThumbParamsDeleteRequestBuilder(int id)
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

	public class ThumbParamsGetRequestBuilder : RequestBuilder<ThumbParams>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public ThumbParamsGetRequestBuilder()
			: base("thumbparams", "get")
		{
		}

		public ThumbParamsGetRequestBuilder(int id)
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
			return ObjectFactory.Create<ThumbParams>(result);
		}
	}

	public class ThumbParamsGetByConversionProfileIdRequestBuilder : RequestBuilder<IList<ThumbParams>>
	{
		#region Constants
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		#endregion

		public int ConversionProfileId
		{
			set;
			get;
		}

		public ThumbParamsGetByConversionProfileIdRequestBuilder()
			: base("thumbparams", "getByConversionProfileId")
		{
		}

		public ThumbParamsGetByConversionProfileIdRequestBuilder(int conversionProfileId)
			: this()
		{
			this.ConversionProfileId = conversionProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("conversionProfileId"))
				kparams.AddIfNotNull("conversionProfileId", ConversionProfileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			IList<ThumbParams> list = new List<ThumbParams>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add(ObjectFactory.Create<ThumbParams>(node));
			}
			return list;
		}
	}

	public class ThumbParamsListRequestBuilder : RequestBuilder<ListResponse<ThumbParams>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ThumbParamsFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public ThumbParamsListRequestBuilder()
			: base("thumbparams", "list")
		{
		}

		public ThumbParamsListRequestBuilder(ThumbParamsFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<ThumbParams>>(result);
		}
	}

	public class ThumbParamsUpdateRequestBuilder : RequestBuilder<ThumbParams>
	{
		#region Constants
		public const string ID = "id";
		public const string THUMB_PARAMS = "thumbParams";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public ThumbParams ThumbParams
		{
			set;
			get;
		}

		public ThumbParamsUpdateRequestBuilder()
			: base("thumbparams", "update")
		{
		}

		public ThumbParamsUpdateRequestBuilder(int id, ThumbParams thumbParams)
			: this()
		{
			this.Id = id;
			this.ThumbParams = thumbParams;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("thumbParams"))
				kparams.AddIfNotNull("thumbParams", ThumbParams);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ThumbParams>(result);
		}
	}


	public class ThumbParamsService
	{
		private ThumbParamsService()
		{
		}

		public static ThumbParamsAddRequestBuilder Add(ThumbParams thumbParams)
		{
			return new ThumbParamsAddRequestBuilder(thumbParams);
		}

		public static ThumbParamsDeleteRequestBuilder Delete(int id)
		{
			return new ThumbParamsDeleteRequestBuilder(id);
		}

		public static ThumbParamsGetRequestBuilder Get(int id)
		{
			return new ThumbParamsGetRequestBuilder(id);
		}

		public static ThumbParamsGetByConversionProfileIdRequestBuilder GetByConversionProfileId(int conversionProfileId)
		{
			return new ThumbParamsGetByConversionProfileIdRequestBuilder(conversionProfileId);
		}

		public static ThumbParamsListRequestBuilder List(ThumbParamsFilter filter = null, FilterPager pager = null)
		{
			return new ThumbParamsListRequestBuilder(filter, pager);
		}

		public static ThumbParamsUpdateRequestBuilder Update(int id, ThumbParams thumbParams)
		{
			return new ThumbParamsUpdateRequestBuilder(id, thumbParams);
		}
	}
}
