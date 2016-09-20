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
	public class KalturaLiveToVodJobData : KalturaJobData
	{
		#region Private Fields
		private string _VodEntryId = null;
		private string _LiveEntryId = null;
		private float _TotalVodDuration = Single.MinValue;
		private float _LastSegmentDuration = Single.MinValue;
		private string _AmfArray = null;
		#endregion

		#region Properties
		public string VodEntryId
		{
			get { return _VodEntryId; }
			set 
			{ 
				_VodEntryId = value;
				OnPropertyChanged("VodEntryId");
			}
		}
		public string LiveEntryId
		{
			get { return _LiveEntryId; }
			set 
			{ 
				_LiveEntryId = value;
				OnPropertyChanged("LiveEntryId");
			}
		}
		public float TotalVodDuration
		{
			get { return _TotalVodDuration; }
			set 
			{ 
				_TotalVodDuration = value;
				OnPropertyChanged("TotalVodDuration");
			}
		}
		public float LastSegmentDuration
		{
			get { return _LastSegmentDuration; }
			set 
			{ 
				_LastSegmentDuration = value;
				OnPropertyChanged("LastSegmentDuration");
			}
		}
		public string AmfArray
		{
			get { return _AmfArray; }
			set 
			{ 
				_AmfArray = value;
				OnPropertyChanged("AmfArray");
			}
		}
		#endregion

		#region CTor
		public KalturaLiveToVodJobData()
		{
		}

		public KalturaLiveToVodJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "vodEntryId":
						this._VodEntryId = txt;
						continue;
					case "liveEntryId":
						this._LiveEntryId = txt;
						continue;
					case "totalVodDuration":
						this._TotalVodDuration = ParseFloat(txt);
						continue;
					case "lastSegmentDuration":
						this._LastSegmentDuration = ParseFloat(txt);
						continue;
					case "amfArray":
						this._AmfArray = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveToVodJobData");
			kparams.AddIfNotNull("vodEntryId", this.VodEntryId);
			kparams.AddIfNotNull("liveEntryId", this.LiveEntryId);
			kparams.AddIfNotNull("totalVodDuration", this.TotalVodDuration);
			kparams.AddIfNotNull("lastSegmentDuration", this.LastSegmentDuration);
			kparams.AddIfNotNull("amfArray", this.AmfArray);
			return kparams;
		}
		#endregion
	}
}

