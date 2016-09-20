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
	public class KalturaUploadToken : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private int _PartnerId = Int32.MinValue;
		private string _UserId = null;
		private KalturaUploadTokenStatus _Status = (KalturaUploadTokenStatus)Int32.MinValue;
		private string _FileName = null;
		private float _FileSize = Single.MinValue;
		private float _UploadedFileSize = Single.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
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
		public KalturaUploadTokenStatus Status
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
		#endregion

		#region CTor
		public KalturaUploadToken()
		{
		}

		public KalturaUploadToken(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = txt;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "userId":
						this._UserId = txt;
						continue;
					case "status":
						this._Status = (KalturaUploadTokenStatus)ParseEnum(typeof(KalturaUploadTokenStatus), txt);
						continue;
					case "fileName":
						this._FileName = txt;
						continue;
					case "fileSize":
						this._FileSize = ParseFloat(txt);
						continue;
					case "uploadedFileSize":
						this._UploadedFileSize = ParseFloat(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUploadToken");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("userId", this.UserId);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("fileName", this.FileName);
			kparams.AddIfNotNull("fileSize", this.FileSize);
			kparams.AddIfNotNull("uploadedFileSize", this.UploadedFileSize);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			return kparams;
		}
		#endregion
	}
}

