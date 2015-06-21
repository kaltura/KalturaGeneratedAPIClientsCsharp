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
// Copyright (C) 2006-2015  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaAnswerCuePoint : KalturaCuePoint
	{
		#region Private Fields
		private string _ParentId = null;
		private string _QuizUserEntryId = null;
		private string _AnswerKey = null;
		private KalturaNullableBoolean _IsCorrect = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaTypedArray _CorrectAnswerKeys;
		private string _Explanation = null;
		#endregion

		#region Properties
		public string ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		public string QuizUserEntryId
		{
			get { return _QuizUserEntryId; }
			set 
			{ 
				_QuizUserEntryId = value;
				OnPropertyChanged("QuizUserEntryId");
			}
		}
		public string AnswerKey
		{
			get { return _AnswerKey; }
			set 
			{ 
				_AnswerKey = value;
				OnPropertyChanged("AnswerKey");
			}
		}
		public KalturaNullableBoolean IsCorrect
		{
			get { return _IsCorrect; }
			set 
			{ 
				_IsCorrect = value;
				OnPropertyChanged("IsCorrect");
			}
		}
		public KalturaTypedArray CorrectAnswerKeys
		{
			get { return _CorrectAnswerKeys; }
			set 
			{ 
				_CorrectAnswerKeys = value;
				OnPropertyChanged("CorrectAnswerKeys");
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
		#endregion

		#region CTor
		public KalturaAnswerCuePoint()
		{
		}

		public KalturaAnswerCuePoint(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "parentId":
						this.ParentId = txt;
						continue;
					case "quizUserEntryId":
						this.QuizUserEntryId = txt;
						continue;
					case "answerKey":
						this.AnswerKey = txt;
						continue;
					case "isCorrect":
						this.IsCorrect = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "correctAnswerKeys":
						this.CorrectAnswerKeys = (KalturaTypedArray)KalturaObjectFactory.Create(propertyNode, "KalturaTypedArray");
						continue;
					case "explanation":
						this.Explanation = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAnswerCuePoint");
			kparams.AddStringIfNotNull("parentId", this.ParentId);
			kparams.AddStringIfNotNull("quizUserEntryId", this.QuizUserEntryId);
			kparams.AddStringIfNotNull("answerKey", this.AnswerKey);
			kparams.AddEnumIfNotNull("isCorrect", this.IsCorrect);
			if (this.CorrectAnswerKeys != null)
				kparams.Add("correctAnswerKeys", this.CorrectAnswerKeys.ToParams());
			kparams.AddStringIfNotNull("explanation", this.Explanation);
			return kparams;
		}
		#endregion
	}
}

