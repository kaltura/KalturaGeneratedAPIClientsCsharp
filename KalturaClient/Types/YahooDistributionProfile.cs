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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class YahooDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string FTP_PATH = "ftpPath";
		public const string FTP_USERNAME = "ftpUsername";
		public const string FTP_PASSWORD = "ftpPassword";
		public const string FTP_HOST = "ftpHost";
		public const string CONTACT_TELEPHONE = "contactTelephone";
		public const string CONTACT_EMAIL = "contactEmail";
		public const string PROCESS_FEED = "processFeed";
		#endregion

		#region Private Fields
		private string _FtpPath = null;
		private string _FtpUsername = null;
		private string _FtpPassword = null;
		private string _FtpHost = null;
		private string _ContactTelephone = null;
		private string _ContactEmail = null;
		private YahooDistributionProcessFeedActionStatus _ProcessFeed = (YahooDistributionProcessFeedActionStatus)Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string FtpPath
		{
			get { return _FtpPath; }
			set 
			{ 
				_FtpPath = value;
				OnPropertyChanged("FtpPath");
			}
		}
		[JsonProperty]
		public string FtpUsername
		{
			get { return _FtpUsername; }
			set 
			{ 
				_FtpUsername = value;
				OnPropertyChanged("FtpUsername");
			}
		}
		[JsonProperty]
		public string FtpPassword
		{
			get { return _FtpPassword; }
			set 
			{ 
				_FtpPassword = value;
				OnPropertyChanged("FtpPassword");
			}
		}
		[JsonProperty]
		public string FtpHost
		{
			get { return _FtpHost; }
			set 
			{ 
				_FtpHost = value;
				OnPropertyChanged("FtpHost");
			}
		}
		[JsonProperty]
		public string ContactTelephone
		{
			get { return _ContactTelephone; }
			set 
			{ 
				_ContactTelephone = value;
				OnPropertyChanged("ContactTelephone");
			}
		}
		[JsonProperty]
		public string ContactEmail
		{
			get { return _ContactEmail; }
			set 
			{ 
				_ContactEmail = value;
				OnPropertyChanged("ContactEmail");
			}
		}
		[JsonProperty]
		public YahooDistributionProcessFeedActionStatus ProcessFeed
		{
			get { return _ProcessFeed; }
			set 
			{ 
				_ProcessFeed = value;
				OnPropertyChanged("ProcessFeed");
			}
		}
		#endregion

		#region CTor
		public YahooDistributionProfile()
		{
		}

		public YahooDistributionProfile(JToken node) : base(node)
		{
			if(node["ftpPath"] != null)
			{
				this._FtpPath = node["ftpPath"].Value<string>();
			}
			if(node["ftpUsername"] != null)
			{
				this._FtpUsername = node["ftpUsername"].Value<string>();
			}
			if(node["ftpPassword"] != null)
			{
				this._FtpPassword = node["ftpPassword"].Value<string>();
			}
			if(node["ftpHost"] != null)
			{
				this._FtpHost = node["ftpHost"].Value<string>();
			}
			if(node["contactTelephone"] != null)
			{
				this._ContactTelephone = node["contactTelephone"].Value<string>();
			}
			if(node["contactEmail"] != null)
			{
				this._ContactEmail = node["contactEmail"].Value<string>();
			}
			if(node["processFeed"] != null)
			{
				this._ProcessFeed = (YahooDistributionProcessFeedActionStatus)ParseEnum(typeof(YahooDistributionProcessFeedActionStatus), node["processFeed"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaYahooDistributionProfile");
			kparams.AddIfNotNull("ftpPath", this._FtpPath);
			kparams.AddIfNotNull("ftpUsername", this._FtpUsername);
			kparams.AddIfNotNull("ftpPassword", this._FtpPassword);
			kparams.AddIfNotNull("ftpHost", this._FtpHost);
			kparams.AddIfNotNull("contactTelephone", this._ContactTelephone);
			kparams.AddIfNotNull("contactEmail", this._ContactEmail);
			kparams.AddIfNotNull("processFeed", this._ProcessFeed);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FTP_PATH:
					return "FtpPath";
				case FTP_USERNAME:
					return "FtpUsername";
				case FTP_PASSWORD:
					return "FtpPassword";
				case FTP_HOST:
					return "FtpHost";
				case CONTACT_TELEPHONE:
					return "ContactTelephone";
				case CONTACT_EMAIL:
					return "ContactEmail";
				case PROCESS_FEED:
					return "ProcessFeed";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

