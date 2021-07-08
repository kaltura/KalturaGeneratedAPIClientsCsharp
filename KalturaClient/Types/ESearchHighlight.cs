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
	public class ESearchHighlight : ObjectBase
	{
		#region Constants
		public const string FIELD_NAME = "fieldName";
		public const string HITS = "hits";
		#endregion

		#region Private Fields
		private string _FieldName = null;
		private IList<String> _Hits;
		#endregion

		#region Properties
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
		/// Use HitsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<String> Hits
		{
			get { return _Hits; }
			set 
			{ 
				_Hits = value;
				OnPropertyChanged("Hits");
			}
		}
		#endregion

		#region CTor
		public ESearchHighlight()
		{
		}

		public ESearchHighlight(JToken node) : base(node)
		{
			if(node["fieldName"] != null)
			{
				this._FieldName = node["fieldName"].Value<string>();
			}
			if(node["hits"] != null)
			{
				this._Hits = new List<String>();
				foreach(var arrayNode in node["hits"].Children())
				{
					this._Hits.Add(ObjectFactory.Create<String>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchHighlight");
			kparams.AddIfNotNull("fieldName", this._FieldName);
			kparams.AddIfNotNull("hits", this._Hits);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FIELD_NAME:
					return "FieldName";
				case HITS:
					return "Hits";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

