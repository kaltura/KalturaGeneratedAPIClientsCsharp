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

namespace Kaltura
{
	public class KalturaWowzaMediaServerNode : KalturaMediaServerNode
	{
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
		public KalturaWowzaMediaServerNode()
		{
		}

		public KalturaWowzaMediaServerNode(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "appPrefix":
						this._AppPrefix = txt;
						continue;
					case "transcoder":
						this._Transcoder = txt;
						continue;
					case "GPUID":
						this._GPUID = ParseInt(txt);
						continue;
					case "liveServicePort":
						this._LiveServicePort = ParseInt(txt);
						continue;
					case "liveServiceProtocol":
						this._LiveServiceProtocol = txt;
						continue;
					case "liveServiceInternalDomain":
						this._LiveServiceInternalDomain = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaWowzaMediaServerNode");
			kparams.AddIfNotNull("appPrefix", this._AppPrefix);
			kparams.AddIfNotNull("transcoder", this._Transcoder);
			kparams.AddIfNotNull("GPUID", this._GPUID);
			kparams.AddIfNotNull("liveServicePort", this._LiveServicePort);
			kparams.AddIfNotNull("liveServiceProtocol", this._LiveServiceProtocol);
			kparams.AddIfNotNull("liveServiceInternalDomain", this._LiveServiceInternalDomain);
			return kparams;
		}
		#endregion
	}
}

