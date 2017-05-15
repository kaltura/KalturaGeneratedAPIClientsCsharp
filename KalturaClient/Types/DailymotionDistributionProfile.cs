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
// Copyright (C) 2006-2017  Kaltura Inc.
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

namespace Kaltura.Types
{
	public class DailymotionDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string USER = "user";
		public const string PASSWORD = "password";
		public const string GEO_BLOCKING_MAPPING = "geoBlockingMapping";
		#endregion

		#region Private Fields
		private string _User = null;
		private string _Password = null;
		private DailymotionGeoBlockingMapping _GeoBlockingMapping = (DailymotionGeoBlockingMapping)Int32.MinValue;
		#endregion

		#region Properties
		public string User
		{
			get { return _User; }
			set 
			{ 
				_User = value;
				OnPropertyChanged("User");
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
		public DailymotionGeoBlockingMapping GeoBlockingMapping
		{
			get { return _GeoBlockingMapping; }
			set 
			{ 
				_GeoBlockingMapping = value;
				OnPropertyChanged("GeoBlockingMapping");
			}
		}
		#endregion

		#region CTor
		public DailymotionDistributionProfile()
		{
		}

		public DailymotionDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "user":
						this._User = propertyNode.InnerText;
						continue;
					case "password":
						this._Password = propertyNode.InnerText;
						continue;
					case "geoBlockingMapping":
						this._GeoBlockingMapping = (DailymotionGeoBlockingMapping)ParseEnum(typeof(DailymotionGeoBlockingMapping), propertyNode.InnerText);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDailymotionDistributionProfile");
			kparams.AddIfNotNull("user", this._User);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("geoBlockingMapping", this._GeoBlockingMapping);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER:
					return "User";
				case PASSWORD:
					return "Password";
				case GEO_BLOCKING_MAPPING:
					return "GeoBlockingMapping";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

