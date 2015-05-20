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
// Copyright (C) 2006-2015  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaPartnerBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private string _NameLike = null;
		private string _NameMultiLikeOr = null;
		private string _NameMultiLikeAnd = null;
		private string _NameEqual = null;
		private KalturaPartnerStatus _StatusEqual = (KalturaPartnerStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _PartnerPackageEqual = Int32.MinValue;
		private int _PartnerPackageGreaterThanOrEqual = Int32.MinValue;
		private int _PartnerPackageLessThanOrEqual = Int32.MinValue;
		private KalturaPartnerGroupType _PartnerGroupTypeEqual = (KalturaPartnerGroupType)Int32.MinValue;
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
		public KalturaPartnerStatus StatusEqual
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
		public KalturaPartnerGroupType PartnerGroupTypeEqual
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
		public KalturaPartnerBaseFilter()
		{
		}

		public KalturaPartnerBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this.IdIn = txt;
						continue;
					case "idNotIn":
						this.IdNotIn = txt;
						continue;
					case "nameLike":
						this.NameLike = txt;
						continue;
					case "nameMultiLikeOr":
						this.NameMultiLikeOr = txt;
						continue;
					case "nameMultiLikeAnd":
						this.NameMultiLikeAnd = txt;
						continue;
					case "nameEqual":
						this.NameEqual = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaPartnerStatus)ParseEnum(typeof(KalturaPartnerStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "partnerPackageEqual":
						this.PartnerPackageEqual = ParseInt(txt);
						continue;
					case "partnerPackageGreaterThanOrEqual":
						this.PartnerPackageGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "partnerPackageLessThanOrEqual":
						this.PartnerPackageLessThanOrEqual = ParseInt(txt);
						continue;
					case "partnerGroupTypeEqual":
						this.PartnerGroupTypeEqual = (KalturaPartnerGroupType)ParseEnum(typeof(KalturaPartnerGroupType), txt);
						continue;
					case "partnerNameDescriptionWebsiteAdminNameAdminEmailLike":
						this.PartnerNameDescriptionWebsiteAdminNameAdminEmailLike = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPartnerBaseFilter");
			kparams.AddIntIfNotNull("idEqual", this.IdEqual);
			kparams.AddStringIfNotNull("idIn", this.IdIn);
			kparams.AddStringIfNotNull("idNotIn", this.IdNotIn);
			kparams.AddStringIfNotNull("nameLike", this.NameLike);
			kparams.AddStringIfNotNull("nameMultiLikeOr", this.NameMultiLikeOr);
			kparams.AddStringIfNotNull("nameMultiLikeAnd", this.NameMultiLikeAnd);
			kparams.AddStringIfNotNull("nameEqual", this.NameEqual);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddIntIfNotNull("partnerPackageEqual", this.PartnerPackageEqual);
			kparams.AddIntIfNotNull("partnerPackageGreaterThanOrEqual", this.PartnerPackageGreaterThanOrEqual);
			kparams.AddIntIfNotNull("partnerPackageLessThanOrEqual", this.PartnerPackageLessThanOrEqual);
			kparams.AddEnumIfNotNull("partnerGroupTypeEqual", this.PartnerGroupTypeEqual);
			kparams.AddStringIfNotNull("partnerNameDescriptionWebsiteAdminNameAdminEmailLike", this.PartnerNameDescriptionWebsiteAdminNameAdminEmailLike);
			return kparams;
		}
		#endregion
	}
}

