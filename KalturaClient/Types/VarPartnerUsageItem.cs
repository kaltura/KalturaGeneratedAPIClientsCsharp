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
	public class VarPartnerUsageItem : ObjectBase
	{
		#region Constants
		public const string PARTNER_ID = "partnerId";
		public const string PARTNER_NAME = "partnerName";
		public const string PARTNER_STATUS = "partnerStatus";
		public const string PARTNER_PACKAGE = "partnerPackage";
		public const string PARTNER_CREATED_AT = "partnerCreatedAt";
		public const string VIEWS = "views";
		public const string PLAYS = "plays";
		public const string ENTRIES_COUNT = "entriesCount";
		public const string TOTAL_ENTRIES_COUNT = "totalEntriesCount";
		public const string VIDEO_ENTRIES_COUNT = "videoEntriesCount";
		public const string IMAGE_ENTRIES_COUNT = "imageEntriesCount";
		public const string AUDIO_ENTRIES_COUNT = "audioEntriesCount";
		public const string MIX_ENTRIES_COUNT = "mixEntriesCount";
		public const string BANDWIDTH = "bandwidth";
		public const string TOTAL_STORAGE = "totalStorage";
		public const string STORAGE = "storage";
		public const string DELETED_STORAGE = "deletedStorage";
		public const string PEAK_STORAGE = "peakStorage";
		public const string AVG_STORAGE = "avgStorage";
		public const string COMBINED_STORAGE_BANDWIDTH = "combinedStorageBandwidth";
		public const string TRANSCODING_USAGE = "transcodingUsage";
		public const string DATE_ID = "dateId";
		#endregion

		#region Private Fields
		private int _PartnerId = Int32.MinValue;
		private string _PartnerName = null;
		private PartnerStatus _PartnerStatus = (PartnerStatus)Int32.MinValue;
		private int _PartnerPackage = Int32.MinValue;
		private int _PartnerCreatedAt = Int32.MinValue;
		private int _Views = Int32.MinValue;
		private int _Plays = Int32.MinValue;
		private int _EntriesCount = Int32.MinValue;
		private int _TotalEntriesCount = Int32.MinValue;
		private int _VideoEntriesCount = Int32.MinValue;
		private int _ImageEntriesCount = Int32.MinValue;
		private int _AudioEntriesCount = Int32.MinValue;
		private int _MixEntriesCount = Int32.MinValue;
		private float _Bandwidth = Single.MinValue;
		private float _TotalStorage = Single.MinValue;
		private float _Storage = Single.MinValue;
		private float _DeletedStorage = Single.MinValue;
		private float _PeakStorage = Single.MinValue;
		private float _AvgStorage = Single.MinValue;
		private float _CombinedStorageBandwidth = Single.MinValue;
		private float _TranscodingUsage = Single.MinValue;
		private string _DateId = null;
		#endregion

		#region Properties
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string PartnerName
		{
			get { return _PartnerName; }
			set 
			{ 
				_PartnerName = value;
				OnPropertyChanged("PartnerName");
			}
		}
		public PartnerStatus PartnerStatus
		{
			get { return _PartnerStatus; }
			set 
			{ 
				_PartnerStatus = value;
				OnPropertyChanged("PartnerStatus");
			}
		}
		public int PartnerPackage
		{
			get { return _PartnerPackage; }
			set 
			{ 
				_PartnerPackage = value;
				OnPropertyChanged("PartnerPackage");
			}
		}
		public int PartnerCreatedAt
		{
			get { return _PartnerCreatedAt; }
			set 
			{ 
				_PartnerCreatedAt = value;
				OnPropertyChanged("PartnerCreatedAt");
			}
		}
		public int Views
		{
			get { return _Views; }
			set 
			{ 
				_Views = value;
				OnPropertyChanged("Views");
			}
		}
		public int Plays
		{
			get { return _Plays; }
			set 
			{ 
				_Plays = value;
				OnPropertyChanged("Plays");
			}
		}
		public int EntriesCount
		{
			get { return _EntriesCount; }
			set 
			{ 
				_EntriesCount = value;
				OnPropertyChanged("EntriesCount");
			}
		}
		public int TotalEntriesCount
		{
			get { return _TotalEntriesCount; }
			set 
			{ 
				_TotalEntriesCount = value;
				OnPropertyChanged("TotalEntriesCount");
			}
		}
		public int VideoEntriesCount
		{
			get { return _VideoEntriesCount; }
			set 
			{ 
				_VideoEntriesCount = value;
				OnPropertyChanged("VideoEntriesCount");
			}
		}
		public int ImageEntriesCount
		{
			get { return _ImageEntriesCount; }
			set 
			{ 
				_ImageEntriesCount = value;
				OnPropertyChanged("ImageEntriesCount");
			}
		}
		public int AudioEntriesCount
		{
			get { return _AudioEntriesCount; }
			set 
			{ 
				_AudioEntriesCount = value;
				OnPropertyChanged("AudioEntriesCount");
			}
		}
		public int MixEntriesCount
		{
			get { return _MixEntriesCount; }
			set 
			{ 
				_MixEntriesCount = value;
				OnPropertyChanged("MixEntriesCount");
			}
		}
		public float Bandwidth
		{
			get { return _Bandwidth; }
			set 
			{ 
				_Bandwidth = value;
				OnPropertyChanged("Bandwidth");
			}
		}
		public float TotalStorage
		{
			get { return _TotalStorage; }
			set 
			{ 
				_TotalStorage = value;
				OnPropertyChanged("TotalStorage");
			}
		}
		public float Storage
		{
			get { return _Storage; }
			set 
			{ 
				_Storage = value;
				OnPropertyChanged("Storage");
			}
		}
		public float DeletedStorage
		{
			get { return _DeletedStorage; }
			set 
			{ 
				_DeletedStorage = value;
				OnPropertyChanged("DeletedStorage");
			}
		}
		public float PeakStorage
		{
			get { return _PeakStorage; }
			set 
			{ 
				_PeakStorage = value;
				OnPropertyChanged("PeakStorage");
			}
		}
		public float AvgStorage
		{
			get { return _AvgStorage; }
			set 
			{ 
				_AvgStorage = value;
				OnPropertyChanged("AvgStorage");
			}
		}
		public float CombinedStorageBandwidth
		{
			get { return _CombinedStorageBandwidth; }
			set 
			{ 
				_CombinedStorageBandwidth = value;
				OnPropertyChanged("CombinedStorageBandwidth");
			}
		}
		public float TranscodingUsage
		{
			get { return _TranscodingUsage; }
			set 
			{ 
				_TranscodingUsage = value;
				OnPropertyChanged("TranscodingUsage");
			}
		}
		public string DateId
		{
			get { return _DateId; }
			set 
			{ 
				_DateId = value;
				OnPropertyChanged("DateId");
			}
		}
		#endregion

		#region CTor
		public VarPartnerUsageItem()
		{
		}

		public VarPartnerUsageItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerName":
						this._PartnerName = propertyNode.InnerText;
						continue;
					case "partnerStatus":
						this._PartnerStatus = (PartnerStatus)ParseEnum(typeof(PartnerStatus), propertyNode.InnerText);
						continue;
					case "partnerPackage":
						this._PartnerPackage = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerCreatedAt":
						this._PartnerCreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "views":
						this._Views = ParseInt(propertyNode.InnerText);
						continue;
					case "plays":
						this._Plays = ParseInt(propertyNode.InnerText);
						continue;
					case "entriesCount":
						this._EntriesCount = ParseInt(propertyNode.InnerText);
						continue;
					case "totalEntriesCount":
						this._TotalEntriesCount = ParseInt(propertyNode.InnerText);
						continue;
					case "videoEntriesCount":
						this._VideoEntriesCount = ParseInt(propertyNode.InnerText);
						continue;
					case "imageEntriesCount":
						this._ImageEntriesCount = ParseInt(propertyNode.InnerText);
						continue;
					case "audioEntriesCount":
						this._AudioEntriesCount = ParseInt(propertyNode.InnerText);
						continue;
					case "mixEntriesCount":
						this._MixEntriesCount = ParseInt(propertyNode.InnerText);
						continue;
					case "bandwidth":
						this._Bandwidth = ParseFloat(propertyNode.InnerText);
						continue;
					case "totalStorage":
						this._TotalStorage = ParseFloat(propertyNode.InnerText);
						continue;
					case "storage":
						this._Storage = ParseFloat(propertyNode.InnerText);
						continue;
					case "deletedStorage":
						this._DeletedStorage = ParseFloat(propertyNode.InnerText);
						continue;
					case "peakStorage":
						this._PeakStorage = ParseFloat(propertyNode.InnerText);
						continue;
					case "avgStorage":
						this._AvgStorage = ParseFloat(propertyNode.InnerText);
						continue;
					case "combinedStorageBandwidth":
						this._CombinedStorageBandwidth = ParseFloat(propertyNode.InnerText);
						continue;
					case "transcodingUsage":
						this._TranscodingUsage = ParseFloat(propertyNode.InnerText);
						continue;
					case "dateId":
						this._DateId = propertyNode.InnerText;
						continue;
				}
			}
		}

		public VarPartnerUsageItem(IDictionary<string,object> data) : base(data)
		{
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._PartnerName = data.TryGetValueSafe<string>("partnerName");
			    this._PartnerStatus = (PartnerStatus)ParseEnum(typeof(PartnerStatus), data.TryGetValueSafe<int>("partnerStatus"));
			    this._PartnerPackage = data.TryGetValueSafe<int>("partnerPackage");
			    this._PartnerCreatedAt = data.TryGetValueSafe<int>("partnerCreatedAt");
			    this._Views = data.TryGetValueSafe<int>("views");
			    this._Plays = data.TryGetValueSafe<int>("plays");
			    this._EntriesCount = data.TryGetValueSafe<int>("entriesCount");
			    this._TotalEntriesCount = data.TryGetValueSafe<int>("totalEntriesCount");
			    this._VideoEntriesCount = data.TryGetValueSafe<int>("videoEntriesCount");
			    this._ImageEntriesCount = data.TryGetValueSafe<int>("imageEntriesCount");
			    this._AudioEntriesCount = data.TryGetValueSafe<int>("audioEntriesCount");
			    this._MixEntriesCount = data.TryGetValueSafe<int>("mixEntriesCount");
			    this._Bandwidth = data.TryGetValueSafe<float>("bandwidth");
			    this._TotalStorage = data.TryGetValueSafe<float>("totalStorage");
			    this._Storage = data.TryGetValueSafe<float>("storage");
			    this._DeletedStorage = data.TryGetValueSafe<float>("deletedStorage");
			    this._PeakStorage = data.TryGetValueSafe<float>("peakStorage");
			    this._AvgStorage = data.TryGetValueSafe<float>("avgStorage");
			    this._CombinedStorageBandwidth = data.TryGetValueSafe<float>("combinedStorageBandwidth");
			    this._TranscodingUsage = data.TryGetValueSafe<float>("transcodingUsage");
			    this._DateId = data.TryGetValueSafe<string>("dateId");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVarPartnerUsageItem");
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("partnerName", this._PartnerName);
			kparams.AddIfNotNull("partnerStatus", this._PartnerStatus);
			kparams.AddIfNotNull("partnerPackage", this._PartnerPackage);
			kparams.AddIfNotNull("partnerCreatedAt", this._PartnerCreatedAt);
			kparams.AddIfNotNull("views", this._Views);
			kparams.AddIfNotNull("plays", this._Plays);
			kparams.AddIfNotNull("entriesCount", this._EntriesCount);
			kparams.AddIfNotNull("totalEntriesCount", this._TotalEntriesCount);
			kparams.AddIfNotNull("videoEntriesCount", this._VideoEntriesCount);
			kparams.AddIfNotNull("imageEntriesCount", this._ImageEntriesCount);
			kparams.AddIfNotNull("audioEntriesCount", this._AudioEntriesCount);
			kparams.AddIfNotNull("mixEntriesCount", this._MixEntriesCount);
			kparams.AddIfNotNull("bandwidth", this._Bandwidth);
			kparams.AddIfNotNull("totalStorage", this._TotalStorage);
			kparams.AddIfNotNull("storage", this._Storage);
			kparams.AddIfNotNull("deletedStorage", this._DeletedStorage);
			kparams.AddIfNotNull("peakStorage", this._PeakStorage);
			kparams.AddIfNotNull("avgStorage", this._AvgStorage);
			kparams.AddIfNotNull("combinedStorageBandwidth", this._CombinedStorageBandwidth);
			kparams.AddIfNotNull("transcodingUsage", this._TranscodingUsage);
			kparams.AddIfNotNull("dateId", this._DateId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_ID:
					return "PartnerId";
				case PARTNER_NAME:
					return "PartnerName";
				case PARTNER_STATUS:
					return "PartnerStatus";
				case PARTNER_PACKAGE:
					return "PartnerPackage";
				case PARTNER_CREATED_AT:
					return "PartnerCreatedAt";
				case VIEWS:
					return "Views";
				case PLAYS:
					return "Plays";
				case ENTRIES_COUNT:
					return "EntriesCount";
				case TOTAL_ENTRIES_COUNT:
					return "TotalEntriesCount";
				case VIDEO_ENTRIES_COUNT:
					return "VideoEntriesCount";
				case IMAGE_ENTRIES_COUNT:
					return "ImageEntriesCount";
				case AUDIO_ENTRIES_COUNT:
					return "AudioEntriesCount";
				case MIX_ENTRIES_COUNT:
					return "MixEntriesCount";
				case BANDWIDTH:
					return "Bandwidth";
				case TOTAL_STORAGE:
					return "TotalStorage";
				case STORAGE:
					return "Storage";
				case DELETED_STORAGE:
					return "DeletedStorage";
				case PEAK_STORAGE:
					return "PeakStorage";
				case AVG_STORAGE:
					return "AvgStorage";
				case COMBINED_STORAGE_BANDWIDTH:
					return "CombinedStorageBandwidth";
				case TRANSCODING_USAGE:
					return "TranscodingUsage";
				case DATE_ID:
					return "DateId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

