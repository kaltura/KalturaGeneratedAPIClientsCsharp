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
	public class BpmEventNotificationIntegrationJobTriggerData : IntegrationJobTriggerData
	{
		#region Constants
		public const string TEMPLATE_ID = "templateId";
		public const string BUSINESS_PROCESS_ID = "businessProcessId";
		public const string CASE_ID = "caseId";
		#endregion

		#region Private Fields
		private int _TemplateId = Int32.MinValue;
		private string _BusinessProcessId = null;
		private string _CaseId = null;
		#endregion

		#region Properties
		public int TemplateId
		{
			get { return _TemplateId; }
			set 
			{ 
				_TemplateId = value;
				OnPropertyChanged("TemplateId");
			}
		}
		public string BusinessProcessId
		{
			get { return _BusinessProcessId; }
			set 
			{ 
				_BusinessProcessId = value;
				OnPropertyChanged("BusinessProcessId");
			}
		}
		public string CaseId
		{
			get { return _CaseId; }
			set 
			{ 
				_CaseId = value;
				OnPropertyChanged("CaseId");
			}
		}
		#endregion

		#region CTor
		public BpmEventNotificationIntegrationJobTriggerData()
		{
		}

		public BpmEventNotificationIntegrationJobTriggerData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "templateId":
						this._TemplateId = ParseInt(propertyNode.InnerText);
						continue;
					case "businessProcessId":
						this._BusinessProcessId = propertyNode.InnerText;
						continue;
					case "caseId":
						this._CaseId = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaBpmEventNotificationIntegrationJobTriggerData");
			kparams.AddIfNotNull("templateId", this._TemplateId);
			kparams.AddIfNotNull("businessProcessId", this._BusinessProcessId);
			kparams.AddIfNotNull("caseId", this._CaseId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TEMPLATE_ID:
					return "TemplateId";
				case BUSINESS_PROCESS_ID:
					return "BusinessProcessId";
				case CASE_ID:
					return "CaseId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

