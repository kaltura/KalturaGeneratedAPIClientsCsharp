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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaVarPartnerUsageItem : KalturaObjectBase
	{
		#region Private Fields
		private int _PartnerId = Int32.MinValue;
		private string _PartnerName = null;
		private KalturaPartnerStatus _PartnerStatus = (KalturaPartnerStatus)Int32.MinValue;
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
		public KalturaPartnerStatus PartnerStatus
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
		public KalturaVarPartnerUsageItem()
		{
		}

		public KalturaVarPartnerUsageItem(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "partnerName":
						this.PartnerName = txt;
						continue;
					case "partnerStatus":
						this.PartnerStatus = (KalturaPartnerStatus)ParseEnum(typeof(KalturaPartnerStatus), txt);
						continue;
					case "partnerPackage":
						this.PartnerPackage = ParseInt(txt);
						continue;
					case "partnerCreatedAt":
						this.PartnerCreatedAt = ParseInt(txt);
						continue;
					case "views":
						this.Views = ParseInt(txt);
						continue;
					case "plays":
						this.Plays = ParseInt(txt);
						continue;
					case "entriesCount":
						this.EntriesCount = ParseInt(txt);
						continue;
					case "totalEntriesCount":
						this.TotalEntriesCount = ParseInt(txt);
						continue;
					case "videoEntriesCount":
						this.VideoEntriesCount = ParseInt(txt);
						continue;
					case "imageEntriesCount":
						this.ImageEntriesCount = ParseInt(txt);
						continue;
					case "audioEntriesCount":
						this.AudioEntriesCount = ParseInt(txt);
						continue;
					case "mixEntriesCount":
						this.MixEntriesCount = ParseInt(txt);
						continue;
					case "bandwidth":
						this.Bandwidth = ParseFloat(txt);
						continue;
					case "totalStorage":
						this.TotalStorage = ParseFloat(txt);
						continue;
					case "storage":
						this.Storage = ParseFloat(txt);
						continue;
					case "deletedStorage":
						this.DeletedStorage = ParseFloat(txt);
						continue;
					case "peakStorage":
						this.PeakStorage = ParseFloat(txt);
						continue;
					case "avgStorage":
						this.AvgStorage = ParseFloat(txt);
						continue;
					case "combinedStorageBandwidth":
						this.CombinedStorageBandwidth = ParseFloat(txt);
						continue;
					case "transcodingUsage":
						this.TranscodingUsage = ParseFloat(txt);
						continue;
					case "dateId":
						this.DateId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaVarPartnerUsageItem");
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("partnerName", this.PartnerName);
			kparams.AddEnumIfNotNull("partnerStatus", this.PartnerStatus);
			kparams.AddIntIfNotNull("partnerPackage", this.PartnerPackage);
			kparams.AddIntIfNotNull("partnerCreatedAt", this.PartnerCreatedAt);
			kparams.AddIntIfNotNull("views", this.Views);
			kparams.AddIntIfNotNull("plays", this.Plays);
			kparams.AddIntIfNotNull("entriesCount", this.EntriesCount);
			kparams.AddIntIfNotNull("totalEntriesCount", this.TotalEntriesCount);
			kparams.AddIntIfNotNull("videoEntriesCount", this.VideoEntriesCount);
			kparams.AddIntIfNotNull("imageEntriesCount", this.ImageEntriesCount);
			kparams.AddIntIfNotNull("audioEntriesCount", this.AudioEntriesCount);
			kparams.AddIntIfNotNull("mixEntriesCount", this.MixEntriesCount);
			kparams.AddFloatIfNotNull("bandwidth", this.Bandwidth);
			kparams.AddFloatIfNotNull("totalStorage", this.TotalStorage);
			kparams.AddFloatIfNotNull("storage", this.Storage);
			kparams.AddFloatIfNotNull("deletedStorage", this.DeletedStorage);
			kparams.AddFloatIfNotNull("peakStorage", this.PeakStorage);
			kparams.AddFloatIfNotNull("avgStorage", this.AvgStorage);
			kparams.AddFloatIfNotNull("combinedStorageBandwidth", this.CombinedStorageBandwidth);
			kparams.AddFloatIfNotNull("transcodingUsage", this.TranscodingUsage);
			kparams.AddStringIfNotNull("dateId", this.DateId);
			return kparams;
		}
		#endregion
	}
}

