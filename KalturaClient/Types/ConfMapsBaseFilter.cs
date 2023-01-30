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
	public class ConfMapsBaseFilter : RelatedFilter
	{
		#region Constants
		public const string NAME_EQUAL = "nameEqual";
		public const string RELATED_HOST_EQUAL = "relatedHostEqual";
		public const string VERSION_EQUAL = "versionEqual";
		#endregion

		#region Private Fields
		private string _NameEqual = null;
		private string _RelatedHostEqual = null;
		private int _VersionEqual = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use NameEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string NameEqual
		{
			get { return _NameEqual; }
			set 
			{ 
				_NameEqual = value;
				OnPropertyChanged("NameEqual");
			}
		}
		/// <summary>
		/// Use RelatedHostEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RelatedHostEqual
		{
			get { return _RelatedHostEqual; }
			set 
			{ 
				_RelatedHostEqual = value;
				OnPropertyChanged("RelatedHostEqual");
			}
		}
		/// <summary>
		/// Use VersionEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VersionEqual
		{
			get { return _VersionEqual; }
			set 
			{ 
				_VersionEqual = value;
				OnPropertyChanged("VersionEqual");
			}
		}
		#endregion

		#region CTor
		public ConfMapsBaseFilter()
		{
		}

		public ConfMapsBaseFilter(JToken node) : base(node)
		{
			if(node["nameEqual"] != null)
			{
				this._NameEqual = node["nameEqual"].Value<string>();
			}
			if(node["relatedHostEqual"] != null)
			{
				this._RelatedHostEqual = node["relatedHostEqual"].Value<string>();
			}
			if(node["versionEqual"] != null)
			{
				this._VersionEqual = ParseInt(node["versionEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConfMapsBaseFilter");
			kparams.AddIfNotNull("nameEqual", this._NameEqual);
			kparams.AddIfNotNull("relatedHostEqual", this._RelatedHostEqual);
			kparams.AddIfNotNull("versionEqual", this._VersionEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case NAME_EQUAL:
					return "NameEqual";
				case RELATED_HOST_EQUAL:
					return "RelatedHostEqual";
				case VERSION_EQUAL:
					return "VersionEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

