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
// Copyright (C) 2006-2017  Kaltura Inc.
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

namespace Kaltura.Services
{
	public class GroupUserAddRequestBuilder : RequestBuilder<GroupUser>
	{
		#region Constants
		public const string GROUP_USER = "groupUser";
		#endregion

		public GroupUser GroupUser
		{
			set;
			get;
		}

		public GroupUserAddRequestBuilder()
			: base("groupuser", "add")
		{
		}

		public GroupUserAddRequestBuilder(GroupUser groupUser)
			: this()
		{
			this.GroupUser = groupUser;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("groupUser"))
				kparams.AddIfNotNull("groupUser", GroupUser);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<GroupUser>(result);
		}
	}

	public class GroupUserDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string GROUP_ID = "groupId";
		#endregion

		public string UserId
		{
			set;
			get;
		}
		public string GroupId
		{
			set;
			get;
		}

		public GroupUserDeleteRequestBuilder()
			: base("groupuser", "delete")
		{
		}

		public GroupUserDeleteRequestBuilder(string userId, string groupId)
			: this()
		{
			this.UserId = userId;
			this.GroupId = groupId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("groupId"))
				kparams.AddIfNotNull("groupId", GroupId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class GroupUserListRequestBuilder : RequestBuilder<ListResponse<GroupUser>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public GroupUserFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public GroupUserListRequestBuilder()
			: base("groupuser", "list")
		{
		}

		public GroupUserListRequestBuilder(GroupUserFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<GroupUser>>(result);
		}
	}


	public class GroupUserService
	{
		private GroupUserService()
		{
		}

		public static GroupUserAddRequestBuilder Add(GroupUser groupUser)
		{
			return new GroupUserAddRequestBuilder(groupUser);
		}

		public static GroupUserDeleteRequestBuilder Delete(string userId, string groupId)
		{
			return new GroupUserDeleteRequestBuilder(userId, groupId);
		}

		public static GroupUserListRequestBuilder List(GroupUserFilter filter = null, FilterPager pager = null)
		{
			return new GroupUserListRequestBuilder(filter, pager);
		}
	}
}
