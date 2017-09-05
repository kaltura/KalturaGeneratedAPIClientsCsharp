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
	public class ESearchGetAllowedSearchTypesRequestBuilder : RequestBuilder<IList<KeyValue>>
	{
		#region Constants
		public const string SEARCH_ITEM = "searchItem";
		#endregion

		public ESearchItem SearchItem
		{
			set;
			get;
		}

		public ESearchGetAllowedSearchTypesRequestBuilder()
			: base("elasticsearch_esearch", "getAllowedSearchTypes")
		{
		}

		public ESearchGetAllowedSearchTypesRequestBuilder(ESearchItem searchItem)
			: this()
		{
			this.SearchItem = searchItem;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("searchItem"))
				kparams.AddIfNotNull("searchItem", SearchItem);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			IList<KeyValue> list = new List<KeyValue>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add(ObjectFactory.Create<KeyValue>(node));
			}
			return list;
		}
	}

	public class ESearchSearchCategoryRequestBuilder : RequestBuilder<ESearchResponse>
	{
		#region Constants
		public const string SEARCH_PARAMS = "searchParams";
		public const string PAGER = "pager";
		#endregion

		public ESearchParams SearchParams
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

		public ESearchSearchCategoryRequestBuilder(ESearchParams searchParams, Pager pager)
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
			return ObjectFactory.Create<ESearchResponse>(result);
		}
	}

	public class ESearchSearchEntryRequestBuilder : RequestBuilder<ESearchResponse>
	{
		#region Constants
		public const string SEARCH_PARAMS = "searchParams";
		public const string PAGER = "pager";
		#endregion

		public ESearchParams SearchParams
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

		public ESearchSearchEntryRequestBuilder(ESearchParams searchParams, Pager pager)
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
			return ObjectFactory.Create<ESearchResponse>(result);
		}
	}

	public class ESearchSearchUserRequestBuilder : RequestBuilder<ESearchResponse>
	{
		#region Constants
		public const string SEARCH_PARAMS = "searchParams";
		public const string PAGER = "pager";
		#endregion

		public ESearchParams SearchParams
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

		public ESearchSearchUserRequestBuilder(ESearchParams searchParams, Pager pager)
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
			return ObjectFactory.Create<ESearchResponse>(result);
		}
	}


	public class ESearchService
	{
		private ESearchService()
		{
		}

		public static ESearchGetAllowedSearchTypesRequestBuilder GetAllowedSearchTypes(ESearchItem searchItem)
		{
			return new ESearchGetAllowedSearchTypesRequestBuilder(searchItem);
		}

		public static ESearchSearchCategoryRequestBuilder SearchCategory(ESearchParams searchParams, Pager pager = null)
		{
			return new ESearchSearchCategoryRequestBuilder(searchParams, pager);
		}

		public static ESearchSearchEntryRequestBuilder SearchEntry(ESearchParams searchParams, Pager pager = null)
		{
			return new ESearchSearchEntryRequestBuilder(searchParams, pager);
		}

		public static ESearchSearchUserRequestBuilder SearchUser(ESearchParams searchParams, Pager pager = null)
		{
			return new ESearchSearchUserRequestBuilder(searchParams, pager);
		}
	}
}
