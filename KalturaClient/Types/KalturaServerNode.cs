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
	public class KalturaServerNode : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _HeartbeatTime = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private string _HostName = null;
		private KalturaServerNodeStatus _Status = (KalturaServerNodeStatus)Int32.MinValue;
		private KalturaServerNodeType _Type = null;
		private string _Tags = null;
		private int _Dc = Int32.MinValue;
		private int _ParentId = Int32.MinValue;
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
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int HeartbeatTime
		{
			get { return _HeartbeatTime; }
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
		public string HostName
		{
			get { return _HostName; }
			set 
			{ 
				_HostName = value;
				OnPropertyChanged("HostName");
			}
		}
		public KalturaServerNodeStatus Status
		{
			get { return _Status; }
		}
		public KalturaServerNodeType Type
		{
			get { return _Type; }
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
		public int Dc
		{
			get { return _Dc; }
		}
		public int ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		#endregion

		#region CTor
		public KalturaServerNode()
		{
		}

		public KalturaServerNode(XmlElement node) : base(node)
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
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "heartbeatTime":
						this._HeartbeatTime = ParseInt(txt);
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
					case "hostName":
						this._HostName = txt;
						continue;
					case "status":
						this._Status = (KalturaServerNodeStatus)ParseEnum(typeof(KalturaServerNodeStatus), txt);
						continue;
					case "type":
						this._Type = (KalturaServerNodeType)KalturaStringEnum.Parse(typeof(KalturaServerNodeType), txt);
						continue;
					case "tags":
						this._Tags = txt;
						continue;
					case "dc":
						this._Dc = ParseInt(txt);
						continue;
					case "parentId":
						this._ParentId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaServerNode");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("heartbeatTime", this.HeartbeatTime);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("systemName", this.SystemName);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("hostName", this.HostName);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("tags", this.Tags);
			kparams.AddIfNotNull("dc", this.Dc);
			kparams.AddIfNotNull("parentId", this.ParentId);
			return kparams;
		}
		#endregion
	}
}

