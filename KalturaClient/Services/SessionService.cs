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
	public class SessionStartRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string SECRET = "secret";
		public const string USER_ID = "userId";
		public const string TYPE = "type";
		public new const string PARTNER_ID = "partnerId";
		public const string EXPIRY = "expiry";
		public const string PRIVILEGES = "privileges";
		#endregion

		public string Secret
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
		public new int PartnerId
		{
			set;
			get;
		}
		public int Expiry
		{
			set;
			get;
		}
		public string Privileges
		{
			set;
			get;
		}

		public SessionStartRequestBuilder()
			: base("session", "start")
		{
		}

		public SessionStartRequestBuilder(string secret, string userId, SessionType type, int partnerId, int expiry, string privileges)
			: this()
		{
			this.Secret = secret;
			this.UserId = userId;
			this.Type = type;
			this.PartnerId = partnerId;
			this.Expiry = expiry;
			this.Privileges = privileges;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("secret"))
				kparams.AddIfNotNull("secret", Secret);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("expiry"))
				kparams.AddIfNotNull("expiry", Expiry);
			if (!isMapped("privileges"))
				kparams.AddIfNotNull("privileges", Privileges);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return result.InnerText;
		}
	}

	public class SessionEndRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		#endregion


		public SessionEndRequestBuilder()
			: base("session", "end")
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
			return null;
		}
	}

	public class SessionImpersonateRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string SECRET = "secret";
		public const string IMPERSONATED_PARTNER_ID = "impersonatedPartnerId";
		public const string USER_ID = "userId";
		public const string TYPE = "type";
		public new const string PARTNER_ID = "partnerId";
		public const string EXPIRY = "expiry";
		public const string PRIVILEGES = "privileges";
		#endregion

		public string Secret
		{
			set;
			get;
		}
		public int ImpersonatedPartnerId
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
		public new int PartnerId
		{
			set;
			get;
		}
		public int Expiry
		{
			set;
			get;
		}
		public string Privileges
		{
			set;
			get;
		}

		public SessionImpersonateRequestBuilder()
			: base("session", "impersonate")
		{
		}

		public SessionImpersonateRequestBuilder(string secret, int impersonatedPartnerId, string userId, SessionType type, int partnerId, int expiry, string privileges)
			: this()
		{
			this.Secret = secret;
			this.ImpersonatedPartnerId = impersonatedPartnerId;
			this.UserId = userId;
			this.Type = type;
			this.PartnerId = partnerId;
			this.Expiry = expiry;
			this.Privileges = privileges;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("secret"))
				kparams.AddIfNotNull("secret", Secret);
			if (!isMapped("impersonatedPartnerId"))
				kparams.AddIfNotNull("impersonatedPartnerId", ImpersonatedPartnerId);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("expiry"))
				kparams.AddIfNotNull("expiry", Expiry);
			if (!isMapped("privileges"))
				kparams.AddIfNotNull("privileges", Privileges);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return result.InnerText;
		}
	}

	public class SessionImpersonateByKsRequestBuilder : RequestBuilder<SessionInfo>
	{
		#region Constants
		public const string SESSION = "session";
		public const string TYPE = "type";
		public const string EXPIRY = "expiry";
		public const string PRIVILEGES = "privileges";
		#endregion

		public string Session
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
		public string Privileges
		{
			set;
			get;
		}

		public SessionImpersonateByKsRequestBuilder()
			: base("session", "impersonateByKs")
		{
		}

		public SessionImpersonateByKsRequestBuilder(string session, SessionType type, int expiry, string privileges)
			: this()
		{
			this.Session = session;
			this.Type = type;
			this.Expiry = expiry;
			this.Privileges = privileges;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("session"))
				kparams.AddIfNotNull("session", Session);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			if (!isMapped("expiry"))
				kparams.AddIfNotNull("expiry", Expiry);
			if (!isMapped("privileges"))
				kparams.AddIfNotNull("privileges", Privileges);
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

	public class SessionGetRequestBuilder : RequestBuilder<SessionInfo>
	{
		#region Constants
		public const string SESSION = "session";
		#endregion

		public string Session
		{
			set;
			get;
		}

		public SessionGetRequestBuilder()
			: base("session", "get")
		{
		}

		public SessionGetRequestBuilder(string session)
			: this()
		{
			this.Session = session;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("session"))
				kparams.AddIfNotNull("session", Session);
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

	public class SessionStartWidgetSessionRequestBuilder : RequestBuilder<StartWidgetSessionResponse>
	{
		#region Constants
		public const string WIDGET_ID = "widgetId";
		public const string EXPIRY = "expiry";
		#endregion

		public string WidgetId
		{
			set;
			get;
		}
		public int Expiry
		{
			set;
			get;
		}

		public SessionStartWidgetSessionRequestBuilder()
			: base("session", "startWidgetSession")
		{
		}

		public SessionStartWidgetSessionRequestBuilder(string widgetId, int expiry)
			: this()
		{
			this.WidgetId = widgetId;
			this.Expiry = expiry;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("widgetId"))
				kparams.AddIfNotNull("widgetId", WidgetId);
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
			return ObjectFactory.Create<StartWidgetSessionResponse>(result);
		}
	}


	public class SessionService
	{
		private SessionService()
		{
		}

		public static SessionStartRequestBuilder Start(string secret, string userId = "", SessionType type = (SessionType)(0), int partnerId = Int32.MinValue, int expiry = 86400, string privileges = null)
		{
			return new SessionStartRequestBuilder(secret, userId, type, partnerId, expiry, privileges);
		}

		public static SessionEndRequestBuilder End()
		{
			return new SessionEndRequestBuilder();
		}

		public static SessionImpersonateRequestBuilder Impersonate(string secret, int impersonatedPartnerId, string userId = "", SessionType type = (SessionType)(0), int partnerId = Int32.MinValue, int expiry = 86400, string privileges = null)
		{
			return new SessionImpersonateRequestBuilder(secret, impersonatedPartnerId, userId, type, partnerId, expiry, privileges);
		}

		public static SessionImpersonateByKsRequestBuilder ImpersonateByKs(string session, SessionType type = (SessionType)(Int32.MinValue), int expiry = Int32.MinValue, string privileges = null)
		{
			return new SessionImpersonateByKsRequestBuilder(session, type, expiry, privileges);
		}

		public static SessionGetRequestBuilder Get(string session = null)
		{
			return new SessionGetRequestBuilder(session);
		}

		public static SessionStartWidgetSessionRequestBuilder StartWidgetSession(string widgetId, int expiry = 86400)
		{
			return new SessionStartWidgetSessionRequestBuilder(widgetId, expiry);
		}
	}
}
