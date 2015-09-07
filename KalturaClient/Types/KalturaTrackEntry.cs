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
	public class KalturaTrackEntry : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private KalturaTrackEntryEventType _TrackEventType = (KalturaTrackEntryEventType)Int32.MinValue;
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
		public KalturaTrackEntryEventType TrackEventType
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
		public KalturaTrackEntry()
		{
		}

		public KalturaTrackEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "trackEventType":
						this.TrackEventType = (KalturaTrackEntryEventType)ParseEnum(typeof(KalturaTrackEntryEventType), txt);
						continue;
					case "psVersion":
						this.PsVersion = txt;
						continue;
					case "context":
						this.Context = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "hostName":
						this.HostName = txt;
						continue;
					case "userId":
						this.UserId = txt;
						continue;
					case "changedProperties":
						this.ChangedProperties = txt;
						continue;
					case "paramStr1":
						this.ParamStr1 = txt;
						continue;
					case "paramStr2":
						this.ParamStr2 = txt;
						continue;
					case "paramStr3":
						this.ParamStr3 = txt;
						continue;
					case "ks":
						this.Ks = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "userIp":
						this.UserIp = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaTrackEntry");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("trackEventType", this.TrackEventType);
			kparams.AddIfNotNull("psVersion", this.PsVersion);
			kparams.AddIfNotNull("context", this.Context);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("entryId", this.EntryId);
			kparams.AddIfNotNull("hostName", this.HostName);
			kparams.AddIfNotNull("userId", this.UserId);
			kparams.AddIfNotNull("changedProperties", this.ChangedProperties);
			kparams.AddIfNotNull("paramStr1", this.ParamStr1);
			kparams.AddIfNotNull("paramStr2", this.ParamStr2);
			kparams.AddIfNotNull("paramStr3", this.ParamStr3);
			kparams.AddIfNotNull("ks", this.Ks);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("userIp", this.UserIp);
			return kparams;
		}
		#endregion
	}
}

