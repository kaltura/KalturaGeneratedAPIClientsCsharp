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
	public class UploadResponse : ObjectBase
	{
		#region Constants
		public const string UPLOAD_TOKEN_ID = "uploadTokenId";
		public const string FILE_SIZE = "fileSize";
		public const string ERROR_CODE = "errorCode";
		public const string ERROR_DESCRIPTION = "errorDescription";
		#endregion

		#region Private Fields
		private string _UploadTokenId = null;
		private int _FileSize = Int32.MinValue;
		private UploadErrorCode _ErrorCode = (UploadErrorCode)Int32.MinValue;
		private string _ErrorDescription = null;
		#endregion

		#region Properties
		public string UploadTokenId
		{
			get { return _UploadTokenId; }
			set 
			{ 
				_UploadTokenId = value;
				OnPropertyChanged("UploadTokenId");
			}
		}
		public int FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		public UploadErrorCode ErrorCode
		{
			get { return _ErrorCode; }
			set 
			{ 
				_ErrorCode = value;
				OnPropertyChanged("ErrorCode");
			}
		}
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		#endregion

		#region CTor
		public UploadResponse()
		{
		}

		public UploadResponse(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "uploadTokenId":
						this._UploadTokenId = propertyNode.InnerText;
						continue;
					case "fileSize":
						this._FileSize = ParseInt(propertyNode.InnerText);
						continue;
					case "errorCode":
						this._ErrorCode = (UploadErrorCode)ParseEnum(typeof(UploadErrorCode), propertyNode.InnerText);
						continue;
					case "errorDescription":
						this._ErrorDescription = propertyNode.InnerText;
						continue;
				}
			}
		}

		public UploadResponse(IDictionary<string,object> data) : base(data)
		{
			    this._UploadTokenId = data.TryGetValueSafe<string>("uploadTokenId");
			    this._FileSize = data.TryGetValueSafe<int>("fileSize");
			    this._ErrorCode = (UploadErrorCode)ParseEnum(typeof(UploadErrorCode), data.TryGetValueSafe<int>("errorCode"));
			    this._ErrorDescription = data.TryGetValueSafe<string>("errorDescription");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUploadResponse");
			kparams.AddIfNotNull("uploadTokenId", this._UploadTokenId);
			kparams.AddIfNotNull("fileSize", this._FileSize);
			kparams.AddIfNotNull("errorCode", this._ErrorCode);
			kparams.AddIfNotNull("errorDescription", this._ErrorDescription);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case UPLOAD_TOKEN_ID:
					return "UploadTokenId";
				case FILE_SIZE:
					return "FileSize";
				case ERROR_CODE:
					return "ErrorCode";
				case ERROR_DESCRIPTION:
					return "ErrorDescription";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

