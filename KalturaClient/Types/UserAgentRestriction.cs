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
	public class UserAgentRestriction : BaseRestriction
	{
		#region Constants
		public const string USER_AGENT_RESTRICTION_TYPE = "userAgentRestrictionType";
		public const string USER_AGENT_REGEX_LIST = "userAgentRegexList";
		#endregion

		#region Private Fields
		private UserAgentRestrictionType _UserAgentRestrictionType = (UserAgentRestrictionType)Int32.MinValue;
		private string _UserAgentRegexList = null;
		#endregion

		#region Properties
		public UserAgentRestrictionType UserAgentRestrictionType
		{
			get { return _UserAgentRestrictionType; }
			set 
			{ 
				_UserAgentRestrictionType = value;
				OnPropertyChanged("UserAgentRestrictionType");
			}
		}
		public string UserAgentRegexList
		{
			get { return _UserAgentRegexList; }
			set 
			{ 
				_UserAgentRegexList = value;
				OnPropertyChanged("UserAgentRegexList");
			}
		}
		#endregion

		#region CTor
		public UserAgentRestriction()
		{
		}

		public UserAgentRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "userAgentRestrictionType":
						this._UserAgentRestrictionType = (UserAgentRestrictionType)ParseEnum(typeof(UserAgentRestrictionType), propertyNode.InnerText);
						continue;
					case "userAgentRegexList":
						this._UserAgentRegexList = propertyNode.InnerText;
						continue;
				}
			}
		}

		public UserAgentRestriction(IDictionary<string,object> data) : base(data)
		{
			    this._UserAgentRestrictionType = (UserAgentRestrictionType)ParseEnum(typeof(UserAgentRestrictionType), data.TryGetValueSafe<int>("userAgentRestrictionType"));
			    this._UserAgentRegexList = data.TryGetValueSafe<string>("userAgentRegexList");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUserAgentRestriction");
			kparams.AddIfNotNull("userAgentRestrictionType", this._UserAgentRestrictionType);
			kparams.AddIfNotNull("userAgentRegexList", this._UserAgentRegexList);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_AGENT_RESTRICTION_TYPE:
					return "UserAgentRestrictionType";
				case USER_AGENT_REGEX_LIST:
					return "UserAgentRegexList";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

