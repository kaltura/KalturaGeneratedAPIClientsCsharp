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
	public class VirusScanJobData : JobData
	{
		#region Constants
		public const string SRC_FILE_PATH = "srcFilePath";
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string SCAN_RESULT = "scanResult";
		public const string VIRUS_FOUND_ACTION = "virusFoundAction";
		#endregion

		#region Private Fields
		private string _SrcFilePath = null;
		private string _FlavorAssetId = null;
		private VirusScanJobResult _ScanResult = (VirusScanJobResult)Int32.MinValue;
		private VirusFoundAction _VirusFoundAction = (VirusFoundAction)Int32.MinValue;
		#endregion

		#region Properties
		public string SrcFilePath
		{
			get { return _SrcFilePath; }
			set 
			{ 
				_SrcFilePath = value;
				OnPropertyChanged("SrcFilePath");
			}
		}
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public VirusScanJobResult ScanResult
		{
			get { return _ScanResult; }
			set 
			{ 
				_ScanResult = value;
				OnPropertyChanged("ScanResult");
			}
		}
		public VirusFoundAction VirusFoundAction
		{
			get { return _VirusFoundAction; }
			set 
			{ 
				_VirusFoundAction = value;
				OnPropertyChanged("VirusFoundAction");
			}
		}
		#endregion

		#region CTor
		public VirusScanJobData()
		{
		}

		public VirusScanJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "srcFilePath":
						this._SrcFilePath = propertyNode.InnerText;
						continue;
					case "flavorAssetId":
						this._FlavorAssetId = propertyNode.InnerText;
						continue;
					case "scanResult":
						this._ScanResult = (VirusScanJobResult)ParseEnum(typeof(VirusScanJobResult), propertyNode.InnerText);
						continue;
					case "virusFoundAction":
						this._VirusFoundAction = (VirusFoundAction)ParseEnum(typeof(VirusFoundAction), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaVirusScanJobData");
			kparams.AddIfNotNull("srcFilePath", this._SrcFilePath);
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("scanResult", this._ScanResult);
			kparams.AddIfNotNull("virusFoundAction", this._VirusFoundAction);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SRC_FILE_PATH:
					return "SrcFilePath";
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case SCAN_RESULT:
					return "ScanResult";
				case VIRUS_FOUND_ACTION:
					return "VirusFoundAction";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

