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
	public class KalturaLiveAsset : KalturaFlavorAsset
	{
		#region Private Fields
		private string _MulticastIP = null;
		private int _MulticastPort = Int32.MinValue;
		#endregion

		#region Properties
		public string MulticastIP
		{
			get { return _MulticastIP; }
			set 
			{ 
				_MulticastIP = value;
				OnPropertyChanged("MulticastIP");
			}
		}
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
		public KalturaLiveAsset()
		{
		}

		public KalturaLiveAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "multicastIP":
						this.MulticastIP = txt;
						continue;
					case "multicastPort":
						this.MulticastPort = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveAsset");
			kparams.AddStringIfNotNull("multicastIP", this.MulticastIP);
			kparams.AddIntIfNotNull("multicastPort", this.MulticastPort);
			return kparams;
		}
		#endregion
	}
}

