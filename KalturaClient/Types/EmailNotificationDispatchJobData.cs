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
	public class EmailNotificationDispatchJobData : EventNotificationDispatchJobData
	{
		#region Constants
		public const string FROM_EMAIL = "fromEmail";
		public const string FROM_NAME = "fromName";
		public const string TO = "to";
		public const string CC = "cc";
		public const string BCC = "bcc";
		public const string REPLY_TO = "replyTo";
		public const string PRIORITY = "priority";
		public const string CONFIRM_READING_TO = "confirmReadingTo";
		public const string HOSTNAME = "hostname";
		public const string MESSAGE_ID = "messageID";
		public const string CUSTOM_HEADERS = "customHeaders";
		#endregion

		#region Private Fields
		private string _FromEmail = null;
		private string _FromName = null;
		private EmailNotificationRecipientJobData _To;
		private EmailNotificationRecipientJobData _Cc;
		private EmailNotificationRecipientJobData _Bcc;
		private EmailNotificationRecipientJobData _ReplyTo;
		private EmailNotificationTemplatePriority _Priority = (EmailNotificationTemplatePriority)Int32.MinValue;
		private string _ConfirmReadingTo = null;
		private string _Hostname = null;
		private string _MessageID = null;
		private IList<KeyValue> _CustomHeaders;
		#endregion

		#region Properties
		public string FromEmail
		{
			get { return _FromEmail; }
			set 
			{ 
				_FromEmail = value;
				OnPropertyChanged("FromEmail");
			}
		}
		public string FromName
		{
			get { return _FromName; }
			set 
			{ 
				_FromName = value;
				OnPropertyChanged("FromName");
			}
		}
		public EmailNotificationRecipientJobData To
		{
			get { return _To; }
			set 
			{ 
				_To = value;
				OnPropertyChanged("To");
			}
		}
		public EmailNotificationRecipientJobData Cc
		{
			get { return _Cc; }
			set 
			{ 
				_Cc = value;
				OnPropertyChanged("Cc");
			}
		}
		public EmailNotificationRecipientJobData Bcc
		{
			get { return _Bcc; }
			set 
			{ 
				_Bcc = value;
				OnPropertyChanged("Bcc");
			}
		}
		public EmailNotificationRecipientJobData ReplyTo
		{
			get { return _ReplyTo; }
			set 
			{ 
				_ReplyTo = value;
				OnPropertyChanged("ReplyTo");
			}
		}
		public EmailNotificationTemplatePriority Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		public string ConfirmReadingTo
		{
			get { return _ConfirmReadingTo; }
			set 
			{ 
				_ConfirmReadingTo = value;
				OnPropertyChanged("ConfirmReadingTo");
			}
		}
		public string Hostname
		{
			get { return _Hostname; }
			set 
			{ 
				_Hostname = value;
				OnPropertyChanged("Hostname");
			}
		}
		public string MessageID
		{
			get { return _MessageID; }
			set 
			{ 
				_MessageID = value;
				OnPropertyChanged("MessageID");
			}
		}
		public IList<KeyValue> CustomHeaders
		{
			get { return _CustomHeaders; }
			set 
			{ 
				_CustomHeaders = value;
				OnPropertyChanged("CustomHeaders");
			}
		}
		#endregion

		#region CTor
		public EmailNotificationDispatchJobData()
		{
		}

		public EmailNotificationDispatchJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "fromEmail":
						this._FromEmail = propertyNode.InnerText;
						continue;
					case "fromName":
						this._FromName = propertyNode.InnerText;
						continue;
					case "to":
						this._To = ObjectFactory.Create<EmailNotificationRecipientJobData>(propertyNode);
						continue;
					case "cc":
						this._Cc = ObjectFactory.Create<EmailNotificationRecipientJobData>(propertyNode);
						continue;
					case "bcc":
						this._Bcc = ObjectFactory.Create<EmailNotificationRecipientJobData>(propertyNode);
						continue;
					case "replyTo":
						this._ReplyTo = ObjectFactory.Create<EmailNotificationRecipientJobData>(propertyNode);
						continue;
					case "priority":
						this._Priority = (EmailNotificationTemplatePriority)ParseEnum(typeof(EmailNotificationTemplatePriority), propertyNode.InnerText);
						continue;
					case "confirmReadingTo":
						this._ConfirmReadingTo = propertyNode.InnerText;
						continue;
					case "hostname":
						this._Hostname = propertyNode.InnerText;
						continue;
					case "messageID":
						this._MessageID = propertyNode.InnerText;
						continue;
					case "customHeaders":
						this._CustomHeaders = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._CustomHeaders.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
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
				kparams.AddReplace("objectType", "KalturaEmailNotificationDispatchJobData");
			kparams.AddIfNotNull("fromEmail", this._FromEmail);
			kparams.AddIfNotNull("fromName", this._FromName);
			kparams.AddIfNotNull("to", this._To);
			kparams.AddIfNotNull("cc", this._Cc);
			kparams.AddIfNotNull("bcc", this._Bcc);
			kparams.AddIfNotNull("replyTo", this._ReplyTo);
			kparams.AddIfNotNull("priority", this._Priority);
			kparams.AddIfNotNull("confirmReadingTo", this._ConfirmReadingTo);
			kparams.AddIfNotNull("hostname", this._Hostname);
			kparams.AddIfNotNull("messageID", this._MessageID);
			kparams.AddIfNotNull("customHeaders", this._CustomHeaders);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FROM_EMAIL:
					return "FromEmail";
				case FROM_NAME:
					return "FromName";
				case TO:
					return "To";
				case CC:
					return "Cc";
				case BCC:
					return "Bcc";
				case REPLY_TO:
					return "ReplyTo";
				case PRIORITY:
					return "Priority";
				case CONFIRM_READING_TO:
					return "ConfirmReadingTo";
				case HOSTNAME:
					return "Hostname";
				case MESSAGE_ID:
					return "MessageID";
				case CUSTOM_HEADERS:
					return "CustomHeaders";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

