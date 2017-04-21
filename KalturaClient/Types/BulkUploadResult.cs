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
// Copyright (C) 2006-2017  Kaltura Inc.
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
		public int Id
		{
			get { return _Id; }
		}
		public long BulkUploadJobId
		{
			get { return _BulkUploadJobId; }
			set 
			{ 
				_BulkUploadJobId = value;
				OnPropertyChanged("BulkUploadJobId");
			}
		}
		public int LineIndex
		{
			get { return _LineIndex; }
			set 
			{ 
				_LineIndex = value;
				OnPropertyChanged("LineIndex");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public BulkUploadResultStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public BulkUploadAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		public int ObjectStatus
		{
			get { return _ObjectStatus; }
			set 
			{ 
				_ObjectStatus = value;
				OnPropertyChanged("ObjectStatus");
			}
		}
		public BulkUploadObjectType BulkUploadResultObjectType
		{
			get { return _BulkUploadResultObjectType; }
			set 
			{ 
				_BulkUploadResultObjectType = value;
				OnPropertyChanged("BulkUploadResultObjectType");
			}
		}
		public string RowData
		{
			get { return _RowData; }
			set 
			{ 
				_RowData = value;
				OnPropertyChanged("RowData");
			}
		}
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		public string ObjectErrorDescription
		{
			get { return _ObjectErrorDescription; }
			set 
			{ 
				_ObjectErrorDescription = value;
				OnPropertyChanged("ObjectErrorDescription");
			}
		}
		public IList<BulkUploadPluginData> PluginsData
		{
			get { return _PluginsData; }
			set 
			{ 
				_PluginsData = value;
				OnPropertyChanged("PluginsData");
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
		public string ErrorCode
		{
			get { return _ErrorCode; }
			set 
			{ 
				_ErrorCode = value;
				OnPropertyChanged("ErrorCode");
			}
		}
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

		public BulkUploadResult(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "bulkUploadJobId":
						this._BulkUploadJobId = ParseLong(propertyNode.InnerText);
						continue;
					case "lineIndex":
						this._LineIndex = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (BulkUploadResultStatus)StringEnum.Parse(typeof(BulkUploadResultStatus), propertyNode.InnerText);
						continue;
					case "action":
						this._Action = (BulkUploadAction)StringEnum.Parse(typeof(BulkUploadAction), propertyNode.InnerText);
						continue;
					case "objectId":
						this._ObjectId = propertyNode.InnerText;
						continue;
					case "objectStatus":
						this._ObjectStatus = ParseInt(propertyNode.InnerText);
						continue;
					case "bulkUploadResultObjectType":
						this._BulkUploadResultObjectType = (BulkUploadObjectType)StringEnum.Parse(typeof(BulkUploadObjectType), propertyNode.InnerText);
						continue;
					case "rowData":
						this._RowData = propertyNode.InnerText;
						continue;
					case "partnerData":
						this._PartnerData = propertyNode.InnerText;
						continue;
					case "objectErrorDescription":
						this._ObjectErrorDescription = propertyNode.InnerText;
						continue;
					case "pluginsData":
						this._PluginsData = new List<BulkUploadPluginData>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._PluginsData.Add(ObjectFactory.Create<BulkUploadPluginData>(arrayNode));
						}
						continue;
					case "errorDescription":
						this._ErrorDescription = propertyNode.InnerText;
						continue;
					case "errorCode":
						this._ErrorCode = propertyNode.InnerText;
						continue;
					case "errorType":
						this._ErrorType = ParseInt(propertyNode.InnerText);
						continue;
				}
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

