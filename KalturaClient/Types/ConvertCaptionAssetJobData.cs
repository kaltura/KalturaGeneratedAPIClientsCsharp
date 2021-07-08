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
	public class ConvertCaptionAssetJobData : JobData
	{
		#region Constants
		public const string CAPTION_ASSET_ID = "captionAssetId";
		public const string FILE_LOCATION = "fileLocation";
		public const string FILE_ENCRYPTION_KEY = "fileEncryptionKey";
		public const string FROM_TYPE = "fromType";
		public const string TO_TYPE = "toType";
		#endregion

		#region Private Fields
		private string _CaptionAssetId = null;
		private string _FileLocation = null;
		private string _FileEncryptionKey = null;
		private string _FromType = null;
		private string _ToType = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use CaptionAssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CaptionAssetId
		{
			get { return _CaptionAssetId; }
			set 
			{ 
				_CaptionAssetId = value;
				OnPropertyChanged("CaptionAssetId");
			}
		}
		/// <summary>
		/// Use FileLocationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileLocation
		{
			get { return _FileLocation; }
			set 
			{ 
				_FileLocation = value;
				OnPropertyChanged("FileLocation");
			}
		}
		/// <summary>
		/// Use FileEncryptionKeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileEncryptionKey
		{
			get { return _FileEncryptionKey; }
			set 
			{ 
				_FileEncryptionKey = value;
				OnPropertyChanged("FileEncryptionKey");
			}
		}
		/// <summary>
		/// Use FromTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FromType
		{
			get { return _FromType; }
			set 
			{ 
				_FromType = value;
				OnPropertyChanged("FromType");
			}
		}
		/// <summary>
		/// Use ToTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ToType
		{
			get { return _ToType; }
			set 
			{ 
				_ToType = value;
				OnPropertyChanged("ToType");
			}
		}
		#endregion

		#region CTor
		public ConvertCaptionAssetJobData()
		{
		}

		public ConvertCaptionAssetJobData(JToken node) : base(node)
		{
			if(node["captionAssetId"] != null)
			{
				this._CaptionAssetId = node["captionAssetId"].Value<string>();
			}
			if(node["fileLocation"] != null)
			{
				this._FileLocation = node["fileLocation"].Value<string>();
			}
			if(node["fileEncryptionKey"] != null)
			{
				this._FileEncryptionKey = node["fileEncryptionKey"].Value<string>();
			}
			if(node["fromType"] != null)
			{
				this._FromType = node["fromType"].Value<string>();
			}
			if(node["toType"] != null)
			{
				this._ToType = node["toType"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConvertCaptionAssetJobData");
			kparams.AddIfNotNull("captionAssetId", this._CaptionAssetId);
			kparams.AddIfNotNull("fileLocation", this._FileLocation);
			kparams.AddIfNotNull("fileEncryptionKey", this._FileEncryptionKey);
			kparams.AddIfNotNull("fromType", this._FromType);
			kparams.AddIfNotNull("toType", this._ToType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CAPTION_ASSET_ID:
					return "CaptionAssetId";
				case FILE_LOCATION:
					return "FileLocation";
				case FILE_ENCRYPTION_KEY:
					return "FileEncryptionKey";
				case FROM_TYPE:
					return "FromType";
				case TO_TYPE:
					return "ToType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

