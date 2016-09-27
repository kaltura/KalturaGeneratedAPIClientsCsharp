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
	public class KalturaConvertLiveSegmentJobData : KalturaJobData
	{
		#region Private Fields
		private string _EntryId = null;
		private string _AssetId = null;
		private KalturaEntryServerNodeType _MediaServerIndex = null;
		private int _FileIndex = Int32.MinValue;
		private string _SrcFilePath = null;
		private string _DestFilePath = null;
		private float _EndTime = Single.MinValue;
		private string _DestDataFilePath = null;
		#endregion

		#region Properties
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		public KalturaEntryServerNodeType MediaServerIndex
		{
			get { return _MediaServerIndex; }
			set 
			{ 
				_MediaServerIndex = value;
				OnPropertyChanged("MediaServerIndex");
			}
		}
		public int FileIndex
		{
			get { return _FileIndex; }
			set 
			{ 
				_FileIndex = value;
				OnPropertyChanged("FileIndex");
			}
		}
		public string SrcFilePath
		{
			get { return _SrcFilePath; }
			set 
			{ 
				_SrcFilePath = value;
				OnPropertyChanged("SrcFilePath");
			}
		}
		public string DestFilePath
		{
			get { return _DestFilePath; }
			set 
			{ 
				_DestFilePath = value;
				OnPropertyChanged("DestFilePath");
			}
		}
		public float EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		public string DestDataFilePath
		{
			get { return _DestDataFilePath; }
			set 
			{ 
				_DestDataFilePath = value;
				OnPropertyChanged("DestDataFilePath");
			}
		}
		#endregion

		#region CTor
		public KalturaConvertLiveSegmentJobData()
		{
		}

		public KalturaConvertLiveSegmentJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "entryId":
						this._EntryId = txt;
						continue;
					case "assetId":
						this._AssetId = txt;
						continue;
					case "mediaServerIndex":
						this._MediaServerIndex = (KalturaEntryServerNodeType)KalturaStringEnum.Parse(typeof(KalturaEntryServerNodeType), txt);
						continue;
					case "fileIndex":
						this._FileIndex = ParseInt(txt);
						continue;
					case "srcFilePath":
						this._SrcFilePath = txt;
						continue;
					case "destFilePath":
						this._DestFilePath = txt;
						continue;
					case "endTime":
						this._EndTime = ParseFloat(txt);
						continue;
					case "destDataFilePath":
						this._DestDataFilePath = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConvertLiveSegmentJobData");
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("mediaServerIndex", this._MediaServerIndex);
			kparams.AddIfNotNull("fileIndex", this._FileIndex);
			kparams.AddIfNotNull("srcFilePath", this._SrcFilePath);
			kparams.AddIfNotNull("destFilePath", this._DestFilePath);
			kparams.AddIfNotNull("endTime", this._EndTime);
			kparams.AddIfNotNull("destDataFilePath", this._DestDataFilePath);
			return kparams;
		}
		#endregion
	}
}

