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
	public class Search : ObjectBase
	{
		#region Constants
		public const string KEY_WORDS = "keyWords";
		public const string SEARCH_SOURCE = "searchSource";
		public const string MEDIA_TYPE = "mediaType";
		public const string EXTRA_DATA = "extraData";
		public const string AUTH_DATA = "authData";
		#endregion

		#region Private Fields
		private string _KeyWords = null;
		private SearchProviderType _SearchSource = (SearchProviderType)Int32.MinValue;
		private MediaType _MediaType = (MediaType)Int32.MinValue;
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
		public SearchProviderType SearchSource
		{
			get { return _SearchSource; }
			set 
			{ 
				_SearchSource = value;
				OnPropertyChanged("SearchSource");
			}
		}
		public MediaType MediaType
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
		public Search()
		{
		}

		public Search(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "keyWords":
						this._KeyWords = propertyNode.InnerText;
						continue;
					case "searchSource":
						this._SearchSource = (SearchProviderType)ParseEnum(typeof(SearchProviderType), propertyNode.InnerText);
						continue;
					case "mediaType":
						this._MediaType = (MediaType)ParseEnum(typeof(MediaType), propertyNode.InnerText);
						continue;
					case "extraData":
						this._ExtraData = propertyNode.InnerText;
						continue;
					case "authData":
						this._AuthData = propertyNode.InnerText;
						continue;
				}
			}
		}

		public Search(IDictionary<string,object> data) : base(data)
		{
			    this._KeyWords = data.TryGetValueSafe<string>("keyWords");
			    this._SearchSource = (SearchProviderType)ParseEnum(typeof(SearchProviderType), data.TryGetValueSafe<int>("searchSource"));
			    this._MediaType = (MediaType)ParseEnum(typeof(MediaType), data.TryGetValueSafe<int>("mediaType"));
			    this._ExtraData = data.TryGetValueSafe<string>("extraData");
			    this._AuthData = data.TryGetValueSafe<string>("authData");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSearch");
			kparams.AddIfNotNull("keyWords", this._KeyWords);
			kparams.AddIfNotNull("searchSource", this._SearchSource);
			kparams.AddIfNotNull("mediaType", this._MediaType);
			kparams.AddIfNotNull("extraData", this._ExtraData);
			kparams.AddIfNotNull("authData", this._AuthData);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KEY_WORDS:
					return "KeyWords";
				case SEARCH_SOURCE:
					return "SearchSource";
				case MEDIA_TYPE:
					return "MediaType";
				case EXTRA_DATA:
					return "ExtraData";
				case AUTH_DATA:
					return "AuthData";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

