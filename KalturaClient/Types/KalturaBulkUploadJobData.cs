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
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public string UploadedBy
		{
			get { return _UploadedBy; }
			set 
			{ 
				_UploadedBy = value;
				OnPropertyChanged("UploadedBy");
			}
		}
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		public string ResultsFileLocalPath
		{
			get { return _ResultsFileLocalPath; }
			set 
			{ 
				_ResultsFileLocalPath = value;
				OnPropertyChanged("ResultsFileLocalPath");
			}
		}
		public string ResultsFileUrl
		{
			get { return _ResultsFileUrl; }
			set 
			{ 
				_ResultsFileUrl = value;
				OnPropertyChanged("ResultsFileUrl");
			}
		}
		public int NumOfEntries
		{
			get { return _NumOfEntries; }
			set 
			{ 
				_NumOfEntries = value;
				OnPropertyChanged("NumOfEntries");
			}
		}
		public int NumOfObjects
		{
			get { return _NumOfObjects; }
			set 
			{ 
				_NumOfObjects = value;
				OnPropertyChanged("NumOfObjects");
			}
		}
		public string FilePath
		{
			get { return _FilePath; }
			set 
			{ 
				_FilePath = value;
				OnPropertyChanged("FilePath");
			}
		}
		public KalturaBulkUploadObjectType BulkUploadObjectType
		{
			get { return _BulkUploadObjectType; }
			set 
			{ 
				_BulkUploadObjectType = value;
				OnPropertyChanged("BulkUploadObjectType");
			}
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
			set 
			{ 
				_ObjectData = value;
				OnPropertyChanged("ObjectData");
			}
		}
		public KalturaBulkUploadType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
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
						this.UserId = txt;
						continue;
					case "uploadedBy":
						this.UploadedBy = txt;
						continue;
					case "conversionProfileId":
						this.ConversionProfileId = ParseInt(txt);
						continue;
					case "resultsFileLocalPath":
						this.ResultsFileLocalPath = txt;
						continue;
					case "resultsFileUrl":
						this.ResultsFileUrl = txt;
						continue;
					case "numOfEntries":
						this.NumOfEntries = ParseInt(txt);
						continue;
					case "numOfObjects":
						this.NumOfObjects = ParseInt(txt);
						continue;
					case "filePath":
						this.FilePath = txt;
						continue;
					case "bulkUploadObjectType":
						this.BulkUploadObjectType = (KalturaBulkUploadObjectType)KalturaStringEnum.Parse(typeof(KalturaBulkUploadObjectType), txt);
						continue;
					case "fileName":
						this.FileName = txt;
						continue;
					case "objectData":
						this.ObjectData = (KalturaBulkUploadObjectData)KalturaObjectFactory.Create(propertyNode, "KalturaBulkUploadObjectData");
						continue;
					case "type":
						this.Type = (KalturaBulkUploadType)KalturaStringEnum.Parse(typeof(KalturaBulkUploadType), txt);
						continue;
					case "emailRecipients":
						this.EmailRecipients = txt;
						continue;
					case "numOfErrorObjects":
						this.NumOfErrorObjects = ParseInt(txt);
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
			kparams.AddIfNotNull("userId", this.UserId);
			kparams.AddIfNotNull("uploadedBy", this.UploadedBy);
			kparams.AddIfNotNull("conversionProfileId", this.ConversionProfileId);
			kparams.AddIfNotNull("resultsFileLocalPath", this.ResultsFileLocalPath);
			kparams.AddIfNotNull("resultsFileUrl", this.ResultsFileUrl);
			kparams.AddIfNotNull("numOfEntries", this.NumOfEntries);
			kparams.AddIfNotNull("numOfObjects", this.NumOfObjects);
			kparams.AddIfNotNull("filePath", this.FilePath);
			kparams.AddIfNotNull("bulkUploadObjectType", this.BulkUploadObjectType);
			kparams.AddIfNotNull("fileName", this.FileName);
			kparams.AddIfNotNull("objectData", this.ObjectData);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("emailRecipients", this.EmailRecipients);
			kparams.AddIfNotNull("numOfErrorObjects", this.NumOfErrorObjects);
			return kparams;
		}
		#endregion
	}
}

