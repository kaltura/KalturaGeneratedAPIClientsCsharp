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
	public class VendorCaptionsCatalogItemBaseFilter : VendorCatalogItemFilter
	{
		#region Constants
		public const string SOURCE_LANGUAGE_EQUAL = "sourceLanguageEqual";
		public const string SOURCE_LANGUAGE_IN = "sourceLanguageIn";
		public const string OUTPUT_FORMAT_EQUAL = "outputFormatEqual";
		public const string OUTPUT_FORMAT_IN = "outputFormatIn";
		#endregion

		#region Private Fields
		private CatalogItemLanguage _SourceLanguageEqual = null;
		private string _SourceLanguageIn = null;
		private VendorCatalogItemOutputFormat _OutputFormatEqual = (VendorCatalogItemOutputFormat)Int32.MinValue;
		private string _OutputFormatIn = null;
		#endregion

		#region Properties
		[JsonProperty]
		public CatalogItemLanguage SourceLanguageEqual
		{
			get { return _SourceLanguageEqual; }
			set 
			{ 
				_SourceLanguageEqual = value;
				OnPropertyChanged("SourceLanguageEqual");
			}
		}
		[JsonProperty]
		public string SourceLanguageIn
		{
			get { return _SourceLanguageIn; }
			set 
			{ 
				_SourceLanguageIn = value;
				OnPropertyChanged("SourceLanguageIn");
			}
		}
		[JsonProperty]
		public VendorCatalogItemOutputFormat OutputFormatEqual
		{
			get { return _OutputFormatEqual; }
			set 
			{ 
				_OutputFormatEqual = value;
				OnPropertyChanged("OutputFormatEqual");
			}
		}
		[JsonProperty]
		public string OutputFormatIn
		{
			get { return _OutputFormatIn; }
			set 
			{ 
				_OutputFormatIn = value;
				OnPropertyChanged("OutputFormatIn");
			}
		}
		#endregion

		#region CTor
		public VendorCaptionsCatalogItemBaseFilter()
		{
		}

		public VendorCaptionsCatalogItemBaseFilter(JToken node) : base(node)
		{
			if(node["sourceLanguageEqual"] != null)
			{
				this._SourceLanguageEqual = (CatalogItemLanguage)StringEnum.Parse(typeof(CatalogItemLanguage), node["sourceLanguageEqual"].Value<string>());
			}
			if(node["sourceLanguageIn"] != null)
			{
				this._SourceLanguageIn = node["sourceLanguageIn"].Value<string>();
			}
			if(node["outputFormatEqual"] != null)
			{
				this._OutputFormatEqual = (VendorCatalogItemOutputFormat)ParseEnum(typeof(VendorCatalogItemOutputFormat), node["outputFormatEqual"].Value<string>());
			}
			if(node["outputFormatIn"] != null)
			{
				this._OutputFormatIn = node["outputFormatIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVendorCaptionsCatalogItemBaseFilter");
			kparams.AddIfNotNull("sourceLanguageEqual", this._SourceLanguageEqual);
			kparams.AddIfNotNull("sourceLanguageIn", this._SourceLanguageIn);
			kparams.AddIfNotNull("outputFormatEqual", this._OutputFormatEqual);
			kparams.AddIfNotNull("outputFormatIn", this._OutputFormatIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SOURCE_LANGUAGE_EQUAL:
					return "SourceLanguageEqual";
				case SOURCE_LANGUAGE_IN:
					return "SourceLanguageIn";
				case OUTPUT_FORMAT_EQUAL:
					return "OutputFormatEqual";
				case OUTPUT_FORMAT_IN:
					return "OutputFormatIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

