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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaDeliveryServerNodeBaseFilter : KalturaServerNodeFilter
	{
		#region Private Fields
		private string _PlaybackDomainLike = null;
		private string _PlaybackDomainMultiLikeOr = null;
		private string _PlaybackDomainMultiLikeAnd = null;
		#endregion

		#region Properties
		public string PlaybackDomainLike
		{
			get { return _PlaybackDomainLike; }
			set 
			{ 
				_PlaybackDomainLike = value;
				OnPropertyChanged("PlaybackDomainLike");
			}
		}
		public string PlaybackDomainMultiLikeOr
		{
			get { return _PlaybackDomainMultiLikeOr; }
			set 
			{ 
				_PlaybackDomainMultiLikeOr = value;
				OnPropertyChanged("PlaybackDomainMultiLikeOr");
			}
		}
		public string PlaybackDomainMultiLikeAnd
		{
			get { return _PlaybackDomainMultiLikeAnd; }
			set 
			{ 
				_PlaybackDomainMultiLikeAnd = value;
				OnPropertyChanged("PlaybackDomainMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public KalturaDeliveryServerNodeBaseFilter()
		{
		}

		public KalturaDeliveryServerNodeBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "playbackDomainLike":
						this.PlaybackDomainLike = txt;
						continue;
					case "playbackDomainMultiLikeOr":
						this.PlaybackDomainMultiLikeOr = txt;
						continue;
					case "playbackDomainMultiLikeAnd":
						this.PlaybackDomainMultiLikeAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDeliveryServerNodeBaseFilter");
			kparams.AddIfNotNull("playbackDomainLike", this.PlaybackDomainLike);
			kparams.AddIfNotNull("playbackDomainMultiLikeOr", this.PlaybackDomainMultiLikeOr);
			kparams.AddIfNotNull("playbackDomainMultiLikeAnd", this.PlaybackDomainMultiLikeAnd);
			return kparams;
		}
		#endregion
	}
}

