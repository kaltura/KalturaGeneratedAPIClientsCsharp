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
// Copyright (C) 2006-2011  Kaltura Inc.
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

	public class KalturaFlavorParamsService : KalturaServiceBase
	{
	public KalturaFlavorParamsService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaFlavorParams Add(KalturaFlavorParams flavorParams)
		{
			KalturaParams kparams = new KalturaParams();
			if (flavorParams != null)
				kparams.Add("flavorParams", flavorParams.ToParams());
			_Client.QueueServiceCall("flavorparams", "add", "KalturaFlavorParams", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorParams)KalturaObjectFactory.Create(result, "KalturaFlavorParams");
		}

		public KalturaFlavorParams Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("flavorparams", "get", "KalturaFlavorParams", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorParams)KalturaObjectFactory.Create(result, "KalturaFlavorParams");
		}

		public KalturaFlavorParams Update(int id, KalturaFlavorParams flavorParams)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (flavorParams != null)
				kparams.Add("flavorParams", flavorParams.ToParams());
			_Client.QueueServiceCall("flavorparams", "update", "KalturaFlavorParams", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorParams)KalturaObjectFactory.Create(result, "KalturaFlavorParams");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("flavorparams", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaFlavorParamsListResponse List()
		{
			return this.List(null);
		}

		public KalturaFlavorParamsListResponse List(KalturaFlavorParamsFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaFlavorParamsListResponse List(KalturaFlavorParamsFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("flavorparams", "list", "KalturaFlavorParamsListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFlavorParamsListResponse)KalturaObjectFactory.Create(result, "KalturaFlavorParamsListResponse");
		}

		public IList<KalturaFlavorParams> GetByConversionProfileId(int conversionProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("conversionProfileId", conversionProfileId);
			_Client.QueueServiceCall("flavorparams", "getByConversionProfileId", "KalturaFlavorParams", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaFlavorParams> list = new List<KalturaFlavorParams>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaFlavorParams)KalturaObjectFactory.Create(node, "KalturaFlavorParams"));
			}
			return list;
		}
	}
}
