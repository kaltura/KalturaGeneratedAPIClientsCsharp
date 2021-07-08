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
	public class BulkUploadResult : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string BULK_UPLOAD_JOB_ID = "bulkUploadJobId";
		public const string LINE_INDEX = "lineIndex";
		public const string PARTNER_ID = "partnerId";
		public const string STATUS = "status";
		public const string ACTION = "action";
		public const string OBJECT_ID = "objectId";
		public const string OBJECT_STATUS = "objectStatus";
		public const string BULK_UPLOAD_RESULT_OBJECT_TYPE = "bulkUploadResultObjectType";
		public const string ROW_DATA = "rowData";
		public const string PARTNER_DATA = "partnerData";
		public const string OBJECT_ERROR_DESCRIPTION = "objectErrorDescription";
		public const string PLUGINS_DATA = "pluginsData";
		public const string ERROR_DESCRIPTION = "errorDescription";
		public const string ERROR_CODE = "errorCode";
		public const string ERROR_TYPE = "errorType";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private long _BulkUploadJobId = long.MinValue;
		private int _LineIndex = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private BulkUploadResultStatus _Status = null;
		private BulkUploadAction _Action = null;
		private string _ObjectId = null;
		private int _ObjectStatus = Int32.MinValue;
		private BulkUploadObjectType _BulkUploadResultObjectType = null;
		private string _RowData = null;
		private string _PartnerData = null;
		private string _ObjectErrorDescription = null;
		private IList<BulkUploadPluginData> _PluginsData;
		private string _ErrorDescription = null;
		private string _ErrorCode = null;
		private int _ErrorType = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use BulkUploadJobIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long BulkUploadJobId
		{
			get { return _BulkUploadJobId; }
			set 
			{ 
				_BulkUploadJobId = value;
				OnPropertyChanged("BulkUploadJobId");
			}
		}
		/// <summary>
		/// Use LineIndexAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LineIndex
		{
			get { return _LineIndex; }
			set 
			{ 
				_LineIndex = value;
				OnPropertyChanged("LineIndex");
			}
		}
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BulkUploadResultStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use ActionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BulkUploadAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		/// <summary>
		/// Use ObjectIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		/// <summary>
		/// Use ObjectStatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ObjectStatus
		{
			get { return _ObjectStatus; }
			set 
			{ 
				_ObjectStatus = value;
				OnPropertyChanged("ObjectStatus");
			}
		}
		/// <summary>
		/// Use BulkUploadResultObjectTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BulkUploadObjectType BulkUploadResultObjectType
		{
			get { return _BulkUploadResultObjectType; }
			set 
			{ 
				_BulkUploadResultObjectType = value;
				OnPropertyChanged("BulkUploadResultObjectType");
			}
		}
		/// <summary>
		/// Use RowDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RowData
		{
			get { return _RowData; }
			set 
			{ 
				_RowData = value;
				OnPropertyChanged("RowData");
			}
		}
		/// <summary>
		/// Use PartnerDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		/// <summary>
		/// Use ObjectErrorDescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectErrorDescription
		{
			get { return _ObjectErrorDescription; }
			set 
			{ 
				_ObjectErrorDescription = value;
				OnPropertyChanged("ObjectErrorDescription");
			}
		}
		/// <summary>
		/// Use PluginsDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<BulkUploadPluginData> PluginsData
		{
			get { return _PluginsData; }
			set 
			{ 
				_PluginsData = value;
				OnPropertyChanged("PluginsData");
			}
		}
		/// <summary>
		/// Use ErrorDescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		/// <summary>
		/// Use ErrorCodeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ErrorCode
		{
			get { return _ErrorCode; }
			set 
			{ 
				_ErrorCode = value;
				OnPropertyChanged("ErrorCode");
			}
		}
		/// <summary>
		/// Use ErrorTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ErrorType
		{
			get { return _ErrorType; }
			set 
			{ 
				_ErrorType = value;
				OnPropertyChanged("ErrorType");
			}
		}
		#endregion

		#region CTor
		public BulkUploadResult()
		{
		}

		public BulkUploadResult(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["bulkUploadJobId"] != null)
			{
				this._BulkUploadJobId = ParseLong(node["bulkUploadJobId"].Value<string>());
			}
			if(node["lineIndex"] != null)
			{
				this._LineIndex = ParseInt(node["lineIndex"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (BulkUploadResultStatus)StringEnum.Parse(typeof(BulkUploadResultStatus), node["status"].Value<string>());
			}
			if(node["action"] != null)
			{
				this._Action = (BulkUploadAction)StringEnum.Parse(typeof(BulkUploadAction), node["action"].Value<string>());
			}
			if(node["objectId"] != null)
			{
				this._ObjectId = node["objectId"].Value<string>();
			}
			if(node["objectStatus"] != null)
			{
				this._ObjectStatus = ParseInt(node["objectStatus"].Value<string>());
			}
			if(node["bulkUploadResultObjectType"] != null)
			{
				this._BulkUploadResultObjectType = (BulkUploadObjectType)StringEnum.Parse(typeof(BulkUploadObjectType), node["bulkUploadResultObjectType"].Value<string>());
			}
			if(node["rowData"] != null)
			{
				this._RowData = node["rowData"].Value<string>();
			}
			if(node["partnerData"] != null)
			{
				this._PartnerData = node["partnerData"].Value<string>();
			}
			if(node["objectErrorDescription"] != null)
			{
				this._ObjectErrorDescription = node["objectErrorDescription"].Value<string>();
			}
			if(node["pluginsData"] != null)
			{
				this._PluginsData = new List<BulkUploadPluginData>();
				foreach(var arrayNode in node["pluginsData"].Children())
				{
					this._PluginsData.Add(ObjectFactory.Create<BulkUploadPluginData>(arrayNode));
				}
			}
			if(node["errorDescription"] != null)
			{
				this._ErrorDescription = node["errorDescription"].Value<string>();
			}
			if(node["errorCode"] != null)
			{
				this._ErrorCode = node["errorCode"].Value<string>();
			}
			if(node["errorType"] != null)
			{
				this._ErrorType = ParseInt(node["errorType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadResult");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("bulkUploadJobId", this._BulkUploadJobId);
			kparams.AddIfNotNull("lineIndex", this._LineIndex);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("action", this._Action);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("objectStatus", this._ObjectStatus);
			kparams.AddIfNotNull("bulkUploadResultObjectType", this._BulkUploadResultObjectType);
			kparams.AddIfNotNull("rowData", this._RowData);
			kparams.AddIfNotNull("partnerData", this._PartnerData);
			kparams.AddIfNotNull("objectErrorDescription", this._ObjectErrorDescription);
			kparams.AddIfNotNull("pluginsData", this._PluginsData);
			kparams.AddIfNotNull("errorDescription", this._ErrorDescription);
			kparams.AddIfNotNull("errorCode", this._ErrorCode);
			kparams.AddIfNotNull("errorType", this._ErrorType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case BULK_UPLOAD_JOB_ID:
					return "BulkUploadJobId";
				case LINE_INDEX:
					return "LineIndex";
				case PARTNER_ID:
					return "PartnerId";
				case STATUS:
					return "Status";
				case ACTION:
					return "Action";
				case OBJECT_ID:
					return "ObjectId";
				case OBJECT_STATUS:
					return "ObjectStatus";
				case BULK_UPLOAD_RESULT_OBJECT_TYPE:
					return "BulkUploadResultObjectType";
				case ROW_DATA:
					return "RowData";
				case PARTNER_DATA:
					return "PartnerData";
				case OBJECT_ERROR_DESCRIPTION:
					return "ObjectErrorDescription";
				case PLUGINS_DATA:
					return "PluginsData";
				case ERROR_DESCRIPTION:
					return "ErrorDescription";
				case ERROR_CODE:
					return "ErrorCode";
				case ERROR_TYPE:
					return "ErrorType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

