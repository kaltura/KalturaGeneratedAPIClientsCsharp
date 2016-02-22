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
		private KalturaLanguage _SpokenLanguage = null;
		private bool? _ReplaceMediaContent = false;
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
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
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
						this.EntryId = txt;
						continue;
					case "flavorAssetId":
						this.FlavorAssetId = txt;
						continue;
					case "captionAssetFormats":
						this.CaptionAssetFormats = txt;
						continue;
					case "priority":
						this.Priority = (KalturaCielo24Priority)KalturaStringEnum.Parse(typeof(KalturaCielo24Priority), txt);
						continue;
					case "fidelity":
						this.Fidelity = (KalturaCielo24Fidelity)KalturaStringEnum.Parse(typeof(KalturaCielo24Fidelity), txt);
						continue;
					case "username":
						this.Username = txt;
						continue;
					case "password":
						this.Password = txt;
						continue;
					case "spokenLanguage":
						this.SpokenLanguage = (KalturaLanguage)KalturaStringEnum.Parse(typeof(KalturaLanguage), txt);
						continue;
					case "replaceMediaContent":
						this.ReplaceMediaContent = ParseBool(txt);
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
			kparams.AddIfNotNull("entryId", this.EntryId);
			kparams.AddIfNotNull("flavorAssetId", this.FlavorAssetId);
			kparams.AddIfNotNull("captionAssetFormats", this.CaptionAssetFormats);
			kparams.AddIfNotNull("priority", this.Priority);
			kparams.AddIfNotNull("fidelity", this.Fidelity);
			kparams.AddIfNotNull("username", this.Username);
			kparams.AddIfNotNull("password", this.Password);
			kparams.AddIfNotNull("spokenLanguage", this.SpokenLanguage);
			kparams.AddIfNotNull("replaceMediaContent", this.ReplaceMediaContent);
			return kparams;
		}
		#endregion
	}
}

