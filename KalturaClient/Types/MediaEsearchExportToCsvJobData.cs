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
	public class MediaEsearchExportToCsvJobData : ExportCsvJobData
	{
		#region Constants
		public const string SEARCH_PARAMS = "searchParams";
		#endregion

		#region Private Fields
		private ESearchEntryParams _SearchParams;
		#endregion

		#region Properties
		[JsonProperty]
		public ESearchEntryParams SearchParams
		{
			get { return _SearchParams; }
			set 
			{ 
				_SearchParams = value;
				OnPropertyChanged("SearchParams");
			}
		}
		#endregion

		#region CTor
		public MediaEsearchExportToCsvJobData()
		{
		}

		public MediaEsearchExportToCsvJobData(JToken node) : base(node)
		{
			if(node["searchParams"] != null)
			{
				this._SearchParams = ObjectFactory.Create<ESearchEntryParams>(node["searchParams"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMediaEsearchExportToCsvJobData");
			kparams.AddIfNotNull("searchParams", this._SearchParams);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SEARCH_PARAMS:
					return "SearchParams";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

