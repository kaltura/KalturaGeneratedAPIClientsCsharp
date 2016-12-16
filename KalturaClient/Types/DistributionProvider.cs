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
	public class DistributionProvider : ObjectBase
	{
		#region Constants
		public const string TYPE = "type";
		public const string NAME = "name";
		public const string SCHEDULE_UPDATE_ENABLED = "scheduleUpdateEnabled";
		public const string AVAILABILITY_UPDATE_ENABLED = "availabilityUpdateEnabled";
		public const string DELETE_INSTEAD_UPDATE = "deleteInsteadUpdate";
		public const string INTERVAL_BEFORE_SUNRISE = "intervalBeforeSunrise";
		public const string INTERVAL_BEFORE_SUNSET = "intervalBeforeSunset";
		public const string UPDATE_REQUIRED_ENTRY_FIELDS = "updateRequiredEntryFields";
		public const string UPDATE_REQUIRED_METADATA_XPATHS = "updateRequiredMetadataXPaths";
		#endregion

		#region Private Fields
		private DistributionProviderType _Type = null;
		private string _Name = null;
		private bool? _ScheduleUpdateEnabled = null;
		private bool? _AvailabilityUpdateEnabled = null;
		private bool? _DeleteInsteadUpdate = null;
		private int _IntervalBeforeSunrise = Int32.MinValue;
		private int _IntervalBeforeSunset = Int32.MinValue;
		private string _UpdateRequiredEntryFields = null;
		private string _UpdateRequiredMetadataXPaths = null;
		#endregion

		#region Properties
		public DistributionProviderType Type
		{
			get { return _Type; }
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public bool? ScheduleUpdateEnabled
		{
			get { return _ScheduleUpdateEnabled; }
			set 
			{ 
				_ScheduleUpdateEnabled = value;
				OnPropertyChanged("ScheduleUpdateEnabled");
			}
		}
		public bool? AvailabilityUpdateEnabled
		{
			get { return _AvailabilityUpdateEnabled; }
			set 
			{ 
				_AvailabilityUpdateEnabled = value;
				OnPropertyChanged("AvailabilityUpdateEnabled");
			}
		}
		public bool? DeleteInsteadUpdate
		{
			get { return _DeleteInsteadUpdate; }
			set 
			{ 
				_DeleteInsteadUpdate = value;
				OnPropertyChanged("DeleteInsteadUpdate");
			}
		}
		public int IntervalBeforeSunrise
		{
			get { return _IntervalBeforeSunrise; }
			set 
			{ 
				_IntervalBeforeSunrise = value;
				OnPropertyChanged("IntervalBeforeSunrise");
			}
		}
		public int IntervalBeforeSunset
		{
			get { return _IntervalBeforeSunset; }
			set 
			{ 
				_IntervalBeforeSunset = value;
				OnPropertyChanged("IntervalBeforeSunset");
			}
		}
		public string UpdateRequiredEntryFields
		{
			get { return _UpdateRequiredEntryFields; }
			set 
			{ 
				_UpdateRequiredEntryFields = value;
				OnPropertyChanged("UpdateRequiredEntryFields");
			}
		}
		public string UpdateRequiredMetadataXPaths
		{
			get { return _UpdateRequiredMetadataXPaths; }
			set 
			{ 
				_UpdateRequiredMetadataXPaths = value;
				OnPropertyChanged("UpdateRequiredMetadataXPaths");
			}
		}
		#endregion

		#region CTor
		public DistributionProvider()
		{
		}

		public DistributionProvider(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "type":
						this._Type = (DistributionProviderType)StringEnum.Parse(typeof(DistributionProviderType), txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "scheduleUpdateEnabled":
						this._ScheduleUpdateEnabled = ParseBool(txt);
						continue;
					case "availabilityUpdateEnabled":
						this._AvailabilityUpdateEnabled = ParseBool(txt);
						continue;
					case "deleteInsteadUpdate":
						this._DeleteInsteadUpdate = ParseBool(txt);
						continue;
					case "intervalBeforeSunrise":
						this._IntervalBeforeSunrise = ParseInt(txt);
						continue;
					case "intervalBeforeSunset":
						this._IntervalBeforeSunset = ParseInt(txt);
						continue;
					case "updateRequiredEntryFields":
						this._UpdateRequiredEntryFields = txt;
						continue;
					case "updateRequiredMetadataXPaths":
						this._UpdateRequiredMetadataXPaths = txt;
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
				kparams.AddReplace("objectType", "KalturaDistributionProvider");
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("scheduleUpdateEnabled", this._ScheduleUpdateEnabled);
			kparams.AddIfNotNull("availabilityUpdateEnabled", this._AvailabilityUpdateEnabled);
			kparams.AddIfNotNull("deleteInsteadUpdate", this._DeleteInsteadUpdate);
			kparams.AddIfNotNull("intervalBeforeSunrise", this._IntervalBeforeSunrise);
			kparams.AddIfNotNull("intervalBeforeSunset", this._IntervalBeforeSunset);
			kparams.AddIfNotNull("updateRequiredEntryFields", this._UpdateRequiredEntryFields);
			kparams.AddIfNotNull("updateRequiredMetadataXPaths", this._UpdateRequiredMetadataXPaths);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TYPE:
					return "Type";
				case NAME:
					return "Name";
				case SCHEDULE_UPDATE_ENABLED:
					return "ScheduleUpdateEnabled";
				case AVAILABILITY_UPDATE_ENABLED:
					return "AvailabilityUpdateEnabled";
				case DELETE_INSTEAD_UPDATE:
					return "DeleteInsteadUpdate";
				case INTERVAL_BEFORE_SUNRISE:
					return "IntervalBeforeSunrise";
				case INTERVAL_BEFORE_SUNSET:
					return "IntervalBeforeSunset";
				case UPDATE_REQUIRED_ENTRY_FIELDS:
					return "UpdateRequiredEntryFields";
				case UPDATE_REQUIRED_METADATA_XPATHS:
					return "UpdateRequiredMetadataXPaths";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

