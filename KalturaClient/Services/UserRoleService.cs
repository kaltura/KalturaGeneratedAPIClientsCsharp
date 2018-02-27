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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class UserRoleAddRequestBuilder : RequestBuilder<UserRole>
	{
		#region Constants
		public const string USER_ROLE = "userRole";
		#endregion

		public UserRole UserRole
		{
			set;
			get;
		}

		public UserRoleAddRequestBuilder()
			: base("userrole", "add")
		{
		}

		public UserRoleAddRequestBuilder(UserRole userRole)
			: this()
		{
			this.UserRole = userRole;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userRole"))
				kparams.AddIfNotNull("userRole", UserRole);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<UserRole>(result);
		}
	}

	public class UserRoleCloneRequestBuilder : RequestBuilder<UserRole>
	{
		#region Constants
		public const string USER_ROLE_ID = "userRoleId";
		#endregion

		public int UserRoleId
		{
			set;
			get;
		}

		public UserRoleCloneRequestBuilder()
			: base("userrole", "clone")
		{
		}

		public UserRoleCloneRequestBuilder(int userRoleId)
			: this()
		{
			this.UserRoleId = userRoleId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userRoleId"))
				kparams.AddIfNotNull("userRoleId", UserRoleId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<UserRole>(result);
		}
	}

	public class UserRoleDeleteRequestBuilder : RequestBuilder<UserRole>
	{
		#region Constants
		public const string USER_ROLE_ID = "userRoleId";
		#endregion

		public int UserRoleId
		{
			set;
			get;
		}

		public UserRoleDeleteRequestBuilder()
			: base("userrole", "delete")
		{
		}

		public UserRoleDeleteRequestBuilder(int userRoleId)
			: this()
		{
			this.UserRoleId = userRoleId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userRoleId"))
				kparams.AddIfNotNull("userRoleId", UserRoleId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<UserRole>(result);
		}
	}

	public class UserRoleGetRequestBuilder : RequestBuilder<UserRole>
	{
		#region Constants
		public const string USER_ROLE_ID = "userRoleId";
		#endregion

		public int UserRoleId
		{
			set;
			get;
		}

		public UserRoleGetRequestBuilder()
			: base("userrole", "get")
		{
		}

		public UserRoleGetRequestBuilder(int userRoleId)
			: this()
		{
			this.UserRoleId = userRoleId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userRoleId"))
				kparams.AddIfNotNull("userRoleId", UserRoleId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<UserRole>(result);
		}
	}

	public class UserRoleListRequestBuilder : RequestBuilder<ListResponse<UserRole>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public UserRoleFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public UserRoleListRequestBuilder()
			: base("userrole", "list")
		{
		}

		public UserRoleListRequestBuilder(UserRoleFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<UserRole>>(result);
		}
	}

	public class UserRoleUpdateRequestBuilder : RequestBuilder<UserRole>
	{
		#region Constants
		public const string USER_ROLE_ID = "userRoleId";
		public const string USER_ROLE = "userRole";
		#endregion

		public int UserRoleId
		{
			set;
			get;
		}
		public UserRole UserRole
		{
			set;
			get;
		}

		public UserRoleUpdateRequestBuilder()
			: base("userrole", "update")
		{
		}

		public UserRoleUpdateRequestBuilder(int userRoleId, UserRole userRole)
			: this()
		{
			this.UserRoleId = userRoleId;
			this.UserRole = userRole;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("userRoleId"))
				kparams.AddIfNotNull("userRoleId", UserRoleId);
			if (!isMapped("userRole"))
				kparams.AddIfNotNull("userRole", UserRole);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<UserRole>(result);
		}
	}


	public class UserRoleService
	{
		private UserRoleService()
		{
		}

		public static UserRoleAddRequestBuilder Add(UserRole userRole)
		{
			return new UserRoleAddRequestBuilder(userRole);
		}

		public static UserRoleCloneRequestBuilder Clone(int userRoleId)
		{
			return new UserRoleCloneRequestBuilder(userRoleId);
		}

		public static UserRoleDeleteRequestBuilder Delete(int userRoleId)
		{
			return new UserRoleDeleteRequestBuilder(userRoleId);
		}

		public static UserRoleGetRequestBuilder Get(int userRoleId)
		{
			return new UserRoleGetRequestBuilder(userRoleId);
		}

		public static UserRoleListRequestBuilder List(UserRoleFilter filter = null, FilterPager pager = null)
		{
			return new UserRoleListRequestBuilder(filter, pager);
		}

		public static UserRoleUpdateRequestBuilder Update(int userRoleId, UserRole userRole)
		{
			return new UserRoleUpdateRequestBuilder(userRoleId, userRole);
		}
	}
}
