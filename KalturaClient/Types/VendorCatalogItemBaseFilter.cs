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
	public class VendorCatalogItemBaseFilter : RelatedFilter
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
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string SERVICE_TYPE_EQUAL = "serviceTypeEqual";
		public const string SERVICE_TYPE_IN = "serviceTypeIn";
		public const string SERVICE_FEATURE_EQUAL = "serviceFeatureEqual";
		public const string SERVICE_FEATURE_IN = "serviceFeatureIn";
		public const string TURN_AROUND_TIME_EQUAL = "turnAroundTimeEqual";
		public const string TURN_AROUND_TIME_IN = "turnAroundTimeIn";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private int _VendorPartnerIdEqual = Int32.MinValue;
		private string _VendorPartnerIdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private VendorCatalogItemStatus _StatusEqual = (VendorCatalogItemStatus)Int32.MinValue;
		private string _StatusIn = null;
		private VendorServiceType _ServiceTypeEqual = (VendorServiceType)Int32.MinValue;
		private string _ServiceTypeIn = null;
		private VendorServiceFeature _ServiceFeatureEqual = (VendorServiceFeature)Int32.MinValue;
		private string _ServiceFeatureIn = null;
		private VendorServiceTurnAroundTime _TurnAroundTimeEqual = (VendorServiceTurnAroundTime)Int32.MinValue;
		private string _TurnAroundTimeIn = null;
		#endregion

		#region Properties
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
		public VendorCatalogItemStatus StatusEqual
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
		public VendorServiceType ServiceTypeEqual
		{
			get { return _ServiceTypeEqual; }
			set 
			{ 
				_ServiceTypeEqual = value;
				OnPropertyChanged("ServiceTypeEqual");
			}
		}
		[JsonProperty]
		public string ServiceTypeIn
		{
			get { return _ServiceTypeIn; }
			set 
			{ 
				_ServiceTypeIn = value;
				OnPropertyChanged("ServiceTypeIn");
			}
		}
		[JsonProperty]
		public VendorServiceFeature ServiceFeatureEqual
		{
			get { return _ServiceFeatureEqual; }
			set 
			{ 
				_ServiceFeatureEqual = value;
				OnPropertyChanged("ServiceFeatureEqual");
			}
		}
		[JsonProperty]
		public string ServiceFeatureIn
		{
			get { return _ServiceFeatureIn; }
			set 
			{ 
				_ServiceFeatureIn = value;
				OnPropertyChanged("ServiceFeatureIn");
			}
		}
		[JsonProperty]
		public VendorServiceTurnAroundTime TurnAroundTimeEqual
		{
			get { return _TurnAroundTimeEqual; }
			set 
			{ 
				_TurnAroundTimeEqual = value;
				OnPropertyChanged("TurnAroundTimeEqual");
			}
		}
		[JsonProperty]
		public string TurnAroundTimeIn
		{
			get { return _TurnAroundTimeIn; }
			set 
			{ 
				_TurnAroundTimeIn = value;
				OnPropertyChanged("TurnAroundTimeIn");
			}
		}
		#endregion

		#region CTor
		public VendorCatalogItemBaseFilter()
		{
		}

		public VendorCatalogItemBaseFilter(JToken node) : base(node)
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
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (VendorCatalogItemStatus)ParseEnum(typeof(VendorCatalogItemStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["serviceTypeEqual"] != null)
			{
				this._ServiceTypeEqual = (VendorServiceType)ParseEnum(typeof(VendorServiceType), node["serviceTypeEqual"].Value<string>());
			}
			if(node["serviceTypeIn"] != null)
			{
				this._ServiceTypeIn = node["serviceTypeIn"].Value<string>();
			}
			if(node["serviceFeatureEqual"] != null)
			{
				this._ServiceFeatureEqual = (VendorServiceFeature)ParseEnum(typeof(VendorServiceFeature), node["serviceFeatureEqual"].Value<string>());
			}
			if(node["serviceFeatureIn"] != null)
			{
				this._ServiceFeatureIn = node["serviceFeatureIn"].Value<string>();
			}
			if(node["turnAroundTimeEqual"] != null)
			{
				this._TurnAroundTimeEqual = (VendorServiceTurnAroundTime)ParseEnum(typeof(VendorServiceTurnAroundTime), node["turnAroundTimeEqual"].Value<string>());
			}
			if(node["turnAroundTimeIn"] != null)
			{
				this._TurnAroundTimeIn = node["turnAroundTimeIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVendorCatalogItemBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("idNotIn", this._IdNotIn);
			kparams.AddIfNotNull("vendorPartnerIdEqual", this._VendorPartnerIdEqual);
			kparams.AddIfNotNull("vendorPartnerIdIn", this._VendorPartnerIdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("serviceTypeEqual", this._ServiceTypeEqual);
			kparams.AddIfNotNull("serviceTypeIn", this._ServiceTypeIn);
			kparams.AddIfNotNull("serviceFeatureEqual", this._ServiceFeatureEqual);
			kparams.AddIfNotNull("serviceFeatureIn", this._ServiceFeatureIn);
			kparams.AddIfNotNull("turnAroundTimeEqual", this._TurnAroundTimeEqual);
			kparams.AddIfNotNull("turnAroundTimeIn", this._TurnAroundTimeIn);
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
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case SERVICE_TYPE_EQUAL:
					return "ServiceTypeEqual";
				case SERVICE_TYPE_IN:
					return "ServiceTypeIn";
				case SERVICE_FEATURE_EQUAL:
					return "ServiceFeatureEqual";
				case SERVICE_FEATURE_IN:
					return "ServiceFeatureIn";
				case TURN_AROUND_TIME_EQUAL:
					return "TurnAroundTimeEqual";
				case TURN_AROUND_TIME_IN:
					return "TurnAroundTimeIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

