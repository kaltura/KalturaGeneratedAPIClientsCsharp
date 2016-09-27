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
	public class KalturaSessionInfo : KalturaObjectBase
	{
		#region Private Fields
		private string _Ks = null;
		private KalturaSessionType _SessionType = (KalturaSessionType)Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _UserId = null;
		private int _Expiry = Int32.MinValue;
		private string _Privileges = null;
		#endregion

		#region Properties
		public string Ks
		{
			get { return _Ks; }
		}
		public KalturaSessionType SessionType
		{
			get { return _SessionType; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public string UserId
		{
			get { return _UserId; }
		}
		public int Expiry
		{
			get { return _Expiry; }
		}
		public string Privileges
		{
			get { return _Privileges; }
		}
		#endregion

		#region CTor
		public KalturaSessionInfo()
		{
		}

		public KalturaSessionInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "ks":
						this._Ks = txt;
						continue;
					case "sessionType":
						this._SessionType = (KalturaSessionType)ParseEnum(typeof(KalturaSessionType), txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "userId":
						this._UserId = txt;
						continue;
					case "expiry":
						this._Expiry = ParseInt(txt);
						continue;
					case "privileges":
						this._Privileges = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSessionInfo");
			kparams.AddIfNotNull("ks", this._Ks);
			kparams.AddIfNotNull("sessionType", this._SessionType);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("expiry", this._Expiry);
			kparams.AddIfNotNull("privileges", this._Privileges);
			return kparams;
		}
		#endregion
	}
}

