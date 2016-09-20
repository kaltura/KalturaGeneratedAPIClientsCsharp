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
	public class KalturaEntryServerNode : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _EntryId = null;
		private int _ServerNodeId = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private KalturaEntryServerNodeStatus _Status = (KalturaEntryServerNodeStatus)Int32.MinValue;
		private KalturaEntryServerNodeType _ServerType = null;
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
		public KalturaEntryServerNodeStatus Status
		{
			get { return _Status; }
		}
		public KalturaEntryServerNodeType ServerType
		{
			get { return _ServerType; }
		}
		#endregion

		#region CTor
		public KalturaEntryServerNode()
		{
		}

		public KalturaEntryServerNode(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "entryId":
						this._EntryId = txt;
						continue;
					case "serverNodeId":
						this._ServerNodeId = ParseInt(txt);
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
					case "status":
						this._Status = (KalturaEntryServerNodeStatus)ParseEnum(typeof(KalturaEntryServerNodeStatus), txt);
						continue;
					case "serverType":
						this._ServerType = (KalturaEntryServerNodeType)KalturaStringEnum.Parse(typeof(KalturaEntryServerNodeType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEntryServerNode");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("entryId", this.EntryId);
			kparams.AddIfNotNull("serverNodeId", this.ServerNodeId);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("serverType", this.ServerType);
			return kparams;
		}
		#endregion
	}
}

