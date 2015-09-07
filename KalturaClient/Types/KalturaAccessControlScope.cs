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
// Copyright (C) 2006-2015  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaAccessControlScope : KalturaObjectBase
	{
		#region Private Fields
		private string _Referrer = null;
		private string _Ip = null;
		private string _Ks = null;
		private string _UserAgent = null;
		private int _Time = Int32.MinValue;
		private IList<KalturaAccessControlContextTypeHolder> _Contexts;
		private IList<KalturaKeyValue> _Hashes;
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
		public IList<KalturaAccessControlContextTypeHolder> Contexts
		{
			get { return _Contexts; }
			set 
			{ 
				_Contexts = value;
				OnPropertyChanged("Contexts");
			}
		}
		public IList<KalturaKeyValue> Hashes
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
		public KalturaAccessControlScope()
		{
		}

		public KalturaAccessControlScope(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "referrer":
						this.Referrer = txt;
						continue;
					case "ip":
						this.Ip = txt;
						continue;
					case "ks":
						this.Ks = txt;
						continue;
					case "userAgent":
						this.UserAgent = txt;
						continue;
					case "time":
						this.Time = ParseInt(txt);
						continue;
					case "contexts":
						this.Contexts = new List<KalturaAccessControlContextTypeHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Contexts.Add((KalturaAccessControlContextTypeHolder)KalturaObjectFactory.Create(arrayNode, "KalturaAccessControlContextTypeHolder"));
						}
						continue;
					case "hashes":
						this.Hashes = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Hashes.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAccessControlScope");
			kparams.AddIfNotNull("referrer", this.Referrer);
			kparams.AddIfNotNull("ip", this.Ip);
			kparams.AddIfNotNull("ks", this.Ks);
			kparams.AddIfNotNull("userAgent", this.UserAgent);
			kparams.AddIfNotNull("time", this.Time);
			kparams.AddIfNotNull("contexts", this.Contexts);
			kparams.AddIfNotNull("hashes", this.Hashes);
			return kparams;
		}
		#endregion
	}
}

