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

	public class KalturaDrmPolicyService : KalturaServiceBase
	{
	public KalturaDrmPolicyService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDrmPolicy Add(KalturaDrmPolicy drmPolicy)
		{
			KalturaParams kparams = new KalturaParams();
			if (drmPolicy != null)
				kparams.Add("drmPolicy", drmPolicy.ToParams());
			_Client.QueueServiceCall("drm_drmpolicy", "add", "KalturaDrmPolicy", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDrmPolicy)KalturaObjectFactory.Create(result, "KalturaDrmPolicy");
		}

		public KalturaDrmPolicy Get(int drmPolicyId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("drmPolicyId", drmPolicyId);
			_Client.QueueServiceCall("drm_drmpolicy", "get", "KalturaDrmPolicy", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDrmPolicy)KalturaObjectFactory.Create(result, "KalturaDrmPolicy");
		}

		public KalturaDrmPolicy Update(int drmPolicyId, KalturaDrmPolicy drmPolicy)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("drmPolicyId", drmPolicyId);
			if (drmPolicy != null)
				kparams.Add("drmPolicy", drmPolicy.ToParams());
			_Client.QueueServiceCall("drm_drmpolicy", "update", "KalturaDrmPolicy", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDrmPolicy)KalturaObjectFactory.Create(result, "KalturaDrmPolicy");
		}

		public KalturaDrmPolicy Delete(int drmPolicyId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("drmPolicyId", drmPolicyId);
			_Client.QueueServiceCall("drm_drmpolicy", "delete", "KalturaDrmPolicy", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDrmPolicy)KalturaObjectFactory.Create(result, "KalturaDrmPolicy");
		}

		public KalturaDrmPolicyListResponse List()
		{
			return this.List(null);
		}

		public KalturaDrmPolicyListResponse List(KalturaDrmPolicyFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDrmPolicyListResponse List(KalturaDrmPolicyFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("drm_drmpolicy", "list", "KalturaDrmPolicyListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDrmPolicyListResponse)KalturaObjectFactory.Create(result, "KalturaDrmPolicyListResponse");
		}
	}
}
