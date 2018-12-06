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
	public class ResponseProfile : DetachedResponseProfile
	{
		#region Constants
		public const string ID = "id";
		public const string SYSTEM_NAME = "systemName";
		public const string PARTNER_ID = "partnerId";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string STATUS = "status";
		public const string VERSION = "version";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private string _SystemName = null;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private ResponseProfileStatus _Status = (ResponseProfileStatus)Int32.MinValue;
		private int _Version = Int32.MinValue;
		#endregion

		#region Properties
		public long Id
		{
			get { return _Id; }
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
		public ResponseProfileStatus Status
		{
			get { return _Status; }
		}
		public int Version
		{
			get { return _Version; }
		}
		#endregion

		#region CTor
		public ResponseProfile()
		{
		}

		public ResponseProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseLong(propertyNode.InnerText);
						continue;
					case "systemName":
						this._SystemName = propertyNode.InnerText;
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
						this._Status = (ResponseProfileStatus)ParseEnum(typeof(ResponseProfileStatus), propertyNode.InnerText);
						continue;
					case "version":
						this._Version = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public ResponseProfile(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<long>("id");
			    this._SystemName = data.TryGetValueSafe<string>("systemName");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._Status = (ResponseProfileStatus)ParseEnum(typeof(ResponseProfileStatus), data.TryGetValueSafe<int>("status"));
			    this._Version = data.TryGetValueSafe<int>("version");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaResponseProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("version", this._Version);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case SYSTEM_NAME:
					return "SystemName";
				case PARTNER_ID:
					return "PartnerId";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case STATUS:
					return "Status";
				case VERSION:
					return "Version";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

