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
	public class GroupAddRequestBuilder : RequestBuilder<Group_>
	{
		#region Constants
		public const string GROUP = "group";
		#endregion

		public Group_ Group { get; set; }

		public GroupAddRequestBuilder()
			: base("group_group", "add")
		{
		}

		public GroupAddRequestBuilder(Group_ group)
			: this()
		{
			this.Group = group;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("group"))
				kparams.AddIfNotNull("group", Group);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Group_>(result);
		}
	}

	public class GroupCloneRequestBuilder : RequestBuilder<Group_>
	{
		#region Constants
		public const string ORIGINAL_GROUP_ID = "originalGroupId";
		public const string NEW_GROUP_ID = "newGroupId";
		public const string NEW_GROUP_NAME = "newGroupName";
		#endregion

		public string OriginalGroupId { get; set; }
		public string NewGroupId { get; set; }
		public string NewGroupName { get; set; }

		public GroupCloneRequestBuilder()
			: base("group_group", "clone")
		{
		}

		public GroupCloneRequestBuilder(string originalGroupId, string newGroupId, string newGroupName)
			: this()
		{
			this.OriginalGroupId = originalGroupId;
			this.NewGroupId = newGroupId;
			this.NewGroupName = newGroupName;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("originalGroupId"))
				kparams.AddIfNotNull("originalGroupId", OriginalGroupId);
			if (!isMapped("newGroupId"))
				kparams.AddIfNotNull("newGroupId", NewGroupId);
			if (!isMapped("newGroupName"))
				kparams.AddIfNotNull("newGroupName", NewGroupName);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Group_>(result);
		}
	}

	public class GroupDeleteRequestBuilder : RequestBuilder<Group_>
	{
		#region Constants
		public const string GROUP_ID = "groupId";
		#endregion

		public string GroupId { get; set; }

		public GroupDeleteRequestBuilder()
			: base("group_group", "delete")
		{
		}

		public GroupDeleteRequestBuilder(string groupId)
			: this()
		{
			this.GroupId = groupId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
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
			return ObjectFactory.Create<Group_>(result);
		}
	}

	public class GroupGetRequestBuilder : RequestBuilder<Group_>
	{
		#region Constants
		public const string GROUP_ID = "groupId";
		#endregion

		public string GroupId { get; set; }

		public GroupGetRequestBuilder()
			: base("group_group", "get")
		{
		}

		public GroupGetRequestBuilder(string groupId)
			: this()
		{
			this.GroupId = groupId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
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
			return ObjectFactory.Create<Group_>(result);
		}
	}

	public class GroupListRequestBuilder : RequestBuilder<ListResponse<Group_>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public GroupFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public GroupListRequestBuilder()
			: base("group_group", "list")
		{
		}

		public GroupListRequestBuilder(GroupFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<Group_>>(result);
		}
	}

	public class GroupUpdateRequestBuilder : RequestBuilder<Group_>
	{
		#region Constants
		public const string GROUP_ID = "groupId";
		public const string GROUP = "group";
		#endregion

		public string GroupId { get; set; }
		public Group_ Group { get; set; }

		public GroupUpdateRequestBuilder()
			: base("group_group", "update")
		{
		}

		public GroupUpdateRequestBuilder(string groupId, Group_ group)
			: this()
		{
			this.GroupId = groupId;
			this.Group = group;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("groupId"))
				kparams.AddIfNotNull("groupId", GroupId);
			if (!isMapped("group"))
				kparams.AddIfNotNull("group", Group);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Group_>(result);
		}
	}


	public class GroupService
	{
		private GroupService()
		{
		}

		public static GroupAddRequestBuilder Add(Group_ group)
		{
			return new GroupAddRequestBuilder(group);
		}

		public static GroupCloneRequestBuilder Clone(string originalGroupId, string newGroupId, string newGroupName = null)
		{
			return new GroupCloneRequestBuilder(originalGroupId, newGroupId, newGroupName);
		}

		public static GroupDeleteRequestBuilder Delete(string groupId)
		{
			return new GroupDeleteRequestBuilder(groupId);
		}

		public static GroupGetRequestBuilder Get(string groupId)
		{
			return new GroupGetRequestBuilder(groupId);
		}

		public static GroupListRequestBuilder List(GroupFilter filter = null, FilterPager pager = null)
		{
			return new GroupListRequestBuilder(filter, pager);
		}

		public static GroupUpdateRequestBuilder Update(string groupId, Group_ group)
		{
			return new GroupUpdateRequestBuilder(groupId, group);
		}
	}
}
