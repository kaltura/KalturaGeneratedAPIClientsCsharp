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

	public class KalturaSystemPartnerService : KalturaServiceBase
	{
	public KalturaSystemPartnerService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaPartner Get(int partnerId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("partnerId", partnerId);
			_Client.QueueServiceCall("systempartner_systempartner", "get", "KalturaPartner", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartner)KalturaObjectFactory.Create(result, "KalturaPartner");
		}

		public KalturaSystemPartnerUsageListResponse GetUsage()
		{
			return this.GetUsage(null);
		}

		public KalturaSystemPartnerUsageListResponse GetUsage(KalturaPartnerFilter partnerFilter)
		{
			return this.GetUsage(partnerFilter, null);
		}

		public KalturaSystemPartnerUsageListResponse GetUsage(KalturaPartnerFilter partnerFilter, KalturaSystemPartnerUsageFilter usageFilter)
		{
			return this.GetUsage(partnerFilter, usageFilter, null);
		}

		public KalturaSystemPartnerUsageListResponse GetUsage(KalturaPartnerFilter partnerFilter, KalturaSystemPartnerUsageFilter usageFilter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("partnerFilter", partnerFilter);
			kparams.AddIfNotNull("usageFilter", usageFilter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("systempartner_systempartner", "getUsage", "KalturaSystemPartnerUsageListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSystemPartnerUsageListResponse)KalturaObjectFactory.Create(result, "KalturaSystemPartnerUsageListResponse");
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
			_Client.QueueServiceCall("systempartner_systempartner", "list", "KalturaPartnerListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartnerListResponse)KalturaObjectFactory.Create(result, "KalturaPartnerListResponse");
		}

		public void UpdateStatus(int id, KalturaPartnerStatus status, string reason)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("status", status);
			kparams.AddIfNotNull("reason", reason);
			_Client.QueueServiceCall("systempartner_systempartner", "updateStatus", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public string GetAdminSession(int partnerId)
		{
			return this.GetAdminSession(partnerId, null);
		}

		public string GetAdminSession(int partnerId, string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("partnerId", partnerId);
			kparams.AddIfNotNull("userId", userId);
			_Client.QueueServiceCall("systempartner_systempartner", "getAdminSession", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public void UpdateConfiguration(int partnerId, KalturaSystemPartnerConfiguration configuration)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("partnerId", partnerId);
			kparams.AddIfNotNull("configuration", configuration);
			_Client.QueueServiceCall("systempartner_systempartner", "updateConfiguration", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaSystemPartnerConfiguration GetConfiguration(int partnerId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("partnerId", partnerId);
			_Client.QueueServiceCall("systempartner_systempartner", "getConfiguration", "KalturaSystemPartnerConfiguration", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSystemPartnerConfiguration)KalturaObjectFactory.Create(result, "KalturaSystemPartnerConfiguration");
		}

		public IList<KalturaSystemPartnerPackage> GetPackages()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("systempartner_systempartner", "getPackages", "KalturaSystemPartnerPackage", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaSystemPartnerPackage> list = new List<KalturaSystemPartnerPackage>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaSystemPartnerPackage)KalturaObjectFactory.Create(node, "KalturaSystemPartnerPackage"));
			}
			return list;
		}

		public IList<KalturaSystemPartnerPackage> GetPackagesClassOfService()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("systempartner_systempartner", "getPackagesClassOfService", "KalturaSystemPartnerPackage", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaSystemPartnerPackage> list = new List<KalturaSystemPartnerPackage>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaSystemPartnerPackage)KalturaObjectFactory.Create(node, "KalturaSystemPartnerPackage"));
			}
			return list;
		}

		public IList<KalturaSystemPartnerPackage> GetPackagesVertical()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("systempartner_systempartner", "getPackagesVertical", "KalturaSystemPartnerPackage", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaSystemPartnerPackage> list = new List<KalturaSystemPartnerPackage>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaSystemPartnerPackage)KalturaObjectFactory.Create(node, "KalturaSystemPartnerPackage"));
			}
			return list;
		}

		public IList<KalturaPlayerEmbedCodeType> GetPlayerEmbedCodeTypes()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("systempartner_systempartner", "getPlayerEmbedCodeTypes", "KalturaPlayerEmbedCodeType", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaPlayerEmbedCodeType> list = new List<KalturaPlayerEmbedCodeType>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaPlayerEmbedCodeType)KalturaObjectFactory.Create(node, "KalturaPlayerEmbedCodeType"));
			}
			return list;
		}

		public IList<KalturaPlayerDeliveryType> GetPlayerDeliveryTypes()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("systempartner_systempartner", "getPlayerDeliveryTypes", "KalturaPlayerDeliveryType", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			IList<KalturaPlayerDeliveryType> list = new List<KalturaPlayerDeliveryType>();
			foreach(XmlElement node in result.ChildNodes)
			{
				list.Add((KalturaPlayerDeliveryType)KalturaObjectFactory.Create(node, "KalturaPlayerDeliveryType"));
			}
			return list;
		}

		public void ResetUserPassword(string userId, int partnerId, string newPassword)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("userId", userId);
			kparams.AddIfNotNull("partnerId", partnerId);
			kparams.AddIfNotNull("newPassword", newPassword);
			_Client.QueueServiceCall("systempartner_systempartner", "resetUserPassword", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaUserLoginDataListResponse ListUserLoginData()
		{
			return this.ListUserLoginData(null);
		}

		public KalturaUserLoginDataListResponse ListUserLoginData(KalturaUserLoginDataFilter filter)
		{
			return this.ListUserLoginData(filter, null);
		}

		public KalturaUserLoginDataListResponse ListUserLoginData(KalturaUserLoginDataFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("systempartner_systempartner", "listUserLoginData", "KalturaUserLoginDataListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserLoginDataListResponse)KalturaObjectFactory.Create(result, "KalturaUserLoginDataListResponse");
		}
	}
}
