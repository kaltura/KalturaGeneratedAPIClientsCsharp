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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class CaptionAssetItemListRequestBuilder : RequestBuilder<ListResponse<CaptionAssetItem>>
	{
		#region Constants
		public const string CAPTION_ASSET_ID = "captionAssetId";
		public const string CAPTION_ASSET_ITEM_FILTER = "captionAssetItemFilter";
		public const string CAPTION_ASSET_ITEM_PAGER = "captionAssetItemPager";
		#endregion

		public string CaptionAssetId { get; set; }
		public CaptionAssetItemFilter CaptionAssetItemFilter { get; set; }
		public FilterPager CaptionAssetItemPager { get; set; }

		public CaptionAssetItemListRequestBuilder()
			: base("captionsearch_captionassetitem", "list")
		{
		}

		public CaptionAssetItemListRequestBuilder(string captionAssetId, CaptionAssetItemFilter captionAssetItemFilter, FilterPager captionAssetItemPager)
			: this()
		{
			this.CaptionAssetId = captionAssetId;
			this.CaptionAssetItemFilter = captionAssetItemFilter;
			this.CaptionAssetItemPager = captionAssetItemPager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("captionAssetId"))
				kparams.AddIfNotNull("captionAssetId", CaptionAssetId);
			if (!isMapped("captionAssetItemFilter"))
				kparams.AddIfNotNull("captionAssetItemFilter", CaptionAssetItemFilter);
			if (!isMapped("captionAssetItemPager"))
				kparams.AddIfNotNull("captionAssetItemPager", CaptionAssetItemPager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<CaptionAssetItem>>(result);
		}
	}

	public class CaptionAssetItemSearchRequestBuilder : RequestBuilder<ListResponse<CaptionAssetItem>>
	{
		#region Constants
		public const string ENTRY_FILTER = "entryFilter";
		public const string CAPTION_ASSET_ITEM_FILTER = "captionAssetItemFilter";
		public const string CAPTION_ASSET_ITEM_PAGER = "captionAssetItemPager";
		#endregion

		public BaseEntryFilter EntryFilter { get; set; }
		public CaptionAssetItemFilter CaptionAssetItemFilter { get; set; }
		public FilterPager CaptionAssetItemPager { get; set; }

		public CaptionAssetItemSearchRequestBuilder()
			: base("captionsearch_captionassetitem", "search")
		{
		}

		public CaptionAssetItemSearchRequestBuilder(BaseEntryFilter entryFilter, CaptionAssetItemFilter captionAssetItemFilter, FilterPager captionAssetItemPager)
			: this()
		{
			this.EntryFilter = entryFilter;
			this.CaptionAssetItemFilter = captionAssetItemFilter;
			this.CaptionAssetItemPager = captionAssetItemPager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryFilter"))
				kparams.AddIfNotNull("entryFilter", EntryFilter);
			if (!isMapped("captionAssetItemFilter"))
				kparams.AddIfNotNull("captionAssetItemFilter", CaptionAssetItemFilter);
			if (!isMapped("captionAssetItemPager"))
				kparams.AddIfNotNull("captionAssetItemPager", CaptionAssetItemPager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<CaptionAssetItem>>(result);
		}
	}

	public class CaptionAssetItemSearchEntriesRequestBuilder : RequestBuilder<ListResponse<BaseEntry>>
	{
		#region Constants
		public const string ENTRY_FILTER = "entryFilter";
		public const string CAPTION_ASSET_ITEM_FILTER = "captionAssetItemFilter";
		public const string CAPTION_ASSET_ITEM_PAGER = "captionAssetItemPager";
		#endregion

		public BaseEntryFilter EntryFilter { get; set; }
		public CaptionAssetItemFilter CaptionAssetItemFilter { get; set; }
		public FilterPager CaptionAssetItemPager { get; set; }

		public CaptionAssetItemSearchEntriesRequestBuilder()
			: base("captionsearch_captionassetitem", "searchEntries")
		{
		}

		public CaptionAssetItemSearchEntriesRequestBuilder(BaseEntryFilter entryFilter, CaptionAssetItemFilter captionAssetItemFilter, FilterPager captionAssetItemPager)
			: this()
		{
			this.EntryFilter = entryFilter;
			this.CaptionAssetItemFilter = captionAssetItemFilter;
			this.CaptionAssetItemPager = captionAssetItemPager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryFilter"))
				kparams.AddIfNotNull("entryFilter", EntryFilter);
			if (!isMapped("captionAssetItemFilter"))
				kparams.AddIfNotNull("captionAssetItemFilter", CaptionAssetItemFilter);
			if (!isMapped("captionAssetItemPager"))
				kparams.AddIfNotNull("captionAssetItemPager", CaptionAssetItemPager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<BaseEntry>>(result);
		}
	}


	public class CaptionAssetItemService
	{
		private CaptionAssetItemService()
		{
		}

		public static CaptionAssetItemListRequestBuilder List(string captionAssetId, CaptionAssetItemFilter captionAssetItemFilter = null, FilterPager captionAssetItemPager = null)
		{
			return new CaptionAssetItemListRequestBuilder(captionAssetId, captionAssetItemFilter, captionAssetItemPager);
		}

		public static CaptionAssetItemSearchRequestBuilder Search(BaseEntryFilter entryFilter = null, CaptionAssetItemFilter captionAssetItemFilter = null, FilterPager captionAssetItemPager = null)
		{
			return new CaptionAssetItemSearchRequestBuilder(entryFilter, captionAssetItemFilter, captionAssetItemPager);
		}

		public static CaptionAssetItemSearchEntriesRequestBuilder SearchEntries(BaseEntryFilter entryFilter = null, CaptionAssetItemFilter captionAssetItemFilter = null, FilterPager captionAssetItemPager = null)
		{
			return new CaptionAssetItemSearchEntriesRequestBuilder(entryFilter, captionAssetItemFilter, captionAssetItemPager);
		}
	}
}
