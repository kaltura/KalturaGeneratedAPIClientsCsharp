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
	public class CodeCuePoint : CuePoint
	{
		#region Constants
		public const string CODE = "code";
		public const string DESCRIPTION = "description";
		public const string END_TIME = "endTime";
		public const string DURATION = "duration";
		#endregion

		#region Private Fields
		private string _Code = null;
		private string _Description = null;
		private int _EndTime = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use CodeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Code
		{
			get { return _Code; }
			set 
			{ 
				_Code = value;
				OnPropertyChanged("Code");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use EndTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		/// <summary>
		/// Use DurationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Duration
		{
			get { return _Duration; }
			private set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		#endregion

		#region CTor
		public CodeCuePoint()
		{
		}

		public CodeCuePoint(JToken node) : base(node)
		{
			if(node["code"] != null)
			{
				this._Code = node["code"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["endTime"] != null)
			{
				this._EndTime = ParseInt(node["endTime"].Value<string>());
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseInt(node["duration"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCodeCuePoint");
			kparams.AddIfNotNull("code", this._Code);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("endTime", this._EndTime);
			kparams.AddIfNotNull("duration", this._Duration);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CODE:
					return "Code";
				case DESCRIPTION:
					return "Description";
				case END_TIME:
					return "EndTime";
				case DURATION:
					return "Duration";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

