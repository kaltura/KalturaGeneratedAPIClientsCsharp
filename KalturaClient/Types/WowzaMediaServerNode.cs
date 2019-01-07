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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class WowzaMediaServerNode : MediaServerNode
	{
		#region Constants
		public const string APP_PREFIX = "appPrefix";
		public const string TRANSCODER = "transcoder";
		public const string GPU_ID = "GPUID";
		public const string LIVE_SERVICE_PORT = "liveServicePort";
		public const string LIVE_SERVICE_PROTOCOL = "liveServiceProtocol";
		public const string LIVE_SERVICE_INTERNAL_DOMAIN = "liveServiceInternalDomain";
		#endregion

		#region Private Fields
		private string _AppPrefix = null;
		private string _Transcoder = null;
		private int _GPUID = Int32.MinValue;
		private int _LiveServicePort = Int32.MinValue;
		private string _LiveServiceProtocol = null;
		private string _LiveServiceInternalDomain = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string AppPrefix
		{
			get { return _AppPrefix; }
			set 
			{ 
				_AppPrefix = value;
				OnPropertyChanged("AppPrefix");
			}
		}
		[JsonProperty]
		public string Transcoder
		{
			get { return _Transcoder; }
			set 
			{ 
				_Transcoder = value;
				OnPropertyChanged("Transcoder");
			}
		}
		[JsonProperty]
		public int GPUID
		{
			get { return _GPUID; }
			set 
			{ 
				_GPUID = value;
				OnPropertyChanged("GPUID");
			}
		}
		[JsonProperty]
		public int LiveServicePort
		{
			get { return _LiveServicePort; }
			set 
			{ 
				_LiveServicePort = value;
				OnPropertyChanged("LiveServicePort");
			}
		}
		[JsonProperty]
		public string LiveServiceProtocol
		{
			get { return _LiveServiceProtocol; }
			set 
			{ 
				_LiveServiceProtocol = value;
				OnPropertyChanged("LiveServiceProtocol");
			}
		}
		[JsonProperty]
		public string LiveServiceInternalDomain
		{
			get { return _LiveServiceInternalDomain; }
			set 
			{ 
				_LiveServiceInternalDomain = value;
				OnPropertyChanged("LiveServiceInternalDomain");
			}
		}
		#endregion

		#region CTor
		public WowzaMediaServerNode()
		{
		}

		public WowzaMediaServerNode(JToken node) : base(node)
		{
			if(node["appPrefix"] != null)
			{
				this._AppPrefix = node["appPrefix"].Value<string>();
			}
			if(node["transcoder"] != null)
			{
				this._Transcoder = node["transcoder"].Value<string>();
			}
			if(node["GPUID"] != null)
			{
				this._GPUID = ParseInt(node["GPUID"].Value<string>());
			}
			if(node["liveServicePort"] != null)
			{
				this._LiveServicePort = ParseInt(node["liveServicePort"].Value<string>());
			}
			if(node["liveServiceProtocol"] != null)
			{
				this._LiveServiceProtocol = node["liveServiceProtocol"].Value<string>();
			}
			if(node["liveServiceInternalDomain"] != null)
			{
				this._LiveServiceInternalDomain = node["liveServiceInternalDomain"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaWowzaMediaServerNode");
			kparams.AddIfNotNull("appPrefix", this._AppPrefix);
			kparams.AddIfNotNull("transcoder", this._Transcoder);
			kparams.AddIfNotNull("GPUID", this._GPUID);
			kparams.AddIfNotNull("liveServicePort", this._LiveServicePort);
			kparams.AddIfNotNull("liveServiceProtocol", this._LiveServiceProtocol);
			kparams.AddIfNotNull("liveServiceInternalDomain", this._LiveServiceInternalDomain);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case APP_PREFIX:
					return "AppPrefix";
				case TRANSCODER:
					return "Transcoder";
				case GPU_ID:
					return "GPUID";
				case LIVE_SERVICE_PORT:
					return "LiveServicePort";
				case LIVE_SERVICE_PROTOCOL:
					return "LiveServiceProtocol";
				case LIVE_SERVICE_INTERNAL_DOMAIN:
					return "LiveServiceInternalDomain";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

