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
	public class TagDeletePendingRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		#endregion


		public TagDeletePendingRequestBuilder()
			: base("tagsearch_tag", "deletePending")
		{
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
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
		public override object DeserializeObject(object result)
		{
			return (int)(result);
		}
	}

	public class TagIndexCategoryEntryTagsRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string PC_TO_DECREMENT = "pcToDecrement";
		public const string PC_TO_INCREMENT = "pcToIncrement";
		#endregion

		public int CategoryId
		{
			set;
			get;
		}
		public string PcToDecrement
		{
			set;
			get;
		}
		public string PcToIncrement
		{
			set;
			get;
		}

		public TagIndexCategoryEntryTagsRequestBuilder()
			: base("tagsearch_tag", "indexCategoryEntryTags")
		{
		}

		public TagIndexCategoryEntryTagsRequestBuilder(int categoryId, string pcToDecrement, string pcToIncrement)
			: this()
		{
			this.CategoryId = categoryId;
			this.PcToDecrement = pcToDecrement;
			this.PcToIncrement = pcToIncrement;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("categoryId"))
				kparams.AddIfNotNull("categoryId", CategoryId);
			if (!isMapped("pcToDecrement"))
				kparams.AddIfNotNull("pcToDecrement", PcToDecrement);
			if (!isMapped("pcToIncrement"))
				kparams.AddIfNotNull("pcToIncrement", PcToIncrement);
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
		public override object DeserializeObject(object result)
		{
			return null;
		}
	}

	public class TagSearchRequestBuilder : RequestBuilder<ListResponse<Tag>>
	{
		#region Constants
		public const string TAG_FILTER = "tagFilter";
		public const string PAGER = "pager";
		#endregion

		public TagFilter TagFilter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public TagSearchRequestBuilder()
			: base("tagsearch_tag", "search")
		{
		}

		public TagSearchRequestBuilder(TagFilter tagFilter, FilterPager pager)
			: this()
		{
			this.TagFilter = tagFilter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("tagFilter"))
				kparams.AddIfNotNull("tagFilter", TagFilter);
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
			return ObjectFactory.Create<ListResponse<Tag>>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ListResponse<Tag>>((IDictionary<string,object>)result);
		}
	}


	public class TagService
	{
		private TagService()
		{
		}

		public static TagDeletePendingRequestBuilder DeletePending()
		{
			return new TagDeletePendingRequestBuilder();
		}

		public static TagIndexCategoryEntryTagsRequestBuilder IndexCategoryEntryTags(int categoryId, string pcToDecrement, string pcToIncrement)
		{
			return new TagIndexCategoryEntryTagsRequestBuilder(categoryId, pcToDecrement, pcToIncrement);
		}

		public static TagSearchRequestBuilder Search(TagFilter tagFilter, FilterPager pager = null)
		{
			return new TagSearchRequestBuilder(tagFilter, pager);
		}
	}
}
