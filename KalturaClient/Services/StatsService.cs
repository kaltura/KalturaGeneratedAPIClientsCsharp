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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class StatsCollectRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string EVENT = "event";
		#endregion

		public StatsEvent Kevent { get; set; }

		public StatsCollectRequestBuilder()
			: base("stats", "collect")
		{
		}

		public StatsCollectRequestBuilder(StatsEvent kevent)
			: this()
		{
			this.Kevent = kevent;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("kevent"))
				kparams.AddIfNotNull("kevent", Kevent);
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

	public class StatsKmcCollectRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string KMC_EVENT = "kmcEvent";
		#endregion

		public StatsKmcEvent KmcEvent { get; set; }

		public StatsKmcCollectRequestBuilder()
			: base("stats", "kmcCollect")
		{
		}

		public StatsKmcCollectRequestBuilder(StatsKmcEvent kmcEvent)
			: this()
		{
			this.KmcEvent = kmcEvent;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("kmcEvent"))
				kparams.AddIfNotNull("kmcEvent", KmcEvent);
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

	public class StatsReportDeviceCapabilitiesRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string DATA = "data";
		#endregion

		public string Data { get; set; }

		public StatsReportDeviceCapabilitiesRequestBuilder()
			: base("stats", "reportDeviceCapabilities")
		{
		}

		public StatsReportDeviceCapabilitiesRequestBuilder(string data)
			: this()
		{
			this.Data = data;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("data"))
				kparams.AddIfNotNull("data", Data);
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

	public class StatsReportErrorRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ERROR_CODE = "errorCode";
		public const string ERROR_MESSAGE = "errorMessage";
		#endregion

		public string ErrorCode { get; set; }
		public string ErrorMessage { get; set; }

		public StatsReportErrorRequestBuilder()
			: base("stats", "reportError")
		{
		}

		public StatsReportErrorRequestBuilder(string errorCode, string errorMessage)
			: this()
		{
			this.ErrorCode = errorCode;
			this.ErrorMessage = errorMessage;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("errorCode"))
				kparams.AddIfNotNull("errorCode", ErrorCode);
			if (!isMapped("errorMessage"))
				kparams.AddIfNotNull("errorMessage", ErrorMessage);
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

	public class StatsReportKceErrorRequestBuilder : RequestBuilder<CEError>
	{
		#region Constants
		public const string KALTURA_CE_ERROR = "kalturaCEError";
		#endregion

		public CEError KalturaCEError { get; set; }

		public StatsReportKceErrorRequestBuilder()
			: base("stats", "reportKceError")
		{
		}

		public StatsReportKceErrorRequestBuilder(CEError kalturaCEError)
			: this()
		{
			this.KalturaCEError = kalturaCEError;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("kalturaCEError"))
				kparams.AddIfNotNull("kalturaCEError", KalturaCEError);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<CEError>(result);
		}
	}


	public class StatsService
	{
		private StatsService()
		{
		}

		public static StatsCollectRequestBuilder Collect(StatsEvent kevent)
		{
			return new StatsCollectRequestBuilder(kevent);
		}

		public static StatsKmcCollectRequestBuilder KmcCollect(StatsKmcEvent kmcEvent)
		{
			return new StatsKmcCollectRequestBuilder(kmcEvent);
		}

		public static StatsReportDeviceCapabilitiesRequestBuilder ReportDeviceCapabilities(string data)
		{
			return new StatsReportDeviceCapabilitiesRequestBuilder(data);
		}

		public static StatsReportErrorRequestBuilder ReportError(string errorCode, string errorMessage)
		{
			return new StatsReportErrorRequestBuilder(errorCode, errorMessage);
		}

		public static StatsReportKceErrorRequestBuilder ReportKceError(CEError kalturaCEError)
		{
			return new StatsReportKceErrorRequestBuilder(kalturaCEError);
		}
	}
}
