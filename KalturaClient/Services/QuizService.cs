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
	public class QuizAddRequestBuilder : RequestBuilder<Quiz>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string QUIZ = "quiz";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public Quiz Quiz
		{
			set;
			get;
		}

		public QuizAddRequestBuilder()
			: base("quiz_quiz", "add")
		{
		}

		public QuizAddRequestBuilder(string entryId, Quiz quiz)
			: this()
		{
			this.EntryId = entryId;
			this.Quiz = quiz;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("quiz"))
				kparams.AddIfNotNull("quiz", Quiz);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Quiz>(result);
		}
	}

	public class QuizGetRequestBuilder : RequestBuilder<Quiz>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId
		{
			set;
			get;
		}

		public QuizGetRequestBuilder()
			: base("quiz_quiz", "get")
		{
		}

		public QuizGetRequestBuilder(string entryId)
			: this()
		{
			this.EntryId = entryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Quiz>(result);
		}
	}

	public class QuizGetUrlRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string QUIZ_OUTPUT_TYPE = "quizOutputType";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public QuizOutputType QuizOutputType
		{
			set;
			get;
		}

		public QuizGetUrlRequestBuilder()
			: base("quiz_quiz", "getUrl")
		{
		}

		public QuizGetUrlRequestBuilder(string entryId, QuizOutputType quizOutputType)
			: this()
		{
			this.EntryId = entryId;
			this.QuizOutputType = quizOutputType;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("quizOutputType"))
				kparams.AddIfNotNull("quizOutputType", QuizOutputType);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class QuizListRequestBuilder : RequestBuilder<ListResponse<Quiz>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public QuizFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public QuizListRequestBuilder()
			: base("quiz_quiz", "list")
		{
		}

		public QuizListRequestBuilder(QuizFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<Quiz>>(result);
		}
	}

	public class QuizUpdateRequestBuilder : RequestBuilder<Quiz>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string QUIZ = "quiz";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public Quiz Quiz
		{
			set;
			get;
		}

		public QuizUpdateRequestBuilder()
			: base("quiz_quiz", "update")
		{
		}

		public QuizUpdateRequestBuilder(string entryId, Quiz quiz)
			: this()
		{
			this.EntryId = entryId;
			this.Quiz = quiz;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("quiz"))
				kparams.AddIfNotNull("quiz", Quiz);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Quiz>(result);
		}
	}


	public class QuizService
	{
		private QuizService()
		{
		}

		public static QuizAddRequestBuilder Add(string entryId, Quiz quiz)
		{
			return new QuizAddRequestBuilder(entryId, quiz);
		}

		public static QuizGetRequestBuilder Get(string entryId)
		{
			return new QuizGetRequestBuilder(entryId);
		}

		public static QuizGetUrlRequestBuilder GetUrl(string entryId, QuizOutputType quizOutputType)
		{
			return new QuizGetUrlRequestBuilder(entryId, quizOutputType);
		}

		public static QuizListRequestBuilder List(QuizFilter filter = null, FilterPager pager = null)
		{
			return new QuizListRequestBuilder(filter, pager);
		}

		public static QuizUpdateRequestBuilder Update(string entryId, Quiz quiz)
		{
			return new QuizUpdateRequestBuilder(entryId, quiz);
		}
	}
}
