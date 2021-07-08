// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
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
	public class UserEntryBaseFilter : RelatedFilter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string ID_NOT_IN = "idNotIn";
		public const string ENTRY_ID_EQUAL = "entryIdEqual";
		public const string ENTRY_ID_IN = "entryIdIn";
		public const string ENTRY_ID_NOT_IN = "entryIdNotIn";
		public const string USER_ID_EQUAL = "userIdEqual";
		public const string USER_ID_IN = "userIdIn";
		public const string USER_ID_NOT_IN = "userIdNotIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string TYPE_EQUAL = "typeEqual";
		public const string EXTENDED_STATUS_EQUAL = "extendedStatusEqual";
		public const string EXTENDED_STATUS_IN = "extendedStatusIn";
		public const string EXTENDED_STATUS_NOT_IN = "extendedStatusNotIn";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private string _EntryIdNotIn = null;
		private string _UserIdEqual = null;
		private string _UserIdIn = null;
		private string _UserIdNotIn = null;
		private UserEntryStatus _StatusEqual = null;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private UserEntryType _TypeEqual = null;
		private UserEntryExtendedStatus _ExtendedStatusEqual = null;
		private string _ExtendedStatusIn = null;
		private string _ExtendedStatusNotIn = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		/// <summary>
		/// Use IdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		/// <summary>
		/// Use IdNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IdNotIn
		{
			get { return _IdNotIn; }
			set 
			{ 
				_IdNotIn = value;
				OnPropertyChanged("IdNotIn");
			}
		}
		/// <summary>
		/// Use EntryIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		/// <summary>
		/// Use EntryIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIdIn
		{
			get { return _EntryIdIn; }
			set 
			{ 
				_EntryIdIn = value;
				OnPropertyChanged("EntryIdIn");
			}
		}
		/// <summary>
		/// Use EntryIdNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIdNotIn
		{
			get { return _EntryIdNotIn; }
			set 
			{ 
				_EntryIdNotIn = value;
				OnPropertyChanged("EntryIdNotIn");
			}
		}
		/// <summary>
		/// Use UserIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		/// <summary>
		/// Use UserIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		/// <summary>
		/// Use UserIdNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserIdNotIn
		{
			get { return _UserIdNotIn; }
			set 
			{ 
				_UserIdNotIn = value;
				OnPropertyChanged("UserIdNotIn");
			}
		}
		/// <summary>
		/// Use StatusEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UserEntryStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		/// <summary>
		/// Use CreatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use CreatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use UpdatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use UpdatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use TypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UserEntryType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		/// <summary>
		/// Use ExtendedStatusEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UserEntryExtendedStatus ExtendedStatusEqual
		{
			get { return _ExtendedStatusEqual; }
			set 
			{ 
				_ExtendedStatusEqual = value;
				OnPropertyChanged("ExtendedStatusEqual");
			}
		}
		/// <summary>
		/// Use ExtendedStatusInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExtendedStatusIn
		{
			get { return _ExtendedStatusIn; }
			set 
			{ 
				_ExtendedStatusIn = value;
				OnPropertyChanged("ExtendedStatusIn");
			}
		}
		/// <summary>
		/// Use ExtendedStatusNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExtendedStatusNotIn
		{
			get { return _ExtendedStatusNotIn; }
			set 
			{ 
				_ExtendedStatusNotIn = value;
				OnPropertyChanged("ExtendedStatusNotIn");
			}
		}
		#endregion

		#region CTor
		public UserEntryBaseFilter()
		{
		}

		public UserEntryBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseInt(node["idEqual"].Value<string>());
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["idNotIn"] != null)
			{
				this._IdNotIn = node["idNotIn"].Value<string>();
			}
			if(node["entryIdEqual"] != null)
			{
				this._EntryIdEqual = node["entryIdEqual"].Value<string>();
			}
			if(node["entryIdIn"] != null)
			{
				this._EntryIdIn = node["entryIdIn"].Value<string>();
			}
			if(node["entryIdNotIn"] != null)
			{
				this._EntryIdNotIn = node["entryIdNotIn"].Value<string>();
			}
			if(node["userIdEqual"] != null)
			{
				this._UserIdEqual = node["userIdEqual"].Value<string>();
			}
			if(node["userIdIn"] != null)
			{
				this._UserIdIn = node["userIdIn"].Value<string>();
			}
			if(node["userIdNotIn"] != null)
			{
				this._UserIdNotIn = node["userIdNotIn"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (UserEntryStatus)StringEnum.Parse(typeof(UserEntryStatus), node["statusEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["typeEqual"] != null)
			{
				this._TypeEqual = (UserEntryType)StringEnum.Parse(typeof(UserEntryType), node["typeEqual"].Value<string>());
			}
			if(node["extendedStatusEqual"] != null)
			{
				this._ExtendedStatusEqual = (UserEntryExtendedStatus)StringEnum.Parse(typeof(UserEntryExtendedStatus), node["extendedStatusEqual"].Value<string>());
			}
			if(node["extendedStatusIn"] != null)
			{
				this._ExtendedStatusIn = node["extendedStatusIn"].Value<string>();
			}
			if(node["extendedStatusNotIn"] != null)
			{
				this._ExtendedStatusNotIn = node["extendedStatusNotIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUserEntryBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("idNotIn", this._IdNotIn);
			kparams.AddIfNotNull("entryIdEqual", this._EntryIdEqual);
			kparams.AddIfNotNull("entryIdIn", this._EntryIdIn);
			kparams.AddIfNotNull("entryIdNotIn", this._EntryIdNotIn);
			kparams.AddIfNotNull("userIdEqual", this._UserIdEqual);
			kparams.AddIfNotNull("userIdIn", this._UserIdIn);
			kparams.AddIfNotNull("userIdNotIn", this._UserIdNotIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("typeEqual", this._TypeEqual);
			kparams.AddIfNotNull("extendedStatusEqual", this._ExtendedStatusEqual);
			kparams.AddIfNotNull("extendedStatusIn", this._ExtendedStatusIn);
			kparams.AddIfNotNull("extendedStatusNotIn", this._ExtendedStatusNotIn);
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
				case ID_NOT_IN:
					return "IdNotIn";
				case ENTRY_ID_EQUAL:
					return "EntryIdEqual";
				case ENTRY_ID_IN:
					return "EntryIdIn";
				case ENTRY_ID_NOT_IN:
					return "EntryIdNotIn";
				case USER_ID_EQUAL:
					return "UserIdEqual";
				case USER_ID_IN:
					return "UserIdIn";
				case USER_ID_NOT_IN:
					return "UserIdNotIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case TYPE_EQUAL:
					return "TypeEqual";
				case EXTENDED_STATUS_EQUAL:
					return "ExtendedStatusEqual";
				case EXTENDED_STATUS_IN:
					return "ExtendedStatusIn";
				case EXTENDED_STATUS_NOT_IN:
					return "ExtendedStatusNotIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

