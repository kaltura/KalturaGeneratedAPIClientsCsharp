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
// Copyright (C) 2006-2016  Kaltura Inc.
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
		public string Referrer
		{
			get { return _Referrer; }
			set 
			{ 
				_Referrer = value;
				OnPropertyChanged("Referrer");
			}
		}
		public string Ip
		{
			get { return _Ip; }
			set 
			{ 
				_Ip = value;
				OnPropertyChanged("Ip");
			}
		}
		public string Ks
		{
			get { return _Ks; }
			set 
			{ 
				_Ks = value;
				OnPropertyChanged("Ks");
			}
		}
		public string UserAgent
		{
			get { return _UserAgent; }
			set 
			{ 
				_UserAgent = value;
				OnPropertyChanged("UserAgent");
			}
		}
		public int Time
		{
			get { return _Time; }
			set 
			{ 
				_Time = value;
				OnPropertyChanged("Time");
			}
		}
		public IList<AccessControlContextTypeHolder> Contexts
		{
			get { return _Contexts; }
			set 
			{ 
				_Contexts = value;
				OnPropertyChanged("Contexts");
			}
		}
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

		public AccessControlScope(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "referrer":
						this._Referrer = propertyNode.InnerText;
						continue;
					case "ip":
						this._Ip = propertyNode.InnerText;
						continue;
					case "ks":
						this._Ks = propertyNode.InnerText;
						continue;
					case "userAgent":
						this._UserAgent = propertyNode.InnerText;
						continue;
					case "time":
						this._Time = ParseInt(propertyNode.InnerText);
						continue;
					case "contexts":
						this._Contexts = new List<AccessControlContextTypeHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Contexts.Add(ObjectFactory.Create<AccessControlContextTypeHolder>(arrayNode));
						}
						continue;
					case "hashes":
						this._Hashes = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Hashes.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
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

