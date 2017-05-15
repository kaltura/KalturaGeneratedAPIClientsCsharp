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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class MetroPcsDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string FTP_HOST = "ftpHost";
		public const string FTP_LOGIN = "ftpLogin";
		public const string FTP_PASS = "ftpPass";
		public const string FTP_PATH = "ftpPath";
		public const string PROVIDER_NAME = "providerName";
		public const string PROVIDER_ID = "providerId";
		public const string COPYRIGHT = "copyright";
		public const string ENTITLEMENTS = "entitlements";
		public const string RATING = "rating";
		public const string ITEM_TYPE = "itemType";
		#endregion

		#region Private Fields
		private string _FtpHost = null;
		private string _FtpLogin = null;
		private string _FtpPass = null;
		private string _FtpPath = null;
		private string _ProviderName = null;
		private string _ProviderId = null;
		private string _Copyright = null;
		private string _Entitlements = null;
		private string _Rating = null;
		private string _ItemType = null;
		#endregion

		#region Properties
		public string FtpHost
		{
			get { return _FtpHost; }
			set 
			{ 
				_FtpHost = value;
				OnPropertyChanged("FtpHost");
			}
		}
		public string FtpLogin
		{
			get { return _FtpLogin; }
			set 
			{ 
				_FtpLogin = value;
				OnPropertyChanged("FtpLogin");
			}
		}
		public string FtpPass
		{
			get { return _FtpPass; }
			set 
			{ 
				_FtpPass = value;
				OnPropertyChanged("FtpPass");
			}
		}
		public string FtpPath
		{
			get { return _FtpPath; }
			set 
			{ 
				_FtpPath = value;
				OnPropertyChanged("FtpPath");
			}
		}
		public string ProviderName
		{
			get { return _ProviderName; }
			set 
			{ 
				_ProviderName = value;
				OnPropertyChanged("ProviderName");
			}
		}
		public string ProviderId
		{
			get { return _ProviderId; }
			set 
			{ 
				_ProviderId = value;
				OnPropertyChanged("ProviderId");
			}
		}
		public string Copyright
		{
			get { return _Copyright; }
			set 
			{ 
				_Copyright = value;
				OnPropertyChanged("Copyright");
			}
		}
		public string Entitlements
		{
			get { return _Entitlements; }
			set 
			{ 
				_Entitlements = value;
				OnPropertyChanged("Entitlements");
			}
		}
		public string Rating
		{
			get { return _Rating; }
			set 
			{ 
				_Rating = value;
				OnPropertyChanged("Rating");
			}
		}
		public string ItemType
		{
			get { return _ItemType; }
			set 
			{ 
				_ItemType = value;
				OnPropertyChanged("ItemType");
			}
		}
		#endregion

		#region CTor
		public MetroPcsDistributionProfile()
		{
		}

		public MetroPcsDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "ftpHost":
						this._FtpHost = propertyNode.InnerText;
						continue;
					case "ftpLogin":
						this._FtpLogin = propertyNode.InnerText;
						continue;
					case "ftpPass":
						this._FtpPass = propertyNode.InnerText;
						continue;
					case "ftpPath":
						this._FtpPath = propertyNode.InnerText;
						continue;
					case "providerName":
						this._ProviderName = propertyNode.InnerText;
						continue;
					case "providerId":
						this._ProviderId = propertyNode.InnerText;
						continue;
					case "copyright":
						this._Copyright = propertyNode.InnerText;
						continue;
					case "entitlements":
						this._Entitlements = propertyNode.InnerText;
						continue;
					case "rating":
						this._Rating = propertyNode.InnerText;
						continue;
					case "itemType":
						this._ItemType = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaMetroPcsDistributionProfile");
			kparams.AddIfNotNull("ftpHost", this._FtpHost);
			kparams.AddIfNotNull("ftpLogin", this._FtpLogin);
			kparams.AddIfNotNull("ftpPass", this._FtpPass);
			kparams.AddIfNotNull("ftpPath", this._FtpPath);
			kparams.AddIfNotNull("providerName", this._ProviderName);
			kparams.AddIfNotNull("providerId", this._ProviderId);
			kparams.AddIfNotNull("copyright", this._Copyright);
			kparams.AddIfNotNull("entitlements", this._Entitlements);
			kparams.AddIfNotNull("rating", this._Rating);
			kparams.AddIfNotNull("itemType", this._ItemType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FTP_HOST:
					return "FtpHost";
				case FTP_LOGIN:
					return "FtpLogin";
				case FTP_PASS:
					return "FtpPass";
				case FTP_PATH:
					return "FtpPath";
				case PROVIDER_NAME:
					return "ProviderName";
				case PROVIDER_ID:
					return "ProviderId";
				case COPYRIGHT:
					return "Copyright";
				case ENTITLEMENTS:
					return "Entitlements";
				case RATING:
					return "Rating";
				case ITEM_TYPE:
					return "ItemType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

