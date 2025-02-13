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
	public class BumperAddRequestBuilder : RequestBuilder<Bumper>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string BUMPER = "bumper";
		#endregion

		public string EntryId { get; set; }
		public Bumper Bumper { get; set; }

		public BumperAddRequestBuilder()
			: base("bumper_bumper", "add")
		{
		}

		public BumperAddRequestBuilder(string entryId, Bumper bumper)
			: this()
		{
			this.EntryId = entryId;
			this.Bumper = bumper;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("bumper"))
				kparams.AddIfNotNull("bumper", Bumper);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Bumper>(result);
		}
	}

	public class BumperDeleteRequestBuilder : RequestBuilder<Bumper>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public BumperDeleteRequestBuilder()
			: base("bumper_bumper", "delete")
		{
		}

		public BumperDeleteRequestBuilder(string entryId)
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
			return ObjectFactory.Create<Bumper>(result);
		}
	}

	public class BumperGetRequestBuilder : RequestBuilder<Bumper>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public BumperGetRequestBuilder()
			: base("bumper_bumper", "get")
		{
		}

		public BumperGetRequestBuilder(string entryId)
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
			return ObjectFactory.Create<Bumper>(result);
		}
	}

	public class BumperUpdateRequestBuilder : RequestBuilder<Bumper>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string BUMPER = "bumper";
		#endregion

		public string EntryId { get; set; }
		public Bumper Bumper { get; set; }

		public BumperUpdateRequestBuilder()
			: base("bumper_bumper", "update")
		{
		}

		public BumperUpdateRequestBuilder(string entryId, Bumper bumper)
			: this()
		{
			this.EntryId = entryId;
			this.Bumper = bumper;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("bumper"))
				kparams.AddIfNotNull("bumper", Bumper);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Bumper>(result);
		}
	}


	public class BumperService
	{
		private BumperService()
		{
		}

		public static BumperAddRequestBuilder Add(string entryId, Bumper bumper)
		{
			return new BumperAddRequestBuilder(entryId, bumper);
		}

		public static BumperDeleteRequestBuilder Delete(string entryId)
		{
			return new BumperDeleteRequestBuilder(entryId);
		}

		public static BumperGetRequestBuilder Get(string entryId)
		{
			return new BumperGetRequestBuilder(entryId);
		}

		public static BumperUpdateRequestBuilder Update(string entryId, Bumper bumper)
		{
			return new BumperUpdateRequestBuilder(entryId, bumper);
		}
	}
}
