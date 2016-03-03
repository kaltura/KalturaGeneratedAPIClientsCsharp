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

namespace Kaltura
{
	public class KalturaMetadataBaseFilter : KalturaRelatedFilter
	{
		#region Private Fields
		private int _PartnerIdEqual = Int32.MinValue;
		private int _MetadataProfileIdEqual = Int32.MinValue;
		private string _MetadataProfileIdIn = null;
		private int _MetadataProfileVersionEqual = Int32.MinValue;
		private int _MetadataProfileVersionGreaterThanOrEqual = Int32.MinValue;
		private int _MetadataProfileVersionLessThanOrEqual = Int32.MinValue;
		private KalturaMetadataObjectType _MetadataObjectTypeEqual = null;
		private string _ObjectIdEqual = null;
		private string _ObjectIdIn = null;
		private int _VersionEqual = Int32.MinValue;
		private int _VersionGreaterThanOrEqual = Int32.MinValue;
		private int _VersionLessThanOrEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private KalturaMetadataStatus _StatusEqual = (KalturaMetadataStatus)Int32.MinValue;
		private string _StatusIn = null;
		#endregion

		#region Properties
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public int MetadataProfileIdEqual
		{
			get { return _MetadataProfileIdEqual; }
			set 
			{ 
				_MetadataProfileIdEqual = value;
				OnPropertyChanged("MetadataProfileIdEqual");
			}
		}
		public string MetadataProfileIdIn
		{
			get { return _MetadataProfileIdIn; }
			set 
			{ 
				_MetadataProfileIdIn = value;
				OnPropertyChanged("MetadataProfileIdIn");
			}
		}
		public int MetadataProfileVersionEqual
		{
			get { return _MetadataProfileVersionEqual; }
			set 
			{ 
				_MetadataProfileVersionEqual = value;
				OnPropertyChanged("MetadataProfileVersionEqual");
			}
		}
		public int MetadataProfileVersionGreaterThanOrEqual
		{
			get { return _MetadataProfileVersionGreaterThanOrEqual; }
			set 
			{ 
				_MetadataProfileVersionGreaterThanOrEqual = value;
				OnPropertyChanged("MetadataProfileVersionGreaterThanOrEqual");
			}
		}
		public int MetadataProfileVersionLessThanOrEqual
		{
			get { return _MetadataProfileVersionLessThanOrEqual; }
			set 
			{ 
				_MetadataProfileVersionLessThanOrEqual = value;
				OnPropertyChanged("MetadataProfileVersionLessThanOrEqual");
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
		public string ObjectIdEqual
		{
			get { return _ObjectIdEqual; }
			set 
			{ 
				_ObjectIdEqual = value;
				OnPropertyChanged("ObjectIdEqual");
			}
		}
		public string ObjectIdIn
		{
			get { return _ObjectIdIn; }
			set 
			{ 
				_ObjectIdIn = value;
				OnPropertyChanged("ObjectIdIn");
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
		public int VersionGreaterThanOrEqual
		{
			get { return _VersionGreaterThanOrEqual; }
			set 
			{ 
				_VersionGreaterThanOrEqual = value;
				OnPropertyChanged("VersionGreaterThanOrEqual");
			}
		}
		public int VersionLessThanOrEqual
		{
			get { return _VersionLessThanOrEqual; }
			set 
			{ 
				_VersionLessThanOrEqual = value;
				OnPropertyChanged("VersionLessThanOrEqual");
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
		public KalturaMetadataStatus StatusEqual
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
		#endregion

		#region CTor
		public KalturaMetadataBaseFilter()
		{
		}

		public KalturaMetadataBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "metadataProfileIdEqual":
						this.MetadataProfileIdEqual = ParseInt(txt);
						continue;
					case "metadataProfileIdIn":
						this.MetadataProfileIdIn = txt;
						continue;
					case "metadataProfileVersionEqual":
						this.MetadataProfileVersionEqual = ParseInt(txt);
						continue;
					case "metadataProfileVersionGreaterThanOrEqual":
						this.MetadataProfileVersionGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "metadataProfileVersionLessThanOrEqual":
						this.MetadataProfileVersionLessThanOrEqual = ParseInt(txt);
						continue;
					case "metadataObjectTypeEqual":
						this.MetadataObjectTypeEqual = (KalturaMetadataObjectType)KalturaStringEnum.Parse(typeof(KalturaMetadataObjectType), txt);
						continue;
					case "objectIdEqual":
						this.ObjectIdEqual = txt;
						continue;
					case "objectIdIn":
						this.ObjectIdIn = txt;
						continue;
					case "versionEqual":
						this.VersionEqual = ParseInt(txt);
						continue;
					case "versionGreaterThanOrEqual":
						this.VersionGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "versionLessThanOrEqual":
						this.VersionLessThanOrEqual = ParseInt(txt);
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
						this.StatusEqual = (KalturaMetadataStatus)ParseEnum(typeof(KalturaMetadataStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaMetadataBaseFilter");
			kparams.AddIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddIfNotNull("metadataProfileIdEqual", this.MetadataProfileIdEqual);
			kparams.AddIfNotNull("metadataProfileIdIn", this.MetadataProfileIdIn);
			kparams.AddIfNotNull("metadataProfileVersionEqual", this.MetadataProfileVersionEqual);
			kparams.AddIfNotNull("metadataProfileVersionGreaterThanOrEqual", this.MetadataProfileVersionGreaterThanOrEqual);
			kparams.AddIfNotNull("metadataProfileVersionLessThanOrEqual", this.MetadataProfileVersionLessThanOrEqual);
			kparams.AddIfNotNull("metadataObjectTypeEqual", this.MetadataObjectTypeEqual);
			kparams.AddIfNotNull("objectIdEqual", this.ObjectIdEqual);
			kparams.AddIfNotNull("objectIdIn", this.ObjectIdIn);
			kparams.AddIfNotNull("versionEqual", this.VersionEqual);
			kparams.AddIfNotNull("versionGreaterThanOrEqual", this.VersionGreaterThanOrEqual);
			kparams.AddIfNotNull("versionLessThanOrEqual", this.VersionLessThanOrEqual);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			return kparams;
		}
		#endregion
	}
}

