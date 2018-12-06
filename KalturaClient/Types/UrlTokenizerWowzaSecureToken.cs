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
	public class UrlTokenizerWowzaSecureToken : UrlTokenizer
	{
		#region Constants
		public const string PARAM_PREFIX = "paramPrefix";
		public const string HASH_ALGORITHM = "hashAlgorithm";
		#endregion

		#region Private Fields
		private string _ParamPrefix = null;
		private string _HashAlgorithm = null;
		#endregion

		#region Properties
		public string ParamPrefix
		{
			get { return _ParamPrefix; }
			set 
			{ 
				_ParamPrefix = value;
				OnPropertyChanged("ParamPrefix");
			}
		}
		public string HashAlgorithm
		{
			get { return _HashAlgorithm; }
			set 
			{ 
				_HashAlgorithm = value;
				OnPropertyChanged("HashAlgorithm");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerWowzaSecureToken()
		{
		}

		public UrlTokenizerWowzaSecureToken(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "paramPrefix":
						this._ParamPrefix = propertyNode.InnerText;
						continue;
					case "hashAlgorithm":
						this._HashAlgorithm = propertyNode.InnerText;
						continue;
				}
			}
		}

		public UrlTokenizerWowzaSecureToken(IDictionary<string,object> data) : base(data)
		{
			    this._ParamPrefix = data.TryGetValueSafe<string>("paramPrefix");
			    this._HashAlgorithm = data.TryGetValueSafe<string>("hashAlgorithm");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlTokenizerWowzaSecureToken");
			kparams.AddIfNotNull("paramPrefix", this._ParamPrefix);
			kparams.AddIfNotNull("hashAlgorithm", this._HashAlgorithm);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARAM_PREFIX:
					return "ParamPrefix";
				case HASH_ALGORITHM:
					return "HashAlgorithm";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

