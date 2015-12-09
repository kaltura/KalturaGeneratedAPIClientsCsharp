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
	public class KalturaConvertLiveSegmentJobData : KalturaJobData
	{
		#region Private Fields
		private string _EntryId = null;
		private string _AssetId = null;
		private KalturaMediaServerIndex _MediaServerIndex = (KalturaMediaServerIndex)Int32.MinValue;
		private int _FileIndex = Int32.MinValue;
		private string _SrcFilePath = null;
		private string _DestFilePath = null;
		private float _EndTime = Single.MinValue;
		private IList<KalturaKeyValue> _AmfArray;
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
		public KalturaMediaServerIndex MediaServerIndex
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
		public IList<KalturaKeyValue> AmfArray
		{
			get { return _AmfArray; }
			set 
			{ 
				_AmfArray = value;
				OnPropertyChanged("AmfArray");
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
						this.EntryId = txt;
						continue;
					case "assetId":
						this.AssetId = txt;
						continue;
					case "mediaServerIndex":
						this.MediaServerIndex = (KalturaMediaServerIndex)ParseEnum(typeof(KalturaMediaServerIndex), txt);
						continue;
					case "fileIndex":
						this.FileIndex = ParseInt(txt);
						continue;
					case "srcFilePath":
						this.SrcFilePath = txt;
						continue;
					case "destFilePath":
						this.DestFilePath = txt;
						continue;
					case "endTime":
						this.EndTime = ParseFloat(txt);
						continue;
					case "amfArray":
						this.AmfArray = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.AmfArray.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
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
			kparams.AddIfNotNull("entryId", this.EntryId);
			kparams.AddIfNotNull("assetId", this.AssetId);
			kparams.AddIfNotNull("mediaServerIndex", this.MediaServerIndex);
			kparams.AddIfNotNull("fileIndex", this.FileIndex);
			kparams.AddIfNotNull("srcFilePath", this.SrcFilePath);
			kparams.AddIfNotNull("destFilePath", this.DestFilePath);
			kparams.AddIfNotNull("endTime", this.EndTime);
			kparams.AddIfNotNull("amfArray", this.AmfArray);
			return kparams;
		}
		#endregion
	}
}

