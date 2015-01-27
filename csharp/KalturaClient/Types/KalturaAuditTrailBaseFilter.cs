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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaAuditTrailBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _ParsedAtGreaterThanOrEqual = Int32.MinValue;
		private int _ParsedAtLessThanOrEqual = Int32.MinValue;
		private KalturaAuditTrailStatus _StatusEqual = (KalturaAuditTrailStatus)Int32.MinValue;
		private string _StatusIn = null;
		private KalturaAuditTrailObjectType _AuditObjectTypeEqual = null;
		private string _AuditObjectTypeIn = null;
		private string _ObjectIdEqual = null;
		private string _ObjectIdIn = null;
		private string _RelatedObjectIdEqual = null;
		private string _RelatedObjectIdIn = null;
		private KalturaAuditTrailObjectType _RelatedObjectTypeEqual = null;
		private string _RelatedObjectTypeIn = null;
		private string _EntryIdEqual = null;
		private string _EntryIdIn = null;
		private int _MasterPartnerIdEqual = Int32.MinValue;
		private string _MasterPartnerIdIn = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _RequestIdEqual = null;
		private string _RequestIdIn = null;
		private string _UserIdEqual = null;
		private string _UserIdIn = null;
		private KalturaAuditTrailAction _ActionEqual = null;
		private string _ActionIn = null;
		private string _KsEqual = null;
		private KalturaAuditTrailContext _ContextEqual = (KalturaAuditTrailContext)Int32.MinValue;
		private string _ContextIn = null;
		private string _EntryPointEqual = null;
		private string _EntryPointIn = null;
		private string _ServerNameEqual = null;
		private string _ServerNameIn = null;
		private string _IpAddressEqual = null;
		private string _IpAddressIn = null;
		private string _ClientTagEqual = null;
		#endregion

		#region Properties
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int ParsedAtGreaterThanOrEqual
		{
			get { return _ParsedAtGreaterThanOrEqual; }
			set 
			{ 
				_ParsedAtGreaterThanOrEqual = value;
				OnPropertyChanged("ParsedAtGreaterThanOrEqual");
			}
		}
		public int ParsedAtLessThanOrEqual
		{
			get { return _ParsedAtLessThanOrEqual; }
			set 
			{ 
				_ParsedAtLessThanOrEqual = value;
				OnPropertyChanged("ParsedAtLessThanOrEqual");
			}
		}
		public KalturaAuditTrailStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public KalturaAuditTrailObjectType AuditObjectTypeEqual
		{
			get { return _AuditObjectTypeEqual; }
			set 
			{ 
				_AuditObjectTypeEqual = value;
				OnPropertyChanged("AuditObjectTypeEqual");
			}
		}
		public string AuditObjectTypeIn
		{
			get { return _AuditObjectTypeIn; }
			set 
			{ 
				_AuditObjectTypeIn = value;
				OnPropertyChanged("AuditObjectTypeIn");
			}
		}
		public string ObjectIdEqual
		{
			get { return _ObjectIdEqual; }
			set 
			{ 
				_ObjectIdEqual = value;
				OnPropertyChanged("ObjectIdEqual");
			}
		}
		public string ObjectIdIn
		{
			get { return _ObjectIdIn; }
			set 
			{ 
				_ObjectIdIn = value;
				OnPropertyChanged("ObjectIdIn");
			}
		}
		public string RelatedObjectIdEqual
		{
			get { return _RelatedObjectIdEqual; }
			set 
			{ 
				_RelatedObjectIdEqual = value;
				OnPropertyChanged("RelatedObjectIdEqual");
			}
		}
		public string RelatedObjectIdIn
		{
			get { return _RelatedObjectIdIn; }
			set 
			{ 
				_RelatedObjectIdIn = value;
				OnPropertyChanged("RelatedObjectIdIn");
			}
		}
		public KalturaAuditTrailObjectType RelatedObjectTypeEqual
		{
			get { return _RelatedObjectTypeEqual; }
			set 
			{ 
				_RelatedObjectTypeEqual = value;
				OnPropertyChanged("RelatedObjectTypeEqual");
			}
		}
		public string RelatedObjectTypeIn
		{
			get { return _RelatedObjectTypeIn; }
			set 
			{ 
				_RelatedObjectTypeIn = value;
				OnPropertyChanged("RelatedObjectTypeIn");
			}
		}
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		public string EntryIdIn
		{
			get { return _EntryIdIn; }
			set 
			{ 
				_EntryIdIn = value;
				OnPropertyChanged("EntryIdIn");
			}
		}
		public int MasterPartnerIdEqual
		{
			get { return _MasterPartnerIdEqual; }
			set 
			{ 
				_MasterPartnerIdEqual = value;
				OnPropertyChanged("MasterPartnerIdEqual");
			}
		}
		public string MasterPartnerIdIn
		{
			get { return _MasterPartnerIdIn; }
			set 
			{ 
				_MasterPartnerIdIn = value;
				OnPropertyChanged("MasterPartnerIdIn");
			}
		}
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		public string RequestIdEqual
		{
			get { return _RequestIdEqual; }
			set 
			{ 
				_RequestIdEqual = value;
				OnPropertyChanged("RequestIdEqual");
			}
		}
		public string RequestIdIn
		{
			get { return _RequestIdIn; }
			set 
			{ 
				_RequestIdIn = value;
				OnPropertyChanged("RequestIdIn");
			}
		}
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		public KalturaAuditTrailAction ActionEqual
		{
			get { return _ActionEqual; }
			set 
			{ 
				_ActionEqual = value;
				OnPropertyChanged("ActionEqual");
			}
		}
		public string ActionIn
		{
			get { return _ActionIn; }
			set 
			{ 
				_ActionIn = value;
				OnPropertyChanged("ActionIn");
			}
		}
		public string KsEqual
		{
			get { return _KsEqual; }
			set 
			{ 
				_KsEqual = value;
				OnPropertyChanged("KsEqual");
			}
		}
		public KalturaAuditTrailContext ContextEqual
		{
			get { return _ContextEqual; }
			set 
			{ 
				_ContextEqual = value;
				OnPropertyChanged("ContextEqual");
			}
		}
		public string ContextIn
		{
			get { return _ContextIn; }
			set 
			{ 
				_ContextIn = value;
				OnPropertyChanged("ContextIn");
			}
		}
		public string EntryPointEqual
		{
			get { return _EntryPointEqual; }
			set 
			{ 
				_EntryPointEqual = value;
				OnPropertyChanged("EntryPointEqual");
			}
		}
		public string EntryPointIn
		{
			get { return _EntryPointIn; }
			set 
			{ 
				_EntryPointIn = value;
				OnPropertyChanged("EntryPointIn");
			}
		}
		public string ServerNameEqual
		{
			get { return _ServerNameEqual; }
			set 
			{ 
				_ServerNameEqual = value;
				OnPropertyChanged("ServerNameEqual");
			}
		}
		public string ServerNameIn
		{
			get { return _ServerNameIn; }
			set 
			{ 
				_ServerNameIn = value;
				OnPropertyChanged("ServerNameIn");
			}
		}
		public string IpAddressEqual
		{
			get { return _IpAddressEqual; }
			set 
			{ 
				_IpAddressEqual = value;
				OnPropertyChanged("IpAddressEqual");
			}
		}
		public string IpAddressIn
		{
			get { return _IpAddressIn; }
			set 
			{ 
				_IpAddressIn = value;
				OnPropertyChanged("IpAddressIn");
			}
		}
		public string ClientTagEqual
		{
			get { return _ClientTagEqual; }
			set 
			{ 
				_ClientTagEqual = value;
				OnPropertyChanged("ClientTagEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaAuditTrailBaseFilter()
		{
		}

		public KalturaAuditTrailBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = ParseInt(txt);
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "parsedAtGreaterThanOrEqual":
						this.ParsedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "parsedAtLessThanOrEqual":
						this.ParsedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaAuditTrailStatus)ParseEnum(typeof(KalturaAuditTrailStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "auditObjectTypeEqual":
						this.AuditObjectTypeEqual = (KalturaAuditTrailObjectType)KalturaStringEnum.Parse(typeof(KalturaAuditTrailObjectType), txt);
						continue;
					case "auditObjectTypeIn":
						this.AuditObjectTypeIn = txt;
						continue;
					case "objectIdEqual":
						this.ObjectIdEqual = txt;
						continue;
					case "objectIdIn":
						this.ObjectIdIn = txt;
						continue;
					case "relatedObjectIdEqual":
						this.RelatedObjectIdEqual = txt;
						continue;
					case "relatedObjectIdIn":
						this.RelatedObjectIdIn = txt;
						continue;
					case "relatedObjectTypeEqual":
						this.RelatedObjectTypeEqual = (KalturaAuditTrailObjectType)KalturaStringEnum.Parse(typeof(KalturaAuditTrailObjectType), txt);
						continue;
					case "relatedObjectTypeIn":
						this.RelatedObjectTypeIn = txt;
						continue;
					case "entryIdEqual":
						this.EntryIdEqual = txt;
						continue;
					case "entryIdIn":
						this.EntryIdIn = txt;
						continue;
					case "masterPartnerIdEqual":
						this.MasterPartnerIdEqual = ParseInt(txt);
						continue;
					case "masterPartnerIdIn":
						this.MasterPartnerIdIn = txt;
						continue;
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this.PartnerIdIn = txt;
						continue;
					case "requestIdEqual":
						this.RequestIdEqual = txt;
						continue;
					case "requestIdIn":
						this.RequestIdIn = txt;
						continue;
					case "userIdEqual":
						this.UserIdEqual = txt;
						continue;
					case "userIdIn":
						this.UserIdIn = txt;
						continue;
					case "actionEqual":
						this.ActionEqual = (KalturaAuditTrailAction)KalturaStringEnum.Parse(typeof(KalturaAuditTrailAction), txt);
						continue;
					case "actionIn":
						this.ActionIn = txt;
						continue;
					case "ksEqual":
						this.KsEqual = txt;
						continue;
					case "contextEqual":
						this.ContextEqual = (KalturaAuditTrailContext)ParseEnum(typeof(KalturaAuditTrailContext), txt);
						continue;
					case "contextIn":
						this.ContextIn = txt;
						continue;
					case "entryPointEqual":
						this.EntryPointEqual = txt;
						continue;
					case "entryPointIn":
						this.EntryPointIn = txt;
						continue;
					case "serverNameEqual":
						this.ServerNameEqual = txt;
						continue;
					case "serverNameIn":
						this.ServerNameIn = txt;
						continue;
					case "ipAddressEqual":
						this.IpAddressEqual = txt;
						continue;
					case "ipAddressIn":
						this.IpAddressIn = txt;
						continue;
					case "clientTagEqual":
						this.ClientTagEqual = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAuditTrailBaseFilter");
			kparams.AddIntIfNotNull("idEqual", this.IdEqual);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("parsedAtGreaterThanOrEqual", this.ParsedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("parsedAtLessThanOrEqual", this.ParsedAtLessThanOrEqual);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddStringEnumIfNotNull("auditObjectTypeEqual", this.AuditObjectTypeEqual);
			kparams.AddStringIfNotNull("auditObjectTypeIn", this.AuditObjectTypeIn);
			kparams.AddStringIfNotNull("objectIdEqual", this.ObjectIdEqual);
			kparams.AddStringIfNotNull("objectIdIn", this.ObjectIdIn);
			kparams.AddStringIfNotNull("relatedObjectIdEqual", this.RelatedObjectIdEqual);
			kparams.AddStringIfNotNull("relatedObjectIdIn", this.RelatedObjectIdIn);
			kparams.AddStringEnumIfNotNull("relatedObjectTypeEqual", this.RelatedObjectTypeEqual);
			kparams.AddStringIfNotNull("relatedObjectTypeIn", this.RelatedObjectTypeIn);
			kparams.AddStringIfNotNull("entryIdEqual", this.EntryIdEqual);
			kparams.AddStringIfNotNull("entryIdIn", this.EntryIdIn);
			kparams.AddIntIfNotNull("masterPartnerIdEqual", this.MasterPartnerIdEqual);
			kparams.AddStringIfNotNull("masterPartnerIdIn", this.MasterPartnerIdIn);
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddStringIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddStringIfNotNull("requestIdEqual", this.RequestIdEqual);
			kparams.AddStringIfNotNull("requestIdIn", this.RequestIdIn);
			kparams.AddStringIfNotNull("userIdEqual", this.UserIdEqual);
			kparams.AddStringIfNotNull("userIdIn", this.UserIdIn);
			kparams.AddStringEnumIfNotNull("actionEqual", this.ActionEqual);
			kparams.AddStringIfNotNull("actionIn", this.ActionIn);
			kparams.AddStringIfNotNull("ksEqual", this.KsEqual);
			kparams.AddEnumIfNotNull("contextEqual", this.ContextEqual);
			kparams.AddStringIfNotNull("contextIn", this.ContextIn);
			kparams.AddStringIfNotNull("entryPointEqual", this.EntryPointEqual);
			kparams.AddStringIfNotNull("entryPointIn", this.EntryPointIn);
			kparams.AddStringIfNotNull("serverNameEqual", this.ServerNameEqual);
			kparams.AddStringIfNotNull("serverNameIn", this.ServerNameIn);
			kparams.AddStringIfNotNull("ipAddressEqual", this.IpAddressEqual);
			kparams.AddStringIfNotNull("ipAddressIn", this.IpAddressIn);
			kparams.AddStringIfNotNull("clientTagEqual", this.ClientTagEqual);
			return kparams;
		}
		#endregion
	}
}

