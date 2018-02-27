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
	public class FileSyncResource : ContentResource
	{
		#region Constants
		public const string FILE_SYNC_OBJECT_TYPE = "fileSyncObjectType";
		public const string OBJECT_SUB_TYPE = "objectSubType";
		public const string OBJECT_ID = "objectId";
		public const string VERSION = "version";
		#endregion

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
		public FileSyncResource()
		{
		}

		public FileSyncResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "fileSyncObjectType":
						this._FileSyncObjectType = ParseInt(propertyNode.InnerText);
						continue;
					case "objectSubType":
						this._ObjectSubType = ParseInt(propertyNode.InnerText);
						continue;
					case "objectId":
						this._ObjectId = propertyNode.InnerText;
						continue;
					case "version":
						this._Version = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaFileSyncResource");
			kparams.AddIfNotNull("fileSyncObjectType", this._FileSyncObjectType);
			kparams.AddIfNotNull("objectSubType", this._ObjectSubType);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("version", this._Version);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILE_SYNC_OBJECT_TYPE:
					return "FileSyncObjectType";
				case OBJECT_SUB_TYPE:
					return "ObjectSubType";
				case OBJECT_ID:
					return "ObjectId";
				case VERSION:
					return "Version";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

