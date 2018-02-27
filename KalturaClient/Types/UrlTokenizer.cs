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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class UrlTokenizer : ObjectBase
	{
		#region Constants
		public const string WINDOW = "window";
		public const string KEY = "key";
		public const string LIMIT_IP_ADDRESS = "limitIpAddress";
		#endregion

		#region Private Fields
		private int _Window = Int32.MinValue;
		private string _Key = null;
		private bool? _LimitIpAddress = null;
		#endregion

		#region Properties
		public int Window
		{
			get { return _Window; }
			set 
			{ 
				_Window = value;
				OnPropertyChanged("Window");
			}
		}
		public string Key
		{
			get { return _Key; }
			set 
			{ 
				_Key = value;
				OnPropertyChanged("Key");
			}
		}
		public bool? LimitIpAddress
		{
			get { return _LimitIpAddress; }
			set 
			{ 
				_LimitIpAddress = value;
				OnPropertyChanged("LimitIpAddress");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizer()
		{
		}

		public UrlTokenizer(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "window":
						this._Window = ParseInt(propertyNode.InnerText);
						continue;
					case "key":
						this._Key = propertyNode.InnerText;
						continue;
					case "limitIpAddress":
						this._LimitIpAddress = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaUrlTokenizer");
			kparams.AddIfNotNull("window", this._Window);
			kparams.AddIfNotNull("key", this._Key);
			kparams.AddIfNotNull("limitIpAddress", this._LimitIpAddress);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case WINDOW:
					return "Window";
				case KEY:
					return "Key";
				case LIMIT_IP_ADDRESS:
					return "LimitIpAddress";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

