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
	public class KalturaBulkUploadJobData : KalturaJobData
	{
		#region Private Fields
		private string _UserId = null;
		private string _UploadedBy = null;
		private int _ConversionProfileId = Int32.MinValue;
		private string _ResultsFileLocalPath = null;
		private string _ResultsFileUrl = null;
		private int _NumOfEntries = Int32.MinValue;
		private int _NumOfObjects = Int32.MinValue;
		private string _FilePath = null;
		private KalturaBulkUploadObjectType _BulkUploadObjectType = null;
		private string _FileName = null;
		private KalturaBulkUploadObjectData _ObjectData;
		private KalturaBulkUploadType _Type = null;
		private string _EmailRecipients = null;
		private int _NumOfErrorObjects = Int32.MinValue;
		#endregion

		#region Properties
		public string UserId
		{
			get { return _UserId; }
		}
		public string UploadedBy
		{
			get { return _UploadedBy; }
		}
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
		}
		public string ResultsFileLocalPath
		{
			get { return _ResultsFileLocalPath; }
		}
		public string ResultsFileUrl
		{
			get { return _ResultsFileUrl; }
		}
		public int NumOfEntries
		{
			get { return _NumOfEntries; }
		}
		public int NumOfObjects
		{
			get { return _NumOfObjects; }
		}
		public string FilePath
		{
			get { return _FilePath; }
		}
		public KalturaBulkUploadObjectType BulkUploadObjectType
		{
			get { return _BulkUploadObjectType; }
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
		public KalturaBulkUploadObjectData ObjectData
		{
			get { return _ObjectData; }
		}
		public KalturaBulkUploadType Type
		{
			get { return _Type; }
		}
		public string EmailRecipients
		{
			get { return _EmailRecipients; }
			set 
			{ 
				_EmailRecipients = value;
				OnPropertyChanged("EmailRecipients");
			}
		}
		public int NumOfErrorObjects
		{
			get { return _NumOfErrorObjects; }
			set 
			{ 
				_NumOfErrorObjects = value;
				OnPropertyChanged("NumOfErrorObjects");
			}
		}
		#endregion

		#region CTor
		public KalturaBulkUploadJobData()
		{
		}

		public KalturaBulkUploadJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "userId":
						this._UserId = txt;
						continue;
					case "uploadedBy":
						this._UploadedBy = txt;
						continue;
					case "conversionProfileId":
						this._ConversionProfileId = ParseInt(txt);
						continue;
					case "resultsFileLocalPath":
						this._ResultsFileLocalPath = txt;
						continue;
					case "resultsFileUrl":
						this._ResultsFileUrl = txt;
						continue;
					case "numOfEntries":
						this._NumOfEntries = ParseInt(txt);
						continue;
					case "numOfObjects":
						this._NumOfObjects = ParseInt(txt);
						continue;
					case "filePath":
						this._FilePath = txt;
						continue;
					case "bulkUploadObjectType":
						this._BulkUploadObjectType = (KalturaBulkUploadObjectType)KalturaStringEnum.Parse(typeof(KalturaBulkUploadObjectType), txt);
						continue;
					case "fileName":
						this._FileName = txt;
						continue;
					case "objectData":
						this._ObjectData = (KalturaBulkUploadObjectData)KalturaObjectFactory.Create(propertyNode, "KalturaBulkUploadObjectData");
						continue;
					case "type":
						this._Type = (KalturaBulkUploadType)KalturaStringEnum.Parse(typeof(KalturaBulkUploadType), txt);
						continue;
					case "emailRecipients":
						this._EmailRecipients = txt;
						continue;
					case "numOfErrorObjects":
						this._NumOfErrorObjects = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBulkUploadJobData");
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("uploadedBy", this._UploadedBy);
			kparams.AddIfNotNull("conversionProfileId", this._ConversionProfileId);
			kparams.AddIfNotNull("resultsFileLocalPath", this._ResultsFileLocalPath);
			kparams.AddIfNotNull("resultsFileUrl", this._ResultsFileUrl);
			kparams.AddIfNotNull("numOfEntries", this._NumOfEntries);
			kparams.AddIfNotNull("numOfObjects", this._NumOfObjects);
			kparams.AddIfNotNull("filePath", this._FilePath);
			kparams.AddIfNotNull("bulkUploadObjectType", this._BulkUploadObjectType);
			kparams.AddIfNotNull("fileName", this._FileName);
			kparams.AddIfNotNull("objectData", this._ObjectData);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("emailRecipients", this._EmailRecipients);
			kparams.AddIfNotNull("numOfErrorObjects", this._NumOfErrorObjects);
			return kparams;
		}
		#endregion
	}
}

