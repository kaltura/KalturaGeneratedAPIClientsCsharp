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
	public class KalturaBulkUploadResultScheduleResource : KalturaBulkUploadResult
	{
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
		public KalturaBulkUploadResultScheduleResource()
		{
		}

		public KalturaBulkUploadResultScheduleResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "resourceId":
						this.ResourceId = txt;
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "type":
						this.Type = txt;
						continue;
					case "systemName":
						this.SystemName = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "parentType":
						this.ParentType = txt;
						continue;
					case "parentSystemName":
						this.ParentSystemName = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBulkUploadResultScheduleResource");
			kparams.AddIfNotNull("resourceId", this.ResourceId);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("systemName", this.SystemName);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("tags", this.Tags);
			kparams.AddIfNotNull("parentType", this.ParentType);
			kparams.AddIfNotNull("parentSystemName", this.ParentSystemName);
			return kparams;
		}
		#endregion
	}
}

