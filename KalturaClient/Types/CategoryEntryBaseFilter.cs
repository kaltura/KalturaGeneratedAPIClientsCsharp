// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class CategoryEntryBaseFilter : RelatedFilter
	{
		#region Constants
		public const string CATEGORY_ID_EQUAL = "categoryIdEqual";
		public const string CATEGORY_ID_IN = "categoryIdIn";
		public const string ENTRY_ID_EQUAL = "entryIdEqual";
		public const string ENTRY_ID_IN = "entryIdIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string CATEGORY_FULL_IDS_STARTS_WITH = "categoryFullIdsStartsWith";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string CREATOR_USER_ID_EQUAL = "creatorUserIdEqual";
		public const string CREATOR_USER_ID_IN = "creatorUserIdIn";
		#endregion

		#region Private Fields
		private int _CategoryIdEqual = Int32.MinValue;
		private string _CategoryIdIn = null;
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private string _CategoryFullIdsStartsWith = null;
		private CategoryEntryStatus _StatusEqual = (CategoryEntryStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _CreatorUserIdEqual = null;
		private string _CreatorUserIdIn = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use CategoryIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CategoryIdEqual
		{
			get { return _CategoryIdEqual; }
			set 
			{ 
				_CategoryIdEqual = value;
				OnPropertyChanged("CategoryIdEqual");
			}
		}
		/// <summary>
		/// Use CategoryIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CategoryIdIn
		{
			get { return _CategoryIdIn; }
			set 
			{ 
				_CategoryIdIn = value;
				OnPropertyChanged("CategoryIdIn");
			}
		}
		/// <summary>
		/// Use EntryIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		/// <summary>
		/// Use EntryIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIdIn
		{
			get { return _EntryIdIn; }
			set 
			{ 
				_EntryIdIn = value;
				OnPropertyChanged("EntryIdIn");
			}
		}
		/// <summary>
		/// Use CreatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use CreatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use CategoryFullIdsStartsWithAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CategoryFullIdsStartsWith
		{
			get { return _CategoryFullIdsStartsWith; }
			set 
			{ 
				_CategoryFullIdsStartsWith = value;
				OnPropertyChanged("CategoryFullIdsStartsWith");
			}
		}
		/// <summary>
		/// Use StatusEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CategoryEntryStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		/// <summary>
		/// Use StatusInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		/// <summary>
		/// Use CreatorUserIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CreatorUserIdEqual
		{
			get { return _CreatorUserIdEqual; }
			set 
			{ 
				_CreatorUserIdEqual = value;
				OnPropertyChanged("CreatorUserIdEqual");
			}
		}
		/// <summary>
		/// Use CreatorUserIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CreatorUserIdIn
		{
			get { return _CreatorUserIdIn; }
			set 
			{ 
				_CreatorUserIdIn = value;
				OnPropertyChanged("CreatorUserIdIn");
			}
		}
		#endregion

		#region CTor
		public CategoryEntryBaseFilter()
		{
		}

		public CategoryEntryBaseFilter(JToken node) : base(node)
		{
			if(node["categoryIdEqual"] != null)
			{
				this._CategoryIdEqual = ParseInt(node["categoryIdEqual"].Value<string>());
			}
			if(node["categoryIdIn"] != null)
			{
				this._CategoryIdIn = node["categoryIdIn"].Value<string>();
			}
			if(node["entryIdEqual"] != null)
			{
				this._EntryIdEqual = node["entryIdEqual"].Value<string>();
			}
			if(node["entryIdIn"] != null)
			{
				this._EntryIdIn = node["entryIdIn"].Value<string>();
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["categoryFullIdsStartsWith"] != null)
			{
				this._CategoryFullIdsStartsWith = node["categoryFullIdsStartsWith"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (CategoryEntryStatus)ParseEnum(typeof(CategoryEntryStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["creatorUserIdEqual"] != null)
			{
				this._CreatorUserIdEqual = node["creatorUserIdEqual"].Value<string>();
			}
			if(node["creatorUserIdIn"] != null)
			{
				this._CreatorUserIdIn = node["creatorUserIdIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCategoryEntryBaseFilter");
			kparams.AddIfNotNull("categoryIdEqual", this._CategoryIdEqual);
			kparams.AddIfNotNull("categoryIdIn", this._CategoryIdIn);
			kparams.AddIfNotNull("entryIdEqual", this._EntryIdEqual);
			kparams.AddIfNotNull("entryIdIn", this._EntryIdIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("categoryFullIdsStartsWith", this._CategoryFullIdsStartsWith);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("creatorUserIdEqual", this._CreatorUserIdEqual);
			kparams.AddIfNotNull("creatorUserIdIn", this._CreatorUserIdIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORY_ID_EQUAL:
					return "CategoryIdEqual";
				case CATEGORY_ID_IN:
					return "CategoryIdIn";
				case ENTRY_ID_EQUAL:
					return "EntryIdEqual";
				case ENTRY_ID_IN:
					return "EntryIdIn";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case CATEGORY_FULL_IDS_STARTS_WITH:
					return "CategoryFullIdsStartsWith";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case CREATOR_USER_ID_EQUAL:
					return "CreatorUserIdEqual";
				case CREATOR_USER_ID_IN:
					return "CreatorUserIdIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

