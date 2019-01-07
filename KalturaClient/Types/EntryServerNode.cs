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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class EntryServerNode : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string ENTRY_ID = "entryId";
		public const string SERVER_NODE_ID = "serverNodeId";
		public const string PARTNER_ID = "partnerId";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string STATUS = "status";
		public const string SERVER_TYPE = "serverType";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _EntryId = null;
		private int _ServerNodeId = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private EntryServerNodeStatus _Status = (EntryServerNodeStatus)Int32.MinValue;
		private EntryServerNodeType _ServerType = null;
		#endregion

		#region Properties
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
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			private set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		[JsonProperty]
		public int ServerNodeId
		{
			get { return _ServerNodeId; }
			private set 
			{ 
				_ServerNodeId = value;
				OnPropertyChanged("ServerNodeId");
			}
		}
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
		[JsonProperty]
		public EntryServerNodeStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public EntryServerNodeType ServerType
		{
			get { return _ServerType; }
			private set 
			{ 
				_ServerType = value;
				OnPropertyChanged("ServerType");
			}
		}
		#endregion

		#region CTor
		public EntryServerNode()
		{
		}

		public EntryServerNode(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["serverNodeId"] != null)
			{
				this._ServerNodeId = ParseInt(node["serverNodeId"].Value<string>());
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
			if(node["status"] != null)
			{
				this._Status = (EntryServerNodeStatus)ParseEnum(typeof(EntryServerNodeStatus), node["status"].Value<string>());
			}
			if(node["serverType"] != null)
			{
				this._ServerType = (EntryServerNodeType)StringEnum.Parse(typeof(EntryServerNodeType), node["serverType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryServerNode");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("serverNodeId", this._ServerNodeId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("serverType", this._ServerType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case ENTRY_ID:
					return "EntryId";
				case SERVER_NODE_ID:
					return "ServerNodeId";
				case PARTNER_ID:
					return "PartnerId";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case STATUS:
					return "Status";
				case SERVER_TYPE:
					return "ServerType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

