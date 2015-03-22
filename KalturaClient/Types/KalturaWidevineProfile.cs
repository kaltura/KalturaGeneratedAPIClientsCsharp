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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaWidevineProfile : KalturaDrmProfile
	{
		#region Private Fields
		private string _Key = null;
		private string _Iv = null;
		private string _Owner = null;
		private string _Portal = null;
		private int _MaxGop = Int32.MinValue;
		private string _RegServerHost = null;
		#endregion

		#region Properties
		public string Key
		{
			get { return _Key; }
			set 
			{ 
				_Key = value;
				OnPropertyChanged("Key");
			}
		}
		public string Iv
		{
			get { return _Iv; }
			set 
			{ 
				_Iv = value;
				OnPropertyChanged("Iv");
			}
		}
		public string Owner
		{
			get { return _Owner; }
			set 
			{ 
				_Owner = value;
				OnPropertyChanged("Owner");
			}
		}
		public string Portal
		{
			get { return _Portal; }
			set 
			{ 
				_Portal = value;
				OnPropertyChanged("Portal");
			}
		}
		public int MaxGop
		{
			get { return _MaxGop; }
			set 
			{ 
				_MaxGop = value;
				OnPropertyChanged("MaxGop");
			}
		}
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
		public KalturaWidevineProfile()
		{
		}

		public KalturaWidevineProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "key":
						this.Key = txt;
						continue;
					case "iv":
						this.Iv = txt;
						continue;
					case "owner":
						this.Owner = txt;
						continue;
					case "portal":
						this.Portal = txt;
						continue;
					case "maxGop":
						this.MaxGop = ParseInt(txt);
						continue;
					case "regServerHost":
						this.RegServerHost = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaWidevineProfile");
			kparams.AddStringIfNotNull("key", this.Key);
			kparams.AddStringIfNotNull("iv", this.Iv);
			kparams.AddStringIfNotNull("owner", this.Owner);
			kparams.AddStringIfNotNull("portal", this.Portal);
			kparams.AddIntIfNotNull("maxGop", this.MaxGop);
			kparams.AddStringIfNotNull("regServerHost", this.RegServerHost);
			return kparams;
		}
		#endregion
	}
}

