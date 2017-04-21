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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class ImportMetadataJobData : JobData
	{
		#region Constants
		public const string SRC_FILE_URL = "srcFileUrl";
		public const string DEST_FILE_LOCAL_PATH = "destFileLocalPath";
		public const string METADATA_ID = "metadataId";
		#endregion

		#region Private Fields
		private string _SrcFileUrl = null;
		private string _DestFileLocalPath = null;
		private int _MetadataId = Int32.MinValue;
		#endregion

		#region Properties
		public string SrcFileUrl
		{
			get { return _SrcFileUrl; }
			set 
			{ 
				_SrcFileUrl = value;
				OnPropertyChanged("SrcFileUrl");
			}
		}
		public string DestFileLocalPath
		{
			get { return _DestFileLocalPath; }
			set 
			{ 
				_DestFileLocalPath = value;
				OnPropertyChanged("DestFileLocalPath");
			}
		}
		public int MetadataId
		{
			get { return _MetadataId; }
			set 
			{ 
				_MetadataId = value;
				OnPropertyChanged("MetadataId");
			}
		}
		#endregion

		#region CTor
		public ImportMetadataJobData()
		{
		}

		public ImportMetadataJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "srcFileUrl":
						this._SrcFileUrl = propertyNode.InnerText;
						continue;
					case "destFileLocalPath":
						this._DestFileLocalPath = propertyNode.InnerText;
						continue;
					case "metadataId":
						this._MetadataId = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaImportMetadataJobData");
			kparams.AddIfNotNull("srcFileUrl", this._SrcFileUrl);
			kparams.AddIfNotNull("destFileLocalPath", this._DestFileLocalPath);
			kparams.AddIfNotNull("metadataId", this._MetadataId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SRC_FILE_URL:
					return "SrcFileUrl";
				case DEST_FILE_LOCAL_PATH:
					return "DestFileLocalPath";
				case METADATA_ID:
					return "MetadataId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

