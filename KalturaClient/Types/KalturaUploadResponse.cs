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

namespace Kaltura
{
	public class KalturaUploadResponse : KalturaObjectBase
	{
		#region Private Fields
		private string _UploadTokenId = null;
		private int _FileSize = Int32.MinValue;
		private KalturaUploadErrorCode _ErrorCode = (KalturaUploadErrorCode)Int32.MinValue;
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
		public KalturaUploadErrorCode ErrorCode
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
		public KalturaUploadResponse()
		{
		}

		public KalturaUploadResponse(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "uploadTokenId":
						this.UploadTokenId = txt;
						continue;
					case "fileSize":
						this.FileSize = ParseInt(txt);
						continue;
					case "errorCode":
						this.ErrorCode = (KalturaUploadErrorCode)ParseEnum(typeof(KalturaUploadErrorCode), txt);
						continue;
					case "errorDescription":
						this.ErrorDescription = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUploadResponse");
			kparams.AddIfNotNull("uploadTokenId", this.UploadTokenId);
			kparams.AddIfNotNull("fileSize", this.FileSize);
			kparams.AddIfNotNull("errorCode", this.ErrorCode);
			kparams.AddIfNotNull("errorDescription", this.ErrorDescription);
			return kparams;
		}
		#endregion
	}
}

