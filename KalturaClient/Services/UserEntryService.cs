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
	public class UserEntryAddRequestBuilder : RequestBuilder<UserEntry>
	{
		#region Constants
		public const string USER_ENTRY = "userEntry";
		#endregion

		public UserEntry UserEntry
		{
			set;
			get;
		}

		public UserEntryAddRequestBuilder()
			: base("userentry", "add")
		{
		}

		public UserEntryAddRequestBuilder(UserEntry userEntry)
			: this()
		{
			this.UserEntry = userEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userEntry"))
				kparams.AddIfNotNull("userEntry", UserEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<UserEntry>(result);
		}
	}

	public class UserEntryBulkDeleteRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public UserEntryFilter Filter
		{
			set;
			get;
		}

		public UserEntryBulkDeleteRequestBuilder()
			: base("userentry", "bulkDelete")
		{
		}

		public UserEntryBulkDeleteRequestBuilder(UserEntryFilter filter)
			: this()
		{
			this.Filter = filter;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class UserEntryDeleteRequestBuilder : RequestBuilder<UserEntry>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public UserEntryDeleteRequestBuilder()
			: base("userentry", "delete")
		{
		}

		public UserEntryDeleteRequestBuilder(int id)
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
			return ObjectFactory.Create<UserEntry>(result);
		}
	}

	public class UserEntryGetRequestBuilder : RequestBuilder<UserEntry>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public UserEntryGetRequestBuilder()
			: base("userentry", "get")
		{
		}

		public UserEntryGetRequestBuilder(string id)
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
			return ObjectFactory.Create<UserEntry>(result);
		}
	}

	public class UserEntryListRequestBuilder : RequestBuilder<ListResponse<UserEntry>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public UserEntryFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public UserEntryListRequestBuilder()
			: base("userentry", "list")
		{
		}

		public UserEntryListRequestBuilder(UserEntryFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<UserEntry>>(result);
		}
	}

	public class UserEntrySubmitQuizRequestBuilder : RequestBuilder<QuizUserEntry>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public UserEntrySubmitQuizRequestBuilder()
			: base("userentry", "submitQuiz")
		{
		}

		public UserEntrySubmitQuizRequestBuilder(int id)
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
			return ObjectFactory.Create<QuizUserEntry>(result);
		}
	}

	public class UserEntryUpdateRequestBuilder : RequestBuilder<UserEntry>
	{
		#region Constants
		public const string ID = "id";
		public const string USER_ENTRY = "userEntry";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public UserEntry UserEntry
		{
			set;
			get;
		}

		public UserEntryUpdateRequestBuilder()
			: base("userentry", "update")
		{
		}

		public UserEntryUpdateRequestBuilder(int id, UserEntry userEntry)
			: this()
		{
			this.Id = id;
			this.UserEntry = userEntry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("userEntry"))
				kparams.AddIfNotNull("userEntry", UserEntry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<UserEntry>(result);
		}
	}


	public class UserEntryService
	{
		private UserEntryService()
		{
		}

		public static UserEntryAddRequestBuilder Add(UserEntry userEntry)
		{
			return new UserEntryAddRequestBuilder(userEntry);
		}

		public static UserEntryBulkDeleteRequestBuilder BulkDelete(UserEntryFilter filter)
		{
			return new UserEntryBulkDeleteRequestBuilder(filter);
		}

		public static UserEntryDeleteRequestBuilder Delete(int id)
		{
			return new UserEntryDeleteRequestBuilder(id);
		}

		public static UserEntryGetRequestBuilder Get(string id)
		{
			return new UserEntryGetRequestBuilder(id);
		}

		public static UserEntryListRequestBuilder List(UserEntryFilter filter = null, FilterPager pager = null)
		{
			return new UserEntryListRequestBuilder(filter, pager);
		}

		public static UserEntrySubmitQuizRequestBuilder SubmitQuiz(int id)
		{
			return new UserEntrySubmitQuizRequestBuilder(id);
		}

		public static UserEntryUpdateRequestBuilder Update(int id, UserEntry userEntry)
		{
			return new UserEntryUpdateRequestBuilder(id, userEntry);
		}
	}
}
