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
	public class EmailNotificationCategoryRecipientJobData : EmailNotificationRecipientJobData
	{
		#region Constants
		public const string CATEGORY_USER_FILTER = "categoryUserFilter";
		#endregion

		#region Private Fields
		private CategoryUserFilter _CategoryUserFilter;
		#endregion

		#region Properties
		public CategoryUserFilter CategoryUserFilter
		{
			get { return _CategoryUserFilter; }
			set 
			{ 
				_CategoryUserFilter = value;
				OnPropertyChanged("CategoryUserFilter");
			}
		}
		#endregion

		#region CTor
		public EmailNotificationCategoryRecipientJobData()
		{
		}

		public EmailNotificationCategoryRecipientJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "categoryUserFilter":
						this._CategoryUserFilter = ObjectFactory.Create<CategoryUserFilter>(propertyNode);
						continue;
				}
			}
		}

		public EmailNotificationCategoryRecipientJobData(IDictionary<string,object> data) : base(data)
		{
			    this._CategoryUserFilter = ObjectFactory.Create<CategoryUserFilter>(data.TryGetValueSafe<IDictionary<string,object>>("categoryUserFilter"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEmailNotificationCategoryRecipientJobData");
			kparams.AddIfNotNull("categoryUserFilter", this._CategoryUserFilter);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORY_USER_FILTER:
					return "CategoryUserFilter";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

