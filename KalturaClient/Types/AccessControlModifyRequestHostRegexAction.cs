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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class AccessControlModifyRequestHostRegexAction : RuleAction
	{
		#region Constants
		public const string PATTERN = "pattern";
		public const string REPLACEMENT = "replacement";
		public const string REPLACMEN_SERVER_NODE_ID = "replacmenServerNodeId";
		#endregion

		#region Private Fields
		private string _Pattern = null;
		private string _Replacement = null;
		private int _ReplacmenServerNodeId = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string Pattern
		{
			get { return _Pattern; }
			set 
			{ 
				_Pattern = value;
				OnPropertyChanged("Pattern");
			}
		}
		[JsonProperty]
		public string Replacement
		{
			get { return _Replacement; }
			set 
			{ 
				_Replacement = value;
				OnPropertyChanged("Replacement");
			}
		}
		[JsonProperty]
		public int ReplacmenServerNodeId
		{
			get { return _ReplacmenServerNodeId; }
			set 
			{ 
				_ReplacmenServerNodeId = value;
				OnPropertyChanged("ReplacmenServerNodeId");
			}
		}
		#endregion

		#region CTor
		public AccessControlModifyRequestHostRegexAction()
		{
		}

		public AccessControlModifyRequestHostRegexAction(JToken node) : base(node)
		{
			if(node["pattern"] != null)
			{
				this._Pattern = node["pattern"].Value<string>();
			}
			if(node["replacement"] != null)
			{
				this._Replacement = node["replacement"].Value<string>();
			}
			if(node["replacmenServerNodeId"] != null)
			{
				this._ReplacmenServerNodeId = ParseInt(node["replacmenServerNodeId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAccessControlModifyRequestHostRegexAction");
			kparams.AddIfNotNull("pattern", this._Pattern);
			kparams.AddIfNotNull("replacement", this._Replacement);
			kparams.AddIfNotNull("replacmenServerNodeId", this._ReplacmenServerNodeId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PATTERN:
					return "Pattern";
				case REPLACEMENT:
					return "Replacement";
				case REPLACMEN_SERVER_NODE_ID:
					return "ReplacmenServerNodeId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

