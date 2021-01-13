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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class FileSyncFilter : FileSyncBaseFilter
	{
		#region Constants
		public const string CURRENT_DC = "currentDc";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private NullableBoolean _CurrentDc = (NullableBoolean)Int32.MinValue;
		private FileSyncOrderBy _OrderBy = null;
		#endregion

		#region Properties
		[JsonProperty]
		public NullableBoolean CurrentDc
		{
			get { return _CurrentDc; }
			set 
			{ 
				_CurrentDc = value;
				OnPropertyChanged("CurrentDc");
			}
		}
		[JsonProperty]
		public new FileSyncOrderBy OrderBy
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
		public FileSyncFilter()
		{
		}

		public FileSyncFilter(JToken node) : base(node)
		{
			if(node["currentDc"] != null)
			{
				this._CurrentDc = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["currentDc"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (FileSyncOrderBy)StringEnum.Parse(typeof(FileSyncOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFileSyncFilter");
			kparams.AddIfNotNull("currentDc", this._CurrentDc);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
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

