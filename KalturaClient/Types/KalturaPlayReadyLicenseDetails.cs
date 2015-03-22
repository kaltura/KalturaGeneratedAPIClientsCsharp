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
	public class KalturaPlayReadyLicenseDetails : KalturaObjectBase
	{
		#region Private Fields
		private KalturaPlayReadyPolicy _Policy;
		private int _BeginDate = Int32.MinValue;
		private int _ExpirationDate = Int32.MinValue;
		private int _RemovalDate = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaPlayReadyPolicy Policy
		{
			get { return _Policy; }
			set 
			{ 
				_Policy = value;
				OnPropertyChanged("Policy");
			}
		}
		public int BeginDate
		{
			get { return _BeginDate; }
			set 
			{ 
				_BeginDate = value;
				OnPropertyChanged("BeginDate");
			}
		}
		public int ExpirationDate
		{
			get { return _ExpirationDate; }
			set 
			{ 
				_ExpirationDate = value;
				OnPropertyChanged("ExpirationDate");
			}
		}
		public int RemovalDate
		{
			get { return _RemovalDate; }
			set 
			{ 
				_RemovalDate = value;
				OnPropertyChanged("RemovalDate");
			}
		}
		#endregion

		#region CTor
		public KalturaPlayReadyLicenseDetails()
		{
		}

		public KalturaPlayReadyLicenseDetails(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "policy":
						this.Policy = (KalturaPlayReadyPolicy)KalturaObjectFactory.Create(propertyNode, "KalturaPlayReadyPolicy");
						continue;
					case "beginDate":
						this.BeginDate = ParseInt(txt);
						continue;
					case "expirationDate":
						this.ExpirationDate = ParseInt(txt);
						continue;
					case "removalDate":
						this.RemovalDate = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPlayReadyLicenseDetails");
			if (this.Policy != null)
				kparams.Add("policy", this.Policy.ToParams());
			kparams.AddIntIfNotNull("beginDate", this.BeginDate);
			kparams.AddIntIfNotNull("expirationDate", this.ExpirationDate);
			kparams.AddIntIfNotNull("removalDate", this.RemovalDate);
			return kparams;
		}
		#endregion
	}
}

