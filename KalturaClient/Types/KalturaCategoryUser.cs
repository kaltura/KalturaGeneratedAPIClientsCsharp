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
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
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

		public KalturaCategoryUser(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "categoryId":
						this._CategoryId = ParseInt(txt);
						continue;
					case "userId":
						this._UserId = txt;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "permissionLevel":
						this._PermissionLevel = (KalturaCategoryUserPermissionLevel)ParseEnum(typeof(KalturaCategoryUserPermissionLevel), txt);
						continue;
					case "status":
						this._Status = (KalturaCategoryUserStatus)ParseEnum(typeof(KalturaCategoryUserStatus), txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "updateMethod":
						this._UpdateMethod = (KalturaUpdateMethodType)ParseEnum(typeof(KalturaUpdateMethodType), txt);
						continue;
					case "categoryFullIds":
						this._CategoryFullIds = txt;
						continue;
					case "permissionNames":
						this._PermissionNames = txt;
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
			kparams.AddIfNotNull("categoryId", this.CategoryId);
			kparams.AddIfNotNull("userId", this.UserId);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("permissionLevel", this.PermissionLevel);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("updateMethod", this.UpdateMethod);
			kparams.AddIfNotNull("categoryFullIds", this.CategoryFullIds);
			kparams.AddIfNotNull("permissionNames", this.PermissionNames);
			return kparams;
		}
		#endregion
	}
}

