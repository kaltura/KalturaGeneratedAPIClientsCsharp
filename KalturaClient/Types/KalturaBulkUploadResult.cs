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
	public class KalturaBulkUploadResult : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private long _BulkUploadJobId = long.MinValue;
		private int _LineIndex = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private KalturaBulkUploadResultStatus _Status = null;
		private KalturaBulkUploadAction _Action = null;
		private string _ObjectId = null;
		private int _ObjectStatus = Int32.MinValue;
		private KalturaBulkUploadObjectType _BulkUploadResultObjectType = null;
		private string _RowData = null;
		private string _PartnerData = null;
		private string _ObjectErrorDescription = null;
		private IList<KalturaBulkUploadPluginData> _PluginsData;
		private string _ErrorDescription = null;
		private string _ErrorCode = null;
		private int _ErrorType = Int32.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
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
		public KalturaBulkUploadResultStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaBulkUploadAction Action
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
		public KalturaBulkUploadObjectType BulkUploadResultObjectType
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
		public IList<KalturaBulkUploadPluginData> PluginsData
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
		public KalturaBulkUploadResult()
		{
		}

		public KalturaBulkUploadResult(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "bulkUploadJobId":
						this.BulkUploadJobId = ParseLong(txt);
						continue;
					case "lineIndex":
						this.LineIndex = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaBulkUploadResultStatus)KalturaStringEnum.Parse(typeof(KalturaBulkUploadResultStatus), txt);
						continue;
					case "action":
						this.Action = (KalturaBulkUploadAction)KalturaStringEnum.Parse(typeof(KalturaBulkUploadAction), txt);
						continue;
					case "objectId":
						this.ObjectId = txt;
						continue;
					case "objectStatus":
						this.ObjectStatus = ParseInt(txt);
						continue;
					case "bulkUploadResultObjectType":
						this.BulkUploadResultObjectType = (KalturaBulkUploadObjectType)KalturaStringEnum.Parse(typeof(KalturaBulkUploadObjectType), txt);
						continue;
					case "rowData":
						this.RowData = txt;
						continue;
					case "partnerData":
						this.PartnerData = txt;
						continue;
					case "objectErrorDescription":
						this.ObjectErrorDescription = txt;
						continue;
					case "pluginsData":
						this.PluginsData = new List<KalturaBulkUploadPluginData>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.PluginsData.Add((KalturaBulkUploadPluginData)KalturaObjectFactory.Create(arrayNode, "KalturaBulkUploadPluginData"));
						}
						continue;
					case "errorDescription":
						this.ErrorDescription = txt;
						continue;
					case "errorCode":
						this.ErrorCode = txt;
						continue;
					case "errorType":
						this.ErrorType = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBulkUploadResult");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("bulkUploadJobId", this.BulkUploadJobId);
			kparams.AddIfNotNull("lineIndex", this.LineIndex);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("action", this.Action);
			kparams.AddIfNotNull("objectId", this.ObjectId);
			kparams.AddIfNotNull("objectStatus", this.ObjectStatus);
			kparams.AddIfNotNull("bulkUploadResultObjectType", this.BulkUploadResultObjectType);
			kparams.AddIfNotNull("rowData", this.RowData);
			kparams.AddIfNotNull("partnerData", this.PartnerData);
			kparams.AddIfNotNull("objectErrorDescription", this.ObjectErrorDescription);
			kparams.AddIfNotNull("pluginsData", this.PluginsData);
			kparams.AddIfNotNull("errorDescription", this.ErrorDescription);
			kparams.AddIfNotNull("errorCode", this.ErrorCode);
			kparams.AddIfNotNull("errorType", this.ErrorType);
			return kparams;
		}
		#endregion
	}
}

