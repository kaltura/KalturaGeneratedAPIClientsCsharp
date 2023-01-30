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
	public class MoveCategoryEntriesJobData : JobData
	{
		#region Constants
		public const string SRC_CATEGORY_ID = "srcCategoryId";
		public const string DEST_CATEGORY_ID = "destCategoryId";
		public const string LAST_MOVED_CATEGORY_ID = "lastMovedCategoryId";
		public const string LAST_MOVED_CATEGORY_PAGE_INDEX = "lastMovedCategoryPageIndex";
		public const string LAST_MOVED_CATEGORY_ENTRY_PAGE_INDEX = "lastMovedCategoryEntryPageIndex";
		public const string MOVE_FROM_CHILDREN = "moveFromChildren";
		public const string DEST_CATEGORY_FULL_IDS = "destCategoryFullIds";
		#endregion

		#region Private Fields
		private int _SrcCategoryId = Int32.MinValue;
		private int _DestCategoryId = Int32.MinValue;
		private int _LastMovedCategoryId = Int32.MinValue;
		private int _LastMovedCategoryPageIndex = Int32.MinValue;
		private int _LastMovedCategoryEntryPageIndex = Int32.MinValue;
		private bool? _MoveFromChildren = null;
		private string _DestCategoryFullIds = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use SrcCategoryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SrcCategoryId
		{
			get { return _SrcCategoryId; }
			set 
			{ 
				_SrcCategoryId = value;
				OnPropertyChanged("SrcCategoryId");
			}
		}
		/// <summary>
		/// Use DestCategoryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DestCategoryId
		{
			get { return _DestCategoryId; }
			set 
			{ 
				_DestCategoryId = value;
				OnPropertyChanged("DestCategoryId");
			}
		}
		/// <summary>
		/// Use LastMovedCategoryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LastMovedCategoryId
		{
			get { return _LastMovedCategoryId; }
			set 
			{ 
				_LastMovedCategoryId = value;
				OnPropertyChanged("LastMovedCategoryId");
			}
		}
		/// <summary>
		/// Use LastMovedCategoryPageIndexAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LastMovedCategoryPageIndex
		{
			get { return _LastMovedCategoryPageIndex; }
			set 
			{ 
				_LastMovedCategoryPageIndex = value;
				OnPropertyChanged("LastMovedCategoryPageIndex");
			}
		}
		/// <summary>
		/// Use LastMovedCategoryEntryPageIndexAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LastMovedCategoryEntryPageIndex
		{
			get { return _LastMovedCategoryEntryPageIndex; }
			set 
			{ 
				_LastMovedCategoryEntryPageIndex = value;
				OnPropertyChanged("LastMovedCategoryEntryPageIndex");
			}
		}
		/// <summary>
		/// Use MoveFromChildrenAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? MoveFromChildren
		{
			get { return _MoveFromChildren; }
			set 
			{ 
				_MoveFromChildren = value;
				OnPropertyChanged("MoveFromChildren");
			}
		}
		/// <summary>
		/// Use DestCategoryFullIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DestCategoryFullIds
		{
			get { return _DestCategoryFullIds; }
			set 
			{ 
				_DestCategoryFullIds = value;
				OnPropertyChanged("DestCategoryFullIds");
			}
		}
		#endregion

		#region CTor
		public MoveCategoryEntriesJobData()
		{
		}

		public MoveCategoryEntriesJobData(JToken node) : base(node)
		{
			if(node["srcCategoryId"] != null)
			{
				this._SrcCategoryId = ParseInt(node["srcCategoryId"].Value<string>());
			}
			if(node["destCategoryId"] != null)
			{
				this._DestCategoryId = ParseInt(node["destCategoryId"].Value<string>());
			}
			if(node["lastMovedCategoryId"] != null)
			{
				this._LastMovedCategoryId = ParseInt(node["lastMovedCategoryId"].Value<string>());
			}
			if(node["lastMovedCategoryPageIndex"] != null)
			{
				this._LastMovedCategoryPageIndex = ParseInt(node["lastMovedCategoryPageIndex"].Value<string>());
			}
			if(node["lastMovedCategoryEntryPageIndex"] != null)
			{
				this._LastMovedCategoryEntryPageIndex = ParseInt(node["lastMovedCategoryEntryPageIndex"].Value<string>());
			}
			if(node["moveFromChildren"] != null)
			{
				this._MoveFromChildren = ParseBool(node["moveFromChildren"].Value<string>());
			}
			if(node["destCategoryFullIds"] != null)
			{
				this._DestCategoryFullIds = node["destCategoryFullIds"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMoveCategoryEntriesJobData");
			kparams.AddIfNotNull("srcCategoryId", this._SrcCategoryId);
			kparams.AddIfNotNull("destCategoryId", this._DestCategoryId);
			kparams.AddIfNotNull("lastMovedCategoryId", this._LastMovedCategoryId);
			kparams.AddIfNotNull("lastMovedCategoryPageIndex", this._LastMovedCategoryPageIndex);
			kparams.AddIfNotNull("lastMovedCategoryEntryPageIndex", this._LastMovedCategoryEntryPageIndex);
			kparams.AddIfNotNull("moveFromChildren", this._MoveFromChildren);
			kparams.AddIfNotNull("destCategoryFullIds", this._DestCategoryFullIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SRC_CATEGORY_ID:
					return "SrcCategoryId";
				case DEST_CATEGORY_ID:
					return "DestCategoryId";
				case LAST_MOVED_CATEGORY_ID:
					return "LastMovedCategoryId";
				case LAST_MOVED_CATEGORY_PAGE_INDEX:
					return "LastMovedCategoryPageIndex";
				case LAST_MOVED_CATEGORY_ENTRY_PAGE_INDEX:
					return "LastMovedCategoryEntryPageIndex";
				case MOVE_FROM_CHILDREN:
					return "MoveFromChildren";
				case DEST_CATEGORY_FULL_IDS:
					return "DestCategoryFullIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

