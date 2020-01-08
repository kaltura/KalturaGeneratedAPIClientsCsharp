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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class WebexDropFolderFile : DropFolderFile
	{
		#region Constants
		public const string RECORDING_ID = "recordingId";
		public const string WEBEX_HOST_ID = "webexHostId";
		public const string DESCRIPTION = "description";
		public const string CONF_ID = "confId";
		public const string CONTENT_URL = "contentUrl";
		#endregion

		#region Private Fields
		private int _RecordingId = Int32.MinValue;
		private string _WebexHostId = null;
		private string _Description = null;
		private string _ConfId = null;
		private string _ContentUrl = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int RecordingId
		{
			get { return _RecordingId; }
			set 
			{ 
				_RecordingId = value;
				OnPropertyChanged("RecordingId");
			}
		}
		[JsonProperty]
		public string WebexHostId
		{
			get { return _WebexHostId; }
			set 
			{ 
				_WebexHostId = value;
				OnPropertyChanged("WebexHostId");
			}
		}
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
		[JsonProperty]
		public string ConfId
		{
			get { return _ConfId; }
			set 
			{ 
				_ConfId = value;
				OnPropertyChanged("ConfId");
			}
		}
		[JsonProperty]
		public string ContentUrl
		{
			get { return _ContentUrl; }
			set 
			{ 
				_ContentUrl = value;
				OnPropertyChanged("ContentUrl");
			}
		}
		#endregion

		#region CTor
		public WebexDropFolderFile()
		{
		}

		public WebexDropFolderFile(JToken node) : base(node)
		{
			if(node["recordingId"] != null)
			{
				this._RecordingId = ParseInt(node["recordingId"].Value<string>());
			}
			if(node["webexHostId"] != null)
			{
				this._WebexHostId = node["webexHostId"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["confId"] != null)
			{
				this._ConfId = node["confId"].Value<string>();
			}
			if(node["contentUrl"] != null)
			{
				this._ContentUrl = node["contentUrl"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaWebexDropFolderFile");
			kparams.AddIfNotNull("recordingId", this._RecordingId);
			kparams.AddIfNotNull("webexHostId", this._WebexHostId);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("confId", this._ConfId);
			kparams.AddIfNotNull("contentUrl", this._ContentUrl);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RECORDING_ID:
					return "RecordingId";
				case WEBEX_HOST_ID:
					return "WebexHostId";
				case DESCRIPTION:
					return "Description";
				case CONF_ID:
					return "ConfId";
				case CONTENT_URL:
					return "ContentUrl";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

