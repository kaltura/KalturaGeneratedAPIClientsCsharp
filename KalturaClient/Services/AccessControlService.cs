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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class AccessControlAddRequestBuilder : RequestBuilder<AccessControl>
	{
		#region Constants
		public const string ACCESS_CONTROL = "accessControl";
		#endregion

		public AccessControl AccessControl
		{
			set;
			get;
		}

		public AccessControlAddRequestBuilder()
			: base("accesscontrol", "add")
		{
		}

		public AccessControlAddRequestBuilder(AccessControl accessControl)
			: this()
		{
			this.AccessControl = accessControl;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("accessControl"))
				kparams.AddIfNotNull("accessControl", AccessControl);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<AccessControl>(result);
		}
	}

	public class AccessControlDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public AccessControlDeleteRequestBuilder()
			: base("accesscontrol", "delete")
		{
		}

		public AccessControlDeleteRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
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

	public class AccessControlGetRequestBuilder : RequestBuilder<AccessControl>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public AccessControlGetRequestBuilder()
			: base("accesscontrol", "get")
		{
		}

		public AccessControlGetRequestBuilder(int id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<AccessControl>(result);
		}
	}

	public class AccessControlListRequestBuilder : RequestBuilder<ListResponse<AccessControl>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public AccessControlFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public AccessControlListRequestBuilder()
			: base("accesscontrol", "list")
		{
		}

		public AccessControlListRequestBuilder(AccessControlFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<AccessControl>>(result);
		}
	}

	public class AccessControlUpdateRequestBuilder : RequestBuilder<AccessControl>
	{
		#region Constants
		public const string ID = "id";
		public const string ACCESS_CONTROL = "accessControl";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public AccessControl AccessControl
		{
			set;
			get;
		}

		public AccessControlUpdateRequestBuilder()
			: base("accesscontrol", "update")
		{
		}

		public AccessControlUpdateRequestBuilder(int id, AccessControl accessControl)
			: this()
		{
			this.Id = id;
			this.AccessControl = accessControl;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("accessControl"))
				kparams.AddIfNotNull("accessControl", AccessControl);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<AccessControl>(result);
		}
	}


	public class AccessControlService
	{
		private AccessControlService()
		{
		}

		public static AccessControlAddRequestBuilder Add(AccessControl accessControl)
		{
			return new AccessControlAddRequestBuilder(accessControl);
		}

		public static AccessControlDeleteRequestBuilder Delete(int id)
		{
			return new AccessControlDeleteRequestBuilder(id);
		}

		public static AccessControlGetRequestBuilder Get(int id)
		{
			return new AccessControlGetRequestBuilder(id);
		}

		public static AccessControlListRequestBuilder List(AccessControlFilter filter = null, FilterPager pager = null)
		{
			return new AccessControlListRequestBuilder(filter, pager);
		}

		public static AccessControlUpdateRequestBuilder Update(int id, AccessControl accessControl)
		{
			return new AccessControlUpdateRequestBuilder(id, accessControl);
		}
	}
}
