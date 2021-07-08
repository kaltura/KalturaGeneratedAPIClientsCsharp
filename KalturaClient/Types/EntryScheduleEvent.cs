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
	public class EntryScheduleEvent : ScheduleEvent
	{
		#region Constants
		public const string TEMPLATE_ENTRY_ID = "templateEntryId";
		public const string ENTRY_IDS = "entryIds";
		public const string CATEGORY_IDS = "categoryIds";
		public const string BLACKOUT_CONFLICTS = "blackoutConflicts";
		#endregion

		#region Private Fields
		private string _TemplateEntryId = null;
		private string _EntryIds = null;
		private string _CategoryIds = null;
		private IList<ScheduleEvent> _BlackoutConflicts;
		#endregion

		#region Properties
		/// <summary>
		/// Use TemplateEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TemplateEntryId
		{
			get { return _TemplateEntryId; }
			set 
			{ 
				_TemplateEntryId = value;
				OnPropertyChanged("TemplateEntryId");
			}
		}
		/// <summary>
		/// Use EntryIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIds
		{
			get { return _EntryIds; }
			set 
			{ 
				_EntryIds = value;
				OnPropertyChanged("EntryIds");
			}
		}
		/// <summary>
		/// Use CategoryIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CategoryIds
		{
			get { return _CategoryIds; }
			set 
			{ 
				_CategoryIds = value;
				OnPropertyChanged("CategoryIds");
			}
		}
		/// <summary>
		/// Use BlackoutConflictsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ScheduleEvent> BlackoutConflicts
		{
			get { return _BlackoutConflicts; }
			private set 
			{ 
				_BlackoutConflicts = value;
				OnPropertyChanged("BlackoutConflicts");
			}
		}
		#endregion

		#region CTor
		public EntryScheduleEvent()
		{
		}

		public EntryScheduleEvent(JToken node) : base(node)
		{
			if(node["templateEntryId"] != null)
			{
				this._TemplateEntryId = node["templateEntryId"].Value<string>();
			}
			if(node["entryIds"] != null)
			{
				this._EntryIds = node["entryIds"].Value<string>();
			}
			if(node["categoryIds"] != null)
			{
				this._CategoryIds = node["categoryIds"].Value<string>();
			}
			if(node["blackoutConflicts"] != null)
			{
				this._BlackoutConflicts = new List<ScheduleEvent>();
				foreach(var arrayNode in node["blackoutConflicts"].Children())
				{
					this._BlackoutConflicts.Add(ObjectFactory.Create<ScheduleEvent>(arrayNode));
				}
			}
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
			kparams.AddIfNotNull("blackoutConflicts", this._BlackoutConflicts);
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
				case BLACKOUT_CONFLICTS:
					return "BlackoutConflicts";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

