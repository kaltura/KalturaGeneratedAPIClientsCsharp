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

namespace Kaltura.Types
{
	public class MetadataProfileBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string METADATA_OBJECT_TYPE_EQUAL = "metadataObjectTypeEqual";
		public const string METADATA_OBJECT_TYPE_IN = "metadataObjectTypeIn";
		public const string VERSION_EQUAL = "versionEqual";
		public const string NAME_EQUAL = "nameEqual";
		public const string SYSTEM_NAME_EQUAL = "systemNameEqual";
		public const string SYSTEM_NAME_IN = "systemNameIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string CREATE_MODE_EQUAL = "createModeEqual";
		public const string CREATE_MODE_NOT_EQUAL = "createModeNotEqual";
		public const string CREATE_MODE_IN = "createModeIn";
		public const string CREATE_MODE_NOT_IN = "createModeNotIn";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private int _PartnerIdEqual = Int32.MinValue;
		private MetadataObjectType _MetadataObjectTypeEqual = null;
		private string _MetadataObjectTypeIn = null;
		private int _VersionEqual = Int32.MinValue;
		private string _NameEqual = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private MetadataProfileStatus _StatusEqual = (MetadataProfileStatus)Int32.MinValue;
		private string _StatusIn = null;
		private MetadataProfileCreateMode _CreateModeEqual = (MetadataProfileCreateMode)Int32.MinValue;
		private MetadataProfileCreateMode _CreateModeNotEqual = (MetadataProfileCreateMode)Int32.MinValue;
		private string _CreateModeIn = null;
		private string _CreateModeNotIn = null;
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
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public MetadataObjectType MetadataObjectTypeEqual
		{
			get { return _MetadataObjectTypeEqual; }
			set 
			{ 
				_MetadataObjectTypeEqual = value;
				OnPropertyChanged("MetadataObjectTypeEqual");
			}
		}
		public string MetadataObjectTypeIn
		{
			get { return _MetadataObjectTypeIn; }
			set 
			{ 
				_MetadataObjectTypeIn = value;
				OnPropertyChanged("MetadataObjectTypeIn");
			}
		}
		public int VersionEqual
		{
			get { return _VersionEqual; }
			set 
			{ 
				_VersionEqual = value;
				OnPropertyChanged("VersionEqual");
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
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public MetadataProfileStatus StatusEqual
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
		public MetadataProfileCreateMode CreateModeEqual
		{
			get { return _CreateModeEqual; }
			set 
			{ 
				_CreateModeEqual = value;
				OnPropertyChanged("CreateModeEqual");
			}
		}
		public MetadataProfileCreateMode CreateModeNotEqual
		{
			get { return _CreateModeNotEqual; }
			set 
			{ 
				_CreateModeNotEqual = value;
				OnPropertyChanged("CreateModeNotEqual");
			}
		}
		public string CreateModeIn
		{
			get { return _CreateModeIn; }
			set 
			{ 
				_CreateModeIn = value;
				OnPropertyChanged("CreateModeIn");
			}
		}
		public string CreateModeNotIn
		{
			get { return _CreateModeNotIn; }
			set 
			{ 
				_CreateModeNotIn = value;
				OnPropertyChanged("CreateModeNotIn");
			}
		}
		#endregion

		#region CTor
		public MetadataProfileBaseFilter()
		{
		}

		public MetadataProfileBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "metadataObjectTypeEqual":
						this._MetadataObjectTypeEqual = (MetadataObjectType)StringEnum.Parse(typeof(MetadataObjectType), propertyNode.InnerText);
						continue;
					case "metadataObjectTypeIn":
						this._MetadataObjectTypeIn = propertyNode.InnerText;
						continue;
					case "versionEqual":
						this._VersionEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "nameEqual":
						this._NameEqual = propertyNode.InnerText;
						continue;
					case "systemNameEqual":
						this._SystemNameEqual = propertyNode.InnerText;
						continue;
					case "systemNameIn":
						this._SystemNameIn = propertyNode.InnerText;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "statusEqual":
						this._StatusEqual = (MetadataProfileStatus)ParseEnum(typeof(MetadataProfileStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "createModeEqual":
						this._CreateModeEqual = (MetadataProfileCreateMode)ParseEnum(typeof(MetadataProfileCreateMode), propertyNode.InnerText);
						continue;
					case "createModeNotEqual":
						this._CreateModeNotEqual = (MetadataProfileCreateMode)ParseEnum(typeof(MetadataProfileCreateMode), propertyNode.InnerText);
						continue;
					case "createModeIn":
						this._CreateModeIn = propertyNode.InnerText;
						continue;
					case "createModeNotIn":
						this._CreateModeNotIn = propertyNode.InnerText;
						continue;
				}
			}
		}

		public MetadataProfileBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._IdEqual = data.TryGetValueSafe<int>("idEqual");
			    this._PartnerIdEqual = data.TryGetValueSafe<int>("partnerIdEqual");
			    this._MetadataObjectTypeEqual = (MetadataObjectType)StringEnum.Parse(typeof(MetadataObjectType), data.TryGetValueSafe<string>("metadataObjectTypeEqual"));
			    this._MetadataObjectTypeIn = data.TryGetValueSafe<string>("metadataObjectTypeIn");
			    this._VersionEqual = data.TryGetValueSafe<int>("versionEqual");
			    this._NameEqual = data.TryGetValueSafe<string>("nameEqual");
			    this._SystemNameEqual = data.TryGetValueSafe<string>("systemNameEqual");
			    this._SystemNameIn = data.TryGetValueSafe<string>("systemNameIn");
			    this._CreatedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("createdAtGreaterThanOrEqual");
			    this._CreatedAtLessThanOrEqual = data.TryGetValueSafe<int>("createdAtLessThanOrEqual");
			    this._UpdatedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("updatedAtGreaterThanOrEqual");
			    this._UpdatedAtLessThanOrEqual = data.TryGetValueSafe<int>("updatedAtLessThanOrEqual");
			    this._StatusEqual = (MetadataProfileStatus)ParseEnum(typeof(MetadataProfileStatus), data.TryGetValueSafe<int>("statusEqual"));
			    this._StatusIn = data.TryGetValueSafe<string>("statusIn");
			    this._CreateModeEqual = (MetadataProfileCreateMode)ParseEnum(typeof(MetadataProfileCreateMode), data.TryGetValueSafe<int>("createModeEqual"));
			    this._CreateModeNotEqual = (MetadataProfileCreateMode)ParseEnum(typeof(MetadataProfileCreateMode), data.TryGetValueSafe<int>("createModeNotEqual"));
			    this._CreateModeIn = data.TryGetValueSafe<string>("createModeIn");
			    this._CreateModeNotIn = data.TryGetValueSafe<string>("createModeNotIn");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMetadataProfileBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("metadataObjectTypeEqual", this._MetadataObjectTypeEqual);
			kparams.AddIfNotNull("metadataObjectTypeIn", this._MetadataObjectTypeIn);
			kparams.AddIfNotNull("versionEqual", this._VersionEqual);
			kparams.AddIfNotNull("nameEqual", this._NameEqual);
			kparams.AddIfNotNull("systemNameEqual", this._SystemNameEqual);
			kparams.AddIfNotNull("systemNameIn", this._SystemNameIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("createModeEqual", this._CreateModeEqual);
			kparams.AddIfNotNull("createModeNotEqual", this._CreateModeNotEqual);
			kparams.AddIfNotNull("createModeIn", this._CreateModeIn);
			kparams.AddIfNotNull("createModeNotIn", this._CreateModeNotIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case METADATA_OBJECT_TYPE_EQUAL:
					return "MetadataObjectTypeEqual";
				case METADATA_OBJECT_TYPE_IN:
					return "MetadataObjectTypeIn";
				case VERSION_EQUAL:
					return "VersionEqual";
				case NAME_EQUAL:
					return "NameEqual";
				case SYSTEM_NAME_EQUAL:
					return "SystemNameEqual";
				case SYSTEM_NAME_IN:
					return "SystemNameIn";
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
				case CREATE_MODE_EQUAL:
					return "CreateModeEqual";
				case CREATE_MODE_NOT_EQUAL:
					return "CreateModeNotEqual";
				case CREATE_MODE_IN:
					return "CreateModeIn";
				case CREATE_MODE_NOT_IN:
					return "CreateModeNotIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

