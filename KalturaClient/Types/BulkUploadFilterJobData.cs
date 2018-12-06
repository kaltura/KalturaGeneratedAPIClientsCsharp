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
	public class BulkUploadFilterJobData : BulkUploadJobData
	{
		#region Constants
		public const string FILTER = "filter";
		public const string TEMPLATE_OBJECT = "templateObject";
		#endregion

		#region Private Fields
		private Filter _Filter;
		private ObjectBase _TemplateObject;
		#endregion

		#region Properties
		public Filter Filter
		{
			get { return _Filter; }
			set 
			{ 
				_Filter = value;
				OnPropertyChanged("Filter");
			}
		}
		public ObjectBase TemplateObject
		{
			get { return _TemplateObject; }
			set 
			{ 
				_TemplateObject = value;
				OnPropertyChanged("TemplateObject");
			}
		}
		#endregion

		#region CTor
		public BulkUploadFilterJobData()
		{
		}

		public BulkUploadFilterJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "filter":
						this._Filter = ObjectFactory.Create<Filter>(propertyNode);
						continue;
					case "templateObject":
						this._TemplateObject = ObjectFactory.Create<ObjectBase>(propertyNode);
						continue;
				}
			}
		}

		public BulkUploadFilterJobData(IDictionary<string,object> data) : base(data)
		{
			    this._Filter = ObjectFactory.Create<Filter>(data.TryGetValueSafe<IDictionary<string,object>>("filter"));
			    this._TemplateObject = ObjectFactory.Create<ObjectBase>(data.TryGetValueSafe<IDictionary<string,object>>("templateObject"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadFilterJobData");
			kparams.AddIfNotNull("filter", this._Filter);
			kparams.AddIfNotNull("templateObject", this._TemplateObject);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILTER:
					return "Filter";
				case TEMPLATE_OBJECT:
					return "TemplateObject";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

