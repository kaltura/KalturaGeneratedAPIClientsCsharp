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
	public class KalturaCategoryUser : KalturaObjectBase
	{
		#region Private Fields
		private int _CategoryId = Int32.MinValue;
		private string _UserId = null;
		private int _PartnerId = Int32.MinValue;
		private KalturaCategoryUserPermissionLevel _PermissionLevel = (KalturaCategoryUserPermissionLevel)Int32.MinValue;
		private KalturaCategoryUserStatus _Status = (KalturaCategoryUserStatus)Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private KalturaUpdateMethodType _UpdateMethod = (KalturaUpdateMethodType)Int32.MinValue;
		private string _CategoryFullIds = null;
		private string _PermissionNames = null;
		#endregion

		#region Properties
		public int CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
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
		public KalturaCategoryUserPermissionLevel PermissionLevel
		{
			get { return _PermissionLevel; }
			set 
			{ 
				_PermissionLevel = value;
				OnPropertyChanged("PermissionLevel");
			}
		}
		public KalturaCategoryUserStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
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
		public KalturaUpdateMethodType UpdateMethod
		{
			get { return _UpdateMethod; }
			set 
			{ 
				_UpdateMethod = value;
				OnPropertyChanged("UpdateMethod");
			}
		}
		public string CategoryFullIds
		{
			get { return _CategoryFullIds; }
			set 
			{ 
				_CategoryFullIds = value;
				OnPropertyChanged("CategoryFullIds");
			}
		}
		public string PermissionNames
		{
			get { return _PermissionNames; }
			set 
			{ 
				_PermissionNames = value;
				OnPropertyChanged("PermissionNames");
			}
		}
		#endregion

		#region CTor
		public KalturaCategoryUser()
		{
		}

		public KalturaCategoryUser(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "categoryId":
						this.CategoryId = ParseInt(txt);
						continue;
					case "userId":
						this.UserId = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "permissionLevel":
						this.PermissionLevel = (KalturaCategoryUserPermissionLevel)ParseEnum(typeof(KalturaCategoryUserPermissionLevel), txt);
						continue;
					case "status":
						this.Status = (KalturaCategoryUserStatus)ParseEnum(typeof(KalturaCategoryUserStatus), txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "updateMethod":
						this.UpdateMethod = (KalturaUpdateMethodType)ParseEnum(typeof(KalturaUpdateMethodType), txt);
						continue;
					case "categoryFullIds":
						this.CategoryFullIds = txt;
						continue;
					case "permissionNames":
						this.PermissionNames = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCategoryUser");
			kparams.AddIntIfNotNull("categoryId", this.CategoryId);
			kparams.AddStringIfNotNull("userId", this.UserId);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddEnumIfNotNull("permissionLevel", this.PermissionLevel);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddEnumIfNotNull("updateMethod", this.UpdateMethod);
			kparams.AddStringIfNotNull("categoryFullIds", this.CategoryFullIds);
			kparams.AddStringIfNotNull("permissionNames", this.PermissionNames);
			return kparams;
		}
		#endregion
	}
}

