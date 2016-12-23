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
	public class SearchAuthData : ObjectBase
	{
		#region Constants
		public const string AUTH_DATA = "authData";
		public const string LOGIN_URL = "loginUrl";
		public const string MESSAGE = "message";
		#endregion

		#region Private Fields
		private string _AuthData = null;
		private string _LoginUrl = null;
		private string _Message = null;
		#endregion

		#region Properties
		public string AuthData
		{
			get { return _AuthData; }
			set 
			{ 
				_AuthData = value;
				OnPropertyChanged("AuthData");
			}
		}
		public string LoginUrl
		{
			get { return _LoginUrl; }
			set 
			{ 
				_LoginUrl = value;
				OnPropertyChanged("LoginUrl");
			}
		}
		public string Message
		{
			get { return _Message; }
			set 
			{ 
				_Message = value;
				OnPropertyChanged("Message");
			}
		}
		#endregion

		#region CTor
		public SearchAuthData()
		{
		}

		public SearchAuthData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "authData":
						this._AuthData = propertyNode.InnerText;
						continue;
					case "loginUrl":
						this._LoginUrl = propertyNode.InnerText;
						continue;
					case "message":
						this._Message = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaSearchAuthData");
			kparams.AddIfNotNull("authData", this._AuthData);
			kparams.AddIfNotNull("loginUrl", this._LoginUrl);
			kparams.AddIfNotNull("message", this._Message);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case AUTH_DATA:
					return "AuthData";
				case LOGIN_URL:
					return "LoginUrl";
				case MESSAGE:
					return "Message";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

