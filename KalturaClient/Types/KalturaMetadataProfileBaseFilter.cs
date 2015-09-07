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
	public class KalturaMetadataProfileBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private int _PartnerIdEqual = Int32.MinValue;
		private KalturaMetadataObjectType _MetadataObjectTypeEqual = null;
		private string _MetadataObjectTypeIn = null;
		private int _VersionEqual = Int32.MinValue;
		private string _NameEqual = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private KalturaMetadataProfileStatus _StatusEqual = (KalturaMetadataProfileStatus)Int32.MinValue;
		private string _StatusIn = null;
		private KalturaMetadataProfileCreateMode _CreateModeEqual = (KalturaMetadataProfileCreateMode)Int32.MinValue;
		private KalturaMetadataProfileCreateMode _CreateModeNotEqual = (KalturaMetadataProfileCreateMode)Int32.MinValue;
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
		public KalturaMetadataObjectType MetadataObjectTypeEqual
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
		public KalturaMetadataProfileStatus StatusEqual
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
		public KalturaMetadataProfileCreateMode CreateModeEqual
		{
			get { return _CreateModeEqual; }
			set 
			{ 
				_CreateModeEqual = value;
				OnPropertyChanged("CreateModeEqual");
			}
		}
		public KalturaMetadataProfileCreateMode CreateModeNotEqual
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
		public KalturaMetadataProfileBaseFilter()
		{
		}

		public KalturaMetadataProfileBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = ParseInt(txt);
						continue;
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "metadataObjectTypeEqual":
						this.MetadataObjectTypeEqual = (KalturaMetadataObjectType)KalturaStringEnum.Parse(typeof(KalturaMetadataObjectType), txt);
						continue;
					case "metadataObjectTypeIn":
						this.MetadataObjectTypeIn = txt;
						continue;
					case "versionEqual":
						this.VersionEqual = ParseInt(txt);
						continue;
					case "nameEqual":
						this.NameEqual = txt;
						continue;
					case "systemNameEqual":
						this.SystemNameEqual = txt;
						continue;
					case "systemNameIn":
						this.SystemNameIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this.UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this.UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaMetadataProfileStatus)ParseEnum(typeof(KalturaMetadataProfileStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "createModeEqual":
						this.CreateModeEqual = (KalturaMetadataProfileCreateMode)ParseEnum(typeof(KalturaMetadataProfileCreateMode), txt);
						continue;
					case "createModeNotEqual":
						this.CreateModeNotEqual = (KalturaMetadataProfileCreateMode)ParseEnum(typeof(KalturaMetadataProfileCreateMode), txt);
						continue;
					case "createModeIn":
						this.CreateModeIn = txt;
						continue;
					case "createModeNotIn":
						this.CreateModeNotIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaMetadataProfileBaseFilter");
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddIfNotNull("metadataObjectTypeEqual", this.MetadataObjectTypeEqual);
			kparams.AddIfNotNull("metadataObjectTypeIn", this.MetadataObjectTypeIn);
			kparams.AddIfNotNull("versionEqual", this.VersionEqual);
			kparams.AddIfNotNull("nameEqual", this.NameEqual);
			kparams.AddIfNotNull("systemNameEqual", this.SystemNameEqual);
			kparams.AddIfNotNull("systemNameIn", this.SystemNameIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			kparams.AddIfNotNull("createModeEqual", this.CreateModeEqual);
			kparams.AddIfNotNull("createModeNotEqual", this.CreateModeNotEqual);
			kparams.AddIfNotNull("createModeIn", this.CreateModeIn);
			kparams.AddIfNotNull("createModeNotIn", this.CreateModeNotIn);
			return kparams;
		}
		#endregion
	}
}

