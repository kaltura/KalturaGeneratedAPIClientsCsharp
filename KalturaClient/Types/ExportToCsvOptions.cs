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
	public class ExportToCsvOptions : ObjectBase
	{
		#region Constants
		public const string FORMAT = "format";
		public const string TYPE_EQUAL = "typeEqual";
		public const string DEFAULT_HEADER = "defaultHeader";
		#endregion

		#region Private Fields
		private string _Format = null;
		private EntryType _TypeEqual = null;
		private NullableBoolean _DefaultHeader = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use FormatAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		/// <summary>
		/// Use TypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		/// <summary>
		/// Use DefaultHeaderAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean DefaultHeader
		{
			get { return _DefaultHeader; }
			set 
			{ 
				_DefaultHeader = value;
				OnPropertyChanged("DefaultHeader");
			}
		}
		#endregion

		#region CTor
		public ExportToCsvOptions()
		{
		}

		public ExportToCsvOptions(JToken node) : base(node)
		{
			if(node["format"] != null)
			{
				this._Format = node["format"].Value<string>();
			}
			if(node["typeEqual"] != null)
			{
				this._TypeEqual = (EntryType)StringEnum.Parse(typeof(EntryType), node["typeEqual"].Value<string>());
			}
			if(node["defaultHeader"] != null)
			{
				this._DefaultHeader = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["defaultHeader"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaExportToCsvOptions");
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("typeEqual", this._TypeEqual);
			kparams.AddIfNotNull("defaultHeader", this._DefaultHeader);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FORMAT:
					return "Format";
				case TYPE_EQUAL:
					return "TypeEqual";
				case DEFAULT_HEADER:
					return "DefaultHeader";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

