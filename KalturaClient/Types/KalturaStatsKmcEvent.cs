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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class KalturaStatsKmcEvent : KalturaObjectBase
	{
		#region Private Fields
		private string _ClientVer = null;
		private string _KmcEventActionPath = null;
		private KalturaStatsKmcEventType _KmcEventType = (KalturaStatsKmcEventType)Int32.MinValue;
		private float _EventTimestamp = Single.MinValue;
		private string _SessionId = null;
		private int _PartnerId = Int32.MinValue;
		private string _EntryId = null;
		private string _WidgetId = null;
		private int _UiconfId = Int32.MinValue;
		private string _UserId = null;
		private string _UserIp = null;
		#endregion

		#region Properties
		public string ClientVer
		{
			get { return _ClientVer; }
			set 
			{ 
				_ClientVer = value;
				OnPropertyChanged("ClientVer");
			}
		}
		public string KmcEventActionPath
		{
			get { return _KmcEventActionPath; }
			set 
			{ 
				_KmcEventActionPath = value;
				OnPropertyChanged("KmcEventActionPath");
			}
		}
		public KalturaStatsKmcEventType KmcEventType
		{
			get { return _KmcEventType; }
			set 
			{ 
				_KmcEventType = value;
				OnPropertyChanged("KmcEventType");
			}
		}
		public float EventTimestamp
		{
			get { return _EventTimestamp; }
			set 
			{ 
				_EventTimestamp = value;
				OnPropertyChanged("EventTimestamp");
			}
		}
		public string SessionId
		{
			get { return _SessionId; }
			set 
			{ 
				_SessionId = value;
				OnPropertyChanged("SessionId");
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
		public string WidgetId
		{
			get { return _WidgetId; }
			set 
			{ 
				_WidgetId = value;
				OnPropertyChanged("WidgetId");
			}
		}
		public int UiconfId
		{
			get { return _UiconfId; }
			set 
			{ 
				_UiconfId = value;
				OnPropertyChanged("UiconfId");
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
		public string UserIp
		{
			get { return _UserIp; }
		}
		#endregion

		#region CTor
		public KalturaStatsKmcEvent()
		{
		}

		public KalturaStatsKmcEvent(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "clientVer":
						this._ClientVer = txt;
						continue;
					case "kmcEventActionPath":
						this._KmcEventActionPath = txt;
						continue;
					case "kmcEventType":
						this._KmcEventType = (KalturaStatsKmcEventType)ParseEnum(typeof(KalturaStatsKmcEventType), txt);
						continue;
					case "eventTimestamp":
						this._EventTimestamp = ParseFloat(txt);
						continue;
					case "sessionId":
						this._SessionId = txt;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "entryId":
						this._EntryId = txt;
						continue;
					case "widgetId":
						this._WidgetId = txt;
						continue;
					case "uiconfId":
						this._UiconfId = ParseInt(txt);
						continue;
					case "userId":
						this._UserId = txt;
						continue;
					case "userIp":
						this._UserIp = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaStatsKmcEvent");
			kparams.AddIfNotNull("clientVer", this._ClientVer);
			kparams.AddIfNotNull("kmcEventActionPath", this._KmcEventActionPath);
			kparams.AddIfNotNull("kmcEventType", this._KmcEventType);
			kparams.AddIfNotNull("eventTimestamp", this._EventTimestamp);
			kparams.AddIfNotNull("sessionId", this._SessionId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("widgetId", this._WidgetId);
			kparams.AddIfNotNull("uiconfId", this._UiconfId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("userIp", this._UserIp);
			return kparams;
		}
		#endregion
	}
}

