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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class ESearchAggregationResponseItem : ObjectBase
	{
		#region Constants
		public const string NAME = "name";
		public const string FIELD_NAME = "fieldName";
		public const string BUCKETS = "buckets";
		#endregion

		#region Private Fields
		private string _Name = null;
		private string _FieldName = null;
		private IList<ESearchAggregationBucket> _Buckets;
		#endregion

		#region Properties
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		/// <summary>
		/// Use FieldNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FieldName
		{
			get { return _FieldName; }
			set 
			{ 
				_FieldName = value;
				OnPropertyChanged("FieldName");
			}
		}
		/// <summary>
		/// Use BucketsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ESearchAggregationBucket> Buckets
		{
			get { return _Buckets; }
			set 
			{ 
				_Buckets = value;
				OnPropertyChanged("Buckets");
			}
		}
		#endregion

		#region CTor
		public ESearchAggregationResponseItem()
		{
		}

		public ESearchAggregationResponseItem(JToken node) : base(node)
		{
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["fieldName"] != null)
			{
				this._FieldName = node["fieldName"].Value<string>();
			}
			if(node["buckets"] != null)
			{
				this._Buckets = new List<ESearchAggregationBucket>();
				foreach(var arrayNode in node["buckets"].Children())
				{
					this._Buckets.Add(ObjectFactory.Create<ESearchAggregationBucket>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchAggregationResponseItem");
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("fieldName", this._FieldName);
			kparams.AddIfNotNull("buckets", this._Buckets);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case NAME:
					return "Name";
				case FIELD_NAME:
					return "FieldName";
				case BUCKETS:
					return "Buckets";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

