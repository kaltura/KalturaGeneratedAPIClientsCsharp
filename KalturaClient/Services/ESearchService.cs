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
	public class ESearchSearchCategoryRequestBuilder : RequestBuilder<ESearchCategoryResponse>
	{
		#region Constants
		public const string SEARCH_PARAMS = "searchParams";
		public const string PAGER = "pager";
		#endregion

		public ESearchCategoryParams SearchParams
		{
			set;
			get;
		}
		public Pager Pager
		{
			set;
			get;
		}

		public ESearchSearchCategoryRequestBuilder()
			: base("elasticsearch_esearch", "searchCategory")
		{
		}

		public ESearchSearchCategoryRequestBuilder(ESearchCategoryParams searchParams, Pager pager)
			: this()
		{
			this.SearchParams = searchParams;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("searchParams"))
				kparams.AddIfNotNull("searchParams", SearchParams);
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
			return ObjectFactory.Create<ESearchCategoryResponse>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ESearchCategoryResponse>((IDictionary<string,object>)result);
		}
	}

	public class ESearchSearchEntryRequestBuilder : RequestBuilder<ESearchEntryResponse>
	{
		#region Constants
		public const string SEARCH_PARAMS = "searchParams";
		public const string PAGER = "pager";
		#endregion

		public ESearchEntryParams SearchParams
		{
			set;
			get;
		}
		public Pager Pager
		{
			set;
			get;
		}

		public ESearchSearchEntryRequestBuilder()
			: base("elasticsearch_esearch", "searchEntry")
		{
		}

		public ESearchSearchEntryRequestBuilder(ESearchEntryParams searchParams, Pager pager)
			: this()
		{
			this.SearchParams = searchParams;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("searchParams"))
				kparams.AddIfNotNull("searchParams", SearchParams);
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
			return ObjectFactory.Create<ESearchEntryResponse>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ESearchEntryResponse>((IDictionary<string,object>)result);
		}
	}

	public class ESearchSearchUserRequestBuilder : RequestBuilder<ESearchUserResponse>
	{
		#region Constants
		public const string SEARCH_PARAMS = "searchParams";
		public const string PAGER = "pager";
		#endregion

		public ESearchUserParams SearchParams
		{
			set;
			get;
		}
		public Pager Pager
		{
			set;
			get;
		}

		public ESearchSearchUserRequestBuilder()
			: base("elasticsearch_esearch", "searchUser")
		{
		}

		public ESearchSearchUserRequestBuilder(ESearchUserParams searchParams, Pager pager)
			: this()
		{
			this.SearchParams = searchParams;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("searchParams"))
				kparams.AddIfNotNull("searchParams", SearchParams);
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
			return ObjectFactory.Create<ESearchUserResponse>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ESearchUserResponse>((IDictionary<string,object>)result);
		}
	}


	public class ESearchService
	{
		private ESearchService()
		{
		}

		public static ESearchSearchCategoryRequestBuilder SearchCategory(ESearchCategoryParams searchParams, Pager pager = null)
		{
			return new ESearchSearchCategoryRequestBuilder(searchParams, pager);
		}

		public static ESearchSearchEntryRequestBuilder SearchEntry(ESearchEntryParams searchParams, Pager pager = null)
		{
			return new ESearchSearchEntryRequestBuilder(searchParams, pager);
		}

		public static ESearchSearchUserRequestBuilder SearchUser(ESearchUserParams searchParams, Pager pager = null)
		{
			return new ESearchSearchUserRequestBuilder(searchParams, pager);
		}
	}
}
