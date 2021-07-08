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
	public class AlignmentVendorTaskData : VendorTaskDataCaptionAsset
	{
		#region Constants
		public const string TEXT_TRANSCRIPT_ASSET_ID = "textTranscriptAssetId";
		public const string JSON_TRANSCRIPT_ASSET_ID = "jsonTranscriptAssetId";
		#endregion

		#region Private Fields
		private string _TextTranscriptAssetId = null;
		private string _JsonTranscriptAssetId = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use TextTranscriptAssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TextTranscriptAssetId
		{
			get { return _TextTranscriptAssetId; }
			set 
			{ 
				_TextTranscriptAssetId = value;
				OnPropertyChanged("TextTranscriptAssetId");
			}
		}
		/// <summary>
		/// Use JsonTranscriptAssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string JsonTranscriptAssetId
		{
			get { return _JsonTranscriptAssetId; }
			set 
			{ 
				_JsonTranscriptAssetId = value;
				OnPropertyChanged("JsonTranscriptAssetId");
			}
		}
		#endregion

		#region CTor
		public AlignmentVendorTaskData()
		{
		}

		public AlignmentVendorTaskData(JToken node) : base(node)
		{
			if(node["textTranscriptAssetId"] != null)
			{
				this._TextTranscriptAssetId = node["textTranscriptAssetId"].Value<string>();
			}
			if(node["jsonTranscriptAssetId"] != null)
			{
				this._JsonTranscriptAssetId = node["jsonTranscriptAssetId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAlignmentVendorTaskData");
			kparams.AddIfNotNull("textTranscriptAssetId", this._TextTranscriptAssetId);
			kparams.AddIfNotNull("jsonTranscriptAssetId", this._JsonTranscriptAssetId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TEXT_TRANSCRIPT_ASSET_ID:
					return "TextTranscriptAssetId";
				case JSON_TRANSCRIPT_ASSET_ID:
					return "JsonTranscriptAssetId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

