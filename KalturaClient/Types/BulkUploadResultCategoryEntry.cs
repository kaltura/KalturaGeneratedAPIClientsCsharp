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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class BulkUploadResultCategoryEntry : BulkUploadResult
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string ENTRY_ID = "entryId";
		#endregion

		#region Private Fields
		private int _CategoryId = Int32.MinValue;
		private string _EntryId = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		#endregion

		#region CTor
		public BulkUploadResultCategoryEntry()
		{
		}

		public BulkUploadResultCategoryEntry(JToken node) : base(node)
		{
			if(node["categoryId"] != null)
			{
				this._CategoryId = ParseInt(node["categoryId"].Value<string>());
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadResultCategoryEntry");
			kparams.AddIfNotNull("categoryId", this._CategoryId);
			kparams.AddIfNotNull("entryId", this._EntryId);
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

