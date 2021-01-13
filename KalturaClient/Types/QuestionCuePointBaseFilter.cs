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
	public class QuestionCuePointBaseFilter : CuePointFilter
	{
		#region Constants
		public const string QUESTION_LIKE = "questionLike";
		public const string QUESTION_MULTI_LIKE_OR = "questionMultiLikeOr";
		public const string QUESTION_MULTI_LIKE_AND = "questionMultiLikeAnd";
		#endregion

		#region Private Fields
		private string _QuestionLike = null;
		private string _QuestionMultiLikeOr = null;
		private string _QuestionMultiLikeAnd = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string QuestionLike
		{
			get { return _QuestionLike; }
			set 
			{ 
				_QuestionLike = value;
				OnPropertyChanged("QuestionLike");
			}
		}
		[JsonProperty]
		public string QuestionMultiLikeOr
		{
			get { return _QuestionMultiLikeOr; }
			set 
			{ 
				_QuestionMultiLikeOr = value;
				OnPropertyChanged("QuestionMultiLikeOr");
			}
		}
		[JsonProperty]
		public string QuestionMultiLikeAnd
		{
			get { return _QuestionMultiLikeAnd; }
			set 
			{ 
				_QuestionMultiLikeAnd = value;
				OnPropertyChanged("QuestionMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public QuestionCuePointBaseFilter()
		{
		}

		public QuestionCuePointBaseFilter(JToken node) : base(node)
		{
			if(node["questionLike"] != null)
			{
				this._QuestionLike = node["questionLike"].Value<string>();
			}
			if(node["questionMultiLikeOr"] != null)
			{
				this._QuestionMultiLikeOr = node["questionMultiLikeOr"].Value<string>();
			}
			if(node["questionMultiLikeAnd"] != null)
			{
				this._QuestionMultiLikeAnd = node["questionMultiLikeAnd"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaQuestionCuePointBaseFilter");
			kparams.AddIfNotNull("questionLike", this._QuestionLike);
			kparams.AddIfNotNull("questionMultiLikeOr", this._QuestionMultiLikeOr);
			kparams.AddIfNotNull("questionMultiLikeAnd", this._QuestionMultiLikeAnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case QUESTION_LIKE:
					return "QuestionLike";
				case QUESTION_MULTI_LIKE_OR:
					return "QuestionMultiLikeOr";
				case QUESTION_MULTI_LIKE_AND:
					return "QuestionMultiLikeAnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

