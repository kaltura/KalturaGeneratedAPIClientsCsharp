// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class AkamaiProvisionJobData : ProvisionJobData
	{
		#region Constants
		public const string WSDL_USERNAME = "wsdlUsername";
		public const string WSDL_PASSWORD = "wsdlPassword";
		public const string CPCODE = "cpcode";
		public const string EMAIL_ID = "emailId";
		public const string PRIMARY_CONTACT = "primaryContact";
		public const string SECONDARY_CONTACT = "secondaryContact";
		#endregion

		#region Private Fields
		private string _WsdlUsername = null;
		private string _WsdlPassword = null;
		private string _Cpcode = null;
		private string _EmailId = null;
		private string _PrimaryContact = null;
		private string _SecondaryContact = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use WsdlUsernameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string WsdlUsername
		{
			get { return _WsdlUsername; }
			set 
			{ 
				_WsdlUsername = value;
				OnPropertyChanged("WsdlUsername");
			}
		}
		/// <summary>
		/// Use WsdlPasswordAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string WsdlPassword
		{
			get { return _WsdlPassword; }
			set 
			{ 
				_WsdlPassword = value;
				OnPropertyChanged("WsdlPassword");
			}
		}
		/// <summary>
		/// Use CpcodeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Cpcode
		{
			get { return _Cpcode; }
			set 
			{ 
				_Cpcode = value;
				OnPropertyChanged("Cpcode");
			}
		}
		/// <summary>
		/// Use EmailIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EmailId
		{
			get { return _EmailId; }
			set 
			{ 
				_EmailId = value;
				OnPropertyChanged("EmailId");
			}
		}
		/// <summary>
		/// Use PrimaryContactAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PrimaryContact
		{
			get { return _PrimaryContact; }
			set 
			{ 
				_PrimaryContact = value;
				OnPropertyChanged("PrimaryContact");
			}
		}
		/// <summary>
		/// Use SecondaryContactAsDouble property instead
		/// </summary>
		[JsonProperty]
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
		public AkamaiProvisionJobData()
		{
		}

		public AkamaiProvisionJobData(JToken node) : base(node)
		{
			if(node["wsdlUsername"] != null)
			{
				this._WsdlUsername = node["wsdlUsername"].Value<string>();
			}
			if(node["wsdlPassword"] != null)
			{
				this._WsdlPassword = node["wsdlPassword"].Value<string>();
			}
			if(node["cpcode"] != null)
			{
				this._Cpcode = node["cpcode"].Value<string>();
			}
			if(node["emailId"] != null)
			{
				this._EmailId = node["emailId"].Value<string>();
			}
			if(node["primaryContact"] != null)
			{
				this._PrimaryContact = node["primaryContact"].Value<string>();
			}
			if(node["secondaryContact"] != null)
			{
				this._SecondaryContact = node["secondaryContact"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAkamaiProvisionJobData");
			kparams.AddIfNotNull("wsdlUsername", this._WsdlUsername);
			kparams.AddIfNotNull("wsdlPassword", this._WsdlPassword);
			kparams.AddIfNotNull("cpcode", this._Cpcode);
			kparams.AddIfNotNull("emailId", this._EmailId);
			kparams.AddIfNotNull("primaryContact", this._PrimaryContact);
			kparams.AddIfNotNull("secondaryContact", this._SecondaryContact);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case WSDL_USERNAME:
					return "WsdlUsername";
				case WSDL_PASSWORD:
					return "WsdlPassword";
				case CPCODE:
					return "Cpcode";
				case EMAIL_ID:
					return "EmailId";
				case PRIMARY_CONTACT:
					return "PrimaryContact";
				case SECONDARY_CONTACT:
					return "SecondaryContact";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

