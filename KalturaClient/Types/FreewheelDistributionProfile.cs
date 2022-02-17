// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class FreewheelDistributionProfile : DistributionProfile
	{
		#region Constants
		public const string APIKEY = "apikey";
		public const string EMAIL = "email";
		public const string SFTP_PASS = "sftpPass";
		public const string SFTP_LOGIN = "sftpLogin";
		public const string ACCOUNT_ID = "accountId";
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		#endregion

		#region Private Fields
		private string _Apikey = null;
		private string _Email = null;
		private string _SftpPass = null;
		private string _SftpLogin = null;
		private string _AccountId = null;
		private int _MetadataProfileId = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use ApikeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Apikey
		{
			get { return _Apikey; }
			set 
			{ 
				_Apikey = value;
				OnPropertyChanged("Apikey");
			}
		}
		/// <summary>
		/// Use EmailAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Email
		{
			get { return _Email; }
			set 
			{ 
				_Email = value;
				OnPropertyChanged("Email");
			}
		}
		/// <summary>
		/// Use SftpPassAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SftpPass
		{
			get { return _SftpPass; }
			set 
			{ 
				_SftpPass = value;
				OnPropertyChanged("SftpPass");
			}
		}
		/// <summary>
		/// Use SftpLoginAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SftpLogin
		{
			get { return _SftpLogin; }
			set 
			{ 
				_SftpLogin = value;
				OnPropertyChanged("SftpLogin");
			}
		}
		/// <summary>
		/// Use AccountIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AccountId
		{
			get { return _AccountId; }
			set 
			{ 
				_AccountId = value;
				OnPropertyChanged("AccountId");
			}
		}
		/// <summary>
		/// Use MetadataProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		#endregion

		#region CTor
		public FreewheelDistributionProfile()
		{
		}

		public FreewheelDistributionProfile(JToken node) : base(node)
		{
			if(node["apikey"] != null)
			{
				this._Apikey = node["apikey"].Value<string>();
			}
			if(node["email"] != null)
			{
				this._Email = node["email"].Value<string>();
			}
			if(node["sftpPass"] != null)
			{
				this._SftpPass = node["sftpPass"].Value<string>();
			}
			if(node["sftpLogin"] != null)
			{
				this._SftpLogin = node["sftpLogin"].Value<string>();
			}
			if(node["accountId"] != null)
			{
				this._AccountId = node["accountId"].Value<string>();
			}
			if(node["metadataProfileId"] != null)
			{
				this._MetadataProfileId = ParseInt(node["metadataProfileId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFreewheelDistributionProfile");
			kparams.AddIfNotNull("apikey", this._Apikey);
			kparams.AddIfNotNull("email", this._Email);
			kparams.AddIfNotNull("sftpPass", this._SftpPass);
			kparams.AddIfNotNull("sftpLogin", this._SftpLogin);
			kparams.AddIfNotNull("accountId", this._AccountId);
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case APIKEY:
					return "Apikey";
				case EMAIL:
					return "Email";
				case SFTP_PASS:
					return "SftpPass";
				case SFTP_LOGIN:
					return "SftpLogin";
				case ACCOUNT_ID:
					return "AccountId";
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

