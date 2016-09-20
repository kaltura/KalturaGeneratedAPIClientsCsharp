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
	public class KalturaEmailNotificationTemplate : KalturaEventNotificationTemplate
	{
		#region Private Fields
		private KalturaEmailNotificationFormat _Format = null;
		private string _Subject = null;
		private string _Body = null;
		private string _FromEmail = null;
		private string _FromName = null;
		private KalturaEmailNotificationRecipientProvider _To;
		private KalturaEmailNotificationRecipientProvider _Cc;
		private KalturaEmailNotificationRecipientProvider _Bcc;
		private KalturaEmailNotificationRecipientProvider _ReplyTo;
		private KalturaEmailNotificationTemplatePriority _Priority = (KalturaEmailNotificationTemplatePriority)Int32.MinValue;
		private string _ConfirmReadingTo = null;
		private string _Hostname = null;
		private string _MessageID = null;
		private IList<KalturaKeyValue> _CustomHeaders;
		#endregion

		#region Properties
		public KalturaEmailNotificationFormat Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
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
		public string Body
		{
			get { return _Body; }
			set 
			{ 
				_Body = value;
				OnPropertyChanged("Body");
			}
		}
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
		public KalturaEmailNotificationRecipientProvider To
		{
			get { return _To; }
			set 
			{ 
				_To = value;
				OnPropertyChanged("To");
			}
		}
		public KalturaEmailNotificationRecipientProvider Cc
		{
			get { return _Cc; }
			set 
			{ 
				_Cc = value;
				OnPropertyChanged("Cc");
			}
		}
		public KalturaEmailNotificationRecipientProvider Bcc
		{
			get { return _Bcc; }
			set 
			{ 
				_Bcc = value;
				OnPropertyChanged("Bcc");
			}
		}
		public KalturaEmailNotificationRecipientProvider ReplyTo
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
		public new IList<KalturaKeyValue> CustomHeaders
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
		public KalturaEmailNotificationTemplate()
		{
		}

		public KalturaEmailNotificationTemplate(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "format":
						this._Format = (KalturaEmailNotificationFormat)KalturaStringEnum.Parse(typeof(KalturaEmailNotificationFormat), txt);
						continue;
					case "subject":
						this._Subject = txt;
						continue;
					case "body":
						this._Body = txt;
						continue;
					case "fromEmail":
						this._FromEmail = txt;
						continue;
					case "fromName":
						this._FromName = txt;
						continue;
					case "to":
						this._To = (KalturaEmailNotificationRecipientProvider)KalturaObjectFactory.Create(propertyNode, "KalturaEmailNotificationRecipientProvider");
						continue;
					case "cc":
						this._Cc = (KalturaEmailNotificationRecipientProvider)KalturaObjectFactory.Create(propertyNode, "KalturaEmailNotificationRecipientProvider");
						continue;
					case "bcc":
						this._Bcc = (KalturaEmailNotificationRecipientProvider)KalturaObjectFactory.Create(propertyNode, "KalturaEmailNotificationRecipientProvider");
						continue;
					case "replyTo":
						this._ReplyTo = (KalturaEmailNotificationRecipientProvider)KalturaObjectFactory.Create(propertyNode, "KalturaEmailNotificationRecipientProvider");
						continue;
					case "priority":
						this._Priority = (KalturaEmailNotificationTemplatePriority)ParseEnum(typeof(KalturaEmailNotificationTemplatePriority), txt);
						continue;
					case "confirmReadingTo":
						this._ConfirmReadingTo = txt;
						continue;
					case "hostname":
						this._Hostname = txt;
						continue;
					case "messageID":
						this._MessageID = txt;
						continue;
					case "customHeaders":
						this._CustomHeaders = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._CustomHeaders.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
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
			kparams.AddReplace("objectType", "KalturaEmailNotificationTemplate");
			kparams.AddIfNotNull("format", this.Format);
			kparams.AddIfNotNull("subject", this.Subject);
			kparams.AddIfNotNull("body", this.Body);
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

