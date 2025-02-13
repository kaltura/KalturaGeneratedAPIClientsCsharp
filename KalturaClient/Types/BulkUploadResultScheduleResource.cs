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
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
		[JsonProperty]
		public string ResourceId
		{
			get { return _ResourceId; }
			set 
			{ 
				_ResourceId = value;
				OnPropertyChanged("ResourceId");
			}
		}
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public string Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		[JsonProperty]
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		[JsonProperty]
		public string ParentType
		{
			get { return _ParentType; }
			set 
			{ 
				_ParentType = value;
				OnPropertyChanged("ParentType");
			}
		}
		[JsonProperty]
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

		public BulkUploadResultScheduleResource(JToken node) : base(node)
		{
			if(node["resourceId"] != null)
			{
				this._ResourceId = node["resourceId"].Value<string>();
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["type"] != null)
			{
				this._Type = node["type"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["parentType"] != null)
			{
				this._ParentType = node["parentType"].Value<string>();
			}
			if(node["parentSystemName"] != null)
			{
				this._ParentSystemName = node["parentSystemName"].Value<string>();
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

