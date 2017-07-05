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
	public class Subscription : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CHANNELS = "channels";
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string FILE_TYPES = "fileTypes";
		public const string IS_RENEWABLE = "isRenewable";
		public const string RENEWALS_NUMBER = "renewalsNumber";
		public const string IS_INFINITE_RENEWAL = "isInfiniteRenewal";
		public const string PRICE = "price";
		public const string DISCOUNT_MODULE = "discountModule";
		public const string COUPONS_GROUP = "couponsGroup";
		public const string NAMES = "names";
		public const string DESCRIPTIONS = "descriptions";
		public const string MEDIA_ID = "mediaId";
		public const string PRORITY_IN_ORDER = "prorityInOrder";
		public const string PRODUCT_CODE = "productCode";
		public const string PRICE_PLANS = "pricePlans";
		public const string PREVIEW_MODULE = "previewModule";
		public const string HOUSEHOLD_LIMITATIONS_ID = "householdLimitationsId";
		public const string GRACE_PERIOD_MINUTES = "gracePeriodMinutes";
		public const string PREMIUM_SERVICES = "premiumServices";
		public const string MAX_VIEWS_NUMBER = "maxViewsNumber";
		public const string VIEW_LIFE_CYCLE = "viewLifeCycle";
		public const string WAIVER_PERIOD = "waiverPeriod";
		public const string IS_WAIVER_ENABLED = "isWaiverEnabled";
		public const string USER_TYPES = "userTypes";
		#endregion

		#region Private Fields
		private string _Id = null;
		private IList<BaseChannel> _Channels;
		private long _StartDate = long.MinValue;
		private long _EndDate = long.MinValue;
		private IList<IntegerValue> _FileTypes;
		private bool? _IsRenewable = null;
		private int _RenewalsNumber = Int32.MinValue;
		private bool? _IsInfiniteRenewal = null;
		private PriceDetails _Price;
		private DiscountModule _DiscountModule;
		private CouponsGroup _CouponsGroup;
		private IList<TranslationToken> _Names;
		private IList<TranslationToken> _Descriptions;
		private int _MediaId = Int32.MinValue;
		private long _ProrityInOrder = long.MinValue;
		private string _ProductCode = null;
		private IList<PricePlan> _PricePlans;
		private PreviewModule _PreviewModule;
		private int _HouseholdLimitationsId = Int32.MinValue;
		private int _GracePeriodMinutes = Int32.MinValue;
		private IList<PremiumService> _PremiumServices;
		private int _MaxViewsNumber = Int32.MinValue;
		private int _ViewLifeCycle = Int32.MinValue;
		private int _WaiverPeriod = Int32.MinValue;
		private bool? _IsWaiverEnabled = null;
		private IList<OTTUserType> _UserTypes;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public IList<BaseChannel> Channels
		{
			get { return _Channels; }
			set 
			{ 
				_Channels = value;
				OnPropertyChanged("Channels");
			}
		}
		public long StartDate
		{
			get { return _StartDate; }
			set 
			{ 
				_StartDate = value;
				OnPropertyChanged("StartDate");
			}
		}
		public long EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
			}
		}
		public IList<IntegerValue> FileTypes
		{
			get { return _FileTypes; }
			set 
			{ 
				_FileTypes = value;
				OnPropertyChanged("FileTypes");
			}
		}
		public bool? IsRenewable
		{
			get { return _IsRenewable; }
			set 
			{ 
				_IsRenewable = value;
				OnPropertyChanged("IsRenewable");
			}
		}
		public int RenewalsNumber
		{
			get { return _RenewalsNumber; }
			set 
			{ 
				_RenewalsNumber = value;
				OnPropertyChanged("RenewalsNumber");
			}
		}
		public bool? IsInfiniteRenewal
		{
			get { return _IsInfiniteRenewal; }
			set 
			{ 
				_IsInfiniteRenewal = value;
				OnPropertyChanged("IsInfiniteRenewal");
			}
		}
		public PriceDetails Price
		{
			get { return _Price; }
			set 
			{ 
				_Price = value;
				OnPropertyChanged("Price");
			}
		}
		public DiscountModule DiscountModule
		{
			get { return _DiscountModule; }
			set 
			{ 
				_DiscountModule = value;
				OnPropertyChanged("DiscountModule");
			}
		}
		public CouponsGroup CouponsGroup
		{
			get { return _CouponsGroup; }
			set 
			{ 
				_CouponsGroup = value;
				OnPropertyChanged("CouponsGroup");
			}
		}
		public IList<TranslationToken> Names
		{
			get { return _Names; }
			set 
			{ 
				_Names = value;
				OnPropertyChanged("Names");
			}
		}
		public IList<TranslationToken> Descriptions
		{
			get { return _Descriptions; }
			set 
			{ 
				_Descriptions = value;
				OnPropertyChanged("Descriptions");
			}
		}
		public int MediaId
		{
			get { return _MediaId; }
			set 
			{ 
				_MediaId = value;
				OnPropertyChanged("MediaId");
			}
		}
		public long ProrityInOrder
		{
			get { return _ProrityInOrder; }
			set 
			{ 
				_ProrityInOrder = value;
				OnPropertyChanged("ProrityInOrder");
			}
		}
		public string ProductCode
		{
			get { return _ProductCode; }
			set 
			{ 
				_ProductCode = value;
				OnPropertyChanged("ProductCode");
			}
		}
		public IList<PricePlan> PricePlans
		{
			get { return _PricePlans; }
			set 
			{ 
				_PricePlans = value;
				OnPropertyChanged("PricePlans");
			}
		}
		public PreviewModule PreviewModule
		{
			get { return _PreviewModule; }
			set 
			{ 
				_PreviewModule = value;
				OnPropertyChanged("PreviewModule");
			}
		}
		public int HouseholdLimitationsId
		{
			get { return _HouseholdLimitationsId; }
			set 
			{ 
				_HouseholdLimitationsId = value;
				OnPropertyChanged("HouseholdLimitationsId");
			}
		}
		public int GracePeriodMinutes
		{
			get { return _GracePeriodMinutes; }
			set 
			{ 
				_GracePeriodMinutes = value;
				OnPropertyChanged("GracePeriodMinutes");
			}
		}
		public IList<PremiumService> PremiumServices
		{
			get { return _PremiumServices; }
			set 
			{ 
				_PremiumServices = value;
				OnPropertyChanged("PremiumServices");
			}
		}
		public int MaxViewsNumber
		{
			get { return _MaxViewsNumber; }
			set 
			{ 
				_MaxViewsNumber = value;
				OnPropertyChanged("MaxViewsNumber");
			}
		}
		public int ViewLifeCycle
		{
			get { return _ViewLifeCycle; }
			set 
			{ 
				_ViewLifeCycle = value;
				OnPropertyChanged("ViewLifeCycle");
			}
		}
		public int WaiverPeriod
		{
			get { return _WaiverPeriod; }
			set 
			{ 
				_WaiverPeriod = value;
				OnPropertyChanged("WaiverPeriod");
			}
		}
		public bool? IsWaiverEnabled
		{
			get { return _IsWaiverEnabled; }
			set 
			{ 
				_IsWaiverEnabled = value;
				OnPropertyChanged("IsWaiverEnabled");
			}
		}
		public IList<OTTUserType> UserTypes
		{
			get { return _UserTypes; }
			set 
			{ 
				_UserTypes = value;
				OnPropertyChanged("UserTypes");
			}
		}
		#endregion

		#region CTor
		public Subscription()
		{
		}

		public Subscription(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "channels":
						this._Channels = new List<BaseChannel>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Channels.Add(ObjectFactory.Create<BaseChannel>(arrayNode));
						}
						continue;
					case "startDate":
						this._StartDate = ParseLong(propertyNode.InnerText);
						continue;
					case "endDate":
						this._EndDate = ParseLong(propertyNode.InnerText);
						continue;
					case "fileTypes":
						this._FileTypes = new List<IntegerValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._FileTypes.Add(ObjectFactory.Create<IntegerValue>(arrayNode));
						}
						continue;
					case "isRenewable":
						this._IsRenewable = ParseBool(propertyNode.InnerText);
						continue;
					case "renewalsNumber":
						this._RenewalsNumber = ParseInt(propertyNode.InnerText);
						continue;
					case "isInfiniteRenewal":
						this._IsInfiniteRenewal = ParseBool(propertyNode.InnerText);
						continue;
					case "price":
						this._Price = ObjectFactory.Create<PriceDetails>(propertyNode);
						continue;
					case "discountModule":
						this._DiscountModule = ObjectFactory.Create<DiscountModule>(propertyNode);
						continue;
					case "couponsGroup":
						this._CouponsGroup = ObjectFactory.Create<CouponsGroup>(propertyNode);
						continue;
					case "names":
						this._Names = new List<TranslationToken>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Names.Add(ObjectFactory.Create<TranslationToken>(arrayNode));
						}
						continue;
					case "descriptions":
						this._Descriptions = new List<TranslationToken>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Descriptions.Add(ObjectFactory.Create<TranslationToken>(arrayNode));
						}
						continue;
					case "mediaId":
						this._MediaId = ParseInt(propertyNode.InnerText);
						continue;
					case "prorityInOrder":
						this._ProrityInOrder = ParseLong(propertyNode.InnerText);
						continue;
					case "productCode":
						this._ProductCode = propertyNode.InnerText;
						continue;
					case "pricePlans":
						this._PricePlans = new List<PricePlan>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._PricePlans.Add(ObjectFactory.Create<PricePlan>(arrayNode));
						}
						continue;
					case "previewModule":
						this._PreviewModule = ObjectFactory.Create<PreviewModule>(propertyNode);
						continue;
					case "householdLimitationsId":
						this._HouseholdLimitationsId = ParseInt(propertyNode.InnerText);
						continue;
					case "gracePeriodMinutes":
						this._GracePeriodMinutes = ParseInt(propertyNode.InnerText);
						continue;
					case "premiumServices":
						this._PremiumServices = new List<PremiumService>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._PremiumServices.Add(ObjectFactory.Create<PremiumService>(arrayNode));
						}
						continue;
					case "maxViewsNumber":
						this._MaxViewsNumber = ParseInt(propertyNode.InnerText);
						continue;
					case "viewLifeCycle":
						this._ViewLifeCycle = ParseInt(propertyNode.InnerText);
						continue;
					case "waiverPeriod":
						this._WaiverPeriod = ParseInt(propertyNode.InnerText);
						continue;
					case "isWaiverEnabled":
						this._IsWaiverEnabled = ParseBool(propertyNode.InnerText);
						continue;
					case "userTypes":
						this._UserTypes = new List<OTTUserType>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._UserTypes.Add(ObjectFactory.Create<OTTUserType>(arrayNode));
						}
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
				kparams.AddReplace("objectType", "KalturaSubscription");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("channels", this._Channels);
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("fileTypes", this._FileTypes);
			kparams.AddIfNotNull("isRenewable", this._IsRenewable);
			kparams.AddIfNotNull("renewalsNumber", this._RenewalsNumber);
			kparams.AddIfNotNull("isInfiniteRenewal", this._IsInfiniteRenewal);
			kparams.AddIfNotNull("price", this._Price);
			kparams.AddIfNotNull("discountModule", this._DiscountModule);
			kparams.AddIfNotNull("couponsGroup", this._CouponsGroup);
			kparams.AddIfNotNull("names", this._Names);
			kparams.AddIfNotNull("descriptions", this._Descriptions);
			kparams.AddIfNotNull("mediaId", this._MediaId);
			kparams.AddIfNotNull("prorityInOrder", this._ProrityInOrder);
			kparams.AddIfNotNull("productCode", this._ProductCode);
			kparams.AddIfNotNull("pricePlans", this._PricePlans);
			kparams.AddIfNotNull("previewModule", this._PreviewModule);
			kparams.AddIfNotNull("householdLimitationsId", this._HouseholdLimitationsId);
			kparams.AddIfNotNull("gracePeriodMinutes", this._GracePeriodMinutes);
			kparams.AddIfNotNull("premiumServices", this._PremiumServices);
			kparams.AddIfNotNull("maxViewsNumber", this._MaxViewsNumber);
			kparams.AddIfNotNull("viewLifeCycle", this._ViewLifeCycle);
			kparams.AddIfNotNull("waiverPeriod", this._WaiverPeriod);
			kparams.AddIfNotNull("isWaiverEnabled", this._IsWaiverEnabled);
			kparams.AddIfNotNull("userTypes", this._UserTypes);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CHANNELS:
					return "Channels";
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case FILE_TYPES:
					return "FileTypes";
				case IS_RENEWABLE:
					return "IsRenewable";
				case RENEWALS_NUMBER:
					return "RenewalsNumber";
				case IS_INFINITE_RENEWAL:
					return "IsInfiniteRenewal";
				case PRICE:
					return "Price";
				case DISCOUNT_MODULE:
					return "DiscountModule";
				case COUPONS_GROUP:
					return "CouponsGroup";
				case NAMES:
					return "Names";
				case DESCRIPTIONS:
					return "Descriptions";
				case MEDIA_ID:
					return "MediaId";
				case PRORITY_IN_ORDER:
					return "ProrityInOrder";
				case PRODUCT_CODE:
					return "ProductCode";
				case PRICE_PLANS:
					return "PricePlans";
				case PREVIEW_MODULE:
					return "PreviewModule";
				case HOUSEHOLD_LIMITATIONS_ID:
					return "HouseholdLimitationsId";
				case GRACE_PERIOD_MINUTES:
					return "GracePeriodMinutes";
				case PREMIUM_SERVICES:
					return "PremiumServices";
				case MAX_VIEWS_NUMBER:
					return "MaxViewsNumber";
				case VIEW_LIFE_CYCLE:
					return "ViewLifeCycle";
				case WAIVER_PERIOD:
					return "WaiverPeriod";
				case IS_WAIVER_ENABLED:
					return "IsWaiverEnabled";
				case USER_TYPES:
					return "UserTypes";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

