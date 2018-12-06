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
	public class BulkUploadJobData : JobData
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string UPLOADED_BY = "uploadedBy";
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string RESULTS_FILE_LOCAL_PATH = "resultsFileLocalPath";
		public const string RESULTS_FILE_URL = "resultsFileUrl";
		public const string NUM_OF_ENTRIES = "numOfEntries";
		public const string NUM_OF_OBJECTS = "numOfObjects";
		public const string FILE_PATH = "filePath";
		public const string BULK_UPLOAD_OBJECT_TYPE = "bulkUploadObjectType";
		public const string FILE_NAME = "fileName";
		public const string OBJECT_DATA = "objectData";
		public const string TYPE = "type";
		public const string EMAIL_RECIPIENTS = "emailRecipients";
		public const string NUM_OF_ERROR_OBJECTS = "numOfErrorObjects";
		public const string PRIVILEGES = "privileges";
		#endregion

		#region Private Fields
		private string _UserId = null;
		private string _UploadedBy = null;
		private int _ConversionProfileId = Int32.MinValue;
		private string _ResultsFileLocalPath = null;
		private string _ResultsFileUrl = null;
		private int _NumOfEntries = Int32.MinValue;
		private int _NumOfObjects = Int32.MinValue;
		private string _FilePath = null;
		private BulkUploadObjectType _BulkUploadObjectType = null;
		private string _FileName = null;
		private BulkUploadObjectData _ObjectData;
		private BulkUploadType _Type = null;
		private string _EmailRecipients = null;
		private int _NumOfErrorObjects = Int32.MinValue;
		private string _Privileges = null;
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
		public BulkUploadObjectType BulkUploadObjectType
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
		public BulkUploadObjectData ObjectData
		{
			get { return _ObjectData; }
		}
		public BulkUploadType Type
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
		public string Privileges
		{
			get { return _Privileges; }
			set 
			{ 
				_Privileges = value;
				OnPropertyChanged("Privileges");
			}
		}
		#endregion

		#region CTor
		public BulkUploadJobData()
		{
		}

		public BulkUploadJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "uploadedBy":
						this._UploadedBy = propertyNode.InnerText;
						continue;
					case "conversionProfileId":
						this._ConversionProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "resultsFileLocalPath":
						this._ResultsFileLocalPath = propertyNode.InnerText;
						continue;
					case "resultsFileUrl":
						this._ResultsFileUrl = propertyNode.InnerText;
						continue;
					case "numOfEntries":
						this._NumOfEntries = ParseInt(propertyNode.InnerText);
						continue;
					case "numOfObjects":
						this._NumOfObjects = ParseInt(propertyNode.InnerText);
						continue;
					case "filePath":
						this._FilePath = propertyNode.InnerText;
						continue;
					case "bulkUploadObjectType":
						this._BulkUploadObjectType = (BulkUploadObjectType)StringEnum.Parse(typeof(BulkUploadObjectType), propertyNode.InnerText);
						continue;
					case "fileName":
						this._FileName = propertyNode.InnerText;
						continue;
					case "objectData":
						this._ObjectData = ObjectFactory.Create<BulkUploadObjectData>(propertyNode);
						continue;
					case "type":
						this._Type = (BulkUploadType)StringEnum.Parse(typeof(BulkUploadType), propertyNode.InnerText);
						continue;
					case "emailRecipients":
						this._EmailRecipients = propertyNode.InnerText;
						continue;
					case "numOfErrorObjects":
						this._NumOfErrorObjects = ParseInt(propertyNode.InnerText);
						continue;
					case "privileges":
						this._Privileges = propertyNode.InnerText;
						continue;
				}
			}
		}

		public BulkUploadJobData(IDictionary<string,object> data) : base(data)
		{
			    this._UserId = data.TryGetValueSafe<string>("userId");
			    this._UploadedBy = data.TryGetValueSafe<string>("uploadedBy");
			    this._ConversionProfileId = data.TryGetValueSafe<int>("conversionProfileId");
			    this._ResultsFileLocalPath = data.TryGetValueSafe<string>("resultsFileLocalPath");
			    this._ResultsFileUrl = data.TryGetValueSafe<string>("resultsFileUrl");
			    this._NumOfEntries = data.TryGetValueSafe<int>("numOfEntries");
			    this._NumOfObjects = data.TryGetValueSafe<int>("numOfObjects");
			    this._FilePath = data.TryGetValueSafe<string>("filePath");
			    this._BulkUploadObjectType = (BulkUploadObjectType)StringEnum.Parse(typeof(BulkUploadObjectType), data.TryGetValueSafe<string>("bulkUploadObjectType"));
			    this._FileName = data.TryGetValueSafe<string>("fileName");
			    this._ObjectData = ObjectFactory.Create<BulkUploadObjectData>(data.TryGetValueSafe<IDictionary<string,object>>("objectData"));
			    this._Type = (BulkUploadType)StringEnum.Parse(typeof(BulkUploadType), data.TryGetValueSafe<string>("type"));
			    this._EmailRecipients = data.TryGetValueSafe<string>("emailRecipients");
			    this._NumOfErrorObjects = data.TryGetValueSafe<int>("numOfErrorObjects");
			    this._Privileges = data.TryGetValueSafe<string>("privileges");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
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
			kparams.AddIfNotNull("privileges", this._Privileges);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_ID:
					return "UserId";
				case UPLOADED_BY:
					return "UploadedBy";
				case CONVERSION_PROFILE_ID:
					return "ConversionProfileId";
				case RESULTS_FILE_LOCAL_PATH:
					return "ResultsFileLocalPath";
				case RESULTS_FILE_URL:
					return "ResultsFileUrl";
				case NUM_OF_ENTRIES:
					return "NumOfEntries";
				case NUM_OF_OBJECTS:
					return "NumOfObjects";
				case FILE_PATH:
					return "FilePath";
				case BULK_UPLOAD_OBJECT_TYPE:
					return "BulkUploadObjectType";
				case FILE_NAME:
					return "FileName";
				case OBJECT_DATA:
					return "ObjectData";
				case TYPE:
					return "Type";
				case EMAIL_RECIPIENTS:
					return "EmailRecipients";
				case NUM_OF_ERROR_OBJECTS:
					return "NumOfErrorObjects";
				case PRIVILEGES:
					return "Privileges";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

