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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaGenericDistributionJobProviderData : KalturaDistributionJobProviderData
	{
		#region Private Fields
		private string _Xml = null;
		private string _ResultParseData = null;
		private KalturaGenericDistributionProviderParser _ResultParserType = (KalturaGenericDistributionProviderParser)Int32.MinValue;
		#endregion

		#region Properties
		public string Xml
		{
			get { return _Xml; }
			set 
			{ 
				_Xml = value;
				OnPropertyChanged("Xml");
			}
		}
		public string ResultParseData
		{
			get { return _ResultParseData; }
			set 
			{ 
				_ResultParseData = value;
				OnPropertyChanged("ResultParseData");
			}
		}
		public KalturaGenericDistributionProviderParser ResultParserType
		{
			get { return _ResultParserType; }
			set 
			{ 
				_ResultParserType = value;
				OnPropertyChanged("ResultParserType");
			}
		}
		#endregion

		#region CTor
		public KalturaGenericDistributionJobProviderData()
		{
		}

		public KalturaGenericDistributionJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "xml":
						this.Xml = txt;
						continue;
					case "resultParseData":
						this.ResultParseData = txt;
						continue;
					case "resultParserType":
						this.ResultParserType = (KalturaGenericDistributionProviderParser)ParseEnum(typeof(KalturaGenericDistributionProviderParser), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaGenericDistributionJobProviderData");
			kparams.AddStringIfNotNull("xml", this.Xml);
			kparams.AddStringIfNotNull("resultParseData", this.ResultParseData);
			kparams.AddEnumIfNotNull("resultParserType", this.ResultParserType);
			return kparams;
		}
		#endregion
	}
}

