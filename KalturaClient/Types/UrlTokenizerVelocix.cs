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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class UrlTokenizerVelocix : UrlTokenizer
	{
		#region Constants
		public const string HDS_PATHS = "hdsPaths";
		public const string PARAM_NAME = "paramName";
		public const string AUTH_PREFIX = "authPrefix";
		#endregion

		#region Private Fields
		private string _HdsPaths = null;
		private string _ParamName = null;
		private string _AuthPrefix = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use HdsPathsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string HdsPaths
		{
			get { return _HdsPaths; }
			set 
			{ 
				_HdsPaths = value;
				OnPropertyChanged("HdsPaths");
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
		/// <summary>
		/// Use AuthPrefixAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AuthPrefix
		{
			get { return _AuthPrefix; }
			set 
			{ 
				_AuthPrefix = value;
				OnPropertyChanged("AuthPrefix");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerVelocix()
		{
		}

		public UrlTokenizerVelocix(JToken node) : base(node)
		{
			if(node["hdsPaths"] != null)
			{
				this._HdsPaths = node["hdsPaths"].Value<string>();
			}
			if(node["paramName"] != null)
			{
				this._ParamName = node["paramName"].Value<string>();
			}
			if(node["authPrefix"] != null)
			{
				this._AuthPrefix = node["authPrefix"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlTokenizerVelocix");
			kparams.AddIfNotNull("hdsPaths", this._HdsPaths);
			kparams.AddIfNotNull("paramName", this._ParamName);
			kparams.AddIfNotNull("authPrefix", this._AuthPrefix);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HDS_PATHS:
					return "HdsPaths";
				case PARAM_NAME:
					return "ParamName";
				case AUTH_PREFIX:
					return "AuthPrefix";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

