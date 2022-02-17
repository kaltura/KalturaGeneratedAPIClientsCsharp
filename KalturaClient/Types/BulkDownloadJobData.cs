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
	public class BulkDownloadJobData : JobData
	{
		#region Constants
		public const string ENTRY_IDS = "entryIds";
		public const string FLAVOR_PARAMS_ID = "flavorParamsId";
		public const string PUSER_ID = "puserId";
		#endregion

		#region Private Fields
		private string _EntryIds = null;
		private int _FlavorParamsId = Int32.MinValue;
		private string _PuserId = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use EntryIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIds
		{
			get { return _EntryIds; }
			set 
			{ 
				_EntryIds = value;
				OnPropertyChanged("EntryIds");
			}
		}
		/// <summary>
		/// Use FlavorParamsIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		/// <summary>
		/// Use PuserIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PuserId
		{
			get { return _PuserId; }
			set 
			{ 
				_PuserId = value;
				OnPropertyChanged("PuserId");
			}
		}
		#endregion

		#region CTor
		public BulkDownloadJobData()
		{
		}

		public BulkDownloadJobData(JToken node) : base(node)
		{
			if(node["entryIds"] != null)
			{
				this._EntryIds = node["entryIds"].Value<string>();
			}
			if(node["flavorParamsId"] != null)
			{
				this._FlavorParamsId = ParseInt(node["flavorParamsId"].Value<string>());
			}
			if(node["puserId"] != null)
			{
				this._PuserId = node["puserId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkDownloadJobData");
			kparams.AddIfNotNull("entryIds", this._EntryIds);
			kparams.AddIfNotNull("flavorParamsId", this._FlavorParamsId);
			kparams.AddIfNotNull("puserId", this._PuserId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_IDS:
					return "EntryIds";
				case FLAVOR_PARAMS_ID:
					return "FlavorParamsId";
				case PUSER_ID:
					return "PuserId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

