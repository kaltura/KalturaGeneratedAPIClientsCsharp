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
	public class UploadToken : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string USER_ID = "userId";
		public const string STATUS = "status";
		public const string FILE_NAME = "fileName";
		public const string FILE_SIZE = "fileSize";
		public const string UPLOADED_FILE_SIZE = "uploadedFileSize";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string UPLOAD_URL = "uploadUrl";
		public const string AUTO_FINALIZE = "autoFinalize";
		#endregion

		#region Private Fields
		private string _Id = null;
		private int _PartnerId = Int32.MinValue;
		private string _UserId = null;
		private UploadTokenStatus _Status = (UploadTokenStatus)Int32.MinValue;
		private string _FileName = null;
		private double _FileSize = Double.MinValue;
		private double _UploadedFileSize = Double.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _UploadUrl = null;
		private NullableBoolean _AutoFinalize = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Id
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
		/// Use UserIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserId
		{
			get { return _UserId; }
			private set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UploadTokenStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use FileNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileName
		{
			get { return _FileName; }
			set 
			{ 
				_FileName = value;
				OnPropertyChanged("FileName");
			}
		}
		/// <summary>
		/// Use FileSizeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		/// <summary>
		/// Use UploadedFileSizeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double UploadedFileSize
		{
			get { return _UploadedFileSize; }
			private set 
			{ 
				_UploadedFileSize = value;
				OnPropertyChanged("UploadedFileSize");
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
		/// Use UploadUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UploadUrl
		{
			get { return _UploadUrl; }
			private set 
			{ 
				_UploadUrl = value;
				OnPropertyChanged("UploadUrl");
			}
		}
		/// <summary>
		/// Use AutoFinalizeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean AutoFinalize
		{
			get { return _AutoFinalize; }
			set 
			{ 
				_AutoFinalize = value;
				OnPropertyChanged("AutoFinalize");
			}
		}
		#endregion

		#region CTor
		public UploadToken()
		{
		}

		public UploadToken(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (UploadTokenStatus)ParseEnum(typeof(UploadTokenStatus), node["status"].Value<string>());
			}
			if(node["fileName"] != null)
			{
				this._FileName = node["fileName"].Value<string>();
			}
			if(node["fileSize"] != null)
			{
				this._FileSize = ParseDouble(node["fileSize"].Value<string>());
			}
			if(node["uploadedFileSize"] != null)
			{
				this._UploadedFileSize = ParseDouble(node["uploadedFileSize"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["uploadUrl"] != null)
			{
				this._UploadUrl = node["uploadUrl"].Value<string>();
			}
			if(node["autoFinalize"] != null)
			{
				this._AutoFinalize = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["autoFinalize"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUploadToken");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("fileName", this._FileName);
			kparams.AddIfNotNull("fileSize", this._FileSize);
			kparams.AddIfNotNull("uploadedFileSize", this._UploadedFileSize);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("uploadUrl", this._UploadUrl);
			kparams.AddIfNotNull("autoFinalize", this._AutoFinalize);
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
				case USER_ID:
					return "UserId";
				case STATUS:
					return "Status";
				case FILE_NAME:
					return "FileName";
				case FILE_SIZE:
					return "FileSize";
				case UPLOADED_FILE_SIZE:
					return "UploadedFileSize";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case UPLOAD_URL:
					return "UploadUrl";
				case AUTO_FINALIZE:
					return "AutoFinalize";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

