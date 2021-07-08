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
	public class TranscriptAsset : AttachmentAsset
	{
		#region Constants
		public const string ACCURACY = "accuracy";
		public const string HUMAN_VERIFIED = "humanVerified";
		public const string LANGUAGE = "language";
		public const string PROVIDER_TYPE = "providerType";
		#endregion

		#region Private Fields
		private double _Accuracy = Double.MinValue;
		private NullableBoolean _HumanVerified = (NullableBoolean)Int32.MinValue;
		private Language _Language = null;
		private TranscriptProviderType _ProviderType = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use AccuracyAsDouble property instead
		/// </summary>
		[JsonProperty]
		[Obsolete("Use AccuracyAsDouble property instead")]
		public float Accuracy
		{
			get { return (float)_Accuracy; }
			set 
			{ 
				_Accuracy = value;
				OnPropertyChanged("Accuracy");
			}
		}
		///<summary>
		///Use this property AccuracyAsDouble instead of the float Accuracy property version
		///</summary>
		[JsonProperty]
		public double AccuracyAsDouble
		{
			get { return _Accuracy; }
			set 
			{ 
				_Accuracy = value;
				OnPropertyChanged("Accuracy");
			}
		}
		/// <summary>
		/// Use HumanVerifiedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean HumanVerified
		{
			get { return _HumanVerified; }
			set 
			{ 
				_HumanVerified = value;
				OnPropertyChanged("HumanVerified");
			}
		}
		/// <summary>
		/// Use LanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public Language Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		/// <summary>
		/// Use ProviderTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TranscriptProviderType ProviderType
		{
			get { return _ProviderType; }
			set 
			{ 
				_ProviderType = value;
				OnPropertyChanged("ProviderType");
			}
		}
		#endregion

		#region CTor
		public TranscriptAsset()
		{
		}

		public TranscriptAsset(JToken node) : base(node)
		{
			if(node["accuracy"] != null)
			{
				this._Accuracy = ParseDouble(node["accuracy"].Value<string>());
			}
			if(node["humanVerified"] != null)
			{
				this._HumanVerified = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["humanVerified"].Value<string>());
			}
			if(node["language"] != null)
			{
				this._Language = (Language)StringEnum.Parse(typeof(Language), node["language"].Value<string>());
			}
			if(node["providerType"] != null)
			{
				this._ProviderType = (TranscriptProviderType)StringEnum.Parse(typeof(TranscriptProviderType), node["providerType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTranscriptAsset");
			kparams.AddIfNotNull("accuracy", this._Accuracy);
			kparams.AddIfNotNull("humanVerified", this._HumanVerified);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("providerType", this._ProviderType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ACCURACY:
					return "Accuracy";
				case HUMAN_VERIFIED:
					return "HumanVerified";
				case LANGUAGE:
					return "Language";
				case PROVIDER_TYPE:
					return "ProviderType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

