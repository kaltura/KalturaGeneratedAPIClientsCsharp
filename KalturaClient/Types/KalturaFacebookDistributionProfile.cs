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

namespace Kaltura
{
	public class KalturaFacebookDistributionProfile : KalturaConfigurableDistributionProfile
	{
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
		public KalturaFacebookDistributionProfile()
		{
		}

		public KalturaFacebookDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "apiAuthorizeUrl":
						this._ApiAuthorizeUrl = txt;
						continue;
					case "pageId":
						this._PageId = txt;
						continue;
					case "pageAccessToken":
						this._PageAccessToken = txt;
						continue;
					case "userAccessToken":
						this._UserAccessToken = txt;
						continue;
					case "state":
						this._State = txt;
						continue;
					case "permissions":
						this._Permissions = txt;
						continue;
					case "reRequestPermissions":
						this._ReRequestPermissions = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

