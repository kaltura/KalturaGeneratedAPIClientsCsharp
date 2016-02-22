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
	public class KalturaMediaServerNode : KalturaDeliveryServerNode
	{
		#region Private Fields
		private string _ApplicationName = null;
		private IList<KalturaKeyValue> _MediaServerPortConfig;
		private IList<KalturaKeyValue> _MediaServerPlaybackDomainConfig;
		#endregion

		#region Properties
		public string ApplicationName
		{
			get { return _ApplicationName; }
			set 
			{ 
				_ApplicationName = value;
				OnPropertyChanged("ApplicationName");
			}
		}
		public IList<KalturaKeyValue> MediaServerPortConfig
		{
			get { return _MediaServerPortConfig; }
			set 
			{ 
				_MediaServerPortConfig = value;
				OnPropertyChanged("MediaServerPortConfig");
			}
		}
		public IList<KalturaKeyValue> MediaServerPlaybackDomainConfig
		{
			get { return _MediaServerPlaybackDomainConfig; }
			set 
			{ 
				_MediaServerPlaybackDomainConfig = value;
				OnPropertyChanged("MediaServerPlaybackDomainConfig");
			}
		}
		#endregion

		#region CTor
		public KalturaMediaServerNode()
		{
		}

		public KalturaMediaServerNode(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "applicationName":
						this.ApplicationName = txt;
						continue;
					case "mediaServerPortConfig":
						this.MediaServerPortConfig = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.MediaServerPortConfig.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
					case "mediaServerPlaybackDomainConfig":
						this.MediaServerPlaybackDomainConfig = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.MediaServerPlaybackDomainConfig.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaMediaServerNode");
			kparams.AddIfNotNull("applicationName", this.ApplicationName);
			kparams.AddIfNotNull("mediaServerPortConfig", this.MediaServerPortConfig);
			kparams.AddIfNotNull("mediaServerPlaybackDomainConfig", this.MediaServerPlaybackDomainConfig);
			return kparams;
		}
		#endregion
	}
}

