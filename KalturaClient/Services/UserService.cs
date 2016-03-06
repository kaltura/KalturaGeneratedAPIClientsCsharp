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

	public class KalturaUserService : KalturaServiceBase
	{
	public KalturaUserService(KalturaClient client)
			: base(client)
		{
		}

		public KalturaUser Add(KalturaUser user)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("user", user);
			_Client.QueueServiceCall("user", "add", "KalturaUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result, "KalturaUser");
		}

		public KalturaUser Update(string userId, KalturaUser user)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("userId", userId);
			kparams.AddIfNotNull("user", user);
			_Client.QueueServiceCall("user", "update", "KalturaUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result, "KalturaUser");
		}

		public KalturaUser Get()
		{
			return this.Get(null);
		}

		public KalturaUser Get(string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("userId", userId);
			_Client.QueueServiceCall("user", "get", "KalturaUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result, "KalturaUser");
		}

		public KalturaUser GetByLoginId(string loginId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("loginId", loginId);
			_Client.QueueServiceCall("user", "getByLoginId", "KalturaUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result, "KalturaUser");
		}

		public KalturaUser Delete(string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("userId", userId);
			_Client.QueueServiceCall("user", "delete", "KalturaUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result, "KalturaUser");
		}

		public KalturaUserListResponse List()
		{
			return this.List(null);
		}

		public KalturaUserListResponse List(KalturaUserFilter filter)
		{
			return this.List(filter, null);
		}

		public KalturaUserListResponse List(KalturaUserFilter filter, KalturaFilterPager pager)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			kparams.AddIfNotNull("pager", pager);
			_Client.QueueServiceCall("user", "list", "KalturaUserListResponse", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUserListResponse)KalturaObjectFactory.Create(result, "KalturaUserListResponse");
		}

		public void NotifyBan(string userId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("userId", userId);
			_Client.QueueServiceCall("user", "notifyBan", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public string Login(int partnerId, string userId, string password)
		{
			return this.Login(partnerId, userId, password, 86400);
		}

		public string Login(int partnerId, string userId, string password, int expiry)
		{
			return this.Login(partnerId, userId, password, expiry, "*");
		}

		public string Login(int partnerId, string userId, string password, int expiry, string privileges)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("partnerId", partnerId);
			kparams.AddIfNotNull("userId", userId);
			kparams.AddIfNotNull("password", password);
			kparams.AddIfNotNull("expiry", expiry);
			kparams.AddIfNotNull("privileges", privileges);
			_Client.QueueServiceCall("user", "login", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public string LoginByLoginId(string loginId, string password)
		{
			return this.LoginByLoginId(loginId, password, Int32.MinValue);
		}

		public string LoginByLoginId(string loginId, string password, int partnerId)
		{
			return this.LoginByLoginId(loginId, password, partnerId, 86400);
		}

		public string LoginByLoginId(string loginId, string password, int partnerId, int expiry)
		{
			return this.LoginByLoginId(loginId, password, partnerId, expiry, "*");
		}

		public string LoginByLoginId(string loginId, string password, int partnerId, int expiry, string privileges)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("loginId", loginId);
			kparams.AddIfNotNull("password", password);
			kparams.AddIfNotNull("partnerId", partnerId);
			kparams.AddIfNotNull("expiry", expiry);
			kparams.AddIfNotNull("privileges", privileges);
			_Client.QueueServiceCall("user", "loginByLoginId", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public void UpdateLoginData(string oldLoginId, string password)
		{
			this.UpdateLoginData(oldLoginId, password, "");
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId)
		{
			this.UpdateLoginData(oldLoginId, password, newLoginId, "");
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId, string newPassword)
		{
			this.UpdateLoginData(oldLoginId, password, newLoginId, newPassword, null);
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId, string newPassword, string newFirstName)
		{
			this.UpdateLoginData(oldLoginId, password, newLoginId, newPassword, newFirstName, null);
		}

		public void UpdateLoginData(string oldLoginId, string password, string newLoginId, string newPassword, string newFirstName, string newLastName)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("oldLoginId", oldLoginId);
			kparams.AddIfNotNull("password", password);
			kparams.AddIfNotNull("newLoginId", newLoginId);
			kparams.AddIfNotNull("newPassword", newPassword);
			kparams.AddIfNotNull("newFirstName", newFirstName);
			kparams.AddIfNotNull("newLastName", newLastName);
			_Client.QueueServiceCall("user", "updateLoginData", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void ResetPassword(string email)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("email", email);
			_Client.QueueServiceCall("user", "resetPassword", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public void SetInitialPassword(string hashKey, string newPassword)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("hashKey", hashKey);
			kparams.AddIfNotNull("newPassword", newPassword);
			_Client.QueueServiceCall("user", "setInitialPassword", null, kparams);
			if (this._Client.IsMultiRequest)
				return;
			XmlElement result = _Client.DoQueue();
		}

		public KalturaUser EnableLogin(string userId, string loginId)
		{
			return this.EnableLogin(userId, loginId, null);
		}

		public KalturaUser EnableLogin(string userId, string loginId, string password)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("userId", userId);
			kparams.AddIfNotNull("loginId", loginId);
			kparams.AddIfNotNull("password", password);
			_Client.QueueServiceCall("user", "enableLogin", "KalturaUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result, "KalturaUser");
		}

		public KalturaUser DisableLogin()
		{
			return this.DisableLogin(null);
		}

		public KalturaUser DisableLogin(string userId)
		{
			return this.DisableLogin(userId, null);
		}

		public KalturaUser DisableLogin(string userId, string loginId)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("userId", userId);
			kparams.AddIfNotNull("loginId", loginId);
			_Client.QueueServiceCall("user", "disableLogin", "KalturaUser", kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaUser)KalturaObjectFactory.Create(result, "KalturaUser");
		}

		public string Index(string id)
		{
			return this.Index(id, true);
		}

		public string Index(string id, bool shouldUpdate)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("id", id);
			kparams.AddIfNotNull("shouldUpdate", shouldUpdate);
			_Client.QueueServiceCall("user", "index", null, kparams);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return result.InnerText;
		}

		public KalturaBulkUpload AddFromBulkUpload(Stream fileData)
		{
			return this.AddFromBulkUpload(fileData, null);
		}

		public KalturaBulkUpload AddFromBulkUpload(Stream fileData, KalturaBulkUploadJobData bulkUploadData)
		{
			return this.AddFromBulkUpload(fileData, bulkUploadData, null);
		}

		public KalturaBulkUpload AddFromBulkUpload(Stream fileData, KalturaBulkUploadJobData bulkUploadData, KalturaBulkUploadUserData bulkUploadUserData)
		{
			KalturaParams kparams = new KalturaParams();
			KalturaFiles kfiles = new KalturaFiles();
			kfiles.Add("fileData", fileData);
			kparams.AddIfNotNull("bulkUploadData", bulkUploadData);
			kparams.AddIfNotNull("bulkUploadUserData", bulkUploadUserData);
			_Client.QueueServiceCall("user", "addFromBulkUpload", "KalturaBulkUpload", kparams, kfiles);
			if (this._Client.IsMultiRequest)
				return null;
			XmlElement result = _Client.DoQueue();
			return (KalturaBulkUpload)KalturaObjectFactory.Create(result, "KalturaBulkUpload");
		}

		public bool CheckLoginDataExists(KalturaUserLoginDataFilter filter)
		{
			KalturaParams kparams = new KalturaParams();
			kparams.AddIfNotNull("filter", filter);
			_Client.QueueServiceCall("user", "checkLoginDataExists", null, kparams);
			if (this._Client.IsMultiRequest)
				return false;
			XmlElement result = _Client.DoQueue();
			if (result.InnerText == "1")
				return true;
			return false;
		}
	}
}
