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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class CategoryEntry : ObjectBase
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string ENTRY_ID = "entryId";
		public const string CREATED_AT = "createdAt";
		public const string CATEGORY_FULL_IDS = "categoryFullIds";
		public const string STATUS = "status";
		public const string CREATOR_USER_ID = "creatorUserId";
		#endregion

		#region Private Fields
		private int _CategoryId = Int32.MinValue;
		private string _EntryId = null;
		private int _CreatedAt = Int32.MinValue;
		private string _CategoryFullIds = null;
		private CategoryEntryStatus _Status = (CategoryEntryStatus)Int32.MinValue;
		private string _CreatorUserId = null;
		#endregion

		#region Properties
		public int CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public string CategoryFullIds
		{
			get { return _CategoryFullIds; }
		}
		public CategoryEntryStatus Status
		{
			get { return _Status; }
		}
		public string CreatorUserId
		{
			get { return _CreatorUserId; }
		}
		#endregion

		#region CTor
		public CategoryEntry()
		{
		}

		public CategoryEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "categoryId":
						this._CategoryId = ParseInt(txt);
						continue;
					case "entryId":
						this._EntryId = txt;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "categoryFullIds":
						this._CategoryFullIds = txt;
						continue;
					case "status":
						this._Status = (CategoryEntryStatus)ParseEnum(typeof(CategoryEntryStatus), txt);
						continue;
					case "creatorUserId":
						this._CreatorUserId = txt;
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
				kparams.AddReplace("objectType", "KalturaCategoryEntry");
			kparams.AddIfNotNull("categoryId", this._CategoryId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("categoryFullIds", this._CategoryFullIds);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("creatorUserId", this._CreatorUserId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORY_ID:
					return "CategoryId";
				case ENTRY_ID:
					return "EntryId";
				case CREATED_AT:
					return "CreatedAt";
				case CATEGORY_FULL_IDS:
					return "CategoryFullIds";
				case STATUS:
					return "Status";
				case CREATOR_USER_ID:
					return "CreatorUserId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

