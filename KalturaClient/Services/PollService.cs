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
	public class PollAddRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string POLL_TYPE = "pollType";
		#endregion

		public string PollType { get; set; }

		public PollAddRequestBuilder()
			: base("poll_poll", "add")
		{
		}

		public PollAddRequestBuilder(string pollType)
			: this()
		{
			this.PollType = pollType;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("pollType"))
				kparams.AddIfNotNull("pollType", PollType);
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

	public class PollGetVoteRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string POLL_ID = "pollId";
		public const string USER_ID = "userId";
		#endregion

		public string PollId { get; set; }
		public string UserId { get; set; }

		public PollGetVoteRequestBuilder()
			: base("poll_poll", "getVote")
		{
		}

		public PollGetVoteRequestBuilder(string pollId, string userId)
			: this()
		{
			this.PollId = pollId;
			this.UserId = userId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("pollId"))
				kparams.AddIfNotNull("pollId", PollId);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
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

	public class PollGetVotesRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string POLL_ID = "pollId";
		public const string ANSWER_IDS = "answerIds";
		#endregion

		public string PollId { get; set; }
		public string AnswerIds { get; set; }

		public PollGetVotesRequestBuilder()
			: base("poll_poll", "getVotes")
		{
		}

		public PollGetVotesRequestBuilder(string pollId, string answerIds)
			: this()
		{
			this.PollId = pollId;
			this.AnswerIds = answerIds;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("pollId"))
				kparams.AddIfNotNull("pollId", PollId);
			if (!isMapped("answerIds"))
				kparams.AddIfNotNull("answerIds", AnswerIds);
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

	public class PollResetVotesRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string POLL_ID = "pollId";
		#endregion

		public string PollId { get; set; }

		public PollResetVotesRequestBuilder()
			: base("poll_poll", "resetVotes")
		{
		}

		public PollResetVotesRequestBuilder(string pollId)
			: this()
		{
			this.PollId = pollId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("pollId"))
				kparams.AddIfNotNull("pollId", PollId);
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

	public class PollVoteRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string POLL_ID = "pollId";
		public const string USER_ID = "userId";
		public const string ANSWER_IDS = "answerIds";
		#endregion

		public string PollId { get; set; }
		public string UserId { get; set; }
		public string AnswerIds { get; set; }

		public PollVoteRequestBuilder()
			: base("poll_poll", "vote")
		{
		}

		public PollVoteRequestBuilder(string pollId, string userId, string answerIds)
			: this()
		{
			this.PollId = pollId;
			this.UserId = userId;
			this.AnswerIds = answerIds;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("pollId"))
				kparams.AddIfNotNull("pollId", PollId);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("answerIds"))
				kparams.AddIfNotNull("answerIds", AnswerIds);
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


	public class PollService
	{
		private PollService()
		{
		}

		public static PollAddRequestBuilder Add(string pollType = "SINGLE_ANONYMOUS")
		{
			return new PollAddRequestBuilder(pollType);
		}

		public static PollGetVoteRequestBuilder GetVote(string pollId, string userId)
		{
			return new PollGetVoteRequestBuilder(pollId, userId);
		}

		public static PollGetVotesRequestBuilder GetVotes(string pollId, string answerIds)
		{
			return new PollGetVotesRequestBuilder(pollId, answerIds);
		}

		public static PollResetVotesRequestBuilder ResetVotes(string pollId)
		{
			return new PollResetVotesRequestBuilder(pollId);
		}

		public static PollVoteRequestBuilder Vote(string pollId, string userId, string answerIds)
		{
			return new PollVoteRequestBuilder(pollId, userId, answerIds);
		}
	}
}
