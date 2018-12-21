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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class EntryScheduleEventBaseFilter : ScheduleEventFilter
	{
		#region Constants
		public const string TEMPLATE_ENTRY_ID_EQUAL = "templateEntryIdEqual";
		public const string ENTRY_IDS_LIKE = "entryIdsLike";
		public const string ENTRY_IDS_MULTI_LIKE_OR = "entryIdsMultiLikeOr";
		public const string ENTRY_IDS_MULTI_LIKE_AND = "entryIdsMultiLikeAnd";
		public const string CATEGORY_IDS_LIKE = "categoryIdsLike";
		public const string CATEGORY_IDS_MULTI_LIKE_OR = "categoryIdsMultiLikeOr";
		public const string CATEGORY_IDS_MULTI_LIKE_AND = "categoryIdsMultiLikeAnd";
		#endregion

		#region Private Fields
		private string _TemplateEntryIdEqual = null;
		private string _EntryIdsLike = null;
		private string _EntryIdsMultiLikeOr = null;
		private string _EntryIdsMultiLikeAnd = null;
		private string _CategoryIdsLike = null;
		private string _CategoryIdsMultiLikeOr = null;
		private string _CategoryIdsMultiLikeAnd = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string TemplateEntryIdEqual
		{
			get { return _TemplateEntryIdEqual; }
			set 
			{ 
				_TemplateEntryIdEqual = value;
				OnPropertyChanged("TemplateEntryIdEqual");
			}
		}
		[JsonProperty]
		public string EntryIdsLike
		{
			get { return _EntryIdsLike; }
			set 
			{ 
				_EntryIdsLike = value;
				OnPropertyChanged("EntryIdsLike");
			}
		}
		[JsonProperty]
		public string EntryIdsMultiLikeOr
		{
			get { return _EntryIdsMultiLikeOr; }
			set 
			{ 
				_EntryIdsMultiLikeOr = value;
				OnPropertyChanged("EntryIdsMultiLikeOr");
			}
		}
		[JsonProperty]
		public string EntryIdsMultiLikeAnd
		{
			get { return _EntryIdsMultiLikeAnd; }
			set 
			{ 
				_EntryIdsMultiLikeAnd = value;
				OnPropertyChanged("EntryIdsMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string CategoryIdsLike
		{
			get { return _CategoryIdsLike; }
			set 
			{ 
				_CategoryIdsLike = value;
				OnPropertyChanged("CategoryIdsLike");
			}
		}
		[JsonProperty]
		public string CategoryIdsMultiLikeOr
		{
			get { return _CategoryIdsMultiLikeOr; }
			set 
			{ 
				_CategoryIdsMultiLikeOr = value;
				OnPropertyChanged("CategoryIdsMultiLikeOr");
			}
		}
		[JsonProperty]
		public string CategoryIdsMultiLikeAnd
		{
			get { return _CategoryIdsMultiLikeAnd; }
			set 
			{ 
				_CategoryIdsMultiLikeAnd = value;
				OnPropertyChanged("CategoryIdsMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public EntryScheduleEventBaseFilter()
		{
		}

		public EntryScheduleEventBaseFilter(JToken node) : base(node)
		{
			if(node["templateEntryIdEqual"] != null)
			{
				this._TemplateEntryIdEqual = node["templateEntryIdEqual"].Value<string>();
			}
			if(node["entryIdsLike"] != null)
			{
				this._EntryIdsLike = node["entryIdsLike"].Value<string>();
			}
			if(node["entryIdsMultiLikeOr"] != null)
			{
				this._EntryIdsMultiLikeOr = node["entryIdsMultiLikeOr"].Value<string>();
			}
			if(node["entryIdsMultiLikeAnd"] != null)
			{
				this._EntryIdsMultiLikeAnd = node["entryIdsMultiLikeAnd"].Value<string>();
			}
			if(node["categoryIdsLike"] != null)
			{
				this._CategoryIdsLike = node["categoryIdsLike"].Value<string>();
			}
			if(node["categoryIdsMultiLikeOr"] != null)
			{
				this._CategoryIdsMultiLikeOr = node["categoryIdsMultiLikeOr"].Value<string>();
			}
			if(node["categoryIdsMultiLikeAnd"] != null)
			{
				this._CategoryIdsMultiLikeAnd = node["categoryIdsMultiLikeAnd"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryScheduleEventBaseFilter");
			kparams.AddIfNotNull("templateEntryIdEqual", this._TemplateEntryIdEqual);
			kparams.AddIfNotNull("entryIdsLike", this._EntryIdsLike);
			kparams.AddIfNotNull("entryIdsMultiLikeOr", this._EntryIdsMultiLikeOr);
			kparams.AddIfNotNull("entryIdsMultiLikeAnd", this._EntryIdsMultiLikeAnd);
			kparams.AddIfNotNull("categoryIdsLike", this._CategoryIdsLike);
			kparams.AddIfNotNull("categoryIdsMultiLikeOr", this._CategoryIdsMultiLikeOr);
			kparams.AddIfNotNull("categoryIdsMultiLikeAnd", this._CategoryIdsMultiLikeAnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TEMPLATE_ENTRY_ID_EQUAL:
					return "TemplateEntryIdEqual";
				case ENTRY_IDS_LIKE:
					return "EntryIdsLike";
				case ENTRY_IDS_MULTI_LIKE_OR:
					return "EntryIdsMultiLikeOr";
				case ENTRY_IDS_MULTI_LIKE_AND:
					return "EntryIdsMultiLikeAnd";
				case CATEGORY_IDS_LIKE:
					return "CategoryIdsLike";
				case CATEGORY_IDS_MULTI_LIKE_OR:
					return "CategoryIdsMultiLikeOr";
				case CATEGORY_IDS_MULTI_LIKE_AND:
					return "CategoryIdsMultiLikeAnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

