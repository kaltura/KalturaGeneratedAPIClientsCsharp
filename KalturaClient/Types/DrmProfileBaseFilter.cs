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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class DrmProfileBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string PARTNER_ID_IN = "partnerIdIn";
		public const string NAME_LIKE = "nameLike";
		public const string PROVIDER_EQUAL = "providerEqual";
		public const string PROVIDER_IN = "providerIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _NameLike = null;
		private DrmProviderType _ProviderEqual = null;
		private string _ProviderIn = null;
		private DrmProfileStatus _StatusEqual = (DrmProfileStatus)Int32.MinValue;
		private string _StatusIn = null;
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
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		[JsonProperty]
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
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
		public DrmProviderType ProviderEqual
		{
			get { return _ProviderEqual; }
			set 
			{ 
				_ProviderEqual = value;
				OnPropertyChanged("ProviderEqual");
			}
		}
		[JsonProperty]
		public string ProviderIn
		{
			get { return _ProviderIn; }
			set 
			{ 
				_ProviderIn = value;
				OnPropertyChanged("ProviderIn");
			}
		}
		[JsonProperty]
		public DrmProfileStatus StatusEqual
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
		#endregion

		#region CTor
		public DrmProfileBaseFilter()
		{
		}

		public DrmProfileBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseInt(node["idEqual"].Value<string>());
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["partnerIdEqual"] != null)
			{
				this._PartnerIdEqual = ParseInt(node["partnerIdEqual"].Value<string>());
			}
			if(node["partnerIdIn"] != null)
			{
				this._PartnerIdIn = node["partnerIdIn"].Value<string>();
			}
			if(node["nameLike"] != null)
			{
				this._NameLike = node["nameLike"].Value<string>();
			}
			if(node["providerEqual"] != null)
			{
				this._ProviderEqual = (DrmProviderType)StringEnum.Parse(typeof(DrmProviderType), node["providerEqual"].Value<string>());
			}
			if(node["providerIn"] != null)
			{
				this._ProviderIn = node["providerIn"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (DrmProfileStatus)ParseEnum(typeof(DrmProfileStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDrmProfileBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this._PartnerIdIn);
			kparams.AddIfNotNull("nameLike", this._NameLike);
			kparams.AddIfNotNull("providerEqual", this._ProviderEqual);
			kparams.AddIfNotNull("providerIn", this._ProviderIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
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
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case PARTNER_ID_IN:
					return "PartnerIdIn";
				case NAME_LIKE:
					return "NameLike";
				case PROVIDER_EQUAL:
					return "ProviderEqual";
				case PROVIDER_IN:
					return "ProviderIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

