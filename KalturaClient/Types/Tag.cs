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
		public int Id
		{
			get { return _Id; }
		}
		public string TagValue
		{
			get { return _Tag; }
		}
		public TaggedObjectType TaggedObjectType
		{
			get { return _TaggedObjectType; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int InstanceCount
		{
			get { return _InstanceCount; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		#endregion

		#region CTor
		public Tag()
		{
		}

		public Tag(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "tag":
						this._Tag = propertyNode.InnerText;
						continue;
					case "taggedObjectType":
						this._TaggedObjectType = (TaggedObjectType)StringEnum.Parse(typeof(TaggedObjectType), propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "instanceCount":
						this._InstanceCount = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
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

