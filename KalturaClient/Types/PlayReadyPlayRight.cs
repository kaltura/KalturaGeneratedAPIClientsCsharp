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
	public class PlayReadyPlayRight : PlayReadyRight
	{
		#region Constants
		public const string ANALOG_VIDEO_OPL = "analogVideoOPL";
		public const string ANALOG_VIDEO_OUTPUT_PROTECTION_LIST = "analogVideoOutputProtectionList";
		public const string COMPRESSED_DIGITAL_AUDIO_OPL = "compressedDigitalAudioOPL";
		public const string COMPRESSED_DIGITAL_VIDEO_OPL = "compressedDigitalVideoOPL";
		public const string DIGITAL_AUDIO_OUTPUT_PROTECTION_LIST = "digitalAudioOutputProtectionList";
		public const string UNCOMPRESSED_DIGITAL_AUDIO_OPL = "uncompressedDigitalAudioOPL";
		public const string UNCOMPRESSED_DIGITAL_VIDEO_OPL = "uncompressedDigitalVideoOPL";
		public const string FIRST_PLAY_EXPIRATION = "firstPlayExpiration";
		public const string PLAY_ENABLERS = "playEnablers";
		#endregion

		#region Private Fields
		private PlayReadyAnalogVideoOPL _AnalogVideoOPL = (PlayReadyAnalogVideoOPL)Int32.MinValue;
		private IList<PlayReadyAnalogVideoOPIdHolder> _AnalogVideoOutputProtectionList;
		private PlayReadyDigitalAudioOPL _CompressedDigitalAudioOPL = (PlayReadyDigitalAudioOPL)Int32.MinValue;
		private PlayReadyCompressedDigitalVideoOPL _CompressedDigitalVideoOPL = (PlayReadyCompressedDigitalVideoOPL)Int32.MinValue;
		private IList<PlayReadyDigitalAudioOPIdHolder> _DigitalAudioOutputProtectionList;
		private PlayReadyDigitalAudioOPL _UncompressedDigitalAudioOPL = (PlayReadyDigitalAudioOPL)Int32.MinValue;
		private PlayReadyUncompressedDigitalVideoOPL _UncompressedDigitalVideoOPL = (PlayReadyUncompressedDigitalVideoOPL)Int32.MinValue;
		private int _FirstPlayExpiration = Int32.MinValue;
		private IList<PlayReadyPlayEnablerHolder> _PlayEnablers;
		#endregion

		#region Properties
		/// <summary>
		/// Use AnalogVideoOPLAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PlayReadyAnalogVideoOPL AnalogVideoOPL
		{
			get { return _AnalogVideoOPL; }
			set 
			{ 
				_AnalogVideoOPL = value;
				OnPropertyChanged("AnalogVideoOPL");
			}
		}
		/// <summary>
		/// Use AnalogVideoOutputProtectionListAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<PlayReadyAnalogVideoOPIdHolder> AnalogVideoOutputProtectionList
		{
			get { return _AnalogVideoOutputProtectionList; }
			set 
			{ 
				_AnalogVideoOutputProtectionList = value;
				OnPropertyChanged("AnalogVideoOutputProtectionList");
			}
		}
		/// <summary>
		/// Use CompressedDigitalAudioOPLAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PlayReadyDigitalAudioOPL CompressedDigitalAudioOPL
		{
			get { return _CompressedDigitalAudioOPL; }
			set 
			{ 
				_CompressedDigitalAudioOPL = value;
				OnPropertyChanged("CompressedDigitalAudioOPL");
			}
		}
		/// <summary>
		/// Use CompressedDigitalVideoOPLAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PlayReadyCompressedDigitalVideoOPL CompressedDigitalVideoOPL
		{
			get { return _CompressedDigitalVideoOPL; }
			set 
			{ 
				_CompressedDigitalVideoOPL = value;
				OnPropertyChanged("CompressedDigitalVideoOPL");
			}
		}
		/// <summary>
		/// Use DigitalAudioOutputProtectionListAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<PlayReadyDigitalAudioOPIdHolder> DigitalAudioOutputProtectionList
		{
			get { return _DigitalAudioOutputProtectionList; }
			set 
			{ 
				_DigitalAudioOutputProtectionList = value;
				OnPropertyChanged("DigitalAudioOutputProtectionList");
			}
		}
		/// <summary>
		/// Use UncompressedDigitalAudioOPLAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PlayReadyDigitalAudioOPL UncompressedDigitalAudioOPL
		{
			get { return _UncompressedDigitalAudioOPL; }
			set 
			{ 
				_UncompressedDigitalAudioOPL = value;
				OnPropertyChanged("UncompressedDigitalAudioOPL");
			}
		}
		/// <summary>
		/// Use UncompressedDigitalVideoOPLAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PlayReadyUncompressedDigitalVideoOPL UncompressedDigitalVideoOPL
		{
			get { return _UncompressedDigitalVideoOPL; }
			set 
			{ 
				_UncompressedDigitalVideoOPL = value;
				OnPropertyChanged("UncompressedDigitalVideoOPL");
			}
		}
		/// <summary>
		/// Use FirstPlayExpirationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FirstPlayExpiration
		{
			get { return _FirstPlayExpiration; }
			set 
			{ 
				_FirstPlayExpiration = value;
				OnPropertyChanged("FirstPlayExpiration");
			}
		}
		/// <summary>
		/// Use PlayEnablersAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<PlayReadyPlayEnablerHolder> PlayEnablers
		{
			get { return _PlayEnablers; }
			set 
			{ 
				_PlayEnablers = value;
				OnPropertyChanged("PlayEnablers");
			}
		}
		#endregion

		#region CTor
		public PlayReadyPlayRight()
		{
		}

		public PlayReadyPlayRight(JToken node) : base(node)
		{
			if(node["analogVideoOPL"] != null)
			{
				this._AnalogVideoOPL = (PlayReadyAnalogVideoOPL)ParseEnum(typeof(PlayReadyAnalogVideoOPL), node["analogVideoOPL"].Value<string>());
			}
			if(node["analogVideoOutputProtectionList"] != null)
			{
				this._AnalogVideoOutputProtectionList = new List<PlayReadyAnalogVideoOPIdHolder>();
				foreach(var arrayNode in node["analogVideoOutputProtectionList"].Children())
				{
					this._AnalogVideoOutputProtectionList.Add(ObjectFactory.Create<PlayReadyAnalogVideoOPIdHolder>(arrayNode));
				}
			}
			if(node["compressedDigitalAudioOPL"] != null)
			{
				this._CompressedDigitalAudioOPL = (PlayReadyDigitalAudioOPL)ParseEnum(typeof(PlayReadyDigitalAudioOPL), node["compressedDigitalAudioOPL"].Value<string>());
			}
			if(node["compressedDigitalVideoOPL"] != null)
			{
				this._CompressedDigitalVideoOPL = (PlayReadyCompressedDigitalVideoOPL)ParseEnum(typeof(PlayReadyCompressedDigitalVideoOPL), node["compressedDigitalVideoOPL"].Value<string>());
			}
			if(node["digitalAudioOutputProtectionList"] != null)
			{
				this._DigitalAudioOutputProtectionList = new List<PlayReadyDigitalAudioOPIdHolder>();
				foreach(var arrayNode in node["digitalAudioOutputProtectionList"].Children())
				{
					this._DigitalAudioOutputProtectionList.Add(ObjectFactory.Create<PlayReadyDigitalAudioOPIdHolder>(arrayNode));
				}
			}
			if(node["uncompressedDigitalAudioOPL"] != null)
			{
				this._UncompressedDigitalAudioOPL = (PlayReadyDigitalAudioOPL)ParseEnum(typeof(PlayReadyDigitalAudioOPL), node["uncompressedDigitalAudioOPL"].Value<string>());
			}
			if(node["uncompressedDigitalVideoOPL"] != null)
			{
				this._UncompressedDigitalVideoOPL = (PlayReadyUncompressedDigitalVideoOPL)ParseEnum(typeof(PlayReadyUncompressedDigitalVideoOPL), node["uncompressedDigitalVideoOPL"].Value<string>());
			}
			if(node["firstPlayExpiration"] != null)
			{
				this._FirstPlayExpiration = ParseInt(node["firstPlayExpiration"].Value<string>());
			}
			if(node["playEnablers"] != null)
			{
				this._PlayEnablers = new List<PlayReadyPlayEnablerHolder>();
				foreach(var arrayNode in node["playEnablers"].Children())
				{
					this._PlayEnablers.Add(ObjectFactory.Create<PlayReadyPlayEnablerHolder>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPlayReadyPlayRight");
			kparams.AddIfNotNull("analogVideoOPL", this._AnalogVideoOPL);
			kparams.AddIfNotNull("analogVideoOutputProtectionList", this._AnalogVideoOutputProtectionList);
			kparams.AddIfNotNull("compressedDigitalAudioOPL", this._CompressedDigitalAudioOPL);
			kparams.AddIfNotNull("compressedDigitalVideoOPL", this._CompressedDigitalVideoOPL);
			kparams.AddIfNotNull("digitalAudioOutputProtectionList", this._DigitalAudioOutputProtectionList);
			kparams.AddIfNotNull("uncompressedDigitalAudioOPL", this._UncompressedDigitalAudioOPL);
			kparams.AddIfNotNull("uncompressedDigitalVideoOPL", this._UncompressedDigitalVideoOPL);
			kparams.AddIfNotNull("firstPlayExpiration", this._FirstPlayExpiration);
			kparams.AddIfNotNull("playEnablers", this._PlayEnablers);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ANALOG_VIDEO_OPL:
					return "AnalogVideoOPL";
				case ANALOG_VIDEO_OUTPUT_PROTECTION_LIST:
					return "AnalogVideoOutputProtectionList";
				case COMPRESSED_DIGITAL_AUDIO_OPL:
					return "CompressedDigitalAudioOPL";
				case COMPRESSED_DIGITAL_VIDEO_OPL:
					return "CompressedDigitalVideoOPL";
				case DIGITAL_AUDIO_OUTPUT_PROTECTION_LIST:
					return "DigitalAudioOutputProtectionList";
				case UNCOMPRESSED_DIGITAL_AUDIO_OPL:
					return "UncompressedDigitalAudioOPL";
				case UNCOMPRESSED_DIGITAL_VIDEO_OPL:
					return "UncompressedDigitalVideoOPL";
				case FIRST_PLAY_EXPIRATION:
					return "FirstPlayExpiration";
				case PLAY_ENABLERS:
					return "PlayEnablers";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

