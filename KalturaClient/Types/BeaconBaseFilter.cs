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
	public class BeaconBaseFilter : Filter
	{
		#region Constants
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string RELATED_OBJECT_TYPE_IN = "relatedObjectTypeIn";
		public const string RELATED_OBJECT_TYPE_EQUAL = "relatedObjectTypeEqual";
		public const string EVENT_TYPE_IN = "eventTypeIn";
		public const string OBJECT_ID_IN = "objectIdIn";
		#endregion

		#region Private Fields
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private string _RelatedObjectTypeIn = null;
		private BeaconObjectTypes _RelatedObjectTypeEqual = null;
		private string _EventTypeIn = null;
		private string _ObjectIdIn = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public string RelatedObjectTypeIn
		{
			get { return _RelatedObjectTypeIn; }
			set 
			{ 
				_RelatedObjectTypeIn = value;
				OnPropertyChanged("RelatedObjectTypeIn");
			}
		}
		[JsonProperty]
		public BeaconObjectTypes RelatedObjectTypeEqual
		{
			get { return _RelatedObjectTypeEqual; }
			set 
			{ 
				_RelatedObjectTypeEqual = value;
				OnPropertyChanged("RelatedObjectTypeEqual");
			}
		}
		[JsonProperty]
		public string EventTypeIn
		{
			get { return _EventTypeIn; }
			set 
			{ 
				_EventTypeIn = value;
				OnPropertyChanged("EventTypeIn");
			}
		}
		[JsonProperty]
		public string ObjectIdIn
		{
			get { return _ObjectIdIn; }
			set 
			{ 
				_ObjectIdIn = value;
				OnPropertyChanged("ObjectIdIn");
			}
		}
		#endregion

		#region CTor
		public BeaconBaseFilter()
		{
		}

		public BeaconBaseFilter(JToken node) : base(node)
		{
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["relatedObjectTypeIn"] != null)
			{
				this._RelatedObjectTypeIn = node["relatedObjectTypeIn"].Value<string>();
			}
			if(node["relatedObjectTypeEqual"] != null)
			{
				this._RelatedObjectTypeEqual = (BeaconObjectTypes)StringEnum.Parse(typeof(BeaconObjectTypes), node["relatedObjectTypeEqual"].Value<string>());
			}
			if(node["eventTypeIn"] != null)
			{
				this._EventTypeIn = node["eventTypeIn"].Value<string>();
			}
			if(node["objectIdIn"] != null)
			{
				this._ObjectIdIn = node["objectIdIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBeaconBaseFilter");
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("relatedObjectTypeIn", this._RelatedObjectTypeIn);
			kparams.AddIfNotNull("relatedObjectTypeEqual", this._RelatedObjectTypeEqual);
			kparams.AddIfNotNull("eventTypeIn", this._EventTypeIn);
			kparams.AddIfNotNull("objectIdIn", this._ObjectIdIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case RELATED_OBJECT_TYPE_IN:
					return "RelatedObjectTypeIn";
				case RELATED_OBJECT_TYPE_EQUAL:
					return "RelatedObjectTypeEqual";
				case EVENT_TYPE_IN:
					return "EventTypeIn";
				case OBJECT_ID_IN:
					return "ObjectIdIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

