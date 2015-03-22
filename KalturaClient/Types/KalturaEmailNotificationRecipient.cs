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
	public class KalturaEmailNotificationRecipient : KalturaObjectBase
	{
		#region Private Fields
		private KalturaStringValue _Email;
		private KalturaStringValue _Name;
		#endregion

		#region Properties
		public KalturaStringValue Email
		{
			get { return _Email; }
			set 
			{ 
				_Email = value;
				OnPropertyChanged("Email");
			}
		}
		public KalturaStringValue Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		#endregion

		#region CTor
		public KalturaEmailNotificationRecipient()
		{
		}

		public KalturaEmailNotificationRecipient(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "email":
						this.Email = (KalturaStringValue)KalturaObjectFactory.Create(propertyNode, "KalturaStringValue");
						continue;
					case "name":
						this.Name = (KalturaStringValue)KalturaObjectFactory.Create(propertyNode, "KalturaStringValue");
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEmailNotificationRecipient");
			if (this.Email != null)
				kparams.Add("email", this.Email.ToParams());
			if (this.Name != null)
				kparams.Add("name", this.Name.ToParams());
			return kparams;
		}
		#endregion
	}
}

