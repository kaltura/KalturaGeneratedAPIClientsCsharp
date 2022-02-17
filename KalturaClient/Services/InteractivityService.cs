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
	public class InteractivityAddRequestBuilder : RequestBuilder<Interactivity>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string KALTURA_INTERACTIVITY = "kalturaInteractivity";
		#endregion

		public string EntryId { get; set; }
		public Interactivity KalturaInteractivity { get; set; }

		public InteractivityAddRequestBuilder()
			: base("interactivity_interactivity", "add")
		{
		}

		public InteractivityAddRequestBuilder(string entryId, Interactivity kalturaInteractivity)
			: this()
		{
			this.EntryId = entryId;
			this.KalturaInteractivity = kalturaInteractivity;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("kalturaInteractivity"))
				kparams.AddIfNotNull("kalturaInteractivity", KalturaInteractivity);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Interactivity>(result);
		}
	}

	public class InteractivityDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public InteractivityDeleteRequestBuilder()
			: base("interactivity_interactivity", "delete")
		{
		}

		public InteractivityDeleteRequestBuilder(string entryId)
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

	public class InteractivityGetRequestBuilder : RequestBuilder<Interactivity>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string DATA_FILTER = "dataFilter";
		#endregion

		public string EntryId { get; set; }
		public InteractivityDataFilter DataFilter { get; set; }

		public InteractivityGetRequestBuilder()
			: base("interactivity_interactivity", "get")
		{
		}

		public InteractivityGetRequestBuilder(string entryId, InteractivityDataFilter dataFilter)
			: this()
		{
			this.EntryId = entryId;
			this.DataFilter = dataFilter;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("dataFilter"))
				kparams.AddIfNotNull("dataFilter", DataFilter);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Interactivity>(result);
		}
	}

	public class InteractivityUpdateRequestBuilder : RequestBuilder<Interactivity>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string VERSION = "version";
		public const string KALTURA_INTERACTIVITY = "kalturaInteractivity";
		#endregion

		public string EntryId { get; set; }
		public int Version { get; set; }
		public Interactivity KalturaInteractivity { get; set; }

		public InteractivityUpdateRequestBuilder()
			: base("interactivity_interactivity", "update")
		{
		}

		public InteractivityUpdateRequestBuilder(string entryId, int version, Interactivity kalturaInteractivity)
			: this()
		{
			this.EntryId = entryId;
			this.Version = version;
			this.KalturaInteractivity = kalturaInteractivity;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("version"))
				kparams.AddIfNotNull("version", Version);
			if (!isMapped("kalturaInteractivity"))
				kparams.AddIfNotNull("kalturaInteractivity", KalturaInteractivity);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Interactivity>(result);
		}
	}


	public class InteractivityService
	{
		private InteractivityService()
		{
		}

		public static InteractivityAddRequestBuilder Add(string entryId, Interactivity kalturaInteractivity)
		{
			return new InteractivityAddRequestBuilder(entryId, kalturaInteractivity);
		}

		public static InteractivityDeleteRequestBuilder Delete(string entryId)
		{
			return new InteractivityDeleteRequestBuilder(entryId);
		}

		public static InteractivityGetRequestBuilder Get(string entryId, InteractivityDataFilter dataFilter = null)
		{
			return new InteractivityGetRequestBuilder(entryId, dataFilter);
		}

		public static InteractivityUpdateRequestBuilder Update(string entryId, int version, Interactivity kalturaInteractivity)
		{
			return new InteractivityUpdateRequestBuilder(entryId, version, kalturaInteractivity);
		}
	}
}
