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

	public class KalturaVarConsoleService : KalturaServiceBase
	{
	public KalturaVarConsoleService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaPartnerUsageListResponse GetPartnerUsage()
		{
			return this.GetPartnerUsage(null);
		}

		public KalturaPartnerUsageListResponse GetPartnerUsage(KalturaPartnerFilter partnerFilter)
		{
			return this.GetPartnerUsage(partnerFilter, null);
		}

		public KalturaPartnerUsageListResponse GetPartnerUsage(KalturaPartnerFilter partnerFilter, KalturaReportInputFilter usageFilter)
		{
			return this.GetPartnerUsage(partnerFilter, usageFilter, null);
		}

		public KalturaPartnerUsageListResponse GetPartnerUsage(KalturaPartnerFilter partnerFilter, KalturaReportInputFilter usageFilter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			if (partnerFilter != null)
				kparams.Add("partnerFilter", partnerFilter.ToParams());
			if (usageFilter != null)
				kparams.Add("usageFilter", usageFilter.ToParams());
			if (pager != null)
				kparams.Add("pager", pager.ToParams());
			_Client.QueueServiceCall("varconsole_varconsole", "getPartnerUsage", "KalturaPartnerUsageListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaPartnerUsageListResponse)KalturaObjectFactory.Create(result, "KalturaPartnerUsageListResponse");
		}

		public void UpdateStatus(int id, KalturaPartnerStatus status)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			kparams.AddEnumIfNotNull("status", status);
			_Client.QueueServiceCall("varconsole_varconsole", "updateStatus", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
