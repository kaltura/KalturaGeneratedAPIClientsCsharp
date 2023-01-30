// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class ESearchParams : ObjectBase
	{
		#region Constants
		public const string OBJECT_STATUSES = "objectStatuses";
		public const string OBJECT_ID = "objectId";
		public const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _ObjectStatuses = null;
		private string _ObjectId = null;
		private ESearchOrderBy _OrderBy;
		#endregion

		#region Properties
		/// <summary>
		/// Use ObjectStatusesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectStatuses
		{
			get { return _ObjectStatuses; }
			set 
			{ 
				_ObjectStatuses = value;
				OnPropertyChanged("ObjectStatuses");
			}
		}
		/// <summary>
		/// Use ObjectIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ESearchOrderBy OrderBy
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
		public ESearchParams()
		{
		}

		public ESearchParams(JToken node) : base(node)
		{
			if(node["objectStatuses"] != null)
			{
				this._ObjectStatuses = node["objectStatuses"].Value<string>();
			}
			if(node["objectId"] != null)
			{
				this._ObjectId = node["objectId"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = ObjectFactory.Create<ESearchOrderBy>(node["orderBy"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchParams");
			kparams.AddIfNotNull("objectStatuses", this._ObjectStatuses);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OBJECT_STATUSES:
					return "ObjectStatuses";
				case OBJECT_ID:
					return "ObjectId";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

