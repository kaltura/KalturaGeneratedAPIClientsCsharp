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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class UrlTokenizerVnpt : UrlTokenizer
	{
		#region Constants
		public const string TOKENIZATION_FORMAT = "tokenizationFormat";
		public const string SHOULD_INCLUDE_CLIENT_IP = "shouldIncludeClientIp";
		#endregion

		#region Private Fields
		private int _TokenizationFormat = Int32.MinValue;
		private bool? _ShouldIncludeClientIp = null;
		#endregion

		#region Properties
		public int TokenizationFormat
		{
			get { return _TokenizationFormat; }
			set 
			{ 
				_TokenizationFormat = value;
				OnPropertyChanged("TokenizationFormat");
			}
		}
		public bool? ShouldIncludeClientIp
		{
			get { return _ShouldIncludeClientIp; }
			set 
			{ 
				_ShouldIncludeClientIp = value;
				OnPropertyChanged("ShouldIncludeClientIp");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerVnpt()
		{
		}

		public UrlTokenizerVnpt(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "tokenizationFormat":
						this._TokenizationFormat = ParseInt(propertyNode.InnerText);
						continue;
					case "shouldIncludeClientIp":
						this._ShouldIncludeClientIp = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaUrlTokenizerVnpt");
			kparams.AddIfNotNull("tokenizationFormat", this._TokenizationFormat);
			kparams.AddIfNotNull("shouldIncludeClientIp", this._ShouldIncludeClientIp);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TOKENIZATION_FORMAT:
					return "TokenizationFormat";
				case SHOULD_INCLUDE_CLIENT_IP:
					return "ShouldIncludeClientIp";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

