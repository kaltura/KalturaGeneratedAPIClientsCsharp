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
	public class KalturaFileSyncDescriptor : KalturaObjectBase
	{
		#region Private Fields
		private string _FileSyncLocalPath = null;
		private string _FileSyncRemoteUrl = null;
		private int _FileSyncObjectSubType = Int32.MinValue;
		#endregion

		#region Properties
		public string FileSyncLocalPath
		{
			get { return _FileSyncLocalPath; }
			set 
			{ 
				_FileSyncLocalPath = value;
				OnPropertyChanged("FileSyncLocalPath");
			}
		}
		public string FileSyncRemoteUrl
		{
			get { return _FileSyncRemoteUrl; }
			set 
			{ 
				_FileSyncRemoteUrl = value;
				OnPropertyChanged("FileSyncRemoteUrl");
			}
		}
		public int FileSyncObjectSubType
		{
			get { return _FileSyncObjectSubType; }
			set 
			{ 
				_FileSyncObjectSubType = value;
				OnPropertyChanged("FileSyncObjectSubType");
			}
		}
		#endregion

		#region CTor
		public KalturaFileSyncDescriptor()
		{
		}

		public KalturaFileSyncDescriptor(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fileSyncLocalPath":
						this.FileSyncLocalPath = txt;
						continue;
					case "fileSyncRemoteUrl":
						this.FileSyncRemoteUrl = txt;
						continue;
					case "fileSyncObjectSubType":
						this.FileSyncObjectSubType = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFileSyncDescriptor");
			kparams.AddIfNotNull("fileSyncLocalPath", this.FileSyncLocalPath);
			kparams.AddIfNotNull("fileSyncRemoteUrl", this.FileSyncRemoteUrl);
			kparams.AddIfNotNull("fileSyncObjectSubType", this.FileSyncObjectSubType);
			return kparams;
		}
		#endregion
	}
}

