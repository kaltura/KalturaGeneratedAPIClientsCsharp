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
	public class UrlTokenizerAkamaiHttp : UrlTokenizer
	{
		#region Constants
		public const string PARAM_NAME = "paramName";
		public const string ROOT_DIR = "rootDir";
		#endregion

		#region Private Fields
		private string _ParamName = null;
		private string _RootDir = null;
		#endregion

		#region Properties
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
		[JsonProperty]
		public string RootDir
		{
			get { return _RootDir; }
			set 
			{ 
				_RootDir = value;
				OnPropertyChanged("RootDir");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerAkamaiHttp()
		{
		}

		public UrlTokenizerAkamaiHttp(JToken node) : base(node)
		{
			if(node["paramName"] != null)
			{
				this._ParamName = node["paramName"].Value<string>();
			}
			if(node["rootDir"] != null)
			{
				this._RootDir = node["rootDir"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlTokenizerAkamaiHttp");
			kparams.AddIfNotNull("paramName", this._ParamName);
			kparams.AddIfNotNull("rootDir", this._RootDir);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARAM_NAME:
					return "ParamName";
				case ROOT_DIR:
					return "RootDir";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

