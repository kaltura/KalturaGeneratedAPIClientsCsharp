// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class ExtendingItemMrssParameter : ObjectBase
	{
		#region Constants
		public const string XPATH = "xpath";
		public const string IDENTIFIER = "identifier";
		public const string EXTENSION_MODE = "extensionMode";
		#endregion

		#region Private Fields
		private string _Xpath = null;
		private ObjectIdentifier _Identifier;
		private MrssExtensionMode _ExtensionMode = (MrssExtensionMode)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use XpathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Xpath
		{
			get { return _Xpath; }
			set 
			{ 
				_Xpath = value;
				OnPropertyChanged("Xpath");
			}
		}
		/// <summary>
		/// Use IdentifierAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ObjectIdentifier Identifier
		{
			get { return _Identifier; }
			set 
			{ 
				_Identifier = value;
				OnPropertyChanged("Identifier");
			}
		}
		/// <summary>
		/// Use ExtensionModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MrssExtensionMode ExtensionMode
		{
			get { return _ExtensionMode; }
			set 
			{ 
				_ExtensionMode = value;
				OnPropertyChanged("ExtensionMode");
			}
		}
		#endregion

		#region CTor
		public ExtendingItemMrssParameter()
		{
		}

		public ExtendingItemMrssParameter(JToken node) : base(node)
		{
			if(node["xpath"] != null)
			{
				this._Xpath = node["xpath"].Value<string>();
			}
			if(node["identifier"] != null)
			{
				this._Identifier = ObjectFactory.Create<ObjectIdentifier>(node["identifier"]);
			}
			if(node["extensionMode"] != null)
			{
				this._ExtensionMode = (MrssExtensionMode)ParseEnum(typeof(MrssExtensionMode), node["extensionMode"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaExtendingItemMrssParameter");
			kparams.AddIfNotNull("xpath", this._Xpath);
			kparams.AddIfNotNull("identifier", this._Identifier);
			kparams.AddIfNotNull("extensionMode", this._ExtensionMode);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case XPATH:
					return "Xpath";
				case IDENTIFIER:
					return "Identifier";
				case EXTENSION_MODE:
					return "ExtensionMode";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

