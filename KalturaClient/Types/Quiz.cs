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
	public class Quiz : ObjectBase
	{
		#region Constants
		public const string VERSION = "version";
		public const string UI_ATTRIBUTES = "uiAttributes";
		public const string SHOW_RESULT_ON_ANSWER = "showResultOnAnswer";
		public const string SHOW_CORRECT_KEY_ON_ANSWER = "showCorrectKeyOnAnswer";
		public const string ALLOW_ANSWER_UPDATE = "allowAnswerUpdate";
		public const string SHOW_CORRECT_AFTER_SUBMISSION = "showCorrectAfterSubmission";
		public const string ALLOW_DOWNLOAD = "allowDownload";
		public const string SHOW_GRADE_AFTER_SUBMISSION = "showGradeAfterSubmission";
		public const string ATTEMPTS_ALLOWED = "attemptsAllowed";
		public const string SCORE_TYPE = "scoreType";
		#endregion

		#region Private Fields
		private int _Version = Int32.MinValue;
		private IList<KeyValue> _UiAttributes;
		private NullableBoolean _ShowResultOnAnswer = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _ShowCorrectKeyOnAnswer = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _AllowAnswerUpdate = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _ShowCorrectAfterSubmission = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _AllowDownload = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _ShowGradeAfterSubmission = (NullableBoolean)Int32.MinValue;
		private int _AttemptsAllowed = Int32.MinValue;
		private ScoreType _ScoreType = (ScoreType)Int32.MinValue;
		#endregion

		#region Properties
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
		[JsonProperty]
		public IList<KeyValue> UiAttributes
		{
			get { return _UiAttributes; }
			set 
			{ 
				_UiAttributes = value;
				OnPropertyChanged("UiAttributes");
			}
		}
		[JsonProperty]
		public NullableBoolean ShowResultOnAnswer
		{
			get { return _ShowResultOnAnswer; }
			set 
			{ 
				_ShowResultOnAnswer = value;
				OnPropertyChanged("ShowResultOnAnswer");
			}
		}
		[JsonProperty]
		public NullableBoolean ShowCorrectKeyOnAnswer
		{
			get { return _ShowCorrectKeyOnAnswer; }
			set 
			{ 
				_ShowCorrectKeyOnAnswer = value;
				OnPropertyChanged("ShowCorrectKeyOnAnswer");
			}
		}
		[JsonProperty]
		public NullableBoolean AllowAnswerUpdate
		{
			get { return _AllowAnswerUpdate; }
			set 
			{ 
				_AllowAnswerUpdate = value;
				OnPropertyChanged("AllowAnswerUpdate");
			}
		}
		[JsonProperty]
		public NullableBoolean ShowCorrectAfterSubmission
		{
			get { return _ShowCorrectAfterSubmission; }
			set 
			{ 
				_ShowCorrectAfterSubmission = value;
				OnPropertyChanged("ShowCorrectAfterSubmission");
			}
		}
		[JsonProperty]
		public NullableBoolean AllowDownload
		{
			get { return _AllowDownload; }
			set 
			{ 
				_AllowDownload = value;
				OnPropertyChanged("AllowDownload");
			}
		}
		[JsonProperty]
		public NullableBoolean ShowGradeAfterSubmission
		{
			get { return _ShowGradeAfterSubmission; }
			set 
			{ 
				_ShowGradeAfterSubmission = value;
				OnPropertyChanged("ShowGradeAfterSubmission");
			}
		}
		[JsonProperty]
		public int AttemptsAllowed
		{
			get { return _AttemptsAllowed; }
			set 
			{ 
				_AttemptsAllowed = value;
				OnPropertyChanged("AttemptsAllowed");
			}
		}
		[JsonProperty]
		public ScoreType ScoreType
		{
			get { return _ScoreType; }
			set 
			{ 
				_ScoreType = value;
				OnPropertyChanged("ScoreType");
			}
		}
		#endregion

		#region CTor
		public Quiz()
		{
		}

		public Quiz(JToken node) : base(node)
		{
			if(node["version"] != null)
			{
				this._Version = ParseInt(node["version"].Value<string>());
			}
			if(node["uiAttributes"] != null)
			{
				this._UiAttributes = new List<KeyValue>();
				foreach(var arrayNode in node["uiAttributes"].Children())
				{
					this._UiAttributes.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["showResultOnAnswer"] != null)
			{
				this._ShowResultOnAnswer = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["showResultOnAnswer"].Value<string>());
			}
			if(node["showCorrectKeyOnAnswer"] != null)
			{
				this._ShowCorrectKeyOnAnswer = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["showCorrectKeyOnAnswer"].Value<string>());
			}
			if(node["allowAnswerUpdate"] != null)
			{
				this._AllowAnswerUpdate = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["allowAnswerUpdate"].Value<string>());
			}
			if(node["showCorrectAfterSubmission"] != null)
			{
				this._ShowCorrectAfterSubmission = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["showCorrectAfterSubmission"].Value<string>());
			}
			if(node["allowDownload"] != null)
			{
				this._AllowDownload = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["allowDownload"].Value<string>());
			}
			if(node["showGradeAfterSubmission"] != null)
			{
				this._ShowGradeAfterSubmission = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["showGradeAfterSubmission"].Value<string>());
			}
			if(node["attemptsAllowed"] != null)
			{
				this._AttemptsAllowed = ParseInt(node["attemptsAllowed"].Value<string>());
			}
			if(node["scoreType"] != null)
			{
				this._ScoreType = (ScoreType)ParseEnum(typeof(ScoreType), node["scoreType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaQuiz");
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("uiAttributes", this._UiAttributes);
			kparams.AddIfNotNull("showResultOnAnswer", this._ShowResultOnAnswer);
			kparams.AddIfNotNull("showCorrectKeyOnAnswer", this._ShowCorrectKeyOnAnswer);
			kparams.AddIfNotNull("allowAnswerUpdate", this._AllowAnswerUpdate);
			kparams.AddIfNotNull("showCorrectAfterSubmission", this._ShowCorrectAfterSubmission);
			kparams.AddIfNotNull("allowDownload", this._AllowDownload);
			kparams.AddIfNotNull("showGradeAfterSubmission", this._ShowGradeAfterSubmission);
			kparams.AddIfNotNull("attemptsAllowed", this._AttemptsAllowed);
			kparams.AddIfNotNull("scoreType", this._ScoreType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VERSION:
					return "Version";
				case UI_ATTRIBUTES:
					return "UiAttributes";
				case SHOW_RESULT_ON_ANSWER:
					return "ShowResultOnAnswer";
				case SHOW_CORRECT_KEY_ON_ANSWER:
					return "ShowCorrectKeyOnAnswer";
				case ALLOW_ANSWER_UPDATE:
					return "AllowAnswerUpdate";
				case SHOW_CORRECT_AFTER_SUBMISSION:
					return "ShowCorrectAfterSubmission";
				case ALLOW_DOWNLOAD:
					return "AllowDownload";
				case SHOW_GRADE_AFTER_SUBMISSION:
					return "ShowGradeAfterSubmission";
				case ATTEMPTS_ALLOWED:
					return "AttemptsAllowed";
				case SCORE_TYPE:
					return "ScoreType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

