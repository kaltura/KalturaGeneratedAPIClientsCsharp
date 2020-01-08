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
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class Group_ : BaseUser
	{
		#region Constants
		public const string MEMBERS_COUNT = "membersCount";
		public const string PROCESS_STATUS = "processStatus";
		#endregion

		#region Private Fields
		private int _MembersCount = Int32.MinValue;
		private GroupProcessStatus _ProcessStatus = (GroupProcessStatus)Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int MembersCount
		{
			get { return _MembersCount; }
			private set 
			{ 
				_MembersCount = value;
				OnPropertyChanged("MembersCount");
			}
		}
		[JsonProperty]
		public GroupProcessStatus ProcessStatus
		{
			get { return _ProcessStatus; }
			set 
			{ 
				_ProcessStatus = value;
				OnPropertyChanged("ProcessStatus");
			}
		}
		#endregion

		#region CTor
		public Group_()
		{
		}

		public Group_(JToken node) : base(node)
		{
			if(node["membersCount"] != null)
			{
				this._MembersCount = ParseInt(node["membersCount"].Value<string>());
			}
			if(node["processStatus"] != null)
			{
				this._ProcessStatus = (GroupProcessStatus)ParseEnum(typeof(GroupProcessStatus), node["processStatus"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGroup");
			kparams.AddIfNotNull("membersCount", this._MembersCount);
			kparams.AddIfNotNull("processStatus", this._ProcessStatus);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MEMBERS_COUNT:
					return "MembersCount";
				case PROCESS_STATUS:
					return "ProcessStatus";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

