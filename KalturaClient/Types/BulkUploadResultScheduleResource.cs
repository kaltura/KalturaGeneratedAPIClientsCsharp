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
	public class BulkUploadResultScheduleResource : BulkUploadResult
	{
		#region Constants
		public const string RESOURCE_ID = "resourceId";
		public const string NAME = "name";
		public const string TYPE = "type";
		public const string SYSTEM_NAME = "systemName";
		public const string DESCRIPTION = "description";
		public const string TAGS = "tags";
		public const string PARENT_TYPE = "parentType";
		public const string PARENT_SYSTEM_NAME = "parentSystemName";
		#endregion

		#region Private Fields
		private string _ResourceId = null;
		private string _Name = null;
		private string _Type = null;
		private string _SystemName = null;
		private string _Description = null;
		private string _Tags = null;
		private string _ParentType = null;
		private string _ParentSystemName = null;
		#endregion

		#region Properties
		public string ResourceId
		{
			get { return _ResourceId; }
			set 
			{ 
				_ResourceId = value;
				OnPropertyChanged("ResourceId");
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
		public string Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
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
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string ParentType
		{
			get { return _ParentType; }
			set 
			{ 
				_ParentType = value;
				OnPropertyChanged("ParentType");
			}
		}
		public string ParentSystemName
		{
			get { return _ParentSystemName; }
			set 
			{ 
				_ParentSystemName = value;
				OnPropertyChanged("ParentSystemName");
			}
		}
		#endregion

		#region CTor
		public BulkUploadResultScheduleResource()
		{
		}

		public BulkUploadResultScheduleResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "resourceId":
						this._ResourceId = propertyNode.InnerText;
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "type":
						this._Type = propertyNode.InnerText;
						continue;
					case "systemName":
						this._SystemName = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "parentType":
						this._ParentType = propertyNode.InnerText;
						continue;
					case "parentSystemName":
						this._ParentSystemName = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaBulkUploadResultScheduleResource");
			kparams.AddIfNotNull("resourceId", this._ResourceId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("parentType", this._ParentType);
			kparams.AddIfNotNull("parentSystemName", this._ParentSystemName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RESOURCE_ID:
					return "ResourceId";
				case NAME:
					return "Name";
				case TYPE:
					return "Type";
				case SYSTEM_NAME:
					return "SystemName";
				case DESCRIPTION:
					return "Description";
				case TAGS:
					return "Tags";
				case PARENT_TYPE:
					return "ParentType";
				case PARENT_SYSTEM_NAME:
					return "ParentSystemName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

