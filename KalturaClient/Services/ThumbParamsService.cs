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

	public class KalturaThumbParamsService : KalturaServiceBase
	{
	public KalturaThumbParamsService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaThumbParams Add(KalturaThumbParams thumbParams)
		{
			KalturaParams kparams = new KalturaParams();
			if (thumbParams != null)
				kparams.Add("thumbParams", thumbParams.ToParams());
			_Client.QueueServiceCall("thumbparams", "add", "KalturaThumbParams", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbParams)KalturaObjectFactory.Create(result, "KalturaThumbParams");
		}

		public KalturaThumbParams Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("thumbparams", "get", "KalturaThumbParams", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbParams)KalturaObjectFactory.Create(result, "KalturaThumbParams");
		}

		public KalturaThumbParams Update(int id, KalturaThumbParams thumbParams)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (thumbParams != null)
				kparams.Add("thumbParams", thumbParams.ToParams());
			_Client.QueueServiceCall("thumbparams", "update", "KalturaThumbParams", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbParams)KalturaObjectFactory.Create(result, "KalturaThumbParams");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("thumbparams", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaThumbParamsListResponse List()
		{
			return this.List(null);
		}

		public KalturaThumbParamsListResponse List(KalturaThumbParamsFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaThumbParamsListResponse List(KalturaThumbParamsFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("thumbparams", "list", "KalturaThumbParamsListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaThumbParamsListResponse)KalturaObjectFactory.Create(result, "KalturaThumbParamsListResponse");
		}

		public IList<KalturaThumbParams> GetByConversionProfileId(int conversionProfileId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("conversionProfileId", conversionProfileId);
			_Client.QueueServiceCall("thumbparams", "getByConversionProfileId", "KalturaThumbParams", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaThumbParams> list = new List<KalturaThumbParams>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaThumbParams)KalturaObjectFactory.Create(node, "KalturaThumbParams"));
			}
			return list;
		}
	}
}
