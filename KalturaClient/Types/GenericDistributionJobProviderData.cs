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
	public class GenericDistributionJobProviderData : DistributionJobProviderData
	{
		#region Constants
		public const string XML = "xml";
		public const string RESULT_PARSE_DATA = "resultParseData";
		public const string RESULT_PARSER_TYPE = "resultParserType";
		#endregion

		#region Private Fields
		private string _Xml = null;
		private string _ResultParseData = null;
		private GenericDistributionProviderParser _ResultParserType = (GenericDistributionProviderParser)Int32.MinValue;
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
		public GenericDistributionProviderParser ResultParserType
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
		public GenericDistributionJobProviderData()
		{
		}

		public GenericDistributionJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "xml":
						this._Xml = propertyNode.InnerText;
						continue;
					case "resultParseData":
						this._ResultParseData = propertyNode.InnerText;
						continue;
					case "resultParserType":
						this._ResultParserType = (GenericDistributionProviderParser)ParseEnum(typeof(GenericDistributionProviderParser), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaGenericDistributionJobProviderData");
			kparams.AddIfNotNull("xml", this._Xml);
			kparams.AddIfNotNull("resultParseData", this._ResultParseData);
			kparams.AddIfNotNull("resultParserType", this._ResultParserType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case XML:
					return "Xml";
				case RESULT_PARSE_DATA:
					return "ResultParseData";
				case RESULT_PARSER_TYPE:
					return "ResultParserType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

