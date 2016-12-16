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
		#endregion

		#region Properties
		public int IdEqual
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
		public string IdNotIn
		{
			get { return _IdNotIn; }
			set 
			{ 
				_IdNotIn = value;
				OnPropertyChanged("IdNotIn");
			}
		}
		public string NameLike
		{
			get { return _NameLike; }
			set 
			{ 
				_NameLike = value;
				OnPropertyChanged("NameLike");
			}
		}
		public string NameMultiLikeOr
		{
			get { return _NameMultiLikeOr; }
			set 
			{ 
				_NameMultiLikeOr = value;
				OnPropertyChanged("NameMultiLikeOr");
			}
		}
		public string NameMultiLikeAnd
		{
			get { return _NameMultiLikeAnd; }
			set 
			{ 
				_NameMultiLikeAnd = value;
				OnPropertyChanged("NameMultiLikeAnd");
			}
		}
		public string NameEqual
		{
			get { return _NameEqual; }
			set 
			{ 
				_NameEqual = value;
				OnPropertyChanged("NameEqual");
			}
		}
		public PartnerStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public int PartnerPackageEqual
		{
			get { return _PartnerPackageEqual; }
			set 
			{ 
				_PartnerPackageEqual = value;
				OnPropertyChanged("PartnerPackageEqual");
			}
		}
		public int PartnerPackageGreaterThanOrEqual
		{
			get { return _PartnerPackageGreaterThanOrEqual; }
			set 
			{ 
				_PartnerPackageGreaterThanOrEqual = value;
				OnPropertyChanged("PartnerPackageGreaterThanOrEqual");
			}
		}
		public int PartnerPackageLessThanOrEqual
		{
			get { return _PartnerPackageLessThanOrEqual; }
			set 
			{ 
				_PartnerPackageLessThanOrEqual = value;
				OnPropertyChanged("PartnerPackageLessThanOrEqual");
			}
		}
		public string PartnerPackageIn
		{
			get { return _PartnerPackageIn; }
			set 
			{ 
				_PartnerPackageIn = value;
				OnPropertyChanged("PartnerPackageIn");
			}
		}
		public PartnerGroupType PartnerGroupTypeEqual
		{
			get { return _PartnerGroupTypeEqual; }
			set 
			{ 
				_PartnerGroupTypeEqual = value;
				OnPropertyChanged("PartnerGroupTypeEqual");
			}
		}
		public string PartnerNameDescriptionWebsiteAdminNameAdminEmailLike
		{
			get { return _PartnerNameDescriptionWebsiteAdminNameAdminEmailLike; }
			set 
			{ 
				_PartnerNameDescriptionWebsiteAdminNameAdminEmailLike = value;
				OnPropertyChanged("PartnerNameDescriptionWebsiteAdminNameAdminEmailLike");
			}
		}
		#endregion

		#region CTor
		public PartnerBaseFilter()
		{
		}

		public PartnerBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this._IdIn = txt;
						continue;
					case "idNotIn":
						this._IdNotIn = txt;
						continue;
					case "nameLike":
						this._NameLike = txt;
						continue;
					case "nameMultiLikeOr":
						this._NameMultiLikeOr = txt;
						continue;
					case "nameMultiLikeAnd":
						this._NameMultiLikeAnd = txt;
						continue;
					case "nameEqual":
						this._NameEqual = txt;
						continue;
					case "statusEqual":
						this._StatusEqual = (PartnerStatus)ParseEnum(typeof(PartnerStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "partnerPackageEqual":
						this._PartnerPackageEqual = ParseInt(txt);
						continue;
					case "partnerPackageGreaterThanOrEqual":
						this._PartnerPackageGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "partnerPackageLessThanOrEqual":
						this._PartnerPackageLessThanOrEqual = ParseInt(txt);
						continue;
					case "partnerPackageIn":
						this._PartnerPackageIn = txt;
						continue;
					case "partnerGroupTypeEqual":
						this._PartnerGroupTypeEqual = (PartnerGroupType)ParseEnum(typeof(PartnerGroupType), txt);
						continue;
					case "partnerNameDescriptionWebsiteAdminNameAdminEmailLike":
						this._PartnerNameDescriptionWebsiteAdminNameAdminEmailLike = txt;
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

