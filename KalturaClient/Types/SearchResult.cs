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
	public class SearchResult : Search
	{
		#region Constants
		public const string ID = "id";
		public const string TITLE = "title";
		public const string THUMB_URL = "thumbUrl";
		public const string DESCRIPTION = "description";
		public const string TAGS = "tags";
		public const string URL = "url";
		public const string SOURCE_LINK = "sourceLink";
		public const string CREDIT = "credit";
		public const string LICENSE_TYPE = "licenseType";
		public const string FLASH_PLAYBACK_TYPE = "flashPlaybackType";
		public const string FILE_EXT = "fileExt";
		#endregion

		#region Private Fields
		private string _Id = null;
		private string _Title = null;
		private string _ThumbUrl = null;
		private string _Description = null;
		private string _Tags = null;
		private string _Url = null;
		private string _SourceLink = null;
		private string _Credit = null;
		private LicenseType _LicenseType = (LicenseType)Int32.MinValue;
		private string _FlashPlaybackType = null;
		private string _FileExt = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		[JsonProperty]
		public string ThumbUrl
		{
			get { return _ThumbUrl; }
			set 
			{ 
				_ThumbUrl = value;
				OnPropertyChanged("ThumbUrl");
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
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
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
		public string SourceLink
		{
			get { return _SourceLink; }
			set 
			{ 
				_SourceLink = value;
				OnPropertyChanged("SourceLink");
			}
		}
		[JsonProperty]
		public string Credit
		{
			get { return _Credit; }
			set 
			{ 
				_Credit = value;
				OnPropertyChanged("Credit");
			}
		}
		[JsonProperty]
		public LicenseType LicenseType
		{
			get { return _LicenseType; }
			set 
			{ 
				_LicenseType = value;
				OnPropertyChanged("LicenseType");
			}
		}
		[JsonProperty]
		public string FlashPlaybackType
		{
			get { return _FlashPlaybackType; }
			set 
			{ 
				_FlashPlaybackType = value;
				OnPropertyChanged("FlashPlaybackType");
			}
		}
		[JsonProperty]
		public string FileExt
		{
			get { return _FileExt; }
			set 
			{ 
				_FileExt = value;
				OnPropertyChanged("FileExt");
			}
		}
		#endregion

		#region CTor
		public SearchResult()
		{
		}

		public SearchResult(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["title"] != null)
			{
				this._Title = node["title"].Value<string>();
			}
			if(node["thumbUrl"] != null)
			{
				this._ThumbUrl = node["thumbUrl"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["url"] != null)
			{
				this._Url = node["url"].Value<string>();
			}
			if(node["sourceLink"] != null)
			{
				this._SourceLink = node["sourceLink"].Value<string>();
			}
			if(node["credit"] != null)
			{
				this._Credit = node["credit"].Value<string>();
			}
			if(node["licenseType"] != null)
			{
				this._LicenseType = (LicenseType)ParseEnum(typeof(LicenseType), node["licenseType"].Value<string>());
			}
			if(node["flashPlaybackType"] != null)
			{
				this._FlashPlaybackType = node["flashPlaybackType"].Value<string>();
			}
			if(node["fileExt"] != null)
			{
				this._FileExt = node["fileExt"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSearchResult");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("title", this._Title);
			kparams.AddIfNotNull("thumbUrl", this._ThumbUrl);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("url", this._Url);
			kparams.AddIfNotNull("sourceLink", this._SourceLink);
			kparams.AddIfNotNull("credit", this._Credit);
			kparams.AddIfNotNull("licenseType", this._LicenseType);
			kparams.AddIfNotNull("flashPlaybackType", this._FlashPlaybackType);
			kparams.AddIfNotNull("fileExt", this._FileExt);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case TITLE:
					return "Title";
				case THUMB_URL:
					return "ThumbUrl";
				case DESCRIPTION:
					return "Description";
				case TAGS:
					return "Tags";
				case URL:
					return "Url";
				case SOURCE_LINK:
					return "SourceLink";
				case CREDIT:
					return "Credit";
				case LICENSE_TYPE:
					return "LicenseType";
				case FLASH_PLAYBACK_TYPE:
					return "FlashPlaybackType";
				case FILE_EXT:
					return "FileExt";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

