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

	public class KalturaConversionProfileService : KalturaServiceBase
	{
	public KalturaConversionProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaConversionProfile SetAsDefault(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("conversionprofile", "setAsDefault", "KalturaConversionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfile)KalturaObjectFactory.Create(result, "KalturaConversionProfile");
		}

		public KalturaConversionProfile GetDefault()
		{
			return this.GetDefault(null);
		}

		public KalturaConversionProfile GetDefault(KalturaConversionProfileType type)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringEnumIfNotNull("type", type);
			_Client.QueueServiceCall("conversionprofile", "getDefault", "KalturaConversionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfile)KalturaObjectFactory.Create(result, "KalturaConversionProfile");
		}

		public KalturaConversionProfile Add(KalturaConversionProfile conversionProfile)
		{
			KalturaParams kparams = new KalturaParams();
			if (conversionProfile != null)
				kparams.Add("conversionProfile", conversionProfile.ToParams());
			_Client.QueueServiceCall("conversionprofile", "add", "KalturaConversionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfile)KalturaObjectFactory.Create(result, "KalturaConversionProfile");
		}

		public KalturaConversionProfile Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("conversionprofile", "get", "KalturaConversionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfile)KalturaObjectFactory.Create(result, "KalturaConversionProfile");
		}

		public KalturaConversionProfile Update(int id, KalturaConversionProfile conversionProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (conversionProfile != null)
				kparams.Add("conversionProfile", conversionProfile.ToParams());
			_Client.QueueServiceCall("conversionprofile", "update", "KalturaConversionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfile)KalturaObjectFactory.Create(result, "KalturaConversionProfile");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("conversionprofile", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaConversionProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaConversionProfileListResponse List(KalturaConversionProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaConversionProfileListResponse List(KalturaConversionProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("conversionprofile", "list", "KalturaConversionProfileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaConversionProfileListResponse)KalturaObjectFactory.Create(result, "KalturaConversionProfileListResponse");
		}
	}
}
