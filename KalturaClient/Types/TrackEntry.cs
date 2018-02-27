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
	public class TrackEntry : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string TRACK_EVENT_TYPE = "trackEventType";
		public const string PS_VERSION = "psVersion";
		public const string CONTEXT = "context";
		public const string PARTNER_ID = "partnerId";
		public const string ENTRY_ID = "entryId";
		public const string HOST_NAME = "hostName";
		public const string USER_ID = "userId";
		public const string CHANGED_PROPERTIES = "changedProperties";
		public const string PARAM_STR1 = "paramStr1";
		public const string PARAM_STR2 = "paramStr2";
		public const string PARAM_STR3 = "paramStr3";
		public const string KS = "ks";
		public const string DESCRIPTION = "description";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string USER_IP = "userIp";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private TrackEntryEventType _TrackEventType = (TrackEntryEventType)Int32.MinValue;
		private string _PsVersion = null;
		private string _Context = null;
		private int _PartnerId = Int32.MinValue;
		private string _EntryId = null;
		private string _HostName = null;
		private string _UserId = null;
		private string _ChangedProperties = null;
		private string _ParamStr1 = null;
		private string _ParamStr2 = null;
		private string _ParamStr3 = null;
		private string _Ks = null;
		private string _Description = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _UserIp = null;
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
		public TrackEntryEventType TrackEventType
		{
			get { return _TrackEventType; }
			set 
			{ 
				_TrackEventType = value;
				OnPropertyChanged("TrackEventType");
			}
		}
		public string PsVersion
		{
			get { return _PsVersion; }
			set 
			{ 
				_PsVersion = value;
				OnPropertyChanged("PsVersion");
			}
		}
		public string Context
		{
			get { return _Context; }
			set 
			{ 
				_Context = value;
				OnPropertyChanged("Context");
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
		public string HostName
		{
			get { return _HostName; }
			set 
			{ 
				_HostName = value;
				OnPropertyChanged("HostName");
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
		public string ChangedProperties
		{
			get { return _ChangedProperties; }
			set 
			{ 
				_ChangedProperties = value;
				OnPropertyChanged("ChangedProperties");
			}
		}
		public string ParamStr1
		{
			get { return _ParamStr1; }
			set 
			{ 
				_ParamStr1 = value;
				OnPropertyChanged("ParamStr1");
			}
		}
		public string ParamStr2
		{
			get { return _ParamStr2; }
			set 
			{ 
				_ParamStr2 = value;
				OnPropertyChanged("ParamStr2");
			}
		}
		public string ParamStr3
		{
			get { return _ParamStr3; }
			set 
			{ 
				_ParamStr3 = value;
				OnPropertyChanged("ParamStr3");
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
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
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
		public string UserIp
		{
			get { return _UserIp; }
			set 
			{ 
				_UserIp = value;
				OnPropertyChanged("UserIp");
			}
		}
		#endregion

		#region CTor
		public TrackEntry()
		{
		}

		public TrackEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "trackEventType":
						this._TrackEventType = (TrackEntryEventType)ParseEnum(typeof(TrackEntryEventType), propertyNode.InnerText);
						continue;
					case "psVersion":
						this._PsVersion = propertyNode.InnerText;
						continue;
					case "context":
						this._Context = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "hostName":
						this._HostName = propertyNode.InnerText;
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "changedProperties":
						this._ChangedProperties = propertyNode.InnerText;
						continue;
					case "paramStr1":
						this._ParamStr1 = propertyNode.InnerText;
						continue;
					case "paramStr2":
						this._ParamStr2 = propertyNode.InnerText;
						continue;
					case "paramStr3":
						this._ParamStr3 = propertyNode.InnerText;
						continue;
					case "ks":
						this._Ks = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "userIp":
						this._UserIp = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaTrackEntry");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("trackEventType", this._TrackEventType);
			kparams.AddIfNotNull("psVersion", this._PsVersion);
			kparams.AddIfNotNull("context", this._Context);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("hostName", this._HostName);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("changedProperties", this._ChangedProperties);
			kparams.AddIfNotNull("paramStr1", this._ParamStr1);
			kparams.AddIfNotNull("paramStr2", this._ParamStr2);
			kparams.AddIfNotNull("paramStr3", this._ParamStr3);
			kparams.AddIfNotNull("ks", this._Ks);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("userIp", this._UserIp);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case TRACK_EVENT_TYPE:
					return "TrackEventType";
				case PS_VERSION:
					return "PsVersion";
				case CONTEXT:
					return "Context";
				case PARTNER_ID:
					return "PartnerId";
				case ENTRY_ID:
					return "EntryId";
				case HOST_NAME:
					return "HostName";
				case USER_ID:
					return "UserId";
				case CHANGED_PROPERTIES:
					return "ChangedProperties";
				case PARAM_STR1:
					return "ParamStr1";
				case PARAM_STR2:
					return "ParamStr2";
				case PARAM_STR3:
					return "ParamStr3";
				case KS:
					return "Ks";
				case DESCRIPTION:
					return "Description";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case USER_IP:
					return "UserIp";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

