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
	public class KalturaAuditTrailFileSyncCreateInfo : KalturaAuditTrailInfo
	{
		#region Private Fields
		private string _Version = null;
		private int _ObjectSubType = Int32.MinValue;
		private int _Dc = Int32.MinValue;
		private bool? _Original = false;
		private KalturaAuditTrailFileSyncType _FileType = (KalturaAuditTrailFileSyncType)Int32.MinValue;
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
		public KalturaAuditTrailFileSyncType FileType
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
		public KalturaAuditTrailFileSyncCreateInfo()
		{
		}

		public KalturaAuditTrailFileSyncCreateInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "version":
						this.Version = txt;
						continue;
					case "objectSubType":
						this.ObjectSubType = ParseInt(txt);
						continue;
					case "dc":
						this.Dc = ParseInt(txt);
						continue;
					case "original":
						this.Original = ParseBool(txt);
						continue;
					case "fileType":
						this.FileType = (KalturaAuditTrailFileSyncType)ParseEnum(typeof(KalturaAuditTrailFileSyncType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAuditTrailFileSyncCreateInfo");
			kparams.AddStringIfNotNull("version", this.Version);
			kparams.AddIntIfNotNull("objectSubType", this.ObjectSubType);
			kparams.AddIntIfNotNull("dc", this.Dc);
			kparams.AddBoolIfNotNull("original", this.Original);
			kparams.AddEnumIfNotNull("fileType", this.FileType);
			return kparams;
		}
		#endregion
	}
}

