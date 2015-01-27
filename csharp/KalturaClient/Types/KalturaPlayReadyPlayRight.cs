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
	public class KalturaPlayReadyPlayRight : KalturaPlayReadyRight
	{
		#region Private Fields
		private KalturaPlayReadyAnalogVideoOPL _AnalogVideoOPL = (KalturaPlayReadyAnalogVideoOPL)Int32.MinValue;
		private IList<KalturaPlayReadyAnalogVideoOPIdHolder> _AnalogVideoOutputProtectionList;
		private KalturaPlayReadyDigitalAudioOPL _CompressedDigitalAudioOPL = (KalturaPlayReadyDigitalAudioOPL)Int32.MinValue;
		private KalturaPlayReadyCompressedDigitalVideoOPL _CompressedDigitalVideoOPL = (KalturaPlayReadyCompressedDigitalVideoOPL)Int32.MinValue;
		private IList<KalturaPlayReadyDigitalAudioOPIdHolder> _DigitalAudioOutputProtectionList;
		private KalturaPlayReadyDigitalAudioOPL _UncompressedDigitalAudioOPL = (KalturaPlayReadyDigitalAudioOPL)Int32.MinValue;
		private KalturaPlayReadyUncompressedDigitalVideoOPL _UncompressedDigitalVideoOPL = (KalturaPlayReadyUncompressedDigitalVideoOPL)Int32.MinValue;
		private int _FirstPlayExpiration = Int32.MinValue;
		private IList<KalturaPlayReadyPlayEnablerHolder> _PlayEnablers;
		#endregion

		#region Properties
		public KalturaPlayReadyAnalogVideoOPL AnalogVideoOPL
		{
			get { return _AnalogVideoOPL; }
			set 
			{ 
				_AnalogVideoOPL = value;
				OnPropertyChanged("AnalogVideoOPL");
			}
		}
		public IList<KalturaPlayReadyAnalogVideoOPIdHolder> AnalogVideoOutputProtectionList
		{
			get { return _AnalogVideoOutputProtectionList; }
			set 
			{ 
				_AnalogVideoOutputProtectionList = value;
				OnPropertyChanged("AnalogVideoOutputProtectionList");
			}
		}
		public KalturaPlayReadyDigitalAudioOPL CompressedDigitalAudioOPL
		{
			get { return _CompressedDigitalAudioOPL; }
			set 
			{ 
				_CompressedDigitalAudioOPL = value;
				OnPropertyChanged("CompressedDigitalAudioOPL");
			}
		}
		public KalturaPlayReadyCompressedDigitalVideoOPL CompressedDigitalVideoOPL
		{
			get { return _CompressedDigitalVideoOPL; }
			set 
			{ 
				_CompressedDigitalVideoOPL = value;
				OnPropertyChanged("CompressedDigitalVideoOPL");
			}
		}
		public IList<KalturaPlayReadyDigitalAudioOPIdHolder> DigitalAudioOutputProtectionList
		{
			get { return _DigitalAudioOutputProtectionList; }
			set 
			{ 
				_DigitalAudioOutputProtectionList = value;
				OnPropertyChanged("DigitalAudioOutputProtectionList");
			}
		}
		public KalturaPlayReadyDigitalAudioOPL UncompressedDigitalAudioOPL
		{
			get { return _UncompressedDigitalAudioOPL; }
			set 
			{ 
				_UncompressedDigitalAudioOPL = value;
				OnPropertyChanged("UncompressedDigitalAudioOPL");
			}
		}
		public KalturaPlayReadyUncompressedDigitalVideoOPL UncompressedDigitalVideoOPL
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
		public IList<KalturaPlayReadyPlayEnablerHolder> PlayEnablers
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
		public KalturaPlayReadyPlayRight()
		{
		}

		public KalturaPlayReadyPlayRight(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "analogVideoOPL":
						this.AnalogVideoOPL = (KalturaPlayReadyAnalogVideoOPL)ParseEnum(typeof(KalturaPlayReadyAnalogVideoOPL), txt);
						continue;
					case "analogVideoOutputProtectionList":
						this.AnalogVideoOutputProtectionList = new List<KalturaPlayReadyAnalogVideoOPIdHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.AnalogVideoOutputProtectionList.Add((KalturaPlayReadyAnalogVideoOPIdHolder)KalturaObjectFactory.Create(arrayNode, "KalturaPlayReadyAnalogVideoOPIdHolder"));
						}
						continue;
					case "compressedDigitalAudioOPL":
						this.CompressedDigitalAudioOPL = (KalturaPlayReadyDigitalAudioOPL)ParseEnum(typeof(KalturaPlayReadyDigitalAudioOPL), txt);
						continue;
					case "compressedDigitalVideoOPL":
						this.CompressedDigitalVideoOPL = (KalturaPlayReadyCompressedDigitalVideoOPL)ParseEnum(typeof(KalturaPlayReadyCompressedDigitalVideoOPL), txt);
						continue;
					case "digitalAudioOutputProtectionList":
						this.DigitalAudioOutputProtectionList = new List<KalturaPlayReadyDigitalAudioOPIdHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.DigitalAudioOutputProtectionList.Add((KalturaPlayReadyDigitalAudioOPIdHolder)KalturaObjectFactory.Create(arrayNode, "KalturaPlayReadyDigitalAudioOPIdHolder"));
						}
						continue;
					case "uncompressedDigitalAudioOPL":
						this.UncompressedDigitalAudioOPL = (KalturaPlayReadyDigitalAudioOPL)ParseEnum(typeof(KalturaPlayReadyDigitalAudioOPL), txt);
						continue;
					case "uncompressedDigitalVideoOPL":
						this.UncompressedDigitalVideoOPL = (KalturaPlayReadyUncompressedDigitalVideoOPL)ParseEnum(typeof(KalturaPlayReadyUncompressedDigitalVideoOPL), txt);
						continue;
					case "firstPlayExpiration":
						this.FirstPlayExpiration = ParseInt(txt);
						continue;
					case "playEnablers":
						this.PlayEnablers = new List<KalturaPlayReadyPlayEnablerHolder>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.PlayEnablers.Add((KalturaPlayReadyPlayEnablerHolder)KalturaObjectFactory.Create(arrayNode, "KalturaPlayReadyPlayEnablerHolder"));
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
			kparams.AddReplace("objectType", "KalturaPlayReadyPlayRight");
			kparams.AddEnumIfNotNull("analogVideoOPL", this.AnalogVideoOPL);
			if (this.AnalogVideoOutputProtectionList != null)
			{
				if (this.AnalogVideoOutputProtectionList.Count == 0)
				{
					kparams.Add("analogVideoOutputProtectionList:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaPlayReadyAnalogVideoOPIdHolder item in this.AnalogVideoOutputProtectionList)
					{
						kparams.Add("analogVideoOutputProtectionList:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddEnumIfNotNull("compressedDigitalAudioOPL", this.CompressedDigitalAudioOPL);
			kparams.AddEnumIfNotNull("compressedDigitalVideoOPL", this.CompressedDigitalVideoOPL);
			if (this.DigitalAudioOutputProtectionList != null)
			{
				if (this.DigitalAudioOutputProtectionList.Count == 0)
				{
					kparams.Add("digitalAudioOutputProtectionList:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaPlayReadyDigitalAudioOPIdHolder item in this.DigitalAudioOutputProtectionList)
					{
						kparams.Add("digitalAudioOutputProtectionList:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddEnumIfNotNull("uncompressedDigitalAudioOPL", this.UncompressedDigitalAudioOPL);
			kparams.AddEnumIfNotNull("uncompressedDigitalVideoOPL", this.UncompressedDigitalVideoOPL);
			kparams.AddIntIfNotNull("firstPlayExpiration", this.FirstPlayExpiration);
			if (this.PlayEnablers != null)
			{
				if (this.PlayEnablers.Count == 0)
				{
					kparams.Add("playEnablers:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaPlayReadyPlayEnablerHolder item in this.PlayEnablers)
					{
						kparams.Add("playEnablers:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

