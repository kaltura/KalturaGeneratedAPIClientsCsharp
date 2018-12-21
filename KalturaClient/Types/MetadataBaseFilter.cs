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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class MetadataBaseFilter : RelatedFilter
	{
		#region Constants
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string METADATA_PROFILE_ID_EQUAL = "metadataProfileIdEqual";
		public const string METADATA_PROFILE_ID_IN = "metadataProfileIdIn";
		public const string METADATA_PROFILE_VERSION_EQUAL = "metadataProfileVersionEqual";
		public const string METADATA_PROFILE_VERSION_GREATER_THAN_OR_EQUAL = "metadataProfileVersionGreaterThanOrEqual";
		public const string METADATA_PROFILE_VERSION_LESS_THAN_OR_EQUAL = "metadataProfileVersionLessThanOrEqual";
		public const string METADATA_OBJECT_TYPE_EQUAL = "metadataObjectTypeEqual";
		public const string OBJECT_ID_EQUAL = "objectIdEqual";
		public const string OBJECT_ID_IN = "objectIdIn";
		public const string VERSION_EQUAL = "versionEqual";
		public const string VERSION_GREATER_THAN_OR_EQUAL = "versionGreaterThanOrEqual";
		public const string VERSION_LESS_THAN_OR_EQUAL = "versionLessThanOrEqual";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		#endregion

		#region Private Fields
		private int _PartnerIdEqual = Int32.MinValue;
		private int _MetadataProfileIdEqual = Int32.MinValue;
		private string _MetadataProfileIdIn = null;
		private int _MetadataProfileVersionEqual = Int32.MinValue;
		private int _MetadataProfileVersionGreaterThanOrEqual = Int32.MinValue;
		private int _MetadataProfileVersionLessThanOrEqual = Int32.MinValue;
		private MetadataObjectType _MetadataObjectTypeEqual = null;
		private string _ObjectIdEqual = null;
		private string _ObjectIdIn = null;
		private int _VersionEqual = Int32.MinValue;
		private int _VersionGreaterThanOrEqual = Int32.MinValue;
		private int _VersionLessThanOrEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private MetadataStatus _StatusEqual = (MetadataStatus)Int32.MinValue;
		private string _StatusIn = null;
		#endregion

		#region Properties
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
		public int MetadataProfileIdEqual
		{
			get { return _MetadataProfileIdEqual; }
			set 
			{ 
				_MetadataProfileIdEqual = value;
				OnPropertyChanged("MetadataProfileIdEqual");
			}
		}
		[JsonProperty]
		public string MetadataProfileIdIn
		{
			get { return _MetadataProfileIdIn; }
			set 
			{ 
				_MetadataProfileIdIn = value;
				OnPropertyChanged("MetadataProfileIdIn");
			}
		}
		[JsonProperty]
		public int MetadataProfileVersionEqual
		{
			get { return _MetadataProfileVersionEqual; }
			set 
			{ 
				_MetadataProfileVersionEqual = value;
				OnPropertyChanged("MetadataProfileVersionEqual");
			}
		}
		[JsonProperty]
		public int MetadataProfileVersionGreaterThanOrEqual
		{
			get { return _MetadataProfileVersionGreaterThanOrEqual; }
			set 
			{ 
				_MetadataProfileVersionGreaterThanOrEqual = value;
				OnPropertyChanged("MetadataProfileVersionGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int MetadataProfileVersionLessThanOrEqual
		{
			get { return _MetadataProfileVersionLessThanOrEqual; }
			set 
			{ 
				_MetadataProfileVersionLessThanOrEqual = value;
				OnPropertyChanged("MetadataProfileVersionLessThanOrEqual");
			}
		}
		[JsonProperty]
		public MetadataObjectType MetadataObjectTypeEqual
		{
			get { return _MetadataObjectTypeEqual; }
			set 
			{ 
				_MetadataObjectTypeEqual = value;
				OnPropertyChanged("MetadataObjectTypeEqual");
			}
		}
		[JsonProperty]
		public string ObjectIdEqual
		{
			get { return _ObjectIdEqual; }
			set 
			{ 
				_ObjectIdEqual = value;
				OnPropertyChanged("ObjectIdEqual");
			}
		}
		[JsonProperty]
		public string ObjectIdIn
		{
			get { return _ObjectIdIn; }
			set 
			{ 
				_ObjectIdIn = value;
				OnPropertyChanged("ObjectIdIn");
			}
		}
		[JsonProperty]
		public int VersionEqual
		{
			get { return _VersionEqual; }
			set 
			{ 
				_VersionEqual = value;
				OnPropertyChanged("VersionEqual");
			}
		}
		[JsonProperty]
		public int VersionGreaterThanOrEqual
		{
			get { return _VersionGreaterThanOrEqual; }
			set 
			{ 
				_VersionGreaterThanOrEqual = value;
				OnPropertyChanged("VersionGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int VersionLessThanOrEqual
		{
			get { return _VersionLessThanOrEqual; }
			set 
			{ 
				_VersionLessThanOrEqual = value;
				OnPropertyChanged("VersionLessThanOrEqual");
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
		public MetadataStatus StatusEqual
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
		public MetadataBaseFilter()
		{
		}

		public MetadataBaseFilter(JToken node) : base(node)
		{
			if(node["partnerIdEqual"] != null)
			{
				this._PartnerIdEqual = ParseInt(node["partnerIdEqual"].Value<string>());
			}
			if(node["metadataProfileIdEqual"] != null)
			{
				this._MetadataProfileIdEqual = ParseInt(node["metadataProfileIdEqual"].Value<string>());
			}
			if(node["metadataProfileIdIn"] != null)
			{
				this._MetadataProfileIdIn = node["metadataProfileIdIn"].Value<string>();
			}
			if(node["metadataProfileVersionEqual"] != null)
			{
				this._MetadataProfileVersionEqual = ParseInt(node["metadataProfileVersionEqual"].Value<string>());
			}
			if(node["metadataProfileVersionGreaterThanOrEqual"] != null)
			{
				this._MetadataProfileVersionGreaterThanOrEqual = ParseInt(node["metadataProfileVersionGreaterThanOrEqual"].Value<string>());
			}
			if(node["metadataProfileVersionLessThanOrEqual"] != null)
			{
				this._MetadataProfileVersionLessThanOrEqual = ParseInt(node["metadataProfileVersionLessThanOrEqual"].Value<string>());
			}
			if(node["metadataObjectTypeEqual"] != null)
			{
				this._MetadataObjectTypeEqual = (MetadataObjectType)StringEnum.Parse(typeof(MetadataObjectType), node["metadataObjectTypeEqual"].Value<string>());
			}
			if(node["objectIdEqual"] != null)
			{
				this._ObjectIdEqual = node["objectIdEqual"].Value<string>();
			}
			if(node["objectIdIn"] != null)
			{
				this._ObjectIdIn = node["objectIdIn"].Value<string>();
			}
			if(node["versionEqual"] != null)
			{
				this._VersionEqual = ParseInt(node["versionEqual"].Value<string>());
			}
			if(node["versionGreaterThanOrEqual"] != null)
			{
				this._VersionGreaterThanOrEqual = ParseInt(node["versionGreaterThanOrEqual"].Value<string>());
			}
			if(node["versionLessThanOrEqual"] != null)
			{
				this._VersionLessThanOrEqual = ParseInt(node["versionLessThanOrEqual"].Value<string>());
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
				this._StatusEqual = (MetadataStatus)ParseEnum(typeof(MetadataStatus), node["statusEqual"].Value<string>());
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
				kparams.AddReplace("objectType", "KalturaMetadataBaseFilter");
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("metadataProfileIdEqual", this._MetadataProfileIdEqual);
			kparams.AddIfNotNull("metadataProfileIdIn", this._MetadataProfileIdIn);
			kparams.AddIfNotNull("metadataProfileVersionEqual", this._MetadataProfileVersionEqual);
			kparams.AddIfNotNull("metadataProfileVersionGreaterThanOrEqual", this._MetadataProfileVersionGreaterThanOrEqual);
			kparams.AddIfNotNull("metadataProfileVersionLessThanOrEqual", this._MetadataProfileVersionLessThanOrEqual);
			kparams.AddIfNotNull("metadataObjectTypeEqual", this._MetadataObjectTypeEqual);
			kparams.AddIfNotNull("objectIdEqual", this._ObjectIdEqual);
			kparams.AddIfNotNull("objectIdIn", this._ObjectIdIn);
			kparams.AddIfNotNull("versionEqual", this._VersionEqual);
			kparams.AddIfNotNull("versionGreaterThanOrEqual", this._VersionGreaterThanOrEqual);
			kparams.AddIfNotNull("versionLessThanOrEqual", this._VersionLessThanOrEqual);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case METADATA_PROFILE_ID_EQUAL:
					return "MetadataProfileIdEqual";
				case METADATA_PROFILE_ID_IN:
					return "MetadataProfileIdIn";
				case METADATA_PROFILE_VERSION_EQUAL:
					return "MetadataProfileVersionEqual";
				case METADATA_PROFILE_VERSION_GREATER_THAN_OR_EQUAL:
					return "MetadataProfileVersionGreaterThanOrEqual";
				case METADATA_PROFILE_VERSION_LESS_THAN_OR_EQUAL:
					return "MetadataProfileVersionLessThanOrEqual";
				case METADATA_OBJECT_TYPE_EQUAL:
					return "MetadataObjectTypeEqual";
				case OBJECT_ID_EQUAL:
					return "ObjectIdEqual";
				case OBJECT_ID_IN:
					return "ObjectIdIn";
				case VERSION_EQUAL:
					return "VersionEqual";
				case VERSION_GREATER_THAN_OR_EQUAL:
					return "VersionGreaterThanOrEqual";
				case VERSION_LESS_THAN_OR_EQUAL:
					return "VersionLessThanOrEqual";
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

