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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
		[JsonProperty]
		public int FileSyncObjectType
		{
			get { return _FileSyncObjectType; }
			set 
			{ 
				_FileSyncObjectType = value;
				OnPropertyChanged("FileSyncObjectType");
			}
		}
		[JsonProperty]
		public int ObjectSubType
		{
			get { return _ObjectSubType; }
			set 
			{ 
				_ObjectSubType = value;
				OnPropertyChanged("ObjectSubType");
			}
		}
		[JsonProperty]
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		[JsonProperty]
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

		public FileSyncResource(JToken node) : base(node)
		{
			if(node["fileSyncObjectType"] != null)
			{
				this._FileSyncObjectType = ParseInt(node["fileSyncObjectType"].Value<string>());
			}
			if(node["objectSubType"] != null)
			{
				this._ObjectSubType = ParseInt(node["objectSubType"].Value<string>());
			}
			if(node["objectId"] != null)
			{
				this._ObjectId = node["objectId"].Value<string>();
			}
			if(node["version"] != null)
			{
				this._Version = node["version"].Value<string>();
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

