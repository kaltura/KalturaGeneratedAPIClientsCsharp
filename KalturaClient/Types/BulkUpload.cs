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
	public class BulkUpload : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string UPLOADED_BY = "uploadedBy";
		public const string UPLOADED_BY_USER_ID = "uploadedByUserId";
		public const string UPLOADED_ON = "uploadedOn";
		public const string NUM_OF_ENTRIES = "numOfEntries";
		public const string STATUS = "status";
		public const string LOG_FILE_URL = "logFileUrl";
		public const string CSV_FILE_URL = "csvFileUrl";
		public const string BULK_FILE_URL = "bulkFileUrl";
		public const string BULK_UPLOAD_TYPE = "bulkUploadType";
		public const string RESULTS = "results";
		public const string ERROR = "error";
		public const string ERROR_TYPE = "errorType";
		public const string ERROR_NUMBER = "errorNumber";
		public const string FILE_NAME = "fileName";
		public const string DESCRIPTION = "description";
		public const string NUM_OF_OBJECTS = "numOfObjects";
		public const string BULK_UPLOAD_OBJECT_TYPE = "bulkUploadObjectType";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private string _UploadedBy = null;
		private string _UploadedByUserId = null;
		private int _UploadedOn = Int32.MinValue;
		private int _NumOfEntries = Int32.MinValue;
		private BatchJobStatus _Status = (BatchJobStatus)Int32.MinValue;
		private string _LogFileUrl = null;
		private string _CsvFileUrl = null;
		private string _BulkFileUrl = null;
		private BulkUploadType _BulkUploadType = null;
		private IList<BulkUploadResult> _Results;
		private string _Error = null;
		private BatchJobErrorTypes _ErrorType = (BatchJobErrorTypes)Int32.MinValue;
		private int _ErrorNumber = Int32.MinValue;
		private string _FileName = null;
		private string _Description = null;
		private int _NumOfObjects = Int32.MinValue;
		private BulkUploadObjectType _BulkUploadObjectType = null;
		#endregion

		#region Properties
		[JsonProperty]
		public long Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public string UploadedBy
		{
			get { return _UploadedBy; }
			set 
			{ 
				_UploadedBy = value;
				OnPropertyChanged("UploadedBy");
			}
		}
		[JsonProperty]
		public string UploadedByUserId
		{
			get { return _UploadedByUserId; }
			set 
			{ 
				_UploadedByUserId = value;
				OnPropertyChanged("UploadedByUserId");
			}
		}
		[JsonProperty]
		public int UploadedOn
		{
			get { return _UploadedOn; }
			set 
			{ 
				_UploadedOn = value;
				OnPropertyChanged("UploadedOn");
			}
		}
		[JsonProperty]
		public int NumOfEntries
		{
			get { return _NumOfEntries; }
			set 
			{ 
				_NumOfEntries = value;
				OnPropertyChanged("NumOfEntries");
			}
		}
		[JsonProperty]
		public BatchJobStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public string LogFileUrl
		{
			get { return _LogFileUrl; }
			set 
			{ 
				_LogFileUrl = value;
				OnPropertyChanged("LogFileUrl");
			}
		}
		[JsonProperty]
		public string CsvFileUrl
		{
			get { return _CsvFileUrl; }
			set 
			{ 
				_CsvFileUrl = value;
				OnPropertyChanged("CsvFileUrl");
			}
		}
		[JsonProperty]
		public string BulkFileUrl
		{
			get { return _BulkFileUrl; }
			set 
			{ 
				_BulkFileUrl = value;
				OnPropertyChanged("BulkFileUrl");
			}
		}
		[JsonProperty]
		public BulkUploadType BulkUploadType
		{
			get { return _BulkUploadType; }
			set 
			{ 
				_BulkUploadType = value;
				OnPropertyChanged("BulkUploadType");
			}
		}
		[JsonProperty]
		public IList<BulkUploadResult> Results
		{
			get { return _Results; }
			set 
			{ 
				_Results = value;
				OnPropertyChanged("Results");
			}
		}
		[JsonProperty]
		public string Error
		{
			get { return _Error; }
			set 
			{ 
				_Error = value;
				OnPropertyChanged("Error");
			}
		}
		[JsonProperty]
		public BatchJobErrorTypes ErrorType
		{
			get { return _ErrorType; }
			set 
			{ 
				_ErrorType = value;
				OnPropertyChanged("ErrorType");
			}
		}
		[JsonProperty]
		public int ErrorNumber
		{
			get { return _ErrorNumber; }
			set 
			{ 
				_ErrorNumber = value;
				OnPropertyChanged("ErrorNumber");
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
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		[JsonProperty]
		public int NumOfObjects
		{
			get { return _NumOfObjects; }
			set 
			{ 
				_NumOfObjects = value;
				OnPropertyChanged("NumOfObjects");
			}
		}
		[JsonProperty]
		public BulkUploadObjectType BulkUploadObjectType
		{
			get { return _BulkUploadObjectType; }
			set 
			{ 
				_BulkUploadObjectType = value;
				OnPropertyChanged("BulkUploadObjectType");
			}
		}
		#endregion

		#region CTor
		public BulkUpload()
		{
		}

		public BulkUpload(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["uploadedBy"] != null)
			{
				this._UploadedBy = node["uploadedBy"].Value<string>();
			}
			if(node["uploadedByUserId"] != null)
			{
				this._UploadedByUserId = node["uploadedByUserId"].Value<string>();
			}
			if(node["uploadedOn"] != null)
			{
				this._UploadedOn = ParseInt(node["uploadedOn"].Value<string>());
			}
			if(node["numOfEntries"] != null)
			{
				this._NumOfEntries = ParseInt(node["numOfEntries"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (BatchJobStatus)ParseEnum(typeof(BatchJobStatus), node["status"].Value<string>());
			}
			if(node["logFileUrl"] != null)
			{
				this._LogFileUrl = node["logFileUrl"].Value<string>();
			}
			if(node["csvFileUrl"] != null)
			{
				this._CsvFileUrl = node["csvFileUrl"].Value<string>();
			}
			if(node["bulkFileUrl"] != null)
			{
				this._BulkFileUrl = node["bulkFileUrl"].Value<string>();
			}
			if(node["bulkUploadType"] != null)
			{
				this._BulkUploadType = (BulkUploadType)StringEnum.Parse(typeof(BulkUploadType), node["bulkUploadType"].Value<string>());
			}
			if(node["results"] != null)
			{
				this._Results = new List<BulkUploadResult>();
				foreach(var arrayNode in node["results"].Children())
				{
					this._Results.Add(ObjectFactory.Create<BulkUploadResult>(arrayNode));
				}
			}
			if(node["error"] != null)
			{
				this._Error = node["error"].Value<string>();
			}
			if(node["errorType"] != null)
			{
				this._ErrorType = (BatchJobErrorTypes)ParseEnum(typeof(BatchJobErrorTypes), node["errorType"].Value<string>());
			}
			if(node["errorNumber"] != null)
			{
				this._ErrorNumber = ParseInt(node["errorNumber"].Value<string>());
			}
			if(node["fileName"] != null)
			{
				this._FileName = node["fileName"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["numOfObjects"] != null)
			{
				this._NumOfObjects = ParseInt(node["numOfObjects"].Value<string>());
			}
			if(node["bulkUploadObjectType"] != null)
			{
				this._BulkUploadObjectType = (BulkUploadObjectType)StringEnum.Parse(typeof(BulkUploadObjectType), node["bulkUploadObjectType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUpload");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("uploadedBy", this._UploadedBy);
			kparams.AddIfNotNull("uploadedByUserId", this._UploadedByUserId);
			kparams.AddIfNotNull("uploadedOn", this._UploadedOn);
			kparams.AddIfNotNull("numOfEntries", this._NumOfEntries);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("logFileUrl", this._LogFileUrl);
			kparams.AddIfNotNull("csvFileUrl", this._CsvFileUrl);
			kparams.AddIfNotNull("bulkFileUrl", this._BulkFileUrl);
			kparams.AddIfNotNull("bulkUploadType", this._BulkUploadType);
			kparams.AddIfNotNull("results", this._Results);
			kparams.AddIfNotNull("error", this._Error);
			kparams.AddIfNotNull("errorType", this._ErrorType);
			kparams.AddIfNotNull("errorNumber", this._ErrorNumber);
			kparams.AddIfNotNull("fileName", this._FileName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("numOfObjects", this._NumOfObjects);
			kparams.AddIfNotNull("bulkUploadObjectType", this._BulkUploadObjectType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case UPLOADED_BY:
					return "UploadedBy";
				case UPLOADED_BY_USER_ID:
					return "UploadedByUserId";
				case UPLOADED_ON:
					return "UploadedOn";
				case NUM_OF_ENTRIES:
					return "NumOfEntries";
				case STATUS:
					return "Status";
				case LOG_FILE_URL:
					return "LogFileUrl";
				case CSV_FILE_URL:
					return "CsvFileUrl";
				case BULK_FILE_URL:
					return "BulkFileUrl";
				case BULK_UPLOAD_TYPE:
					return "BulkUploadType";
				case RESULTS:
					return "Results";
				case ERROR:
					return "Error";
				case ERROR_TYPE:
					return "ErrorType";
				case ERROR_NUMBER:
					return "ErrorNumber";
				case FILE_NAME:
					return "FileName";
				case DESCRIPTION:
					return "Description";
				case NUM_OF_OBJECTS:
					return "NumOfObjects";
				case BULK_UPLOAD_OBJECT_TYPE:
					return "BulkUploadObjectType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

