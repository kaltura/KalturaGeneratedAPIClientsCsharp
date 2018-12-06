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
	public class LiveChannel : LiveEntry
	{
		#region Constants
		public const string PLAYLIST_ID = "playlistId";
		public const string REPEAT = "repeat";
		#endregion

		#region Private Fields
		private string _PlaylistId = null;
		private NullableBoolean _Repeat = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public string PlaylistId
		{
			get { return _PlaylistId; }
			set 
			{ 
				_PlaylistId = value;
				OnPropertyChanged("PlaylistId");
			}
		}
		public NullableBoolean Repeat
		{
			get { return _Repeat; }
			set 
			{ 
				_Repeat = value;
				OnPropertyChanged("Repeat");
			}
		}
		#endregion

		#region CTor
		public LiveChannel()
		{
		}

		public LiveChannel(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "playlistId":
						this._PlaylistId = propertyNode.InnerText;
						continue;
					case "repeat":
						this._Repeat = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
				}
			}
		}

		public LiveChannel(IDictionary<string,object> data) : base(data)
		{
			    this._PlaylistId = data.TryGetValueSafe<string>("playlistId");
			    this._Repeat = (NullableBoolean)ParseEnum(typeof(NullableBoolean), data.TryGetValueSafe<int>("repeat"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveChannel");
			kparams.AddIfNotNull("playlistId", this._PlaylistId);
			kparams.AddIfNotNull("repeat", this._Repeat);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PLAYLIST_ID:
					return "PlaylistId";
				case REPEAT:
					return "Repeat";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

