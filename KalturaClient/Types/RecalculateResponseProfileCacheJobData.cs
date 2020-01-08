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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class RecalculateResponseProfileCacheJobData : RecalculateCacheJobData
	{
		#region Constants
		public const string PROTOCOL = "protocol";
		public const string KS_TYPE = "ksType";
		public const string USER_ROLES = "userRoles";
		public const string CACHED_OBJECT_TYPE = "cachedObjectType";
		public const string OBJECT_ID = "objectId";
		public const string START_OBJECT_KEY = "startObjectKey";
		public const string END_OBJECT_KEY = "endObjectKey";
		#endregion

		#region Private Fields
		private string _Protocol = null;
		private SessionType _KsType = (SessionType)Int32.MinValue;
		private IList<IntegerValue> _UserRoles;
		private string _CachedObjectType = null;
		private string _ObjectId = null;
		private string _StartObjectKey = null;
		private string _EndObjectKey = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		[JsonProperty]
		public SessionType KsType
		{
			get { return _KsType; }
			set 
			{ 
				_KsType = value;
				OnPropertyChanged("KsType");
			}
		}
		[JsonProperty]
		public IList<IntegerValue> UserRoles
		{
			get { return _UserRoles; }
			set 
			{ 
				_UserRoles = value;
				OnPropertyChanged("UserRoles");
			}
		}
		[JsonProperty]
		public string CachedObjectType
		{
			get { return _CachedObjectType; }
			set 
			{ 
				_CachedObjectType = value;
				OnPropertyChanged("CachedObjectType");
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
		public string StartObjectKey
		{
			get { return _StartObjectKey; }
			set 
			{ 
				_StartObjectKey = value;
				OnPropertyChanged("StartObjectKey");
			}
		}
		[JsonProperty]
		public string EndObjectKey
		{
			get { return _EndObjectKey; }
			set 
			{ 
				_EndObjectKey = value;
				OnPropertyChanged("EndObjectKey");
			}
		}
		#endregion

		#region CTor
		public RecalculateResponseProfileCacheJobData()
		{
		}

		public RecalculateResponseProfileCacheJobData(JToken node) : base(node)
		{
			if(node["protocol"] != null)
			{
				this._Protocol = node["protocol"].Value<string>();
			}
			if(node["ksType"] != null)
			{
				this._KsType = (SessionType)ParseEnum(typeof(SessionType), node["ksType"].Value<string>());
			}
			if(node["userRoles"] != null)
			{
				this._UserRoles = new List<IntegerValue>();
				foreach(var arrayNode in node["userRoles"].Children())
				{
					this._UserRoles.Add(ObjectFactory.Create<IntegerValue>(arrayNode));
				}
			}
			if(node["cachedObjectType"] != null)
			{
				this._CachedObjectType = node["cachedObjectType"].Value<string>();
			}
			if(node["objectId"] != null)
			{
				this._ObjectId = node["objectId"].Value<string>();
			}
			if(node["startObjectKey"] != null)
			{
				this._StartObjectKey = node["startObjectKey"].Value<string>();
			}
			if(node["endObjectKey"] != null)
			{
				this._EndObjectKey = node["endObjectKey"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaRecalculateResponseProfileCacheJobData");
			kparams.AddIfNotNull("protocol", this._Protocol);
			kparams.AddIfNotNull("ksType", this._KsType);
			kparams.AddIfNotNull("userRoles", this._UserRoles);
			kparams.AddIfNotNull("cachedObjectType", this._CachedObjectType);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("startObjectKey", this._StartObjectKey);
			kparams.AddIfNotNull("endObjectKey", this._EndObjectKey);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROTOCOL:
					return "Protocol";
				case KS_TYPE:
					return "KsType";
				case USER_ROLES:
					return "UserRoles";
				case CACHED_OBJECT_TYPE:
					return "CachedObjectType";
				case OBJECT_ID:
					return "ObjectId";
				case START_OBJECT_KEY:
					return "StartObjectKey";
				case END_OBJECT_KEY:
					return "EndObjectKey";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

