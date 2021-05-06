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
	public class RoomDetails : ObjectBase
	{
		#region Constants
		public const string SERVER_URL = "serverUrl";
		public const string ENTRY_ID = "entryId";
		public const string TOKEN = "token";
		public const string EXPIRY = "expiry";
		public const string SERVER_NAME = "serverName";
		#endregion

		#region Private Fields
		private string _ServerUrl = null;
		private string _EntryId = null;
		private string _Token = null;
		private int _Expiry = Int32.MinValue;
		private string _ServerName = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string ServerUrl
		{
			get { return _ServerUrl; }
			set 
			{ 
				_ServerUrl = value;
				OnPropertyChanged("ServerUrl");
			}
		}
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		[JsonProperty]
		public string Token
		{
			get { return _Token; }
			set 
			{ 
				_Token = value;
				OnPropertyChanged("Token");
			}
		}
		[JsonProperty]
		public int Expiry
		{
			get { return _Expiry; }
			set 
			{ 
				_Expiry = value;
				OnPropertyChanged("Expiry");
			}
		}
		[JsonProperty]
		public string ServerName
		{
			get { return _ServerName; }
			set 
			{ 
				_ServerName = value;
				OnPropertyChanged("ServerName");
			}
		}
		#endregion

		#region CTor
		public RoomDetails()
		{
		}

		public RoomDetails(JToken node) : base(node)
		{
			if(node["serverUrl"] != null)
			{
				this._ServerUrl = node["serverUrl"].Value<string>();
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["token"] != null)
			{
				this._Token = node["token"].Value<string>();
			}
			if(node["expiry"] != null)
			{
				this._Expiry = ParseInt(node["expiry"].Value<string>());
			}
			if(node["serverName"] != null)
			{
				this._ServerName = node["serverName"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaRoomDetails");
			kparams.AddIfNotNull("serverUrl", this._ServerUrl);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("token", this._Token);
			kparams.AddIfNotNull("expiry", this._Expiry);
			kparams.AddIfNotNull("serverName", this._ServerName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SERVER_URL:
					return "ServerUrl";
				case ENTRY_ID:
					return "EntryId";
				case TOKEN:
					return "Token";
				case EXPIRY:
					return "Expiry";
				case SERVER_NAME:
					return "ServerName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

