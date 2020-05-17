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
	public class VolatileInteractivityAddRequestBuilder : RequestBuilder<VolatileInteractivity>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string KALTURA_VOLATILE_INTERACTIVITY = "kalturaVolatileInteractivity";
		#endregion

		public string EntryId { get; set; }
		public VolatileInteractivity KalturaVolatileInteractivity { get; set; }

		public VolatileInteractivityAddRequestBuilder()
			: base("interactivity_volatileinteractivity", "add")
		{
		}

		public VolatileInteractivityAddRequestBuilder(string entryId, VolatileInteractivity kalturaVolatileInteractivity)
			: this()
		{
			this.EntryId = entryId;
			this.KalturaVolatileInteractivity = kalturaVolatileInteractivity;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("kalturaVolatileInteractivity"))
				kparams.AddIfNotNull("kalturaVolatileInteractivity", KalturaVolatileInteractivity);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VolatileInteractivity>(result);
		}
	}

	public class VolatileInteractivityDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public VolatileInteractivityDeleteRequestBuilder()
			: base("interactivity_volatileinteractivity", "delete")
		{
		}

		public VolatileInteractivityDeleteRequestBuilder(string entryId)
			: this()
		{
			this.EntryId = entryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
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

	public class VolatileInteractivityGetRequestBuilder : RequestBuilder<VolatileInteractivity>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public VolatileInteractivityGetRequestBuilder()
			: base("interactivity_volatileinteractivity", "get")
		{
		}

		public VolatileInteractivityGetRequestBuilder(string entryId)
			: this()
		{
			this.EntryId = entryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VolatileInteractivity>(result);
		}
	}

	public class VolatileInteractivityUpdateRequestBuilder : RequestBuilder<VolatileInteractivity>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string VERSION = "version";
		public const string KALTURA_VOLATILE_INTERACTIVITY = "kalturaVolatileInteractivity";
		#endregion

		public string EntryId { get; set; }
		public int Version { get; set; }
		public VolatileInteractivity KalturaVolatileInteractivity { get; set; }

		public VolatileInteractivityUpdateRequestBuilder()
			: base("interactivity_volatileinteractivity", "update")
		{
		}

		public VolatileInteractivityUpdateRequestBuilder(string entryId, int version, VolatileInteractivity kalturaVolatileInteractivity)
			: this()
		{
			this.EntryId = entryId;
			this.Version = version;
			this.KalturaVolatileInteractivity = kalturaVolatileInteractivity;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("version"))
				kparams.AddIfNotNull("version", Version);
			if (!isMapped("kalturaVolatileInteractivity"))
				kparams.AddIfNotNull("kalturaVolatileInteractivity", KalturaVolatileInteractivity);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<VolatileInteractivity>(result);
		}
	}


	public class VolatileInteractivityService
	{
		private VolatileInteractivityService()
		{
		}

		public static VolatileInteractivityAddRequestBuilder Add(string entryId, VolatileInteractivity kalturaVolatileInteractivity)
		{
			return new VolatileInteractivityAddRequestBuilder(entryId, kalturaVolatileInteractivity);
		}

		public static VolatileInteractivityDeleteRequestBuilder Delete(string entryId)
		{
			return new VolatileInteractivityDeleteRequestBuilder(entryId);
		}

		public static VolatileInteractivityGetRequestBuilder Get(string entryId)
		{
			return new VolatileInteractivityGetRequestBuilder(entryId);
		}

		public static VolatileInteractivityUpdateRequestBuilder Update(string entryId, int version, VolatileInteractivity kalturaVolatileInteractivity)
		{
			return new VolatileInteractivityUpdateRequestBuilder(entryId, version, kalturaVolatileInteractivity);
		}
	}
}
