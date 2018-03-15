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

namespace Kaltura.Types
{
	public class QuestionCuePoint : CuePoint
	{
		#region Constants
		public const string OPTIONAL_ANSWERS = "optionalAnswers";
		public const string HINT = "hint";
		public const string QUESTION = "question";
		public const string EXPLANATION = "explanation";
		public const string QUESTION_TYPE = "questionType";
		public const string PRESENTATION_ORDER = "presentationOrder";
		public const string EXCLUDE_FROM_SCORE = "excludeFromScore";
		#endregion

		#region Private Fields
		private IList<OptionalAnswer> _OptionalAnswers;
		private string _Hint = null;
		private string _Question = null;
		private string _Explanation = null;
		private QuestionType _QuestionType = (QuestionType)Int32.MinValue;
		private int _PresentationOrder = Int32.MinValue;
		private NullableBoolean _ExcludeFromScore = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public IList<OptionalAnswer> OptionalAnswers
		{
			get { return _OptionalAnswers; }
			set 
			{ 
				_OptionalAnswers = value;
				OnPropertyChanged("OptionalAnswers");
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
		public string Question
		{
			get { return _Question; }
			set 
			{ 
				_Question = value;
				OnPropertyChanged("Question");
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
		public QuestionType QuestionType
		{
			get { return _QuestionType; }
			set 
			{ 
				_QuestionType = value;
				OnPropertyChanged("QuestionType");
			}
		}
		public int PresentationOrder
		{
			get { return _PresentationOrder; }
			set 
			{ 
				_PresentationOrder = value;
				OnPropertyChanged("PresentationOrder");
			}
		}
		public NullableBoolean ExcludeFromScore
		{
			get { return _ExcludeFromScore; }
			set 
			{ 
				_ExcludeFromScore = value;
				OnPropertyChanged("ExcludeFromScore");
			}
		}
		#endregion

		#region CTor
		public QuestionCuePoint()
		{
		}

		public QuestionCuePoint(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "optionalAnswers":
						this._OptionalAnswers = new List<OptionalAnswer>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._OptionalAnswers.Add(ObjectFactory.Create<OptionalAnswer>(arrayNode));
						}
						continue;
					case "hint":
						this._Hint = propertyNode.InnerText;
						continue;
					case "question":
						this._Question = propertyNode.InnerText;
						continue;
					case "explanation":
						this._Explanation = propertyNode.InnerText;
						continue;
					case "questionType":
						this._QuestionType = (QuestionType)ParseEnum(typeof(QuestionType), propertyNode.InnerText);
						continue;
					case "presentationOrder":
						this._PresentationOrder = ParseInt(propertyNode.InnerText);
						continue;
					case "excludeFromScore":
						this._ExcludeFromScore = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaQuestionCuePoint");
			kparams.AddIfNotNull("optionalAnswers", this._OptionalAnswers);
			kparams.AddIfNotNull("hint", this._Hint);
			kparams.AddIfNotNull("question", this._Question);
			kparams.AddIfNotNull("explanation", this._Explanation);
			kparams.AddIfNotNull("questionType", this._QuestionType);
			kparams.AddIfNotNull("presentationOrder", this._PresentationOrder);
			kparams.AddIfNotNull("excludeFromScore", this._ExcludeFromScore);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OPTIONAL_ANSWERS:
					return "OptionalAnswers";
				case HINT:
					return "Hint";
				case QUESTION:
					return "Question";
				case EXPLANATION:
					return "Explanation";
				case QUESTION_TYPE:
					return "QuestionType";
				case PRESENTATION_ORDER:
					return "PresentationOrder";
				case EXCLUDE_FROM_SCORE:
					return "ExcludeFromScore";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

