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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class SsoAddRequestBuilder : RequestBuilder<Sso>
	{
		#region Constants
		public const string SSO = "sso";
		#endregion

		public Sso Sso { get; set; }

		public SsoAddRequestBuilder()
			: base("sso_sso", "add")
		{
		}

		public SsoAddRequestBuilder(Sso sso)
			: this()
		{
			this.Sso = sso;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("sso"))
				kparams.AddIfNotNull("sso", Sso);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Sso>(result);
		}
	}

	public class SsoDeleteRequestBuilder : RequestBuilder<Sso>
	{
		#region Constants
		public const string SSO_ID = "ssoId";
		#endregion

		public int SsoId { get; set; }

		public SsoDeleteRequestBuilder()
			: base("sso_sso", "delete")
		{
		}

		public SsoDeleteRequestBuilder(int ssoId)
			: this()
		{
			this.SsoId = ssoId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("ssoId"))
				kparams.AddIfNotNull("ssoId", SsoId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Sso>(result);
		}
	}

	public class SsoGetRequestBuilder : RequestBuilder<Sso>
	{
		#region Constants
		public const string SSO_ID = "ssoId";
		#endregion

		public int SsoId { get; set; }

		public SsoGetRequestBuilder()
			: base("sso_sso", "get")
		{
		}

		public SsoGetRequestBuilder(int ssoId)
			: this()
		{
			this.SsoId = ssoId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("ssoId"))
				kparams.AddIfNotNull("ssoId", SsoId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Sso>(result);
		}
	}

	public class SsoListRequestBuilder : RequestBuilder<ListResponse<Sso>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public SsoFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public SsoListRequestBuilder()
			: base("sso_sso", "list")
		{
		}

		public SsoListRequestBuilder(SsoFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<Sso>>(result);
		}
	}

	public class SsoLoginRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string APPLICATION_TYPE = "applicationType";
		public new const string PARTNER_ID = "partnerId";
		#endregion

		public string UserId { get; set; }
		public string ApplicationType { get; set; }
		public new int PartnerId { get; set; }

		public SsoLoginRequestBuilder()
			: base("sso_sso", "login")
		{
		}

		public SsoLoginRequestBuilder(string userId, string applicationType, int partnerId)
			: this()
		{
			this.UserId = userId;
			this.ApplicationType = applicationType;
			this.PartnerId = partnerId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("applicationType"))
				kparams.AddIfNotNull("applicationType", ApplicationType);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
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

	public class SsoUpdateRequestBuilder : RequestBuilder<Sso>
	{
		#region Constants
		public const string SSO_ID = "ssoId";
		public const string SSO = "sso";
		#endregion

		public int SsoId { get; set; }
		public Sso Sso { get; set; }

		public SsoUpdateRequestBuilder()
			: base("sso_sso", "update")
		{
		}

		public SsoUpdateRequestBuilder(int ssoId, Sso sso)
			: this()
		{
			this.SsoId = ssoId;
			this.Sso = sso;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("ssoId"))
				kparams.AddIfNotNull("ssoId", SsoId);
			if (!isMapped("sso"))
				kparams.AddIfNotNull("sso", Sso);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Sso>(result);
		}
	}


	public class SsoService
	{
		private SsoService()
		{
		}

		public static SsoAddRequestBuilder Add(Sso sso)
		{
			return new SsoAddRequestBuilder(sso);
		}

		public static SsoDeleteRequestBuilder Delete(int ssoId)
		{
			return new SsoDeleteRequestBuilder(ssoId);
		}

		public static SsoGetRequestBuilder Get(int ssoId)
		{
			return new SsoGetRequestBuilder(ssoId);
		}

		public static SsoListRequestBuilder List(SsoFilter filter = null, FilterPager pager = null)
		{
			return new SsoListRequestBuilder(filter, pager);
		}

		public static SsoLoginRequestBuilder Login(string userId, string applicationType, int partnerId = Int32.MinValue)
		{
			return new SsoLoginRequestBuilder(userId, applicationType, partnerId);
		}

		public static SsoUpdateRequestBuilder Update(int ssoId, Sso sso)
		{
			return new SsoUpdateRequestBuilder(ssoId, sso);
		}
	}
}
