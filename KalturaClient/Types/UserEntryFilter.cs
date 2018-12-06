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
	public class UserEntryFilter : UserEntryBaseFilter
	{
		#region Constants
		public const string USER_ID_EQUAL_CURRENT = "userIdEqualCurrent";
		public const string IS_ANONYMOUS = "isAnonymous";
		public const string PRIVACY_CONTEXT_EQUAL = "privacyContextEqual";
		public const string PRIVACY_CONTEXT_IN = "privacyContextIn";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private NullableBoolean _UserIdEqualCurrent = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _IsAnonymous = (NullableBoolean)Int32.MinValue;
		private string _PrivacyContextEqual = null;
		private string _PrivacyContextIn = null;
		private UserEntryOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public NullableBoolean UserIdEqualCurrent
		{
			get { return _UserIdEqualCurrent; }
			set 
			{ 
				_UserIdEqualCurrent = value;
				OnPropertyChanged("UserIdEqualCurrent");
			}
		}
		public NullableBoolean IsAnonymous
		{
			get { return _IsAnonymous; }
			set 
			{ 
				_IsAnonymous = value;
				OnPropertyChanged("IsAnonymous");
			}
		}
		public string PrivacyContextEqual
		{
			get { return _PrivacyContextEqual; }
			set 
			{ 
				_PrivacyContextEqual = value;
				OnPropertyChanged("PrivacyContextEqual");
			}
		}
		public string PrivacyContextIn
		{
			get { return _PrivacyContextIn; }
			set 
			{ 
				_PrivacyContextIn = value;
				OnPropertyChanged("PrivacyContextIn");
			}
		}
		public new UserEntryOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public UserEntryFilter()
		{
		}

		public UserEntryFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "userIdEqualCurrent":
						this._UserIdEqualCurrent = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "isAnonymous":
						this._IsAnonymous = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "privacyContextEqual":
						this._PrivacyContextEqual = propertyNode.InnerText;
						continue;
					case "privacyContextIn":
						this._PrivacyContextIn = propertyNode.InnerText;
						continue;
					case "orderBy":
						this._OrderBy = (UserEntryOrderBy)StringEnum.Parse(typeof(UserEntryOrderBy), propertyNode.InnerText);
						continue;
				}
			}
		}

		public UserEntryFilter(IDictionary<string,object> data) : base(data)
		{
			    this._UserIdEqualCurrent = (NullableBoolean)ParseEnum(typeof(NullableBoolean), data.TryGetValueSafe<int>("userIdEqualCurrent"));
			    this._IsAnonymous = (NullableBoolean)ParseEnum(typeof(NullableBoolean), data.TryGetValueSafe<int>("isAnonymous"));
			    this._PrivacyContextEqual = data.TryGetValueSafe<string>("privacyContextEqual");
			    this._PrivacyContextIn = data.TryGetValueSafe<string>("privacyContextIn");
			    this._OrderBy = (UserEntryOrderBy)StringEnum.Parse(typeof(UserEntryOrderBy), data.TryGetValueSafe<string>("orderBy"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUserEntryFilter");
			kparams.AddIfNotNull("userIdEqualCurrent", this._UserIdEqualCurrent);
			kparams.AddIfNotNull("isAnonymous", this._IsAnonymous);
			kparams.AddIfNotNull("privacyContextEqual", this._PrivacyContextEqual);
			kparams.AddIfNotNull("privacyContextIn", this._PrivacyContextIn);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_ID_EQUAL_CURRENT:
					return "UserIdEqualCurrent";
				case IS_ANONYMOUS:
					return "IsAnonymous";
				case PRIVACY_CONTEXT_EQUAL:
					return "PrivacyContextEqual";
				case PRIVACY_CONTEXT_IN:
					return "PrivacyContextIn";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

