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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class AnswerCuePointBaseFilter : CuePointFilter
	{
		#region Constants
		public const string PARENT_ID_EQUAL = "parentIdEqual";
		public const string PARENT_ID_IN = "parentIdIn";
		public const string QUIZ_USER_ENTRY_ID_EQUAL = "quizUserEntryIdEqual";
		public const string QUIZ_USER_ENTRY_ID_IN = "quizUserEntryIdIn";
		#endregion

		#region Private Fields
		private string _ParentIdEqual = null;
		private string _ParentIdIn = null;
		private string _QuizUserEntryIdEqual = null;
		private string _QuizUserEntryIdIn = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ParentIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParentIdEqual
		{
			get { return _ParentIdEqual; }
			set 
			{ 
				_ParentIdEqual = value;
				OnPropertyChanged("ParentIdEqual");
			}
		}
		/// <summary>
		/// Use ParentIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParentIdIn
		{
			get { return _ParentIdIn; }
			set 
			{ 
				_ParentIdIn = value;
				OnPropertyChanged("ParentIdIn");
			}
		}
		/// <summary>
		/// Use QuizUserEntryIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string QuizUserEntryIdEqual
		{
			get { return _QuizUserEntryIdEqual; }
			set 
			{ 
				_QuizUserEntryIdEqual = value;
				OnPropertyChanged("QuizUserEntryIdEqual");
			}
		}
		/// <summary>
		/// Use QuizUserEntryIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string QuizUserEntryIdIn
		{
			get { return _QuizUserEntryIdIn; }
			set 
			{ 
				_QuizUserEntryIdIn = value;
				OnPropertyChanged("QuizUserEntryIdIn");
			}
		}
		#endregion

		#region CTor
		public AnswerCuePointBaseFilter()
		{
		}

		public AnswerCuePointBaseFilter(JToken node) : base(node)
		{
			if(node["parentIdEqual"] != null)
			{
				this._ParentIdEqual = node["parentIdEqual"].Value<string>();
			}
			if(node["parentIdIn"] != null)
			{
				this._ParentIdIn = node["parentIdIn"].Value<string>();
			}
			if(node["quizUserEntryIdEqual"] != null)
			{
				this._QuizUserEntryIdEqual = node["quizUserEntryIdEqual"].Value<string>();
			}
			if(node["quizUserEntryIdIn"] != null)
			{
				this._QuizUserEntryIdIn = node["quizUserEntryIdIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAnswerCuePointBaseFilter");
			kparams.AddIfNotNull("parentIdEqual", this._ParentIdEqual);
			kparams.AddIfNotNull("parentIdIn", this._ParentIdIn);
			kparams.AddIfNotNull("quizUserEntryIdEqual", this._QuizUserEntryIdEqual);
			kparams.AddIfNotNull("quizUserEntryIdIn", this._QuizUserEntryIdIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARENT_ID_EQUAL:
					return "ParentIdEqual";
				case PARENT_ID_IN:
					return "ParentIdIn";
				case QUIZ_USER_ENTRY_ID_EQUAL:
					return "QuizUserEntryIdEqual";
				case QUIZ_USER_ENTRY_ID_IN:
					return "QuizUserEntryIdIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

