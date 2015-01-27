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
	public class KalturaAuditTrail : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _ParsedAt = Int32.MinValue;
		private KalturaAuditTrailStatus _Status = (KalturaAuditTrailStatus)Int32.MinValue;
		private KalturaAuditTrailObjectType _AuditObjectType = null;
		private string _ObjectId = null;
		private string _RelatedObjectId = null;
		private KalturaAuditTrailObjectType _RelatedObjectType = null;
		private string _EntryId = null;
		private int _MasterPartnerId = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _RequestId = null;
		private string _UserId = null;
		private KalturaAuditTrailAction _Action = null;
		private KalturaAuditTrailInfo _Data;
		private string _Ks = null;
		private KalturaAuditTrailContext _Context = (KalturaAuditTrailContext)Int32.MinValue;
		private string _EntryPoint = null;
		private string _ServerName = null;
		private string _IpAddress = null;
		private string _UserAgent = null;
		private string _ClientTag = null;
		private string _Description = null;
		private string _ErrorDescription = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
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
		public int ParsedAt
		{
			get { return _ParsedAt; }
			set 
			{ 
				_ParsedAt = value;
				OnPropertyChanged("ParsedAt");
			}
		}
		public KalturaAuditTrailStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaAuditTrailObjectType AuditObjectType
		{
			get { return _AuditObjectType; }
			set 
			{ 
				_AuditObjectType = value;
				OnPropertyChanged("AuditObjectType");
			}
		}
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		public string RelatedObjectId
		{
			get { return _RelatedObjectId; }
			set 
			{ 
				_RelatedObjectId = value;
				OnPropertyChanged("RelatedObjectId");
			}
		}
		public KalturaAuditTrailObjectType RelatedObjectType
		{
			get { return _RelatedObjectType; }
			set 
			{ 
				_RelatedObjectType = value;
				OnPropertyChanged("RelatedObjectType");
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
		public int MasterPartnerId
		{
			get { return _MasterPartnerId; }
			set 
			{ 
				_MasterPartnerId = value;
				OnPropertyChanged("MasterPartnerId");
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
		public string RequestId
		{
			get { return _RequestId; }
			set 
			{ 
				_RequestId = value;
				OnPropertyChanged("RequestId");
			}
		}
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public KalturaAuditTrailAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		public KalturaAuditTrailInfo Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		public string Ks
		{
			get { return _Ks; }
			set 
			{ 
				_Ks = value;
				OnPropertyChanged("Ks");
			}
		}
		public KalturaAuditTrailContext Context
		{
			get { return _Context; }
			set 
			{ 
				_Context = value;
				OnPropertyChanged("Context");
			}
		}
		public string EntryPoint
		{
			get { return _EntryPoint; }
			set 
			{ 
				_EntryPoint = value;
				OnPropertyChanged("EntryPoint");
			}
		}
		public string ServerName
		{
			get { return _ServerName; }
			set 
			{ 
				_ServerName = value;
				OnPropertyChanged("ServerName");
			}
		}
		public string IpAddress
		{
			get { return _IpAddress; }
			set 
			{ 
				_IpAddress = value;
				OnPropertyChanged("IpAddress");
			}
		}
		public string UserAgent
		{
			get { return _UserAgent; }
			set 
			{ 
				_UserAgent = value;
				OnPropertyChanged("UserAgent");
			}
		}
		public string ClientTag
		{
			get { return _ClientTag; }
			set 
			{ 
				_ClientTag = value;
				OnPropertyChanged("ClientTag");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		#endregion

		#region CTor
		public KalturaAuditTrail()
		{
		}

		public KalturaAuditTrail(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "parsedAt":
						this.ParsedAt = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaAuditTrailStatus)ParseEnum(typeof(KalturaAuditTrailStatus), txt);
						continue;
					case "auditObjectType":
						this.AuditObjectType = (KalturaAuditTrailObjectType)KalturaStringEnum.Parse(typeof(KalturaAuditTrailObjectType), txt);
						continue;
					case "objectId":
						this.ObjectId = txt;
						continue;
					case "relatedObjectId":
						this.RelatedObjectId = txt;
						continue;
					case "relatedObjectType":
						this.RelatedObjectType = (KalturaAuditTrailObjectType)KalturaStringEnum.Parse(typeof(KalturaAuditTrailObjectType), txt);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "masterPartnerId":
						this.MasterPartnerId = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "requestId":
						this.RequestId = txt;
						continue;
					case "userId":
						this.UserId = txt;
						continue;
					case "action":
						this.Action = (KalturaAuditTrailAction)KalturaStringEnum.Parse(typeof(KalturaAuditTrailAction), txt);
						continue;
					case "data":
						this.Data = (KalturaAuditTrailInfo)KalturaObjectFactory.Create(propertyNode, "KalturaAuditTrailInfo");
						continue;
					case "ks":
						this.Ks = txt;
						continue;
					case "context":
						this.Context = (KalturaAuditTrailContext)ParseEnum(typeof(KalturaAuditTrailContext), txt);
						continue;
					case "entryPoint":
						this.EntryPoint = txt;
						continue;
					case "serverName":
						this.ServerName = txt;
						continue;
					case "ipAddress":
						this.IpAddress = txt;
						continue;
					case "userAgent":
						this.UserAgent = txt;
						continue;
					case "clientTag":
						this.ClientTag = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "errorDescription":
						this.ErrorDescription = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAuditTrail");
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("parsedAt", this.ParsedAt);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddStringEnumIfNotNull("auditObjectType", this.AuditObjectType);
			kparams.AddStringIfNotNull("objectId", this.ObjectId);
			kparams.AddStringIfNotNull("relatedObjectId", this.RelatedObjectId);
			kparams.AddStringEnumIfNotNull("relatedObjectType", this.RelatedObjectType);
			kparams.AddStringIfNotNull("entryId", this.EntryId);
			kparams.AddIntIfNotNull("masterPartnerId", this.MasterPartnerId);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("requestId", this.RequestId);
			kparams.AddStringIfNotNull("userId", this.UserId);
			kparams.AddStringEnumIfNotNull("action", this.Action);
			if (this.Data != null)
				kparams.Add("data", this.Data.ToParams());
			kparams.AddStringIfNotNull("ks", this.Ks);
			kparams.AddEnumIfNotNull("context", this.Context);
			kparams.AddStringIfNotNull("entryPoint", this.EntryPoint);
			kparams.AddStringIfNotNull("serverName", this.ServerName);
			kparams.AddStringIfNotNull("ipAddress", this.IpAddress);
			kparams.AddStringIfNotNull("userAgent", this.UserAgent);
			kparams.AddStringIfNotNull("clientTag", this.ClientTag);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringIfNotNull("errorDescription", this.ErrorDescription);
			return kparams;
		}
		#endregion
	}
}

