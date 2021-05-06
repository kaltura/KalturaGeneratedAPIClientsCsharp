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
	public class UrlTokenizerAkamaiRtsp : UrlTokenizer
	{
		#region Constants
		public const string HOST = "host";
		public const string CPCODE = "cpcode";
		#endregion

		#region Private Fields
		private string _Host = null;
		private int _Cpcode = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string Host
		{
			get { return _Host; }
			set 
			{ 
				_Host = value;
				OnPropertyChanged("Host");
			}
		}
		[JsonProperty]
		public int Cpcode
		{
			get { return _Cpcode; }
			set 
			{ 
				_Cpcode = value;
				OnPropertyChanged("Cpcode");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerAkamaiRtsp()
		{
		}

		public UrlTokenizerAkamaiRtsp(JToken node) : base(node)
		{
			if(node["host"] != null)
			{
				this._Host = node["host"].Value<string>();
			}
			if(node["cpcode"] != null)
			{
				this._Cpcode = ParseInt(node["cpcode"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlTokenizerAkamaiRtsp");
			kparams.AddIfNotNull("host", this._Host);
			kparams.AddIfNotNull("cpcode", this._Cpcode);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HOST:
					return "Host";
				case CPCODE:
					return "Cpcode";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

