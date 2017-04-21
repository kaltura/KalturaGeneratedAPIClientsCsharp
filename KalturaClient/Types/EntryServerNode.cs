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
// Copyright (C) 2006-2017  Kaltura Inc.
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
		public int Id
		{
			get { return _Id; }
		}
		public string EntryId
		{
			get { return _EntryId; }
		}
		public int ServerNodeId
		{
			get { return _ServerNodeId; }
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
		public EntryServerNodeStatus Status
		{
			get { return _Status; }
		}
		public EntryServerNodeType ServerType
		{
			get { return _ServerType; }
		}
		#endregion

		#region CTor
		public EntryServerNode()
		{
		}

		public EntryServerNode(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "serverNodeId":
						this._ServerNodeId = ParseInt(propertyNode.InnerText);
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
					case "status":
						this._Status = (EntryServerNodeStatus)ParseEnum(typeof(EntryServerNodeStatus), propertyNode.InnerText);
						continue;
					case "serverType":
						this._ServerType = (EntryServerNodeType)StringEnum.Parse(typeof(EntryServerNodeType), propertyNode.InnerText);
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

