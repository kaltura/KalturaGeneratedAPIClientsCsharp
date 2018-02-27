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
	public class DeliveryProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string TYPE = "type";
		public const string SYSTEM_NAME = "systemName";
		public const string DESCRIPTION = "description";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string STREAMER_TYPE = "streamerType";
		public const string URL = "url";
		public const string HOST_NAME = "hostName";
		public const string STATUS = "status";
		public const string RECOGNIZER = "recognizer";
		public const string TOKENIZER = "tokenizer";
		public const string IS_DEFAULT = "isDefault";
		public const string PARENT_ID = "parentId";
		public const string MEDIA_PROTOCOLS = "mediaProtocols";
		public const string PRIORITY = "priority";
		public const string EXTRA_PARAMS = "extraParams";
		public const string SUPPLEMENTARY_ASSETS_FILTER = "supplementaryAssetsFilter";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private DeliveryProfileType _Type = null;
		private string _SystemName = null;
		private string _Description = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private PlaybackProtocol _StreamerType = null;
		private string _Url = null;
		private string _HostName = null;
		private DeliveryStatus _Status = (DeliveryStatus)Int32.MinValue;
		private UrlRecognizer _Recognizer;
		private UrlTokenizer _Tokenizer;
		private NullableBoolean _IsDefault = (NullableBoolean)Int32.MinValue;
		private int _ParentId = Int32.MinValue;
		private string _MediaProtocols = null;
		private int _Priority = Int32.MinValue;
		private string _ExtraParams = null;
		private AssetFilter _SupplementaryAssetsFilter;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public DeliveryProfileType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public PlaybackProtocol StreamerType
		{
			get { return _StreamerType; }
			set 
			{ 
				_StreamerType = value;
				OnPropertyChanged("StreamerType");
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
		public string HostName
		{
			get { return _HostName; }
		}
		public DeliveryStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public UrlRecognizer Recognizer
		{
			get { return _Recognizer; }
			set 
			{ 
				_Recognizer = value;
				OnPropertyChanged("Recognizer");
			}
		}
		public UrlTokenizer Tokenizer
		{
			get { return _Tokenizer; }
			set 
			{ 
				_Tokenizer = value;
				OnPropertyChanged("Tokenizer");
			}
		}
		public NullableBoolean IsDefault
		{
			get { return _IsDefault; }
		}
		public int ParentId
		{
			get { return _ParentId; }
		}
		public string MediaProtocols
		{
			get { return _MediaProtocols; }
			set 
			{ 
				_MediaProtocols = value;
				OnPropertyChanged("MediaProtocols");
			}
		}
		public int Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		public string ExtraParams
		{
			get { return _ExtraParams; }
			set 
			{ 
				_ExtraParams = value;
				OnPropertyChanged("ExtraParams");
			}
		}
		public AssetFilter SupplementaryAssetsFilter
		{
			get { return _SupplementaryAssetsFilter; }
			set 
			{ 
				_SupplementaryAssetsFilter = value;
				OnPropertyChanged("SupplementaryAssetsFilter");
			}
		}
		#endregion

		#region CTor
		public DeliveryProfile()
		{
		}

		public DeliveryProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "type":
						this._Type = (DeliveryProfileType)StringEnum.Parse(typeof(DeliveryProfileType), propertyNode.InnerText);
						continue;
					case "systemName":
						this._SystemName = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "streamerType":
						this._StreamerType = (PlaybackProtocol)StringEnum.Parse(typeof(PlaybackProtocol), propertyNode.InnerText);
						continue;
					case "url":
						this._Url = propertyNode.InnerText;
						continue;
					case "hostName":
						this._HostName = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (DeliveryStatus)ParseEnum(typeof(DeliveryStatus), propertyNode.InnerText);
						continue;
					case "recognizer":
						this._Recognizer = ObjectFactory.Create<UrlRecognizer>(propertyNode);
						continue;
					case "tokenizer":
						this._Tokenizer = ObjectFactory.Create<UrlTokenizer>(propertyNode);
						continue;
					case "isDefault":
						this._IsDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "parentId":
						this._ParentId = ParseInt(propertyNode.InnerText);
						continue;
					case "mediaProtocols":
						this._MediaProtocols = propertyNode.InnerText;
						continue;
					case "priority":
						this._Priority = ParseInt(propertyNode.InnerText);
						continue;
					case "extraParams":
						this._ExtraParams = propertyNode.InnerText;
						continue;
					case "supplementaryAssetsFilter":
						this._SupplementaryAssetsFilter = ObjectFactory.Create<AssetFilter>(propertyNode);
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
				kparams.AddReplace("objectType", "KalturaDeliveryProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("streamerType", this._StreamerType);
			kparams.AddIfNotNull("url", this._Url);
			kparams.AddIfNotNull("hostName", this._HostName);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("recognizer", this._Recognizer);
			kparams.AddIfNotNull("tokenizer", this._Tokenizer);
			kparams.AddIfNotNull("isDefault", this._IsDefault);
			kparams.AddIfNotNull("parentId", this._ParentId);
			kparams.AddIfNotNull("mediaProtocols", this._MediaProtocols);
			kparams.AddIfNotNull("priority", this._Priority);
			kparams.AddIfNotNull("extraParams", this._ExtraParams);
			kparams.AddIfNotNull("supplementaryAssetsFilter", this._SupplementaryAssetsFilter);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case NAME:
					return "Name";
				case TYPE:
					return "Type";
				case SYSTEM_NAME:
					return "SystemName";
				case DESCRIPTION:
					return "Description";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case STREAMER_TYPE:
					return "StreamerType";
				case URL:
					return "Url";
				case HOST_NAME:
					return "HostName";
				case STATUS:
					return "Status";
				case RECOGNIZER:
					return "Recognizer";
				case TOKENIZER:
					return "Tokenizer";
				case IS_DEFAULT:
					return "IsDefault";
				case PARENT_ID:
					return "ParentId";
				case MEDIA_PROTOCOLS:
					return "MediaProtocols";
				case PRIORITY:
					return "Priority";
				case EXTRA_PARAMS:
					return "ExtraParams";
				case SUPPLEMENTARY_ASSETS_FILTER:
					return "SupplementaryAssetsFilter";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

