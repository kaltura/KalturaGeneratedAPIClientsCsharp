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
	public class RemotePath : ObjectBase
	{
		#region Constants
		public const string STORAGE_PROFILE_ID = "storageProfileId";
		public const string URI = "uri";
		#endregion

		#region Private Fields
		private int _StorageProfileId = Int32.MinValue;
		private string _Uri = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use StorageProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int StorageProfileId
		{
			get { return _StorageProfileId; }
			private set 
			{ 
				_StorageProfileId = value;
				OnPropertyChanged("StorageProfileId");
			}
		}
		/// <summary>
		/// Use UriAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Uri
		{
			get { return _Uri; }
			private set 
			{ 
				_Uri = value;
				OnPropertyChanged("Uri");
			}
		}
		#endregion

		#region CTor
		public RemotePath()
		{
		}

		public RemotePath(JToken node) : base(node)
		{
			if(node["storageProfileId"] != null)
			{
				this._StorageProfileId = ParseInt(node["storageProfileId"].Value<string>());
			}
			if(node["uri"] != null)
			{
				this._Uri = node["uri"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaRemotePath");
			kparams.AddIfNotNull("storageProfileId", this._StorageProfileId);
			kparams.AddIfNotNull("uri", this._Uri);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case STORAGE_PROFILE_ID:
					return "StorageProfileId";
				case URI:
					return "Uri";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

