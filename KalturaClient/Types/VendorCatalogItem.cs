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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class VendorCatalogItem : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string VENDOR_PARTNER_ID = "vendorPartnerId";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string STATUS = "status";
		public const string SERVICE_TYPE = "serviceType";
		public const string SERVICE_FEATURE = "serviceFeature";
		public const string TURN_AROUND_TIME = "turnAroundTime";
		public const string PRICING = "pricing";
		public const string ENGINE_TYPE = "engineType";
		public const string SOURCE_LANGUAGE = "sourceLanguage";
		public const string ALLOW_RESUBMISSION = "allowResubmission";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _VendorPartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private VendorCatalogItemStatus _Status = (VendorCatalogItemStatus)Int32.MinValue;
		private VendorServiceType _ServiceType = (VendorServiceType)Int32.MinValue;
		private VendorServiceFeature _ServiceFeature = (VendorServiceFeature)Int32.MinValue;
		private VendorServiceTurnAroundTime _TurnAroundTime = (VendorServiceTurnAroundTime)Int32.MinValue;
		private VendorCatalogItemPricing _Pricing;
		private ReachVendorEngineType _EngineType = null;
		private CatalogItemLanguage _SourceLanguage = null;
		private bool? _AllowResubmission = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use VendorPartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VendorPartnerId
		{
			get { return _VendorPartnerId; }
			set 
			{ 
				_VendorPartnerId = value;
				OnPropertyChanged("VendorPartnerId");
			}
		}
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		/// <summary>
		/// Use SystemNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		/// <summary>
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorCatalogItemStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use ServiceTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorServiceType ServiceType
		{
			get { return _ServiceType; }
			set 
			{ 
				_ServiceType = value;
				OnPropertyChanged("ServiceType");
			}
		}
		/// <summary>
		/// Use ServiceFeatureAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorServiceFeature ServiceFeature
		{
			get { return _ServiceFeature; }
			private set 
			{ 
				_ServiceFeature = value;
				OnPropertyChanged("ServiceFeature");
			}
		}
		/// <summary>
		/// Use TurnAroundTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorServiceTurnAroundTime TurnAroundTime
		{
			get { return _TurnAroundTime; }
			set 
			{ 
				_TurnAroundTime = value;
				OnPropertyChanged("TurnAroundTime");
			}
		}
		/// <summary>
		/// Use PricingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorCatalogItemPricing Pricing
		{
			get { return _Pricing; }
			set 
			{ 
				_Pricing = value;
				OnPropertyChanged("Pricing");
			}
		}
		/// <summary>
		/// Use EngineTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ReachVendorEngineType EngineType
		{
			get { return _EngineType; }
			set 
			{ 
				_EngineType = value;
				OnPropertyChanged("EngineType");
			}
		}
		/// <summary>
		/// Use SourceLanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CatalogItemLanguage SourceLanguage
		{
			get { return _SourceLanguage; }
			set 
			{ 
				_SourceLanguage = value;
				OnPropertyChanged("SourceLanguage");
			}
		}
		/// <summary>
		/// Use AllowResubmissionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? AllowResubmission
		{
			get { return _AllowResubmission; }
			set 
			{ 
				_AllowResubmission = value;
				OnPropertyChanged("AllowResubmission");
			}
		}
		#endregion

		#region CTor
		public VendorCatalogItem()
		{
		}

		public VendorCatalogItem(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["vendorPartnerId"] != null)
			{
				this._VendorPartnerId = ParseInt(node["vendorPartnerId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (VendorCatalogItemStatus)ParseEnum(typeof(VendorCatalogItemStatus), node["status"].Value<string>());
			}
			if(node["serviceType"] != null)
			{
				this._ServiceType = (VendorServiceType)ParseEnum(typeof(VendorServiceType), node["serviceType"].Value<string>());
			}
			if(node["serviceFeature"] != null)
			{
				this._ServiceFeature = (VendorServiceFeature)ParseEnum(typeof(VendorServiceFeature), node["serviceFeature"].Value<string>());
			}
			if(node["turnAroundTime"] != null)
			{
				this._TurnAroundTime = (VendorServiceTurnAroundTime)ParseEnum(typeof(VendorServiceTurnAroundTime), node["turnAroundTime"].Value<string>());
			}
			if(node["pricing"] != null)
			{
				this._Pricing = ObjectFactory.Create<VendorCatalogItemPricing>(node["pricing"]);
			}
			if(node["engineType"] != null)
			{
				this._EngineType = (ReachVendorEngineType)StringEnum.Parse(typeof(ReachVendorEngineType), node["engineType"].Value<string>());
			}
			if(node["sourceLanguage"] != null)
			{
				this._SourceLanguage = (CatalogItemLanguage)StringEnum.Parse(typeof(CatalogItemLanguage), node["sourceLanguage"].Value<string>());
			}
			if(node["allowResubmission"] != null)
			{
				this._AllowResubmission = ParseBool(node["allowResubmission"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVendorCatalogItem");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("vendorPartnerId", this._VendorPartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("serviceType", this._ServiceType);
			kparams.AddIfNotNull("serviceFeature", this._ServiceFeature);
			kparams.AddIfNotNull("turnAroundTime", this._TurnAroundTime);
			kparams.AddIfNotNull("pricing", this._Pricing);
			kparams.AddIfNotNull("engineType", this._EngineType);
			kparams.AddIfNotNull("sourceLanguage", this._SourceLanguage);
			kparams.AddIfNotNull("allowResubmission", this._AllowResubmission);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case VENDOR_PARTNER_ID:
					return "VendorPartnerId";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case STATUS:
					return "Status";
				case SERVICE_TYPE:
					return "ServiceType";
				case SERVICE_FEATURE:
					return "ServiceFeature";
				case TURN_AROUND_TIME:
					return "TurnAroundTime";
				case PRICING:
					return "Pricing";
				case ENGINE_TYPE:
					return "EngineType";
				case SOURCE_LANGUAGE:
					return "SourceLanguage";
				case ALLOW_RESUBMISSION:
					return "AllowResubmission";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

