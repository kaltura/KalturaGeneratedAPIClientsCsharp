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
	public class KalturaAppToken : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private string _Token = null;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private KalturaAppTokenStatus _Status = (KalturaAppTokenStatus)Int32.MinValue;
		private int _Expiry = Int32.MinValue;
		private KalturaSessionType _SessionType = (KalturaSessionType)Int32.MinValue;
		private string _SessionUserId = null;
		private int _SessionDuration = Int32.MinValue;
		private string _SessionPrivileges = null;
		private KalturaAppTokenHashType _HashType = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
		}
		public string Token
		{
			get { return _Token; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public KalturaAppTokenStatus Status
		{
			get { return _Status; }
		}
		public int Expiry
		{
			get { return _Expiry; }
			set 
			{ 
				_Expiry = value;
				OnPropertyChanged("Expiry");
			}
		}
		public KalturaSessionType SessionType
		{
			get { return _SessionType; }
			set 
			{ 
				_SessionType = value;
				OnPropertyChanged("SessionType");
			}
		}
		public string SessionUserId
		{
			get { return _SessionUserId; }
			set 
			{ 
				_SessionUserId = value;
				OnPropertyChanged("SessionUserId");
			}
		}
		public int SessionDuration
		{
			get { return _SessionDuration; }
			set 
			{ 
				_SessionDuration = value;
				OnPropertyChanged("SessionDuration");
			}
		}
		public string SessionPrivileges
		{
			get { return _SessionPrivileges; }
			set 
			{ 
				_SessionPrivileges = value;
				OnPropertyChanged("SessionPrivileges");
			}
		}
		public KalturaAppTokenHashType HashType
		{
			get { return _HashType; }
			set 
			{ 
				_HashType = value;
				OnPropertyChanged("HashType");
			}
		}
		#endregion

		#region CTor
		public KalturaAppToken()
		{
		}

		public KalturaAppToken(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = txt;
						continue;
					case "token":
						this._Token = txt;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "status":
						this._Status = (KalturaAppTokenStatus)ParseEnum(typeof(KalturaAppTokenStatus), txt);
						continue;
					case "expiry":
						this._Expiry = ParseInt(txt);
						continue;
					case "sessionType":
						this._SessionType = (KalturaSessionType)ParseEnum(typeof(KalturaSessionType), txt);
						continue;
					case "sessionUserId":
						this._SessionUserId = txt;
						continue;
					case "sessionDuration":
						this._SessionDuration = ParseInt(txt);
						continue;
					case "sessionPrivileges":
						this._SessionPrivileges = txt;
						continue;
					case "hashType":
						this._HashType = (KalturaAppTokenHashType)KalturaStringEnum.Parse(typeof(KalturaAppTokenHashType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAppToken");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("token", this._Token);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("expiry", this._Expiry);
			kparams.AddIfNotNull("sessionType", this._SessionType);
			kparams.AddIfNotNull("sessionUserId", this._SessionUserId);
			kparams.AddIfNotNull("sessionDuration", this._SessionDuration);
			kparams.AddIfNotNull("sessionPrivileges", this._SessionPrivileges);
			kparams.AddIfNotNull("hashType", this._HashType);
			return kparams;
		}
		#endregion
	}
}

