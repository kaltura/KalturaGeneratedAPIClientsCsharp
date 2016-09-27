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
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
		}
		public int MetadataProfileVersion
		{
			get { return _MetadataProfileVersion; }
		}
		public KalturaMetadataObjectType MetadataObjectType
		{
			get { return _MetadataObjectType; }
		}
		public string ObjectId
		{
			get { return _ObjectId; }
		}
		public int Version
		{
			get { return _Version; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public KalturaMetadataStatus Status
		{
			get { return _Status; }
		}
		public string Xml
		{
			get { return _Xml; }
		}
		#endregion

		#region CTor
		public KalturaMetadata()
		{
		}

		public KalturaMetadata(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "metadataProfileId":
						this._MetadataProfileId = ParseInt(txt);
						continue;
					case "metadataProfileVersion":
						this._MetadataProfileVersion = ParseInt(txt);
						continue;
					case "metadataObjectType":
						this._MetadataObjectType = (KalturaMetadataObjectType)KalturaStringEnum.Parse(typeof(KalturaMetadataObjectType), txt);
						continue;
					case "objectId":
						this._ObjectId = txt;
						continue;
					case "version":
						this._Version = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "status":
						this._Status = (KalturaMetadataStatus)ParseEnum(typeof(KalturaMetadataStatus), txt);
						continue;
					case "xml":
						this._Xml = txt;
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
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("metadataProfileVersion", this._MetadataProfileVersion);
			kparams.AddIfNotNull("metadataObjectType", this._MetadataObjectType);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("xml", this._Xml);
			return kparams;
		}
		#endregion
	}
}

