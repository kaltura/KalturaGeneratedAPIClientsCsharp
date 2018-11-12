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
	public class ServerNode : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string HEARTBEAT_TIME = "heartbeatTime";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string DESCRIPTION = "description";
		public const string HOST_NAME = "hostName";
		public const string STATUS = "status";
		public const string TYPE = "type";
		public const string TAGS = "tags";
		public const string DC = "dc";
		public const string PARENT_ID = "parentId";
		public const string ENVIRONMENT = "environment";
		#endregion

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
		private ServerNodeStatus _Status = (ServerNodeStatus)Int32.MinValue;
		private ServerNodeType _Type = null;
		private string _Tags = null;
		private int _Dc = Int32.MinValue;
		private string _ParentId = null;
		private string _Environment = null;
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
		public ServerNodeStatus Status
		{
			get { return _Status; }
		}
		public ServerNodeType Type
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
		public string ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		public string Environment
		{
			get { return _Environment; }
			set 
			{ 
				_Environment = value;
				OnPropertyChanged("Environment");
			}
		}
		#endregion

		#region CTor
		public ServerNode()
		{
		}

		public ServerNode(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
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
					case "heartbeatTime":
						this._HeartbeatTime = ParseInt(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "systemName":
						this._SystemName = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "hostName":
						this._HostName = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (ServerNodeStatus)ParseEnum(typeof(ServerNodeStatus), propertyNode.InnerText);
						continue;
					case "type":
						this._Type = (ServerNodeType)StringEnum.Parse(typeof(ServerNodeType), propertyNode.InnerText);
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "dc":
						this._Dc = ParseInt(propertyNode.InnerText);
						continue;
					case "parentId":
						this._ParentId = propertyNode.InnerText;
						continue;
					case "environment":
						this._Environment = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaServerNode");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("heartbeatTime", this._HeartbeatTime);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("hostName", this._HostName);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("dc", this._Dc);
			kparams.AddIfNotNull("parentId", this._ParentId);
			kparams.AddIfNotNull("environment", this._Environment);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case HEARTBEAT_TIME:
					return "HeartbeatTime";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case DESCRIPTION:
					return "Description";
				case HOST_NAME:
					return "HostName";
				case STATUS:
					return "Status";
				case TYPE:
					return "Type";
				case TAGS:
					return "Tags";
				case DC:
					return "Dc";
				case PARENT_ID:
					return "ParentId";
				case ENVIRONMENT:
					return "Environment";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

