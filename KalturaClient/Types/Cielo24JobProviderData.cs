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
	public class Cielo24JobProviderData : IntegrationJobProviderData
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string CAPTION_ASSET_FORMATS = "captionAssetFormats";
		public const string PRIORITY = "priority";
		public const string FIDELITY = "fidelity";
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		public const string BASE_URL = "baseUrl";
		public const string SPOKEN_LANGUAGE = "spokenLanguage";
		public const string REPLACE_MEDIA_CONTENT = "replaceMediaContent";
		#endregion

		#region Private Fields
		private string _EntryId = null;
		private string _FlavorAssetId = null;
		private string _CaptionAssetFormats = null;
		private Cielo24Priority _Priority = null;
		private Cielo24Fidelity _Fidelity = null;
		private string _Username = null;
		private string _Password = null;
		private string _BaseUrl = null;
		private Language _SpokenLanguage = null;
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
		public Cielo24Priority Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		public Cielo24Fidelity Fidelity
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
		public Language SpokenLanguage
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
		public Cielo24JobProviderData()
		{
		}

		public Cielo24JobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "flavorAssetId":
						this._FlavorAssetId = propertyNode.InnerText;
						continue;
					case "captionAssetFormats":
						this._CaptionAssetFormats = propertyNode.InnerText;
						continue;
					case "priority":
						this._Priority = (Cielo24Priority)StringEnum.Parse(typeof(Cielo24Priority), propertyNode.InnerText);
						continue;
					case "fidelity":
						this._Fidelity = (Cielo24Fidelity)StringEnum.Parse(typeof(Cielo24Fidelity), propertyNode.InnerText);
						continue;
					case "username":
						this._Username = propertyNode.InnerText;
						continue;
					case "password":
						this._Password = propertyNode.InnerText;
						continue;
					case "baseUrl":
						this._BaseUrl = propertyNode.InnerText;
						continue;
					case "spokenLanguage":
						this._SpokenLanguage = (Language)StringEnum.Parse(typeof(Language), propertyNode.InnerText);
						continue;
					case "replaceMediaContent":
						this._ReplaceMediaContent = ParseBool(propertyNode.InnerText);
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
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID:
					return "EntryId";
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case CAPTION_ASSET_FORMATS:
					return "CaptionAssetFormats";
				case PRIORITY:
					return "Priority";
				case FIDELITY:
					return "Fidelity";
				case USERNAME:
					return "Username";
				case PASSWORD:
					return "Password";
				case BASE_URL:
					return "BaseUrl";
				case SPOKEN_LANGUAGE:
					return "SpokenLanguage";
				case REPLACE_MEDIA_CONTENT:
					return "ReplaceMediaContent";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

