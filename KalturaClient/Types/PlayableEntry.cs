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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class PlayableEntry : BaseEntry
	{
		#region Constants
		public const string PLAYS = "plays";
		public const string VIEWS = "views";
		public const string LAST_PLAYED_AT = "lastPlayedAt";
		public const string WIDTH = "width";
		public const string HEIGHT = "height";
		public const string DURATION = "duration";
		public const string MS_DURATION = "msDuration";
		public const string DURATION_TYPE = "durationType";
		#endregion

		#region Private Fields
		private int _Plays = Int32.MinValue;
		private int _Views = Int32.MinValue;
		private int _LastPlayedAt = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private int _MsDuration = Int32.MinValue;
		private DurationType _DurationType = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int Plays
		{
			get { return _Plays; }
			private set 
			{ 
				_Plays = value;
				OnPropertyChanged("Plays");
			}
		}
		[JsonProperty]
		public int Views
		{
			get { return _Views; }
			private set 
			{ 
				_Views = value;
				OnPropertyChanged("Views");
			}
		}
		[JsonProperty]
		public int LastPlayedAt
		{
			get { return _LastPlayedAt; }
			private set 
			{ 
				_LastPlayedAt = value;
				OnPropertyChanged("LastPlayedAt");
			}
		}
		[JsonProperty]
		public int Width
		{
			get { return _Width; }
			private set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		[JsonProperty]
		public int Height
		{
			get { return _Height; }
			private set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		[JsonProperty]
		public int Duration
		{
			get { return _Duration; }
			private set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		[JsonProperty]
		public int MsDuration
		{
			get { return _MsDuration; }
			set 
			{ 
				_MsDuration = value;
				OnPropertyChanged("MsDuration");
			}
		}
		[JsonProperty]
		public DurationType DurationType
		{
			get { return _DurationType; }
			private set 
			{ 
				_DurationType = value;
				OnPropertyChanged("DurationType");
			}
		}
		#endregion

		#region CTor
		public PlayableEntry()
		{
		}

		public PlayableEntry(JToken node) : base(node)
		{
			if(node["plays"] != null)
			{
				this._Plays = ParseInt(node["plays"].Value<string>());
			}
			if(node["views"] != null)
			{
				this._Views = ParseInt(node["views"].Value<string>());
			}
			if(node["lastPlayedAt"] != null)
			{
				this._LastPlayedAt = ParseInt(node["lastPlayedAt"].Value<string>());
			}
			if(node["width"] != null)
			{
				this._Width = ParseInt(node["width"].Value<string>());
			}
			if(node["height"] != null)
			{
				this._Height = ParseInt(node["height"].Value<string>());
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseInt(node["duration"].Value<string>());
			}
			if(node["msDuration"] != null)
			{
				this._MsDuration = ParseInt(node["msDuration"].Value<string>());
			}
			if(node["durationType"] != null)
			{
				this._DurationType = (DurationType)StringEnum.Parse(typeof(DurationType), node["durationType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPlayableEntry");
			kparams.AddIfNotNull("plays", this._Plays);
			kparams.AddIfNotNull("views", this._Views);
			kparams.AddIfNotNull("lastPlayedAt", this._LastPlayedAt);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("height", this._Height);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("msDuration", this._MsDuration);
			kparams.AddIfNotNull("durationType", this._DurationType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PLAYS:
					return "Plays";
				case VIEWS:
					return "Views";
				case LAST_PLAYED_AT:
					return "LastPlayedAt";
				case WIDTH:
					return "Width";
				case HEIGHT:
					return "Height";
				case DURATION:
					return "Duration";
				case MS_DURATION:
					return "MsDuration";
				case DURATION_TYPE:
					return "DurationType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

