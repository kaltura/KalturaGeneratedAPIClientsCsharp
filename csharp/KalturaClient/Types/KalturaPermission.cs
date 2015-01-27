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
	public class KalturaPermission : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private KalturaPermissionType _Type = (KalturaPermissionType)Int32.MinValue;
		private string _Name = null;
		private string _FriendlyName = null;
		private string _Description = null;
		private KalturaPermissionStatus _Status = (KalturaPermissionStatus)Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _DependsOnPermissionNames = null;
		private string _Tags = null;
		private string _PermissionItemsIds = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _PartnerGroup = null;
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
		public KalturaPermissionType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string FriendlyName
		{
			get { return _FriendlyName; }
			set 
			{ 
				_FriendlyName = value;
				OnPropertyChanged("FriendlyName");
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
		public KalturaPermissionStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
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
		public string DependsOnPermissionNames
		{
			get { return _DependsOnPermissionNames; }
			set 
			{ 
				_DependsOnPermissionNames = value;
				OnPropertyChanged("DependsOnPermissionNames");
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
		public string PermissionItemsIds
		{
			get { return _PermissionItemsIds; }
			set 
			{ 
				_PermissionItemsIds = value;
				OnPropertyChanged("PermissionItemsIds");
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
		public string PartnerGroup
		{
			get { return _PartnerGroup; }
			set 
			{ 
				_PartnerGroup = value;
				OnPropertyChanged("PartnerGroup");
			}
		}
		#endregion

		#region CTor
		public KalturaPermission()
		{
		}

		public KalturaPermission(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "type":
						this.Type = (KalturaPermissionType)ParseEnum(typeof(KalturaPermissionType), txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "friendlyName":
						this.FriendlyName = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "status":
						this.Status = (KalturaPermissionStatus)ParseEnum(typeof(KalturaPermissionStatus), txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "dependsOnPermissionNames":
						this.DependsOnPermissionNames = txt;
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "permissionItemsIds":
						this.PermissionItemsIds = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "partnerGroup":
						this.PartnerGroup = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPermission");
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddEnumIfNotNull("type", this.Type);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddStringIfNotNull("friendlyName", this.FriendlyName);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("dependsOnPermissionNames", this.DependsOnPermissionNames);
			kparams.AddStringIfNotNull("tags", this.Tags);
			kparams.AddStringIfNotNull("permissionItemsIds", this.PermissionItemsIds);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddStringIfNotNull("partnerGroup", this.PartnerGroup);
			return kparams;
		}
		#endregion
	}
}

