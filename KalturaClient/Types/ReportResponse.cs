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
	public class ReportResponse : ObjectBase
	{
		#region Constants
		public const string COLUMNS = "columns";
		public const string RESULTS = "results";
		#endregion

		#region Private Fields
		private string _Columns = null;
		private IList<String> _Results;
		#endregion

		#region Properties
		[JsonProperty]
		public string Columns
		{
			get { return _Columns; }
			set 
			{ 
				_Columns = value;
				OnPropertyChanged("Columns");
			}
		}
		[JsonProperty]
		public IList<String> Results
		{
			get { return _Results; }
			set 
			{ 
				_Results = value;
				OnPropertyChanged("Results");
			}
		}
		#endregion

		#region CTor
		public ReportResponse()
		{
		}

		public ReportResponse(JToken node) : base(node)
		{
			if(node["columns"] != null)
			{
				this._Columns = node["columns"].Value<string>();
			}
			if(node["results"] != null)
			{
				this._Results = new List<String>();
				foreach(var arrayNode in node["results"].Children())
				{
					this._Results.Add(ObjectFactory.Create<String>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReportResponse");
			kparams.AddIfNotNull("columns", this._Columns);
			kparams.AddIfNotNull("results", this._Results);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case COLUMNS:
					return "Columns";
				case RESULTS:
					return "Results";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

