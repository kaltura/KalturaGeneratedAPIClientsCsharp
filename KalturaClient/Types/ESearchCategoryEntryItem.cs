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
	public class ESearchCategoryEntryItem : ESearchAbstractEntryItem
	{
		#region Constants
		public const string FIELD_NAME = "fieldName";
		public const string CATEGORY_ENTRY_STATUS = "categoryEntryStatus";
		#endregion

		#region Private Fields
		private ESearchCategoryEntryFieldName _FieldName = null;
		private CategoryEntryStatus _CategoryEntryStatus = (CategoryEntryStatus)Int32.MinValue;
		#endregion

		#region Properties
		public ESearchCategoryEntryFieldName FieldName
		{
			get { return _FieldName; }
			set 
			{ 
				_FieldName = value;
				OnPropertyChanged("FieldName");
			}
		}
		public CategoryEntryStatus CategoryEntryStatus
		{
			get { return _CategoryEntryStatus; }
			set 
			{ 
				_CategoryEntryStatus = value;
				OnPropertyChanged("CategoryEntryStatus");
			}
		}
		#endregion

		#region CTor
		public ESearchCategoryEntryItem()
		{
		}

		public ESearchCategoryEntryItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "fieldName":
						this._FieldName = (ESearchCategoryEntryFieldName)StringEnum.Parse(typeof(ESearchCategoryEntryFieldName), propertyNode.InnerText);
						continue;
					case "categoryEntryStatus":
						this._CategoryEntryStatus = (CategoryEntryStatus)ParseEnum(typeof(CategoryEntryStatus), propertyNode.InnerText);
						continue;
				}
			}
		}

		public ESearchCategoryEntryItem(IDictionary<string,object> data) : base(data)
		{
			    this._FieldName = (ESearchCategoryEntryFieldName)StringEnum.Parse(typeof(ESearchCategoryEntryFieldName), data.TryGetValueSafe<string>("fieldName"));
			    this._CategoryEntryStatus = (CategoryEntryStatus)ParseEnum(typeof(CategoryEntryStatus), data.TryGetValueSafe<int>("categoryEntryStatus"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchCategoryEntryItem");
			kparams.AddIfNotNull("fieldName", this._FieldName);
			kparams.AddIfNotNull("categoryEntryStatus", this._CategoryEntryStatus);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FIELD_NAME:
					return "FieldName";
				case CATEGORY_ENTRY_STATUS:
					return "CategoryEntryStatus";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

