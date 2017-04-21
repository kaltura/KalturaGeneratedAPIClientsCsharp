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
	public class MailJobData : JobData
	{
		#region Constants
		public const string MAIL_TYPE = "mailType";
		public const string MAIL_PRIORITY = "mailPriority";
		public const string STATUS = "status";
		public const string RECIPIENT_NAME = "recipientName";
		public const string RECIPIENT_EMAIL = "recipientEmail";
		public const string RECIPIENT_ID = "recipientId";
		public const string FROM_NAME = "fromName";
		public const string FROM_EMAIL = "fromEmail";
		public const string BODY_PARAMS = "bodyParams";
		public const string SUBJECT_PARAMS = "subjectParams";
		public const string TEMPLATE_PATH = "templatePath";
		public const string LANGUAGE = "language";
		public const string CAMPAIGN_ID = "campaignId";
		public const string MIN_SEND_DATE = "minSendDate";
		public const string IS_HTML = "isHtml";
		public const string SEPARATOR = "separator";
		#endregion

		#region Private Fields
		private MailType _MailType = null;
		private int _MailPriority = Int32.MinValue;
		private MailJobStatus _Status = (MailJobStatus)Int32.MinValue;
		private string _RecipientName = null;
		private string _RecipientEmail = null;
		private int _RecipientId = Int32.MinValue;
		private string _FromName = null;
		private string _FromEmail = null;
		private string _BodyParams = null;
		private string _SubjectParams = null;
		private string _TemplatePath = null;
		private LanguageCode _Language = null;
		private int _CampaignId = Int32.MinValue;
		private int _MinSendDate = Int32.MinValue;
		private bool? _IsHtml = null;
		private string _Separator = null;
		#endregion

		#region Properties
		public MailType MailType
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
		public MailJobStatus Status
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
		public LanguageCode Language
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
		public MailJobData()
		{
		}

		public MailJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "mailType":
						this._MailType = (MailType)StringEnum.Parse(typeof(MailType), propertyNode.InnerText);
						continue;
					case "mailPriority":
						this._MailPriority = ParseInt(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (MailJobStatus)ParseEnum(typeof(MailJobStatus), propertyNode.InnerText);
						continue;
					case "recipientName":
						this._RecipientName = propertyNode.InnerText;
						continue;
					case "recipientEmail":
						this._RecipientEmail = propertyNode.InnerText;
						continue;
					case "recipientId":
						this._RecipientId = ParseInt(propertyNode.InnerText);
						continue;
					case "fromName":
						this._FromName = propertyNode.InnerText;
						continue;
					case "fromEmail":
						this._FromEmail = propertyNode.InnerText;
						continue;
					case "bodyParams":
						this._BodyParams = propertyNode.InnerText;
						continue;
					case "subjectParams":
						this._SubjectParams = propertyNode.InnerText;
						continue;
					case "templatePath":
						this._TemplatePath = propertyNode.InnerText;
						continue;
					case "language":
						this._Language = (LanguageCode)StringEnum.Parse(typeof(LanguageCode), propertyNode.InnerText);
						continue;
					case "campaignId":
						this._CampaignId = ParseInt(propertyNode.InnerText);
						continue;
					case "minSendDate":
						this._MinSendDate = ParseInt(propertyNode.InnerText);
						continue;
					case "isHtml":
						this._IsHtml = ParseBool(propertyNode.InnerText);
						continue;
					case "separator":
						this._Separator = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaMailJobData");
			kparams.AddIfNotNull("mailType", this._MailType);
			kparams.AddIfNotNull("mailPriority", this._MailPriority);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("recipientName", this._RecipientName);
			kparams.AddIfNotNull("recipientEmail", this._RecipientEmail);
			kparams.AddIfNotNull("recipientId", this._RecipientId);
			kparams.AddIfNotNull("fromName", this._FromName);
			kparams.AddIfNotNull("fromEmail", this._FromEmail);
			kparams.AddIfNotNull("bodyParams", this._BodyParams);
			kparams.AddIfNotNull("subjectParams", this._SubjectParams);
			kparams.AddIfNotNull("templatePath", this._TemplatePath);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("campaignId", this._CampaignId);
			kparams.AddIfNotNull("minSendDate", this._MinSendDate);
			kparams.AddIfNotNull("isHtml", this._IsHtml);
			kparams.AddIfNotNull("separator", this._Separator);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MAIL_TYPE:
					return "MailType";
				case MAIL_PRIORITY:
					return "MailPriority";
				case STATUS:
					return "Status";
				case RECIPIENT_NAME:
					return "RecipientName";
				case RECIPIENT_EMAIL:
					return "RecipientEmail";
				case RECIPIENT_ID:
					return "RecipientId";
				case FROM_NAME:
					return "FromName";
				case FROM_EMAIL:
					return "FromEmail";
				case BODY_PARAMS:
					return "BodyParams";
				case SUBJECT_PARAMS:
					return "SubjectParams";
				case TEMPLATE_PATH:
					return "TemplatePath";
				case LANGUAGE:
					return "Language";
				case CAMPAIGN_ID:
					return "CampaignId";
				case MIN_SEND_DATE:
					return "MinSendDate";
				case IS_HTML:
					return "IsHtml";
				case SEPARATOR:
					return "Separator";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

