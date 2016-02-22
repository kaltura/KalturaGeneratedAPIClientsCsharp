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
	public class KalturaEndUserReportInputFilter : KalturaReportInputFilter
	{
		#region Private Fields
		private string _Application = null;
		private string _UserIds = null;
		private string _PlaybackContext = null;
		private string _AncestorPlaybackContext = null;
		#endregion

		#region Properties
		public string Application
		{
			get { return _Application; }
			set 
			{ 
				_Application = value;
				OnPropertyChanged("Application");
			}
		}
		public string UserIds
		{
			get { return _UserIds; }
			set 
			{ 
				_UserIds = value;
				OnPropertyChanged("UserIds");
			}
		}
		public string PlaybackContext
		{
			get { return _PlaybackContext; }
			set 
			{ 
				_PlaybackContext = value;
				OnPropertyChanged("PlaybackContext");
			}
		}
		public string AncestorPlaybackContext
		{
			get { return _AncestorPlaybackContext; }
			set 
			{ 
				_AncestorPlaybackContext = value;
				OnPropertyChanged("AncestorPlaybackContext");
			}
		}
		#endregion

		#region CTor
		public KalturaEndUserReportInputFilter()
		{
		}

		public KalturaEndUserReportInputFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "application":
						this.Application = txt;
						continue;
					case "userIds":
						this.UserIds = txt;
						continue;
					case "playbackContext":
						this.PlaybackContext = txt;
						continue;
					case "ancestorPlaybackContext":
						this.AncestorPlaybackContext = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEndUserReportInputFilter");
			kparams.AddIfNotNull("application", this.Application);
			kparams.AddIfNotNull("userIds", this.UserIds);
			kparams.AddIfNotNull("playbackContext", this.PlaybackContext);
			kparams.AddIfNotNull("ancestorPlaybackContext", this.AncestorPlaybackContext);
			return kparams;
		}
		#endregion
	}
}

