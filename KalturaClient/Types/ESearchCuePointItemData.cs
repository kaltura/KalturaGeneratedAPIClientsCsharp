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
// Copyright (C) 2006-2017  Kaltura Inc.
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
		public string CuePointType
		{
			get { return _CuePointType; }
			set 
			{ 
				_CuePointType = value;
				OnPropertyChanged("CuePointType");
			}
		}
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string Text
		{
			get { return _Text; }
			set 
			{ 
				_Text = value;
				OnPropertyChanged("Text");
			}
		}
		public IList<String> Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		public string EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		public string SubType
		{
			get { return _SubType; }
			set 
			{ 
				_SubType = value;
				OnPropertyChanged("SubType");
			}
		}
		public string Question
		{
			get { return _Question; }
			set 
			{ 
				_Question = value;
				OnPropertyChanged("Question");
			}
		}
		public IList<String> Answers
		{
			get { return _Answers; }
			set 
			{ 
				_Answers = value;
				OnPropertyChanged("Answers");
			}
		}
		public string Hint
		{
			get { return _Hint; }
			set 
			{ 
				_Hint = value;
				OnPropertyChanged("Hint");
			}
		}
		public string Explanation
		{
			get { return _Explanation; }
			set 
			{ 
				_Explanation = value;
				OnPropertyChanged("Explanation");
			}
		}
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

		public ESearchCuePointItemData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "cuePointType":
						this._CuePointType = propertyNode.InnerText;
						continue;
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "text":
						this._Text = propertyNode.InnerText;
						continue;
					case "tags":
						this._Tags = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Tags.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
					case "startTime":
						this._StartTime = propertyNode.InnerText;
						continue;
					case "endTime":
						this._EndTime = propertyNode.InnerText;
						continue;
					case "subType":
						this._SubType = propertyNode.InnerText;
						continue;
					case "question":
						this._Question = propertyNode.InnerText;
						continue;
					case "answers":
						this._Answers = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Answers.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
					case "hint":
						this._Hint = propertyNode.InnerText;
						continue;
					case "explanation":
						this._Explanation = propertyNode.InnerText;
						continue;
					case "assetId":
						this._AssetId = propertyNode.InnerText;
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

