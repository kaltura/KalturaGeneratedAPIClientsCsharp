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
	public class ConcatJobData : JobData
	{
		#region Constants
		public const string SRC_FILES = "srcFiles";
		public const string DEST_FILE_PATH = "destFilePath";
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string OFFSET = "offset";
		public const string DURATION = "duration";
		public const string CONCATENATED_DURATION = "concatenatedDuration";
		#endregion

		#region Private Fields
		private IList<String> _SrcFiles;
		private string _DestFilePath = null;
		private string _FlavorAssetId = null;
		private float _Offset = Single.MinValue;
		private float _Duration = Single.MinValue;
		private float _ConcatenatedDuration = Single.MinValue;
		#endregion

		#region Properties
		public IList<String> SrcFiles
		{
			get { return _SrcFiles; }
			set 
			{ 
				_SrcFiles = value;
				OnPropertyChanged("SrcFiles");
			}
		}
		public string DestFilePath
		{
			get { return _DestFilePath; }
			set 
			{ 
				_DestFilePath = value;
				OnPropertyChanged("DestFilePath");
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
		public float Offset
		{
			get { return _Offset; }
			set 
			{ 
				_Offset = value;
				OnPropertyChanged("Offset");
			}
		}
		public float Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		public float ConcatenatedDuration
		{
			get { return _ConcatenatedDuration; }
			set 
			{ 
				_ConcatenatedDuration = value;
				OnPropertyChanged("ConcatenatedDuration");
			}
		}
		#endregion

		#region CTor
		public ConcatJobData()
		{
		}

		public ConcatJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "srcFiles":
						this._SrcFiles = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._SrcFiles.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
					case "destFilePath":
						this._DestFilePath = propertyNode.InnerText;
						continue;
					case "flavorAssetId":
						this._FlavorAssetId = propertyNode.InnerText;
						continue;
					case "offset":
						this._Offset = ParseFloat(propertyNode.InnerText);
						continue;
					case "duration":
						this._Duration = ParseFloat(propertyNode.InnerText);
						continue;
					case "concatenatedDuration":
						this._ConcatenatedDuration = ParseFloat(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaConcatJobData");
			kparams.AddIfNotNull("srcFiles", this._SrcFiles);
			kparams.AddIfNotNull("destFilePath", this._DestFilePath);
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("offset", this._Offset);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("concatenatedDuration", this._ConcatenatedDuration);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SRC_FILES:
					return "SrcFiles";
				case DEST_FILE_PATH:
					return "DestFilePath";
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case OFFSET:
					return "Offset";
				case DURATION:
					return "Duration";
				case CONCATENATED_DURATION:
					return "ConcatenatedDuration";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

