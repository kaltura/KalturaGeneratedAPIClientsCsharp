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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class VendorIntegrationAddRequestBuilder : RequestBuilder<IntegrationSetting>
	{
		#region Constants
		public const string INTEGRATION = "integration";
		public const string REMOTE_ID = "remoteId";
		#endregion

		public IntegrationSetting Integration { get; set; }
		public string RemoteId { get; set; }

		public VendorIntegrationAddRequestBuilder()
			: base("vendor_vendorintegration", "add")
		{
		}

		public VendorIntegrationAddRequestBuilder(IntegrationSetting integration, string remoteId)
			: this()
		{
			this.Integration = integration;
			this.RemoteId = remoteId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("integration"))
				kparams.AddIfNotNull("integration", Integration);
			if (!isMapped("remoteId"))
				kparams.AddIfNotNull("remoteId", RemoteId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<IntegrationSetting>(result);
		}
	}

	public class VendorIntegrationDeleteRequestBuilder : RequestBuilder<IntegrationSetting>
	{
		#region Constants
		public const string INTEGRATION_ID = "integrationId";
		#endregion

		public int IntegrationId { get; set; }

		public VendorIntegrationDeleteRequestBuilder()
			: base("vendor_vendorintegration", "delete")
		{
		}

		public VendorIntegrationDeleteRequestBuilder(int integrationId)
			: this()
		{
			this.IntegrationId = integrationId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("integrationId"))
				kparams.AddIfNotNull("integrationId", IntegrationId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<IntegrationSetting>(result);
		}
	}

	public class VendorIntegrationGetRequestBuilder : RequestBuilder<IntegrationSetting>
	{
		#region Constants
		public const string INTEGRATION_ID = "integrationId";
		#endregion

		public int IntegrationId { get; set; }

		public VendorIntegrationGetRequestBuilder()
			: base("vendor_vendorintegration", "get")
		{
		}

		public VendorIntegrationGetRequestBuilder(int integrationId)
			: this()
		{
			this.IntegrationId = integrationId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("integrationId"))
				kparams.AddIfNotNull("integrationId", IntegrationId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<IntegrationSetting>(result);
		}
	}

	public class VendorIntegrationUpdateRequestBuilder : RequestBuilder<IntegrationSetting>
	{
		#region Constants
		public const string ID = "id";
		public const string INTEGRATION_SETTING = "integrationSetting";
		#endregion

		public int Id { get; set; }
		public IntegrationSetting IntegrationSetting { get; set; }

		public VendorIntegrationUpdateRequestBuilder()
			: base("vendor_vendorintegration", "update")
		{
		}

		public VendorIntegrationUpdateRequestBuilder(int id, IntegrationSetting integrationSetting)
			: this()
		{
			this.Id = id;
			this.IntegrationSetting = integrationSetting;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
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
			return ObjectFactory.Create<IntegrationSetting>(result);
		}
	}

	public class VendorIntegrationUpdateStatusRequestBuilder : RequestBuilder<IntegrationSetting>
	{
		#region Constants
		public const string ID = "id";
		public const string STATUS = "status";
		#endregion

		public int Id { get; set; }
		public VendorIntegrationStatus Status { get; set; }

		public VendorIntegrationUpdateStatusRequestBuilder()
			: base("vendor_vendorintegration", "updateStatus")
		{
		}

		public VendorIntegrationUpdateStatusRequestBuilder(int id, VendorIntegrationStatus status)
			: this()
		{
			this.Id = id;
			this.Status = status;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("status"))
				kparams.AddIfNotNull("status", Status);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<IntegrationSetting>(result);
		}
	}


	public class VendorIntegrationService
	{
		private VendorIntegrationService()
		{
		}

		public static VendorIntegrationAddRequestBuilder Add(IntegrationSetting integration, string remoteId)
		{
			return new VendorIntegrationAddRequestBuilder(integration, remoteId);
		}

		public static VendorIntegrationDeleteRequestBuilder Delete(int integrationId)
		{
			return new VendorIntegrationDeleteRequestBuilder(integrationId);
		}

		public static VendorIntegrationGetRequestBuilder Get(int integrationId)
		{
			return new VendorIntegrationGetRequestBuilder(integrationId);
		}

		public static VendorIntegrationUpdateRequestBuilder Update(int id, IntegrationSetting integrationSetting)
		{
			return new VendorIntegrationUpdateRequestBuilder(id, integrationSetting);
		}

		public static VendorIntegrationUpdateStatusRequestBuilder UpdateStatus(int id, VendorIntegrationStatus status)
		{
			return new VendorIntegrationUpdateStatusRequestBuilder(id, status);
		}
	}
}
