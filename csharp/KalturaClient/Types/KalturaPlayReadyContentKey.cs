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
	public class KalturaPlayReadyContentKey : KalturaObjectBase
	{
		#region Private Fields
		private string _KeyId = null;
		private string _ContentKey = null;
		#endregion

		#region Properties
		public string KeyId
		{
			get { return _KeyId; }
			set 
			{ 
				_KeyId = value;
				OnPropertyChanged("KeyId");
			}
		}
		public string ContentKey
		{
			get { return _ContentKey; }
			set 
			{ 
				_ContentKey = value;
				OnPropertyChanged("ContentKey");
			}
		}
		#endregion

		#region CTor
		public KalturaPlayReadyContentKey()
		{
		}

		public KalturaPlayReadyContentKey(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "keyId":
						this.KeyId = txt;
						continue;
					case "contentKey":
						this.ContentKey = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPlayReadyContentKey");
			kparams.AddStringIfNotNull("keyId", this.KeyId);
			kparams.AddStringIfNotNull("contentKey", this.ContentKey);
			return kparams;
		}
		#endregion
	}
}

