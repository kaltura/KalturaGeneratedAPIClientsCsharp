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
	public class KalturaTag : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _Tag = null;
		private KalturaTaggedObjectType _TaggedObjectType = null;
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
		public string Tag
		{
			get { return _Tag; }
		}
		public KalturaTaggedObjectType TaggedObjectType
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
		public KalturaTag()
		{
		}

		public KalturaTag(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "tag":
						this._Tag = txt;
						continue;
					case "taggedObjectType":
						this._TaggedObjectType = (KalturaTaggedObjectType)KalturaStringEnum.Parse(typeof(KalturaTaggedObjectType), txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "instanceCount":
						this._InstanceCount = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

