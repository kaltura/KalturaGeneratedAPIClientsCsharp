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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class ResponseProfileCacheRecalculateResults : ObjectBase
	{
		#region Constants
		public const string LAST_OBJECT_KEY = "lastObjectKey";
		public const string RECALCULATED = "recalculated";
		#endregion

		#region Private Fields
		private string _LastObjectKey = null;
		private int _Recalculated = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string LastObjectKey
		{
			get { return _LastObjectKey; }
			set 
			{ 
				_LastObjectKey = value;
				OnPropertyChanged("LastObjectKey");
			}
		}
		[JsonProperty]
		public int Recalculated
		{
			get { return _Recalculated; }
			set 
			{ 
				_Recalculated = value;
				OnPropertyChanged("Recalculated");
			}
		}
		#endregion

		#region CTor
		public ResponseProfileCacheRecalculateResults()
		{
		}

		public ResponseProfileCacheRecalculateResults(JToken node) : base(node)
		{
			if(node["lastObjectKey"] != null)
			{
				this._LastObjectKey = node["lastObjectKey"].Value<string>();
			}
			if(node["recalculated"] != null)
			{
				this._Recalculated = ParseInt(node["recalculated"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaResponseProfileCacheRecalculateResults");
			kparams.AddIfNotNull("lastObjectKey", this._LastObjectKey);
			kparams.AddIfNotNull("recalculated", this._Recalculated);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LAST_OBJECT_KEY:
					return "LastObjectKey";
				case RECALCULATED:
					return "Recalculated";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

