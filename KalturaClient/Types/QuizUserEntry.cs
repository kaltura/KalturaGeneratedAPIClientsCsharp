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
	public class QuizUserEntry : UserEntry
	{
		#region Constants
		public const string SCORE = "score";
		public const string CALCULATED_SCORE = "calculatedScore";
		public const string FEEDBACK = "feedback";
		public const string VERSION = "version";
		#endregion

		#region Private Fields
		private float _Score = Single.MinValue;
		private float _CalculatedScore = Single.MinValue;
		private string _Feedback = null;
		private int _Version = Int32.MinValue;
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
		public float CalculatedScore
		{
			get { return _CalculatedScore; }
			private set 
			{ 
				_CalculatedScore = value;
				OnPropertyChanged("CalculatedScore");
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
		[JsonProperty]
		public int Version
		{
			get { return _Version; }
			private set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
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
			if(node["calculatedScore"] != null)
			{
				this._CalculatedScore = ParseFloat(node["calculatedScore"].Value<string>());
			}
			if(node["feedback"] != null)
			{
				this._Feedback = node["feedback"].Value<string>();
			}
			if(node["version"] != null)
			{
				this._Version = ParseInt(node["version"].Value<string>());
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
			kparams.AddIfNotNull("calculatedScore", this._CalculatedScore);
			kparams.AddIfNotNull("feedback", this._Feedback);
			kparams.AddIfNotNull("version", this._Version);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SCORE:
					return "Score";
				case CALCULATED_SCORE:
					return "CalculatedScore";
				case FEEDBACK:
					return "Feedback";
				case VERSION:
					return "Version";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

