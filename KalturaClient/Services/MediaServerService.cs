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

	public class KalturaMediaServerService : KalturaServiceBase
	{
	public KalturaMediaServerService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaMediaServer Get(string hostname)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("hostname", hostname);
			_Client.QueueServiceCall("mediaserver", "get", "KalturaMediaServer", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaServer)KalturaObjectFactory.Create(result, "KalturaMediaServer");
		}

		public KalturaMediaServer ReportStatus(string hostname, KalturaMediaServerStatus mediaServerStatus)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("hostname", hostname);
			if (mediaServerStatus != null)
				kparams.Add("mediaServerStatus", mediaServerStatus.ToParams());
			_Client.QueueServiceCall("mediaserver", "reportStatus", "KalturaMediaServer", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaServer)KalturaObjectFactory.Create(result, "KalturaMediaServer");
		}
	}
}
