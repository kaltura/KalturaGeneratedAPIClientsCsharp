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
	public class ConfigurableDistributionJobProviderData : DistributionJobProviderData
	{
		#region Constants
		public const string FIELD_VALUES = "fieldValues";
		#endregion

		#region Private Fields
		private string _FieldValues = null;
		#endregion

		#region Properties
		public string FieldValues
		{
			get { return _FieldValues; }
			set 
			{ 
				_FieldValues = value;
				OnPropertyChanged("FieldValues");
			}
		}
		#endregion

		#region CTor
		public ConfigurableDistributionJobProviderData()
		{
		}

		public ConfigurableDistributionJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "fieldValues":
						this._FieldValues = propertyNode.InnerText;
						continue;
				}
			}
		}

		public ConfigurableDistributionJobProviderData(IDictionary<string,object> data) : base(data)
		{
			    this._FieldValues = data.TryGetValueSafe<string>("fieldValues");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConfigurableDistributionJobProviderData");
			kparams.AddIfNotNull("fieldValues", this._FieldValues);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FIELD_VALUES:
					return "FieldValues";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

