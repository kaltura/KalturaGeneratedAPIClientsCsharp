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
	public class LiveReportExportJobData : JobData
	{
		#region Constants
		public const string TIME_REFERENCE = "timeReference";
		public const string TIME_ZONE_OFFSET = "timeZoneOffset";
		public const string ENTRY_IDS = "entryIds";
		public const string OUTPUT_PATH = "outputPath";
		public const string RECIPIENT_EMAIL = "recipientEmail";
		#endregion

		#region Private Fields
		private int _TimeReference = Int32.MinValue;
		private int _TimeZoneOffset = Int32.MinValue;
		private string _EntryIds = null;
		private string _OutputPath = null;
		private string _RecipientEmail = null;
		#endregion

		#region Properties
		public int TimeReference
		{
			get { return _TimeReference; }
			set 
			{ 
				_TimeReference = value;
				OnPropertyChanged("TimeReference");
			}
		}
		public int TimeZoneOffset
		{
			get { return _TimeZoneOffset; }
			set 
			{ 
				_TimeZoneOffset = value;
				OnPropertyChanged("TimeZoneOffset");
			}
		}
		public string EntryIds
		{
			get { return _EntryIds; }
			set 
			{ 
				_EntryIds = value;
				OnPropertyChanged("EntryIds");
			}
		}
		public string OutputPath
		{
			get { return _OutputPath; }
			set 
			{ 
				_OutputPath = value;
				OnPropertyChanged("OutputPath");
			}
		}
		public string RecipientEmail
		{
			get { return _RecipientEmail; }
			set 
			{ 
				_RecipientEmail = value;
				OnPropertyChanged("RecipientEmail");
			}
		}
		#endregion

		#region CTor
		public LiveReportExportJobData()
		{
		}

		public LiveReportExportJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "timeReference":
						this._TimeReference = ParseInt(txt);
						continue;
					case "timeZoneOffset":
						this._TimeZoneOffset = ParseInt(txt);
						continue;
					case "entryIds":
						this._EntryIds = txt;
						continue;
					case "outputPath":
						this._OutputPath = txt;
						continue;
					case "recipientEmail":
						this._RecipientEmail = txt;
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
				kparams.AddReplace("objectType", "KalturaLiveReportExportJobData");
			kparams.AddIfNotNull("timeReference", this._TimeReference);
			kparams.AddIfNotNull("timeZoneOffset", this._TimeZoneOffset);
			kparams.AddIfNotNull("entryIds", this._EntryIds);
			kparams.AddIfNotNull("outputPath", this._OutputPath);
			kparams.AddIfNotNull("recipientEmail", this._RecipientEmail);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TIME_REFERENCE:
					return "TimeReference";
				case TIME_ZONE_OFFSET:
					return "TimeZoneOffset";
				case ENTRY_IDS:
					return "EntryIds";
				case OUTPUT_PATH:
					return "OutputPath";
				case RECIPIENT_EMAIL:
					return "RecipientEmail";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

