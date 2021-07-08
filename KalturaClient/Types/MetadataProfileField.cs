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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class MetadataProfileField : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string XPATH = "xPath";
		public const string KEY = "key";
		public const string LABEL = "label";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _XPath = null;
		private string _Key = null;
		private string _Label = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use XPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string XPath
		{
			get { return _XPath; }
			private set 
			{ 
				_XPath = value;
				OnPropertyChanged("XPath");
			}
		}
		/// <summary>
		/// Use KeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Key
		{
			get { return _Key; }
			private set 
			{ 
				_Key = value;
				OnPropertyChanged("Key");
			}
		}
		/// <summary>
		/// Use LabelAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Label
		{
			get { return _Label; }
			private set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		#endregion

		#region CTor
		public MetadataProfileField()
		{
		}

		public MetadataProfileField(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["xPath"] != null)
			{
				this._XPath = node["xPath"].Value<string>();
			}
			if(node["key"] != null)
			{
				this._Key = node["key"].Value<string>();
			}
			if(node["label"] != null)
			{
				this._Label = node["label"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMetadataProfileField");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("xPath", this._XPath);
			kparams.AddIfNotNull("key", this._Key);
			kparams.AddIfNotNull("label", this._Label);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case XPATH:
					return "XPath";
				case KEY:
					return "Key";
				case LABEL:
					return "Label";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

