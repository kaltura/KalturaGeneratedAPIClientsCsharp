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
	public class Beacon : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string INDEX_TYPE = "indexType";
		public const string UPDATED_AT = "updatedAt";
		public const string RELATED_OBJECT_TYPE = "relatedObjectType";
		public const string EVENT_TYPE = "eventType";
		public const string OBJECT_ID = "objectId";
		public const string PRIVATE_DATA = "privateData";
		public const string RAW_DATA = "rawData";
		#endregion

		#region Private Fields
		private string _Id = null;
		private string _IndexType = null;
		private int _UpdatedAt = Int32.MinValue;
		private BeaconObjectTypes _RelatedObjectType = null;
		private string _EventType = null;
		private string _ObjectId = null;
		private string _PrivateData = null;
		private string _RawData = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public string IndexType
		{
			get { return _IndexType; }
			private set 
			{ 
				_IndexType = value;
				OnPropertyChanged("IndexType");
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
		public BeaconObjectTypes RelatedObjectType
		{
			get { return _RelatedObjectType; }
			set 
			{ 
				_RelatedObjectType = value;
				OnPropertyChanged("RelatedObjectType");
			}
		}
		[JsonProperty]
		public string EventType
		{
			get { return _EventType; }
			set 
			{ 
				_EventType = value;
				OnPropertyChanged("EventType");
			}
		}
		[JsonProperty]
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		[JsonProperty]
		public string PrivateData
		{
			get { return _PrivateData; }
			set 
			{ 
				_PrivateData = value;
				OnPropertyChanged("PrivateData");
			}
		}
		[JsonProperty]
		public string RawData
		{
			get { return _RawData; }
			set 
			{ 
				_RawData = value;
				OnPropertyChanged("RawData");
			}
		}
		#endregion

		#region CTor
		public Beacon()
		{
		}

		public Beacon(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["indexType"] != null)
			{
				this._IndexType = node["indexType"].Value<string>();
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["relatedObjectType"] != null)
			{
				this._RelatedObjectType = (BeaconObjectTypes)StringEnum.Parse(typeof(BeaconObjectTypes), node["relatedObjectType"].Value<string>());
			}
			if(node["eventType"] != null)
			{
				this._EventType = node["eventType"].Value<string>();
			}
			if(node["objectId"] != null)
			{
				this._ObjectId = node["objectId"].Value<string>();
			}
			if(node["privateData"] != null)
			{
				this._PrivateData = node["privateData"].Value<string>();
			}
			if(node["rawData"] != null)
			{
				this._RawData = node["rawData"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBeacon");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("indexType", this._IndexType);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("relatedObjectType", this._RelatedObjectType);
			kparams.AddIfNotNull("eventType", this._EventType);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("privateData", this._PrivateData);
			kparams.AddIfNotNull("rawData", this._RawData);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case INDEX_TYPE:
					return "IndexType";
				case UPDATED_AT:
					return "UpdatedAt";
				case RELATED_OBJECT_TYPE:
					return "RelatedObjectType";
				case EVENT_TYPE:
					return "EventType";
				case OBJECT_ID:
					return "ObjectId";
				case PRIVATE_DATA:
					return "PrivateData";
				case RAW_DATA:
					return "RawData";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

