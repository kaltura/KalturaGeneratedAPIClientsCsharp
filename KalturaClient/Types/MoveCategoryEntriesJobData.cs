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
		public int SrcCategoryId
		{
			get { return _SrcCategoryId; }
			set 
			{ 
				_SrcCategoryId = value;
				OnPropertyChanged("SrcCategoryId");
			}
		}
		public int DestCategoryId
		{
			get { return _DestCategoryId; }
			set 
			{ 
				_DestCategoryId = value;
				OnPropertyChanged("DestCategoryId");
			}
		}
		public int LastMovedCategoryId
		{
			get { return _LastMovedCategoryId; }
			set 
			{ 
				_LastMovedCategoryId = value;
				OnPropertyChanged("LastMovedCategoryId");
			}
		}
		public int LastMovedCategoryPageIndex
		{
			get { return _LastMovedCategoryPageIndex; }
			set 
			{ 
				_LastMovedCategoryPageIndex = value;
				OnPropertyChanged("LastMovedCategoryPageIndex");
			}
		}
		public int LastMovedCategoryEntryPageIndex
		{
			get { return _LastMovedCategoryEntryPageIndex; }
			set 
			{ 
				_LastMovedCategoryEntryPageIndex = value;
				OnPropertyChanged("LastMovedCategoryEntryPageIndex");
			}
		}
		public bool? MoveFromChildren
		{
			get { return _MoveFromChildren; }
			set 
			{ 
				_MoveFromChildren = value;
				OnPropertyChanged("MoveFromChildren");
			}
		}
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

		public MoveCategoryEntriesJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "srcCategoryId":
						this._SrcCategoryId = ParseInt(txt);
						continue;
					case "destCategoryId":
						this._DestCategoryId = ParseInt(txt);
						continue;
					case "lastMovedCategoryId":
						this._LastMovedCategoryId = ParseInt(txt);
						continue;
					case "lastMovedCategoryPageIndex":
						this._LastMovedCategoryPageIndex = ParseInt(txt);
						continue;
					case "lastMovedCategoryEntryPageIndex":
						this._LastMovedCategoryEntryPageIndex = ParseInt(txt);
						continue;
					case "moveFromChildren":
						this._MoveFromChildren = ParseBool(txt);
						continue;
					case "destCategoryFullIds":
						this._DestCategoryFullIds = txt;
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

