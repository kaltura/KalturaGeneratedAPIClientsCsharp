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
	public class KalturaQuestionCuePoint : KalturaCuePoint
	{
		#region Private Fields
		private Dictionary<string, KalturaOptionalAnswer> _OptionalAnswers;
		private string _Hint = null;
		private string _Question = null;
		private string _Explanation = null;
		#endregion

		#region Properties
		public Dictionary<string, KalturaOptionalAnswer> OptionalAnswers
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
		#endregion

		#region CTor
		public KalturaQuestionCuePoint()
		{
		}

		public KalturaQuestionCuePoint(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "optionalAnswers":
						{
							int index = 0;
							this.OptionalAnswers = new Dictionary<string, KalturaOptionalAnswer>();
							foreach(XmlElement arrayNode in propertyNode.ChildNodes)
							{
								this.OptionalAnswers[index.ToString()] = (KalturaOptionalAnswer)KalturaObjectFactory.Create(arrayNode, "KalturaOptionalAnswer");
								index++;
							}
						}
						continue;
					case "hint":
						this.Hint = txt;
						continue;
					case "question":
						this.Question = txt;
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
			kparams.AddReplace("objectType", "KalturaQuestionCuePoint");
			if (this.OptionalAnswers != null)
			{
				if (this.OptionalAnswers.Count == 0)
				{
					kparams.Add("optionalAnswers:-", "");
				}
				else
				{
					foreach (KeyValuePair<string, KalturaOptionalAnswer> curEntry in this.OptionalAnswers)
					{
						kparams.Add("optionalAnswers:" + curEntry.Key, curEntry.Value.ToParams());
					}
				}
			}
			kparams.AddStringIfNotNull("hint", this.Hint);
			kparams.AddStringIfNotNull("question", this.Question);
			kparams.AddStringIfNotNull("explanation", this.Explanation);
			return kparams;
		}
		#endregion
	}
}

