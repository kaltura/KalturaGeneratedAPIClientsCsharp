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
	public class MailNotificationObjectTask : ObjectTask
	{
		#region Constants
		public const string MAIL_TO = "mailTo";
		public const string SENDER = "sender";
		public const string SUBJECT = "subject";
		public const string MESSAGE = "message";
		public const string FOOTER = "footer";
		public const string LINK = "link";
		public const string SEND_TO_USERS = "sendToUsers";
		#endregion

		#region Private Fields
		private string _MailTo = null;
		private string _Sender = null;
		private string _Subject = null;
		private string _Message = null;
		private string _Footer = null;
		private string _Link = null;
		private bool? _SendToUsers = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string MailTo
		{
			get { return _MailTo; }
			set 
			{ 
				_MailTo = value;
				OnPropertyChanged("MailTo");
			}
		}
		[JsonProperty]
		public string Sender
		{
			get { return _Sender; }
			set 
			{ 
				_Sender = value;
				OnPropertyChanged("Sender");
			}
		}
		[JsonProperty]
		public string Subject
		{
			get { return _Subject; }
			set 
			{ 
				_Subject = value;
				OnPropertyChanged("Subject");
			}
		}
		[JsonProperty]
		public string Message
		{
			get { return _Message; }
			set 
			{ 
				_Message = value;
				OnPropertyChanged("Message");
			}
		}
		[JsonProperty]
		public string Footer
		{
			get { return _Footer; }
			set 
			{ 
				_Footer = value;
				OnPropertyChanged("Footer");
			}
		}
		[JsonProperty]
		public string Link
		{
			get { return _Link; }
			set 
			{ 
				_Link = value;
				OnPropertyChanged("Link");
			}
		}
		[JsonProperty]
		public bool? SendToUsers
		{
			get { return _SendToUsers; }
			set 
			{ 
				_SendToUsers = value;
				OnPropertyChanged("SendToUsers");
			}
		}
		#endregion

		#region CTor
		public MailNotificationObjectTask()
		{
		}

		public MailNotificationObjectTask(JToken node) : base(node)
		{
			if(node["mailTo"] != null)
			{
				this._MailTo = node["mailTo"].Value<string>();
			}
			if(node["sender"] != null)
			{
				this._Sender = node["sender"].Value<string>();
			}
			if(node["subject"] != null)
			{
				this._Subject = node["subject"].Value<string>();
			}
			if(node["message"] != null)
			{
				this._Message = node["message"].Value<string>();
			}
			if(node["footer"] != null)
			{
				this._Footer = node["footer"].Value<string>();
			}
			if(node["link"] != null)
			{
				this._Link = node["link"].Value<string>();
			}
			if(node["sendToUsers"] != null)
			{
				this._SendToUsers = ParseBool(node["sendToUsers"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMailNotificationObjectTask");
			kparams.AddIfNotNull("mailTo", this._MailTo);
			kparams.AddIfNotNull("sender", this._Sender);
			kparams.AddIfNotNull("subject", this._Subject);
			kparams.AddIfNotNull("message", this._Message);
			kparams.AddIfNotNull("footer", this._Footer);
			kparams.AddIfNotNull("link", this._Link);
			kparams.AddIfNotNull("sendToUsers", this._SendToUsers);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MAIL_TO:
					return "MailTo";
				case SENDER:
					return "Sender";
				case SUBJECT:
					return "Subject";
				case MESSAGE:
					return "Message";
				case FOOTER:
					return "Footer";
				case LINK:
					return "Link";
				case SEND_TO_USERS:
					return "SendToUsers";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

