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
// Copyright (C) 2006-2015  Kaltura Inc.
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

	public class KalturaUserEntryService : KalturaServiceBase
	{
	public KalturaUserEntryService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaUserEntry Add(KalturaUserEntry userEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("userEntry", userEntry);
			_Client.QueueServiceCall("userentry", "add", "KalturaUserEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserEntry)KalturaObjectFactory.Create(result, "KalturaUserEntry");
		}

		public void Update(int id, KalturaUserEntry userEntry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("userEntry", userEntry);
			_Client.QueueServiceCall("userentry", "update", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaUserEntry Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("userentry", "delete", "KalturaUserEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserEntry)KalturaObjectFactory.Create(result, "KalturaUserEntry");
		}

		public KalturaUserEntryListResponse List(KalturaUserEntryFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaUserEntryListResponse List(KalturaUserEntryFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("userentry", "list", "KalturaUserEntryListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserEntryListResponse)KalturaObjectFactory.Create(result, "KalturaUserEntryListResponse");
		}

		public KalturaUserEntry Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("userentry", "get", "KalturaUserEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserEntry)KalturaObjectFactory.Create(result, "KalturaUserEntry");
		}

		public KalturaQuizUserEntry SubmitQuiz(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("userentry", "submitQuiz", "KalturaQuizUserEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaQuizUserEntry)KalturaObjectFactory.Create(result, "KalturaQuizUserEntry");
		}
	}
}
