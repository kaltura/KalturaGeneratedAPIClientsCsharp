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
		public const string TWO_PASS = "twoPass";
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
		private NullableBoolean _TwoPass = (NullableBoolean)Int32.MinValue;
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
		public NullableBoolean TwoPass
		{
			get { return _TwoPass; }
			set 
			{ 
				_TwoPass = value;
				OnPropertyChanged("TwoPass");
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
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "conversionProfileId":
						this._ConversionProfileId = ParseInt(txt);
						continue;
					case "assetParamsId":
						this._AssetParamsId = ParseInt(txt);
						continue;
					case "readyBehavior":
						this._ReadyBehavior = (FlavorReadyBehaviorType)ParseEnum(typeof(FlavorReadyBehaviorType), txt);
						continue;
					case "origin":
						this._Origin = (AssetParamsOrigin)ParseEnum(typeof(AssetParamsOrigin), txt);
						continue;
					case "systemName":
						this._SystemName = txt;
						continue;
					case "forceNoneComplied":
						this._ForceNoneComplied = (NullableBoolean)ParseEnum(typeof(NullableBoolean), txt);
						continue;
					case "deletePolicy":
						this._DeletePolicy = (AssetParamsDeletePolicy)ParseEnum(typeof(AssetParamsDeletePolicy), txt);
						continue;
					case "isEncrypted":
						this._IsEncrypted = (NullableBoolean)ParseEnum(typeof(NullableBoolean), txt);
						continue;
					case "contentAwareness":
						this._ContentAwareness = ParseFloat(txt);
						continue;
					case "twoPass":
						this._TwoPass = (NullableBoolean)ParseEnum(typeof(NullableBoolean), txt);
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
			kparams.AddIfNotNull("twoPass", this._TwoPass);
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
				case TWO_PASS:
					return "TwoPass";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}
