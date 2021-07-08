// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
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
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		/// <summary>
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		/// <summary>
		/// Use HeartbeatTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int HeartbeatTime
		{
			get { return _HeartbeatTime; }
			private set 
			{ 
				_HeartbeatTime = value;
				OnPropertyChanged("HeartbeatTime");
			}
		}
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use SystemNameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use HostNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string HostName
		{
			get { return _HostName; }
			set 
			{ 
				_HostName = value;
				OnPropertyChanged("HostName");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ServerNodeStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use TypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ServerNodeType Type
		{
			get { return _Type; }
			private set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		/// <summary>
		/// Use TagsAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use DcAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Dc
		{
			get { return _Dc; }
			private set 
			{ 
				_Dc = value;
				OnPropertyChanged("Dc");
			}
		}
		/// <summary>
		/// Use ParentIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		/// <summary>
		/// Use EnvironmentAsDouble property instead
		/// </summary>
		[JsonProperty]
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

		public ServerNode(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["heartbeatTime"] != null)
			{
				this._HeartbeatTime = ParseInt(node["heartbeatTime"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["hostName"] != null)
			{
				this._HostName = node["hostName"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (ServerNodeStatus)ParseEnum(typeof(ServerNodeStatus), node["status"].Value<string>());
			}
			if(node["type"] != null)
			{
				this._Type = (ServerNodeType)StringEnum.Parse(typeof(ServerNodeType), node["type"].Value<string>());
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["dc"] != null)
			{
				this._Dc = ParseInt(node["dc"].Value<string>());
			}
			if(node["parentId"] != null)
			{
				this._ParentId = node["parentId"].Value<string>();
			}
			if(node["environment"] != null)
			{
				this._Environment = node["environment"].Value<string>();
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

