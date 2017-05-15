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
	public class BusinessProcessServerFilter : BusinessProcessServerBaseFilter
	{
		#region Constants
		public const string CURRENT_DC_OR_EXTERNAL = "currentDcOrExternal";
		public const string CURRENT_DC = "currentDc";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private NullableBoolean _CurrentDcOrExternal = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _CurrentDc = (NullableBoolean)Int32.MinValue;
		private BusinessProcessServerOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public NullableBoolean CurrentDcOrExternal
		{
			get { return _CurrentDcOrExternal; }
			set 
			{ 
				_CurrentDcOrExternal = value;
				OnPropertyChanged("CurrentDcOrExternal");
			}
		}
		public NullableBoolean CurrentDc
		{
			get { return _CurrentDc; }
			set 
			{ 
				_CurrentDc = value;
				OnPropertyChanged("CurrentDc");
			}
		}
		public new BusinessProcessServerOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public BusinessProcessServerFilter()
		{
		}

		public BusinessProcessServerFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "currentDcOrExternal":
						this._CurrentDcOrExternal = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "currentDc":
						this._CurrentDc = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "orderBy":
						this._OrderBy = (BusinessProcessServerOrderBy)StringEnum.Parse(typeof(BusinessProcessServerOrderBy), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaBusinessProcessServerFilter");
			kparams.AddIfNotNull("currentDcOrExternal", this._CurrentDcOrExternal);
			kparams.AddIfNotNull("currentDc", this._CurrentDc);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CURRENT_DC_OR_EXTERNAL:
					return "CurrentDcOrExternal";
				case CURRENT_DC:
					return "CurrentDc";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

