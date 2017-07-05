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
	public class NotificationsPartnerSettings : ObjectBase
	{
		#region Constants
		public const string PUSH_NOTIFICATION_ENABLED = "pushNotificationEnabled";
		public const string PUSH_SYSTEM_ANNOUNCEMENTS_ENABLED = "pushSystemAnnouncementsEnabled";
		public const string PUSH_START_HOUR = "pushStartHour";
		public const string PUSH_END_HOUR = "pushEndHour";
		public const string INBOX_ENABLED = "inboxEnabled";
		public const string MESSAGE_TTL_DAYS = "messageTTLDays";
		public const string AUTOMATIC_ISSUE_FOLLOW_NOTIFICATION = "automaticIssueFollowNotification";
		public const string TOPIC_EXPIRATION_DURATION_DAYS = "topicExpirationDurationDays";
		#endregion

		#region Private Fields
		private bool? _PushNotificationEnabled = null;
		private bool? _PushSystemAnnouncementsEnabled = null;
		private int _PushStartHour = Int32.MinValue;
		private int _PushEndHour = Int32.MinValue;
		private bool? _InboxEnabled = null;
		private int _MessageTTLDays = Int32.MinValue;
		private bool? _AutomaticIssueFollowNotification = null;
		private int _TopicExpirationDurationDays = Int32.MinValue;
		#endregion

		#region Properties
		public bool? PushNotificationEnabled
		{
			get { return _PushNotificationEnabled; }
			set 
			{ 
				_PushNotificationEnabled = value;
				OnPropertyChanged("PushNotificationEnabled");
			}
		}
		public bool? PushSystemAnnouncementsEnabled
		{
			get { return _PushSystemAnnouncementsEnabled; }
			set 
			{ 
				_PushSystemAnnouncementsEnabled = value;
				OnPropertyChanged("PushSystemAnnouncementsEnabled");
			}
		}
		public int PushStartHour
		{
			get { return _PushStartHour; }
			set 
			{ 
				_PushStartHour = value;
				OnPropertyChanged("PushStartHour");
			}
		}
		public int PushEndHour
		{
			get { return _PushEndHour; }
			set 
			{ 
				_PushEndHour = value;
				OnPropertyChanged("PushEndHour");
			}
		}
		public bool? InboxEnabled
		{
			get { return _InboxEnabled; }
			set 
			{ 
				_InboxEnabled = value;
				OnPropertyChanged("InboxEnabled");
			}
		}
		public int MessageTTLDays
		{
			get { return _MessageTTLDays; }
			set 
			{ 
				_MessageTTLDays = value;
				OnPropertyChanged("MessageTTLDays");
			}
		}
		public bool? AutomaticIssueFollowNotification
		{
			get { return _AutomaticIssueFollowNotification; }
			set 
			{ 
				_AutomaticIssueFollowNotification = value;
				OnPropertyChanged("AutomaticIssueFollowNotification");
			}
		}
		public int TopicExpirationDurationDays
		{
			get { return _TopicExpirationDurationDays; }
			set 
			{ 
				_TopicExpirationDurationDays = value;
				OnPropertyChanged("TopicExpirationDurationDays");
			}
		}
		#endregion

		#region CTor
		public NotificationsPartnerSettings()
		{
		}

		public NotificationsPartnerSettings(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "pushNotificationEnabled":
						this._PushNotificationEnabled = ParseBool(propertyNode.InnerText);
						continue;
					case "pushSystemAnnouncementsEnabled":
						this._PushSystemAnnouncementsEnabled = ParseBool(propertyNode.InnerText);
						continue;
					case "pushStartHour":
						this._PushStartHour = ParseInt(propertyNode.InnerText);
						continue;
					case "pushEndHour":
						this._PushEndHour = ParseInt(propertyNode.InnerText);
						continue;
					case "inboxEnabled":
						this._InboxEnabled = ParseBool(propertyNode.InnerText);
						continue;
					case "messageTTLDays":
						this._MessageTTLDays = ParseInt(propertyNode.InnerText);
						continue;
					case "automaticIssueFollowNotification":
						this._AutomaticIssueFollowNotification = ParseBool(propertyNode.InnerText);
						continue;
					case "topicExpirationDurationDays":
						this._TopicExpirationDurationDays = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaNotificationsPartnerSettings");
			kparams.AddIfNotNull("pushNotificationEnabled", this._PushNotificationEnabled);
			kparams.AddIfNotNull("pushSystemAnnouncementsEnabled", this._PushSystemAnnouncementsEnabled);
			kparams.AddIfNotNull("pushStartHour", this._PushStartHour);
			kparams.AddIfNotNull("pushEndHour", this._PushEndHour);
			kparams.AddIfNotNull("inboxEnabled", this._InboxEnabled);
			kparams.AddIfNotNull("messageTTLDays", this._MessageTTLDays);
			kparams.AddIfNotNull("automaticIssueFollowNotification", this._AutomaticIssueFollowNotification);
			kparams.AddIfNotNull("topicExpirationDurationDays", this._TopicExpirationDurationDays);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PUSH_NOTIFICATION_ENABLED:
					return "PushNotificationEnabled";
				case PUSH_SYSTEM_ANNOUNCEMENTS_ENABLED:
					return "PushSystemAnnouncementsEnabled";
				case PUSH_START_HOUR:
					return "PushStartHour";
				case PUSH_END_HOUR:
					return "PushEndHour";
				case INBOX_ENABLED:
					return "InboxEnabled";
				case MESSAGE_TTL_DAYS:
					return "MessageTTLDays";
				case AUTOMATIC_ISSUE_FOLLOW_NOTIFICATION:
					return "AutomaticIssueFollowNotification";
				case TOPIC_EXPIRATION_DURATION_DAYS:
					return "TopicExpirationDurationDays";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

