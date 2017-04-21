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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class Metadata : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string METADATA_PROFILE_VERSION = "metadataProfileVersion";
		public const string METADATA_OBJECT_TYPE = "metadataObjectType";
		public const string OBJECT_ID = "objectId";
		public const string VERSION = "version";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string STATUS = "status";
		public const string XML = "xml";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _MetadataProfileId = Int32.MinValue;
		private int _MetadataProfileVersion = Int32.MinValue;
		private MetadataObjectType _MetadataObjectType = null;
		private string _ObjectId = null;
		private int _Version = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private MetadataStatus _Status = (MetadataStatus)Int32.MinValue;
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
		public MetadataObjectType MetadataObjectType
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
		public MetadataStatus Status
		{
			get { return _Status; }
		}
		public string Xml
		{
			get { return _Xml; }
		}
		#endregion

		#region CTor
		public Metadata()
		{
		}

		public Metadata(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "metadataProfileId":
						this._MetadataProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "metadataProfileVersion":
						this._MetadataProfileVersion = ParseInt(propertyNode.InnerText);
						continue;
					case "metadataObjectType":
						this._MetadataObjectType = (MetadataObjectType)StringEnum.Parse(typeof(MetadataObjectType), propertyNode.InnerText);
						continue;
					case "objectId":
						this._ObjectId = propertyNode.InnerText;
						continue;
					case "version":
						this._Version = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (MetadataStatus)ParseEnum(typeof(MetadataStatus), propertyNode.InnerText);
						continue;
					case "xml":
						this._Xml = propertyNode.InnerText;
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
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				case METADATA_PROFILE_VERSION:
					return "MetadataProfileVersion";
				case METADATA_OBJECT_TYPE:
					return "MetadataObjectType";
				case OBJECT_ID:
					return "ObjectId";
				case VERSION:
					return "Version";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case STATUS:
					return "Status";
				case XML:
					return "Xml";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

