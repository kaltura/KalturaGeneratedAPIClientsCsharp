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
	public class VirusScanProfileBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string PARTNER_ID_IN = "partnerIdIn";
		public const string NAME_EQUAL = "nameEqual";
		public const string NAME_LIKE = "nameLike";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string ENGINE_TYPE_EQUAL = "engineTypeEqual";
		public const string ENGINE_TYPE_IN = "engineTypeIn";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _NameEqual = null;
		private string _NameLike = null;
		private VirusScanProfileStatus _StatusEqual = (VirusScanProfileStatus)Int32.MinValue;
		private string _StatusIn = null;
		private VirusScanEngineType _EngineTypeEqual = null;
		private string _EngineTypeIn = null;
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
		public VirusScanProfileStatus StatusEqual
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
		public VirusScanEngineType EngineTypeEqual
		{
			get { return _EngineTypeEqual; }
			set 
			{ 
				_EngineTypeEqual = value;
				OnPropertyChanged("EngineTypeEqual");
			}
		}
		[JsonProperty]
		public string EngineTypeIn
		{
			get { return _EngineTypeIn; }
			set 
			{ 
				_EngineTypeIn = value;
				OnPropertyChanged("EngineTypeIn");
			}
		}
		#endregion

		#region CTor
		public VirusScanProfileBaseFilter()
		{
		}

		public VirusScanProfileBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseInt(node["idEqual"].Value<string>());
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
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
			if(node["partnerIdEqual"] != null)
			{
				this._PartnerIdEqual = ParseInt(node["partnerIdEqual"].Value<string>());
			}
			if(node["partnerIdIn"] != null)
			{
				this._PartnerIdIn = node["partnerIdIn"].Value<string>();
			}
			if(node["nameEqual"] != null)
			{
				this._NameEqual = node["nameEqual"].Value<string>();
			}
			if(node["nameLike"] != null)
			{
				this._NameLike = node["nameLike"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (VirusScanProfileStatus)ParseEnum(typeof(VirusScanProfileStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["engineTypeEqual"] != null)
			{
				this._EngineTypeEqual = (VirusScanEngineType)StringEnum.Parse(typeof(VirusScanEngineType), node["engineTypeEqual"].Value<string>());
			}
			if(node["engineTypeIn"] != null)
			{
				this._EngineTypeIn = node["engineTypeIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVirusScanProfileBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this._PartnerIdIn);
			kparams.AddIfNotNull("nameEqual", this._NameEqual);
			kparams.AddIfNotNull("nameLike", this._NameLike);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("engineTypeEqual", this._EngineTypeEqual);
			kparams.AddIfNotNull("engineTypeIn", this._EngineTypeIn);
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
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case PARTNER_ID_IN:
					return "PartnerIdIn";
				case NAME_EQUAL:
					return "NameEqual";
				case NAME_LIKE:
					return "NameLike";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case ENGINE_TYPE_EQUAL:
					return "EngineTypeEqual";
				case ENGINE_TYPE_IN:
					return "EngineTypeIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

