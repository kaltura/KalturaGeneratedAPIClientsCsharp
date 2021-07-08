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
		/// <summary>
		/// Use MailTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MailType MailType
		{
			get { return _MailType; }
			set 
			{ 
				_MailType = value;
				OnPropertyChanged("MailType");
			}
		}
		/// <summary>
		/// Use MailPriorityAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MailPriority
		{
			get { return _MailPriority; }
			set 
			{ 
				_MailPriority = value;
				OnPropertyChanged("MailPriority");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MailJobStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use RecipientNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RecipientName
		{
			get { return _RecipientName; }
			set 
			{ 
				_RecipientName = value;
				OnPropertyChanged("RecipientName");
			}
		}
		/// <summary>
		/// Use RecipientEmailAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RecipientEmail
		{
			get { return _RecipientEmail; }
			set 
			{ 
				_RecipientEmail = value;
				OnPropertyChanged("RecipientEmail");
			}
		}
		/// <summary>
		/// Use RecipientIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RecipientId
		{
			get { return _RecipientId; }
			set 
			{ 
				_RecipientId = value;
				OnPropertyChanged("RecipientId");
			}
		}
		/// <summary>
		/// Use FromNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FromName
		{
			get { return _FromName; }
			set 
			{ 
				_FromName = value;
				OnPropertyChanged("FromName");
			}
		}
		/// <summary>
		/// Use FromEmailAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FromEmail
		{
			get { return _FromEmail; }
			set 
			{ 
				_FromEmail = value;
				OnPropertyChanged("FromEmail");
			}
		}
		/// <summary>
		/// Use BodyParamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string BodyParams
		{
			get { return _BodyParams; }
			set 
			{ 
				_BodyParams = value;
				OnPropertyChanged("BodyParams");
			}
		}
		/// <summary>
		/// Use SubjectParamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SubjectParams
		{
			get { return _SubjectParams; }
			set 
			{ 
				_SubjectParams = value;
				OnPropertyChanged("SubjectParams");
			}
		}
		/// <summary>
		/// Use TemplatePathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TemplatePath
		{
			get { return _TemplatePath; }
			set 
			{ 
				_TemplatePath = value;
				OnPropertyChanged("TemplatePath");
			}
		}
		/// <summary>
		/// Use LanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public LanguageCode Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		/// <summary>
		/// Use CampaignIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CampaignId
		{
			get { return _CampaignId; }
			set 
			{ 
				_CampaignId = value;
				OnPropertyChanged("CampaignId");
			}
		}
		/// <summary>
		/// Use MinSendDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MinSendDate
		{
			get { return _MinSendDate; }
			set 
			{ 
				_MinSendDate = value;
				OnPropertyChanged("MinSendDate");
			}
		}
		/// <summary>
		/// Use IsHtmlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsHtml
		{
			get { return _IsHtml; }
			set 
			{ 
				_IsHtml = value;
				OnPropertyChanged("IsHtml");
			}
		}
		/// <summary>
		/// Use SeparatorAsDouble property instead
		/// </summary>
		[JsonProperty]
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

		public MailJobData(JToken node) : base(node)
		{
			if(node["mailType"] != null)
			{
				this._MailType = (MailType)StringEnum.Parse(typeof(MailType), node["mailType"].Value<string>());
			}
			if(node["mailPriority"] != null)
			{
				this._MailPriority = ParseInt(node["mailPriority"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (MailJobStatus)ParseEnum(typeof(MailJobStatus), node["status"].Value<string>());
			}
			if(node["recipientName"] != null)
			{
				this._RecipientName = node["recipientName"].Value<string>();
			}
			if(node["recipientEmail"] != null)
			{
				this._RecipientEmail = node["recipientEmail"].Value<string>();
			}
			if(node["recipientId"] != null)
			{
				this._RecipientId = ParseInt(node["recipientId"].Value<string>());
			}
			if(node["fromName"] != null)
			{
				this._FromName = node["fromName"].Value<string>();
			}
			if(node["fromEmail"] != null)
			{
				this._FromEmail = node["fromEmail"].Value<string>();
			}
			if(node["bodyParams"] != null)
			{
				this._BodyParams = node["bodyParams"].Value<string>();
			}
			if(node["subjectParams"] != null)
			{
				this._SubjectParams = node["subjectParams"].Value<string>();
			}
			if(node["templatePath"] != null)
			{
				this._TemplatePath = node["templatePath"].Value<string>();
			}
			if(node["language"] != null)
			{
				this._Language = (LanguageCode)StringEnum.Parse(typeof(LanguageCode), node["language"].Value<string>());
			}
			if(node["campaignId"] != null)
			{
				this._CampaignId = ParseInt(node["campaignId"].Value<string>());
			}
			if(node["minSendDate"] != null)
			{
				this._MinSendDate = ParseInt(node["minSendDate"].Value<string>());
			}
			if(node["isHtml"] != null)
			{
				this._IsHtml = ParseBool(node["isHtml"].Value<string>());
			}
			if(node["separator"] != null)
			{
				this._Separator = node["separator"].Value<string>();
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

