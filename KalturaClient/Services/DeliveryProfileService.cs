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

namespace Kaltura
{

	public class KalturaDeliveryProfileService : KalturaServiceBase
	{
	public KalturaDeliveryProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDeliveryProfile Add(KalturaDeliveryProfile delivery)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("delivery", delivery);
			_Client.QueueServiceCall("deliveryprofile", "add", "KalturaDeliveryProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDeliveryProfile)KalturaObjectFactory.Create(result, "KalturaDeliveryProfile");
		}

		public KalturaDeliveryProfile Update(string id, KalturaDeliveryProfile delivery)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("delivery", delivery);
			_Client.QueueServiceCall("deliveryprofile", "update", "KalturaDeliveryProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDeliveryProfile)KalturaObjectFactory.Create(result, "KalturaDeliveryProfile");
		}

		public KalturaDeliveryProfile Get(string id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("deliveryprofile", "get", "KalturaDeliveryProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDeliveryProfile)KalturaObjectFactory.Create(result, "KalturaDeliveryProfile");
		}

		public KalturaDeliveryProfile Clone(int deliveryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("deliveryId", deliveryId);
			_Client.QueueServiceCall("deliveryprofile", "clone", "KalturaDeliveryProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDeliveryProfile)KalturaObjectFactory.Create(result, "KalturaDeliveryProfile");
		}

		public KalturaDeliveryProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaDeliveryProfileListResponse List(KalturaDeliveryProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDeliveryProfileListResponse List(KalturaDeliveryProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("deliveryprofile", "list", "KalturaDeliveryProfileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDeliveryProfileListResponse)KalturaObjectFactory.Create(result, "KalturaDeliveryProfileListResponse");
		}
	}
}
