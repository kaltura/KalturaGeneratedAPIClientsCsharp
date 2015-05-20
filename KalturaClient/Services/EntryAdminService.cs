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

	public class KalturaEntryAdminService : KalturaServiceBase
	{
	public KalturaEntryAdminService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaBaseEntry Get(string entryId)
		{
			return this.Get(entryId, -1);
		}

		public KalturaBaseEntry Get(string entryId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("adminconsole_entryadmin", "get", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public KalturaBaseEntry GetByFlavorId(string flavorId)
		{
			return this.GetByFlavorId(flavorId, -1);
		}

		public KalturaBaseEntry GetByFlavorId(string flavorId, int version)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("flavorId", flavorId);
			kparams.AddIntIfNotNull("version", version);
			_Client.QueueServiceCall("adminconsole_entryadmin", "getByFlavorId", "KalturaBaseEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBaseEntry)KalturaObjectFactory.Create(result, "KalturaBaseEntry");
		}

		public KalturaTrackEntryListResponse GetTracks(string entryId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("entryId", entryId);
			_Client.QueueServiceCall("adminconsole_entryadmin", "getTracks", "KalturaTrackEntryListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaTrackEntryListResponse)KalturaObjectFactory.Create(result, "KalturaTrackEntryListResponse");
		}
	}
}
