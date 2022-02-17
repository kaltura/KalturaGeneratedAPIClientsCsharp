// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class ConcatJobData : JobData
	{
		#region Constants
		public const string SRC_FILES = "srcFiles";
		public const string DEST_FILE_PATH = "destFilePath";
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string OFFSET = "offset";
		public const string DURATION = "duration";
		public const string CONCATENATED_DURATION = "concatenatedDuration";
		public const string SHOULD_SORT = "shouldSort";
		#endregion

		#region Private Fields
		private IList<String> _SrcFiles;
		private string _DestFilePath = null;
		private string _FlavorAssetId = null;
		private double _Offset = Double.MinValue;
		private double _Duration = Double.MinValue;
		private double _ConcatenatedDuration = Double.MinValue;
		private bool? _ShouldSort = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use SrcFilesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<String> SrcFiles
		{
			get { return _SrcFiles; }
			set 
			{ 
				_SrcFiles = value;
				OnPropertyChanged("SrcFiles");
			}
		}
		/// <summary>
		/// Use DestFilePathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DestFilePath
		{
			get { return _DestFilePath; }
			set 
			{ 
				_DestFilePath = value;
				OnPropertyChanged("DestFilePath");
			}
		}
		/// <summary>
		/// Use FlavorAssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		/// <summary>
		/// Use OffsetAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double Offset
		{
			get { return _Offset; }
			set 
			{ 
				_Offset = value;
				OnPropertyChanged("Offset");
			}
		}
		/// <summary>
		/// Use DurationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		/// <summary>
		/// Use ConcatenatedDurationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double ConcatenatedDuration
		{
			get { return _ConcatenatedDuration; }
			set 
			{ 
				_ConcatenatedDuration = value;
				OnPropertyChanged("ConcatenatedDuration");
			}
		}
		/// <summary>
		/// Use ShouldSortAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? ShouldSort
		{
			get { return _ShouldSort; }
			set 
			{ 
				_ShouldSort = value;
				OnPropertyChanged("ShouldSort");
			}
		}
		#endregion

		#region CTor
		public ConcatJobData()
		{
		}

		public ConcatJobData(JToken node) : base(node)
		{
			if(node["srcFiles"] != null)
			{
				this._SrcFiles = new List<String>();
				foreach(var arrayNode in node["srcFiles"].Children())
				{
					this._SrcFiles.Add(ObjectFactory.Create<String>(arrayNode));
				}
			}
			if(node["destFilePath"] != null)
			{
				this._DestFilePath = node["destFilePath"].Value<string>();
			}
			if(node["flavorAssetId"] != null)
			{
				this._FlavorAssetId = node["flavorAssetId"].Value<string>();
			}
			if(node["offset"] != null)
			{
				this._Offset = ParseDouble(node["offset"].Value<string>());
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseDouble(node["duration"].Value<string>());
			}
			if(node["concatenatedDuration"] != null)
			{
				this._ConcatenatedDuration = ParseDouble(node["concatenatedDuration"].Value<string>());
			}
			if(node["shouldSort"] != null)
			{
				this._ShouldSort = ParseBool(node["shouldSort"].Value<string>());
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
			kparams.AddIfNotNull("shouldSort", this._ShouldSort);
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
				case SHOULD_SORT:
					return "ShouldSort";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

