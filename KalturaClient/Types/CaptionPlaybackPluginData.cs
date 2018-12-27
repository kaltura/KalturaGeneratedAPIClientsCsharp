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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class CaptionPlaybackPluginData : ObjectBase
	{
		#region Constants
		public const string LABEL = "label";
		public const string FORMAT = "format";
		public const string LANGUAGE = "language";
		public const string WEB_VTT_URL = "webVttUrl";
		public const string URL = "url";
		public const string IS_DEFAULT = "isDefault";
		#endregion

		#region Private Fields
		private string _Label = null;
		private string _Format = null;
		private string _Language = null;
		private string _WebVttUrl = null;
		private string _Url = null;
		private bool? _IsDefault = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		[JsonProperty]
		public string Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		[JsonProperty]
		public string Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		[JsonProperty]
		public string WebVttUrl
		{
			get { return _WebVttUrl; }
			set 
			{ 
				_WebVttUrl = value;
				OnPropertyChanged("WebVttUrl");
			}
		}
		[JsonProperty]
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		[JsonProperty]
		public bool? IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		#endregion

		#region CTor
		public CaptionPlaybackPluginData()
		{
		}

		public CaptionPlaybackPluginData(JToken node) : base(node)
		{
			if(node["label"] != null)
			{
				this._Label = node["label"].Value<string>();
			}
			if(node["format"] != null)
			{
				this._Format = node["format"].Value<string>();
			}
			if(node["language"] != null)
			{
				this._Language = node["language"].Value<string>();
			}
			if(node["webVttUrl"] != null)
			{
				this._WebVttUrl = node["webVttUrl"].Value<string>();
			}
			if(node["url"] != null)
			{
				this._Url = node["url"].Value<string>();
			}
			if(node["isDefault"] != null)
			{
				this._IsDefault = ParseBool(node["isDefault"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCaptionPlaybackPluginData");
			kparams.AddIfNotNull("label", this._Label);
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("webVttUrl", this._WebVttUrl);
			kparams.AddIfNotNull("url", this._Url);
			kparams.AddIfNotNull("isDefault", this._IsDefault);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LABEL:
					return "Label";
				case FORMAT:
					return "Format";
				case LANGUAGE:
					return "Language";
				case WEB_VTT_URL:
					return "WebVttUrl";
				case URL:
					return "Url";
				case IS_DEFAULT:
					return "IsDefault";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

