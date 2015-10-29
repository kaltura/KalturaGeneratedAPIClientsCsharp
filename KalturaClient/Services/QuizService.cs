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

	public class KalturaQuizService : KalturaServiceBase
	{
	public KalturaQuizService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaQuiz Add(string entryId, KalturaQuiz quiz)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("quiz", quiz);
			_Client.QueueServiceCall("quiz_quiz", "add", "KalturaQuiz", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaQuiz)KalturaObjectFactory.Create(result, "KalturaQuiz");
		}

		public KalturaQuiz Update(string entryId, KalturaQuiz quiz)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("quiz", quiz);
			_Client.QueueServiceCall("quiz_quiz", "update", "KalturaQuiz", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaQuiz)KalturaObjectFactory.Create(result, "KalturaQuiz");
		}

		public KalturaQuiz Get(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("quiz_quiz", "get", "KalturaQuiz", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaQuiz)KalturaObjectFactory.Create(result, "KalturaQuiz");
		}

		public KalturaQuizListResponse List()
		{
			return this.List(null);
		}

		public KalturaQuizListResponse List(KalturaQuizFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaQuizListResponse List(KalturaQuizFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("quiz_quiz", "list", "KalturaQuizListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaQuizListResponse)KalturaObjectFactory.Create(result, "KalturaQuizListResponse");
		}

		public string GetUrl(string entryId, KalturaQuizOutputType quizOutputType)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("entryId", entryId);
			kparams.AddIfNotNull("quizOutputType", quizOutputType);
			_Client.QueueServiceCall("quiz_quiz", "getUrl", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}
	}
}
