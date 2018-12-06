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
	public class Filter : ObjectBase
	{
		#region Constants
		public const string ORDER_BY = "orderBy";
		public const string ADVANCED_SEARCH = "advancedSearch";
		#endregion

		#region Private Fields
		private string _OrderBy = null;
		private SearchItem _AdvancedSearch;
		#endregion

		#region Properties
		public string OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		public SearchItem AdvancedSearch
		{
			get { return _AdvancedSearch; }
			set 
			{ 
				_AdvancedSearch = value;
				OnPropertyChanged("AdvancedSearch");
			}
		}
		#endregion

		#region CTor
		public Filter()
		{
		}

		public Filter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "orderBy":
						this._OrderBy = propertyNode.InnerText;
						continue;
					case "advancedSearch":
						this._AdvancedSearch = ObjectFactory.Create<SearchItem>(propertyNode);
						continue;
				}
			}
		}

		public Filter(IDictionary<string,object> data) : base(data)
		{
			    this._OrderBy = data.TryGetValueSafe<string>("orderBy");
			    this._AdvancedSearch = ObjectFactory.Create<SearchItem>(data.TryGetValueSafe<IDictionary<string,object>>("advancedSearch"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFilter");
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			kparams.AddIfNotNull("advancedSearch", this._AdvancedSearch);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ORDER_BY:
					return "OrderBy";
				case ADVANCED_SEARCH:
					return "AdvancedSearch";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

