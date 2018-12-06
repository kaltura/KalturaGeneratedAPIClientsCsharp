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
	public class PlaybackSource : ObjectBase
	{
		#region Constants
		public const string DELIVERY_PROFILE_ID = "deliveryProfileId";
		public const string FORMAT = "format";
		public const string PROTOCOLS = "protocols";
		public const string FLAVOR_IDS = "flavorIds";
		public const string URL = "url";
		public const string DRM = "drm";
		#endregion

		#region Private Fields
		private string _DeliveryProfileId = null;
		private string _Format = null;
		private string _Protocols = null;
		private string _FlavorIds = null;
		private string _Url = null;
		private IList<DrmPlaybackPluginData> _Drm;
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
		public string Protocols
		{
			get { return _Protocols; }
			set 
			{ 
				_Protocols = value;
				OnPropertyChanged("Protocols");
			}
		}
		public string FlavorIds
		{
			get { return _FlavorIds; }
			set 
			{ 
				_FlavorIds = value;
				OnPropertyChanged("FlavorIds");
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
		public IList<DrmPlaybackPluginData> Drm
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
		public PlaybackSource()
		{
		}

		public PlaybackSource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "deliveryProfileId":
						this._DeliveryProfileId = propertyNode.InnerText;
						continue;
					case "format":
						this._Format = propertyNode.InnerText;
						continue;
					case "protocols":
						this._Protocols = propertyNode.InnerText;
						continue;
					case "flavorIds":
						this._FlavorIds = propertyNode.InnerText;
						continue;
					case "url":
						this._Url = propertyNode.InnerText;
						continue;
					case "drm":
						this._Drm = new List<DrmPlaybackPluginData>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Drm.Add(ObjectFactory.Create<DrmPlaybackPluginData>(arrayNode));
						}
						continue;
				}
			}
		}

		public PlaybackSource(IDictionary<string,object> data) : base(data)
		{
			    this._DeliveryProfileId = data.TryGetValueSafe<string>("deliveryProfileId");
			    this._Format = data.TryGetValueSafe<string>("format");
			    this._Protocols = data.TryGetValueSafe<string>("protocols");
			    this._FlavorIds = data.TryGetValueSafe<string>("flavorIds");
			    this._Url = data.TryGetValueSafe<string>("url");
			    this._Drm = new List<DrmPlaybackPluginData>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("drm", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._Drm.Add(ObjectFactory.Create<DrmPlaybackPluginData>((IDictionary<string,object>)dataDictionary));
			    }
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPlaybackSource");
			kparams.AddIfNotNull("deliveryProfileId", this._DeliveryProfileId);
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("protocols", this._Protocols);
			kparams.AddIfNotNull("flavorIds", this._FlavorIds);
			kparams.AddIfNotNull("url", this._Url);
			kparams.AddIfNotNull("drm", this._Drm);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DELIVERY_PROFILE_ID:
					return "DeliveryProfileId";
				case FORMAT:
					return "Format";
				case PROTOCOLS:
					return "Protocols";
				case FLAVOR_IDS:
					return "FlavorIds";
				case URL:
					return "Url";
				case DRM:
					return "Drm";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

