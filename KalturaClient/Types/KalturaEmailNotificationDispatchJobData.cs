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
	public class KalturaEmailNotificationDispatchJobData : KalturaEventNotificationDispatchJobData
	{
		#region Private Fields
		private string _FromEmail = null;
		private string _FromName = null;
		private KalturaEmailNotificationRecipientJobData _To;
		private KalturaEmailNotificationRecipientJobData _Cc;
		private KalturaEmailNotificationRecipientJobData _Bcc;
		private KalturaEmailNotificationRecipientJobData _ReplyTo;
		private KalturaEmailNotificationTemplatePriority _Priority = (KalturaEmailNotificationTemplatePriority)Int32.MinValue;
		private string _ConfirmReadingTo = null;
		private string _Hostname = null;
		private string _MessageID = null;
		private IList<KalturaKeyValue> _CustomHeaders;
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
		public KalturaEmailNotificationRecipientJobData To
		{
			get { return _To; }
			set 
			{ 
				_To = value;
				OnPropertyChanged("To");
			}
		}
		public KalturaEmailNotificationRecipientJobData Cc
		{
			get { return _Cc; }
			set 
			{ 
				_Cc = value;
				OnPropertyChanged("Cc");
			}
		}
		public KalturaEmailNotificationRecipientJobData Bcc
		{
			get { return _Bcc; }
			set 
			{ 
				_Bcc = value;
				OnPropertyChanged("Bcc");
			}
		}
		public KalturaEmailNotificationRecipientJobData ReplyTo
		{
			get { return _ReplyTo; }
			set 
			{ 
				_ReplyTo = value;
				OnPropertyChanged("ReplyTo");
			}
		}
		public KalturaEmailNotificationTemplatePriority Priority
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
		public IList<KalturaKeyValue> CustomHeaders
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
		public KalturaEmailNotificationDispatchJobData()
		{
		}

		public KalturaEmailNotificationDispatchJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fromEmail":
						this.FromEmail = txt;
						continue;
					case "fromName":
						this.FromName = txt;
						continue;
					case "to":
						this.To = (KalturaEmailNotificationRecipientJobData)KalturaObjectFactory.Create(propertyNode, "KalturaEmailNotificationRecipientJobData");
						continue;
					case "cc":
						this.Cc = (KalturaEmailNotificationRecipientJobData)KalturaObjectFactory.Create(propertyNode, "KalturaEmailNotificationRecipientJobData");
						continue;
					case "bcc":
						this.Bcc = (KalturaEmailNotificationRecipientJobData)KalturaObjectFactory.Create(propertyNode, "KalturaEmailNotificationRecipientJobData");
						continue;
					case "replyTo":
						this.ReplyTo = (KalturaEmailNotificationRecipientJobData)KalturaObjectFactory.Create(propertyNode, "KalturaEmailNotificationRecipientJobData");
						continue;
					case "priority":
						this.Priority = (KalturaEmailNotificationTemplatePriority)ParseEnum(typeof(KalturaEmailNotificationTemplatePriority), txt);
						continue;
					case "confirmReadingTo":
						this.ConfirmReadingTo = txt;
						continue;
					case "hostname":
						this.Hostname = txt;
						continue;
					case "messageID":
						this.MessageID = txt;
						continue;
					case "customHeaders":
						this.CustomHeaders = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.CustomHeaders.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEmailNotificationDispatchJobData");
			kparams.AddIfNotNull("fromEmail", this.FromEmail);
			kparams.AddIfNotNull("fromName", this.FromName);
			kparams.AddIfNotNull("to", this.To);
			kparams.AddIfNotNull("cc", this.Cc);
			kparams.AddIfNotNull("bcc", this.Bcc);
			kparams.AddIfNotNull("replyTo", this.ReplyTo);
			kparams.AddIfNotNull("priority", this.Priority);
			kparams.AddIfNotNull("confirmReadingTo", this.ConfirmReadingTo);
			kparams.AddIfNotNull("hostname", this.Hostname);
			kparams.AddIfNotNull("messageID", this.MessageID);
			kparams.AddIfNotNull("customHeaders", this.CustomHeaders);
			return kparams;
		}
		#endregion
	}
}

