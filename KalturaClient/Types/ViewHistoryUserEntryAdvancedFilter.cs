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
	public class ViewHistoryUserEntryAdvancedFilter : SearchItem
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string USER_ID_EQUAL = "userIdEqual";
		public const string USER_ID_IN = "userIdIn";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string EXTENDED_STATUS_EQUAL = "extendedStatusEqual";
		public const string EXTENDED_STATUS_IN = "extendedStatusIn";
		#endregion

		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private string _UserIdEqual = null;
		private string _UserIdIn = null;
		private string _UpdatedAtGreaterThanOrEqual = null;
		private string _UpdatedAtLessThanOrEqual = null;
		private UserEntryExtendedStatus _ExtendedStatusEqual = null;
		private string _ExtendedStatusIn = null;
		#endregion

		#region Properties
		public string IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		public string UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public string UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public UserEntryExtendedStatus ExtendedStatusEqual
		{
			get { return _ExtendedStatusEqual; }
			set 
			{ 
				_ExtendedStatusEqual = value;
				OnPropertyChanged("ExtendedStatusEqual");
			}
		}
		public string ExtendedStatusIn
		{
			get { return _ExtendedStatusIn; }
			set 
			{ 
				_ExtendedStatusIn = value;
				OnPropertyChanged("ExtendedStatusIn");
			}
		}
		#endregion

		#region CTor
		public ViewHistoryUserEntryAdvancedFilter()
		{
		}

		public ViewHistoryUserEntryAdvancedFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = propertyNode.InnerText;
						continue;
					case "idIn":
						this._IdIn = propertyNode.InnerText;
						continue;
					case "userIdEqual":
						this._UserIdEqual = propertyNode.InnerText;
						continue;
					case "userIdIn":
						this._UserIdIn = propertyNode.InnerText;
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = propertyNode.InnerText;
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = propertyNode.InnerText;
						continue;
					case "extendedStatusEqual":
						this._ExtendedStatusEqual = (UserEntryExtendedStatus)StringEnum.Parse(typeof(UserEntryExtendedStatus), propertyNode.InnerText);
						continue;
					case "extendedStatusIn":
						this._ExtendedStatusIn = propertyNode.InnerText;
						continue;
				}
			}
		}

		public ViewHistoryUserEntryAdvancedFilter(IDictionary<string,object> data) : base(data)
		{
			    this._IdEqual = data.TryGetValueSafe<string>("idEqual");
			    this._IdIn = data.TryGetValueSafe<string>("idIn");
			    this._UserIdEqual = data.TryGetValueSafe<string>("userIdEqual");
			    this._UserIdIn = data.TryGetValueSafe<string>("userIdIn");
			    this._UpdatedAtGreaterThanOrEqual = data.TryGetValueSafe<string>("updatedAtGreaterThanOrEqual");
			    this._UpdatedAtLessThanOrEqual = data.TryGetValueSafe<string>("updatedAtLessThanOrEqual");
			    this._ExtendedStatusEqual = (UserEntryExtendedStatus)StringEnum.Parse(typeof(UserEntryExtendedStatus), data.TryGetValueSafe<string>("extendedStatusEqual"));
			    this._ExtendedStatusIn = data.TryGetValueSafe<string>("extendedStatusIn");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaViewHistoryUserEntryAdvancedFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("userIdEqual", this._UserIdEqual);
			kparams.AddIfNotNull("userIdIn", this._UserIdIn);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("extendedStatusEqual", this._ExtendedStatusEqual);
			kparams.AddIfNotNull("extendedStatusIn", this._ExtendedStatusIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case ID_IN:
					return "IdIn";
				case USER_ID_EQUAL:
					return "UserIdEqual";
				case USER_ID_IN:
					return "UserIdIn";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case EXTENDED_STATUS_EQUAL:
					return "ExtendedStatusEqual";
				case EXTENDED_STATUS_IN:
					return "ExtendedStatusIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

