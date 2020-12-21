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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class ZoomVendorDeAuthorizationRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		#endregion


		public ZoomVendorDeAuthorizationRequestBuilder()
			: base("vendor_zoomvendor", "deAuthorization")
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
			return result.Value<string>();
		}
	}

	public class ZoomVendorFetchRegistrationPageRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string TOKENS_DATA = "tokensData";
		public const string IV = "iv";
		#endregion

		public string TokensData { get; set; }
		public string Iv { get; set; }

		public ZoomVendorFetchRegistrationPageRequestBuilder()
			: base("vendor_zoomvendor", "fetchRegistrationPage")
		{
		}

		public ZoomVendorFetchRegistrationPageRequestBuilder(string tokensData, string iv)
			: this()
		{
			this.TokensData = tokensData;
			this.Iv = iv;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("tokensData"))
				kparams.AddIfNotNull("tokensData", TokensData);
			if (!isMapped("iv"))
				kparams.AddIfNotNull("iv", Iv);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class ZoomVendorGetRequestBuilder : RequestBuilder<ZoomIntegrationSetting>
	{
		#region Constants
		public new const string PARTNER_ID = "partnerId";
		#endregion

		public new int PartnerId { get; set; }

		public ZoomVendorGetRequestBuilder()
			: base("vendor_zoomvendor", "get")
		{
		}

		public ZoomVendorGetRequestBuilder(int partnerId)
			: this()
		{
			this.PartnerId = partnerId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
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
			return ObjectFactory.Create<ZoomIntegrationSetting>(result);
		}
	}

	public class ZoomVendorOauthValidationRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		#endregion


		public ZoomVendorOauthValidationRequestBuilder()
			: base("vendor_zoomvendor", "oauthValidation")
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
			return result.Value<string>();
		}
	}

	public class ZoomVendorRecordingCompleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		#endregion


		public ZoomVendorRecordingCompleteRequestBuilder()
			: base("vendor_zoomvendor", "recordingComplete")
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
			return null;
		}
	}

	public class ZoomVendorSubmitRegistrationRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ACCOUNT_ID = "accountId";
		public const string INTEGRATION_SETTING = "integrationSetting";
		#endregion

		public string AccountId { get; set; }
		public ZoomIntegrationSetting IntegrationSetting { get; set; }

		public ZoomVendorSubmitRegistrationRequestBuilder()
			: base("vendor_zoomvendor", "submitRegistration")
		{
		}

		public ZoomVendorSubmitRegistrationRequestBuilder(string accountId, ZoomIntegrationSetting integrationSetting)
			: this()
		{
			this.AccountId = accountId;
			this.IntegrationSetting = integrationSetting;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("accountId"))
				kparams.AddIfNotNull("accountId", AccountId);
			if (!isMapped("integrationSetting"))
				kparams.AddIfNotNull("integrationSetting", IntegrationSetting);
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


	public class ZoomVendorService
	{
		private ZoomVendorService()
		{
		}

		public static ZoomVendorDeAuthorizationRequestBuilder DeAuthorization()
		{
			return new ZoomVendorDeAuthorizationRequestBuilder();
		}

		public static ZoomVendorFetchRegistrationPageRequestBuilder FetchRegistrationPage(string tokensData, string iv)
		{
			return new ZoomVendorFetchRegistrationPageRequestBuilder(tokensData, iv);
		}

		public static ZoomVendorGetRequestBuilder Get(int partnerId)
		{
			return new ZoomVendorGetRequestBuilder(partnerId);
		}

		public static ZoomVendorOauthValidationRequestBuilder OauthValidation()
		{
			return new ZoomVendorOauthValidationRequestBuilder();
		}

		public static ZoomVendorRecordingCompleteRequestBuilder RecordingComplete()
		{
			return new ZoomVendorRecordingCompleteRequestBuilder();
		}

		public static ZoomVendorSubmitRegistrationRequestBuilder SubmitRegistration(string accountId, ZoomIntegrationSetting integrationSetting)
		{
			return new ZoomVendorSubmitRegistrationRequestBuilder(accountId, integrationSetting);
		}
	}
}
