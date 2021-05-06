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
	public class Tag : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string TAG = "tag";
		public const string TAGGED_OBJECT_TYPE = "taggedObjectType";
		public const string PARTNER_ID = "partnerId";
		public const string INSTANCE_COUNT = "instanceCount";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _Tag = null;
		private TaggedObjectType _TaggedObjectType = null;
		private int _PartnerId = Int32.MinValue;
		private int _InstanceCount = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
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
		public string TagValue
		{
			get { return _Tag; }
			private set 
			{ 
				_Tag = value;
				OnPropertyChanged("Tag");
			}
		}
		[JsonProperty]
		public TaggedObjectType TaggedObjectType
		{
			get { return _TaggedObjectType; }
			private set 
			{ 
				_TaggedObjectType = value;
				OnPropertyChanged("TaggedObjectType");
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
		public int InstanceCount
		{
			get { return _InstanceCount; }
			private set 
			{ 
				_InstanceCount = value;
				OnPropertyChanged("InstanceCount");
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
		#endregion

		#region CTor
		public Tag()
		{
		}

		public Tag(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["tag"] != null)
			{
				this._Tag = node["tag"].Value<string>();
			}
			if(node["taggedObjectType"] != null)
			{
				this._TaggedObjectType = (TaggedObjectType)StringEnum.Parse(typeof(TaggedObjectType), node["taggedObjectType"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["instanceCount"] != null)
			{
				this._InstanceCount = ParseInt(node["instanceCount"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTag");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("tag", this._Tag);
			kparams.AddIfNotNull("taggedObjectType", this._TaggedObjectType);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("instanceCount", this._InstanceCount);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case TAG:
					return "Tag";
				case TAGGED_OBJECT_TYPE:
					return "TaggedObjectType";
				case PARTNER_ID:
					return "PartnerId";
				case INSTANCE_COUNT:
					return "InstanceCount";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

