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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class ScheduledTaskJobData : JobData
	{
		#region Constants
		public const string MAX_RESULTS = "maxResults";
		public const string TOTAL_COUNT = "totalCount";
		public const string FILE_FORMAT = "fileFormat";
		public const string RESULTS_FILE_PATH = "resultsFilePath";
		public const string REFERENCE_TIME = "referenceTime";
		#endregion

		#region Private Fields
		private int _MaxResults = Int32.MinValue;
		private int _TotalCount = Int32.MinValue;
		private DryRunFileType _FileFormat = (DryRunFileType)Int32.MinValue;
		private string _ResultsFilePath = null;
		private int _ReferenceTime = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int MaxResults
		{
			get { return _MaxResults; }
			set 
			{ 
				_MaxResults = value;
				OnPropertyChanged("MaxResults");
			}
		}
		[JsonProperty]
		public int TotalCount
		{
			get { return _TotalCount; }
			set 
			{ 
				_TotalCount = value;
				OnPropertyChanged("TotalCount");
			}
		}
		[JsonProperty]
		public DryRunFileType FileFormat
		{
			get { return _FileFormat; }
			set 
			{ 
				_FileFormat = value;
				OnPropertyChanged("FileFormat");
			}
		}
		[JsonProperty]
		public string ResultsFilePath
		{
			get { return _ResultsFilePath; }
			set 
			{ 
				_ResultsFilePath = value;
				OnPropertyChanged("ResultsFilePath");
			}
		}
		[JsonProperty]
		public int ReferenceTime
		{
			get { return _ReferenceTime; }
			set 
			{ 
				_ReferenceTime = value;
				OnPropertyChanged("ReferenceTime");
			}
		}
		#endregion

		#region CTor
		public ScheduledTaskJobData()
		{
		}

		public ScheduledTaskJobData(JToken node) : base(node)
		{
			if(node["maxResults"] != null)
			{
				this._MaxResults = ParseInt(node["maxResults"].Value<string>());
			}
			if(node["totalCount"] != null)
			{
				this._TotalCount = ParseInt(node["totalCount"].Value<string>());
			}
			if(node["fileFormat"] != null)
			{
				this._FileFormat = (DryRunFileType)ParseEnum(typeof(DryRunFileType), node["fileFormat"].Value<string>());
			}
			if(node["resultsFilePath"] != null)
			{
				this._ResultsFilePath = node["resultsFilePath"].Value<string>();
			}
			if(node["referenceTime"] != null)
			{
				this._ReferenceTime = ParseInt(node["referenceTime"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaScheduledTaskJobData");
			kparams.AddIfNotNull("maxResults", this._MaxResults);
			kparams.AddIfNotNull("totalCount", this._TotalCount);
			kparams.AddIfNotNull("fileFormat", this._FileFormat);
			kparams.AddIfNotNull("resultsFilePath", this._ResultsFilePath);
			kparams.AddIfNotNull("referenceTime", this._ReferenceTime);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MAX_RESULTS:
					return "MaxResults";
				case TOTAL_COUNT:
					return "TotalCount";
				case FILE_FORMAT:
					return "FileFormat";
				case RESULTS_FILE_PATH:
					return "ResultsFilePath";
				case REFERENCE_TIME:
					return "ReferenceTime";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

