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
	public class LiveEntryArchiveJobData : JobData
	{
		#region Constants
		public const string LIVE_ENTRY_ID = "liveEntryId";
		public const string VOD_ENTRY_ID = "vodEntryId";
		#endregion

		#region Private Fields
		private string _LiveEntryId = null;
		private string _VodEntryId = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use LiveEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LiveEntryId
		{
			get { return _LiveEntryId; }
			set 
			{ 
				_LiveEntryId = value;
				OnPropertyChanged("LiveEntryId");
			}
		}
		/// <summary>
		/// Use VodEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VodEntryId
		{
			get { return _VodEntryId; }
			set 
			{ 
				_VodEntryId = value;
				OnPropertyChanged("VodEntryId");
			}
		}
		#endregion

		#region CTor
		public LiveEntryArchiveJobData()
		{
		}

		public LiveEntryArchiveJobData(JToken node) : base(node)
		{
			if(node["liveEntryId"] != null)
			{
				this._LiveEntryId = node["liveEntryId"].Value<string>();
			}
			if(node["vodEntryId"] != null)
			{
				this._VodEntryId = node["vodEntryId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveEntryArchiveJobData");
			kparams.AddIfNotNull("liveEntryId", this._LiveEntryId);
			kparams.AddIfNotNull("vodEntryId", this._VodEntryId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LIVE_ENTRY_ID:
					return "LiveEntryId";
				case VOD_ENTRY_ID:
					return "VodEntryId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

