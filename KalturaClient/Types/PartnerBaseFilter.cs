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
	public class PartnerBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string ID_NOT_IN = "idNotIn";
		public const string NAME_LIKE = "nameLike";
		public const string NAME_MULTI_LIKE_OR = "nameMultiLikeOr";
		public const string NAME_MULTI_LIKE_AND = "nameMultiLikeAnd";
		public const string NAME_EQUAL = "nameEqual";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string PARTNER_PACKAGE_EQUAL = "partnerPackageEqual";
		public const string PARTNER_PACKAGE_GREATER_THAN_OR_EQUAL = "partnerPackageGreaterThanOrEqual";
		public const string PARTNER_PACKAGE_LESS_THAN_OR_EQUAL = "partnerPackageLessThanOrEqual";
		public const string PARTNER_PACKAGE_IN = "partnerPackageIn";
		public const string PARTNER_GROUP_TYPE_EQUAL = "partnerGroupTypeEqual";
		public const string PARTNER_NAME_DESCRIPTION_WEBSITE_ADMIN_NAME_ADMIN_EMAIL_LIKE = "partnerNameDescriptionWebsiteAdminNameAdminEmailLike";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string ID_GREATER_THAN = "idGreaterThan";
		public const string MONITOR_USAGE_EQUAL = "monitorUsageEqual";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private string _NameLike = null;
		private string _NameMultiLikeOr = null;
		private string _NameMultiLikeAnd = null;
		private string _NameEqual = null;
		private PartnerStatus _StatusEqual = (PartnerStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _PartnerPackageEqual = Int32.MinValue;
		private int _PartnerPackageGreaterThanOrEqual = Int32.MinValue;
		private int _PartnerPackageLessThanOrEqual = Int32.MinValue;
		private string _PartnerPackageIn = null;
		private PartnerGroupType _PartnerGroupTypeEqual = (PartnerGroupType)Int32.MinValue;
		private string _PartnerNameDescriptionWebsiteAdminNameAdminEmailLike = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _IdGreaterThan = Int32.MinValue;
		private int _MonitorUsageEqual = Int32.MinValue;
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
		public string NameLike
		{
			get { return _NameLike; }
			set 
			{ 
				_NameLike = value;
				OnPropertyChanged("NameLike");
			}
		}
		[JsonProperty]
		public string NameMultiLikeOr
		{
			get { return _NameMultiLikeOr; }
			set 
			{ 
				_NameMultiLikeOr = value;
				OnPropertyChanged("NameMultiLikeOr");
			}
		}
		[JsonProperty]
		public string NameMultiLikeAnd
		{
			get { return _NameMultiLikeAnd; }
			set 
			{ 
				_NameMultiLikeAnd = value;
				OnPropertyChanged("NameMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string NameEqual
		{
			get { return _NameEqual; }
			set 
			{ 
				_NameEqual = value;
				OnPropertyChanged("NameEqual");
			}
		}
		[JsonProperty]
		public PartnerStatus StatusEqual
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
		public int PartnerPackageEqual
		{
			get { return _PartnerPackageEqual; }
			set 
			{ 
				_PartnerPackageEqual = value;
				OnPropertyChanged("PartnerPackageEqual");
			}
		}
		[JsonProperty]
		public int PartnerPackageGreaterThanOrEqual
		{
			get { return _PartnerPackageGreaterThanOrEqual; }
			set 
			{ 
				_PartnerPackageGreaterThanOrEqual = value;
				OnPropertyChanged("PartnerPackageGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int PartnerPackageLessThanOrEqual
		{
			get { return _PartnerPackageLessThanOrEqual; }
			set 
			{ 
				_PartnerPackageLessThanOrEqual = value;
				OnPropertyChanged("PartnerPackageLessThanOrEqual");
			}
		}
		[JsonProperty]
		public string PartnerPackageIn
		{
			get { return _PartnerPackageIn; }
			set 
			{ 
				_PartnerPackageIn = value;
				OnPropertyChanged("PartnerPackageIn");
			}
		}
		[JsonProperty]
		public PartnerGroupType PartnerGroupTypeEqual
		{
			get { return _PartnerGroupTypeEqual; }
			set 
			{ 
				_PartnerGroupTypeEqual = value;
				OnPropertyChanged("PartnerGroupTypeEqual");
			}
		}
		[JsonProperty]
		public string PartnerNameDescriptionWebsiteAdminNameAdminEmailLike
		{
			get { return _PartnerNameDescriptionWebsiteAdminNameAdminEmailLike; }
			set 
			{ 
				_PartnerNameDescriptionWebsiteAdminNameAdminEmailLike = value;
				OnPropertyChanged("PartnerNameDescriptionWebsiteAdminNameAdminEmailLike");
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
		public int IdGreaterThan
		{
			get { return _IdGreaterThan; }
			set 
			{ 
				_IdGreaterThan = value;
				OnPropertyChanged("IdGreaterThan");
			}
		}
		[JsonProperty]
		public int MonitorUsageEqual
		{
			get { return _MonitorUsageEqual; }
			set 
			{ 
				_MonitorUsageEqual = value;
				OnPropertyChanged("MonitorUsageEqual");
			}
		}
		#endregion

		#region CTor
		public PartnerBaseFilter()
		{
		}

		public PartnerBaseFilter(JToken node) : base(node)
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
			if(node["nameLike"] != null)
			{
				this._NameLike = node["nameLike"].Value<string>();
			}
			if(node["nameMultiLikeOr"] != null)
			{
				this._NameMultiLikeOr = node["nameMultiLikeOr"].Value<string>();
			}
			if(node["nameMultiLikeAnd"] != null)
			{
				this._NameMultiLikeAnd = node["nameMultiLikeAnd"].Value<string>();
			}
			if(node["nameEqual"] != null)
			{
				this._NameEqual = node["nameEqual"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (PartnerStatus)ParseEnum(typeof(PartnerStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["partnerPackageEqual"] != null)
			{
				this._PartnerPackageEqual = ParseInt(node["partnerPackageEqual"].Value<string>());
			}
			if(node["partnerPackageGreaterThanOrEqual"] != null)
			{
				this._PartnerPackageGreaterThanOrEqual = ParseInt(node["partnerPackageGreaterThanOrEqual"].Value<string>());
			}
			if(node["partnerPackageLessThanOrEqual"] != null)
			{
				this._PartnerPackageLessThanOrEqual = ParseInt(node["partnerPackageLessThanOrEqual"].Value<string>());
			}
			if(node["partnerPackageIn"] != null)
			{
				this._PartnerPackageIn = node["partnerPackageIn"].Value<string>();
			}
			if(node["partnerGroupTypeEqual"] != null)
			{
				this._PartnerGroupTypeEqual = (PartnerGroupType)ParseEnum(typeof(PartnerGroupType), node["partnerGroupTypeEqual"].Value<string>());
			}
			if(node["partnerNameDescriptionWebsiteAdminNameAdminEmailLike"] != null)
			{
				this._PartnerNameDescriptionWebsiteAdminNameAdminEmailLike = node["partnerNameDescriptionWebsiteAdminNameAdminEmailLike"].Value<string>();
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["idGreaterThan"] != null)
			{
				this._IdGreaterThan = ParseInt(node["idGreaterThan"].Value<string>());
			}
			if(node["monitorUsageEqual"] != null)
			{
				this._MonitorUsageEqual = ParseInt(node["monitorUsageEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPartnerBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("idNotIn", this._IdNotIn);
			kparams.AddIfNotNull("nameLike", this._NameLike);
			kparams.AddIfNotNull("nameMultiLikeOr", this._NameMultiLikeOr);
			kparams.AddIfNotNull("nameMultiLikeAnd", this._NameMultiLikeAnd);
			kparams.AddIfNotNull("nameEqual", this._NameEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("partnerPackageEqual", this._PartnerPackageEqual);
			kparams.AddIfNotNull("partnerPackageGreaterThanOrEqual", this._PartnerPackageGreaterThanOrEqual);
			kparams.AddIfNotNull("partnerPackageLessThanOrEqual", this._PartnerPackageLessThanOrEqual);
			kparams.AddIfNotNull("partnerPackageIn", this._PartnerPackageIn);
			kparams.AddIfNotNull("partnerGroupTypeEqual", this._PartnerGroupTypeEqual);
			kparams.AddIfNotNull("partnerNameDescriptionWebsiteAdminNameAdminEmailLike", this._PartnerNameDescriptionWebsiteAdminNameAdminEmailLike);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("idGreaterThan", this._IdGreaterThan);
			kparams.AddIfNotNull("monitorUsageEqual", this._MonitorUsageEqual);
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
				case NAME_LIKE:
					return "NameLike";
				case NAME_MULTI_LIKE_OR:
					return "NameMultiLikeOr";
				case NAME_MULTI_LIKE_AND:
					return "NameMultiLikeAnd";
				case NAME_EQUAL:
					return "NameEqual";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case PARTNER_PACKAGE_EQUAL:
					return "PartnerPackageEqual";
				case PARTNER_PACKAGE_GREATER_THAN_OR_EQUAL:
					return "PartnerPackageGreaterThanOrEqual";
				case PARTNER_PACKAGE_LESS_THAN_OR_EQUAL:
					return "PartnerPackageLessThanOrEqual";
				case PARTNER_PACKAGE_IN:
					return "PartnerPackageIn";
				case PARTNER_GROUP_TYPE_EQUAL:
					return "PartnerGroupTypeEqual";
				case PARTNER_NAME_DESCRIPTION_WEBSITE_ADMIN_NAME_ADMIN_EMAIL_LIKE:
					return "PartnerNameDescriptionWebsiteAdminNameAdminEmailLike";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case ID_GREATER_THAN:
					return "IdGreaterThan";
				case MONITOR_USAGE_EQUAL:
					return "MonitorUsageEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

