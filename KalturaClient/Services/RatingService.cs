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
	public class RatingCheckRatingRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public RatingCheckRatingRequestBuilder()
			: base("rating_rating", "checkRating")
		{
		}

		public RatingCheckRatingRequestBuilder(string entryId)
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
			return result.Value<int>();
		}
	}

	public class RatingGetRatingCountsRequestBuilder : RequestBuilder<ListResponse<RatingCount>>
	{
		#region Constants
		public const string FILTER = "filter";
		#endregion

		public RatingCountFilter Filter { get; set; }

		public RatingGetRatingCountsRequestBuilder()
			: base("rating_rating", "getRatingCounts")
		{
		}

		public RatingGetRatingCountsRequestBuilder(RatingCountFilter filter)
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
			return ObjectFactory.Create<ListResponse<RatingCount>>(result);
		}
	}

	public class RatingRateRequestBuilder : RequestBuilder<int>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string RANK = "rank";
		#endregion

		public string EntryId { get; set; }
		public int Rank { get; set; }

		public RatingRateRequestBuilder()
			: base("rating_rating", "rate")
		{
		}

		public RatingRateRequestBuilder(string entryId, int rank)
			: this()
		{
			this.EntryId = entryId;
			this.Rank = rank;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("rank"))
				kparams.AddIfNotNull("rank", Rank);
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

	public class RatingRemoveRatingRequestBuilder : RequestBuilder<bool>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		#endregion

		public string EntryId { get; set; }

		public RatingRemoveRatingRequestBuilder()
			: base("rating_rating", "removeRating")
		{
		}

		public RatingRemoveRatingRequestBuilder(string entryId)
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
			if (result.Value<string>().Equals("1") || result.Value<string>().ToLower().Equals("true"))
				return true;
			return false;
		}
	}


	public class RatingService
	{
		private RatingService()
		{
		}

		public static RatingCheckRatingRequestBuilder CheckRating(string entryId)
		{
			return new RatingCheckRatingRequestBuilder(entryId);
		}

		public static RatingGetRatingCountsRequestBuilder GetRatingCounts(RatingCountFilter filter)
		{
			return new RatingGetRatingCountsRequestBuilder(filter);
		}

		public static RatingRateRequestBuilder Rate(string entryId, int rank)
		{
			return new RatingRateRequestBuilder(entryId, rank);
		}

		public static RatingRemoveRatingRequestBuilder RemoveRating(string entryId)
		{
			return new RatingRemoveRatingRequestBuilder(entryId);
		}
	}
}
