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
	public class LiveReportExportParams : ObjectBase
	{
		#region Constants
		public const string ENTRY_IDS = "entryIds";
		public const string RECPIENT_EMAIL = "recpientEmail";
		public const string TIME_ZONE_OFFSET = "timeZoneOffset";
		public const string APPLICATION_URL_TEMPLATE = "applicationUrlTemplate";
		#endregion

		#region Private Fields
		private string _EntryIds = null;
		private string _RecpientEmail = null;
		private int _TimeZoneOffset = Int32.MinValue;
		private string _ApplicationUrlTemplate = null;
		#endregion

		#region Properties
		public string EntryIds
		{
			get { return _EntryIds; }
			set 
			{ 
				_EntryIds = value;
				OnPropertyChanged("EntryIds");
			}
		}
		public string RecpientEmail
		{
			get { return _RecpientEmail; }
			set 
			{ 
				_RecpientEmail = value;
				OnPropertyChanged("RecpientEmail");
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
		public string ApplicationUrlTemplate
		{
			get { return _ApplicationUrlTemplate; }
			set 
			{ 
				_ApplicationUrlTemplate = value;
				OnPropertyChanged("ApplicationUrlTemplate");
			}
		}
		#endregion

		#region CTor
		public LiveReportExportParams()
		{
		}

		public LiveReportExportParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "entryIds":
						this._EntryIds = propertyNode.InnerText;
						continue;
					case "recpientEmail":
						this._RecpientEmail = propertyNode.InnerText;
						continue;
					case "timeZoneOffset":
						this._TimeZoneOffset = ParseInt(propertyNode.InnerText);
						continue;
					case "applicationUrlTemplate":
						this._ApplicationUrlTemplate = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaLiveReportExportParams");
			kparams.AddIfNotNull("entryIds", this._EntryIds);
			kparams.AddIfNotNull("recpientEmail", this._RecpientEmail);
			kparams.AddIfNotNull("timeZoneOffset", this._TimeZoneOffset);
			kparams.AddIfNotNull("applicationUrlTemplate", this._ApplicationUrlTemplate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_IDS:
					return "EntryIds";
				case RECPIENT_EMAIL:
					return "RecpientEmail";
				case TIME_ZONE_OFFSET:
					return "TimeZoneOffset";
				case APPLICATION_URL_TEMPLATE:
					return "ApplicationUrlTemplate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

