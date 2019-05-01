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
	public class PartnerCountRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public PartnerFilter Filter { get; set; }

		public PartnerCountRequestBuilder()
			: base("partner", "count")
		{
		}

		public PartnerCountRequestBuilder(PartnerFilter filter)
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
			return result.Value<int>();
		}
	}

	public class PartnerGetRequestBuilder : RequestBuilder<Partner>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id { get; set; }

		public PartnerGetRequestBuilder()
			: base("partner", "get")
		{
		}

		public PartnerGetRequestBuilder(int id)
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
			return ObjectFactory.Create<Partner>(result);
		}
	}

	public class PartnerGetInfoRequestBuilder : RequestBuilder<Partner>
	{
		#region Constants
		#endregion


		public PartnerGetInfoRequestBuilder()
			: base("partner", "getInfo")
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Partner>(result);
		}
	}

	public class PartnerGetSecretsRequestBuilder : RequestBuilder<Partner>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		public const string ADMIN_EMAIL = "adminEmail";
		public const string CMS_PASSWORD = "cmsPassword";
		#endregion

		public new int PartnerId { get; set; }
		public string AdminEmail { get; set; }
		public string CmsPassword { get; set; }

		public PartnerGetSecretsRequestBuilder()
			: base("partner", "getSecrets")
		{
		}

		public PartnerGetSecretsRequestBuilder(int partnerId, string adminEmail, string cmsPassword)
			: this()
		{
			this.PartnerId = partnerId;
			this.AdminEmail = adminEmail;
			this.CmsPassword = cmsPassword;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			if (!isMapped("adminEmail"))
				kparams.AddIfNotNull("adminEmail", AdminEmail);
			if (!isMapped("cmsPassword"))
				kparams.AddIfNotNull("cmsPassword", CmsPassword);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Partner>(result);
		}
	}

	public class PartnerGetStatisticsRequestBuilder : RequestBuilder<PartnerStatistics>
	{
		#region Constants
		#endregion


		public PartnerGetStatisticsRequestBuilder()
			: base("partner", "getStatistics")
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<PartnerStatistics>(result);
		}
	}

	public class PartnerListRequestBuilder : RequestBuilder<ListResponse<Partner>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public PartnerFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public PartnerListRequestBuilder()
			: base("partner", "list")
		{
		}

		public PartnerListRequestBuilder(PartnerFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<Partner>>(result);
		}
	}

	public class PartnerListFeatureStatusRequestBuilder : RequestBuilder<ListResponse<FeatureStatus>>
	{
		#region Constants
		#endregion


		public PartnerListFeatureStatusRequestBuilder()
			: base("partner", "listFeatureStatus")
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<FeatureStatus>>(result);
		}
	}

	public class PartnerListPartnersForUserRequestBuilder : RequestBuilder<ListResponse<Partner>>
	{
		#region Constants
		public const string PARTNER_FILTER = "partnerFilter";
		public const string PAGER = "pager";
		#endregion

		public PartnerFilter PartnerFilter { get; set; }
		public FilterPager Pager { get; set; }

		public PartnerListPartnersForUserRequestBuilder()
			: base("partner", "listPartnersForUser")
		{
		}

		public PartnerListPartnersForUserRequestBuilder(PartnerFilter partnerFilter, FilterPager pager)
			: this()
		{
			this.PartnerFilter = partnerFilter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partnerFilter"))
				kparams.AddIfNotNull("partnerFilter", PartnerFilter);
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
			return ObjectFactory.Create<ListResponse<Partner>>(result);
		}
	}

	public class PartnerRegisterRequestBuilder : RequestBuilder<Partner>
	{
		#region Constants
		public const string PARTNER = "partner";
		public const string CMS_PASSWORD = "cmsPassword";
		public const string TEMPLATE_PARTNER_ID = "templatePartnerId";
		public const string SILENT = "silent";
		#endregion

		public Partner Partner { get; set; }
		public string CmsPassword { get; set; }
		public int TemplatePartnerId { get; set; }
		public bool Silent { get; set; }

		public PartnerRegisterRequestBuilder()
			: base("partner", "register")
		{
		}

		public PartnerRegisterRequestBuilder(Partner partner, string cmsPassword, int templatePartnerId, bool silent)
			: this()
		{
			this.Partner = partner;
			this.CmsPassword = cmsPassword;
			this.TemplatePartnerId = templatePartnerId;
			this.Silent = silent;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partner"))
				kparams.AddIfNotNull("partner", Partner);
			if (!isMapped("cmsPassword"))
				kparams.AddIfNotNull("cmsPassword", CmsPassword);
			if (!isMapped("templatePartnerId"))
				kparams.AddIfNotNull("templatePartnerId", TemplatePartnerId);
			if (!isMapped("silent"))
				kparams.AddIfNotNull("silent", Silent);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Partner>(result);
		}
	}

	public class PartnerUpdateRequestBuilder : RequestBuilder<Partner>
	{
		#region Constants
		public const string PARTNER = "partner";
		public const string ALLOW_EMPTY = "allowEmpty";
		#endregion

		public Partner Partner { get; set; }
		public bool AllowEmpty { get; set; }

		public PartnerUpdateRequestBuilder()
			: base("partner", "update")
		{
		}

		public PartnerUpdateRequestBuilder(Partner partner, bool allowEmpty)
			: this()
		{
			this.Partner = partner;
			this.AllowEmpty = allowEmpty;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("partner"))
				kparams.AddIfNotNull("partner", Partner);
			if (!isMapped("allowEmpty"))
				kparams.AddIfNotNull("allowEmpty", AllowEmpty);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Partner>(result);
		}
	}


	public class PartnerService
	{
		private PartnerService()
		{
		}

		public static PartnerCountRequestBuilder Count(PartnerFilter filter = null)
		{
			return new PartnerCountRequestBuilder(filter);
		}

		public static PartnerGetRequestBuilder Get(int id = Int32.MinValue)
		{
			return new PartnerGetRequestBuilder(id);
		}

		public static PartnerGetInfoRequestBuilder GetInfo()
		{
			return new PartnerGetInfoRequestBuilder();
		}

		public static PartnerGetSecretsRequestBuilder GetSecrets(int partnerId, string adminEmail, string cmsPassword)
		{
			return new PartnerGetSecretsRequestBuilder(partnerId, adminEmail, cmsPassword);
		}

		public static PartnerGetStatisticsRequestBuilder GetStatistics()
		{
			return new PartnerGetStatisticsRequestBuilder();
		}

		public static PartnerListRequestBuilder List(PartnerFilter filter = null, FilterPager pager = null)
		{
			return new PartnerListRequestBuilder(filter, pager);
		}

		public static PartnerListFeatureStatusRequestBuilder ListFeatureStatus()
		{
			return new PartnerListFeatureStatusRequestBuilder();
		}

		public static PartnerListPartnersForUserRequestBuilder ListPartnersForUser(PartnerFilter partnerFilter = null, FilterPager pager = null)
		{
			return new PartnerListPartnersForUserRequestBuilder(partnerFilter, pager);
		}

		public static PartnerRegisterRequestBuilder Register(Partner partner, string cmsPassword = "", int templatePartnerId = Int32.MinValue, bool silent = false)
		{
			return new PartnerRegisterRequestBuilder(partner, cmsPassword, templatePartnerId, silent);
		}

		public static PartnerUpdateRequestBuilder Update(Partner partner, bool allowEmpty = false)
		{
			return new PartnerUpdateRequestBuilder(partner, allowEmpty);
		}
	}
}
