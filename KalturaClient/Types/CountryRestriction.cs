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
	public class CountryRestriction : BaseRestriction
	{
		#region Constants
		public const string COUNTRY_RESTRICTION_TYPE = "countryRestrictionType";
		public const string COUNTRY_LIST = "countryList";
		#endregion

		#region Private Fields
		private CountryRestrictionType _CountryRestrictionType = (CountryRestrictionType)Int32.MinValue;
		private string _CountryList = null;
		#endregion

		#region Properties
		public CountryRestrictionType CountryRestrictionType
		{
			get { return _CountryRestrictionType; }
			set 
			{ 
				_CountryRestrictionType = value;
				OnPropertyChanged("CountryRestrictionType");
			}
		}
		public string CountryList
		{
			get { return _CountryList; }
			set 
			{ 
				_CountryList = value;
				OnPropertyChanged("CountryList");
			}
		}
		#endregion

		#region CTor
		public CountryRestriction()
		{
		}

		public CountryRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "countryRestrictionType":
						this._CountryRestrictionType = (CountryRestrictionType)ParseEnum(typeof(CountryRestrictionType), propertyNode.InnerText);
						continue;
					case "countryList":
						this._CountryList = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaCountryRestriction");
			kparams.AddIfNotNull("countryRestrictionType", this._CountryRestrictionType);
			kparams.AddIfNotNull("countryList", this._CountryList);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case COUNTRY_RESTRICTION_TYPE:
					return "CountryRestrictionType";
				case COUNTRY_LIST:
					return "CountryList";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

