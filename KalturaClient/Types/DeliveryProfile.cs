// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		/// <summary>
		/// Use TypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DeliveryProfileType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		/// <summary>
		/// Use SystemNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		/// <summary>
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		/// <summary>
		/// Use StreamerTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PlaybackProtocol StreamerType
		{
			get { return _StreamerType; }
			set 
			{ 
				_StreamerType = value;
				OnPropertyChanged("StreamerType");
			}
		}
		/// <summary>
		/// Use UrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		/// <summary>
		/// Use HostNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string HostName
		{
			get { return _HostName; }
			private set 
			{ 
				_HostName = value;
				OnPropertyChanged("HostName");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DeliveryStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use RecognizerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UrlRecognizer Recognizer
		{
			get { return _Recognizer; }
			set 
			{ 
				_Recognizer = value;
				OnPropertyChanged("Recognizer");
			}
		}
		/// <summary>
		/// Use TokenizerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UrlTokenizer Tokenizer
		{
			get { return _Tokenizer; }
			set 
			{ 
				_Tokenizer = value;
				OnPropertyChanged("Tokenizer");
			}
		}
		/// <summary>
		/// Use IsDefaultAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean IsDefault
		{
			get { return _IsDefault; }
			private set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		/// <summary>
		/// Use ParentIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ParentId
		{
			get { return _ParentId; }
			private set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		/// <summary>
		/// Use MediaProtocolsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MediaProtocols
		{
			get { return _MediaProtocols; }
			set 
			{ 
				_MediaProtocols = value;
				OnPropertyChanged("MediaProtocols");
			}
		}
		/// <summary>
		/// Use PriorityAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		/// <summary>
		/// Use ExtraParamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExtraParams
		{
			get { return _ExtraParams; }
			set 
			{ 
				_ExtraParams = value;
				OnPropertyChanged("ExtraParams");
			}
		}
		/// <summary>
		/// Use SupplementaryAssetsFilterAsDouble property instead
		/// </summary>
		[JsonProperty]
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

		public DeliveryProfile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["type"] != null)
			{
				this._Type = (DeliveryProfileType)StringEnum.Parse(typeof(DeliveryProfileType), node["type"].Value<string>());
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["streamerType"] != null)
			{
				this._StreamerType = (PlaybackProtocol)StringEnum.Parse(typeof(PlaybackProtocol), node["streamerType"].Value<string>());
			}
			if(node["url"] != null)
			{
				this._Url = node["url"].Value<string>();
			}
			if(node["hostName"] != null)
			{
				this._HostName = node["hostName"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (DeliveryStatus)ParseEnum(typeof(DeliveryStatus), node["status"].Value<string>());
			}
			if(node["recognizer"] != null)
			{
				this._Recognizer = ObjectFactory.Create<UrlRecognizer>(node["recognizer"]);
			}
			if(node["tokenizer"] != null)
			{
				this._Tokenizer = ObjectFactory.Create<UrlTokenizer>(node["tokenizer"]);
			}
			if(node["isDefault"] != null)
			{
				this._IsDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isDefault"].Value<string>());
			}
			if(node["parentId"] != null)
			{
				this._ParentId = ParseInt(node["parentId"].Value<string>());
			}
			if(node["mediaProtocols"] != null)
			{
				this._MediaProtocols = node["mediaProtocols"].Value<string>();
			}
			if(node["priority"] != null)
			{
				this._Priority = ParseInt(node["priority"].Value<string>());
			}
			if(node["extraParams"] != null)
			{
				this._ExtraParams = node["extraParams"].Value<string>();
			}
			if(node["supplementaryAssetsFilter"] != null)
			{
				this._SupplementaryAssetsFilter = ObjectFactory.Create<AssetFilter>(node["supplementaryAssetsFilter"]);
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

