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
// Copyright (C) 2006-2011  Kaltura Inc.
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

namespace Kaltura
{

	public class KalturaTagService : KalturaServiceBase
	{
	public KalturaTagService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaTagListResponse Search(KalturaTagFilter tagFilter)
		{
			return this.Search(tagFilter, null);
		}

		public KalturaTagListResponse Search(KalturaTagFilter tagFilter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (tagFilter != null)
				kparams.Add("tagFilter", tagFilter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("tagsearch_tag", "search", "KalturaTagListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaTagListResponse)KalturaObjectFactory.Create(result, "KalturaTagListResponse");
		}

		public int DeletePending()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("tagsearch_tag", "deletePending", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}

		public void IndexCategoryEntryTags(int categoryId, string pcToDecrement, string pcToIncrement)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("categoryId", categoryId);
			kparams.AddStringIfNotNull("pcToDecrement", pcToDecrement);
			kparams.AddStringIfNotNull("pcToIncrement", pcToIncrement);
			_Client.QueueServiceCall("tagsearch_tag", "indexCategoryEntryTags", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
