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
	public class UiConfAddRequestBuilder : RequestBuilder<UiConf>
	{
		#region Constants
		public const string UI_CONF = "uiConf";
		#endregion

		public UiConf UiConf
		{
			set;
			get;
		}

		public UiConfAddRequestBuilder()
			: base("uiconf", "add")
		{
		}

		public UiConfAddRequestBuilder(UiConf uiConf)
			: this()
		{
			this.UiConf = uiConf;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("uiConf"))
				kparams.AddIfNotNull("uiConf", UiConf);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<UiConf>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<UiConf>((IDictionary<string,object>)result);
		}
	}

	public class UiConfCloneRequestBuilder : RequestBuilder<UiConf>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public UiConfCloneRequestBuilder()
			: base("uiconf", "clone")
		{
		}

		public UiConfCloneRequestBuilder(int id)
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
			return ObjectFactory.Create<UiConf>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<UiConf>((IDictionary<string,object>)result);
		}
	}

	public class UiConfDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public UiConfDeleteRequestBuilder()
			: base("uiconf", "delete")
		{
		}

		public UiConfDeleteRequestBuilder(int id)
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
		public override object DeserializeObject(object result)
		{
			return null;
		}
	}

	public class UiConfGetRequestBuilder : RequestBuilder<UiConf>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public UiConfGetRequestBuilder()
			: base("uiconf", "get")
		{
		}

		public UiConfGetRequestBuilder(int id)
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
			return ObjectFactory.Create<UiConf>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<UiConf>((IDictionary<string,object>)result);
		}
	}

	public class UiConfGetAvailableTypesRequestBuilder : RequestBuilder<IList<UiConfTypeInfo>>
	{
		#region Constants
		#endregion


		public UiConfGetAvailableTypesRequestBuilder()
			: base("uiconf", "getAvailableTypes")
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

		public override object Deserialize(XmlElement result)
		{
			IList<UiConfTypeInfo> list = new List<UiConfTypeInfo>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add(ObjectFactory.Create<UiConfTypeInfo>(node));
			}
			return list;
		}
		public override object DeserializeObject(object result)
		{
			var list = new List<UiConfTypeInfo>();
			foreach(var node in (IEnumerable<IDictionary<string,object>>)result)
			{
				list.Add(ObjectFactory.Create<UiConfTypeInfo>(node));
			}
			return list;
		}
	}

	public class UiConfListRequestBuilder : RequestBuilder<ListResponse<UiConf>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public UiConfFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public UiConfListRequestBuilder()
			: base("uiconf", "list")
		{
		}

		public UiConfListRequestBuilder(UiConfFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<UiConf>>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ListResponse<UiConf>>((IDictionary<string,object>)result);
		}
	}

	public class UiConfListTemplatesRequestBuilder : RequestBuilder<ListResponse<UiConf>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public UiConfFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public UiConfListTemplatesRequestBuilder()
			: base("uiconf", "listTemplates")
		{
		}

		public UiConfListTemplatesRequestBuilder(UiConfFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<UiConf>>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ListResponse<UiConf>>((IDictionary<string,object>)result);
		}
	}

	public class UiConfUpdateRequestBuilder : RequestBuilder<UiConf>
	{
		#region Constants
		public const string ID = "id";
		public const string UI_CONF = "uiConf";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public UiConf UiConf
		{
			set;
			get;
		}

		public UiConfUpdateRequestBuilder()
			: base("uiconf", "update")
		{
		}

		public UiConfUpdateRequestBuilder(int id, UiConf uiConf)
			: this()
		{
			this.Id = id;
			this.UiConf = uiConf;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("uiConf"))
				kparams.AddIfNotNull("uiConf", UiConf);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<UiConf>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<UiConf>((IDictionary<string,object>)result);
		}
	}


	public class UiConfService
	{
		private UiConfService()
		{
		}

		public static UiConfAddRequestBuilder Add(UiConf uiConf)
		{
			return new UiConfAddRequestBuilder(uiConf);
		}

		public static UiConfCloneRequestBuilder Clone(int id)
		{
			return new UiConfCloneRequestBuilder(id);
		}

		public static UiConfDeleteRequestBuilder Delete(int id)
		{
			return new UiConfDeleteRequestBuilder(id);
		}

		public static UiConfGetRequestBuilder Get(int id)
		{
			return new UiConfGetRequestBuilder(id);
		}

		public static UiConfGetAvailableTypesRequestBuilder GetAvailableTypes()
		{
			return new UiConfGetAvailableTypesRequestBuilder();
		}

		public static UiConfListRequestBuilder List(UiConfFilter filter = null, FilterPager pager = null)
		{
			return new UiConfListRequestBuilder(filter, pager);
		}

		public static UiConfListTemplatesRequestBuilder ListTemplates(UiConfFilter filter = null, FilterPager pager = null)
		{
			return new UiConfListTemplatesRequestBuilder(filter, pager);
		}

		public static UiConfUpdateRequestBuilder Update(int id, UiConf uiConf)
		{
			return new UiConfUpdateRequestBuilder(id, uiConf);
		}
	}
}
