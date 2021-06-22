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
	public class EntryVendorTaskBaseFilter : RelatedFilter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string ID_NOT_IN = "idNotIn";
		public const string VENDOR_PARTNER_ID_EQUAL = "vendorPartnerIdEqual";
		public const string VENDOR_PARTNER_ID_IN = "vendorPartnerIdIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string QUEUE_TIME_GREATER_THAN_OR_EQUAL = "queueTimeGreaterThanOrEqual";
		public const string QUEUE_TIME_LESS_THAN_OR_EQUAL = "queueTimeLessThanOrEqual";
		public const string FINISH_TIME_GREATER_THAN_OR_EQUAL = "finishTimeGreaterThanOrEqual";
		public const string FINISH_TIME_LESS_THAN_OR_EQUAL = "finishTimeLessThanOrEqual";
		public const string ENTRY_ID_EQUAL = "entryIdEqual";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string REACH_PROFILE_ID_EQUAL = "reachProfileIdEqual";
		public const string REACH_PROFILE_ID_IN = "reachProfileIdIn";
		public const string CATALOG_ITEM_ID_EQUAL = "catalogItemIdEqual";
		public const string CATALOG_ITEM_ID_IN = "catalogItemIdIn";
		public const string USER_ID_EQUAL = "userIdEqual";
		public const string CONTEXT_EQUAL = "contextEqual";
		public const string EXPECTED_FINISH_TIME_GREATER_THAN_OR_EQUAL = "expectedFinishTimeGreaterThanOrEqual";
		public const string EXPECTED_FINISH_TIME_LESS_THAN_OR_EQUAL = "expectedFinishTimeLessThanOrEqual";
		#endregion

		#region Private Fields
		private long _IdEqual = long.MinValue;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private int _VendorPartnerIdEqual = Int32.MinValue;
		private string _VendorPartnerIdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _QueueTimeGreaterThanOrEqual = Int32.MinValue;
		private int _QueueTimeLessThanOrEqual = Int32.MinValue;
		private int _FinishTimeGreaterThanOrEqual = Int32.MinValue;
		private int _FinishTimeLessThanOrEqual = Int32.MinValue;
		private string _EntryIdEqual = null;
		private EntryVendorTaskStatus _StatusEqual = (EntryVendorTaskStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _ReachProfileIdEqual = Int32.MinValue;
		private string _ReachProfileIdIn = null;
		private int _CatalogItemIdEqual = Int32.MinValue;
		private string _CatalogItemIdIn = null;
		private string _UserIdEqual = null;
		private string _ContextEqual = null;
		private int _ExpectedFinishTimeGreaterThanOrEqual = Int32.MinValue;
		private int _ExpectedFinishTimeLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public long IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
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
		[JsonProperty]
		public int VendorPartnerIdEqual
		{
			get { return _VendorPartnerIdEqual; }
			set 
			{ 
				_VendorPartnerIdEqual = value;
				OnPropertyChanged("VendorPartnerIdEqual");
			}
		}
		[JsonProperty]
		public string VendorPartnerIdIn
		{
			get { return _VendorPartnerIdIn; }
			set 
			{ 
				_VendorPartnerIdIn = value;
				OnPropertyChanged("VendorPartnerIdIn");
			}
		}
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
		[JsonProperty]
		public int QueueTimeGreaterThanOrEqual
		{
			get { return _QueueTimeGreaterThanOrEqual; }
			set 
			{ 
				_QueueTimeGreaterThanOrEqual = value;
				OnPropertyChanged("QueueTimeGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int QueueTimeLessThanOrEqual
		{
			get { return _QueueTimeLessThanOrEqual; }
			set 
			{ 
				_QueueTimeLessThanOrEqual = value;
				OnPropertyChanged("QueueTimeLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int FinishTimeGreaterThanOrEqual
		{
			get { return _FinishTimeGreaterThanOrEqual; }
			set 
			{ 
				_FinishTimeGreaterThanOrEqual = value;
				OnPropertyChanged("FinishTimeGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int FinishTimeLessThanOrEqual
		{
			get { return _FinishTimeLessThanOrEqual; }
			set 
			{ 
				_FinishTimeLessThanOrEqual = value;
				OnPropertyChanged("FinishTimeLessThanOrEqual");
			}
		}
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
		[JsonProperty]
		public EntryVendorTaskStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		[JsonProperty]
		public int ReachProfileIdEqual
		{
			get { return _ReachProfileIdEqual; }
			set 
			{ 
				_ReachProfileIdEqual = value;
				OnPropertyChanged("ReachProfileIdEqual");
			}
		}
		[JsonProperty]
		public string ReachProfileIdIn
		{
			get { return _ReachProfileIdIn; }
			set 
			{ 
				_ReachProfileIdIn = value;
				OnPropertyChanged("ReachProfileIdIn");
			}
		}
		[JsonProperty]
		public int CatalogItemIdEqual
		{
			get { return _CatalogItemIdEqual; }
			set 
			{ 
				_CatalogItemIdEqual = value;
				OnPropertyChanged("CatalogItemIdEqual");
			}
		}
		[JsonProperty]
		public string CatalogItemIdIn
		{
			get { return _CatalogItemIdIn; }
			set 
			{ 
				_CatalogItemIdIn = value;
				OnPropertyChanged("CatalogItemIdIn");
			}
		}
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
		[JsonProperty]
		public string ContextEqual
		{
			get { return _ContextEqual; }
			set 
			{ 
				_ContextEqual = value;
				OnPropertyChanged("ContextEqual");
			}
		}
		[JsonProperty]
		public int ExpectedFinishTimeGreaterThanOrEqual
		{
			get { return _ExpectedFinishTimeGreaterThanOrEqual; }
			set 
			{ 
				_ExpectedFinishTimeGreaterThanOrEqual = value;
				OnPropertyChanged("ExpectedFinishTimeGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int ExpectedFinishTimeLessThanOrEqual
		{
			get { return _ExpectedFinishTimeLessThanOrEqual; }
			set 
			{ 
				_ExpectedFinishTimeLessThanOrEqual = value;
				OnPropertyChanged("ExpectedFinishTimeLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public EntryVendorTaskBaseFilter()
		{
		}

		public EntryVendorTaskBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseLong(node["idEqual"].Value<string>());
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["idNotIn"] != null)
			{
				this._IdNotIn = node["idNotIn"].Value<string>();
			}
			if(node["vendorPartnerIdEqual"] != null)
			{
				this._VendorPartnerIdEqual = ParseInt(node["vendorPartnerIdEqual"].Value<string>());
			}
			if(node["vendorPartnerIdIn"] != null)
			{
				this._VendorPartnerIdIn = node["vendorPartnerIdIn"].Value<string>();
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["queueTimeGreaterThanOrEqual"] != null)
			{
				this._QueueTimeGreaterThanOrEqual = ParseInt(node["queueTimeGreaterThanOrEqual"].Value<string>());
			}
			if(node["queueTimeLessThanOrEqual"] != null)
			{
				this._QueueTimeLessThanOrEqual = ParseInt(node["queueTimeLessThanOrEqual"].Value<string>());
			}
			if(node["finishTimeGreaterThanOrEqual"] != null)
			{
				this._FinishTimeGreaterThanOrEqual = ParseInt(node["finishTimeGreaterThanOrEqual"].Value<string>());
			}
			if(node["finishTimeLessThanOrEqual"] != null)
			{
				this._FinishTimeLessThanOrEqual = ParseInt(node["finishTimeLessThanOrEqual"].Value<string>());
			}
			if(node["entryIdEqual"] != null)
			{
				this._EntryIdEqual = node["entryIdEqual"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (EntryVendorTaskStatus)ParseEnum(typeof(EntryVendorTaskStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["reachProfileIdEqual"] != null)
			{
				this._ReachProfileIdEqual = ParseInt(node["reachProfileIdEqual"].Value<string>());
			}
			if(node["reachProfileIdIn"] != null)
			{
				this._ReachProfileIdIn = node["reachProfileIdIn"].Value<string>();
			}
			if(node["catalogItemIdEqual"] != null)
			{
				this._CatalogItemIdEqual = ParseInt(node["catalogItemIdEqual"].Value<string>());
			}
			if(node["catalogItemIdIn"] != null)
			{
				this._CatalogItemIdIn = node["catalogItemIdIn"].Value<string>();
			}
			if(node["userIdEqual"] != null)
			{
				this._UserIdEqual = node["userIdEqual"].Value<string>();
			}
			if(node["contextEqual"] != null)
			{
				this._ContextEqual = node["contextEqual"].Value<string>();
			}
			if(node["expectedFinishTimeGreaterThanOrEqual"] != null)
			{
				this._ExpectedFinishTimeGreaterThanOrEqual = ParseInt(node["expectedFinishTimeGreaterThanOrEqual"].Value<string>());
			}
			if(node["expectedFinishTimeLessThanOrEqual"] != null)
			{
				this._ExpectedFinishTimeLessThanOrEqual = ParseInt(node["expectedFinishTimeLessThanOrEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryVendorTaskBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("idNotIn", this._IdNotIn);
			kparams.AddIfNotNull("vendorPartnerIdEqual", this._VendorPartnerIdEqual);
			kparams.AddIfNotNull("vendorPartnerIdIn", this._VendorPartnerIdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("queueTimeGreaterThanOrEqual", this._QueueTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("queueTimeLessThanOrEqual", this._QueueTimeLessThanOrEqual);
			kparams.AddIfNotNull("finishTimeGreaterThanOrEqual", this._FinishTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("finishTimeLessThanOrEqual", this._FinishTimeLessThanOrEqual);
			kparams.AddIfNotNull("entryIdEqual", this._EntryIdEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("reachProfileIdEqual", this._ReachProfileIdEqual);
			kparams.AddIfNotNull("reachProfileIdIn", this._ReachProfileIdIn);
			kparams.AddIfNotNull("catalogItemIdEqual", this._CatalogItemIdEqual);
			kparams.AddIfNotNull("catalogItemIdIn", this._CatalogItemIdIn);
			kparams.AddIfNotNull("userIdEqual", this._UserIdEqual);
			kparams.AddIfNotNull("contextEqual", this._ContextEqual);
			kparams.AddIfNotNull("expectedFinishTimeGreaterThanOrEqual", this._ExpectedFinishTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("expectedFinishTimeLessThanOrEqual", this._ExpectedFinishTimeLessThanOrEqual);
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
				case VENDOR_PARTNER_ID_EQUAL:
					return "VendorPartnerIdEqual";
				case VENDOR_PARTNER_ID_IN:
					return "VendorPartnerIdIn";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case QUEUE_TIME_GREATER_THAN_OR_EQUAL:
					return "QueueTimeGreaterThanOrEqual";
				case QUEUE_TIME_LESS_THAN_OR_EQUAL:
					return "QueueTimeLessThanOrEqual";
				case FINISH_TIME_GREATER_THAN_OR_EQUAL:
					return "FinishTimeGreaterThanOrEqual";
				case FINISH_TIME_LESS_THAN_OR_EQUAL:
					return "FinishTimeLessThanOrEqual";
				case ENTRY_ID_EQUAL:
					return "EntryIdEqual";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case REACH_PROFILE_ID_EQUAL:
					return "ReachProfileIdEqual";
				case REACH_PROFILE_ID_IN:
					return "ReachProfileIdIn";
				case CATALOG_ITEM_ID_EQUAL:
					return "CatalogItemIdEqual";
				case CATALOG_ITEM_ID_IN:
					return "CatalogItemIdIn";
				case USER_ID_EQUAL:
					return "UserIdEqual";
				case CONTEXT_EQUAL:
					return "ContextEqual";
				case EXPECTED_FINISH_TIME_GREATER_THAN_OR_EQUAL:
					return "ExpectedFinishTimeGreaterThanOrEqual";
				case EXPECTED_FINISH_TIME_LESS_THAN_OR_EQUAL:
					return "ExpectedFinishTimeLessThanOrEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

