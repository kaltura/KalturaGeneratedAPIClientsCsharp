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
	public class LiveRestreamFeature : LiveFeature
	{
		#region Constants
		public const string PRIMARY_URL = "primaryUrl";
		public const string SECONDARY_URL = "secondaryUrl";
		public const string STREAM_KEY = "streamKey";
		#endregion

		#region Private Fields
		private string _PrimaryUrl = null;
		private string _SecondaryUrl = null;
		private string _StreamKey = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use PrimaryUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PrimaryUrl
		{
			get { return _PrimaryUrl; }
			set 
			{ 
				_PrimaryUrl = value;
				OnPropertyChanged("PrimaryUrl");
			}
		}
		/// <summary>
		/// Use SecondaryUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SecondaryUrl
		{
			get { return _SecondaryUrl; }
			set 
			{ 
				_SecondaryUrl = value;
				OnPropertyChanged("SecondaryUrl");
			}
		}
		/// <summary>
		/// Use StreamKeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StreamKey
		{
			get { return _StreamKey; }
			set 
			{ 
				_StreamKey = value;
				OnPropertyChanged("StreamKey");
			}
		}
		#endregion

		#region CTor
		public LiveRestreamFeature()
		{
		}

		public LiveRestreamFeature(JToken node) : base(node)
		{
			if(node["primaryUrl"] != null)
			{
				this._PrimaryUrl = node["primaryUrl"].Value<string>();
			}
			if(node["secondaryUrl"] != null)
			{
				this._SecondaryUrl = node["secondaryUrl"].Value<string>();
			}
			if(node["streamKey"] != null)
			{
				this._StreamKey = node["streamKey"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveRestreamFeature");
			kparams.AddIfNotNull("primaryUrl", this._PrimaryUrl);
			kparams.AddIfNotNull("secondaryUrl", this._SecondaryUrl);
			kparams.AddIfNotNull("streamKey", this._StreamKey);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PRIMARY_URL:
					return "PrimaryUrl";
				case SECONDARY_URL:
					return "SecondaryUrl";
				case STREAM_KEY:
					return "StreamKey";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

