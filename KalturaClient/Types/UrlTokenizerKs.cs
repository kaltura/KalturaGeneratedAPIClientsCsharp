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
	public class UrlTokenizerKs : UrlTokenizer
	{
		#region Constants
		public const string USE_PATH = "usePath";
		public const string ADDITIONAL_URIS = "additionalUris";
		#endregion

		#region Private Fields
		private bool? _UsePath = null;
		private string _AdditionalUris = null;
		#endregion

		#region Properties
		public bool? UsePath
		{
			get { return _UsePath; }
			set 
			{ 
				_UsePath = value;
				OnPropertyChanged("UsePath");
			}
		}
		public string AdditionalUris
		{
			get { return _AdditionalUris; }
			set 
			{ 
				_AdditionalUris = value;
				OnPropertyChanged("AdditionalUris");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerKs()
		{
		}

		public UrlTokenizerKs(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "usePath":
						this._UsePath = ParseBool(propertyNode.InnerText);
						continue;
					case "additionalUris":
						this._AdditionalUris = propertyNode.InnerText;
						continue;
				}
			}
		}

		public UrlTokenizerKs(IDictionary<string,object> data) : base(data)
		{
			    this._UsePath = data.TryGetValueSafe<bool>("usePath");
			    this._AdditionalUris = data.TryGetValueSafe<string>("additionalUris");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlTokenizerKs");
			kparams.AddIfNotNull("usePath", this._UsePath);
			kparams.AddIfNotNull("additionalUris", this._AdditionalUris);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USE_PATH:
					return "UsePath";
				case ADDITIONAL_URIS:
					return "AdditionalUris";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

