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
	public class KalturaFileSyncResource : KalturaContentResource
	{
		#region Private Fields
		private int _FileSyncObjectType = Int32.MinValue;
		private int _ObjectSubType = Int32.MinValue;
		private string _ObjectId = null;
		private string _Version = null;
		#endregion

		#region Properties
		public int FileSyncObjectType
		{
			get { return _FileSyncObjectType; }
			set 
			{ 
				_FileSyncObjectType = value;
				OnPropertyChanged("FileSyncObjectType");
			}
		}
		public int ObjectSubType
		{
			get { return _ObjectSubType; }
			set 
			{ 
				_ObjectSubType = value;
				OnPropertyChanged("ObjectSubType");
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
		public string Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		#endregion

		#region CTor
		public KalturaFileSyncResource()
		{
		}

		public KalturaFileSyncResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fileSyncObjectType":
						this._FileSyncObjectType = ParseInt(txt);
						continue;
					case "objectSubType":
						this._ObjectSubType = ParseInt(txt);
						continue;
					case "objectId":
						this._ObjectId = txt;
						continue;
					case "version":
						this._Version = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFileSyncResource");
			kparams.AddIfNotNull("fileSyncObjectType", this.FileSyncObjectType);
			kparams.AddIfNotNull("objectSubType", this.ObjectSubType);
			kparams.AddIfNotNull("objectId", this.ObjectId);
			kparams.AddIfNotNull("version", this.Version);
			return kparams;
		}
		#endregion
	}
}

