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
	public class ESearchCategoryUserItem : ESearchAbstractCategoryItem
	{
		#region Constants
		public const string FIELD_NAME = "fieldName";
		public const string PERMISSION_LEVEL = "permissionLevel";
		public const string PERMISSION_NAME = "permissionName";
		#endregion

		#region Private Fields
		private ESearchCategoryUserFieldName _FieldName = null;
		private CategoryUserPermissionLevel _PermissionLevel = (CategoryUserPermissionLevel)Int32.MinValue;
		private string _PermissionName = null;
		#endregion

		#region Properties
		public ESearchCategoryUserFieldName FieldName
		{
			get { return _FieldName; }
			set 
			{ 
				_FieldName = value;
				OnPropertyChanged("FieldName");
			}
		}
		public CategoryUserPermissionLevel PermissionLevel
		{
			get { return _PermissionLevel; }
			set 
			{ 
				_PermissionLevel = value;
				OnPropertyChanged("PermissionLevel");
			}
		}
		public string PermissionName
		{
			get { return _PermissionName; }
			set 
			{ 
				_PermissionName = value;
				OnPropertyChanged("PermissionName");
			}
		}
		#endregion

		#region CTor
		public ESearchCategoryUserItem()
		{
		}

		public ESearchCategoryUserItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "fieldName":
						this._FieldName = (ESearchCategoryUserFieldName)StringEnum.Parse(typeof(ESearchCategoryUserFieldName), propertyNode.InnerText);
						continue;
					case "permissionLevel":
						this._PermissionLevel = (CategoryUserPermissionLevel)ParseEnum(typeof(CategoryUserPermissionLevel), propertyNode.InnerText);
						continue;
					case "permissionName":
						this._PermissionName = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaESearchCategoryUserItem");
			kparams.AddIfNotNull("fieldName", this._FieldName);
			kparams.AddIfNotNull("permissionLevel", this._PermissionLevel);
			kparams.AddIfNotNull("permissionName", this._PermissionName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FIELD_NAME:
					return "FieldName";
				case PERMISSION_LEVEL:
					return "PermissionLevel";
				case PERMISSION_NAME:
					return "PermissionName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

