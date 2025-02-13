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
	public class WidevineProfile : DrmProfile
	{
		#region Constants
		public const string KEY = "key";
		public const string IV = "iv";
		public const string OWNER = "owner";
		public const string PORTAL = "portal";
		public const string MAX_GOP = "maxGop";
		public const string REG_SERVER_HOST = "regServerHost";
		#endregion

		#region Private Fields
		private string _Key = null;
		private string _Iv = null;
		private string _Owner = null;
		private string _Portal = null;
		private int _MaxGop = Int32.MinValue;
		private string _RegServerHost = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string Key
		{
			get { return _Key; }
			set 
			{ 
				_Key = value;
				OnPropertyChanged("Key");
			}
		}
		[JsonProperty]
		public string Iv
		{
			get { return _Iv; }
			set 
			{ 
				_Iv = value;
				OnPropertyChanged("Iv");
			}
		}
		[JsonProperty]
		public string Owner
		{
			get { return _Owner; }
			set 
			{ 
				_Owner = value;
				OnPropertyChanged("Owner");
			}
		}
		[JsonProperty]
		public string Portal
		{
			get { return _Portal; }
			set 
			{ 
				_Portal = value;
				OnPropertyChanged("Portal");
			}
		}
		[JsonProperty]
		public int MaxGop
		{
			get { return _MaxGop; }
			set 
			{ 
				_MaxGop = value;
				OnPropertyChanged("MaxGop");
			}
		}
		[JsonProperty]
		public string RegServerHost
		{
			get { return _RegServerHost; }
			set 
			{ 
				_RegServerHost = value;
				OnPropertyChanged("RegServerHost");
			}
		}
		#endregion

		#region CTor
		public WidevineProfile()
		{
		}

		public WidevineProfile(JToken node) : base(node)
		{
			if(node["key"] != null)
			{
				this._Key = node["key"].Value<string>();
			}
			if(node["iv"] != null)
			{
				this._Iv = node["iv"].Value<string>();
			}
			if(node["owner"] != null)
			{
				this._Owner = node["owner"].Value<string>();
			}
			if(node["portal"] != null)
			{
				this._Portal = node["portal"].Value<string>();
			}
			if(node["maxGop"] != null)
			{
				this._MaxGop = ParseInt(node["maxGop"].Value<string>());
			}
			if(node["regServerHost"] != null)
			{
				this._RegServerHost = node["regServerHost"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaWidevineProfile");
			kparams.AddIfNotNull("key", this._Key);
			kparams.AddIfNotNull("iv", this._Iv);
			kparams.AddIfNotNull("owner", this._Owner);
			kparams.AddIfNotNull("portal", this._Portal);
			kparams.AddIfNotNull("maxGop", this._MaxGop);
			kparams.AddIfNotNull("regServerHost", this._RegServerHost);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KEY:
					return "Key";
				case IV:
					return "Iv";
				case OWNER:
					return "Owner";
				case PORTAL:
					return "Portal";
				case MAX_GOP:
					return "MaxGop";
				case REG_SERVER_HOST:
					return "RegServerHost";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

