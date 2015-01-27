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
	public class KalturaAkamaiProvisionJobData : KalturaProvisionJobData
	{
		#region Private Fields
		private string _WsdlUsername = null;
		private string _WsdlPassword = null;
		private string _Cpcode = null;
		private string _EmailId = null;
		private string _PrimaryContact = null;
		private string _SecondaryContact = null;
		#endregion

		#region Properties
		public string WsdlUsername
		{
			get { return _WsdlUsername; }
			set 
			{ 
				_WsdlUsername = value;
				OnPropertyChanged("WsdlUsername");
			}
		}
		public string WsdlPassword
		{
			get { return _WsdlPassword; }
			set 
			{ 
				_WsdlPassword = value;
				OnPropertyChanged("WsdlPassword");
			}
		}
		public string Cpcode
		{
			get { return _Cpcode; }
			set 
			{ 
				_Cpcode = value;
				OnPropertyChanged("Cpcode");
			}
		}
		public string EmailId
		{
			get { return _EmailId; }
			set 
			{ 
				_EmailId = value;
				OnPropertyChanged("EmailId");
			}
		}
		public string PrimaryContact
		{
			get { return _PrimaryContact; }
			set 
			{ 
				_PrimaryContact = value;
				OnPropertyChanged("PrimaryContact");
			}
		}
		public string SecondaryContact
		{
			get { return _SecondaryContact; }
			set 
			{ 
				_SecondaryContact = value;
				OnPropertyChanged("SecondaryContact");
			}
		}
		#endregion

		#region CTor
		public KalturaAkamaiProvisionJobData()
		{
		}

		public KalturaAkamaiProvisionJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "wsdlUsername":
						this.WsdlUsername = txt;
						continue;
					case "wsdlPassword":
						this.WsdlPassword = txt;
						continue;
					case "cpcode":
						this.Cpcode = txt;
						continue;
					case "emailId":
						this.EmailId = txt;
						continue;
					case "primaryContact":
						this.PrimaryContact = txt;
						continue;
					case "secondaryContact":
						this.SecondaryContact = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAkamaiProvisionJobData");
			kparams.AddStringIfNotNull("wsdlUsername", this.WsdlUsername);
			kparams.AddStringIfNotNull("wsdlPassword", this.WsdlPassword);
			kparams.AddStringIfNotNull("cpcode", this.Cpcode);
			kparams.AddStringIfNotNull("emailId", this.EmailId);
			kparams.AddStringIfNotNull("primaryContact", this.PrimaryContact);
			kparams.AddStringIfNotNull("secondaryContact", this.SecondaryContact);
			return kparams;
		}
		#endregion
	}
}

