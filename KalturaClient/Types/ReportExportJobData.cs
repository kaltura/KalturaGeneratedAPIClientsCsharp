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
	public class ReportExportJobData : JobData
	{
		#region Constants
		public const string RECIPIENT_EMAIL = "recipientEmail";
		public const string REPORT_ITEMS = "reportItems";
		public const string FILE_PATHS = "filePaths";
		public const string REPORTS_GROUP = "reportsGroup";
		public const string FILES = "files";
		public const string BASE_URL = "baseUrl";
		#endregion

		#region Private Fields
		private string _RecipientEmail = null;
		private IList<ReportExportItem> _ReportItems;
		private string _FilePaths = null;
		private string _ReportsGroup = null;
		private IList<ReportExportFile> _Files;
		private string _BaseUrl = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use RecipientEmailAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RecipientEmail
		{
			get { return _RecipientEmail; }
			set 
			{ 
				_RecipientEmail = value;
				OnPropertyChanged("RecipientEmail");
			}
		}
		/// <summary>
		/// Use ReportItemsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ReportExportItem> ReportItems
		{
			get { return _ReportItems; }
			set 
			{ 
				_ReportItems = value;
				OnPropertyChanged("ReportItems");
			}
		}
		/// <summary>
		/// Use FilePathsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FilePaths
		{
			get { return _FilePaths; }
			set 
			{ 
				_FilePaths = value;
				OnPropertyChanged("FilePaths");
			}
		}
		/// <summary>
		/// Use ReportsGroupAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ReportsGroup
		{
			get { return _ReportsGroup; }
			set 
			{ 
				_ReportsGroup = value;
				OnPropertyChanged("ReportsGroup");
			}
		}
		/// <summary>
		/// Use FilesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ReportExportFile> Files
		{
			get { return _Files; }
			set 
			{ 
				_Files = value;
				OnPropertyChanged("Files");
			}
		}
		/// <summary>
		/// Use BaseUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string BaseUrl
		{
			get { return _BaseUrl; }
			set 
			{ 
				_BaseUrl = value;
				OnPropertyChanged("BaseUrl");
			}
		}
		#endregion

		#region CTor
		public ReportExportJobData()
		{
		}

		public ReportExportJobData(JToken node) : base(node)
		{
			if(node["recipientEmail"] != null)
			{
				this._RecipientEmail = node["recipientEmail"].Value<string>();
			}
			if(node["reportItems"] != null)
			{
				this._ReportItems = new List<ReportExportItem>();
				foreach(var arrayNode in node["reportItems"].Children())
				{
					this._ReportItems.Add(ObjectFactory.Create<ReportExportItem>(arrayNode));
				}
			}
			if(node["filePaths"] != null)
			{
				this._FilePaths = node["filePaths"].Value<string>();
			}
			if(node["reportsGroup"] != null)
			{
				this._ReportsGroup = node["reportsGroup"].Value<string>();
			}
			if(node["files"] != null)
			{
				this._Files = new List<ReportExportFile>();
				foreach(var arrayNode in node["files"].Children())
				{
					this._Files.Add(ObjectFactory.Create<ReportExportFile>(arrayNode));
				}
			}
			if(node["baseUrl"] != null)
			{
				this._BaseUrl = node["baseUrl"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReportExportJobData");
			kparams.AddIfNotNull("recipientEmail", this._RecipientEmail);
			kparams.AddIfNotNull("reportItems", this._ReportItems);
			kparams.AddIfNotNull("filePaths", this._FilePaths);
			kparams.AddIfNotNull("reportsGroup", this._ReportsGroup);
			kparams.AddIfNotNull("files", this._Files);
			kparams.AddIfNotNull("baseUrl", this._BaseUrl);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RECIPIENT_EMAIL:
					return "RecipientEmail";
				case REPORT_ITEMS:
					return "ReportItems";
				case FILE_PATHS:
					return "FilePaths";
				case REPORTS_GROUP:
					return "ReportsGroup";
				case FILES:
					return "Files";
				case BASE_URL:
					return "BaseUrl";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

