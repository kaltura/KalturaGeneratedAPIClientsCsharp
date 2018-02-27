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
		public string Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
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
		public int Dc
		{
			get { return _Dc; }
			set 
			{ 
				_Dc = value;
				OnPropertyChanged("Dc");
			}
		}
		public bool? Original
		{
			get { return _Original; }
			set 
			{ 
				_Original = value;
				OnPropertyChanged("Original");
			}
		}
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

		public AuditTrailFileSyncCreateInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "version":
						this._Version = propertyNode.InnerText;
						continue;
					case "objectSubType":
						this._ObjectSubType = ParseInt(propertyNode.InnerText);
						continue;
					case "dc":
						this._Dc = ParseInt(propertyNode.InnerText);
						continue;
					case "original":
						this._Original = ParseBool(propertyNode.InnerText);
						continue;
					case "fileType":
						this._FileType = (AuditTrailFileSyncType)ParseEnum(typeof(AuditTrailFileSyncType), propertyNode.InnerText);
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

