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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class AppTokenAddRequestBuilder : RequestBuilder<AppToken>
	{
		#region Constants
		public const string APP_TOKEN = "appToken";
		#endregion

		public AppToken AppToken
		{
			set;
			get;
		}

		public AppTokenAddRequestBuilder()
			: base("apptoken", "add")
		{
		}

		public AppTokenAddRequestBuilder(AppToken appToken)
			: this()
		{
			this.AppToken = appToken;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("appToken"))
				kparams.AddIfNotNull("appToken", AppToken);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<AppToken>(result);
		}
	}

	public class AppTokenDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public AppTokenDeleteRequestBuilder()
			: base("apptoken", "delete")
		{
		}

		public AppTokenDeleteRequestBuilder(string id)
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

	public class AppTokenGetRequestBuilder : RequestBuilder<AppToken>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public AppTokenGetRequestBuilder()
			: base("apptoken", "get")
		{
		}

		public AppTokenGetRequestBuilder(string id)
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
			return ObjectFactory.Create<AppToken>(result);
		}
	}

	public class AppTokenListRequestBuilder : RequestBuilder<ListResponse<AppToken>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public AppTokenFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public AppTokenListRequestBuilder()
			: base("apptoken", "list")
		{
		}

		public AppTokenListRequestBuilder(AppTokenFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<AppToken>>(result);
		}
	}

	public class AppTokenStartSessionRequestBuilder : RequestBuilder<SessionInfo>
	{
		#region Constants
		public const string ID = "id";
		public const string TOKEN_HASH = "tokenHash";
		public const string USER_ID = "userId";
		public const string TYPE = "type";
		public const string EXPIRY = "expiry";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public string TokenHash
		{
			set;
			get;
		}
		public string UserId
		{
			set;
			get;
		}
		public SessionType Type
		{
			set;
			get;
		}
		public int Expiry
		{
			set;
			get;
		}

		public AppTokenStartSessionRequestBuilder()
			: base("apptoken", "startSession")
		{
		}

		public AppTokenStartSessionRequestBuilder(string id, string tokenHash, string userId, SessionType type, int expiry)
			: this()
		{
			this.Id = id;
			this.TokenHash = tokenHash;
			this.UserId = userId;
			this.Type = type;
			this.Expiry = expiry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("tokenHash"))
				kparams.AddIfNotNull("tokenHash", TokenHash);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			if (!isMapped("expiry"))
				kparams.AddIfNotNull("expiry", Expiry);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<SessionInfo>(result);
		}
	}

	public class AppTokenUpdateRequestBuilder : RequestBuilder<AppToken>
	{
		#region Constants
		public const string ID = "id";
		public const string APP_TOKEN = "appToken";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public AppToken AppToken
		{
			set;
			get;
		}

		public AppTokenUpdateRequestBuilder()
			: base("apptoken", "update")
		{
		}

		public AppTokenUpdateRequestBuilder(string id, AppToken appToken)
			: this()
		{
			this.Id = id;
			this.AppToken = appToken;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("appToken"))
				kparams.AddIfNotNull("appToken", AppToken);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<AppToken>(result);
		}
	}


	public class AppTokenService
	{
		private AppTokenService()
		{
		}

		public static AppTokenAddRequestBuilder Add(AppToken appToken)
		{
			return new AppTokenAddRequestBuilder(appToken);
		}

		public static AppTokenDeleteRequestBuilder Delete(string id)
		{
			return new AppTokenDeleteRequestBuilder(id);
		}

		public static AppTokenGetRequestBuilder Get(string id)
		{
			return new AppTokenGetRequestBuilder(id);
		}

		public static AppTokenListRequestBuilder List(AppTokenFilter filter = null, FilterPager pager = null)
		{
			return new AppTokenListRequestBuilder(filter, pager);
		}

		public static AppTokenStartSessionRequestBuilder StartSession(string id, string tokenHash, string userId = null, SessionType type = (SessionType)(Int32.MinValue), int expiry = Int32.MinValue)
		{
			return new AppTokenStartSessionRequestBuilder(id, tokenHash, userId, type, expiry);
		}

		public static AppTokenUpdateRequestBuilder Update(string id, AppToken appToken)
		{
			return new AppTokenUpdateRequestBuilder(id, appToken);
		}
	}
}
