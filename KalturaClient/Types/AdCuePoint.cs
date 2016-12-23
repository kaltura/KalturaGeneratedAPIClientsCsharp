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
	public class AdCuePoint : CuePoint
	{
		#region Constants
		public const string PROTOCOL_TYPE = "protocolType";
		public const string SOURCE_URL = "sourceUrl";
		public const string AD_TYPE = "adType";
		public const string TITLE = "title";
		public const string END_TIME = "endTime";
		public const string DURATION = "duration";
		#endregion

		#region Private Fields
		private AdProtocolType _ProtocolType = null;
		private string _SourceUrl = null;
		private AdType _AdType = null;
		private string _Title = null;
		private int _EndTime = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		#endregion

		#region Properties
		public AdProtocolType ProtocolType
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
		public AdType AdType
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
		public AdCuePoint()
		{
		}

		public AdCuePoint(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "protocolType":
						this._ProtocolType = (AdProtocolType)StringEnum.Parse(typeof(AdProtocolType), propertyNode.InnerText);
						continue;
					case "sourceUrl":
						this._SourceUrl = propertyNode.InnerText;
						continue;
					case "adType":
						this._AdType = (AdType)StringEnum.Parse(typeof(AdType), propertyNode.InnerText);
						continue;
					case "title":
						this._Title = propertyNode.InnerText;
						continue;
					case "endTime":
						this._EndTime = ParseInt(propertyNode.InnerText);
						continue;
					case "duration":
						this._Duration = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaAdCuePoint");
			kparams.AddIfNotNull("protocolType", this._ProtocolType);
			kparams.AddIfNotNull("sourceUrl", this._SourceUrl);
			kparams.AddIfNotNull("adType", this._AdType);
			kparams.AddIfNotNull("title", this._Title);
			kparams.AddIfNotNull("endTime", this._EndTime);
			kparams.AddIfNotNull("duration", this._Duration);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROTOCOL_TYPE:
					return "ProtocolType";
				case SOURCE_URL:
					return "SourceUrl";
				case AD_TYPE:
					return "AdType";
				case TITLE:
					return "Title";
				case END_TIME:
					return "EndTime";
				case DURATION:
					return "Duration";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

