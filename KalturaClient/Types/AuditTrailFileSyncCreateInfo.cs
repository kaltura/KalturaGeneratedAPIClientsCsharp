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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class AuditTrailFileSyncCreateInfo : AuditTrailInfo
	{
		#region Constants
		public const string VERSION = "version";
		public const string OBJECT_SUB_TYPE = "objectSubType";
		public const string DC = "dc";
		public const string ORIGINAL = "original";
		public const string FILE_TYPE = "fileType";
		#endregion

		#region Private Fields
		private string _Version = null;
		private int _ObjectSubType = Int32.MinValue;
		private int _Dc = Int32.MinValue;
		private bool? _Original = null;
		private AuditTrailFileSyncType _FileType = (AuditTrailFileSyncType)Int32.MinValue;
		#endregion

		#region Properties
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
		public int Dc
		{
			get { return _Dc; }
			set 
			{ 
				_Dc = value;
				OnPropertyChanged("Dc");
			}
		}
		[JsonProperty]
		public bool? Original
		{
			get { return _Original; }
			set 
			{ 
				_Original = value;
				OnPropertyChanged("Original");
			}
		}
		[JsonProperty]
		public AuditTrailFileSyncType FileType
		{
			get { return _FileType; }
			set 
			{ 
				_FileType = value;
				OnPropertyChanged("FileType");
			}
		}
		#endregion

		#region CTor
		public AuditTrailFileSyncCreateInfo()
		{
		}

		public AuditTrailFileSyncCreateInfo(JToken node) : base(node)
		{
			if(node["version"] != null)
			{
				this._Version = node["version"].Value<string>();
			}
			if(node["objectSubType"] != null)
			{
				this._ObjectSubType = ParseInt(node["objectSubType"].Value<string>());
			}
			if(node["dc"] != null)
			{
				this._Dc = ParseInt(node["dc"].Value<string>());
			}
			if(node["original"] != null)
			{
				this._Original = ParseBool(node["original"].Value<string>());
			}
			if(node["fileType"] != null)
			{
				this._FileType = (AuditTrailFileSyncType)ParseEnum(typeof(AuditTrailFileSyncType), node["fileType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAuditTrailFileSyncCreateInfo");
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("objectSubType", this._ObjectSubType);
			kparams.AddIfNotNull("dc", this._Dc);
			kparams.AddIfNotNull("original", this._Original);
			kparams.AddIfNotNull("fileType", this._FileType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VERSION:
					return "Version";
				case OBJECT_SUB_TYPE:
					return "ObjectSubType";
				case DC:
					return "Dc";
				case ORIGINAL:
					return "Original";
				case FILE_TYPE:
					return "FileType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

