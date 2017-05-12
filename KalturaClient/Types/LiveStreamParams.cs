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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class LiveStreamParams : ObjectBase
	{
		#region Constants
		public const string BITRATE = "bitrate";
		public const string FLAVOR_ID = "flavorId";
		public const string WIDTH = "width";
		public const string HEIGHT = "height";
		public const string CODEC = "codec";
		public const string FRAME_RATE = "frameRate";
		public const string KEY_FRAME_INTERVAL = "keyFrameInterval";
		public const string LANGUAGE = "language";
		#endregion

		#region Private Fields
		private int _Bitrate = Int32.MinValue;
		private string _FlavorId = null;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private string _Codec = null;
		private int _FrameRate = Int32.MinValue;
		private float _KeyFrameInterval = Single.MinValue;
		private string _Language = null;
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
		public string Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		#endregion

		#region CTor
		public LiveStreamParams()
		{
		}

		public LiveStreamParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "bitrate":
						this._Bitrate = ParseInt(propertyNode.InnerText);
						continue;
					case "flavorId":
						this._FlavorId = propertyNode.InnerText;
						continue;
					case "width":
						this._Width = ParseInt(propertyNode.InnerText);
						continue;
					case "height":
						this._Height = ParseInt(propertyNode.InnerText);
						continue;
					case "codec":
						this._Codec = propertyNode.InnerText;
						continue;
					case "frameRate":
						this._FrameRate = ParseInt(propertyNode.InnerText);
						continue;
					case "keyFrameInterval":
						this._KeyFrameInterval = ParseFloat(propertyNode.InnerText);
						continue;
					case "language":
						this._Language = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaLiveStreamParams");
			kparams.AddIfNotNull("bitrate", this._Bitrate);
			kparams.AddIfNotNull("flavorId", this._FlavorId);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("height", this._Height);
			kparams.AddIfNotNull("codec", this._Codec);
			kparams.AddIfNotNull("frameRate", this._FrameRate);
			kparams.AddIfNotNull("keyFrameInterval", this._KeyFrameInterval);
			kparams.AddIfNotNull("language", this._Language);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case BITRATE:
					return "Bitrate";
				case FLAVOR_ID:
					return "FlavorId";
				case WIDTH:
					return "Width";
				case HEIGHT:
					return "Height";
				case CODEC:
					return "Codec";
				case FRAME_RATE:
					return "FrameRate";
				case KEY_FRAME_INTERVAL:
					return "KeyFrameInterval";
				case LANGUAGE:
					return "Language";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

