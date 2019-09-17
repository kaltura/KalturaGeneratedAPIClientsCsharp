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
		public const string DEFAULT_USER_ID = "defaultUserId";
		public const string ZOOM_CATEGORY = "zoomCategory";
		public const string ACCOUNT_ID = "accountId";
		public const string ENABLE_RECORDING_UPLOAD = "enableRecordingUpload";
		public const string CREATE_USER_IF_NOT_EXIST = "createUserIfNotExist";
		public const string HANDLE_PARTICIPANT_MODE = "handleParticipantMode";
		public const string ZOOM_USER_MATCHING_MODE = "zoomUserMatchingMode";
		public const string ZOOM_USER_POSTFIX = "zoomUserPostfix";
		#endregion

		public string DefaultUserId { get; set; }
		public string ZoomCategory { get; set; }
		public string AccountId { get; set; }
		public bool EnableRecordingUpload { get; set; }
		public bool CreateUserIfNotExist { get; set; }
		public int HandleParticipantMode { get; set; }
		public int ZoomUserMatchingMode { get; set; }
		public string ZoomUserPostfix { get; set; }

		public ZoomVendorSubmitRegistrationRequestBuilder()
			: base("vendor_zoomvendor", "submitRegistration")
		{
		}

		public ZoomVendorSubmitRegistrationRequestBuilder(string defaultUserId, string zoomCategory, string accountId, bool enableRecordingUpload, bool createUserIfNotExist, int handleParticipantMode, int zoomUserMatchingMode, string zoomUserPostfix)
			: this()
		{
			this.DefaultUserId = defaultUserId;
			this.ZoomCategory = zoomCategory;
			this.AccountId = accountId;
			this.EnableRecordingUpload = enableRecordingUpload;
			this.CreateUserIfNotExist = createUserIfNotExist;
			this.HandleParticipantMode = handleParticipantMode;
			this.ZoomUserMatchingMode = zoomUserMatchingMode;
			this.ZoomUserPostfix = zoomUserPostfix;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("defaultUserId"))
				kparams.AddIfNotNull("defaultUserId", DefaultUserId);
			if (!isMapped("zoomCategory"))
				kparams.AddIfNotNull("zoomCategory", ZoomCategory);
			if (!isMapped("accountId"))
				kparams.AddIfNotNull("accountId", AccountId);
			if (!isMapped("enableRecordingUpload"))
				kparams.AddIfNotNull("enableRecordingUpload", EnableRecordingUpload);
			if (!isMapped("createUserIfNotExist"))
				kparams.AddIfNotNull("createUserIfNotExist", CreateUserIfNotExist);
			if (!isMapped("handleParticipantMode"))
				kparams.AddIfNotNull("handleParticipantMode", HandleParticipantMode);
			if (!isMapped("zoomUserMatchingMode"))
				kparams.AddIfNotNull("zoomUserMatchingMode", ZoomUserMatchingMode);
			if (!isMapped("zoomUserPostfix"))
				kparams.AddIfNotNull("zoomUserPostfix", ZoomUserPostfix);
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

		public static ZoomVendorOauthValidationRequestBuilder OauthValidation()
		{
			return new ZoomVendorOauthValidationRequestBuilder();
		}

		public static ZoomVendorRecordingCompleteRequestBuilder RecordingComplete()
		{
			return new ZoomVendorRecordingCompleteRequestBuilder();
		}

		public static ZoomVendorSubmitRegistrationRequestBuilder SubmitRegistration(string defaultUserId, string zoomCategory, string accountId, bool enableRecordingUpload, bool createUserIfNotExist, int handleParticipantMode, int zoomUserMatchingMode, string zoomUserPostfix = "")
		{
			return new ZoomVendorSubmitRegistrationRequestBuilder(defaultUserId, zoomCategory, accountId, enableRecordingUpload, createUserIfNotExist, handleParticipantMode, zoomUserMatchingMode, zoomUserPostfix);
		}
	}
}
