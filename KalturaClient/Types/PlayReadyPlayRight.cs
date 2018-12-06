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
		public PlayReadyAnalogVideoOPL AnalogVideoOPL
		{
			get { return _AnalogVideoOPL; }
			set 
			{ 
				_AnalogVideoOPL = value;
				OnPropertyChanged("AnalogVideoOPL");
			}
		}
		public IList<PlayReadyAnalogVideoOPIdHolder> AnalogVideoOutputProtectionList
		{
			get { return _AnalogVideoOutputProtectionList; }
			set 
			{ 
				_AnalogVideoOutputProtectionList = value;
				OnPropertyChanged("AnalogVideoOutputProtectionList");
			}
		}
		public PlayReadyDigitalAudioOPL CompressedDigitalAudioOPL
		{
			get { return _CompressedDigitalAudioOPL; }
			set 
			{ 
				_CompressedDigitalAudioOPL = value;
				OnPropertyChanged("CompressedDigitalAudioOPL");
			}
		}
		public PlayReadyCompressedDigitalVideoOPL CompressedDigitalVideoOPL
		{
			get { return _CompressedDigitalVideoOPL; }
			set 
			{ 
				_CompressedDigitalVideoOPL = value;
				OnPropertyChanged("CompressedDigitalVideoOPL");
			}
		}
		public IList<PlayReadyDigitalAudioOPIdHolder> DigitalAudioOutputProtectionList
		{
			get { return _DigitalAudioOutputProtectionList; }
			set 
			{ 
				_DigitalAudioOutputProtectionList = value;
				OnPropertyChanged("DigitalAudioOutputProtectionList");
			}
		}
		public PlayReadyDigitalAudioOPL UncompressedDigitalAudioOPL
		{
			get { return _UncompressedDigitalAudioOPL; }
			set 
			{ 
				_UncompressedDigitalAudioOPL = value;
				OnPropertyChanged("UncompressedDigitalAudioOPL");
			}
		}
		public PlayReadyUncompressedDigitalVideoOPL UncompressedDigitalVideoOPL
		{
			get { return _UncompressedDigitalVideoOPL; }
			set 
			{ 
				_UncompressedDigitalVideoOPL = value;
				OnPropertyChanged("UncompressedDigitalVideoOPL");
			}
		}
		public int FirstPlayExpiration
		{
			get { return _FirstPlayExpiration; }
			set 
			{ 
				_FirstPlayExpiration = value;
				OnPropertyChanged("FirstPlayExpiration");
			}
		}
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

		public PlayReadyPlayRight(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "analogVideoOPL":
						this._AnalogVideoOPL = (PlayReadyAnalogVideoOPL)ParseEnum(typeof(PlayReadyAnalogVideoOPL), propertyNode.InnerText);
						continue;
					case "analogVideoOutputProtectionList":
						this._AnalogVideoOutputProtectionList = new List<PlayReadyAnalogVideoOPIdHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._AnalogVideoOutputProtectionList.Add(ObjectFactory.Create<PlayReadyAnalogVideoOPIdHolder>(arrayNode));
						}
						continue;
					case "compressedDigitalAudioOPL":
						this._CompressedDigitalAudioOPL = (PlayReadyDigitalAudioOPL)ParseEnum(typeof(PlayReadyDigitalAudioOPL), propertyNode.InnerText);
						continue;
					case "compressedDigitalVideoOPL":
						this._CompressedDigitalVideoOPL = (PlayReadyCompressedDigitalVideoOPL)ParseEnum(typeof(PlayReadyCompressedDigitalVideoOPL), propertyNode.InnerText);
						continue;
					case "digitalAudioOutputProtectionList":
						this._DigitalAudioOutputProtectionList = new List<PlayReadyDigitalAudioOPIdHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._DigitalAudioOutputProtectionList.Add(ObjectFactory.Create<PlayReadyDigitalAudioOPIdHolder>(arrayNode));
						}
						continue;
					case "uncompressedDigitalAudioOPL":
						this._UncompressedDigitalAudioOPL = (PlayReadyDigitalAudioOPL)ParseEnum(typeof(PlayReadyDigitalAudioOPL), propertyNode.InnerText);
						continue;
					case "uncompressedDigitalVideoOPL":
						this._UncompressedDigitalVideoOPL = (PlayReadyUncompressedDigitalVideoOPL)ParseEnum(typeof(PlayReadyUncompressedDigitalVideoOPL), propertyNode.InnerText);
						continue;
					case "firstPlayExpiration":
						this._FirstPlayExpiration = ParseInt(propertyNode.InnerText);
						continue;
					case "playEnablers":
						this._PlayEnablers = new List<PlayReadyPlayEnablerHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._PlayEnablers.Add(ObjectFactory.Create<PlayReadyPlayEnablerHolder>(arrayNode));
						}
						continue;
				}
			}
		}

		public PlayReadyPlayRight(IDictionary<string,object> data) : base(data)
		{
			    this._AnalogVideoOPL = (PlayReadyAnalogVideoOPL)ParseEnum(typeof(PlayReadyAnalogVideoOPL), data.TryGetValueSafe<int>("analogVideoOPL"));
			    this._AnalogVideoOutputProtectionList = new List<PlayReadyAnalogVideoOPIdHolder>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("analogVideoOutputProtectionList", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._AnalogVideoOutputProtectionList.Add(ObjectFactory.Create<PlayReadyAnalogVideoOPIdHolder>((IDictionary<string,object>)dataDictionary));
			    }
			    this._CompressedDigitalAudioOPL = (PlayReadyDigitalAudioOPL)ParseEnum(typeof(PlayReadyDigitalAudioOPL), data.TryGetValueSafe<int>("compressedDigitalAudioOPL"));
			    this._CompressedDigitalVideoOPL = (PlayReadyCompressedDigitalVideoOPL)ParseEnum(typeof(PlayReadyCompressedDigitalVideoOPL), data.TryGetValueSafe<int>("compressedDigitalVideoOPL"));
			    this._DigitalAudioOutputProtectionList = new List<PlayReadyDigitalAudioOPIdHolder>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("digitalAudioOutputProtectionList", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._DigitalAudioOutputProtectionList.Add(ObjectFactory.Create<PlayReadyDigitalAudioOPIdHolder>((IDictionary<string,object>)dataDictionary));
			    }
			    this._UncompressedDigitalAudioOPL = (PlayReadyDigitalAudioOPL)ParseEnum(typeof(PlayReadyDigitalAudioOPL), data.TryGetValueSafe<int>("uncompressedDigitalAudioOPL"));
			    this._UncompressedDigitalVideoOPL = (PlayReadyUncompressedDigitalVideoOPL)ParseEnum(typeof(PlayReadyUncompressedDigitalVideoOPL), data.TryGetValueSafe<int>("uncompressedDigitalVideoOPL"));
			    this._FirstPlayExpiration = data.TryGetValueSafe<int>("firstPlayExpiration");
			    this._PlayEnablers = new List<PlayReadyPlayEnablerHolder>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("playEnablers", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._PlayEnablers.Add(ObjectFactory.Create<PlayReadyPlayEnablerHolder>((IDictionary<string,object>)dataDictionary));
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

