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

	public class KalturaEmailIngestionProfileService : KalturaServiceBase
	{
	public KalturaEmailIngestionProfileService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaEmailIngestionProfile Add(KalturaEmailIngestionProfile EmailIP)
		{
			KalturaParams kparams = new KalturaParams();
			if (EmailIP != null)
				kparams.Add("EmailIP", EmailIP.ToParams());
			_Client.QueueServiceCall("emailingestionprofile", "add", "KalturaEmailIngestionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEmailIngestionProfile)KalturaObjectFactory.Create(result, "KalturaEmailIngestionProfile");
		}

		public KalturaEmailIngestionProfile GetByEmailAddress(string emailAddress)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("emailAddress", emailAddress);
			_Client.QueueServiceCall("emailingestionprofile", "getByEmailAddress", "KalturaEmailIngestionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEmailIngestionProfile)KalturaObjectFactory.Create(result, "KalturaEmailIngestionProfile");
		}

		public KalturaEmailIngestionProfile Get(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("emailingestionprofile", "get", "KalturaEmailIngestionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEmailIngestionProfile)KalturaObjectFactory.Create(result, "KalturaEmailIngestionProfile");
		}

		public KalturaEmailIngestionProfile Update(int id, KalturaEmailIngestionProfile EmailIP)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			if (EmailIP != null)
				kparams.Add("EmailIP", EmailIP.ToParams());
			_Client.QueueServiceCall("emailingestionprofile", "update", "KalturaEmailIngestionProfile", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaEmailIngestionProfile)KalturaObjectFactory.Create(result, "KalturaEmailIngestionProfile");
		}

		public void Delete(int id)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIntIfNotNull("id", id);
			_Client.QueueServiceCall("emailingestionprofile", "delete", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaMediaEntry AddMediaEntry(KalturaMediaEntry mediaEntry, string uploadTokenId, int emailProfId, string fromAddress, string emailMsgId)
		{
			KalturaParams kparams = new KalturaParams();
			if (mediaEntry != null)
				kparams.Add("mediaEntry", mediaEntry.ToParams());
			kparams.AddStringIfNotNull("uploadTokenId", uploadTokenId);
			kparams.AddIntIfNotNull("emailProfId", emailProfId);
			kparams.AddStringIfNotNull("fromAddress", fromAddress);
			kparams.AddStringIfNotNull("emailMsgId", emailMsgId);
			_Client.QueueServiceCall("emailingestionprofile", "addMediaEntry", "KalturaMediaEntry", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaMediaEntry)KalturaObjectFactory.Create(result, "KalturaMediaEntry");
		}
	}
}
