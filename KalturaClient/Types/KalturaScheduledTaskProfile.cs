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
	public class KalturaScheduledTaskProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private KalturaScheduledTaskProfileStatus _Status = (KalturaScheduledTaskProfileStatus)Int32.MinValue;
		private KalturaObjectFilterEngineType _ObjectFilterEngineType = null;
		private KalturaFilter _ObjectFilter;
		private IList<KalturaObjectTask> _ObjectTasks;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _LastExecutionStartedAt = Int32.MinValue;
		private int _MaxTotalCountAllowed = Int32.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
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
		public KalturaScheduledTaskProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaObjectFilterEngineType ObjectFilterEngineType
		{
			get { return _ObjectFilterEngineType; }
			set 
			{ 
				_ObjectFilterEngineType = value;
				OnPropertyChanged("ObjectFilterEngineType");
			}
		}
		public KalturaFilter ObjectFilter
		{
			get { return _ObjectFilter; }
			set 
			{ 
				_ObjectFilter = value;
				OnPropertyChanged("ObjectFilter");
			}
		}
		public new IList<KalturaObjectTask> ObjectTasks
		{
			get { return _ObjectTasks; }
			set 
			{ 
				_ObjectTasks = value;
				OnPropertyChanged("ObjectTasks");
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
		public int LastExecutionStartedAt
		{
			get { return _LastExecutionStartedAt; }
			set 
			{ 
				_LastExecutionStartedAt = value;
				OnPropertyChanged("LastExecutionStartedAt");
			}
		}
		public int MaxTotalCountAllowed
		{
			get { return _MaxTotalCountAllowed; }
			set 
			{ 
				_MaxTotalCountAllowed = value;
				OnPropertyChanged("MaxTotalCountAllowed");
			}
		}
		#endregion

		#region CTor
		public KalturaScheduledTaskProfile()
		{
		}

		public KalturaScheduledTaskProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "systemName":
						this._SystemName = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "status":
						this._Status = (KalturaScheduledTaskProfileStatus)ParseEnum(typeof(KalturaScheduledTaskProfileStatus), txt);
						continue;
					case "objectFilterEngineType":
						this._ObjectFilterEngineType = (KalturaObjectFilterEngineType)KalturaStringEnum.Parse(typeof(KalturaObjectFilterEngineType), txt);
						continue;
					case "objectFilter":
						this._ObjectFilter = (KalturaFilter)KalturaObjectFactory.Create(propertyNode, "KalturaFilter");
						continue;
					case "objectTasks":
						this._ObjectTasks = new List<KalturaObjectTask>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._ObjectTasks.Add((KalturaObjectTask)KalturaObjectFactory.Create(arrayNode, "KalturaObjectTask"));
						}
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "lastExecutionStartedAt":
						this._LastExecutionStartedAt = ParseInt(txt);
						continue;
					case "maxTotalCountAllowed":
						this._MaxTotalCountAllowed = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaScheduledTaskProfile");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("systemName", this.SystemName);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("objectFilterEngineType", this.ObjectFilterEngineType);
			kparams.AddIfNotNull("objectFilter", this.ObjectFilter);
			kparams.AddIfNotNull("objectTasks", this.ObjectTasks);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("lastExecutionStartedAt", this.LastExecutionStartedAt);
			kparams.AddIfNotNull("maxTotalCountAllowed", this.MaxTotalCountAllowed);
			return kparams;
		}
		#endregion
	}
}

