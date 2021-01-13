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
		[JsonProperty]
		public string WebexUserId
		{
			get { return _WebexUserId; }
			set 
			{ 
				_WebexUserId = value;
				OnPropertyChanged("WebexUserId");
			}
		}
		[JsonProperty]
		public string WebexPassword
		{
			get { return _WebexPassword; }
			set 
			{ 
				_WebexPassword = value;
				OnPropertyChanged("WebexPassword");
			}
		}
		[JsonProperty]
		public int WebexSiteId
		{
			get { return _WebexSiteId; }
			set 
			{ 
				_WebexSiteId = value;
				OnPropertyChanged("WebexSiteId");
			}
		}
		[JsonProperty]
		public string WebexPartnerId
		{
			get { return _WebexPartnerId; }
			set 
			{ 
				_WebexPartnerId = value;
				OnPropertyChanged("WebexPartnerId");
			}
		}
		[JsonProperty]
		public string WebexServiceUrl
		{
			get { return _WebexServiceUrl; }
			set 
			{ 
				_WebexServiceUrl = value;
				OnPropertyChanged("WebexServiceUrl");
			}
		}
		[JsonProperty]
		public string WebexHostIdMetadataFieldName
		{
			get { return _WebexHostIdMetadataFieldName; }
			set 
			{ 
				_WebexHostIdMetadataFieldName = value;
				OnPropertyChanged("WebexHostIdMetadataFieldName");
			}
		}
		[JsonProperty]
		public bool? DeleteFromRecycleBin
		{
			get { return _DeleteFromRecycleBin; }
			set 
			{ 
				_DeleteFromRecycleBin = value;
				OnPropertyChanged("DeleteFromRecycleBin");
			}
		}
		[JsonProperty]
		public string WebexServiceType
		{
			get { return _WebexServiceType; }
			set 
			{ 
				_WebexServiceType = value;
				OnPropertyChanged("WebexServiceType");
			}
		}
		[JsonProperty]
		public string WebexSiteName
		{
			get { return _WebexSiteName; }
			set 
			{ 
				_WebexSiteName = value;
				OnPropertyChanged("WebexSiteName");
			}
		}
		[JsonProperty]
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

		public WebexDropFolder(JToken node) : base(node)
		{
			if(node["webexUserId"] != null)
			{
				this._WebexUserId = node["webexUserId"].Value<string>();
			}
			if(node["webexPassword"] != null)
			{
				this._WebexPassword = node["webexPassword"].Value<string>();
			}
			if(node["webexSiteId"] != null)
			{
				this._WebexSiteId = ParseInt(node["webexSiteId"].Value<string>());
			}
			if(node["webexPartnerId"] != null)
			{
				this._WebexPartnerId = node["webexPartnerId"].Value<string>();
			}
			if(node["webexServiceUrl"] != null)
			{
				this._WebexServiceUrl = node["webexServiceUrl"].Value<string>();
			}
			if(node["webexHostIdMetadataFieldName"] != null)
			{
				this._WebexHostIdMetadataFieldName = node["webexHostIdMetadataFieldName"].Value<string>();
			}
			if(node["deleteFromRecycleBin"] != null)
			{
				this._DeleteFromRecycleBin = ParseBool(node["deleteFromRecycleBin"].Value<string>());
			}
			if(node["webexServiceType"] != null)
			{
				this._WebexServiceType = node["webexServiceType"].Value<string>();
			}
			if(node["webexSiteName"] != null)
			{
				this._WebexSiteName = node["webexSiteName"].Value<string>();
			}
			if(node["deleteFromTimestamp"] != null)
			{
				this._DeleteFromTimestamp = ParseInt(node["deleteFromTimestamp"].Value<string>());
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

