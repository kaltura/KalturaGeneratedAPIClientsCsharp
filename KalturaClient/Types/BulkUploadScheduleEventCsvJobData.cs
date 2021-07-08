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
	public class BulkUploadScheduleEventCsvJobData : BulkUploadScheduleEventJobData
	{
		#region Constants
		public const string CSV_VERSION = "csvVersion";
		public const string COLUMNS = "columns";
		#endregion

		#region Private Fields
		private BulkUploadCsvVersion _CsvVersion = (BulkUploadCsvVersion)Int32.MinValue;
		private IList<String> _Columns;
		#endregion

		#region Properties
		/// <summary>
		/// Use CsvVersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BulkUploadCsvVersion CsvVersion
		{
			get { return _CsvVersion; }
			private set 
			{ 
				_CsvVersion = value;
				OnPropertyChanged("CsvVersion");
			}
		}
		/// <summary>
		/// Use ColumnsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<String> Columns
		{
			get { return _Columns; }
			set 
			{ 
				_Columns = value;
				OnPropertyChanged("Columns");
			}
		}
		#endregion

		#region CTor
		public BulkUploadScheduleEventCsvJobData()
		{
		}

		public BulkUploadScheduleEventCsvJobData(JToken node) : base(node)
		{
			if(node["csvVersion"] != null)
			{
				this._CsvVersion = (BulkUploadCsvVersion)ParseEnum(typeof(BulkUploadCsvVersion), node["csvVersion"].Value<string>());
			}
			if(node["columns"] != null)
			{
				this._Columns = new List<String>();
				foreach(var arrayNode in node["columns"].Children())
				{
					this._Columns.Add(ObjectFactory.Create<String>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadScheduleEventCsvJobData");
			kparams.AddIfNotNull("csvVersion", this._CsvVersion);
			kparams.AddIfNotNull("columns", this._Columns);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CSV_VERSION:
					return "CsvVersion";
				case COLUMNS:
					return "Columns";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

