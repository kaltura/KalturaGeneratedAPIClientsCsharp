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
	public class LiveCaptionFeature : LiveFeature
	{
		#region Constants
		public const string MEDIA_URL = "mediaUrl";
		public const string MEDIA_KEY = "mediaKey";
		public const string CAPTION_URL = "captionUrl";
		public const string CAPTION_TOKEN = "captionToken";
		#endregion

		#region Private Fields
		private string _MediaUrl = null;
		private string _MediaKey = null;
		private string _CaptionUrl = null;
		private string _CaptionToken = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use MediaUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MediaUrl
		{
			get { return _MediaUrl; }
			set 
			{ 
				_MediaUrl = value;
				OnPropertyChanged("MediaUrl");
			}
		}
		/// <summary>
		/// Use MediaKeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MediaKey
		{
			get { return _MediaKey; }
			set 
			{ 
				_MediaKey = value;
				OnPropertyChanged("MediaKey");
			}
		}
		/// <summary>
		/// Use CaptionUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CaptionUrl
		{
			get { return _CaptionUrl; }
			set 
			{ 
				_CaptionUrl = value;
				OnPropertyChanged("CaptionUrl");
			}
		}
		/// <summary>
		/// Use CaptionTokenAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CaptionToken
		{
			get { return _CaptionToken; }
			set 
			{ 
				_CaptionToken = value;
				OnPropertyChanged("CaptionToken");
			}
		}
		#endregion

		#region CTor
		public LiveCaptionFeature()
		{
		}

		public LiveCaptionFeature(JToken node) : base(node)
		{
			if(node["mediaUrl"] != null)
			{
				this._MediaUrl = node["mediaUrl"].Value<string>();
			}
			if(node["mediaKey"] != null)
			{
				this._MediaKey = node["mediaKey"].Value<string>();
			}
			if(node["captionUrl"] != null)
			{
				this._CaptionUrl = node["captionUrl"].Value<string>();
			}
			if(node["captionToken"] != null)
			{
				this._CaptionToken = node["captionToken"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveCaptionFeature");
			kparams.AddIfNotNull("mediaUrl", this._MediaUrl);
			kparams.AddIfNotNull("mediaKey", this._MediaKey);
			kparams.AddIfNotNull("captionUrl", this._CaptionUrl);
			kparams.AddIfNotNull("captionToken", this._CaptionToken);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MEDIA_URL:
					return "MediaUrl";
				case MEDIA_KEY:
					return "MediaKey";
				case CAPTION_URL:
					return "CaptionUrl";
				case CAPTION_TOKEN:
					return "CaptionToken";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

