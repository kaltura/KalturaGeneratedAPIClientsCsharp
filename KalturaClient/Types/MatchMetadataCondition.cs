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
	public class MatchMetadataCondition : MatchCondition
	{
		#region Constants
		public const string XPATH = "xPath";
		public const string PROFILE_ID = "profileId";
		public const string PROFILE_SYSTEM_NAME = "profileSystemName";
		#endregion

		#region Private Fields
		private string _XPath = null;
		private int _ProfileId = Int32.MinValue;
		private string _ProfileSystemName = null;
		#endregion

		#region Properties
		public string XPath
		{
			get { return _XPath; }
			set 
			{ 
				_XPath = value;
				OnPropertyChanged("XPath");
			}
		}
		public int ProfileId
		{
			get { return _ProfileId; }
			set 
			{ 
				_ProfileId = value;
				OnPropertyChanged("ProfileId");
			}
		}
		public string ProfileSystemName
		{
			get { return _ProfileSystemName; }
			set 
			{ 
				_ProfileSystemName = value;
				OnPropertyChanged("ProfileSystemName");
			}
		}
		#endregion

		#region CTor
		public MatchMetadataCondition()
		{
		}

		public MatchMetadataCondition(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "xPath":
						this._XPath = propertyNode.InnerText;
						continue;
					case "profileId":
						this._ProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "profileSystemName":
						this._ProfileSystemName = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaMatchMetadataCondition");
			kparams.AddIfNotNull("xPath", this._XPath);
			kparams.AddIfNotNull("profileId", this._ProfileId);
			kparams.AddIfNotNull("profileSystemName", this._ProfileSystemName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case XPATH:
					return "XPath";
				case PROFILE_ID:
					return "ProfileId";
				case PROFILE_SYSTEM_NAME:
					return "ProfileSystemName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

