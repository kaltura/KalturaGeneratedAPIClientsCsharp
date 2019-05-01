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
// Copyright (C) 2006-2019  Kaltura Inc.
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
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;
using Newtonsoft.Json.Linq;

namespace Kaltura.Services
{
	public class AdminUserLoginRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string EMAIL = "email";
		public const string PASSWORD = "password";
		public new const string PARTNER_ID = "partnerId";
		#endregion

		public string Email { get; set; }
		public string Password { get; set; }
		public new int PartnerId { get; set; }

		public AdminUserLoginRequestBuilder()
			: base("adminuser", "login")
		{
		}

		public AdminUserLoginRequestBuilder(string email, string password, int partnerId)
			: this()
		{
			this.Email = email;
			this.Password = password;
			this.PartnerId = partnerId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("email"))
				kparams.AddIfNotNull("email", Email);
			if (!isMapped("password"))
				kparams.AddIfNotNull("password", Password);
			if (!isMapped("partnerId"))
				kparams.AddIfNotNull("partnerId", PartnerId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return result.Value<string>();
		}
	}

	public class AdminUserResetPasswordRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string EMAIL = "email";
		#endregion

		public string Email { get; set; }

		public AdminUserResetPasswordRequestBuilder()
			: base("adminuser", "resetPassword")
		{
		}

		public AdminUserResetPasswordRequestBuilder(string email)
			: this()
		{
			this.Email = email;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("email"))
				kparams.AddIfNotNull("email", Email);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class AdminUserSetInitialPasswordRequestBuilder : RequestBuilder<VoidResponse>
	{
		#region Constants
		public const string HASH_KEY = "hashKey";
		public const string NEW_PASSWORD = "newPassword";
		#endregion

		public string HashKey { get; set; }
		public string NewPassword { get; set; }

		public AdminUserSetInitialPasswordRequestBuilder()
			: base("adminuser", "setInitialPassword")
		{
		}

		public AdminUserSetInitialPasswordRequestBuilder(string hashKey, string newPassword)
			: this()
		{
			this.HashKey = hashKey;
			this.NewPassword = newPassword;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("hashKey"))
				kparams.AddIfNotNull("hashKey", HashKey);
			if (!isMapped("newPassword"))
				kparams.AddIfNotNull("newPassword", NewPassword);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return null;
		}
	}

	public class AdminUserUpdatePasswordRequestBuilder : RequestBuilder<AdminUser>
	{
		#region Constants
		public const string EMAIL = "email";
		public const string PASSWORD = "password";
		public const string NEW_EMAIL = "newEmail";
		public const string NEW_PASSWORD = "newPassword";
		#endregion

		public string Email { get; set; }
		public string Password { get; set; }
		public string NewEmail { get; set; }
		public string NewPassword { get; set; }

		public AdminUserUpdatePasswordRequestBuilder()
			: base("adminuser", "updatePassword")
		{
		}

		public AdminUserUpdatePasswordRequestBuilder(string email, string password, string newEmail, string newPassword)
			: this()
		{
			this.Email = email;
			this.Password = password;
			this.NewEmail = newEmail;
			this.NewPassword = newPassword;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("email"))
				kparams.AddIfNotNull("email", Email);
			if (!isMapped("password"))
				kparams.AddIfNotNull("password", Password);
			if (!isMapped("newEmail"))
				kparams.AddIfNotNull("newEmail", NewEmail);
			if (!isMapped("newPassword"))
				kparams.AddIfNotNull("newPassword", NewPassword);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(JToken result)
		{
			return ObjectFactory.Create<AdminUser>(result);
		}
	}


	public class AdminUserService
	{
		private AdminUserService()
		{
		}

		public static AdminUserLoginRequestBuilder Login(string email, string password, int partnerId = Int32.MinValue)
		{
			return new AdminUserLoginRequestBuilder(email, password, partnerId);
		}

		public static AdminUserResetPasswordRequestBuilder ResetPassword(string email)
		{
			return new AdminUserResetPasswordRequestBuilder(email);
		}

		public static AdminUserSetInitialPasswordRequestBuilder SetInitialPassword(string hashKey, string newPassword)
		{
			return new AdminUserSetInitialPasswordRequestBuilder(hashKey, newPassword);
		}

		public static AdminUserUpdatePasswordRequestBuilder UpdatePassword(string email, string password, string newEmail = "", string newPassword = "")
		{
			return new AdminUserUpdatePasswordRequestBuilder(email, password, newEmail, newPassword);
		}
	}
}
