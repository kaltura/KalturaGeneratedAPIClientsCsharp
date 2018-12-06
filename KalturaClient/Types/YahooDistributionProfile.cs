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
		public string FtpPath
		{
			get { return _FtpPath; }
			set 
			{ 
				_FtpPath = value;
				OnPropertyChanged("FtpPath");
			}
		}
		public string FtpUsername
		{
			get { return _FtpUsername; }
			set 
			{ 
				_FtpUsername = value;
				OnPropertyChanged("FtpUsername");
			}
		}
		public string FtpPassword
		{
			get { return _FtpPassword; }
			set 
			{ 
				_FtpPassword = value;
				OnPropertyChanged("FtpPassword");
			}
		}
		public string FtpHost
		{
			get { return _FtpHost; }
			set 
			{ 
				_FtpHost = value;
				OnPropertyChanged("FtpHost");
			}
		}
		public string ContactTelephone
		{
			get { return _ContactTelephone; }
			set 
			{ 
				_ContactTelephone = value;
				OnPropertyChanged("ContactTelephone");
			}
		}
		public string ContactEmail
		{
			get { return _ContactEmail; }
			set 
			{ 
				_ContactEmail = value;
				OnPropertyChanged("ContactEmail");
			}
		}
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

		public YahooDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "ftpPath":
						this._FtpPath = propertyNode.InnerText;
						continue;
					case "ftpUsername":
						this._FtpUsername = propertyNode.InnerText;
						continue;
					case "ftpPassword":
						this._FtpPassword = propertyNode.InnerText;
						continue;
					case "ftpHost":
						this._FtpHost = propertyNode.InnerText;
						continue;
					case "contactTelephone":
						this._ContactTelephone = propertyNode.InnerText;
						continue;
					case "contactEmail":
						this._ContactEmail = propertyNode.InnerText;
						continue;
					case "processFeed":
						this._ProcessFeed = (YahooDistributionProcessFeedActionStatus)ParseEnum(typeof(YahooDistributionProcessFeedActionStatus), propertyNode.InnerText);
						continue;
				}
			}
		}

		public YahooDistributionProfile(IDictionary<string,object> data) : base(data)
		{
			    this._FtpPath = data.TryGetValueSafe<string>("ftpPath");
			    this._FtpUsername = data.TryGetValueSafe<string>("ftpUsername");
			    this._FtpPassword = data.TryGetValueSafe<string>("ftpPassword");
			    this._FtpHost = data.TryGetValueSafe<string>("ftpHost");
			    this._ContactTelephone = data.TryGetValueSafe<string>("contactTelephone");
			    this._ContactEmail = data.TryGetValueSafe<string>("contactEmail");
			    this._ProcessFeed = (YahooDistributionProcessFeedActionStatus)ParseEnum(typeof(YahooDistributionProcessFeedActionStatus), data.TryGetValueSafe<int>("processFeed"));
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

