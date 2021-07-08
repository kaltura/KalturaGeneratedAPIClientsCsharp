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
	public class UrlTokenizerL3 : UrlTokenizer
	{
		#region Constants
		public const string GEN = "gen";
		public const string PARAM_NAME = "paramName";
		#endregion

		#region Private Fields
		private string _Gen = null;
		private string _ParamName = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use GenAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Gen
		{
			get { return _Gen; }
			set 
			{ 
				_Gen = value;
				OnPropertyChanged("Gen");
			}
		}
		/// <summary>
		/// Use ParamNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParamName
		{
			get { return _ParamName; }
			set 
			{ 
				_ParamName = value;
				OnPropertyChanged("ParamName");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerL3()
		{
		}

		public UrlTokenizerL3(JToken node) : base(node)
		{
			if(node["gen"] != null)
			{
				this._Gen = node["gen"].Value<string>();
			}
			if(node["paramName"] != null)
			{
				this._ParamName = node["paramName"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlTokenizerL3");
			kparams.AddIfNotNull("gen", this._Gen);
			kparams.AddIfNotNull("paramName", this._ParamName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case GEN:
					return "Gen";
				case PARAM_NAME:
					return "ParamName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

