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
	public class WebexDropFolder : DropFolder
	{
		#region Constants
		public const string WEBEX_USER_ID = "webexUserId";
		public const string WEBEX_PASSWORD = "webexPassword";
		public const string WEBEX_SITE_ID = "webexSiteId";
		public const string WEBEX_PARTNER_ID = "webexPartnerId";
		public const string WEBEX_SERVICE_URL = "webexServiceUrl";
		public const string WEBEX_HOST_ID_METADATA_FIELD_NAME = "webexHostIdMetadataFieldName";
		public const string DELETE_FROM_RECYCLE_BIN = "deleteFromRecycleBin";
		public const string WEBEX_SERVICE_TYPE = "webexServiceType";
		public const string WEBEX_SITE_NAME = "webexSiteName";
		public const string DELETE_FROM_TIMESTAMP = "deleteFromTimestamp";
		#endregion

		#region Private Fields
		private string _WebexUserId = null;
		private string _WebexPassword = null;
		private int _WebexSiteId = Int32.MinValue;
		private string _WebexPartnerId = null;
		private string _WebexServiceUrl = null;
		private string _WebexHostIdMetadataFieldName = null;
		private bool? _DeleteFromRecycleBin = null;
		private string _WebexServiceType = null;
		private string _WebexSiteName = null;
		private int _DeleteFromTimestamp = Int32.MinValue;
		#endregion

		#region Properties
		public string WebexUserId
		{
			get { return _WebexUserId; }
			set 
			{ 
				_WebexUserId = value;
				OnPropertyChanged("WebexUserId");
			}
		}
		public string WebexPassword
		{
			get { return _WebexPassword; }
			set 
			{ 
				_WebexPassword = value;
				OnPropertyChanged("WebexPassword");
			}
		}
		public int WebexSiteId
		{
			get { return _WebexSiteId; }
			set 
			{ 
				_WebexSiteId = value;
				OnPropertyChanged("WebexSiteId");
			}
		}
		public string WebexPartnerId
		{
			get { return _WebexPartnerId; }
			set 
			{ 
				_WebexPartnerId = value;
				OnPropertyChanged("WebexPartnerId");
			}
		}
		public string WebexServiceUrl
		{
			get { return _WebexServiceUrl; }
			set 
			{ 
				_WebexServiceUrl = value;
				OnPropertyChanged("WebexServiceUrl");
			}
		}
		public string WebexHostIdMetadataFieldName
		{
			get { return _WebexHostIdMetadataFieldName; }
			set 
			{ 
				_WebexHostIdMetadataFieldName = value;
				OnPropertyChanged("WebexHostIdMetadataFieldName");
			}
		}
		public bool? DeleteFromRecycleBin
		{
			get { return _DeleteFromRecycleBin; }
			set 
			{ 
				_DeleteFromRecycleBin = value;
				OnPropertyChanged("DeleteFromRecycleBin");
			}
		}
		public string WebexServiceType
		{
			get { return _WebexServiceType; }
			set 
			{ 
				_WebexServiceType = value;
				OnPropertyChanged("WebexServiceType");
			}
		}
		public string WebexSiteName
		{
			get { return _WebexSiteName; }
			set 
			{ 
				_WebexSiteName = value;
				OnPropertyChanged("WebexSiteName");
			}
		}
		public int DeleteFromTimestamp
		{
			get { return _DeleteFromTimestamp; }
			set 
			{ 
				_DeleteFromTimestamp = value;
				OnPropertyChanged("DeleteFromTimestamp");
			}
		}
		#endregion

		#region CTor
		public WebexDropFolder()
		{
		}

		public WebexDropFolder(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "webexUserId":
						this._WebexUserId = propertyNode.InnerText;
						continue;
					case "webexPassword":
						this._WebexPassword = propertyNode.InnerText;
						continue;
					case "webexSiteId":
						this._WebexSiteId = ParseInt(propertyNode.InnerText);
						continue;
					case "webexPartnerId":
						this._WebexPartnerId = propertyNode.InnerText;
						continue;
					case "webexServiceUrl":
						this._WebexServiceUrl = propertyNode.InnerText;
						continue;
					case "webexHostIdMetadataFieldName":
						this._WebexHostIdMetadataFieldName = propertyNode.InnerText;
						continue;
					case "deleteFromRecycleBin":
						this._DeleteFromRecycleBin = ParseBool(propertyNode.InnerText);
						continue;
					case "webexServiceType":
						this._WebexServiceType = propertyNode.InnerText;
						continue;
					case "webexSiteName":
						this._WebexSiteName = propertyNode.InnerText;
						continue;
					case "deleteFromTimestamp":
						this._DeleteFromTimestamp = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaWebexDropFolder");
			kparams.AddIfNotNull("webexUserId", this._WebexUserId);
			kparams.AddIfNotNull("webexPassword", this._WebexPassword);
			kparams.AddIfNotNull("webexSiteId", this._WebexSiteId);
			kparams.AddIfNotNull("webexPartnerId", this._WebexPartnerId);
			kparams.AddIfNotNull("webexServiceUrl", this._WebexServiceUrl);
			kparams.AddIfNotNull("webexHostIdMetadataFieldName", this._WebexHostIdMetadataFieldName);
			kparams.AddIfNotNull("deleteFromRecycleBin", this._DeleteFromRecycleBin);
			kparams.AddIfNotNull("webexServiceType", this._WebexServiceType);
			kparams.AddIfNotNull("webexSiteName", this._WebexSiteName);
			kparams.AddIfNotNull("deleteFromTimestamp", this._DeleteFromTimestamp);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case WEBEX_USER_ID:
					return "WebexUserId";
				case WEBEX_PASSWORD:
					return "WebexPassword";
				case WEBEX_SITE_ID:
					return "WebexSiteId";
				case WEBEX_PARTNER_ID:
					return "WebexPartnerId";
				case WEBEX_SERVICE_URL:
					return "WebexServiceUrl";
				case WEBEX_HOST_ID_METADATA_FIELD_NAME:
					return "WebexHostIdMetadataFieldName";
				case DELETE_FROM_RECYCLE_BIN:
					return "DeleteFromRecycleBin";
				case WEBEX_SERVICE_TYPE:
					return "WebexServiceType";
				case WEBEX_SITE_NAME:
					return "WebexSiteName";
				case DELETE_FROM_TIMESTAMP:
					return "DeleteFromTimestamp";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

