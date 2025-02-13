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
	public class EntryCaptionAdvancedFilter : SearchItem
	{
		#region Constants
		public const string HAS_CAPTION = "hasCaption";
		#endregion

		#region Private Fields
		private NullableBoolean _HasCaption = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public NullableBoolean HasCaption
		{
			get { return _HasCaption; }
			set 
			{ 
				_HasCaption = value;
				OnPropertyChanged("HasCaption");
			}
		}
		#endregion

		#region CTor
		public EntryCaptionAdvancedFilter()
		{
		}

		public EntryCaptionAdvancedFilter(JToken node) : base(node)
		{
			if(node["hasCaption"] != null)
			{
				this._HasCaption = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["hasCaption"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryCaptionAdvancedFilter");
			kparams.AddIfNotNull("hasCaption", this._HasCaption);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HAS_CAPTION:
					return "HasCaption";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

