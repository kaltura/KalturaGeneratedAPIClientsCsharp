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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class IdeticDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string FTP_PATH = "ftpPath";
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		public const string DOMAIN = "domain";
		#endregion

		#region Private Fields
		private string _FtpPath = null;
		private string _Username = null;
		private string _Password = null;
		private string _Domain = null;
		#endregion

		#region Properties
		public string FtpPath
		{
			get { return _FtpPath; }
			set 
			{ 
				_FtpPath = value;
				OnPropertyChanged("FtpPath");
			}
		}
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		public string Domain
		{
			get { return _Domain; }
			set 
			{ 
				_Domain = value;
				OnPropertyChanged("Domain");
			}
		}
		#endregion

		#region CTor
		public IdeticDistributionProfile()
		{
		}

		public IdeticDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "ftpPath":
						this._FtpPath = txt;
						continue;
					case "username":
						this._Username = txt;
						continue;
					case "password":
						this._Password = txt;
						continue;
					case "domain":
						this._Domain = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIdeticDistributionProfile");
			kparams.AddIfNotNull("ftpPath", this._FtpPath);
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("domain", this._Domain);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FTP_PATH:
					return "FtpPath";
				case USERNAME:
					return "Username";
				case PASSWORD:
					return "Password";
				case DOMAIN:
					return "Domain";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

