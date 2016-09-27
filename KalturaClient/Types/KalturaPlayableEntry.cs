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
	public class KalturaPlayableEntry : KalturaBaseEntry
	{
		#region Private Fields
		private int _Plays = Int32.MinValue;
		private int _Views = Int32.MinValue;
		private int _LastPlayedAt = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private int _MsDuration = Int32.MinValue;
		private KalturaDurationType _DurationType = null;
		#endregion

		#region Properties
		public int Plays
		{
			get { return _Plays; }
		}
		public int Views
		{
			get { return _Views; }
		}
		public int LastPlayedAt
		{
			get { return _LastPlayedAt; }
		}
		public int Width
		{
			get { return _Width; }
		}
		public int Height
		{
			get { return _Height; }
		}
		public int Duration
		{
			get { return _Duration; }
		}
		public int MsDuration
		{
			get { return _MsDuration; }
			set 
			{ 
				_MsDuration = value;
				OnPropertyChanged("MsDuration");
			}
		}
		public KalturaDurationType DurationType
		{
			get { return _DurationType; }
		}
		#endregion

		#region CTor
		public KalturaPlayableEntry()
		{
		}

		public KalturaPlayableEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "plays":
						this._Plays = ParseInt(txt);
						continue;
					case "views":
						this._Views = ParseInt(txt);
						continue;
					case "lastPlayedAt":
						this._LastPlayedAt = ParseInt(txt);
						continue;
					case "width":
						this._Width = ParseInt(txt);
						continue;
					case "height":
						this._Height = ParseInt(txt);
						continue;
					case "duration":
						this._Duration = ParseInt(txt);
						continue;
					case "msDuration":
						this._MsDuration = ParseInt(txt);
						continue;
					case "durationType":
						this._DurationType = (KalturaDurationType)KalturaStringEnum.Parse(typeof(KalturaDurationType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

