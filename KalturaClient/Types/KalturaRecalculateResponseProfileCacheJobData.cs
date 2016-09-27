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
	public class KalturaRecalculateResponseProfileCacheJobData : KalturaRecalculateCacheJobData
	{
		#region Private Fields
		private string _Protocol = null;
		private KalturaSessionType _KsType = (KalturaSessionType)Int32.MinValue;
		private IList<KalturaIntegerValue> _UserRoles;
		private string _CachedObjectType = null;
		private string _ObjectId = null;
		private string _StartObjectKey = null;
		private string _EndObjectKey = null;
		#endregion

		#region Properties
		public string Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		public KalturaSessionType KsType
		{
			get { return _KsType; }
			set 
			{ 
				_KsType = value;
				OnPropertyChanged("KsType");
			}
		}
		public new IList<KalturaIntegerValue> UserRoles
		{
			get { return _UserRoles; }
			set 
			{ 
				_UserRoles = value;
				OnPropertyChanged("UserRoles");
			}
		}
		public string CachedObjectType
		{
			get { return _CachedObjectType; }
			set 
			{ 
				_CachedObjectType = value;
				OnPropertyChanged("CachedObjectType");
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
		public string StartObjectKey
		{
			get { return _StartObjectKey; }
			set 
			{ 
				_StartObjectKey = value;
				OnPropertyChanged("StartObjectKey");
			}
		}
		public string EndObjectKey
		{
			get { return _EndObjectKey; }
			set 
			{ 
				_EndObjectKey = value;
				OnPropertyChanged("EndObjectKey");
			}
		}
		#endregion

		#region CTor
		public KalturaRecalculateResponseProfileCacheJobData()
		{
		}

		public KalturaRecalculateResponseProfileCacheJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "protocol":
						this._Protocol = txt;
						continue;
					case "ksType":
						this._KsType = (KalturaSessionType)ParseEnum(typeof(KalturaSessionType), txt);
						continue;
					case "userRoles":
						this._UserRoles = new List<KalturaIntegerValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._UserRoles.Add((KalturaIntegerValue)KalturaObjectFactory.Create(arrayNode, "KalturaIntegerValue"));
						}
						continue;
					case "cachedObjectType":
						this._CachedObjectType = txt;
						continue;
					case "objectId":
						this._ObjectId = txt;
						continue;
					case "startObjectKey":
						this._StartObjectKey = txt;
						continue;
					case "endObjectKey":
						this._EndObjectKey = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaRecalculateResponseProfileCacheJobData");
			kparams.AddIfNotNull("protocol", this._Protocol);
			kparams.AddIfNotNull("ksType", this._KsType);
			kparams.AddIfNotNull("userRoles", this._UserRoles);
			kparams.AddIfNotNull("cachedObjectType", this._CachedObjectType);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("startObjectKey", this._StartObjectKey);
			kparams.AddIfNotNull("endObjectKey", this._EndObjectKey);
			return kparams;
		}
		#endregion
	}
}

