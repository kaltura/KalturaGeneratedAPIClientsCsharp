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
	public class SharepointExtensionIsVersionSupportedRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string SERVER_MAJOR = "serverMajor";
		public const string SERVER_MINOR = "serverMinor";
		public const string SERVER_BUILD = "serverBuild";
		#endregion

		public int ServerMajor { get; set; }
		public int ServerMinor { get; set; }
		public int ServerBuild { get; set; }

		public SharepointExtensionIsVersionSupportedRequestBuilder()
			: base("kalturasharepointextension_sharepointextension", "isVersionSupported")
		{
		}

		public SharepointExtensionIsVersionSupportedRequestBuilder(int serverMajor, int serverMinor, int serverBuild)
			: this()
		{
			this.ServerMajor = serverMajor;
			this.ServerMinor = serverMinor;
			this.ServerBuild = serverBuild;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("serverMajor"))
				kparams.AddIfNotNull("serverMajor", ServerMajor);
			if (!isMapped("serverMinor"))
				kparams.AddIfNotNull("serverMinor", ServerMinor);
			if (!isMapped("serverBuild"))
				kparams.AddIfNotNull("serverBuild", ServerBuild);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			if (result.Value<string>().Equals("1") || result.Value<string>().ToLower().Equals("true"))
				return true;
			return false;
		}
	}

	public class SharepointExtensionListUiconfsRequestBuilder : RequestBuilder<ListResponse<UiConf>>
	{
		#region Constants
		#endregion


		public SharepointExtensionListUiconfsRequestBuilder()
			: base("kalturasharepointextension_sharepointextension", "listUiconfs")
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
			return ObjectFactory.Create<ListResponse<UiConf>>(result);
		}
	}


	public class SharepointExtensionService
	{
		private SharepointExtensionService()
		{
		}

		public static SharepointExtensionIsVersionSupportedRequestBuilder IsVersionSupported(int serverMajor, int serverMinor, int serverBuild)
		{
			return new SharepointExtensionIsVersionSupportedRequestBuilder(serverMajor, serverMinor, serverBuild);
		}

		public static SharepointExtensionListUiconfsRequestBuilder ListUiconfs()
		{
			return new SharepointExtensionListUiconfsRequestBuilder();
		}
	}
}
