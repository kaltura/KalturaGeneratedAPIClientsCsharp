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
		private float _FileSize = Single.MinValue;
		private float _UploadedFileSize = Single.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _UploadUrl = null;
		private NullableBoolean _AutoFinalize = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public string UserId
		{
			get { return _UserId; }
		}
		public UploadTokenStatus Status
		{
			get { return _Status; }
		}
		public string FileName
		{
			get { return _FileName; }
			set 
			{ 
				_FileName = value;
				OnPropertyChanged("FileName");
			}
		}
		public float FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		public float UploadedFileSize
		{
			get { return _UploadedFileSize; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public string UploadUrl
		{
			get { return _UploadUrl; }
		}
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

		public UploadToken(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (UploadTokenStatus)ParseEnum(typeof(UploadTokenStatus), propertyNode.InnerText);
						continue;
					case "fileName":
						this._FileName = propertyNode.InnerText;
						continue;
					case "fileSize":
						this._FileSize = ParseFloat(propertyNode.InnerText);
						continue;
					case "uploadedFileSize":
						this._UploadedFileSize = ParseFloat(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "uploadUrl":
						this._UploadUrl = propertyNode.InnerText;
						continue;
					case "autoFinalize":
						this._AutoFinalize = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
				}
			}
		}

		public UploadToken(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<string>("id");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._UserId = data.TryGetValueSafe<string>("userId");
			    this._Status = (UploadTokenStatus)ParseEnum(typeof(UploadTokenStatus), data.TryGetValueSafe<int>("status"));
			    this._FileName = data.TryGetValueSafe<string>("fileName");
			    this._FileSize = data.TryGetValueSafe<float>("fileSize");
			    this._UploadedFileSize = data.TryGetValueSafe<float>("uploadedFileSize");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._UploadUrl = data.TryGetValueSafe<string>("uploadUrl");
			    this._AutoFinalize = (NullableBoolean)ParseEnum(typeof(NullableBoolean), data.TryGetValueSafe<int>("autoFinalize"));
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

