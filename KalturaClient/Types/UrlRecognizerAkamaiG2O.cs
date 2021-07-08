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
	public class UrlRecognizerAkamaiG2O : UrlRecognizer
	{
		#region Constants
		public const string HEADER_DATA = "headerData";
		public const string HEADER_SIGN = "headerSign";
		public const string TIMEOUT = "timeout";
		public const string SALT = "salt";
		#endregion

		#region Private Fields
		private string _HeaderData = null;
		private string _HeaderSign = null;
		private int _Timeout = Int32.MinValue;
		private string _Salt = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use HeaderDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string HeaderData
		{
			get { return _HeaderData; }
			set 
			{ 
				_HeaderData = value;
				OnPropertyChanged("HeaderData");
			}
		}
		/// <summary>
		/// Use HeaderSignAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string HeaderSign
		{
			get { return _HeaderSign; }
			set 
			{ 
				_HeaderSign = value;
				OnPropertyChanged("HeaderSign");
			}
		}
		/// <summary>
		/// Use TimeoutAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Timeout
		{
			get { return _Timeout; }
			set 
			{ 
				_Timeout = value;
				OnPropertyChanged("Timeout");
			}
		}
		/// <summary>
		/// Use SaltAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Salt
		{
			get { return _Salt; }
			set 
			{ 
				_Salt = value;
				OnPropertyChanged("Salt");
			}
		}
		#endregion

		#region CTor
		public UrlRecognizerAkamaiG2O()
		{
		}

		public UrlRecognizerAkamaiG2O(JToken node) : base(node)
		{
			if(node["headerData"] != null)
			{
				this._HeaderData = node["headerData"].Value<string>();
			}
			if(node["headerSign"] != null)
			{
				this._HeaderSign = node["headerSign"].Value<string>();
			}
			if(node["timeout"] != null)
			{
				this._Timeout = ParseInt(node["timeout"].Value<string>());
			}
			if(node["salt"] != null)
			{
				this._Salt = node["salt"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlRecognizerAkamaiG2O");
			kparams.AddIfNotNull("headerData", this._HeaderData);
			kparams.AddIfNotNull("headerSign", this._HeaderSign);
			kparams.AddIfNotNull("timeout", this._Timeout);
			kparams.AddIfNotNull("salt", this._Salt);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HEADER_DATA:
					return "HeaderData";
				case HEADER_SIGN:
					return "HeaderSign";
				case TIMEOUT:
					return "Timeout";
				case SALT:
					return "Salt";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

