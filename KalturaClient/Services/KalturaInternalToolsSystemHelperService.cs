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
// Copyright (C) 2006-2015  Kaltura Inc.
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

	public class KalturaKalturaInternalToolsSystemHelperService : KalturaServiceBase
	{
	public KalturaKalturaInternalToolsSystemHelperService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaInternalToolsSession FromSecureString(string str)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("str", str);
			_Client.QueueServiceCall("kalturainternaltools_kalturainternaltoolssystemhelper", "fromSecureString", "KalturaInternalToolsSession", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaInternalToolsSession)KalturaObjectFactory.Create(result, "KalturaInternalToolsSession");
		}

		public string Iptocountry(string remote_addr)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("remote_addr", remote_addr);
			_Client.QueueServiceCall("kalturainternaltools_kalturainternaltoolssystemhelper", "iptocountry", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public string GetRemoteAddress()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("kalturainternaltools_kalturainternaltoolssystemhelper", "getRemoteAddress", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}
	}
}
