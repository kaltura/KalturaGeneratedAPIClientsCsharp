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
	public class VelocixProvisionJobData : ProvisionJobData
	{
		#region Constants
		public const string PROVISIONING_PARAMS = "provisioningParams";
		public const string USER_NAME = "userName";
		public const string PASSWORD = "password";
		#endregion

		#region Private Fields
		private IList<KeyValue> _ProvisioningParams;
		private string _UserName = null;
		private string _Password = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ProvisioningParamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<KeyValue> ProvisioningParams
		{
			get { return _ProvisioningParams; }
			set 
			{ 
				_ProvisioningParams = value;
				OnPropertyChanged("ProvisioningParams");
			}
		}
		/// <summary>
		/// Use UserNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserName
		{
			get { return _UserName; }
			set 
			{ 
				_UserName = value;
				OnPropertyChanged("UserName");
			}
		}
		/// <summary>
		/// Use PasswordAsDouble property instead
		/// </summary>
		[JsonProperty]
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
		public VelocixProvisionJobData()
		{
		}

		public VelocixProvisionJobData(JToken node) : base(node)
		{
			if(node["provisioningParams"] != null)
			{
				this._ProvisioningParams = new List<KeyValue>();
				foreach(var arrayNode in node["provisioningParams"].Children())
				{
					this._ProvisioningParams.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["userName"] != null)
			{
				this._UserName = node["userName"].Value<string>();
			}
			if(node["password"] != null)
			{
				this._Password = node["password"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVelocixProvisionJobData");
			kparams.AddIfNotNull("provisioningParams", this._ProvisioningParams);
			kparams.AddIfNotNull("userName", this._UserName);
			kparams.AddIfNotNull("password", this._Password);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROVISIONING_PARAMS:
					return "ProvisioningParams";
				case USER_NAME:
					return "UserName";
				case PASSWORD:
					return "Password";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

