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

namespace Kaltura
{
	public class KalturaCompareMetadataCondition : KalturaCompareCondition
	{
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
		public KalturaCompareMetadataCondition()
		{
		}

		public KalturaCompareMetadataCondition(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "xPath":
						this._XPath = txt;
						continue;
					case "profileId":
						this._ProfileId = ParseInt(txt);
						continue;
					case "profileSystemName":
						this._ProfileSystemName = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCompareMetadataCondition");
			kparams.AddIfNotNull("xPath", this._XPath);
			kparams.AddIfNotNull("profileId", this._ProfileId);
			kparams.AddIfNotNull("profileSystemName", this._ProfileSystemName);
			return kparams;
		}
		#endregion
	}
}

