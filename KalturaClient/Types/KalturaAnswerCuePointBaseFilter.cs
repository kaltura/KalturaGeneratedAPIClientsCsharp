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
	public class KalturaAnswerCuePointBaseFilter : KalturaCuePointFilter
	{
		#region Private Fields
		private string _ParentIdEqual = null;
		private string _ParentIdIn = null;
		private string _QuizUserEntryIdEqual = null;
		private string _QuizUserEntryIdIn = null;
		#endregion

		#region Properties
		public string ParentIdEqual
		{
			get { return _ParentIdEqual; }
			set 
			{ 
				_ParentIdEqual = value;
				OnPropertyChanged("ParentIdEqual");
			}
		}
		public string ParentIdIn
		{
			get { return _ParentIdIn; }
			set 
			{ 
				_ParentIdIn = value;
				OnPropertyChanged("ParentIdIn");
			}
		}
		public string QuizUserEntryIdEqual
		{
			get { return _QuizUserEntryIdEqual; }
			set 
			{ 
				_QuizUserEntryIdEqual = value;
				OnPropertyChanged("QuizUserEntryIdEqual");
			}
		}
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
		public KalturaAnswerCuePointBaseFilter()
		{
		}

		public KalturaAnswerCuePointBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "parentIdEqual":
						this.ParentIdEqual = txt;
						continue;
					case "parentIdIn":
						this.ParentIdIn = txt;
						continue;
					case "quizUserEntryIdEqual":
						this.QuizUserEntryIdEqual = txt;
						continue;
					case "quizUserEntryIdIn":
						this.QuizUserEntryIdIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAnswerCuePointBaseFilter");
			kparams.AddIfNotNull("parentIdEqual", this.ParentIdEqual);
			kparams.AddIfNotNull("parentIdIn", this.ParentIdIn);
			kparams.AddIfNotNull("quizUserEntryIdEqual", this.QuizUserEntryIdEqual);
			kparams.AddIfNotNull("quizUserEntryIdIn", this.QuizUserEntryIdIn);
			return kparams;
		}
		#endregion
	}
}

