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
	public class CategoryUserAdvancedFilter : SearchItem
	{
		#region Constants
		public const string MEMBER_ID_EQ = "memberIdEq";
		public const string MEMBER_ID_IN = "memberIdIn";
		public const string MEMBER_PERMISSIONS_MATCH_OR = "memberPermissionsMatchOr";
		public const string MEMBER_PERMISSIONS_MATCH_AND = "memberPermissionsMatchAnd";
		#endregion

		#region Private Fields
		private string _MemberIdEq = null;
		private string _MemberIdIn = null;
		private string _MemberPermissionsMatchOr = null;
		private string _MemberPermissionsMatchAnd = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use MemberIdEqAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MemberIdEq
		{
			get { return _MemberIdEq; }
			set 
			{ 
				_MemberIdEq = value;
				OnPropertyChanged("MemberIdEq");
			}
		}
		/// <summary>
		/// Use MemberIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MemberIdIn
		{
			get { return _MemberIdIn; }
			set 
			{ 
				_MemberIdIn = value;
				OnPropertyChanged("MemberIdIn");
			}
		}
		/// <summary>
		/// Use MemberPermissionsMatchOrAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MemberPermissionsMatchOr
		{
			get { return _MemberPermissionsMatchOr; }
			set 
			{ 
				_MemberPermissionsMatchOr = value;
				OnPropertyChanged("MemberPermissionsMatchOr");
			}
		}
		/// <summary>
		/// Use MemberPermissionsMatchAndAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MemberPermissionsMatchAnd
		{
			get { return _MemberPermissionsMatchAnd; }
			set 
			{ 
				_MemberPermissionsMatchAnd = value;
				OnPropertyChanged("MemberPermissionsMatchAnd");
			}
		}
		#endregion

		#region CTor
		public CategoryUserAdvancedFilter()
		{
		}

		public CategoryUserAdvancedFilter(JToken node) : base(node)
		{
			if(node["memberIdEq"] != null)
			{
				this._MemberIdEq = node["memberIdEq"].Value<string>();
			}
			if(node["memberIdIn"] != null)
			{
				this._MemberIdIn = node["memberIdIn"].Value<string>();
			}
			if(node["memberPermissionsMatchOr"] != null)
			{
				this._MemberPermissionsMatchOr = node["memberPermissionsMatchOr"].Value<string>();
			}
			if(node["memberPermissionsMatchAnd"] != null)
			{
				this._MemberPermissionsMatchAnd = node["memberPermissionsMatchAnd"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCategoryUserAdvancedFilter");
			kparams.AddIfNotNull("memberIdEq", this._MemberIdEq);
			kparams.AddIfNotNull("memberIdIn", this._MemberIdIn);
			kparams.AddIfNotNull("memberPermissionsMatchOr", this._MemberPermissionsMatchOr);
			kparams.AddIfNotNull("memberPermissionsMatchAnd", this._MemberPermissionsMatchAnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MEMBER_ID_EQ:
					return "MemberIdEq";
				case MEMBER_ID_IN:
					return "MemberIdIn";
				case MEMBER_PERMISSIONS_MATCH_OR:
					return "MemberPermissionsMatchOr";
				case MEMBER_PERMISSIONS_MATCH_AND:
					return "MemberPermissionsMatchAnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

