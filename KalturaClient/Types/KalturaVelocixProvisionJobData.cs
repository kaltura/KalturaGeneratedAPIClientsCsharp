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
	public class KalturaVelocixProvisionJobData : KalturaProvisionJobData
	{
		#region Private Fields
		private IList<KalturaKeyValue> _ProvisioningParams;
		private string _UserName = null;
		private string _Password = null;
		#endregion

		#region Properties
		public IList<KalturaKeyValue> ProvisioningParams
		{
			get { return _ProvisioningParams; }
			set 
			{ 
				_ProvisioningParams = value;
				OnPropertyChanged("ProvisioningParams");
			}
		}
		public string UserName
		{
			get { return _UserName; }
			set 
			{ 
				_UserName = value;
				OnPropertyChanged("UserName");
			}
		}
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		#endregion

		#region CTor
		public KalturaVelocixProvisionJobData()
		{
		}

		public KalturaVelocixProvisionJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "provisioningParams":
						this.ProvisioningParams = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.ProvisioningParams.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
					case "userName":
						this.UserName = txt;
						continue;
					case "password":
						this.Password = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaVelocixProvisionJobData");
			if (this.ProvisioningParams != null)
			{
				if (this.ProvisioningParams.Count == 0)
				{
					kparams.Add("provisioningParams:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaKeyValue item in this.ProvisioningParams)
					{
						kparams.Add("provisioningParams:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("userName", this.UserName);
			kparams.AddStringIfNotNull("password", this.Password);
			return kparams;
		}
		#endregion
	}
}

