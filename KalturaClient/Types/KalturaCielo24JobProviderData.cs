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
	public class KalturaCielo24JobProviderData : KalturaIntegrationJobProviderData
	{
		#region Private Fields
		private string _EntryId = null;
		private string _FlavorAssetId = null;
		private string _CaptionAssetFormats = null;
		private KalturaCielo24Priority _Priority = null;
		private KalturaCielo24Fidelity _Fidelity = null;
		private string _Username = null;
		private string _Password = null;
		private string _BaseUrl = null;
		private KalturaLanguage _SpokenLanguage = null;
		private bool? _ReplaceMediaContent = null;
		#endregion

		#region Properties
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public string CaptionAssetFormats
		{
			get { return _CaptionAssetFormats; }
			set 
			{ 
				_CaptionAssetFormats = value;
				OnPropertyChanged("CaptionAssetFormats");
			}
		}
		public KalturaCielo24Priority Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		public KalturaCielo24Fidelity Fidelity
		{
			get { return _Fidelity; }
			set 
			{ 
				_Fidelity = value;
				OnPropertyChanged("Fidelity");
			}
		}
		public string Username
		{
			get { return _Username; }
		}
		public string Password
		{
			get { return _Password; }
		}
		public string BaseUrl
		{
			get { return _BaseUrl; }
		}
		public KalturaLanguage SpokenLanguage
		{
			get { return _SpokenLanguage; }
			set 
			{ 
				_SpokenLanguage = value;
				OnPropertyChanged("SpokenLanguage");
			}
		}
		public bool? ReplaceMediaContent
		{
			get { return _ReplaceMediaContent; }
			set 
			{ 
				_ReplaceMediaContent = value;
				OnPropertyChanged("ReplaceMediaContent");
			}
		}
		#endregion

		#region CTor
		public KalturaCielo24JobProviderData()
		{
		}

		public KalturaCielo24JobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "entryId":
						this._EntryId = txt;
						continue;
					case "flavorAssetId":
						this._FlavorAssetId = txt;
						continue;
					case "captionAssetFormats":
						this._CaptionAssetFormats = txt;
						continue;
					case "priority":
						this._Priority = (KalturaCielo24Priority)KalturaStringEnum.Parse(typeof(KalturaCielo24Priority), txt);
						continue;
					case "fidelity":
						this._Fidelity = (KalturaCielo24Fidelity)KalturaStringEnum.Parse(typeof(KalturaCielo24Fidelity), txt);
						continue;
					case "username":
						this._Username = txt;
						continue;
					case "password":
						this._Password = txt;
						continue;
					case "baseUrl":
						this._BaseUrl = txt;
						continue;
					case "spokenLanguage":
						this._SpokenLanguage = (KalturaLanguage)KalturaStringEnum.Parse(typeof(KalturaLanguage), txt);
						continue;
					case "replaceMediaContent":
						this._ReplaceMediaContent = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCielo24JobProviderData");
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("captionAssetFormats", this._CaptionAssetFormats);
			kparams.AddIfNotNull("priority", this._Priority);
			kparams.AddIfNotNull("fidelity", this._Fidelity);
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("baseUrl", this._BaseUrl);
			kparams.AddIfNotNull("spokenLanguage", this._SpokenLanguage);
			kparams.AddIfNotNull("replaceMediaContent", this._ReplaceMediaContent);
			return kparams;
		}
		#endregion
	}
}

