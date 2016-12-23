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
	public class ReportInputFilter : ReportInputBaseFilter
	{
		#region Constants
		public const string KEYWORDS = "keywords";
		public const string SEARCH_IN_TAGS = "searchInTags";
		public const string SEARCH_IN_ADMIN_TAGS = "searchInAdminTags";
		public const string CATEGORIES = "categories";
		public const string TIME_ZONE_OFFSET = "timeZoneOffset";
		public const string INTERVAL = "interval";
		#endregion

		#region Private Fields
		private string _Keywords = null;
		private bool? _SearchInTags = null;
		private bool? _SearchInAdminTags = null;
		private string _Categories = null;
		private int _TimeZoneOffset = Int32.MinValue;
		private ReportInterval _Interval = null;
		#endregion

		#region Properties
		public string Keywords
		{
			get { return _Keywords; }
			set 
			{ 
				_Keywords = value;
				OnPropertyChanged("Keywords");
			}
		}
		public bool? SearchInTags
		{
			get { return _SearchInTags; }
			set 
			{ 
				_SearchInTags = value;
				OnPropertyChanged("SearchInTags");
			}
		}
		public bool? SearchInAdminTags
		{
			get { return _SearchInAdminTags; }
			set 
			{ 
				_SearchInAdminTags = value;
				OnPropertyChanged("SearchInAdminTags");
			}
		}
		public string Categories
		{
			get { return _Categories; }
			set 
			{ 
				_Categories = value;
				OnPropertyChanged("Categories");
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
		public ReportInterval Interval
		{
			get { return _Interval; }
			set 
			{ 
				_Interval = value;
				OnPropertyChanged("Interval");
			}
		}
		#endregion

		#region CTor
		public ReportInputFilter()
		{
		}

		public ReportInputFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "keywords":
						this._Keywords = propertyNode.InnerText;
						continue;
					case "searchInTags":
						this._SearchInTags = ParseBool(propertyNode.InnerText);
						continue;
					case "searchInAdminTags":
						this._SearchInAdminTags = ParseBool(propertyNode.InnerText);
						continue;
					case "categories":
						this._Categories = propertyNode.InnerText;
						continue;
					case "timeZoneOffset":
						this._TimeZoneOffset = ParseInt(propertyNode.InnerText);
						continue;
					case "interval":
						this._Interval = (ReportInterval)StringEnum.Parse(typeof(ReportInterval), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaReportInputFilter");
			kparams.AddIfNotNull("keywords", this._Keywords);
			kparams.AddIfNotNull("searchInTags", this._SearchInTags);
			kparams.AddIfNotNull("searchInAdminTags", this._SearchInAdminTags);
			kparams.AddIfNotNull("categories", this._Categories);
			kparams.AddIfNotNull("timeZoneOffset", this._TimeZoneOffset);
			kparams.AddIfNotNull("interval", this._Interval);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KEYWORDS:
					return "Keywords";
				case SEARCH_IN_TAGS:
					return "SearchInTags";
				case SEARCH_IN_ADMIN_TAGS:
					return "SearchInAdminTags";
				case CATEGORIES:
					return "Categories";
				case TIME_ZONE_OFFSET:
					return "TimeZoneOffset";
				case INTERVAL:
					return "Interval";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

