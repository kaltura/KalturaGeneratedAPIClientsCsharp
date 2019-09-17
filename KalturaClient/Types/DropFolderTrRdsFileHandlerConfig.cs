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
	public class DropFolderTrRdsFileHandlerConfig : DropFolderFileHandlerConfig
	{
		#region Constants
		public const string LEAD_PATTERN = "leadPattern";
		public const string ADDITIONAL_PATTERNS = "additionalPatterns";
		#endregion

		#region Private Fields
		private string _LeadPattern = null;
		private string _AdditionalPatterns = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string LeadPattern
		{
			get { return _LeadPattern; }
			set 
			{ 
				_LeadPattern = value;
				OnPropertyChanged("LeadPattern");
			}
		}
		[JsonProperty]
		public string AdditionalPatterns
		{
			get { return _AdditionalPatterns; }
			set 
			{ 
				_AdditionalPatterns = value;
				OnPropertyChanged("AdditionalPatterns");
			}
		}
		#endregion

		#region CTor
		public DropFolderTrRdsFileHandlerConfig()
		{
		}

		public DropFolderTrRdsFileHandlerConfig(JToken node) : base(node)
		{
			if(node["leadPattern"] != null)
			{
				this._LeadPattern = node["leadPattern"].Value<string>();
			}
			if(node["additionalPatterns"] != null)
			{
				this._AdditionalPatterns = node["additionalPatterns"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDropFolderTrRdsFileHandlerConfig");
			kparams.AddIfNotNull("leadPattern", this._LeadPattern);
			kparams.AddIfNotNull("additionalPatterns", this._AdditionalPatterns);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LEAD_PATTERN:
					return "LeadPattern";
				case ADDITIONAL_PATTERNS:
					return "AdditionalPatterns";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

