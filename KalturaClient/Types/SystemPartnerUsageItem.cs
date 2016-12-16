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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class SystemPartnerUsageItem : ObjectBase
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
		public const string PEAK_STORAGE = "peakStorage";
		public const string AVG_STORAGE = "avgStorage";
		public const string COMBINED_BANDWIDTH_STORAGE = "combinedBandwidthStorage";
		public const string DELETED_STORAGE = "deletedStorage";
		public const string TRANSCODING_USAGE = "transcodingUsage";
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
		private float _PeakStorage = Single.MinValue;
		private float _AvgStorage = Single.MinValue;
		private float _CombinedBandwidthStorage = Single.MinValue;
		private float _DeletedStorage = Single.MinValue;
		private float _TranscodingUsage = Single.MinValue;
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
		public float CombinedBandwidthStorage
		{
			get { return _CombinedBandwidthStorage; }
			set 
			{ 
				_CombinedBandwidthStorage = value;
				OnPropertyChanged("CombinedBandwidthStorage");
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
		public float TranscodingUsage
		{
			get { return _TranscodingUsage; }
			set 
			{ 
				_TranscodingUsage = value;
				OnPropertyChanged("TranscodingUsage");
			}
		}
		#endregion

		#region CTor
		public SystemPartnerUsageItem()
		{
		}

		public SystemPartnerUsageItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "partnerName":
						this._PartnerName = txt;
						continue;
					case "partnerStatus":
						this._PartnerStatus = (PartnerStatus)ParseEnum(typeof(PartnerStatus), txt);
						continue;
					case "partnerPackage":
						this._PartnerPackage = ParseInt(txt);
						continue;
					case "partnerCreatedAt":
						this._PartnerCreatedAt = ParseInt(txt);
						continue;
					case "views":
						this._Views = ParseInt(txt);
						continue;
					case "plays":
						this._Plays = ParseInt(txt);
						continue;
					case "entriesCount":
						this._EntriesCount = ParseInt(txt);
						continue;
					case "totalEntriesCount":
						this._TotalEntriesCount = ParseInt(txt);
						continue;
					case "videoEntriesCount":
						this._VideoEntriesCount = ParseInt(txt);
						continue;
					case "imageEntriesCount":
						this._ImageEntriesCount = ParseInt(txt);
						continue;
					case "audioEntriesCount":
						this._AudioEntriesCount = ParseInt(txt);
						continue;
					case "mixEntriesCount":
						this._MixEntriesCount = ParseInt(txt);
						continue;
					case "bandwidth":
						this._Bandwidth = ParseFloat(txt);
						continue;
					case "totalStorage":
						this._TotalStorage = ParseFloat(txt);
						continue;
					case "storage":
						this._Storage = ParseFloat(txt);
						continue;
					case "peakStorage":
						this._PeakStorage = ParseFloat(txt);
						continue;
					case "avgStorage":
						this._AvgStorage = ParseFloat(txt);
						continue;
					case "combinedBandwidthStorage":
						this._CombinedBandwidthStorage = ParseFloat(txt);
						continue;
					case "deletedStorage":
						this._DeletedStorage = ParseFloat(txt);
						continue;
					case "transcodingUsage":
						this._TranscodingUsage = ParseFloat(txt);
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
				kparams.AddReplace("objectType", "KalturaSystemPartnerUsageItem");
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
			kparams.AddIfNotNull("peakStorage", this._PeakStorage);
			kparams.AddIfNotNull("avgStorage", this._AvgStorage);
			kparams.AddIfNotNull("combinedBandwidthStorage", this._CombinedBandwidthStorage);
			kparams.AddIfNotNull("deletedStorage", this._DeletedStorage);
			kparams.AddIfNotNull("transcodingUsage", this._TranscodingUsage);
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
				case PEAK_STORAGE:
					return "PeakStorage";
				case AVG_STORAGE:
					return "AvgStorage";
				case COMBINED_BANDWIDTH_STORAGE:
					return "CombinedBandwidthStorage";
				case DELETED_STORAGE:
					return "DeletedStorage";
				case TRANSCODING_USAGE:
					return "TranscodingUsage";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

