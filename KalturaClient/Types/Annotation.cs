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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class Annotation : CuePoint
	{
		#region Constants
		public const string PARENT_ID = "parentId";
		public const string TEXT = "text";
		public const string END_TIME = "endTime";
		public const string DURATION = "duration";
		public const string DEPTH = "depth";
		public const string CHILDREN_COUNT = "childrenCount";
		public const string DIRECT_CHILDREN_COUNT = "directChildrenCount";
		public const string IS_PUBLIC = "isPublic";
		public const string SEARCHABLE_ON_ENTRY = "searchableOnEntry";
		#endregion

		#region Private Fields
		private string _ParentId = null;
		private string _Text = null;
		private int _EndTime = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private int _Depth = Int32.MinValue;
		private int _ChildrenCount = Int32.MinValue;
		private int _DirectChildrenCount = Int32.MinValue;
		private NullableBoolean _IsPublic = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _SearchableOnEntry = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		[JsonProperty]
		public string Text
		{
			get { return _Text; }
			set 
			{ 
				_Text = value;
				OnPropertyChanged("Text");
			}
		}
		[JsonProperty]
		public int EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		[JsonProperty]
		public int Duration
		{
			get { return _Duration; }
			private set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		[JsonProperty]
		public int Depth
		{
			get { return _Depth; }
			private set 
			{ 
				_Depth = value;
				OnPropertyChanged("Depth");
			}
		}
		[JsonProperty]
		public int ChildrenCount
		{
			get { return _ChildrenCount; }
			private set 
			{ 
				_ChildrenCount = value;
				OnPropertyChanged("ChildrenCount");
			}
		}
		[JsonProperty]
		public int DirectChildrenCount
		{
			get { return _DirectChildrenCount; }
			private set 
			{ 
				_DirectChildrenCount = value;
				OnPropertyChanged("DirectChildrenCount");
			}
		}
		[JsonProperty]
		public NullableBoolean IsPublic
		{
			get { return _IsPublic; }
			set 
			{ 
				_IsPublic = value;
				OnPropertyChanged("IsPublic");
			}
		}
		[JsonProperty]
		public NullableBoolean SearchableOnEntry
		{
			get { return _SearchableOnEntry; }
			set 
			{ 
				_SearchableOnEntry = value;
				OnPropertyChanged("SearchableOnEntry");
			}
		}
		#endregion

		#region CTor
		public Annotation()
		{
		}

		public Annotation(JToken node) : base(node)
		{
			if(node["parentId"] != null)
			{
				this._ParentId = node["parentId"].Value<string>();
			}
			if(node["text"] != null)
			{
				this._Text = node["text"].Value<string>();
			}
			if(node["endTime"] != null)
			{
				this._EndTime = ParseInt(node["endTime"].Value<string>());
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseInt(node["duration"].Value<string>());
			}
			if(node["depth"] != null)
			{
				this._Depth = ParseInt(node["depth"].Value<string>());
			}
			if(node["childrenCount"] != null)
			{
				this._ChildrenCount = ParseInt(node["childrenCount"].Value<string>());
			}
			if(node["directChildrenCount"] != null)
			{
				this._DirectChildrenCount = ParseInt(node["directChildrenCount"].Value<string>());
			}
			if(node["isPublic"] != null)
			{
				this._IsPublic = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isPublic"].Value<string>());
			}
			if(node["searchableOnEntry"] != null)
			{
				this._SearchableOnEntry = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["searchableOnEntry"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAnnotation");
			kparams.AddIfNotNull("parentId", this._ParentId);
			kparams.AddIfNotNull("text", this._Text);
			kparams.AddIfNotNull("endTime", this._EndTime);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("depth", this._Depth);
			kparams.AddIfNotNull("childrenCount", this._ChildrenCount);
			kparams.AddIfNotNull("directChildrenCount", this._DirectChildrenCount);
			kparams.AddIfNotNull("isPublic", this._IsPublic);
			kparams.AddIfNotNull("searchableOnEntry", this._SearchableOnEntry);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARENT_ID:
					return "ParentId";
				case TEXT:
					return "Text";
				case END_TIME:
					return "EndTime";
				case DURATION:
					return "Duration";
				case DEPTH:
					return "Depth";
				case CHILDREN_COUNT:
					return "ChildrenCount";
				case DIRECT_CHILDREN_COUNT:
					return "DirectChildrenCount";
				case IS_PUBLIC:
					return "IsPublic";
				case SEARCHABLE_ON_ENTRY:
					return "SearchableOnEntry";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

