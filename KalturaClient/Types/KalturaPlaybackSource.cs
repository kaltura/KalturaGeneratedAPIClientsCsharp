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
	public class KalturaPlaybackSource : KalturaObjectBase
	{
		#region Private Fields
		private string _DeliveryProfileId = null;
		private string _Format = null;
		private string _Priority = null;
		private IList<KalturaString> _Protocols;
		private IList<KalturaString> _Flavors;
		private string _Url = null;
		private IList<KalturaDrmEntryPlayingPluginData> _Drm;
		#endregion

		#region Properties
		public string DeliveryProfileId
		{
			get { return _DeliveryProfileId; }
			set 
			{ 
				_DeliveryProfileId = value;
				OnPropertyChanged("DeliveryProfileId");
			}
		}
		public string Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		public string Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		public new IList<KalturaString> Protocols
		{
			get { return _Protocols; }
			set 
			{ 
				_Protocols = value;
				OnPropertyChanged("Protocols");
			}
		}
		public new IList<KalturaString> Flavors
		{
			get { return _Flavors; }
			set 
			{ 
				_Flavors = value;
				OnPropertyChanged("Flavors");
			}
		}
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		public new IList<KalturaDrmEntryPlayingPluginData> Drm
		{
			get { return _Drm; }
			set 
			{ 
				_Drm = value;
				OnPropertyChanged("Drm");
			}
		}
		#endregion

		#region CTor
		public KalturaPlaybackSource()
		{
		}

		public KalturaPlaybackSource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "deliveryProfileId":
						this._DeliveryProfileId = txt;
						continue;
					case "format":
						this._Format = txt;
						continue;
					case "priority":
						this._Priority = txt;
						continue;
					case "protocols":
						this._Protocols = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Protocols.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "flavors":
						this._Flavors = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Flavors.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "url":
						this._Url = txt;
						continue;
					case "drm":
						this._Drm = new List<KalturaDrmEntryPlayingPluginData>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Drm.Add((KalturaDrmEntryPlayingPluginData)KalturaObjectFactory.Create(arrayNode, "KalturaDrmEntryPlayingPluginData"));
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
			kparams.AddReplace("objectType", "KalturaPlaybackSource");
			kparams.AddIfNotNull("deliveryProfileId", this._DeliveryProfileId);
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("priority", this._Priority);
			kparams.AddIfNotNull("protocols", this._Protocols);
			kparams.AddIfNotNull("flavors", this._Flavors);
			kparams.AddIfNotNull("url", this._Url);
			kparams.AddIfNotNull("drm", this._Drm);
			return kparams;
		}
		#endregion
	}
}

