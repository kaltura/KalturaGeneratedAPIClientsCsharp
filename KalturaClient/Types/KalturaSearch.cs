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
	public class KalturaSearch : KalturaObjectBase
	{
		#region Private Fields
		private string _KeyWords = null;
		private KalturaSearchProviderType _SearchSource = (KalturaSearchProviderType)Int32.MinValue;
		private KalturaMediaType _MediaType = (KalturaMediaType)Int32.MinValue;
		private string _ExtraData = null;
		private string _AuthData = null;
		#endregion

		#region Properties
		public string KeyWords
		{
			get { return _KeyWords; }
			set 
			{ 
				_KeyWords = value;
				OnPropertyChanged("KeyWords");
			}
		}
		public KalturaSearchProviderType SearchSource
		{
			get { return _SearchSource; }
			set 
			{ 
				_SearchSource = value;
				OnPropertyChanged("SearchSource");
			}
		}
		public KalturaMediaType MediaType
		{
			get { return _MediaType; }
			set 
			{ 
				_MediaType = value;
				OnPropertyChanged("MediaType");
			}
		}
		public string ExtraData
		{
			get { return _ExtraData; }
			set 
			{ 
				_ExtraData = value;
				OnPropertyChanged("ExtraData");
			}
		}
		public string AuthData
		{
			get { return _AuthData; }
			set 
			{ 
				_AuthData = value;
				OnPropertyChanged("AuthData");
			}
		}
		#endregion

		#region CTor
		public KalturaSearch()
		{
		}

		public KalturaSearch(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "keyWords":
						this.KeyWords = txt;
						continue;
					case "searchSource":
						this.SearchSource = (KalturaSearchProviderType)ParseEnum(typeof(KalturaSearchProviderType), txt);
						continue;
					case "mediaType":
						this.MediaType = (KalturaMediaType)ParseEnum(typeof(KalturaMediaType), txt);
						continue;
					case "extraData":
						this.ExtraData = txt;
						continue;
					case "authData":
						this.AuthData = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSearch");
			kparams.AddIfNotNull("keyWords", this.KeyWords);
			kparams.AddIfNotNull("searchSource", this.SearchSource);
			kparams.AddIfNotNull("mediaType", this.MediaType);
			kparams.AddIfNotNull("extraData", this.ExtraData);
			kparams.AddIfNotNull("authData", this.AuthData);
			return kparams;
		}
		#endregion
	}
}

