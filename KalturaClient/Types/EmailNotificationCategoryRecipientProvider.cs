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
	public class EmailNotificationCategoryRecipientProvider : EmailNotificationRecipientProvider
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string CATEGORY_IDS = "categoryIds";
		public const string CATEGORY_USER_FILTER = "categoryUserFilter";
		#endregion

		#region Private Fields
		private StringValue _CategoryId;
		private StringValue _CategoryIds;
		private CategoryUserProviderFilter _CategoryUserFilter;
		#endregion

		#region Properties
		public StringValue CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		public StringValue CategoryIds
		{
			get { return _CategoryIds; }
			set 
			{ 
				_CategoryIds = value;
				OnPropertyChanged("CategoryIds");
			}
		}
		public CategoryUserProviderFilter CategoryUserFilter
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
		public EmailNotificationCategoryRecipientProvider()
		{
		}

		public EmailNotificationCategoryRecipientProvider(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "categoryId":
						this._CategoryId = ObjectFactory.Create<StringValue>(propertyNode);
						continue;
					case "categoryIds":
						this._CategoryIds = ObjectFactory.Create<StringValue>(propertyNode);
						continue;
					case "categoryUserFilter":
						this._CategoryUserFilter = ObjectFactory.Create<CategoryUserProviderFilter>(propertyNode);
						continue;
				}
			}
		}

		public EmailNotificationCategoryRecipientProvider(IDictionary<string,object> data) : base(data)
		{
			    this._CategoryId = ObjectFactory.Create<StringValue>(data.TryGetValueSafe<IDictionary<string,object>>("categoryId"));
			    this._CategoryIds = ObjectFactory.Create<StringValue>(data.TryGetValueSafe<IDictionary<string,object>>("categoryIds"));
			    this._CategoryUserFilter = ObjectFactory.Create<CategoryUserProviderFilter>(data.TryGetValueSafe<IDictionary<string,object>>("categoryUserFilter"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEmailNotificationCategoryRecipientProvider");
			kparams.AddIfNotNull("categoryId", this._CategoryId);
			kparams.AddIfNotNull("categoryIds", this._CategoryIds);
			kparams.AddIfNotNull("categoryUserFilter", this._CategoryUserFilter);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORY_ID:
					return "CategoryId";
				case CATEGORY_IDS:
					return "CategoryIds";
				case CATEGORY_USER_FILTER:
					return "CategoryUserFilter";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

