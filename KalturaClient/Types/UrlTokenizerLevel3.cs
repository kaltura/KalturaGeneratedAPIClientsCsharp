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
	public class UrlTokenizerLevel3 : UrlTokenizer
	{
		#region Constants
		public const string PARAM_NAME = "paramName";
		public const string EXPIRY_NAME = "expiryName";
		public const string GEN = "gen";
		#endregion

		#region Private Fields
		private string _ParamName = null;
		private string _ExpiryName = null;
		private string _Gen = null;
		#endregion

		#region Properties
		public string ParamName
		{
			get { return _ParamName; }
			set 
			{ 
				_ParamName = value;
				OnPropertyChanged("ParamName");
			}
		}
		public string ExpiryName
		{
			get { return _ExpiryName; }
			set 
			{ 
				_ExpiryName = value;
				OnPropertyChanged("ExpiryName");
			}
		}
		public string Gen
		{
			get { return _Gen; }
			set 
			{ 
				_Gen = value;
				OnPropertyChanged("Gen");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerLevel3()
		{
		}

		public UrlTokenizerLevel3(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "paramName":
						this._ParamName = propertyNode.InnerText;
						continue;
					case "expiryName":
						this._ExpiryName = propertyNode.InnerText;
						continue;
					case "gen":
						this._Gen = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaUrlTokenizerLevel3");
			kparams.AddIfNotNull("paramName", this._ParamName);
			kparams.AddIfNotNull("expiryName", this._ExpiryName);
			kparams.AddIfNotNull("gen", this._Gen);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARAM_NAME:
					return "ParamName";
				case EXPIRY_NAME:
					return "ExpiryName";
				case GEN:
					return "Gen";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

