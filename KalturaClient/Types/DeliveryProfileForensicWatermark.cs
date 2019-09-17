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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class DeliveryProfileForensicWatermark : DeliveryProfile
	{
		#region Constants
		public const string INTERNAL_URL = "internalUrl";
		public const string ENCRYPTION_KEY = "encryptionKey";
		public const string ENCRYPTION_IV = "encryptionIv";
		public const string ENCRYPTION_REGEX = "encryptionRegex";
		#endregion

		#region Private Fields
		private IList<KeyValue> _InternalUrl;
		private string _EncryptionKey = null;
		private string _EncryptionIv = null;
		private string _EncryptionRegex = null;
		#endregion

		#region Properties
		[JsonProperty]
		public IList<KeyValue> InternalUrl
		{
			get { return _InternalUrl; }
			set 
			{ 
				_InternalUrl = value;
				OnPropertyChanged("InternalUrl");
			}
		}
		[JsonProperty]
		public string EncryptionKey
		{
			get { return _EncryptionKey; }
			set 
			{ 
				_EncryptionKey = value;
				OnPropertyChanged("EncryptionKey");
			}
		}
		[JsonProperty]
		public string EncryptionIv
		{
			get { return _EncryptionIv; }
			set 
			{ 
				_EncryptionIv = value;
				OnPropertyChanged("EncryptionIv");
			}
		}
		[JsonProperty]
		public string EncryptionRegex
		{
			get { return _EncryptionRegex; }
			set 
			{ 
				_EncryptionRegex = value;
				OnPropertyChanged("EncryptionRegex");
			}
		}
		#endregion

		#region CTor
		public DeliveryProfileForensicWatermark()
		{
		}

		public DeliveryProfileForensicWatermark(JToken node) : base(node)
		{
			if(node["internalUrl"] != null)
			{
				this._InternalUrl = new List<KeyValue>();
				foreach(var arrayNode in node["internalUrl"].Children())
				{
					this._InternalUrl.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["encryptionKey"] != null)
			{
				this._EncryptionKey = node["encryptionKey"].Value<string>();
			}
			if(node["encryptionIv"] != null)
			{
				this._EncryptionIv = node["encryptionIv"].Value<string>();
			}
			if(node["encryptionRegex"] != null)
			{
				this._EncryptionRegex = node["encryptionRegex"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDeliveryProfileForensicWatermark");
			kparams.AddIfNotNull("internalUrl", this._InternalUrl);
			kparams.AddIfNotNull("encryptionKey", this._EncryptionKey);
			kparams.AddIfNotNull("encryptionIv", this._EncryptionIv);
			kparams.AddIfNotNull("encryptionRegex", this._EncryptionRegex);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case INTERNAL_URL:
					return "InternalUrl";
				case ENCRYPTION_KEY:
					return "EncryptionKey";
				case ENCRYPTION_IV:
					return "EncryptionIv";
				case ENCRYPTION_REGEX:
					return "EncryptionRegex";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

