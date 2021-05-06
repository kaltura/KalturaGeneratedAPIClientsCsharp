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
	public class AccessControlScope : ObjectBase
	{
		#region Constants
		public const string REFERRER = "referrer";
		public const string IP = "ip";
		public const string KS = "ks";
		public const string USER_AGENT = "userAgent";
		public const string TIME = "time";
		public const string CONTEXTS = "contexts";
		public const string HASHES = "hashes";
		#endregion

		#region Private Fields
		private string _Referrer = null;
		private string _Ip = null;
		private string _Ks = null;
		private string _UserAgent = null;
		private int _Time = Int32.MinValue;
		private IList<AccessControlContextTypeHolder> _Contexts;
		private IList<KeyValue> _Hashes;
		#endregion

		#region Properties
		[JsonProperty]
		public string Referrer
		{
			get { return _Referrer; }
			set 
			{ 
				_Referrer = value;
				OnPropertyChanged("Referrer");
			}
		}
		[JsonProperty]
		public string Ip
		{
			get { return _Ip; }
			set 
			{ 
				_Ip = value;
				OnPropertyChanged("Ip");
			}
		}
		[JsonProperty]
		public string Ks
		{
			get { return _Ks; }
			set 
			{ 
				_Ks = value;
				OnPropertyChanged("Ks");
			}
		}
		[JsonProperty]
		public string UserAgent
		{
			get { return _UserAgent; }
			set 
			{ 
				_UserAgent = value;
				OnPropertyChanged("UserAgent");
			}
		}
		[JsonProperty]
		public int Time
		{
			get { return _Time; }
			set 
			{ 
				_Time = value;
				OnPropertyChanged("Time");
			}
		}
		[JsonProperty]
		public IList<AccessControlContextTypeHolder> Contexts
		{
			get { return _Contexts; }
			set 
			{ 
				_Contexts = value;
				OnPropertyChanged("Contexts");
			}
		}
		[JsonProperty]
		public IList<KeyValue> Hashes
		{
			get { return _Hashes; }
			set 
			{ 
				_Hashes = value;
				OnPropertyChanged("Hashes");
			}
		}
		#endregion

		#region CTor
		public AccessControlScope()
		{
		}

		public AccessControlScope(JToken node) : base(node)
		{
			if(node["referrer"] != null)
			{
				this._Referrer = node["referrer"].Value<string>();
			}
			if(node["ip"] != null)
			{
				this._Ip = node["ip"].Value<string>();
			}
			if(node["ks"] != null)
			{
				this._Ks = node["ks"].Value<string>();
			}
			if(node["userAgent"] != null)
			{
				this._UserAgent = node["userAgent"].Value<string>();
			}
			if(node["time"] != null)
			{
				this._Time = ParseInt(node["time"].Value<string>());
			}
			if(node["contexts"] != null)
			{
				this._Contexts = new List<AccessControlContextTypeHolder>();
				foreach(var arrayNode in node["contexts"].Children())
				{
					this._Contexts.Add(ObjectFactory.Create<AccessControlContextTypeHolder>(arrayNode));
				}
			}
			if(node["hashes"] != null)
			{
				this._Hashes = new List<KeyValue>();
				foreach(var arrayNode in node["hashes"].Children())
				{
					this._Hashes.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAccessControlScope");
			kparams.AddIfNotNull("referrer", this._Referrer);
			kparams.AddIfNotNull("ip", this._Ip);
			kparams.AddIfNotNull("ks", this._Ks);
			kparams.AddIfNotNull("userAgent", this._UserAgent);
			kparams.AddIfNotNull("time", this._Time);
			kparams.AddIfNotNull("contexts", this._Contexts);
			kparams.AddIfNotNull("hashes", this._Hashes);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case REFERRER:
					return "Referrer";
				case IP:
					return "Ip";
				case KS:
					return "Ks";
				case USER_AGENT:
					return "UserAgent";
				case TIME:
					return "Time";
				case CONTEXTS:
					return "Contexts";
				case HASHES:
					return "Hashes";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

