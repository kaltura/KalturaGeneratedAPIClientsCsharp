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
	public class GroupUserAddRequestBuilder : RequestBuilder<GroupUser>
	{
		#region Constants
		public const string GROUP_USER = "groupUser";
		#endregion

		public GroupUser GroupUser { get; set; }

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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GroupUser>(result);
		}
	}

	public class GroupUserDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string GROUP_ID = "groupId";
		#endregion

		public string UserId { get; set; }
		public string GroupId { get; set; }

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

		public override object Deserialize(JToken result)
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

		public GroupUserFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<ListResponse<GroupUser>>(result);
		}
	}

	public class GroupUserSyncRequestBuilder : RequestBuilder<BulkUpload>
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string GROUP_IDS = "groupIds";
		public const string REMOVE_FROM_EXISTING_GROUPS = "removeFromExistingGroups";
		public const string CREATE_NEW_GROUPS = "createNewGroups";
		#endregion

		public string UserId { get; set; }
		public string GroupIds { get; set; }
		public bool RemoveFromExistingGroups { get; set; }
		public bool CreateNewGroups { get; set; }

		public GroupUserSyncRequestBuilder()
			: base("groupuser", "sync")
		{
		}

		public GroupUserSyncRequestBuilder(string userId, string groupIds, bool removeFromExistingGroups, bool createNewGroups)
			: this()
		{
			this.UserId = userId;
			this.GroupIds = groupIds;
			this.RemoveFromExistingGroups = removeFromExistingGroups;
			this.CreateNewGroups = createNewGroups;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userId"))
				kparams.AddIfNotNull("userId", UserId);
			if (!isMapped("groupIds"))
				kparams.AddIfNotNull("groupIds", GroupIds);
			if (!isMapped("removeFromExistingGroups"))
				kparams.AddIfNotNull("removeFromExistingGroups", RemoveFromExistingGroups);
			if (!isMapped("createNewGroups"))
				kparams.AddIfNotNull("createNewGroups", CreateNewGroups);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<BulkUpload>(result);
		}
	}

	public class GroupUserUpdateRequestBuilder : RequestBuilder<GroupUser>
	{
		#region Constants
		public const string GROUP_USER_ID = "groupUserId";
		public const string GROUP_USER = "groupUser";
		#endregion

		public string GroupUserId { get; set; }
		public GroupUser GroupUser { get; set; }

		public GroupUserUpdateRequestBuilder()
			: base("groupuser", "update")
		{
		}

		public GroupUserUpdateRequestBuilder(string groupUserId, GroupUser groupUser)
			: this()
		{
			this.GroupUserId = groupUserId;
			this.GroupUser = groupUser;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("groupUserId"))
				kparams.AddIfNotNull("groupUserId", GroupUserId);
			if (!isMapped("groupUser"))
				kparams.AddIfNotNull("groupUser", GroupUser);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GroupUser>(result);
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

		public static GroupUserSyncRequestBuilder Sync(string userId, string groupIds = null, bool removeFromExistingGroups = true, bool createNewGroups = true)
		{
			return new GroupUserSyncRequestBuilder(userId, groupIds, removeFromExistingGroups, createNewGroups);
		}

		public static GroupUserUpdateRequestBuilder Update(string groupUserId, GroupUser groupUser)
		{
			return new GroupUserUpdateRequestBuilder(groupUserId, groupUser);
		}
	}
}
