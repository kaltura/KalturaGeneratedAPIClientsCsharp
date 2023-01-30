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
	public class DropFolderContentProcessorJobData : JobData
	{
		#region Constants
		public const string DROP_FOLDER_ID = "dropFolderId";
		public const string DROP_FOLDER_FILE_IDS = "dropFolderFileIds";
		public const string PARSED_SLUG = "parsedSlug";
		public const string CONTENT_MATCH_POLICY = "contentMatchPolicy";
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string PARSED_USER_ID = "parsedUserId";
		#endregion

		#region Private Fields
		private int _DropFolderId = Int32.MinValue;
		private string _DropFolderFileIds = null;
		private string _ParsedSlug = null;
		private DropFolderContentFileHandlerMatchPolicy _ContentMatchPolicy = (DropFolderContentFileHandlerMatchPolicy)Int32.MinValue;
		private int _ConversionProfileId = Int32.MinValue;
		private string _ParsedUserId = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use DropFolderIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DropFolderId
		{
			get { return _DropFolderId; }
			set 
			{ 
				_DropFolderId = value;
				OnPropertyChanged("DropFolderId");
			}
		}
		/// <summary>
		/// Use DropFolderFileIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DropFolderFileIds
		{
			get { return _DropFolderFileIds; }
			set 
			{ 
				_DropFolderFileIds = value;
				OnPropertyChanged("DropFolderFileIds");
			}
		}
		/// <summary>
		/// Use ParsedSlugAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParsedSlug
		{
			get { return _ParsedSlug; }
			set 
			{ 
				_ParsedSlug = value;
				OnPropertyChanged("ParsedSlug");
			}
		}
		/// <summary>
		/// Use ContentMatchPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DropFolderContentFileHandlerMatchPolicy ContentMatchPolicy
		{
			get { return _ContentMatchPolicy; }
			set 
			{ 
				_ContentMatchPolicy = value;
				OnPropertyChanged("ContentMatchPolicy");
			}
		}
		/// <summary>
		/// Use ConversionProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		/// <summary>
		/// Use ParsedUserIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParsedUserId
		{
			get { return _ParsedUserId; }
			set 
			{ 
				_ParsedUserId = value;
				OnPropertyChanged("ParsedUserId");
			}
		}
		#endregion

		#region CTor
		public DropFolderContentProcessorJobData()
		{
		}

		public DropFolderContentProcessorJobData(JToken node) : base(node)
		{
			if(node["dropFolderId"] != null)
			{
				this._DropFolderId = ParseInt(node["dropFolderId"].Value<string>());
			}
			if(node["dropFolderFileIds"] != null)
			{
				this._DropFolderFileIds = node["dropFolderFileIds"].Value<string>();
			}
			if(node["parsedSlug"] != null)
			{
				this._ParsedSlug = node["parsedSlug"].Value<string>();
			}
			if(node["contentMatchPolicy"] != null)
			{
				this._ContentMatchPolicy = (DropFolderContentFileHandlerMatchPolicy)ParseEnum(typeof(DropFolderContentFileHandlerMatchPolicy), node["contentMatchPolicy"].Value<string>());
			}
			if(node["conversionProfileId"] != null)
			{
				this._ConversionProfileId = ParseInt(node["conversionProfileId"].Value<string>());
			}
			if(node["parsedUserId"] != null)
			{
				this._ParsedUserId = node["parsedUserId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDropFolderContentProcessorJobData");
			kparams.AddIfNotNull("dropFolderId", this._DropFolderId);
			kparams.AddIfNotNull("dropFolderFileIds", this._DropFolderFileIds);
			kparams.AddIfNotNull("parsedSlug", this._ParsedSlug);
			kparams.AddIfNotNull("contentMatchPolicy", this._ContentMatchPolicy);
			kparams.AddIfNotNull("conversionProfileId", this._ConversionProfileId);
			kparams.AddIfNotNull("parsedUserId", this._ParsedUserId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DROP_FOLDER_ID:
					return "DropFolderId";
				case DROP_FOLDER_FILE_IDS:
					return "DropFolderFileIds";
				case PARSED_SLUG:
					return "ParsedSlug";
				case CONTENT_MATCH_POLICY:
					return "ContentMatchPolicy";
				case CONVERSION_PROFILE_ID:
					return "ConversionProfileId";
				case PARSED_USER_ID:
					return "ParsedUserId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

