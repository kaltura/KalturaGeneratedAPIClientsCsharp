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
// Copyright (C) 2006-2020  Kaltura Inc.
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
		[JsonProperty]
		public string UploadedBy
		{
			get { return _UploadedBy; }
			private set 
			{ 
				_UploadedBy = value;
				OnPropertyChanged("UploadedBy");
			}
		}
		[JsonProperty]
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			private set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		[JsonProperty]
		public string ResultsFileLocalPath
		{
			get { return _ResultsFileLocalPath; }
			private set 
			{ 
				_ResultsFileLocalPath = value;
				OnPropertyChanged("ResultsFileLocalPath");
			}
		}
		[JsonProperty]
		public string ResultsFileUrl
		{
			get { return _ResultsFileUrl; }
			private set 
			{ 
				_ResultsFileUrl = value;
				OnPropertyChanged("ResultsFileUrl");
			}
		}
		[JsonProperty]
		public int NumOfEntries
		{
			get { return _NumOfEntries; }
			private set 
			{ 
				_NumOfEntries = value;
				OnPropertyChanged("NumOfEntries");
			}
		}
		[JsonProperty]
		public int NumOfObjects
		{
			get { return _NumOfObjects; }
			private set 
			{ 
				_NumOfObjects = value;
				OnPropertyChanged("NumOfObjects");
			}
		}
		[JsonProperty]
		public string FilePath
		{
			get { return _FilePath; }
			private set 
			{ 
				_FilePath = value;
				OnPropertyChanged("FilePath");
			}
		}
		[JsonProperty]
		public BulkUploadObjectType BulkUploadObjectType
		{
			get { return _BulkUploadObjectType; }
			private set 
			{ 
				_BulkUploadObjectType = value;
				OnPropertyChanged("BulkUploadObjectType");
			}
		}
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
		[JsonProperty]
		public BulkUploadObjectData ObjectData
		{
			get { return _ObjectData; }
			private set 
			{ 
				_ObjectData = value;
				OnPropertyChanged("ObjectData");
			}
		}
		[JsonProperty]
		public BulkUploadType Type
		{
			get { return _Type; }
			private set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		[JsonProperty]
		public string EmailRecipients
		{
			get { return _EmailRecipients; }
			set 
			{ 
				_EmailRecipients = value;
				OnPropertyChanged("EmailRecipients");
			}
		}
		[JsonProperty]
		public int NumOfErrorObjects
		{
			get { return _NumOfErrorObjects; }
			set 
			{ 
				_NumOfErrorObjects = value;
				OnPropertyChanged("NumOfErrorObjects");
			}
		}
		[JsonProperty]
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

		public BulkUploadJobData(JToken node) : base(node)
		{
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["uploadedBy"] != null)
			{
				this._UploadedBy = node["uploadedBy"].Value<string>();
			}
			if(node["conversionProfileId"] != null)
			{
				this._ConversionProfileId = ParseInt(node["conversionProfileId"].Value<string>());
			}
			if(node["resultsFileLocalPath"] != null)
			{
				this._ResultsFileLocalPath = node["resultsFileLocalPath"].Value<string>();
			}
			if(node["resultsFileUrl"] != null)
			{
				this._ResultsFileUrl = node["resultsFileUrl"].Value<string>();
			}
			if(node["numOfEntries"] != null)
			{
				this._NumOfEntries = ParseInt(node["numOfEntries"].Value<string>());
			}
			if(node["numOfObjects"] != null)
			{
				this._NumOfObjects = ParseInt(node["numOfObjects"].Value<string>());
			}
			if(node["filePath"] != null)
			{
				this._FilePath = node["filePath"].Value<string>();
			}
			if(node["bulkUploadObjectType"] != null)
			{
				this._BulkUploadObjectType = (BulkUploadObjectType)StringEnum.Parse(typeof(BulkUploadObjectType), node["bulkUploadObjectType"].Value<string>());
			}
			if(node["fileName"] != null)
			{
				this._FileName = node["fileName"].Value<string>();
			}
			if(node["objectData"] != null)
			{
				this._ObjectData = ObjectFactory.Create<BulkUploadObjectData>(node["objectData"]);
			}
			if(node["type"] != null)
			{
				this._Type = (BulkUploadType)StringEnum.Parse(typeof(BulkUploadType), node["type"].Value<string>());
			}
			if(node["emailRecipients"] != null)
			{
				this._EmailRecipients = node["emailRecipients"].Value<string>();
			}
			if(node["numOfErrorObjects"] != null)
			{
				this._NumOfErrorObjects = ParseInt(node["numOfErrorObjects"].Value<string>());
			}
			if(node["privileges"] != null)
			{
				this._Privileges = node["privileges"].Value<string>();
			}
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

