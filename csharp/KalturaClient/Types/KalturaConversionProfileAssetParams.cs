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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaConversionProfileAssetParams : KalturaObjectBase
	{
		#region Private Fields
		private int _ConversionProfileId = Int32.MinValue;
		private int _AssetParamsId = Int32.MinValue;
		private KalturaFlavorReadyBehaviorType _ReadyBehavior = (KalturaFlavorReadyBehaviorType)Int32.MinValue;
		private KalturaAssetParamsOrigin _Origin = (KalturaAssetParamsOrigin)Int32.MinValue;
		private string _SystemName = null;
		private KalturaNullableBoolean _ForceNoneComplied = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaAssetParamsDeletePolicy _DeletePolicy = (KalturaAssetParamsDeletePolicy)Int32.MinValue;
		#endregion

		#region Properties
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
			set 
			{ 
				_AssetParamsId = value;
				OnPropertyChanged("AssetParamsId");
			}
		}
		public KalturaFlavorReadyBehaviorType ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		public KalturaAssetParamsOrigin Origin
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
		public KalturaNullableBoolean ForceNoneComplied
		{
			get { return _ForceNoneComplied; }
			set 
			{ 
				_ForceNoneComplied = value;
				OnPropertyChanged("ForceNoneComplied");
			}
		}
		public KalturaAssetParamsDeletePolicy DeletePolicy
		{
			get { return _DeletePolicy; }
			set 
			{ 
				_DeletePolicy = value;
				OnPropertyChanged("DeletePolicy");
			}
		}
		#endregion

		#region CTor
		public KalturaConversionProfileAssetParams()
		{
		}

		public KalturaConversionProfileAssetParams(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "conversionProfileId":
						this.ConversionProfileId = ParseInt(txt);
						continue;
					case "assetParamsId":
						this.AssetParamsId = ParseInt(txt);
						continue;
					case "readyBehavior":
						this.ReadyBehavior = (KalturaFlavorReadyBehaviorType)ParseEnum(typeof(KalturaFlavorReadyBehaviorType), txt);
						continue;
					case "origin":
						this.Origin = (KalturaAssetParamsOrigin)ParseEnum(typeof(KalturaAssetParamsOrigin), txt);
						continue;
					case "systemName":
						this.SystemName = txt;
						continue;
					case "forceNoneComplied":
						this.ForceNoneComplied = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "deletePolicy":
						this.DeletePolicy = (KalturaAssetParamsDeletePolicy)ParseEnum(typeof(KalturaAssetParamsDeletePolicy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConversionProfileAssetParams");
			kparams.AddIntIfNotNull("conversionProfileId", this.ConversionProfileId);
			kparams.AddIntIfNotNull("assetParamsId", this.AssetParamsId);
			kparams.AddEnumIfNotNull("readyBehavior", this.ReadyBehavior);
			kparams.AddEnumIfNotNull("origin", this.Origin);
			kparams.AddStringIfNotNull("systemName", this.SystemName);
			kparams.AddEnumIfNotNull("forceNoneComplied", this.ForceNoneComplied);
			kparams.AddEnumIfNotNull("deletePolicy", this.DeletePolicy);
			return kparams;
		}
		#endregion
	}
}

