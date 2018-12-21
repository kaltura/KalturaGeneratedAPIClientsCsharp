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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class DrmLicenseAccessDetails : ObjectBase
	{
		#region Constants
		public const string POLICY = "policy";
		public const string DURATION = "duration";
		public const string ABSOLUTE_DURATION = "absolute_duration";
		public const string LICENSE_PARAMS = "licenseParams";
		#endregion

		#region Private Fields
		private string _Policy = null;
		private int _Duration = Int32.MinValue;
		private int _Absolute_duration = Int32.MinValue;
		private IList<KeyValue> _LicenseParams;
		#endregion

		#region Properties
		[JsonProperty]
		public string Policy
		{
			get { return _Policy; }
			set 
			{ 
				_Policy = value;
				OnPropertyChanged("Policy");
			}
		}
		[JsonProperty]
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		[JsonProperty]
		public int Absolute_duration
		{
			get { return _Absolute_duration; }
			set 
			{ 
				_Absolute_duration = value;
				OnPropertyChanged("Absolute_duration");
			}
		}
		[JsonProperty]
		public IList<KeyValue> LicenseParams
		{
			get { return _LicenseParams; }
			set 
			{ 
				_LicenseParams = value;
				OnPropertyChanged("LicenseParams");
			}
		}
		#endregion

		#region CTor
		public DrmLicenseAccessDetails()
		{
		}

		public DrmLicenseAccessDetails(JToken node) : base(node)
		{
			if(node["policy"] != null)
			{
				this._Policy = node["policy"].Value<string>();
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseInt(node["duration"].Value<string>());
			}
			if(node["absolute_duration"] != null)
			{
				this._Absolute_duration = ParseInt(node["absolute_duration"].Value<string>());
			}
			if(node["licenseParams"] != null)
			{
				this._LicenseParams = new List<KeyValue>();
				foreach(var arrayNode in node["licenseParams"].Children())
				{
					this._LicenseParams.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDrmLicenseAccessDetails");
			kparams.AddIfNotNull("policy", this._Policy);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("absolute_duration", this._Absolute_duration);
			kparams.AddIfNotNull("licenseParams", this._LicenseParams);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case POLICY:
					return "Policy";
				case DURATION:
					return "Duration";
				case ABSOLUTE_DURATION:
					return "Absolute_duration";
				case LICENSE_PARAMS:
					return "LicenseParams";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

