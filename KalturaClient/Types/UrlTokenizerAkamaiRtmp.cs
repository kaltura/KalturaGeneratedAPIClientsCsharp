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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class UrlTokenizerAkamaiRtmp : UrlTokenizer
	{
		#region Constants
		public const string PROFILE = "profile";
		public const string TYPE = "type";
		public const string AIFP = "aifp";
		public const string USE_PREFIX = "usePrefix";
		#endregion

		#region Private Fields
		private string _Profile = null;
		private string _Type = null;
		private string _Aifp = null;
		private bool? _UsePrefix = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ProfileAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Profile
		{
			get { return _Profile; }
			set 
			{ 
				_Profile = value;
				OnPropertyChanged("Profile");
			}
		}
		/// <summary>
		/// Use TypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		/// <summary>
		/// Use AifpAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Aifp
		{
			get { return _Aifp; }
			set 
			{ 
				_Aifp = value;
				OnPropertyChanged("Aifp");
			}
		}
		/// <summary>
		/// Use UsePrefixAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? UsePrefix
		{
			get { return _UsePrefix; }
			set 
			{ 
				_UsePrefix = value;
				OnPropertyChanged("UsePrefix");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerAkamaiRtmp()
		{
		}

		public UrlTokenizerAkamaiRtmp(JToken node) : base(node)
		{
			if(node["profile"] != null)
			{
				this._Profile = node["profile"].Value<string>();
			}
			if(node["type"] != null)
			{
				this._Type = node["type"].Value<string>();
			}
			if(node["aifp"] != null)
			{
				this._Aifp = node["aifp"].Value<string>();
			}
			if(node["usePrefix"] != null)
			{
				this._UsePrefix = ParseBool(node["usePrefix"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlTokenizerAkamaiRtmp");
			kparams.AddIfNotNull("profile", this._Profile);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("aifp", this._Aifp);
			kparams.AddIfNotNull("usePrefix", this._UsePrefix);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROFILE:
					return "Profile";
				case TYPE:
					return "Type";
				case AIFP:
					return "Aifp";
				case USE_PREFIX:
					return "UsePrefix";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

