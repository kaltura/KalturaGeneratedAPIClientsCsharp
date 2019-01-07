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
	public class AnswerCuePoint : CuePoint
	{
		#region Constants
		public const string PARENT_ID = "parentId";
		public const string QUIZ_USER_ENTRY_ID = "quizUserEntryId";
		public const string ANSWER_KEY = "answerKey";
		public const string IS_CORRECT = "isCorrect";
		public const string CORRECT_ANSWER_KEYS = "correctAnswerKeys";
		public const string EXPLANATION = "explanation";
		#endregion

		#region Private Fields
		private string _ParentId = null;
		private string _QuizUserEntryId = null;
		private string _AnswerKey = null;
		private NullableBoolean _IsCorrect = (NullableBoolean)Int32.MinValue;
		private IList<String> _CorrectAnswerKeys;
		private string _Explanation = null;
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
		public string QuizUserEntryId
		{
			get { return _QuizUserEntryId; }
			set 
			{ 
				_QuizUserEntryId = value;
				OnPropertyChanged("QuizUserEntryId");
			}
		}
		[JsonProperty]
		public string AnswerKey
		{
			get { return _AnswerKey; }
			set 
			{ 
				_AnswerKey = value;
				OnPropertyChanged("AnswerKey");
			}
		}
		[JsonProperty]
		public NullableBoolean IsCorrect
		{
			get { return _IsCorrect; }
			private set 
			{ 
				_IsCorrect = value;
				OnPropertyChanged("IsCorrect");
			}
		}
		[JsonProperty]
		public IList<String> CorrectAnswerKeys
		{
			get { return _CorrectAnswerKeys; }
			private set 
			{ 
				_CorrectAnswerKeys = value;
				OnPropertyChanged("CorrectAnswerKeys");
			}
		}
		[JsonProperty]
		public string Explanation
		{
			get { return _Explanation; }
			private set 
			{ 
				_Explanation = value;
				OnPropertyChanged("Explanation");
			}
		}
		#endregion

		#region CTor
		public AnswerCuePoint()
		{
		}

		public AnswerCuePoint(JToken node) : base(node)
		{
			if(node["parentId"] != null)
			{
				this._ParentId = node["parentId"].Value<string>();
			}
			if(node["quizUserEntryId"] != null)
			{
				this._QuizUserEntryId = node["quizUserEntryId"].Value<string>();
			}
			if(node["answerKey"] != null)
			{
				this._AnswerKey = node["answerKey"].Value<string>();
			}
			if(node["isCorrect"] != null)
			{
				this._IsCorrect = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isCorrect"].Value<string>());
			}
			if(node["correctAnswerKeys"] != null)
			{
				this._CorrectAnswerKeys = new List<String>();
				foreach(var arrayNode in node["correctAnswerKeys"].Children())
				{
					this._CorrectAnswerKeys.Add(ObjectFactory.Create<String>(arrayNode));
				}
			}
			if(node["explanation"] != null)
			{
				this._Explanation = node["explanation"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAnswerCuePoint");
			kparams.AddIfNotNull("parentId", this._ParentId);
			kparams.AddIfNotNull("quizUserEntryId", this._QuizUserEntryId);
			kparams.AddIfNotNull("answerKey", this._AnswerKey);
			kparams.AddIfNotNull("isCorrect", this._IsCorrect);
			kparams.AddIfNotNull("correctAnswerKeys", this._CorrectAnswerKeys);
			kparams.AddIfNotNull("explanation", this._Explanation);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARENT_ID:
					return "ParentId";
				case QUIZ_USER_ENTRY_ID:
					return "QuizUserEntryId";
				case ANSWER_KEY:
					return "AnswerKey";
				case IS_CORRECT:
					return "IsCorrect";
				case CORRECT_ANSWER_KEYS:
					return "CorrectAnswerKeys";
				case EXPLANATION:
					return "Explanation";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

