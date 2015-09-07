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
	public class KalturaCaptureThumbJobData : KalturaJobData
	{
		#region Private Fields
		private string _SrcFileSyncLocalPath = null;
		private string _ActualSrcFileSyncLocalPath = null;
		private string _SrcFileSyncRemoteUrl = null;
		private int _ThumbParamsOutputId = Int32.MinValue;
		private string _ThumbAssetId = null;
		private string _SrcAssetId = null;
		private KalturaAssetType _SrcAssetType = null;
		private string _ThumbPath = null;
		#endregion

		#region Properties
		public string SrcFileSyncLocalPath
		{
			get { return _SrcFileSyncLocalPath; }
			set 
			{ 
				_SrcFileSyncLocalPath = value;
				OnPropertyChanged("SrcFileSyncLocalPath");
			}
		}
		public string ActualSrcFileSyncLocalPath
		{
			get { return _ActualSrcFileSyncLocalPath; }
			set 
			{ 
				_ActualSrcFileSyncLocalPath = value;
				OnPropertyChanged("ActualSrcFileSyncLocalPath");
			}
		}
		public string SrcFileSyncRemoteUrl
		{
			get { return _SrcFileSyncRemoteUrl; }
			set 
			{ 
				_SrcFileSyncRemoteUrl = value;
				OnPropertyChanged("SrcFileSyncRemoteUrl");
			}
		}
		public int ThumbParamsOutputId
		{
			get { return _ThumbParamsOutputId; }
			set 
			{ 
				_ThumbParamsOutputId = value;
				OnPropertyChanged("ThumbParamsOutputId");
			}
		}
		public string ThumbAssetId
		{
			get { return _ThumbAssetId; }
			set 
			{ 
				_ThumbAssetId = value;
				OnPropertyChanged("ThumbAssetId");
			}
		}
		public string SrcAssetId
		{
			get { return _SrcAssetId; }
			set 
			{ 
				_SrcAssetId = value;
				OnPropertyChanged("SrcAssetId");
			}
		}
		public KalturaAssetType SrcAssetType
		{
			get { return _SrcAssetType; }
			set 
			{ 
				_SrcAssetType = value;
				OnPropertyChanged("SrcAssetType");
			}
		}
		public string ThumbPath
		{
			get { return _ThumbPath; }
			set 
			{ 
				_ThumbPath = value;
				OnPropertyChanged("ThumbPath");
			}
		}
		#endregion

		#region CTor
		public KalturaCaptureThumbJobData()
		{
		}

		public KalturaCaptureThumbJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "srcFileSyncLocalPath":
						this.SrcFileSyncLocalPath = txt;
						continue;
					case "actualSrcFileSyncLocalPath":
						this.ActualSrcFileSyncLocalPath = txt;
						continue;
					case "srcFileSyncRemoteUrl":
						this.SrcFileSyncRemoteUrl = txt;
						continue;
					case "thumbParamsOutputId":
						this.ThumbParamsOutputId = ParseInt(txt);
						continue;
					case "thumbAssetId":
						this.ThumbAssetId = txt;
						continue;
					case "srcAssetId":
						this.SrcAssetId = txt;
						continue;
					case "srcAssetType":
						this.SrcAssetType = (KalturaAssetType)KalturaStringEnum.Parse(typeof(KalturaAssetType), txt);
						continue;
					case "thumbPath":
						this.ThumbPath = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCaptureThumbJobData");
			kparams.AddIfNotNull("srcFileSyncLocalPath", this.SrcFileSyncLocalPath);
			kparams.AddIfNotNull("actualSrcFileSyncLocalPath", this.ActualSrcFileSyncLocalPath);
			kparams.AddIfNotNull("srcFileSyncRemoteUrl", this.SrcFileSyncRemoteUrl);
			kparams.AddIfNotNull("thumbParamsOutputId", this.ThumbParamsOutputId);
			kparams.AddIfNotNull("thumbAssetId", this.ThumbAssetId);
			kparams.AddIfNotNull("srcAssetId", this.SrcAssetId);
			kparams.AddIfNotNull("srcAssetType", this.SrcAssetType);
			kparams.AddIfNotNull("thumbPath", this.ThumbPath);
			return kparams;
		}
		#endregion
	}
}

