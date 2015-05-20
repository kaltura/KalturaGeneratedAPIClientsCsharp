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
	public class KalturaAsset : KalturaObjectBase
	{
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
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
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
		public int Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		public int Size
		{
			get { return _Size; }
			set 
			{ 
				_Size = value;
				OnPropertyChanged("Size");
			}
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
		public int DeletedAt
		{
			get { return _DeletedAt; }
			set 
			{ 
				_DeletedAt = value;
				OnPropertyChanged("DeletedAt");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
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
		public KalturaAsset()
		{
		}

		public KalturaAsset(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = txt;
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "version":
						this.Version = ParseInt(txt);
						continue;
					case "size":
						this.Size = ParseInt(txt);
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "fileExt":
						this.FileExt = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "deletedAt":
						this.DeletedAt = ParseInt(txt);
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "partnerData":
						this.PartnerData = txt;
						continue;
					case "partnerDescription":
						this.PartnerDescription = txt;
						continue;
					case "actualSourceAssetParamsIds":
						this.ActualSourceAssetParamsIds = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAsset");
			kparams.AddStringIfNotNull("id", this.Id);
			kparams.AddStringIfNotNull("entryId", this.EntryId);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddIntIfNotNull("version", this.Version);
			kparams.AddIntIfNotNull("size", this.Size);
			kparams.AddStringIfNotNull("tags", this.Tags);
			kparams.AddStringIfNotNull("fileExt", this.FileExt);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIntIfNotNull("deletedAt", this.DeletedAt);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringIfNotNull("partnerData", this.PartnerData);
			kparams.AddStringIfNotNull("partnerDescription", this.PartnerDescription);
			kparams.AddStringIfNotNull("actualSourceAssetParamsIds", this.ActualSourceAssetParamsIds);
			return kparams;
		}
		#endregion
	}
}

