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
		public string AppPrefix
		{
			get { return _AppPrefix; }
			set 
			{ 
				_AppPrefix = value;
				OnPropertyChanged("AppPrefix");
			}
		}
		public string Transcoder
		{
			get { return _Transcoder; }
			set 
			{ 
				_Transcoder = value;
				OnPropertyChanged("Transcoder");
			}
		}
		public int GPUID
		{
			get { return _GPUID; }
			set 
			{ 
				_GPUID = value;
				OnPropertyChanged("GPUID");
			}
		}
		public int LiveServicePort
		{
			get { return _LiveServicePort; }
			set 
			{ 
				_LiveServicePort = value;
				OnPropertyChanged("LiveServicePort");
			}
		}
		public string LiveServiceProtocol
		{
			get { return _LiveServiceProtocol; }
			set 
			{ 
				_LiveServiceProtocol = value;
				OnPropertyChanged("LiveServiceProtocol");
			}
		}
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

		public WowzaMediaServerNode(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "appPrefix":
						this._AppPrefix = propertyNode.InnerText;
						continue;
					case "transcoder":
						this._Transcoder = propertyNode.InnerText;
						continue;
					case "GPUID":
						this._GPUID = ParseInt(propertyNode.InnerText);
						continue;
					case "liveServicePort":
						this._LiveServicePort = ParseInt(propertyNode.InnerText);
						continue;
					case "liveServiceProtocol":
						this._LiveServiceProtocol = propertyNode.InnerText;
						continue;
					case "liveServiceInternalDomain":
						this._LiveServiceInternalDomain = propertyNode.InnerText;
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

