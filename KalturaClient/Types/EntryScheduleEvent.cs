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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class EntryScheduleEvent : ScheduleEvent
	{
		#region Constants
		public const string TEMPLATE_ENTRY_ID = "templateEntryId";
		public const string ENTRY_IDS = "entryIds";
		public const string CATEGORY_IDS = "categoryIds";
		#endregion

		#region Private Fields
		private string _TemplateEntryId = null;
		private string _EntryIds = null;
		private string _CategoryIds = null;
		#endregion

		#region Properties
		public string TemplateEntryId
		{
			get { return _TemplateEntryId; }
			set 
			{ 
				_TemplateEntryId = value;
				OnPropertyChanged("TemplateEntryId");
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
		public string CategoryIds
		{
			get { return _CategoryIds; }
			set 
			{ 
				_CategoryIds = value;
				OnPropertyChanged("CategoryIds");
			}
		}
		#endregion

		#region CTor
		public EntryScheduleEvent()
		{
		}

		public EntryScheduleEvent(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "templateEntryId":
						this._TemplateEntryId = propertyNode.InnerText;
						continue;
					case "entryIds":
						this._EntryIds = propertyNode.InnerText;
						continue;
					case "categoryIds":
						this._CategoryIds = propertyNode.InnerText;
						continue;
				}
			}
		}

		public EntryScheduleEvent(IDictionary<string,object> data) : base(data)
		{
			    this._TemplateEntryId = data.TryGetValueSafe<string>("templateEntryId");
			    this._EntryIds = data.TryGetValueSafe<string>("entryIds");
			    this._CategoryIds = data.TryGetValueSafe<string>("categoryIds");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryScheduleEvent");
			kparams.AddIfNotNull("templateEntryId", this._TemplateEntryId);
			kparams.AddIfNotNull("entryIds", this._EntryIds);
			kparams.AddIfNotNull("categoryIds", this._CategoryIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TEMPLATE_ENTRY_ID:
					return "TemplateEntryId";
				case ENTRY_IDS:
					return "EntryIds";
				case CATEGORY_IDS:
					return "CategoryIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

