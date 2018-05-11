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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class GroupUser : ObjectBase
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string GROUP_ID = "groupId";
		public const string STATUS = "status";
		public const string PARTNER_ID = "partnerId";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string CREATION_MODE = "creationMode";
		#endregion

		#region Private Fields
		private string _UserId = null;
		private string _GroupId = null;
		private GroupUserStatus _Status = (GroupUserStatus)Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private GroupUserCreationMode _CreationMode = (GroupUserCreationMode)Int32.MinValue;
		#endregion

		#region Properties
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public string GroupId
		{
			get { return _GroupId; }
			set 
			{ 
				_GroupId = value;
				OnPropertyChanged("GroupId");
			}
		}
		public GroupUserStatus Status
		{
			get { return _Status; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public GroupUserCreationMode CreationMode
		{
			get { return _CreationMode; }
			set 
			{ 
				_CreationMode = value;
				OnPropertyChanged("CreationMode");
			}
		}
		#endregion

		#region CTor
		public GroupUser()
		{
		}

		public GroupUser(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "groupId":
						this._GroupId = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (GroupUserStatus)ParseEnum(typeof(GroupUserStatus), propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "creationMode":
						this._CreationMode = (GroupUserCreationMode)ParseEnum(typeof(GroupUserCreationMode), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaGroupUser");
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("groupId", this._GroupId);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("creationMode", this._CreationMode);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_ID:
					return "UserId";
				case GROUP_ID:
					return "GroupId";
				case STATUS:
					return "Status";
				case PARTNER_ID:
					return "PartnerId";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case CREATION_MODE:
					return "CreationMode";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

