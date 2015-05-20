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
	public class KalturaWidget : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private string _SourceWidgetId = null;
		private string _RootWidgetId = null;
		private int _PartnerId = Int32.MinValue;
		private string _EntryId = null;
		private int _UiConfId = Int32.MinValue;
		private KalturaWidgetSecurityType _SecurityType = (KalturaWidgetSecurityType)Int32.MinValue;
		private int _SecurityPolicy = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _PartnerData = null;
		private string _WidgetHTML = null;
		private bool? _EnforceEntitlement = false;
		private string _PrivacyContext = null;
		private bool? _AddEmbedHtml5Support = false;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
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
			set 
			{ 
				_RootWidgetId = value;
				OnPropertyChanged("RootWidgetId");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
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
		public KalturaWidgetSecurityType SecurityType
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
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
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
			set 
			{ 
				_WidgetHTML = value;
				OnPropertyChanged("WidgetHTML");
			}
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
		#endregion

		#region CTor
		public KalturaWidget()
		{
		}

		public KalturaWidget(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = txt;
						continue;
					case "sourceWidgetId":
						this.SourceWidgetId = txt;
						continue;
					case "rootWidgetId":
						this.RootWidgetId = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "uiConfId":
						this.UiConfId = ParseInt(txt);
						continue;
					case "securityType":
						this.SecurityType = (KalturaWidgetSecurityType)ParseEnum(typeof(KalturaWidgetSecurityType), txt);
						continue;
					case "securityPolicy":
						this.SecurityPolicy = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "partnerData":
						this.PartnerData = txt;
						continue;
					case "widgetHTML":
						this.WidgetHTML = txt;
						continue;
					case "enforceEntitlement":
						this.EnforceEntitlement = ParseBool(txt);
						continue;
					case "privacyContext":
						this.PrivacyContext = txt;
						continue;
					case "addEmbedHtml5Support":
						this.AddEmbedHtml5Support = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaWidget");
			kparams.AddStringIfNotNull("id", this.Id);
			kparams.AddStringIfNotNull("sourceWidgetId", this.SourceWidgetId);
			kparams.AddStringIfNotNull("rootWidgetId", this.RootWidgetId);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("entryId", this.EntryId);
			kparams.AddIntIfNotNull("uiConfId", this.UiConfId);
			kparams.AddEnumIfNotNull("securityType", this.SecurityType);
			kparams.AddIntIfNotNull("securityPolicy", this.SecurityPolicy);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddStringIfNotNull("partnerData", this.PartnerData);
			kparams.AddStringIfNotNull("widgetHTML", this.WidgetHTML);
			kparams.AddBoolIfNotNull("enforceEntitlement", this.EnforceEntitlement);
			kparams.AddStringIfNotNull("privacyContext", this.PrivacyContext);
			kparams.AddBoolIfNotNull("addEmbedHtml5Support", this.AddEmbedHtml5Support);
			return kparams;
		}
		#endregion
	}
}

