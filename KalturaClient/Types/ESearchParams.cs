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
	public class ESearchParams : ObjectBase
	{
		#region Constants
		public const string OBJECT_STATUSES = "objectStatuses";
		public const string OBJECT_ID = "objectId";
		public const string ORDER_BY = "orderBy";
		public const string USE_HIGHLIGHT = "useHighlight";
		#endregion

		#region Private Fields
		private string _ObjectStatuses = null;
		private string _ObjectId = null;
		private ESearchOrderBy _OrderBy;
		private bool? _UseHighlight = null;
		#endregion

		#region Properties
		public string ObjectStatuses
		{
			get { return _ObjectStatuses; }
			set 
			{ 
				_ObjectStatuses = value;
				OnPropertyChanged("ObjectStatuses");
			}
		}
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		public ESearchOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		public bool? UseHighlight
		{
			get { return _UseHighlight; }
			set 
			{ 
				_UseHighlight = value;
				OnPropertyChanged("UseHighlight");
			}
		}
		#endregion

		#region CTor
		public ESearchParams()
		{
		}

		public ESearchParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "objectStatuses":
						this._ObjectStatuses = propertyNode.InnerText;
						continue;
					case "objectId":
						this._ObjectId = propertyNode.InnerText;
						continue;
					case "orderBy":
						this._OrderBy = ObjectFactory.Create<ESearchOrderBy>(propertyNode);
						continue;
					case "useHighlight":
						this._UseHighlight = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaESearchParams");
			kparams.AddIfNotNull("objectStatuses", this._ObjectStatuses);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			kparams.AddIfNotNull("useHighlight", this._UseHighlight);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OBJECT_STATUSES:
					return "ObjectStatuses";
				case OBJECT_ID:
					return "ObjectId";
				case ORDER_BY:
					return "OrderBy";
				case USE_HIGHLIGHT:
					return "UseHighlight";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

