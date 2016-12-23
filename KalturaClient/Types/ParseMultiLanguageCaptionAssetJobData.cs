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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class ParseMultiLanguageCaptionAssetJobData : JobData
	{
		#region Constants
		public const string MULTI_LANAGUAGE_CAPTION_ASSET_ID = "multiLanaguageCaptionAssetId";
		public const string ENTRY_ID = "entryId";
		public const string FILE_LOCATION = "fileLocation";
		#endregion

		#region Private Fields
		private string _MultiLanaguageCaptionAssetId = null;
		private string _EntryId = null;
		private string _FileLocation = null;
		#endregion

		#region Properties
		public string MultiLanaguageCaptionAssetId
		{
			get { return _MultiLanaguageCaptionAssetId; }
			set 
			{ 
				_MultiLanaguageCaptionAssetId = value;
				OnPropertyChanged("MultiLanaguageCaptionAssetId");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public string FileLocation
		{
			get { return _FileLocation; }
			set 
			{ 
				_FileLocation = value;
				OnPropertyChanged("FileLocation");
			}
		}
		#endregion

		#region CTor
		public ParseMultiLanguageCaptionAssetJobData()
		{
		}

		public ParseMultiLanguageCaptionAssetJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "multiLanaguageCaptionAssetId":
						this._MultiLanaguageCaptionAssetId = propertyNode.InnerText;
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "fileLocation":
						this._FileLocation = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaParseMultiLanguageCaptionAssetJobData");
			kparams.AddIfNotNull("multiLanaguageCaptionAssetId", this._MultiLanaguageCaptionAssetId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("fileLocation", this._FileLocation);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MULTI_LANAGUAGE_CAPTION_ASSET_ID:
					return "MultiLanaguageCaptionAssetId";
				case ENTRY_ID:
					return "EntryId";
				case FILE_LOCATION:
					return "FileLocation";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

