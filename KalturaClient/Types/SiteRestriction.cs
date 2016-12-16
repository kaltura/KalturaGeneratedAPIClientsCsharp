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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class SiteRestriction : BaseRestriction
	{
		#region Constants
		public const string SITE_RESTRICTION_TYPE = "siteRestrictionType";
		public const string SITE_LIST = "siteList";
		#endregion

		#region Private Fields
		private SiteRestrictionType _SiteRestrictionType = (SiteRestrictionType)Int32.MinValue;
		private string _SiteList = null;
		#endregion

		#region Properties
		public SiteRestrictionType SiteRestrictionType
		{
			get { return _SiteRestrictionType; }
			set 
			{ 
				_SiteRestrictionType = value;
				OnPropertyChanged("SiteRestrictionType");
			}
		}
		public string SiteList
		{
			get { return _SiteList; }
			set 
			{ 
				_SiteList = value;
				OnPropertyChanged("SiteList");
			}
		}
		#endregion

		#region CTor
		public SiteRestriction()
		{
		}

		public SiteRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "siteRestrictionType":
						this._SiteRestrictionType = (SiteRestrictionType)ParseEnum(typeof(SiteRestrictionType), txt);
						continue;
					case "siteList":
						this._SiteList = txt;
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
				kparams.AddReplace("objectType", "KalturaSiteRestriction");
			kparams.AddIfNotNull("siteRestrictionType", this._SiteRestrictionType);
			kparams.AddIfNotNull("siteList", this._SiteList);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SITE_RESTRICTION_TYPE:
					return "SiteRestrictionType";
				case SITE_LIST:
					return "SiteList";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

