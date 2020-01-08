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
	public class ConvertProfileJobData : JobData
	{
		#region Constants
		public const string INPUT_FILE_SYNC_LOCAL_PATH = "inputFileSyncLocalPath";
		public const string THUMB_HEIGHT = "thumbHeight";
		public const string THUMB_BITRATE = "thumbBitrate";
		#endregion

		#region Private Fields
		private string _InputFileSyncLocalPath = null;
		private int _ThumbHeight = Int32.MinValue;
		private int _ThumbBitrate = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string InputFileSyncLocalPath
		{
			get { return _InputFileSyncLocalPath; }
			set 
			{ 
				_InputFileSyncLocalPath = value;
				OnPropertyChanged("InputFileSyncLocalPath");
			}
		}
		[JsonProperty]
		public int ThumbHeight
		{
			get { return _ThumbHeight; }
			set 
			{ 
				_ThumbHeight = value;
				OnPropertyChanged("ThumbHeight");
			}
		}
		[JsonProperty]
		public int ThumbBitrate
		{
			get { return _ThumbBitrate; }
			set 
			{ 
				_ThumbBitrate = value;
				OnPropertyChanged("ThumbBitrate");
			}
		}
		#endregion

		#region CTor
		public ConvertProfileJobData()
		{
		}

		public ConvertProfileJobData(JToken node) : base(node)
		{
			if(node["inputFileSyncLocalPath"] != null)
			{
				this._InputFileSyncLocalPath = node["inputFileSyncLocalPath"].Value<string>();
			}
			if(node["thumbHeight"] != null)
			{
				this._ThumbHeight = ParseInt(node["thumbHeight"].Value<string>());
			}
			if(node["thumbBitrate"] != null)
			{
				this._ThumbBitrate = ParseInt(node["thumbBitrate"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConvertProfileJobData");
			kparams.AddIfNotNull("inputFileSyncLocalPath", this._InputFileSyncLocalPath);
			kparams.AddIfNotNull("thumbHeight", this._ThumbHeight);
			kparams.AddIfNotNull("thumbBitrate", this._ThumbBitrate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case INPUT_FILE_SYNC_LOCAL_PATH:
					return "InputFileSyncLocalPath";
				case THUMB_HEIGHT:
					return "ThumbHeight";
				case THUMB_BITRATE:
					return "ThumbBitrate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

