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
	public class KalturaLiveStreamParams : KalturaObjectBase
	{
		#region Private Fields
		private int _Bitrate = Int32.MinValue;
		private string _FlavorId = null;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private string _Codec = null;
		private int _FrameRate = Int32.MinValue;
		private float _KeyFrameInterval = Single.MinValue;
		#endregion

		#region Properties
		public int Bitrate
		{
			get { return _Bitrate; }
			set 
			{ 
				_Bitrate = value;
				OnPropertyChanged("Bitrate");
			}
		}
		public string FlavorId
		{
			get { return _FlavorId; }
			set 
			{ 
				_FlavorId = value;
				OnPropertyChanged("FlavorId");
			}
		}
		public int Width
		{
			get { return _Width; }
			set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		public int Height
		{
			get { return _Height; }
			set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		public string Codec
		{
			get { return _Codec; }
			set 
			{ 
				_Codec = value;
				OnPropertyChanged("Codec");
			}
		}
		public int FrameRate
		{
			get { return _FrameRate; }
			set 
			{ 
				_FrameRate = value;
				OnPropertyChanged("FrameRate");
			}
		}
		public float KeyFrameInterval
		{
			get { return _KeyFrameInterval; }
			set 
			{ 
				_KeyFrameInterval = value;
				OnPropertyChanged("KeyFrameInterval");
			}
		}
		#endregion

		#region CTor
		public KalturaLiveStreamParams()
		{
		}

		public KalturaLiveStreamParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "bitrate":
						this._Bitrate = ParseInt(txt);
						continue;
					case "flavorId":
						this._FlavorId = txt;
						continue;
					case "width":
						this._Width = ParseInt(txt);
						continue;
					case "height":
						this._Height = ParseInt(txt);
						continue;
					case "codec":
						this._Codec = txt;
						continue;
					case "frameRate":
						this._FrameRate = ParseInt(txt);
						continue;
					case "keyFrameInterval":
						this._KeyFrameInterval = ParseFloat(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveStreamParams");
			kparams.AddIfNotNull("bitrate", this._Bitrate);
			kparams.AddIfNotNull("flavorId", this._FlavorId);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("height", this._Height);
			kparams.AddIfNotNull("codec", this._Codec);
			kparams.AddIfNotNull("frameRate", this._FrameRate);
			kparams.AddIfNotNull("keyFrameInterval", this._KeyFrameInterval);
			return kparams;
		}
		#endregion
	}
}

