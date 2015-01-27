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

	public class KalturaDistributionProfileService : KalturaServiceBase
	{
	public KalturaDistributionProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaDistributionProfile Add(KalturaDistributionProfile distributionProfile)
		{
			KalturaParams kparams = new KalturaParams();
			if (distributionProfile != null)
				kparams.Add("distributionProfile", distributionProfile.ToParams());
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "add", "KalturaDistributionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfile)KalturaObjectFactory.Create(result, "KalturaDistributionProfile");
		}

		public KalturaDistributionProfile Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "get", "KalturaDistributionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfile)KalturaObjectFactory.Create(result, "KalturaDistributionProfile");
		}

		public KalturaDistributionProfile Update(int id, KalturaDistributionProfile distributionProfile)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (distributionProfile != null)
				kparams.Add("distributionProfile", distributionProfile.ToParams());
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "update", "KalturaDistributionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfile)KalturaObjectFactory.Create(result, "KalturaDistributionProfile");
		}

		public KalturaDistributionProfile UpdateStatus(int id, KalturaDistributionProfileStatus status)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddEnumIfNotNull("status", status);
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "updateStatus", "KalturaDistributionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfile)KalturaObjectFactory.Create(result, "KalturaDistributionProfile");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaDistributionProfileListResponse List()
		{
			return this.List(null);
		}

		public KalturaDistributionProfileListResponse List(KalturaDistributionProfileFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaDistributionProfileListResponse List(KalturaDistributionProfileFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "list", "KalturaDistributionProfileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfileListResponse)KalturaObjectFactory.Create(result, "KalturaDistributionProfileListResponse");
		}

		public KalturaDistributionProfileListResponse ListByPartner()
		{
			return this.ListByPartner(null);
		}

		public KalturaDistributionProfileListResponse ListByPartner(KalturaPartnerFilter filter)
		{
			return this.ListByPartner(filter, null);
		}

		public KalturaDistributionProfileListResponse ListByPartner(KalturaPartnerFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (filter != null)
				kparams.Add("filter", filter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("contentdistribution_distributionprofile", "listByPartner", "KalturaDistributionProfileListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaDistributionProfileListResponse)KalturaObjectFactory.Create(result, "KalturaDistributionProfileListResponse");
		}
	}
}
