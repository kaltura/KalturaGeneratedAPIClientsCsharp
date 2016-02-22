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

	public class KalturaPartnerService : KalturaServiceBase
	{
	public KalturaPartnerService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaPartner Register(KalturaPartner partner)
		{
			return this.Register(partner, "");
		}

		public KalturaPartner Register(KalturaPartner partner, string cmsPassword)
		{
			return this.Register(partner, cmsPassword, Int32.MinValue);
		}

		public KalturaPartner Register(KalturaPartner partner, string cmsPassword, int templatePartnerId)
		{
			return this.Register(partner, cmsPassword, templatePartnerId, false);
		}

		public KalturaPartner Register(KalturaPartner partner, string cmsPassword, int templatePartnerId, bool silent)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("partner", partner);
			kparams.AddIfNotNull("cmsPassword", cmsPassword);
			kparams.AddIfNotNull("templatePartnerId", templatePartnerId);
			kparams.AddIfNotNull("silent", silent);
			_Client.QueueServiceCall("partner", "register", "KalturaPartner", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartner)KalturaObjectFactory.Create(result, "KalturaPartner");
		}

		public KalturaPartner Update(KalturaPartner partner)
		{
			return this.Update(partner, false);
		}

		public KalturaPartner Update(KalturaPartner partner, bool allowEmpty)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("partner", partner);
			kparams.AddIfNotNull("allowEmpty", allowEmpty);
			_Client.QueueServiceCall("partner", "update", "KalturaPartner", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartner)KalturaObjectFactory.Create(result, "KalturaPartner");
		}

		public KalturaPartner Get()
		{
			return this.Get(Int32.MinValue);
		}

		public KalturaPartner Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			_Client.QueueServiceCall("partner", "get", "KalturaPartner", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartner)KalturaObjectFactory.Create(result, "KalturaPartner");
		}

		public KalturaPartner GetSecrets(int partnerId, string adminEmail, string cmsPassword)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("partnerId", partnerId);
			kparams.AddIfNotNull("adminEmail", adminEmail);
			kparams.AddIfNotNull("cmsPassword", cmsPassword);
			_Client.QueueServiceCall("partner", "getSecrets", "KalturaPartner", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartner)KalturaObjectFactory.Create(result, "KalturaPartner");
		}

		public KalturaPartner GetInfo()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("partner", "getInfo", "KalturaPartner", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartner)KalturaObjectFactory.Create(result, "KalturaPartner");
		}

		public KalturaPartnerUsage GetUsage()
		{
			return this.GetUsage();
		}

		public KalturaPartnerUsage GetUsage(int year)
		{
			return this.GetUsage(year, 1);
		}

		public KalturaPartnerUsage GetUsage(int year, int month)
		{
			return this.GetUsage(year, month, null);
		}

		public KalturaPartnerUsage GetUsage(int year, int month, KalturaReportInterval resolution)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("year", year);
			kparams.AddIfNotNull("month", month);
			kparams.AddIfNotNull("resolution", resolution);
			_Client.QueueServiceCall("partner", "getUsage", "KalturaPartnerUsage", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartnerUsage)KalturaObjectFactory.Create(result, "KalturaPartnerUsage");
		}

		public KalturaPartnerStatistics GetStatistics()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("partner", "getStatistics", "KalturaPartnerStatistics", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartnerStatistics)KalturaObjectFactory.Create(result, "KalturaPartnerStatistics");
		}

		public KalturaPartnerListResponse ListPartnersForUser()
		{
			return this.ListPartnersForUser(null);
		}

		public KalturaPartnerListResponse ListPartnersForUser(KalturaPartnerFilter partnerFilter)
		{
			return this.ListPartnersForUser(partnerFilter, null);
		}

		public KalturaPartnerListResponse ListPartnersForUser(KalturaPartnerFilter partnerFilter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("partnerFilter", partnerFilter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("partner", "listPartnersForUser", "KalturaPartnerListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartnerListResponse)KalturaObjectFactory.Create(result, "KalturaPartnerListResponse");
		}

		public KalturaPartnerListResponse List()
		{
			return this.List(null);
		}

		public KalturaPartnerListResponse List(KalturaPartnerFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaPartnerListResponse List(KalturaPartnerFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("partner", "list", "KalturaPartnerListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartnerListResponse)KalturaObjectFactory.Create(result, "KalturaPartnerListResponse");
		}

		public KalturaFeatureStatusListResponse ListFeatureStatus()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("partner", "listFeatureStatus", "KalturaFeatureStatusListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaFeatureStatusListResponse)KalturaObjectFactory.Create(result, "KalturaFeatureStatusListResponse");
		}

		public int Count()
		{
			return this.Count(null);
		}

		public int Count(KalturaPartnerFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			_Client.QueueServiceCall("partner", "count", null, kparams);
			if (this._Client.IsMultiRequest)
				return 0;
			XmlElement result = _Client.DoQueue();
			return int.Parse(result.InnerText);
		}
	}
}
