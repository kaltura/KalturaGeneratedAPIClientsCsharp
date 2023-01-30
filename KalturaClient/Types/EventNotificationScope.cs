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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class EventNotificationScope : Scope
	{
		#region Constants
		public const string OBJECT_ID = "objectId";
		public const string SCOPE_OBJECT_TYPE = "scopeObjectType";
		#endregion

		#region Private Fields
		private string _ObjectId = null;
		private EventNotificationEventObjectType _ScopeObjectType = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ObjectIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ScopeObjectTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EventNotificationEventObjectType ScopeObjectType
		{
			get { return _ScopeObjectType; }
			set 
			{ 
				_ScopeObjectType = value;
				OnPropertyChanged("ScopeObjectType");
			}
		}
		#endregion

		#region CTor
		public EventNotificationScope()
		{
		}

		public EventNotificationScope(JToken node) : base(node)
		{
			if(node["objectId"] != null)
			{
				this._ObjectId = node["objectId"].Value<string>();
			}
			if(node["scopeObjectType"] != null)
			{
				this._ScopeObjectType = (EventNotificationEventObjectType)StringEnum.Parse(typeof(EventNotificationEventObjectType), node["scopeObjectType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEventNotificationScope");
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("scopeObjectType", this._ScopeObjectType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OBJECT_ID:
					return "ObjectId";
				case SCOPE_OBJECT_TYPE:
					return "ScopeObjectType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

