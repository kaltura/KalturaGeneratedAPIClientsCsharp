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
	public class KalturaAdCuePoint : KalturaCuePoint
	{
		#region Private Fields
		private KalturaAdProtocolType _ProtocolType = null;
		private string _SourceUrl = null;
		private KalturaAdType _AdType = null;
		private string _Title = null;
		private int _EndTime = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaAdProtocolType ProtocolType
		{
			get { return _ProtocolType; }
			set 
			{ 
				_ProtocolType = value;
				OnPropertyChanged("ProtocolType");
			}
		}
		public string SourceUrl
		{
			get { return _SourceUrl; }
			set 
			{ 
				_SourceUrl = value;
				OnPropertyChanged("SourceUrl");
			}
		}
		public KalturaAdType AdType
		{
			get { return _AdType; }
			set 
			{ 
				_AdType = value;
				OnPropertyChanged("AdType");
			}
		}
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		public int EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
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
		#endregion

		#region CTor
		public KalturaAdCuePoint()
		{
		}

		public KalturaAdCuePoint(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "protocolType":
						this.ProtocolType = (KalturaAdProtocolType)KalturaStringEnum.Parse(typeof(KalturaAdProtocolType), txt);
						continue;
					case "sourceUrl":
						this.SourceUrl = txt;
						continue;
					case "adType":
						this.AdType = (KalturaAdType)KalturaStringEnum.Parse(typeof(KalturaAdType), txt);
						continue;
					case "title":
						this.Title = txt;
						continue;
					case "endTime":
						this.EndTime = ParseInt(txt);
						continue;
					case "duration":
						this.Duration = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAdCuePoint");
			kparams.AddStringEnumIfNotNull("protocolType", this.ProtocolType);
			kparams.AddStringIfNotNull("sourceUrl", this.SourceUrl);
			kparams.AddStringEnumIfNotNull("adType", this.AdType);
			kparams.AddStringIfNotNull("title", this.Title);
			kparams.AddIntIfNotNull("endTime", this.EndTime);
			kparams.AddIntIfNotNull("duration", this.Duration);
			return kparams;
		}
		#endregion
	}
}

