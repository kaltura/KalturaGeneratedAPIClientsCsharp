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
	public class LiveAsset : FlavorAsset
	{
		#region Constants
		public const string MULTICAST_IP = "multicastIP";
		public const string MULTICAST_PORT = "multicastPort";
		#endregion

		#region Private Fields
		private string _MulticastIP = null;
		private int _MulticastPort = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use MulticastIPAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MulticastIP
		{
			get { return _MulticastIP; }
			set 
			{ 
				_MulticastIP = value;
				OnPropertyChanged("MulticastIP");
			}
		}
		/// <summary>
		/// Use MulticastPortAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MulticastPort
		{
			get { return _MulticastPort; }
			set 
			{ 
				_MulticastPort = value;
				OnPropertyChanged("MulticastPort");
			}
		}
		#endregion

		#region CTor
		public LiveAsset()
		{
		}

		public LiveAsset(JToken node) : base(node)
		{
			if(node["multicastIP"] != null)
			{
				this._MulticastIP = node["multicastIP"].Value<string>();
			}
			if(node["multicastPort"] != null)
			{
				this._MulticastPort = ParseInt(node["multicastPort"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveAsset");
			kparams.AddIfNotNull("multicastIP", this._MulticastIP);
			kparams.AddIfNotNull("multicastPort", this._MulticastPort);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MULTICAST_IP:
					return "MulticastIP";
				case MULTICAST_PORT:
					return "MulticastPort";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

