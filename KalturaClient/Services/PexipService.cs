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
	public class PexipGenerateSipUrlRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string REGENERATE = "regenerate";
		public const string SOURCE_TYPE = "sourceType";
		#endregion

		public string EntryId { get; set; }
		public bool Regenerate { get; set; }
		public SipSourceType SourceType { get; set; }

		public PexipGenerateSipUrlRequestBuilder()
			: base("sip_pexip", "generateSipUrl")
		{
		}

		public PexipGenerateSipUrlRequestBuilder(string entryId, bool regenerate, SipSourceType sourceType)
			: this()
		{
			this.EntryId = entryId;
			this.Regenerate = regenerate;
			this.SourceType = sourceType;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("regenerate"))
				kparams.AddIfNotNull("regenerate", Regenerate);
			if (!isMapped("sourceType"))
				kparams.AddIfNotNull("sourceType", SourceType);
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

	public class PexipHandleIncomingCallRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		#endregion


		public PexipHandleIncomingCallRequestBuilder()
			: base("sip_pexip", "handleIncomingCall")
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

	public class PexipListRoomsRequestBuilder : RequestBuilder<IList<StringValue>>
	{
		#region Constants
		public const string OFFSET = "offset";
		public const string PAGE_SIZE = "pageSize";
		public const string ACTIVE_ONLY = "activeOnly";
		#endregion

		public int Offset { get; set; }
		public int PageSize { get; set; }
		public bool ActiveOnly { get; set; }

		public PexipListRoomsRequestBuilder()
			: base("sip_pexip", "listRooms")
		{
		}

		public PexipListRoomsRequestBuilder(int offset, int pageSize, bool activeOnly)
			: this()
		{
			this.Offset = offset;
			this.PageSize = pageSize;
			this.ActiveOnly = activeOnly;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("offset"))
				kparams.AddIfNotNull("offset", Offset);
			if (!isMapped("pageSize"))
				kparams.AddIfNotNull("pageSize", PageSize);
			if (!isMapped("activeOnly"))
				kparams.AddIfNotNull("activeOnly", ActiveOnly);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			IList<StringValue> list = new List<StringValue>();
			foreach(var node in result.Children())
			{
				//TODO: Deserilize Array;
				list.Add(ObjectFactory.Create<StringValue>(node));
			}
			return list;
		}
	}


	public class PexipService
	{
		private PexipService()
		{
		}

		public static PexipGenerateSipUrlRequestBuilder GenerateSipUrl(string entryId, bool regenerate = false, SipSourceType sourceType = (SipSourceType)(1))
		{
			return new PexipGenerateSipUrlRequestBuilder(entryId, regenerate, sourceType);
		}

		public static PexipHandleIncomingCallRequestBuilder HandleIncomingCall()
		{
			return new PexipHandleIncomingCallRequestBuilder();
		}

		public static PexipListRoomsRequestBuilder ListRooms(int offset = 0, int pageSize = 500, bool activeOnly = false)
		{
			return new PexipListRoomsRequestBuilder(offset, pageSize, activeOnly);
		}
	}
}
