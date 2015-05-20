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
// Copyright (C) 2006-2015  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaBulkUploadCsvJobData : KalturaBulkUploadJobData
	{
		#region Private Fields
		private KalturaBulkUploadCsvVersion _CsvVersion = (KalturaBulkUploadCsvVersion)Int32.MinValue;
		private IList<KalturaString> _Columns;
		#endregion

		#region Properties
		public KalturaBulkUploadCsvVersion CsvVersion
		{
			get { return _CsvVersion; }
			set 
			{ 
				_CsvVersion = value;
				OnPropertyChanged("CsvVersion");
			}
		}
		public IList<KalturaString> Columns
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
		public KalturaBulkUploadCsvJobData()
		{
		}

		public KalturaBulkUploadCsvJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "csvVersion":
						this.CsvVersion = (KalturaBulkUploadCsvVersion)ParseEnum(typeof(KalturaBulkUploadCsvVersion), txt);
						continue;
					case "columns":
						this.Columns = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Columns.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBulkUploadCsvJobData");
			kparams.AddEnumIfNotNull("csvVersion", this.CsvVersion);
			if (this.Columns != null)
			{
				if (this.Columns.Count == 0)
				{
					kparams.Add("columns:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaString item in this.Columns)
					{
						kparams.Add("columns:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

