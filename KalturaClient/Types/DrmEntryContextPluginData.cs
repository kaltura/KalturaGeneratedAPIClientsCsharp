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

namespace Kaltura.Types
{
	public class DrmEntryContextPluginData : PluginData
	{
		#region Constants
		public const string FLAVOR_DATA = "flavorData";
		#endregion

		#region Private Fields
		private string _FlavorData = null;
		#endregion

		#region Properties
		public string FlavorData
		{
			get { return _FlavorData; }
			set 
			{ 
				_FlavorData = value;
				OnPropertyChanged("FlavorData");
			}
		}
		#endregion

		#region CTor
		public DrmEntryContextPluginData()
		{
		}

		public DrmEntryContextPluginData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "flavorData":
						this._FlavorData = propertyNode.InnerText;
						continue;
				}
			}
		}

		public DrmEntryContextPluginData(IDictionary<string,object> data) : base(data)
		{
			    this._FlavorData = data.TryGetValueSafe<string>("flavorData");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDrmEntryContextPluginData");
			kparams.AddIfNotNull("flavorData", this._FlavorData);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLAVOR_DATA:
					return "FlavorData";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

