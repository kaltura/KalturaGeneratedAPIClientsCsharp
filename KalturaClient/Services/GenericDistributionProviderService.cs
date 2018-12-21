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
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class GenericDistributionProviderAddRequestBuilder : RequestBuilder<GenericDistributionProvider>
	{
		#region Constants
		public const string GENERIC_DISTRIBUTION_PROVIDER = "genericDistributionProvider";
		#endregion

		public GenericDistributionProvider GenericDistributionProvider
		{
			set;
			get;
		}

		public GenericDistributionProviderAddRequestBuilder()
			: base("contentdistribution_genericdistributionprovider", "add")
		{
		}

		public GenericDistributionProviderAddRequestBuilder(GenericDistributionProvider genericDistributionProvider)
			: this()
		{
			this.GenericDistributionProvider = genericDistributionProvider;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("genericDistributionProvider"))
				kparams.AddIfNotNull("genericDistributionProvider", GenericDistributionProvider);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProvider>(result);
		}
	}

	public class GenericDistributionProviderDeleteRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public GenericDistributionProviderDeleteRequestBuilder()
			: base("contentdistribution_genericdistributionprovider", "delete")
		{
		}

		public GenericDistributionProviderDeleteRequestBuilder(int id)
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
			return null;
		}
	}

	public class GenericDistributionProviderGetRequestBuilder : RequestBuilder<GenericDistributionProvider>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public GenericDistributionProviderGetRequestBuilder()
			: base("contentdistribution_genericdistributionprovider", "get")
		{
		}

		public GenericDistributionProviderGetRequestBuilder(int id)
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
			return ObjectFactory.Create<GenericDistributionProvider>(result);
		}
	}

	public class GenericDistributionProviderListRequestBuilder : RequestBuilder<ListResponse<GenericDistributionProvider>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public GenericDistributionProviderFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public GenericDistributionProviderListRequestBuilder()
			: base("contentdistribution_genericdistributionprovider", "list")
		{
		}

		public GenericDistributionProviderListRequestBuilder(GenericDistributionProviderFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<GenericDistributionProvider>>(result);
		}
	}

	public class GenericDistributionProviderUpdateRequestBuilder : RequestBuilder<GenericDistributionProvider>
	{
		#region Constants
		public const string ID = "id";
		public const string GENERIC_DISTRIBUTION_PROVIDER = "genericDistributionProvider";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public GenericDistributionProvider GenericDistributionProvider
		{
			set;
			get;
		}

		public GenericDistributionProviderUpdateRequestBuilder()
			: base("contentdistribution_genericdistributionprovider", "update")
		{
		}

		public GenericDistributionProviderUpdateRequestBuilder(int id, GenericDistributionProvider genericDistributionProvider)
			: this()
		{
			this.Id = id;
			this.GenericDistributionProvider = genericDistributionProvider;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("genericDistributionProvider"))
				kparams.AddIfNotNull("genericDistributionProvider", GenericDistributionProvider);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<GenericDistributionProvider>(result);
		}
	}


	public class GenericDistributionProviderService
	{
		private GenericDistributionProviderService()
		{
		}

		public static GenericDistributionProviderAddRequestBuilder Add(GenericDistributionProvider genericDistributionProvider)
		{
			return new GenericDistributionProviderAddRequestBuilder(genericDistributionProvider);
		}

		public static GenericDistributionProviderDeleteRequestBuilder Delete(int id)
		{
			return new GenericDistributionProviderDeleteRequestBuilder(id);
		}

		public static GenericDistributionProviderGetRequestBuilder Get(int id)
		{
			return new GenericDistributionProviderGetRequestBuilder(id);
		}

		public static GenericDistributionProviderListRequestBuilder List(GenericDistributionProviderFilter filter = null, FilterPager pager = null)
		{
			return new GenericDistributionProviderListRequestBuilder(filter, pager);
		}

		public static GenericDistributionProviderUpdateRequestBuilder Update(int id, GenericDistributionProvider genericDistributionProvider)
		{
			return new GenericDistributionProviderUpdateRequestBuilder(id, genericDistributionProvider);
		}
	}
}
