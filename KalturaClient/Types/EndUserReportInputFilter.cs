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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class EndUserReportInputFilter : ReportInputFilter
	{
		#region Constants
		public const string APPLICATION = "application";
		public const string USER_IDS = "userIds";
		public const string PLAYBACK_CONTEXT = "playbackContext";
		public const string ANCESTOR_PLAYBACK_CONTEXT = "ancestorPlaybackContext";
		#endregion

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
		public EndUserReportInputFilter()
		{
		}

		public EndUserReportInputFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "application":
						this._Application = propertyNode.InnerText;
						continue;
					case "userIds":
						this._UserIds = propertyNode.InnerText;
						continue;
					case "playbackContext":
						this._PlaybackContext = propertyNode.InnerText;
						continue;
					case "ancestorPlaybackContext":
						this._AncestorPlaybackContext = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaEndUserReportInputFilter");
			kparams.AddIfNotNull("application", this._Application);
			kparams.AddIfNotNull("userIds", this._UserIds);
			kparams.AddIfNotNull("playbackContext", this._PlaybackContext);
			kparams.AddIfNotNull("ancestorPlaybackContext", this._AncestorPlaybackContext);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case APPLICATION:
					return "Application";
				case USER_IDS:
					return "UserIds";
				case PLAYBACK_CONTEXT:
					return "PlaybackContext";
				case ANCESTOR_PLAYBACK_CONTEXT:
					return "AncestorPlaybackContext";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

