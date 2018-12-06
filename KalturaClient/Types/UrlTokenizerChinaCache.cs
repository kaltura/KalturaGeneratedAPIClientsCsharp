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
	public class UrlTokenizerChinaCache : UrlTokenizer
	{
		#region Constants
		public const string ALGORITHM_ID = "algorithmId";
		public const string KEY_ID = "keyId";
		#endregion

		#region Private Fields
		private ChinaCacheAlgorithmType _AlgorithmId = (ChinaCacheAlgorithmType)Int32.MinValue;
		private int _KeyId = Int32.MinValue;
		#endregion

		#region Properties
		public ChinaCacheAlgorithmType AlgorithmId
		{
			get { return _AlgorithmId; }
			set 
			{ 
				_AlgorithmId = value;
				OnPropertyChanged("AlgorithmId");
			}
		}
		public int KeyId
		{
			get { return _KeyId; }
			set 
			{ 
				_KeyId = value;
				OnPropertyChanged("KeyId");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerChinaCache()
		{
		}

		public UrlTokenizerChinaCache(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "algorithmId":
						this._AlgorithmId = (ChinaCacheAlgorithmType)ParseEnum(typeof(ChinaCacheAlgorithmType), propertyNode.InnerText);
						continue;
					case "keyId":
						this._KeyId = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public UrlTokenizerChinaCache(IDictionary<string,object> data) : base(data)
		{
			    this._AlgorithmId = (ChinaCacheAlgorithmType)ParseEnum(typeof(ChinaCacheAlgorithmType), data.TryGetValueSafe<int>("algorithmId"));
			    this._KeyId = data.TryGetValueSafe<int>("keyId");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlTokenizerChinaCache");
			kparams.AddIfNotNull("algorithmId", this._AlgorithmId);
			kparams.AddIfNotNull("keyId", this._KeyId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ALGORITHM_ID:
					return "AlgorithmId";
				case KEY_ID:
					return "KeyId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

