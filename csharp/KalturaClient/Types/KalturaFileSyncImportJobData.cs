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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaFileSyncImportJobData : KalturaJobData
	{
		#region Private Fields
		private string _SourceUrl = null;
		private string _FilesyncId = null;
		private string _TmpFilePath = null;
		private string _DestFilePath = null;
		private int _FileSize = Int32.MinValue;
		#endregion

		#region Properties
		public string SourceUrl
		{
			get { return _SourceUrl; }
			set 
			{ 
				_SourceUrl = value;
				OnPropertyChanged("SourceUrl");
			}
		}
		public string FilesyncId
		{
			get { return _FilesyncId; }
			set 
			{ 
				_FilesyncId = value;
				OnPropertyChanged("FilesyncId");
			}
		}
		public string TmpFilePath
		{
			get { return _TmpFilePath; }
			set 
			{ 
				_TmpFilePath = value;
				OnPropertyChanged("TmpFilePath");
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
		public int FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		#endregion

		#region CTor
		public KalturaFileSyncImportJobData()
		{
		}

		public KalturaFileSyncImportJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "sourceUrl":
						this.SourceUrl = txt;
						continue;
					case "filesyncId":
						this.FilesyncId = txt;
						continue;
					case "tmpFilePath":
						this.TmpFilePath = txt;
						continue;
					case "destFilePath":
						this.DestFilePath = txt;
						continue;
					case "fileSize":
						this.FileSize = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFileSyncImportJobData");
			kparams.AddStringIfNotNull("sourceUrl", this.SourceUrl);
			kparams.AddStringIfNotNull("filesyncId", this.FilesyncId);
			kparams.AddStringIfNotNull("tmpFilePath", this.TmpFilePath);
			kparams.AddStringIfNotNull("destFilePath", this.DestFilePath);
			kparams.AddIntIfNotNull("fileSize", this.FileSize);
			return kparams;
		}
		#endregion
	}
}

