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

namespace Kaltura
{
	public class KalturaEntryScheduleEvent : KalturaScheduleEvent
	{
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
		public KalturaEntryScheduleEvent()
		{
		}

		public KalturaEntryScheduleEvent(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "templateEntryId":
						this.TemplateEntryId = txt;
						continue;
					case "entryIds":
						this.EntryIds = txt;
						continue;
					case "categoryIds":
						this.CategoryIds = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEntryScheduleEvent");
			kparams.AddIfNotNull("templateEntryId", this.TemplateEntryId);
			kparams.AddIfNotNull("entryIds", this.EntryIds);
			kparams.AddIfNotNull("categoryIds", this.CategoryIds);
			return kparams;
		}
		#endregion
	}
}

