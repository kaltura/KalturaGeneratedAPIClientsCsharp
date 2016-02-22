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
	public class KalturaPlaylist : KalturaBaseEntry
	{
		#region Private Fields
		private string _PlaylistContent = null;
		private IList<KalturaMediaEntryFilterForPlaylist> _Filters;
		private int _TotalResults = Int32.MinValue;
		private KalturaPlaylistType _PlaylistType = (KalturaPlaylistType)Int32.MinValue;
		private int _Plays = Int32.MinValue;
		private int _Views = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private string _ExecuteUrl = null;
		#endregion

		#region Properties
		public string PlaylistContent
		{
			get { return _PlaylistContent; }
			set 
			{ 
				_PlaylistContent = value;
				OnPropertyChanged("PlaylistContent");
			}
		}
		public IList<KalturaMediaEntryFilterForPlaylist> Filters
		{
			get { return _Filters; }
			set 
			{ 
				_Filters = value;
				OnPropertyChanged("Filters");
			}
		}
		public int TotalResults
		{
			get { return _TotalResults; }
			set 
			{ 
				_TotalResults = value;
				OnPropertyChanged("TotalResults");
			}
		}
		public KalturaPlaylistType PlaylistType
		{
			get { return _PlaylistType; }
			set 
			{ 
				_PlaylistType = value;
				OnPropertyChanged("PlaylistType");
			}
		}
		public int Plays
		{
			get { return _Plays; }
			set 
			{ 
				_Plays = value;
				OnPropertyChanged("Plays");
			}
		}
		public int Views
		{
			get { return _Views; }
			set 
			{ 
				_Views = value;
				OnPropertyChanged("Views");
			}
		}
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		public string ExecuteUrl
		{
			get { return _ExecuteUrl; }
			set 
			{ 
				_ExecuteUrl = value;
				OnPropertyChanged("ExecuteUrl");
			}
		}
		#endregion

		#region CTor
		public KalturaPlaylist()
		{
		}

		public KalturaPlaylist(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "playlistContent":
						this.PlaylistContent = txt;
						continue;
					case "filters":
						this.Filters = new List<KalturaMediaEntryFilterForPlaylist>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Filters.Add((KalturaMediaEntryFilterForPlaylist)KalturaObjectFactory.Create(arrayNode, "KalturaMediaEntryFilterForPlaylist"));
						}
						continue;
					case "totalResults":
						this.TotalResults = ParseInt(txt);
						continue;
					case "playlistType":
						this.PlaylistType = (KalturaPlaylistType)ParseEnum(typeof(KalturaPlaylistType), txt);
						continue;
					case "plays":
						this.Plays = ParseInt(txt);
						continue;
					case "views":
						this.Views = ParseInt(txt);
						continue;
					case "duration":
						this.Duration = ParseInt(txt);
						continue;
					case "executeUrl":
						this.ExecuteUrl = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPlaylist");
			kparams.AddIfNotNull("playlistContent", this.PlaylistContent);
			kparams.AddIfNotNull("filters", this.Filters);
			kparams.AddIfNotNull("totalResults", this.TotalResults);
			kparams.AddIfNotNull("playlistType", this.PlaylistType);
			kparams.AddIfNotNull("plays", this.Plays);
			kparams.AddIfNotNull("views", this.Views);
			kparams.AddIfNotNull("duration", this.Duration);
			kparams.AddIfNotNull("executeUrl", this.ExecuteUrl);
			return kparams;
		}
		#endregion
	}
}

