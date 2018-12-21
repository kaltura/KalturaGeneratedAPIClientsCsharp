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
	public class DeliveryProfileAddRequestBuilder : RequestBuilder<DeliveryProfile>
	{
		#region Constants
		public const string DELIVERY = "delivery";
		#endregion

		public DeliveryProfile Delivery
		{
			set;
			get;
		}

		public DeliveryProfileAddRequestBuilder()
			: base("deliveryprofile", "add")
		{
		}

		public DeliveryProfileAddRequestBuilder(DeliveryProfile delivery)
			: this()
		{
			this.Delivery = delivery;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("delivery"))
				kparams.AddIfNotNull("delivery", Delivery);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DeliveryProfile>(result);
		}
	}

	public class DeliveryProfileCloneRequestBuilder : RequestBuilder<DeliveryProfile>
	{
		#region Constants
		public const string DELIVERY_ID = "deliveryId";
		#endregion

		public int DeliveryId
		{
			set;
			get;
		}

		public DeliveryProfileCloneRequestBuilder()
			: base("deliveryprofile", "clone")
		{
		}

		public DeliveryProfileCloneRequestBuilder(int deliveryId)
			: this()
		{
			this.DeliveryId = deliveryId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("deliveryId"))
				kparams.AddIfNotNull("deliveryId", DeliveryId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DeliveryProfile>(result);
		}
	}

	public class DeliveryProfileGetRequestBuilder : RequestBuilder<DeliveryProfile>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public DeliveryProfileGetRequestBuilder()
			: base("deliveryprofile", "get")
		{
		}

		public DeliveryProfileGetRequestBuilder(string id)
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
			return ObjectFactory.Create<DeliveryProfile>(result);
		}
	}

	public class DeliveryProfileListRequestBuilder : RequestBuilder<ListResponse<DeliveryProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public DeliveryProfileFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public DeliveryProfileListRequestBuilder()
			: base("deliveryprofile", "list")
		{
		}

		public DeliveryProfileListRequestBuilder(DeliveryProfileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<DeliveryProfile>>(result);
		}
	}

	public class DeliveryProfileUpdateRequestBuilder : RequestBuilder<DeliveryProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string DELIVERY = "delivery";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public DeliveryProfile Delivery
		{
			set;
			get;
		}

		public DeliveryProfileUpdateRequestBuilder()
			: base("deliveryprofile", "update")
		{
		}

		public DeliveryProfileUpdateRequestBuilder(string id, DeliveryProfile delivery)
			: this()
		{
			this.Id = id;
			this.Delivery = delivery;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("delivery"))
				kparams.AddIfNotNull("delivery", Delivery);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<DeliveryProfile>(result);
		}
	}


	public class DeliveryProfileService
	{
		private DeliveryProfileService()
		{
		}

		public static DeliveryProfileAddRequestBuilder Add(DeliveryProfile delivery)
		{
			return new DeliveryProfileAddRequestBuilder(delivery);
		}

		public static DeliveryProfileCloneRequestBuilder Clone(int deliveryId)
		{
			return new DeliveryProfileCloneRequestBuilder(deliveryId);
		}

		public static DeliveryProfileGetRequestBuilder Get(string id)
		{
			return new DeliveryProfileGetRequestBuilder(id);
		}

		public static DeliveryProfileListRequestBuilder List(DeliveryProfileFilter filter = null, FilterPager pager = null)
		{
			return new DeliveryProfileListRequestBuilder(filter, pager);
		}

		public static DeliveryProfileUpdateRequestBuilder Update(string id, DeliveryProfile delivery)
		{
			return new DeliveryProfileUpdateRequestBuilder(id, delivery);
		}
	}
}
