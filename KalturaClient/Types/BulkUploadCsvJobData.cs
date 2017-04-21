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
// Copyright (C) 2006-2017  Kaltura Inc.
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

namespace Kaltura.Types
{
	public class BulkUploadCsvJobData : BulkUploadJobData
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
		public BulkUploadCsvVersion CsvVersion
		{
			get { return _CsvVersion; }
		}
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
		public BulkUploadCsvJobData()
		{
		}

		public BulkUploadCsvJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "csvVersion":
						this._CsvVersion = (BulkUploadCsvVersion)ParseEnum(typeof(BulkUploadCsvVersion), propertyNode.InnerText);
						continue;
					case "columns":
						this._Columns = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Columns.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadCsvJobData");
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

