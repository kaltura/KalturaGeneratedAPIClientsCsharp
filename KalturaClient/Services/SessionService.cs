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

	public class KalturaSessionService : KalturaServiceBase
	{
	public KalturaSessionService(KalturaClient client)
			: base(client)
		{
		}

		public string Start(string secret)
		{
			return this.Start(secret, "");
		}

		public string Start(string secret, string userId)
		{
			return this.Start(secret, userId, (KalturaSessionType)(0));
		}

		public string Start(string secret, string userId, KalturaSessionType type)
		{
			return this.Start(secret, userId, type, Int32.MinValue);
		}

		public string Start(string secret, string userId, KalturaSessionType type, int partnerId)
		{
			return this.Start(secret, userId, type, partnerId, 86400);
		}

		public string Start(string secret, string userId, KalturaSessionType type, int partnerId, int expiry)
		{
			return this.Start(secret, userId, type, partnerId, expiry, null);
		}

		public string Start(string secret, string userId, KalturaSessionType type, int partnerId, int expiry, string privileges)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("secret", secret);
			kparams.AddStringIfNotNull("userId", userId);
			kparams.AddEnumIfNotNull("type", type);
			kparams.AddIntIfNotNull("partnerId", partnerId);
			kparams.AddIntIfNotNull("expiry", expiry);
			kparams.AddStringIfNotNull("privileges", privileges);
			_Client.QueueServiceCall("session", "start", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public void End()
		{
			KalturaParams kparams = new KalturaParams();
			_Client.QueueServiceCall("session", "end", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public string Impersonate(string secret, int impersonatedPartnerId)
		{
			return this.Impersonate(secret, impersonatedPartnerId, "");
		}

		public string Impersonate(string secret, int impersonatedPartnerId, string userId)
		{
			return this.Impersonate(secret, impersonatedPartnerId, userId, (KalturaSessionType)(0));
		}

		public string Impersonate(string secret, int impersonatedPartnerId, string userId, KalturaSessionType type)
		{
			return this.Impersonate(secret, impersonatedPartnerId, userId, type, Int32.MinValue);
		}

		public string Impersonate(string secret, int impersonatedPartnerId, string userId, KalturaSessionType type, int partnerId)
		{
			return this.Impersonate(secret, impersonatedPartnerId, userId, type, partnerId, 86400);
		}

		public string Impersonate(string secret, int impersonatedPartnerId, string userId, KalturaSessionType type, int partnerId, int expiry)
		{
			return this.Impersonate(secret, impersonatedPartnerId, userId, type, partnerId, expiry, null);
		}

		public string Impersonate(string secret, int impersonatedPartnerId, string userId, KalturaSessionType type, int partnerId, int expiry, string privileges)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("secret", secret);
			kparams.AddIntIfNotNull("impersonatedPartnerId", impersonatedPartnerId);
			kparams.AddStringIfNotNull("userId", userId);
			kparams.AddEnumIfNotNull("type", type);
			kparams.AddIntIfNotNull("partnerId", partnerId);
			kparams.AddIntIfNotNull("expiry", expiry);
			kparams.AddStringIfNotNull("privileges", privileges);
			_Client.QueueServiceCall("session", "impersonate", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaSessionInfo ImpersonateByKs(string session)
		{
			return this.ImpersonateByKs(session, (KalturaSessionType)(Int32.MinValue));
		}

		public KalturaSessionInfo ImpersonateByKs(string session, KalturaSessionType type)
		{
			return this.ImpersonateByKs(session, type, Int32.MinValue);
		}

		public KalturaSessionInfo ImpersonateByKs(string session, KalturaSessionType type, int expiry)
		{
			return this.ImpersonateByKs(session, type, expiry, null);
		}

		public KalturaSessionInfo ImpersonateByKs(string session, KalturaSessionType type, int expiry, string privileges)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("session", session);
			kparams.AddEnumIfNotNull("type", type);
			kparams.AddIntIfNotNull("expiry", expiry);
			kparams.AddStringIfNotNull("privileges", privileges);
			_Client.QueueServiceCall("session", "impersonateByKs", "KalturaSessionInfo", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSessionInfo)KalturaObjectFactory.Create(result, "KalturaSessionInfo");
		}

		public KalturaSessionInfo Get()
		{
			return this.Get(null);
		}

		public KalturaSessionInfo Get(string session)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("session", session);
			_Client.QueueServiceCall("session", "get", "KalturaSessionInfo", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaSessionInfo)KalturaObjectFactory.Create(result, "KalturaSessionInfo");
		}

		public KalturaStartWidgetSessionResponse StartWidgetSession(string widgetId)
		{
			return this.StartWidgetSession(widgetId, 86400);
		}

		public KalturaStartWidgetSessionResponse StartWidgetSession(string widgetId, int expiry)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddStringIfNotNull("widgetId", widgetId);
			kparams.AddIntIfNotNull("expiry", expiry);
			_Client.QueueServiceCall("session", "startWidgetSession", "KalturaStartWidgetSessionResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaStartWidgetSessionResponse)KalturaObjectFactory.Create(result, "KalturaStartWidgetSessionResponse");
		}
	}
}
