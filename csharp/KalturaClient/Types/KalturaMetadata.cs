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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaMetadata : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _MetadataProfileId = Int32.MinValue;
		private int _MetadataProfileVersion = Int32.MinValue;
		private KalturaMetadataObjectType _MetadataObjectType = null;
		private string _ObjectId = null;
		private int _Version = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private KalturaMetadataStatus _Status = (KalturaMetadataStatus)Int32.MinValue;
		private string _Xml = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		public int MetadataProfileVersion
		{
			get { return _MetadataProfileVersion; }
			set 
			{ 
				_MetadataProfileVersion = value;
				OnPropertyChanged("MetadataProfileVersion");
			}
		}
		public KalturaMetadataObjectType MetadataObjectType
		{
			get { return _MetadataObjectType; }
			set 
			{ 
				_MetadataObjectType = value;
				OnPropertyChanged("MetadataObjectType");
			}
		}
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		public int Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		public KalturaMetadataStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string Xml
		{
			get { return _Xml; }
			set 
			{ 
				_Xml = value;
				OnPropertyChanged("Xml");
			}
		}
		#endregion

		#region CTor
		public KalturaMetadata()
		{
		}

		public KalturaMetadata(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "metadataProfileId":
						this.MetadataProfileId = ParseInt(txt);
						continue;
					case "metadataProfileVersion":
						this.MetadataProfileVersion = ParseInt(txt);
						continue;
					case "metadataObjectType":
						this.MetadataObjectType = (KalturaMetadataObjectType)KalturaStringEnum.Parse(typeof(KalturaMetadataObjectType), txt);
						continue;
					case "objectId":
						this.ObjectId = txt;
						continue;
					case "version":
						this.Version = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaMetadataStatus)ParseEnum(typeof(KalturaMetadataStatus), txt);
						continue;
					case "xml":
						this.Xml = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaMetadata");
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddIntIfNotNull("metadataProfileId", this.MetadataProfileId);
			kparams.AddIntIfNotNull("metadataProfileVersion", this.MetadataProfileVersion);
			kparams.AddStringEnumIfNotNull("metadataObjectType", this.MetadataObjectType);
			kparams.AddStringIfNotNull("objectId", this.ObjectId);
			kparams.AddIntIfNotNull("version", this.Version);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddStringIfNotNull("xml", this.Xml);
			return kparams;
		}
		#endregion
	}
}

