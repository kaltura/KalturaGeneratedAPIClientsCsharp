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
	public class PlayReadyPolicy : DrmPolicy
	{
		#region Constants
		public const string GRACE_PERIOD = "gracePeriod";
		public const string LICENSE_REMOVAL_POLICY = "licenseRemovalPolicy";
		public const string LICENSE_REMOVAL_DURATION = "licenseRemovalDuration";
		public const string MIN_SECURITY_LEVEL = "minSecurityLevel";
		public const string RIGHTS = "rights";
		#endregion

		#region Private Fields
		private int _GracePeriod = Int32.MinValue;
		private PlayReadyLicenseRemovalPolicy _LicenseRemovalPolicy = (PlayReadyLicenseRemovalPolicy)Int32.MinValue;
		private int _LicenseRemovalDuration = Int32.MinValue;
		private PlayReadyMinimumLicenseSecurityLevel _MinSecurityLevel = (PlayReadyMinimumLicenseSecurityLevel)Int32.MinValue;
		private IList<PlayReadyRight> _Rights;
		#endregion

		#region Properties
		/// <summary>
		/// Use GracePeriodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int GracePeriod
		{
			get { return _GracePeriod; }
			set 
			{ 
				_GracePeriod = value;
				OnPropertyChanged("GracePeriod");
			}
		}
		/// <summary>
		/// Use LicenseRemovalPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PlayReadyLicenseRemovalPolicy LicenseRemovalPolicy
		{
			get { return _LicenseRemovalPolicy; }
			set 
			{ 
				_LicenseRemovalPolicy = value;
				OnPropertyChanged("LicenseRemovalPolicy");
			}
		}
		/// <summary>
		/// Use LicenseRemovalDurationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LicenseRemovalDuration
		{
			get { return _LicenseRemovalDuration; }
			set 
			{ 
				_LicenseRemovalDuration = value;
				OnPropertyChanged("LicenseRemovalDuration");
			}
		}
		/// <summary>
		/// Use MinSecurityLevelAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PlayReadyMinimumLicenseSecurityLevel MinSecurityLevel
		{
			get { return _MinSecurityLevel; }
			set 
			{ 
				_MinSecurityLevel = value;
				OnPropertyChanged("MinSecurityLevel");
			}
		}
		/// <summary>
		/// Use RightsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<PlayReadyRight> Rights
		{
			get { return _Rights; }
			set 
			{ 
				_Rights = value;
				OnPropertyChanged("Rights");
			}
		}
		#endregion

		#region CTor
		public PlayReadyPolicy()
		{
		}

		public PlayReadyPolicy(JToken node) : base(node)
		{
			if(node["gracePeriod"] != null)
			{
				this._GracePeriod = ParseInt(node["gracePeriod"].Value<string>());
			}
			if(node["licenseRemovalPolicy"] != null)
			{
				this._LicenseRemovalPolicy = (PlayReadyLicenseRemovalPolicy)ParseEnum(typeof(PlayReadyLicenseRemovalPolicy), node["licenseRemovalPolicy"].Value<string>());
			}
			if(node["licenseRemovalDuration"] != null)
			{
				this._LicenseRemovalDuration = ParseInt(node["licenseRemovalDuration"].Value<string>());
			}
			if(node["minSecurityLevel"] != null)
			{
				this._MinSecurityLevel = (PlayReadyMinimumLicenseSecurityLevel)ParseEnum(typeof(PlayReadyMinimumLicenseSecurityLevel), node["minSecurityLevel"].Value<string>());
			}
			if(node["rights"] != null)
			{
				this._Rights = new List<PlayReadyRight>();
				foreach(var arrayNode in node["rights"].Children())
				{
					this._Rights.Add(ObjectFactory.Create<PlayReadyRight>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPlayReadyPolicy");
			kparams.AddIfNotNull("gracePeriod", this._GracePeriod);
			kparams.AddIfNotNull("licenseRemovalPolicy", this._LicenseRemovalPolicy);
			kparams.AddIfNotNull("licenseRemovalDuration", this._LicenseRemovalDuration);
			kparams.AddIfNotNull("minSecurityLevel", this._MinSecurityLevel);
			kparams.AddIfNotNull("rights", this._Rights);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case GRACE_PERIOD:
					return "GracePeriod";
				case LICENSE_REMOVAL_POLICY:
					return "LicenseRemovalPolicy";
				case LICENSE_REMOVAL_DURATION:
					return "LicenseRemovalDuration";
				case MIN_SECURITY_LEVEL:
					return "MinSecurityLevel";
				case RIGHTS:
					return "Rights";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

