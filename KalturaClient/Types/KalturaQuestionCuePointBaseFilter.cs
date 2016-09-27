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

namespace Kaltura
{
	public class KalturaQuestionCuePointBaseFilter : KalturaCuePointFilter
	{
		#region Private Fields
		private string _QuestionLike = null;
		private string _QuestionMultiLikeOr = null;
		private string _QuestionMultiLikeAnd = null;
		#endregion

		#region Properties
		public string QuestionLike
		{
			get { return _QuestionLike; }
			set 
			{ 
				_QuestionLike = value;
				OnPropertyChanged("QuestionLike");
			}
		}
		public string QuestionMultiLikeOr
		{
			get { return _QuestionMultiLikeOr; }
			set 
			{ 
				_QuestionMultiLikeOr = value;
				OnPropertyChanged("QuestionMultiLikeOr");
			}
		}
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
		public KalturaQuestionCuePointBaseFilter()
		{
		}

		public KalturaQuestionCuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "questionLike":
						this._QuestionLike = txt;
						continue;
					case "questionMultiLikeOr":
						this._QuestionMultiLikeOr = txt;
						continue;
					case "questionMultiLikeAnd":
						this._QuestionMultiLikeAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaQuestionCuePointBaseFilter");
			kparams.AddIfNotNull("questionLike", this._QuestionLike);
			kparams.AddIfNotNull("questionMultiLikeOr", this._QuestionMultiLikeOr);
			kparams.AddIfNotNull("questionMultiLikeAnd", this._QuestionMultiLikeAnd);
			return kparams;
		}
		#endregion
	}
}

