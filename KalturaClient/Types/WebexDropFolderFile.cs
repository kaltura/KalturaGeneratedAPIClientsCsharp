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
		public int RecordingId
		{
			get { return _RecordingId; }
			set 
			{ 
				_RecordingId = value;
				OnPropertyChanged("RecordingId");
			}
		}
		public string WebexHostId
		{
			get { return _WebexHostId; }
			set 
			{ 
				_WebexHostId = value;
				OnPropertyChanged("WebexHostId");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string ConfId
		{
			get { return _ConfId; }
			set 
			{ 
				_ConfId = value;
				OnPropertyChanged("ConfId");
			}
		}
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

		public WebexDropFolderFile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "recordingId":
						this._RecordingId = ParseInt(propertyNode.InnerText);
						continue;
					case "webexHostId":
						this._WebexHostId = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "confId":
						this._ConfId = propertyNode.InnerText;
						continue;
					case "contentUrl":
						this._ContentUrl = propertyNode.InnerText;
						continue;
				}
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

