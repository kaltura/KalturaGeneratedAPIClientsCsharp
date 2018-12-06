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
	public class StreamContainer : ObjectBase
	{
		#region Constants
		public const string TYPE = "type";
		public const string TRACK_INDEX = "trackIndex";
		public const string LANGUAGE = "language";
		public const string CHANNEL_INDEX = "channelIndex";
		public const string LABEL = "label";
		public const string CHANNEL_LAYOUT = "channelLayout";
		#endregion

		#region Private Fields
		private string _Type = null;
		private int _TrackIndex = Int32.MinValue;
		private string _Language = null;
		private int _ChannelIndex = Int32.MinValue;
		private string _Label = null;
		private string _ChannelLayout = null;
		#endregion

		#region Properties
		public string Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public int TrackIndex
		{
			get { return _TrackIndex; }
			set 
			{ 
				_TrackIndex = value;
				OnPropertyChanged("TrackIndex");
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
		public int ChannelIndex
		{
			get { return _ChannelIndex; }
			set 
			{ 
				_ChannelIndex = value;
				OnPropertyChanged("ChannelIndex");
			}
		}
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		public string ChannelLayout
		{
			get { return _ChannelLayout; }
			set 
			{ 
				_ChannelLayout = value;
				OnPropertyChanged("ChannelLayout");
			}
		}
		#endregion

		#region CTor
		public StreamContainer()
		{
		}

		public StreamContainer(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "type":
						this._Type = propertyNode.InnerText;
						continue;
					case "trackIndex":
						this._TrackIndex = ParseInt(propertyNode.InnerText);
						continue;
					case "language":
						this._Language = propertyNode.InnerText;
						continue;
					case "channelIndex":
						this._ChannelIndex = ParseInt(propertyNode.InnerText);
						continue;
					case "label":
						this._Label = propertyNode.InnerText;
						continue;
					case "channelLayout":
						this._ChannelLayout = propertyNode.InnerText;
						continue;
				}
			}
		}

		public StreamContainer(IDictionary<string,object> data) : base(data)
		{
			    this._Type = data.TryGetValueSafe<string>("type");
			    this._TrackIndex = data.TryGetValueSafe<int>("trackIndex");
			    this._Language = data.TryGetValueSafe<string>("language");
			    this._ChannelIndex = data.TryGetValueSafe<int>("channelIndex");
			    this._Label = data.TryGetValueSafe<string>("label");
			    this._ChannelLayout = data.TryGetValueSafe<string>("channelLayout");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaStreamContainer");
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("trackIndex", this._TrackIndex);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("channelIndex", this._ChannelIndex);
			kparams.AddIfNotNull("label", this._Label);
			kparams.AddIfNotNull("channelLayout", this._ChannelLayout);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TYPE:
					return "Type";
				case TRACK_INDEX:
					return "TrackIndex";
				case LANGUAGE:
					return "Language";
				case CHANNEL_INDEX:
					return "ChannelIndex";
				case LABEL:
					return "Label";
				case CHANNEL_LAYOUT:
					return "ChannelLayout";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

