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
	public class ExportCsvJobData : JobData
	{
		#region Constants
		public const string USER_NAME = "userName";
		public const string USER_MAIL = "userMail";
		public const string OUTPUT_PATH = "outputPath";
		public const string SHARED_OUTPUT_PATH = "sharedOutputPath";
		#endregion

		#region Private Fields
		private string _UserName = null;
		private string _UserMail = null;
		private string _OutputPath = null;
		private string _SharedOutputPath = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use UserNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserName
		{
			get { return _UserName; }
			set 
			{ 
				_UserName = value;
				OnPropertyChanged("UserName");
			}
		}
		/// <summary>
		/// Use UserMailAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserMail
		{
			get { return _UserMail; }
			set 
			{ 
				_UserMail = value;
				OnPropertyChanged("UserMail");
			}
		}
		/// <summary>
		/// Use OutputPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OutputPath
		{
			get { return _OutputPath; }
			set 
			{ 
				_OutputPath = value;
				OnPropertyChanged("OutputPath");
			}
		}
		/// <summary>
		/// Use SharedOutputPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SharedOutputPath
		{
			get { return _SharedOutputPath; }
			set 
			{ 
				_SharedOutputPath = value;
				OnPropertyChanged("SharedOutputPath");
			}
		}
		#endregion

		#region CTor
		public ExportCsvJobData()
		{
		}

		public ExportCsvJobData(JToken node) : base(node)
		{
			if(node["userName"] != null)
			{
				this._UserName = node["userName"].Value<string>();
			}
			if(node["userMail"] != null)
			{
				this._UserMail = node["userMail"].Value<string>();
			}
			if(node["outputPath"] != null)
			{
				this._OutputPath = node["outputPath"].Value<string>();
			}
			if(node["sharedOutputPath"] != null)
			{
				this._SharedOutputPath = node["sharedOutputPath"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaExportCsvJobData");
			kparams.AddIfNotNull("userName", this._UserName);
			kparams.AddIfNotNull("userMail", this._UserMail);
			kparams.AddIfNotNull("outputPath", this._OutputPath);
			kparams.AddIfNotNull("sharedOutputPath", this._SharedOutputPath);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_NAME:
					return "UserName";
				case USER_MAIL:
					return "UserMail";
				case OUTPUT_PATH:
					return "OutputPath";
				case SHARED_OUTPUT_PATH:
					return "SharedOutputPath";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

