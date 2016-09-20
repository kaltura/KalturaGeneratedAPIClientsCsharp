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
	public class KalturaReportResponse : KalturaObjectBase
	{
		#region Private Fields
		private string _Columns = null;
		private IList<KalturaString> _Results;
		#endregion

		#region Properties
		public string Columns
		{
			get { return _Columns; }
			set 
			{ 
				_Columns = value;
				OnPropertyChanged("Columns");
			}
		}
		public new IList<KalturaString> Results
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
		public KalturaReportResponse()
		{
		}

		public KalturaReportResponse(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "columns":
						this._Columns = txt;
						continue;
					case "results":
						this._Results = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Results.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
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
			kparams.AddReplace("objectType", "KalturaReportResponse");
			kparams.AddIfNotNull("columns", this.Columns);
			kparams.AddIfNotNull("results", this.Results);
			return kparams;
		}
		#endregion
	}
}

