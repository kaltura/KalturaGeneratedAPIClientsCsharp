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
		public string MailTo
		{
			get { return _MailTo; }
			set 
			{ 
				_MailTo = value;
				OnPropertyChanged("MailTo");
			}
		}
		public string Sender
		{
			get { return _Sender; }
			set 
			{ 
				_Sender = value;
				OnPropertyChanged("Sender");
			}
		}
		public string Subject
		{
			get { return _Subject; }
			set 
			{ 
				_Subject = value;
				OnPropertyChanged("Subject");
			}
		}
		public string Message
		{
			get { return _Message; }
			set 
			{ 
				_Message = value;
				OnPropertyChanged("Message");
			}
		}
		public string Footer
		{
			get { return _Footer; }
			set 
			{ 
				_Footer = value;
				OnPropertyChanged("Footer");
			}
		}
		public string Link
		{
			get { return _Link; }
			set 
			{ 
				_Link = value;
				OnPropertyChanged("Link");
			}
		}
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

		public MailNotificationObjectTask(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "mailTo":
						this._MailTo = propertyNode.InnerText;
						continue;
					case "sender":
						this._Sender = propertyNode.InnerText;
						continue;
					case "subject":
						this._Subject = propertyNode.InnerText;
						continue;
					case "message":
						this._Message = propertyNode.InnerText;
						continue;
					case "footer":
						this._Footer = propertyNode.InnerText;
						continue;
					case "link":
						this._Link = propertyNode.InnerText;
						continue;
					case "sendToUsers":
						this._SendToUsers = ParseBool(propertyNode.InnerText);
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

