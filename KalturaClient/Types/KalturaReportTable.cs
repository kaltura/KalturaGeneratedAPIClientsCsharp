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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class KalturaReportTable : KalturaObjectBase
	{
		#region Private Fields
		private string _Header = null;
		private string _Data = null;
		private int _TotalCount = Int32.MinValue;
		#endregion

		#region Properties
		public string Header
		{
			get { return _Header; }
		}
		public string Data
		{
			get { return _Data; }
		}
		public int TotalCount
		{
			get { return _TotalCount; }
		}
		#endregion

		#region CTor
		public KalturaReportTable()
		{
		}

		public KalturaReportTable(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "header":
						this._Header = txt;
						continue;
					case "data":
						this._Data = txt;
						continue;
					case "totalCount":
						this._TotalCount = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaReportTable");
			kparams.AddIfNotNull("header", this._Header);
			kparams.AddIfNotNull("data", this._Data);
			kparams.AddIfNotNull("totalCount", this._TotalCount);
			return kparams;
		}
		#endregion
	}
}

