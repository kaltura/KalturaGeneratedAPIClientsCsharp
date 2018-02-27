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
		private float _ContentAwareness = Single.MinValue;
		private int _ChunkedEncodeMode = Int32.MinValue;
		private NullableBoolean _TwoPass = (NullableBoolean)Int32.MinValue;
		private string _Tags = null;
		#endregion

		#region Properties
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
		}
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
		}
		public FlavorReadyBehaviorType ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		public AssetParamsOrigin Origin
		{
			get { return _Origin; }
			set 
			{ 
				_Origin = value;
				OnPropertyChanged("Origin");
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
		public NullableBoolean ForceNoneComplied
		{
			get { return _ForceNoneComplied; }
			set 
			{ 
				_ForceNoneComplied = value;
				OnPropertyChanged("ForceNoneComplied");
			}
		}
		public AssetParamsDeletePolicy DeletePolicy
		{
			get { return _DeletePolicy; }
			set 
			{ 
				_DeletePolicy = value;
				OnPropertyChanged("DeletePolicy");
			}
		}
		public NullableBoolean IsEncrypted
		{
			get { return _IsEncrypted; }
			set 
			{ 
				_IsEncrypted = value;
				OnPropertyChanged("IsEncrypted");
			}
		}
		public float ContentAwareness
		{
			get { return _ContentAwareness; }
			set 
			{ 
				_ContentAwareness = value;
				OnPropertyChanged("ContentAwareness");
			}
		}
		public int ChunkedEncodeMode
		{
			get { return _ChunkedEncodeMode; }
			set 
			{ 
				_ChunkedEncodeMode = value;
				OnPropertyChanged("ChunkedEncodeMode");
			}
		}
		public NullableBoolean TwoPass
		{
			get { return _TwoPass; }
			set 
			{ 
				_TwoPass = value;
				OnPropertyChanged("TwoPass");
			}
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		#endregion

		#region CTor
		public ConversionProfileAssetParams()
		{
		}

		public ConversionProfileAssetParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "conversionProfileId":
						this._ConversionProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "assetParamsId":
						this._AssetParamsId = ParseInt(propertyNode.InnerText);
						continue;
					case "readyBehavior":
						this._ReadyBehavior = (FlavorReadyBehaviorType)ParseEnum(typeof(FlavorReadyBehaviorType), propertyNode.InnerText);
						continue;
					case "origin":
						this._Origin = (AssetParamsOrigin)ParseEnum(typeof(AssetParamsOrigin), propertyNode.InnerText);
						continue;
					case "systemName":
						this._SystemName = propertyNode.InnerText;
						continue;
					case "forceNoneComplied":
						this._ForceNoneComplied = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "deletePolicy":
						this._DeletePolicy = (AssetParamsDeletePolicy)ParseEnum(typeof(AssetParamsDeletePolicy), propertyNode.InnerText);
						continue;
					case "isEncrypted":
						this._IsEncrypted = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "contentAwareness":
						this._ContentAwareness = ParseFloat(propertyNode.InnerText);
						continue;
					case "chunkedEncodeMode":
						this._ChunkedEncodeMode = ParseInt(propertyNode.InnerText);
						continue;
					case "twoPass":
						this._TwoPass = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

