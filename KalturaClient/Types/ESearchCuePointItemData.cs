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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class ESearchCuePointItemData : ESearchItemData
	{
		#region Constants
		public const string CUE_POINT_TYPE = "cuePointType";
		public const string ID = "id";
		public const string NAME = "name";
		public const string TEXT = "text";
		public const string TAGS = "tags";
		public const string START_TIME = "startTime";
		public const string END_TIME = "endTime";
		public const string SUB_TYPE = "subType";
		public const string QUESTION = "question";
		public const string ANSWERS = "answers";
		public const string HINT = "hint";
		public const string EXPLANATION = "explanation";
		public const string ASSET_ID = "assetId";
		#endregion

		#region Private Fields
		private string _CuePointType = null;
		private string _Id = null;
		private string _Name = null;
		private string _Text = null;
		private IList<String> _Tags;
		private string _StartTime = null;
		private string _EndTime = null;
		private string _SubType = null;
		private string _Question = null;
		private IList<String> _Answers;
		private string _Hint = null;
		private string _Explanation = null;
		private string _AssetId = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string CuePointType
		{
			get { return _CuePointType; }
			set 
			{ 
				_CuePointType = value;
				OnPropertyChanged("CuePointType");
			}
		}
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
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
		public IList<String> Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		[JsonProperty]
		public string StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		[JsonProperty]
		public string EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		[JsonProperty]
		public string SubType
		{
			get { return _SubType; }
			set 
			{ 
				_SubType = value;
				OnPropertyChanged("SubType");
			}
		}
		[JsonProperty]
		public string Question
		{
			get { return _Question; }
			set 
			{ 
				_Question = value;
				OnPropertyChanged("Question");
			}
		}
		[JsonProperty]
		public IList<String> Answers
		{
			get { return _Answers; }
			set 
			{ 
				_Answers = value;
				OnPropertyChanged("Answers");
			}
		}
		[JsonProperty]
		public string Hint
		{
			get { return _Hint; }
			set 
			{ 
				_Hint = value;
				OnPropertyChanged("Hint");
			}
		}
		[JsonProperty]
		public string Explanation
		{
			get { return _Explanation; }
			set 
			{ 
				_Explanation = value;
				OnPropertyChanged("Explanation");
			}
		}
		[JsonProperty]
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		#endregion

		#region CTor
		public ESearchCuePointItemData()
		{
		}

		public ESearchCuePointItemData(JToken node) : base(node)
		{
			if(node["cuePointType"] != null)
			{
				this._CuePointType = node["cuePointType"].Value<string>();
			}
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["text"] != null)
			{
				this._Text = node["text"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = new List<String>();
				foreach(var arrayNode in node["tags"].Children())
				{
					this._Tags.Add(ObjectFactory.Create<String>(arrayNode));
				}
			}
			if(node["startTime"] != null)
			{
				this._StartTime = node["startTime"].Value<string>();
			}
			if(node["endTime"] != null)
			{
				this._EndTime = node["endTime"].Value<string>();
			}
			if(node["subType"] != null)
			{
				this._SubType = node["subType"].Value<string>();
			}
			if(node["question"] != null)
			{
				this._Question = node["question"].Value<string>();
			}
			if(node["answers"] != null)
			{
				this._Answers = new List<String>();
				foreach(var arrayNode in node["answers"].Children())
				{
					this._Answers.Add(ObjectFactory.Create<String>(arrayNode));
				}
			}
			if(node["hint"] != null)
			{
				this._Hint = node["hint"].Value<string>();
			}
			if(node["explanation"] != null)
			{
				this._Explanation = node["explanation"].Value<string>();
			}
			if(node["assetId"] != null)
			{
				this._AssetId = node["assetId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchCuePointItemData");
			kparams.AddIfNotNull("cuePointType", this._CuePointType);
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("text", this._Text);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("startTime", this._StartTime);
			kparams.AddIfNotNull("endTime", this._EndTime);
			kparams.AddIfNotNull("subType", this._SubType);
			kparams.AddIfNotNull("question", this._Question);
			kparams.AddIfNotNull("answers", this._Answers);
			kparams.AddIfNotNull("hint", this._Hint);
			kparams.AddIfNotNull("explanation", this._Explanation);
			kparams.AddIfNotNull("assetId", this._AssetId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CUE_POINT_TYPE:
					return "CuePointType";
				case ID:
					return "Id";
				case NAME:
					return "Name";
				case TEXT:
					return "Text";
				case TAGS:
					return "Tags";
				case START_TIME:
					return "StartTime";
				case END_TIME:
					return "EndTime";
				case SUB_TYPE:
					return "SubType";
				case QUESTION:
					return "Question";
				case ANSWERS:
					return "Answers";
				case HINT:
					return "Hint";
				case EXPLANATION:
					return "Explanation";
				case ASSET_ID:
					return "AssetId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

