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
	public class ConversionProfileAssetParams : ObjectBase
	{
		#region Constants
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string ASSET_PARAMS_ID = "assetParamsId";
		public const string READY_BEHAVIOR = "readyBehavior";
		public const string ORIGIN = "origin";
		public const string SYSTEM_NAME = "systemName";
		public const string FORCE_NONE_COMPLIED = "forceNoneComplied";
		public const string DELETE_POLICY = "deletePolicy";
		public const string IS_ENCRYPTED = "isEncrypted";
		public const string CONTENT_AWARENESS = "contentAwareness";
		public const string CHUNKED_ENCODE_MODE = "chunkedEncodeMode";
		public const string TWO_PASS = "twoPass";
		public const string TAGS = "tags";
		public const string OVERLOAD_PARAMS = "overloadParams";
		#endregion

		#region Private Fields
		private int _ConversionProfileId = Int32.MinValue;
		private int _AssetParamsId = Int32.MinValue;
		private FlavorReadyBehaviorType _ReadyBehavior = (FlavorReadyBehaviorType)Int32.MinValue;
		private AssetParamsOrigin _Origin = (AssetParamsOrigin)Int32.MinValue;
		private string _SystemName = null;
		private NullableBoolean _ForceNoneComplied = (NullableBoolean)Int32.MinValue;
		private AssetParamsDeletePolicy _DeletePolicy = (AssetParamsDeletePolicy)Int32.MinValue;
		private NullableBoolean _IsEncrypted = (NullableBoolean)Int32.MinValue;
		private double _ContentAwareness = Double.MinValue;
		private int _ChunkedEncodeMode = Int32.MinValue;
		private NullableBoolean _TwoPass = (NullableBoolean)Int32.MinValue;
		private string _Tags = null;
		private string _OverloadParams = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ConversionProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			private set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		/// <summary>
		/// Use AssetParamsIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
			private set 
			{ 
				_AssetParamsId = value;
				OnPropertyChanged("AssetParamsId");
			}
		}
		/// <summary>
		/// Use ReadyBehaviorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FlavorReadyBehaviorType ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		/// <summary>
		/// Use OriginAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AssetParamsOrigin Origin
		{
			get { return _Origin; }
			set 
			{ 
				_Origin = value;
				OnPropertyChanged("Origin");
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
		/// Use ForceNoneCompliedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean ForceNoneComplied
		{
			get { return _ForceNoneComplied; }
			set 
			{ 
				_ForceNoneComplied = value;
				OnPropertyChanged("ForceNoneComplied");
			}
		}
		/// <summary>
		/// Use DeletePolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AssetParamsDeletePolicy DeletePolicy
		{
			get { return _DeletePolicy; }
			set 
			{ 
				_DeletePolicy = value;
				OnPropertyChanged("DeletePolicy");
			}
		}
		/// <summary>
		/// Use IsEncryptedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean IsEncrypted
		{
			get { return _IsEncrypted; }
			set 
			{ 
				_IsEncrypted = value;
				OnPropertyChanged("IsEncrypted");
			}
		}
		/// <summary>
		/// Use ContentAwarenessAsDouble property instead
		/// </summary>
		[JsonProperty]
		[Obsolete("Use ContentAwarenessAsDouble property instead")]
		public float ContentAwareness
		{
			get { return (float)_ContentAwareness; }
			set 
			{ 
				_ContentAwareness = value;
				OnPropertyChanged("ContentAwareness");
			}
		}
		///<summary>
		///Use this property ContentAwarenessAsDouble instead of the float ContentAwareness property version
		///</summary>
		[JsonProperty]
		public double ContentAwarenessAsDouble
		{
			get { return _ContentAwareness; }
			set 
			{ 
				_ContentAwareness = value;
				OnPropertyChanged("ContentAwareness");
			}
		}
		/// <summary>
		/// Use ChunkedEncodeModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ChunkedEncodeMode
		{
			get { return _ChunkedEncodeMode; }
			set 
			{ 
				_ChunkedEncodeMode = value;
				OnPropertyChanged("ChunkedEncodeMode");
			}
		}
		/// <summary>
		/// Use TwoPassAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean TwoPass
		{
			get { return _TwoPass; }
			set 
			{ 
				_TwoPass = value;
				OnPropertyChanged("TwoPass");
			}
		}
		/// <summary>
		/// Use TagsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		/// <summary>
		/// Use OverloadParamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OverloadParams
		{
			get { return _OverloadParams; }
			set 
			{ 
				_OverloadParams = value;
				OnPropertyChanged("OverloadParams");
			}
		}
		#endregion

		#region CTor
		public ConversionProfileAssetParams()
		{
		}

		public ConversionProfileAssetParams(JToken node) : base(node)
		{
			if(node["conversionProfileId"] != null)
			{
				this._ConversionProfileId = ParseInt(node["conversionProfileId"].Value<string>());
			}
			if(node["assetParamsId"] != null)
			{
				this._AssetParamsId = ParseInt(node["assetParamsId"].Value<string>());
			}
			if(node["readyBehavior"] != null)
			{
				this._ReadyBehavior = (FlavorReadyBehaviorType)ParseEnum(typeof(FlavorReadyBehaviorType), node["readyBehavior"].Value<string>());
			}
			if(node["origin"] != null)
			{
				this._Origin = (AssetParamsOrigin)ParseEnum(typeof(AssetParamsOrigin), node["origin"].Value<string>());
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["forceNoneComplied"] != null)
			{
				this._ForceNoneComplied = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["forceNoneComplied"].Value<string>());
			}
			if(node["deletePolicy"] != null)
			{
				this._DeletePolicy = (AssetParamsDeletePolicy)ParseEnum(typeof(AssetParamsDeletePolicy), node["deletePolicy"].Value<string>());
			}
			if(node["isEncrypted"] != null)
			{
				this._IsEncrypted = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isEncrypted"].Value<string>());
			}
			if(node["contentAwareness"] != null)
			{
				this._ContentAwareness = ParseDouble(node["contentAwareness"].Value<string>());
			}
			if(node["chunkedEncodeMode"] != null)
			{
				this._ChunkedEncodeMode = ParseInt(node["chunkedEncodeMode"].Value<string>());
			}
			if(node["twoPass"] != null)
			{
				this._TwoPass = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["twoPass"].Value<string>());
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["overloadParams"] != null)
			{
				this._OverloadParams = node["overloadParams"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConversionProfileAssetParams");
			kparams.AddIfNotNull("conversionProfileId", this._ConversionProfileId);
			kparams.AddIfNotNull("assetParamsId", this._AssetParamsId);
			kparams.AddIfNotNull("readyBehavior", this._ReadyBehavior);
			kparams.AddIfNotNull("origin", this._Origin);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("forceNoneComplied", this._ForceNoneComplied);
			kparams.AddIfNotNull("deletePolicy", this._DeletePolicy);
			kparams.AddIfNotNull("isEncrypted", this._IsEncrypted);
			kparams.AddIfNotNull("contentAwareness", this._ContentAwareness);
			kparams.AddIfNotNull("chunkedEncodeMode", this._ChunkedEncodeMode);
			kparams.AddIfNotNull("twoPass", this._TwoPass);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("overloadParams", this._OverloadParams);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONVERSION_PROFILE_ID:
					return "ConversionProfileId";
				case ASSET_PARAMS_ID:
					return "AssetParamsId";
				case READY_BEHAVIOR:
					return "ReadyBehavior";
				case ORIGIN:
					return "Origin";
				case SYSTEM_NAME:
					return "SystemName";
				case FORCE_NONE_COMPLIED:
					return "ForceNoneComplied";
				case DELETE_POLICY:
					return "DeletePolicy";
				case IS_ENCRYPTED:
					return "IsEncrypted";
				case CONTENT_AWARENESS:
					return "ContentAwareness";
				case CHUNKED_ENCODE_MODE:
					return "ChunkedEncodeMode";
				case TWO_PASS:
					return "TwoPass";
				case TAGS:
					return "Tags";
				case OVERLOAD_PARAMS:
					return "OverloadParams";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

