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
	public class ConversionProfileAddRequestBuilder : RequestBuilder<ConversionProfile>
	{
		#region Constants
		public const string CONVERSION_PROFILE = "conversionProfile";
		#endregion

		public ConversionProfile ConversionProfile
		{
			set;
			get;
		}

		public ConversionProfileAddRequestBuilder()
			: base("conversionprofile", "add")
		{
		}

		public ConversionProfileAddRequestBuilder(ConversionProfile conversionProfile)
			: this()
		{
			this.ConversionProfile = conversionProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("conversionProfile"))
				kparams.AddIfNotNull("conversionProfile", ConversionProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ConversionProfile>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ConversionProfile>((IDictionary<string,object>)result);
		}
	}

	public class ConversionProfileDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public ConversionProfileDeleteRequestBuilder()
			: base("conversionprofile", "delete")
		{
		}

		public ConversionProfileDeleteRequestBuilder(int id)
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

	public class ConversionProfileGetRequestBuilder : RequestBuilder<ConversionProfile>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public ConversionProfileGetRequestBuilder()
			: base("conversionprofile", "get")
		{
		}

		public ConversionProfileGetRequestBuilder(int id)
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
			return ObjectFactory.Create<ConversionProfile>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ConversionProfile>((IDictionary<string,object>)result);
		}
	}

	public class ConversionProfileGetDefaultRequestBuilder : RequestBuilder<ConversionProfile>
	{
		#region Constants
		public const string TYPE = "type";
		#endregion

		public ConversionProfileType Type
		{
			set;
			get;
		}

		public ConversionProfileGetDefaultRequestBuilder()
			: base("conversionprofile", "getDefault")
		{
		}

		public ConversionProfileGetDefaultRequestBuilder(ConversionProfileType type)
			: this()
		{
			this.Type = type;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("type"))
				kparams.AddIfNotNull("type", Type);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ConversionProfile>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ConversionProfile>((IDictionary<string,object>)result);
		}
	}

	public class ConversionProfileListRequestBuilder : RequestBuilder<ListResponse<ConversionProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public ConversionProfileFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public ConversionProfileListRequestBuilder()
			: base("conversionprofile", "list")
		{
		}

		public ConversionProfileListRequestBuilder(ConversionProfileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<ConversionProfile>>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ListResponse<ConversionProfile>>((IDictionary<string,object>)result);
		}
	}

	public class ConversionProfileSetAsDefaultRequestBuilder : RequestBuilder<ConversionProfile>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public ConversionProfileSetAsDefaultRequestBuilder()
			: base("conversionprofile", "setAsDefault")
		{
		}

		public ConversionProfileSetAsDefaultRequestBuilder(int id)
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
			return ObjectFactory.Create<ConversionProfile>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ConversionProfile>((IDictionary<string,object>)result);
		}
	}

	public class ConversionProfileUpdateRequestBuilder : RequestBuilder<ConversionProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string CONVERSION_PROFILE = "conversionProfile";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public ConversionProfile ConversionProfile
		{
			set;
			get;
		}

		public ConversionProfileUpdateRequestBuilder()
			: base("conversionprofile", "update")
		{
		}

		public ConversionProfileUpdateRequestBuilder(int id, ConversionProfile conversionProfile)
			: this()
		{
			this.Id = id;
			this.ConversionProfile = conversionProfile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("conversionProfile"))
				kparams.AddIfNotNull("conversionProfile", ConversionProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ConversionProfile>(result);
		}
		public override object DeserializeObject(object result)
		{
			return ObjectFactory.Create<ConversionProfile>((IDictionary<string,object>)result);
		}
	}


	public class ConversionProfileService
	{
		private ConversionProfileService()
		{
		}

		public static ConversionProfileAddRequestBuilder Add(ConversionProfile conversionProfile)
		{
			return new ConversionProfileAddRequestBuilder(conversionProfile);
		}

		public static ConversionProfileDeleteRequestBuilder Delete(int id)
		{
			return new ConversionProfileDeleteRequestBuilder(id);
		}

		public static ConversionProfileGetRequestBuilder Get(int id)
		{
			return new ConversionProfileGetRequestBuilder(id);
		}

		public static ConversionProfileGetDefaultRequestBuilder GetDefault(ConversionProfileType type = null)
		{
			return new ConversionProfileGetDefaultRequestBuilder(type);
		}

		public static ConversionProfileListRequestBuilder List(ConversionProfileFilter filter = null, FilterPager pager = null)
		{
			return new ConversionProfileListRequestBuilder(filter, pager);
		}

		public static ConversionProfileSetAsDefaultRequestBuilder SetAsDefault(int id)
		{
			return new ConversionProfileSetAsDefaultRequestBuilder(id);
		}

		public static ConversionProfileUpdateRequestBuilder Update(int id, ConversionProfile conversionProfile)
		{
			return new ConversionProfileUpdateRequestBuilder(id, conversionProfile);
		}
	}
}
