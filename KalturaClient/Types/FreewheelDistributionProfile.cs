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
// Copyright (C) 2006-2018  Kaltura Inc.
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
		public string Apikey
		{
			get { return _Apikey; }
			set 
			{ 
				_Apikey = value;
				OnPropertyChanged("Apikey");
			}
		}
		public string Email
		{
			get { return _Email; }
			set 
			{ 
				_Email = value;
				OnPropertyChanged("Email");
			}
		}
		public string SftpPass
		{
			get { return _SftpPass; }
			set 
			{ 
				_SftpPass = value;
				OnPropertyChanged("SftpPass");
			}
		}
		public string SftpLogin
		{
			get { return _SftpLogin; }
			set 
			{ 
				_SftpLogin = value;
				OnPropertyChanged("SftpLogin");
			}
		}
		public string AccountId
		{
			get { return _AccountId; }
			set 
			{ 
				_AccountId = value;
				OnPropertyChanged("AccountId");
			}
		}
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

		public FreewheelDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "apikey":
						this._Apikey = propertyNode.InnerText;
						continue;
					case "email":
						this._Email = propertyNode.InnerText;
						continue;
					case "sftpPass":
						this._SftpPass = propertyNode.InnerText;
						continue;
					case "sftpLogin":
						this._SftpLogin = propertyNode.InnerText;
						continue;
					case "accountId":
						this._AccountId = propertyNode.InnerText;
						continue;
					case "metadataProfileId":
						this._MetadataProfileId = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public FreewheelDistributionProfile(IDictionary<string,object> data) : base(data)
		{
			    this._Apikey = data.TryGetValueSafe<string>("apikey");
			    this._Email = data.TryGetValueSafe<string>("email");
			    this._SftpPass = data.TryGetValueSafe<string>("sftpPass");
			    this._SftpLogin = data.TryGetValueSafe<string>("sftpLogin");
			    this._AccountId = data.TryGetValueSafe<string>("accountId");
			    this._MetadataProfileId = data.TryGetValueSafe<int>("metadataProfileId");
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

