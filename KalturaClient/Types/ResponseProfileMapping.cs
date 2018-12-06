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
	public class ResponseProfileMapping : ObjectBase
	{
		#region Constants
		public const string PARENT_PROPERTY = "parentProperty";
		public const string FILTER_PROPERTY = "filterProperty";
		public const string ALLOW_NULL = "allowNull";
		#endregion

		#region Private Fields
		private string _ParentProperty = null;
		private string _FilterProperty = null;
		private bool? _AllowNull = null;
		#endregion

		#region Properties
		public string ParentProperty
		{
			get { return _ParentProperty; }
			set 
			{ 
				_ParentProperty = value;
				OnPropertyChanged("ParentProperty");
			}
		}
		public string FilterProperty
		{
			get { return _FilterProperty; }
			set 
			{ 
				_FilterProperty = value;
				OnPropertyChanged("FilterProperty");
			}
		}
		public bool? AllowNull
		{
			get { return _AllowNull; }
			set 
			{ 
				_AllowNull = value;
				OnPropertyChanged("AllowNull");
			}
		}
		#endregion

		#region CTor
		public ResponseProfileMapping()
		{
		}

		public ResponseProfileMapping(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "parentProperty":
						this._ParentProperty = propertyNode.InnerText;
						continue;
					case "filterProperty":
						this._FilterProperty = propertyNode.InnerText;
						continue;
					case "allowNull":
						this._AllowNull = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}

		public ResponseProfileMapping(IDictionary<string,object> data) : base(data)
		{
			    this._ParentProperty = data.TryGetValueSafe<string>("parentProperty");
			    this._FilterProperty = data.TryGetValueSafe<string>("filterProperty");
			    this._AllowNull = data.TryGetValueSafe<bool>("allowNull");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaResponseProfileMapping");
			kparams.AddIfNotNull("parentProperty", this._ParentProperty);
			kparams.AddIfNotNull("filterProperty", this._FilterProperty);
			kparams.AddIfNotNull("allowNull", this._AllowNull);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARENT_PROPERTY:
					return "ParentProperty";
				case FILTER_PROPERTY:
					return "FilterProperty";
				case ALLOW_NULL:
					return "AllowNull";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

