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
	public class WidgetAddRequestBuilder : RequestBuilder<Widget>
	{
		#region Constants
		public const string WIDGET = "widget";
		#endregion

		public Widget Widget { get; set; }

		public WidgetAddRequestBuilder()
			: base("widget", "add")
		{
		}

		public WidgetAddRequestBuilder(Widget widget)
			: this()
		{
			this.Widget = widget;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("widget"))
				kparams.AddIfNotNull("widget", Widget);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Widget>(result);
		}
	}

	public class WidgetCloneRequestBuilder : RequestBuilder<Widget>
	{
		#region Constants
		public const string WIDGET = "widget";
		#endregion

		public Widget Widget { get; set; }

		public WidgetCloneRequestBuilder()
			: base("widget", "clone")
		{
		}

		public WidgetCloneRequestBuilder(Widget widget)
			: this()
		{
			this.Widget = widget;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("widget"))
				kparams.AddIfNotNull("widget", Widget);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Widget>(result);
		}
	}

	public class WidgetGetRequestBuilder : RequestBuilder<Widget>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id { get; set; }

		public WidgetGetRequestBuilder()
			: base("widget", "get")
		{
		}

		public WidgetGetRequestBuilder(string id)
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

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Widget>(result);
		}
	}

	public class WidgetListRequestBuilder : RequestBuilder<ListResponse<Widget>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public WidgetFilter Filter { get; set; }
		public FilterPager Pager { get; set; }

		public WidgetListRequestBuilder()
			: base("widget", "list")
		{
		}

		public WidgetListRequestBuilder(WidgetFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<Widget>>(result);
		}
	}

	public class WidgetUpdateRequestBuilder : RequestBuilder<Widget>
	{
		#region Constants
		public const string ID = "id";
		public const string WIDGET = "widget";
		#endregion

		public string Id { get; set; }
		public Widget Widget { get; set; }

		public WidgetUpdateRequestBuilder()
			: base("widget", "update")
		{
		}

		public WidgetUpdateRequestBuilder(string id, Widget widget)
			: this()
		{
			this.Id = id;
			this.Widget = widget;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("widget"))
				kparams.AddIfNotNull("widget", Widget);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<Widget>(result);
		}
	}


	public class WidgetService
	{
		private WidgetService()
		{
		}

		public static WidgetAddRequestBuilder Add(Widget widget)
		{
			return new WidgetAddRequestBuilder(widget);
		}

		public static WidgetCloneRequestBuilder Clone(Widget widget)
		{
			return new WidgetCloneRequestBuilder(widget);
		}

		public static WidgetGetRequestBuilder Get(string id)
		{
			return new WidgetGetRequestBuilder(id);
		}

		public static WidgetListRequestBuilder List(WidgetFilter filter = null, FilterPager pager = null)
		{
			return new WidgetListRequestBuilder(filter, pager);
		}

		public static WidgetUpdateRequestBuilder Update(string id, Widget widget)
		{
			return new WidgetUpdateRequestBuilder(id, widget);
		}
	}
}
