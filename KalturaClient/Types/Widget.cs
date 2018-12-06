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
	public class Widget : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string SOURCE_WIDGET_ID = "sourceWidgetId";
		public const string ROOT_WIDGET_ID = "rootWidgetId";
		public const string PARTNER_ID = "partnerId";
		public const string ENTRY_ID = "entryId";
		public const string UI_CONF_ID = "uiConfId";
		public const string SECURITY_TYPE = "securityType";
		public const string SECURITY_POLICY = "securityPolicy";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string PARTNER_DATA = "partnerData";
		public const string WIDGET_HT_ML = "widgetHTML";
		public const string ENFORCE_ENTITLEMENT = "enforceEntitlement";
		public const string PRIVACY_CONTEXT = "privacyContext";
		public const string ADD_EMBED_HTML5SUPPORT = "addEmbedHtml5Support";
		public const string ROLES = "roles";
		#endregion

		#region Private Fields
		private string _Id = null;
		private string _SourceWidgetId = null;
		private string _RootWidgetId = null;
		private int _PartnerId = Int32.MinValue;
		private string _EntryId = null;
		private int _UiConfId = Int32.MinValue;
		private WidgetSecurityType _SecurityType = (WidgetSecurityType)Int32.MinValue;
		private int _SecurityPolicy = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _PartnerData = null;
		private string _WidgetHTML = null;
		private bool? _EnforceEntitlement = null;
		private string _PrivacyContext = null;
		private bool? _AddEmbedHtml5Support = null;
		private string _Roles = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
		}
		public string SourceWidgetId
		{
			get { return _SourceWidgetId; }
			set 
			{ 
				_SourceWidgetId = value;
				OnPropertyChanged("SourceWidgetId");
			}
		}
		public string RootWidgetId
		{
			get { return _RootWidgetId; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public int UiConfId
		{
			get { return _UiConfId; }
			set 
			{ 
				_UiConfId = value;
				OnPropertyChanged("UiConfId");
			}
		}
		public WidgetSecurityType SecurityType
		{
			get { return _SecurityType; }
			set 
			{ 
				_SecurityType = value;
				OnPropertyChanged("SecurityType");
			}
		}
		public int SecurityPolicy
		{
			get { return _SecurityPolicy; }
			set 
			{ 
				_SecurityPolicy = value;
				OnPropertyChanged("SecurityPolicy");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		public string WidgetHTML
		{
			get { return _WidgetHTML; }
		}
		public bool? EnforceEntitlement
		{
			get { return _EnforceEntitlement; }
			set 
			{ 
				_EnforceEntitlement = value;
				OnPropertyChanged("EnforceEntitlement");
			}
		}
		public string PrivacyContext
		{
			get { return _PrivacyContext; }
			set 
			{ 
				_PrivacyContext = value;
				OnPropertyChanged("PrivacyContext");
			}
		}
		public bool? AddEmbedHtml5Support
		{
			get { return _AddEmbedHtml5Support; }
			set 
			{ 
				_AddEmbedHtml5Support = value;
				OnPropertyChanged("AddEmbedHtml5Support");
			}
		}
		public string Roles
		{
			get { return _Roles; }
			set 
			{ 
				_Roles = value;
				OnPropertyChanged("Roles");
			}
		}
		#endregion

		#region CTor
		public Widget()
		{
		}

		public Widget(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "sourceWidgetId":
						this._SourceWidgetId = propertyNode.InnerText;
						continue;
					case "rootWidgetId":
						this._RootWidgetId = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "uiConfId":
						this._UiConfId = ParseInt(propertyNode.InnerText);
						continue;
					case "securityType":
						this._SecurityType = (WidgetSecurityType)ParseEnum(typeof(WidgetSecurityType), propertyNode.InnerText);
						continue;
					case "securityPolicy":
						this._SecurityPolicy = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerData":
						this._PartnerData = propertyNode.InnerText;
						continue;
					case "widgetHTML":
						this._WidgetHTML = propertyNode.InnerText;
						continue;
					case "enforceEntitlement":
						this._EnforceEntitlement = ParseBool(propertyNode.InnerText);
						continue;
					case "privacyContext":
						this._PrivacyContext = propertyNode.InnerText;
						continue;
					case "addEmbedHtml5Support":
						this._AddEmbedHtml5Support = ParseBool(propertyNode.InnerText);
						continue;
					case "roles":
						this._Roles = propertyNode.InnerText;
						continue;
				}
			}
		}

		public Widget(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<string>("id");
			    this._SourceWidgetId = data.TryGetValueSafe<string>("sourceWidgetId");
			    this._RootWidgetId = data.TryGetValueSafe<string>("rootWidgetId");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._EntryId = data.TryGetValueSafe<string>("entryId");
			    this._UiConfId = data.TryGetValueSafe<int>("uiConfId");
			    this._SecurityType = (WidgetSecurityType)ParseEnum(typeof(WidgetSecurityType), data.TryGetValueSafe<int>("securityType"));
			    this._SecurityPolicy = data.TryGetValueSafe<int>("securityPolicy");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._PartnerData = data.TryGetValueSafe<string>("partnerData");
			    this._WidgetHTML = data.TryGetValueSafe<string>("widgetHTML");
			    this._EnforceEntitlement = data.TryGetValueSafe<bool>("enforceEntitlement");
			    this._PrivacyContext = data.TryGetValueSafe<string>("privacyContext");
			    this._AddEmbedHtml5Support = data.TryGetValueSafe<bool>("addEmbedHtml5Support");
			    this._Roles = data.TryGetValueSafe<string>("roles");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaWidget");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("sourceWidgetId", this._SourceWidgetId);
			kparams.AddIfNotNull("rootWidgetId", this._RootWidgetId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("uiConfId", this._UiConfId);
			kparams.AddIfNotNull("securityType", this._SecurityType);
			kparams.AddIfNotNull("securityPolicy", this._SecurityPolicy);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("partnerData", this._PartnerData);
			kparams.AddIfNotNull("widgetHTML", this._WidgetHTML);
			kparams.AddIfNotNull("enforceEntitlement", this._EnforceEntitlement);
			kparams.AddIfNotNull("privacyContext", this._PrivacyContext);
			kparams.AddIfNotNull("addEmbedHtml5Support", this._AddEmbedHtml5Support);
			kparams.AddIfNotNull("roles", this._Roles);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case SOURCE_WIDGET_ID:
					return "SourceWidgetId";
				case ROOT_WIDGET_ID:
					return "RootWidgetId";
				case PARTNER_ID:
					return "PartnerId";
				case ENTRY_ID:
					return "EntryId";
				case UI_CONF_ID:
					return "UiConfId";
				case SECURITY_TYPE:
					return "SecurityType";
				case SECURITY_POLICY:
					return "SecurityPolicy";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case PARTNER_DATA:
					return "PartnerData";
				case WIDGET_HT_ML:
					return "WidgetHTML";
				case ENFORCE_ENTITLEMENT:
					return "EnforceEntitlement";
				case PRIVACY_CONTEXT:
					return "PrivacyContext";
				case ADD_EMBED_HTML5SUPPORT:
					return "AddEmbedHtml5Support";
				case ROLES:
					return "Roles";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

