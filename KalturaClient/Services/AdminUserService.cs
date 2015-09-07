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

	public class KalturaAdminUserService : KalturaServiceBase
	{
	public KalturaAdminUserService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaAdminUser UpdatePassword(string email, string password)
		{
			return this.UpdatePassword(email, password, "");
		}

		public KalturaAdminUser UpdatePassword(string email, string password, string newEmail)
		{
			return this.UpdatePassword(email, password, newEmail, "");
		}

		public KalturaAdminUser UpdatePassword(string email, string password, string newEmail, string newPassword)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("email", email);
			kparams.AddIfNotNull("password", password);
			kparams.AddIfNotNull("newEmail", newEmail);
			kparams.AddIfNotNull("newPassword", newPassword);
			_Client.QueueServiceCall("adminuser", "updatePassword", "KalturaAdminUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaAdminUser)KalturaObjectFactory.Create(result, "KalturaAdminUser");
		}

		public void ResetPassword(string email)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("email", email);
			_Client.QueueServiceCall("adminuser", "resetPassword", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public string Login(string email, string password)
		{
			return this.Login(email, password, Int32.MinValue);
		}

		public string Login(string email, string password, int partnerId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("email", email);
			kparams.AddIfNotNull("password", password);
			kparams.AddIfNotNull("partnerId", partnerId);
			_Client.QueueServiceCall("adminuser", "login", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public void SetInitialPassword(string hashKey, string newPassword)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("hashKey", hashKey);
			kparams.AddIfNotNull("newPassword", newPassword);
			_Client.QueueServiceCall("adminuser", "setInitialPassword", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}
	}
}
