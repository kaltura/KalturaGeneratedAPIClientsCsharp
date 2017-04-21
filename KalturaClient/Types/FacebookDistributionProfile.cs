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
	public class FacebookDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string API_AUTHORIZE_URL = "apiAuthorizeUrl";
		public const string PAGE_ID = "pageId";
		public const string PAGE_ACCESS_TOKEN = "pageAccessToken";
		public const string USER_ACCESS_TOKEN = "userAccessToken";
		public const string STATE = "state";
		public const string PERMISSIONS = "permissions";
		public const string RE_REQUEST_PERMISSIONS = "reRequestPermissions";
		#endregion

		#region Private Fields
		private string _ApiAuthorizeUrl = null;
		private string _PageId = null;
		private string _PageAccessToken = null;
		private string _UserAccessToken = null;
		private string _State = null;
		private string _Permissions = null;
		private int _ReRequestPermissions = Int32.MinValue;
		#endregion

		#region Properties
		public string ApiAuthorizeUrl
		{
			get { return _ApiAuthorizeUrl; }
			set 
			{ 
				_ApiAuthorizeUrl = value;
				OnPropertyChanged("ApiAuthorizeUrl");
			}
		}
		public string PageId
		{
			get { return _PageId; }
			set 
			{ 
				_PageId = value;
				OnPropertyChanged("PageId");
			}
		}
		public string PageAccessToken
		{
			get { return _PageAccessToken; }
			set 
			{ 
				_PageAccessToken = value;
				OnPropertyChanged("PageAccessToken");
			}
		}
		public string UserAccessToken
		{
			get { return _UserAccessToken; }
			set 
			{ 
				_UserAccessToken = value;
				OnPropertyChanged("UserAccessToken");
			}
		}
		public string State
		{
			get { return _State; }
			set 
			{ 
				_State = value;
				OnPropertyChanged("State");
			}
		}
		public string Permissions
		{
			get { return _Permissions; }
			set 
			{ 
				_Permissions = value;
				OnPropertyChanged("Permissions");
			}
		}
		public int ReRequestPermissions
		{
			get { return _ReRequestPermissions; }
			set 
			{ 
				_ReRequestPermissions = value;
				OnPropertyChanged("ReRequestPermissions");
			}
		}
		#endregion

		#region CTor
		public FacebookDistributionProfile()
		{
		}

		public FacebookDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "apiAuthorizeUrl":
						this._ApiAuthorizeUrl = propertyNode.InnerText;
						continue;
					case "pageId":
						this._PageId = propertyNode.InnerText;
						continue;
					case "pageAccessToken":
						this._PageAccessToken = propertyNode.InnerText;
						continue;
					case "userAccessToken":
						this._UserAccessToken = propertyNode.InnerText;
						continue;
					case "state":
						this._State = propertyNode.InnerText;
						continue;
					case "permissions":
						this._Permissions = propertyNode.InnerText;
						continue;
					case "reRequestPermissions":
						this._ReRequestPermissions = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaFacebookDistributionProfile");
			kparams.AddIfNotNull("apiAuthorizeUrl", this._ApiAuthorizeUrl);
			kparams.AddIfNotNull("pageId", this._PageId);
			kparams.AddIfNotNull("pageAccessToken", this._PageAccessToken);
			kparams.AddIfNotNull("userAccessToken", this._UserAccessToken);
			kparams.AddIfNotNull("state", this._State);
			kparams.AddIfNotNull("permissions", this._Permissions);
			kparams.AddIfNotNull("reRequestPermissions", this._ReRequestPermissions);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case API_AUTHORIZE_URL:
					return "ApiAuthorizeUrl";
				case PAGE_ID:
					return "PageId";
				case PAGE_ACCESS_TOKEN:
					return "PageAccessToken";
				case USER_ACCESS_TOKEN:
					return "UserAccessToken";
				case STATE:
					return "State";
				case PERMISSIONS:
					return "Permissions";
				case RE_REQUEST_PERMISSIONS:
					return "ReRequestPermissions";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

