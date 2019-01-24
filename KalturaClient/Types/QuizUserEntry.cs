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
	public class QuizUserEntry : UserEntry
	{
		#region Constants
		public const string SCORE = "score";
		public const string FEEDBACK = "feedback";
		#endregion

		#region Private Fields
		private float _Score = Single.MinValue;
		private string _Feedback = null;
		#endregion

		#region Properties
		[JsonProperty]
		public float Score
		{
			get { return _Score; }
			private set 
			{ 
				_Score = value;
				OnPropertyChanged("Score");
			}
		}
		[JsonProperty]
		public string Feedback
		{
			get { return _Feedback; }
			set 
			{ 
				_Feedback = value;
				OnPropertyChanged("Feedback");
			}
		}
		#endregion

		#region CTor
		public QuizUserEntry()
		{
		}

		public QuizUserEntry(JToken node) : base(node)
		{
			if(node["score"] != null)
			{
				this._Score = ParseFloat(node["score"].Value<string>());
			}
			if(node["feedback"] != null)
			{
				this._Feedback = node["feedback"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaQuizUserEntry");
			kparams.AddIfNotNull("score", this._Score);
			kparams.AddIfNotNull("feedback", this._Feedback);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SCORE:
					return "Score";
				case FEEDBACK:
					return "Feedback";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

