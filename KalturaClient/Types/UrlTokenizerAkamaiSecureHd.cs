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
	public class UrlTokenizerAkamaiSecureHd : UrlTokenizer
	{
		#region Constants
		public const string PARAM_NAME = "paramName";
		public const string ACL_POSTFIX = "aclPostfix";
		public const string CUSTOM_POSTFIXES = "customPostfixes";
		public const string USE_COOKIE_HOSTS = "useCookieHosts";
		public const string ROOT_DIR = "rootDir";
		#endregion

		#region Private Fields
		private string _ParamName = null;
		private string _AclPostfix = null;
		private string _CustomPostfixes = null;
		private string _UseCookieHosts = null;
		private string _RootDir = null;
		#endregion

		#region Properties
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
		/// Use AclPostfixAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AclPostfix
		{
			get { return _AclPostfix; }
			set 
			{ 
				_AclPostfix = value;
				OnPropertyChanged("AclPostfix");
			}
		}
		/// <summary>
		/// Use CustomPostfixesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CustomPostfixes
		{
			get { return _CustomPostfixes; }
			set 
			{ 
				_CustomPostfixes = value;
				OnPropertyChanged("CustomPostfixes");
			}
		}
		/// <summary>
		/// Use UseCookieHostsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UseCookieHosts
		{
			get { return _UseCookieHosts; }
			set 
			{ 
				_UseCookieHosts = value;
				OnPropertyChanged("UseCookieHosts");
			}
		}
		/// <summary>
		/// Use RootDirAsDouble property instead
		/// </summary>
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
		public UrlTokenizerAkamaiSecureHd()
		{
		}

		public UrlTokenizerAkamaiSecureHd(JToken node) : base(node)
		{
			if(node["paramName"] != null)
			{
				this._ParamName = node["paramName"].Value<string>();
			}
			if(node["aclPostfix"] != null)
			{
				this._AclPostfix = node["aclPostfix"].Value<string>();
			}
			if(node["customPostfixes"] != null)
			{
				this._CustomPostfixes = node["customPostfixes"].Value<string>();
			}
			if(node["useCookieHosts"] != null)
			{
				this._UseCookieHosts = node["useCookieHosts"].Value<string>();
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
				kparams.AddReplace("objectType", "KalturaUrlTokenizerAkamaiSecureHd");
			kparams.AddIfNotNull("paramName", this._ParamName);
			kparams.AddIfNotNull("aclPostfix", this._AclPostfix);
			kparams.AddIfNotNull("customPostfixes", this._CustomPostfixes);
			kparams.AddIfNotNull("useCookieHosts", this._UseCookieHosts);
			kparams.AddIfNotNull("rootDir", this._RootDir);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARAM_NAME:
					return "ParamName";
				case ACL_POSTFIX:
					return "AclPostfix";
				case CUSTOM_POSTFIXES:
					return "CustomPostfixes";
				case USE_COOKIE_HOSTS:
					return "UseCookieHosts";
				case ROOT_DIR:
					return "RootDir";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

