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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaMailJobData : KalturaJobData
	{
		#region Private Fields
		private KalturaMailType _MailType = null;
		private int _MailPriority = Int32.MinValue;
		private KalturaMailJobStatus _Status = (KalturaMailJobStatus)Int32.MinValue;
		private string _RecipientName = null;
		private string _RecipientEmail = null;
		private int _RecipientId = Int32.MinValue;
		private string _FromName = null;
		private string _FromEmail = null;
		private string _BodyParams = null;
		private string _SubjectParams = null;
		private string _TemplatePath = null;
		private KalturaLanguageCode _Language = null;
		private int _CampaignId = Int32.MinValue;
		private int _MinSendDate = Int32.MinValue;
		private bool? _IsHtml = false;
		private string _Separator = null;
		#endregion

		#region Properties
		public KalturaMailType MailType
		{
			get { return _MailType; }
			set 
			{ 
				_MailType = value;
				OnPropertyChanged("MailType");
			}
		}
		public int MailPriority
		{
			get { return _MailPriority; }
			set 
			{ 
				_MailPriority = value;
				OnPropertyChanged("MailPriority");
			}
		}
		public KalturaMailJobStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string RecipientName
		{
			get { return _RecipientName; }
			set 
			{ 
				_RecipientName = value;
				OnPropertyChanged("RecipientName");
			}
		}
		public string RecipientEmail
		{
			get { return _RecipientEmail; }
			set 
			{ 
				_RecipientEmail = value;
				OnPropertyChanged("RecipientEmail");
			}
		}
		public int RecipientId
		{
			get { return _RecipientId; }
			set 
			{ 
				_RecipientId = value;
				OnPropertyChanged("RecipientId");
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
		public string FromEmail
		{
			get { return _FromEmail; }
			set 
			{ 
				_FromEmail = value;
				OnPropertyChanged("FromEmail");
			}
		}
		public string BodyParams
		{
			get { return _BodyParams; }
			set 
			{ 
				_BodyParams = value;
				OnPropertyChanged("BodyParams");
			}
		}
		public string SubjectParams
		{
			get { return _SubjectParams; }
			set 
			{ 
				_SubjectParams = value;
				OnPropertyChanged("SubjectParams");
			}
		}
		public string TemplatePath
		{
			get { return _TemplatePath; }
			set 
			{ 
				_TemplatePath = value;
				OnPropertyChanged("TemplatePath");
			}
		}
		public KalturaLanguageCode Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public int CampaignId
		{
			get { return _CampaignId; }
			set 
			{ 
				_CampaignId = value;
				OnPropertyChanged("CampaignId");
			}
		}
		public int MinSendDate
		{
			get { return _MinSendDate; }
			set 
			{ 
				_MinSendDate = value;
				OnPropertyChanged("MinSendDate");
			}
		}
		public bool? IsHtml
		{
			get { return _IsHtml; }
			set 
			{ 
				_IsHtml = value;
				OnPropertyChanged("IsHtml");
			}
		}
		public string Separator
		{
			get { return _Separator; }
			set 
			{ 
				_Separator = value;
				OnPropertyChanged("Separator");
			}
		}
		#endregion

		#region CTor
		public KalturaMailJobData()
		{
		}

		public KalturaMailJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "mailType":
						this.MailType = (KalturaMailType)KalturaStringEnum.Parse(typeof(KalturaMailType), txt);
						continue;
					case "mailPriority":
						this.MailPriority = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaMailJobStatus)ParseEnum(typeof(KalturaMailJobStatus), txt);
						continue;
					case "recipientName":
						this.RecipientName = txt;
						continue;
					case "recipientEmail":
						this.RecipientEmail = txt;
						continue;
					case "recipientId":
						this.RecipientId = ParseInt(txt);
						continue;
					case "fromName":
						this.FromName = txt;
						continue;
					case "fromEmail":
						this.FromEmail = txt;
						continue;
					case "bodyParams":
						this.BodyParams = txt;
						continue;
					case "subjectParams":
						this.SubjectParams = txt;
						continue;
					case "templatePath":
						this.TemplatePath = txt;
						continue;
					case "language":
						this.Language = (KalturaLanguageCode)KalturaStringEnum.Parse(typeof(KalturaLanguageCode), txt);
						continue;
					case "campaignId":
						this.CampaignId = ParseInt(txt);
						continue;
					case "minSendDate":
						this.MinSendDate = ParseInt(txt);
						continue;
					case "isHtml":
						this.IsHtml = ParseBool(txt);
						continue;
					case "separator":
						this.Separator = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaMailJobData");
			kparams.AddIfNotNull("mailType", this.MailType);
			kparams.AddIfNotNull("mailPriority", this.MailPriority);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("recipientName", this.RecipientName);
			kparams.AddIfNotNull("recipientEmail", this.RecipientEmail);
			kparams.AddIfNotNull("recipientId", this.RecipientId);
			kparams.AddIfNotNull("fromName", this.FromName);
			kparams.AddIfNotNull("fromEmail", this.FromEmail);
			kparams.AddIfNotNull("bodyParams", this.BodyParams);
			kparams.AddIfNotNull("subjectParams", this.SubjectParams);
			kparams.AddIfNotNull("templatePath", this.TemplatePath);
			kparams.AddIfNotNull("language", this.Language);
			kparams.AddIfNotNull("campaignId", this.CampaignId);
			kparams.AddIfNotNull("minSendDate", this.MinSendDate);
			kparams.AddIfNotNull("isHtml", this.IsHtml);
			kparams.AddIfNotNull("separator", this.Separator);
			return kparams;
		}
		#endregion
	}
}

