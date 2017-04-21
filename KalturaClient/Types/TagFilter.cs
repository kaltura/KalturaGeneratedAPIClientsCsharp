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
	public class TagFilter : Filter
	{
		#region Constants
		public const string OBJECT_TYPE_EQUAL = "objectTypeEqual";
		public const string TAG_EQUAL = "tagEqual";
		public const string TAG_STARTS_WITH = "tagStartsWith";
		public const string INSTANCE_COUNT_EQUAL = "instanceCountEqual";
		public const string INSTANCE_COUNT_IN = "instanceCountIn";
		#endregion

		#region Private Fields
		private TaggedObjectType _ObjectTypeEqual = null;
		private string _TagEqual = null;
		private string _TagStartsWith = null;
		private int _InstanceCountEqual = Int32.MinValue;
		private int _InstanceCountIn = Int32.MinValue;
		#endregion

		#region Properties
		public TaggedObjectType ObjectTypeEqual
		{
			get { return _ObjectTypeEqual; }
			set 
			{ 
				_ObjectTypeEqual = value;
				OnPropertyChanged("ObjectTypeEqual");
			}
		}
		public string TagEqual
		{
			get { return _TagEqual; }
			set 
			{ 
				_TagEqual = value;
				OnPropertyChanged("TagEqual");
			}
		}
		public string TagStartsWith
		{
			get { return _TagStartsWith; }
			set 
			{ 
				_TagStartsWith = value;
				OnPropertyChanged("TagStartsWith");
			}
		}
		public int InstanceCountEqual
		{
			get { return _InstanceCountEqual; }
			set 
			{ 
				_InstanceCountEqual = value;
				OnPropertyChanged("InstanceCountEqual");
			}
		}
		public int InstanceCountIn
		{
			get { return _InstanceCountIn; }
			set 
			{ 
				_InstanceCountIn = value;
				OnPropertyChanged("InstanceCountIn");
			}
		}
		#endregion

		#region CTor
		public TagFilter()
		{
		}

		public TagFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "objectTypeEqual":
						this._ObjectTypeEqual = (TaggedObjectType)StringEnum.Parse(typeof(TaggedObjectType), propertyNode.InnerText);
						continue;
					case "tagEqual":
						this._TagEqual = propertyNode.InnerText;
						continue;
					case "tagStartsWith":
						this._TagStartsWith = propertyNode.InnerText;
						continue;
					case "instanceCountEqual":
						this._InstanceCountEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "instanceCountIn":
						this._InstanceCountIn = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaTagFilter");
			kparams.AddIfNotNull("objectTypeEqual", this._ObjectTypeEqual);
			kparams.AddIfNotNull("tagEqual", this._TagEqual);
			kparams.AddIfNotNull("tagStartsWith", this._TagStartsWith);
			kparams.AddIfNotNull("instanceCountEqual", this._InstanceCountEqual);
			kparams.AddIfNotNull("instanceCountIn", this._InstanceCountIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OBJECT_TYPE_EQUAL:
					return "ObjectTypeEqual";
				case TAG_EQUAL:
					return "TagEqual";
				case TAG_STARTS_WITH:
					return "TagStartsWith";
				case INSTANCE_COUNT_EQUAL:
					return "InstanceCountEqual";
				case INSTANCE_COUNT_IN:
					return "InstanceCountIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

