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
	public class Asset : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string ENTRY_ID = "entryId";
		public const string PARTNER_ID = "partnerId";
		public const string VERSION = "version";
		public const string SIZE = "size";
		public const string TAGS = "tags";
		public const string FILE_EXT = "fileExt";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string DELETED_AT = "deletedAt";
		public const string DESCRIPTION = "description";
		public const string PARTNER_DATA = "partnerData";
		public const string PARTNER_DESCRIPTION = "partnerDescription";
		public const string ACTUAL_SOURCE_ASSET_PARAMS_IDS = "actualSourceAssetParamsIds";
		#endregion

		#region Private Fields
		private string _Id = null;
		private string _EntryId = null;
		private int _PartnerId = Int32.MinValue;
		private int _Version = Int32.MinValue;
		private int _Size = Int32.MinValue;
		private string _Tags = null;
		private string _FileExt = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _DeletedAt = Int32.MinValue;
		private string _Description = null;
		private string _PartnerData = null;
		private string _PartnerDescription = null;
		private string _ActualSourceAssetParamsIds = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
		}
		public string EntryId
		{
			get { return _EntryId; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int Version
		{
			get { return _Version; }
		}
		public int Size
		{
			get { return _Size; }
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string FileExt
		{
			get { return _FileExt; }
			set 
			{ 
				_FileExt = value;
				OnPropertyChanged("FileExt");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int DeletedAt
		{
			get { return _DeletedAt; }
		}
		public string Description
		{
			get { return _Description; }
		}
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		public string PartnerDescription
		{
			get { return _PartnerDescription; }
			set 
			{ 
				_PartnerDescription = value;
				OnPropertyChanged("PartnerDescription");
			}
		}
		public string ActualSourceAssetParamsIds
		{
			get { return _ActualSourceAssetParamsIds; }
			set 
			{ 
				_ActualSourceAssetParamsIds = value;
				OnPropertyChanged("ActualSourceAssetParamsIds");
			}
		}
		#endregion

		#region CTor
		public Asset()
		{
		}

		public Asset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "version":
						this._Version = ParseInt(propertyNode.InnerText);
						continue;
					case "size":
						this._Size = ParseInt(propertyNode.InnerText);
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "fileExt":
						this._FileExt = propertyNode.InnerText;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "deletedAt":
						this._DeletedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "partnerData":
						this._PartnerData = propertyNode.InnerText;
						continue;
					case "partnerDescription":
						this._PartnerDescription = propertyNode.InnerText;
						continue;
					case "actualSourceAssetParamsIds":
						this._ActualSourceAssetParamsIds = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaAsset");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("size", this._Size);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("fileExt", this._FileExt);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("deletedAt", this._DeletedAt);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("partnerData", this._PartnerData);
			kparams.AddIfNotNull("partnerDescription", this._PartnerDescription);
			kparams.AddIfNotNull("actualSourceAssetParamsIds", this._ActualSourceAssetParamsIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case ENTRY_ID:
					return "EntryId";
				case PARTNER_ID:
					return "PartnerId";
				case VERSION:
					return "Version";
				case SIZE:
					return "Size";
				case TAGS:
					return "Tags";
				case FILE_EXT:
					return "FileExt";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case DELETED_AT:
					return "DeletedAt";
				case DESCRIPTION:
					return "Description";
				case PARTNER_DATA:
					return "PartnerData";
				case PARTNER_DESCRIPTION:
					return "PartnerDescription";
				case ACTUAL_SOURCE_ASSET_PARAMS_IDS:
					return "ActualSourceAssetParamsIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

