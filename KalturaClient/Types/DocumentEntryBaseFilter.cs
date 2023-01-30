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
	public class DocumentEntryBaseFilter : BaseEntryFilter
	{
		#region Constants
		public const string DOCUMENT_TYPE_EQUAL = "documentTypeEqual";
		public const string DOCUMENT_TYPE_IN = "documentTypeIn";
		public const string ASSET_PARAMS_IDS_MATCH_OR = "assetParamsIdsMatchOr";
		public const string ASSET_PARAMS_IDS_MATCH_AND = "assetParamsIdsMatchAnd";
		#endregion

		#region Private Fields
		private DocumentType _DocumentTypeEqual = (DocumentType)Int32.MinValue;
		private string _DocumentTypeIn = null;
		private string _AssetParamsIdsMatchOr = null;
		private string _AssetParamsIdsMatchAnd = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use DocumentTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DocumentType DocumentTypeEqual
		{
			get { return _DocumentTypeEqual; }
			set 
			{ 
				_DocumentTypeEqual = value;
				OnPropertyChanged("DocumentTypeEqual");
			}
		}
		/// <summary>
		/// Use DocumentTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DocumentTypeIn
		{
			get { return _DocumentTypeIn; }
			set 
			{ 
				_DocumentTypeIn = value;
				OnPropertyChanged("DocumentTypeIn");
			}
		}
		/// <summary>
		/// Use AssetParamsIdsMatchOrAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetParamsIdsMatchOr
		{
			get { return _AssetParamsIdsMatchOr; }
			set 
			{ 
				_AssetParamsIdsMatchOr = value;
				OnPropertyChanged("AssetParamsIdsMatchOr");
			}
		}
		/// <summary>
		/// Use AssetParamsIdsMatchAndAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetParamsIdsMatchAnd
		{
			get { return _AssetParamsIdsMatchAnd; }
			set 
			{ 
				_AssetParamsIdsMatchAnd = value;
				OnPropertyChanged("AssetParamsIdsMatchAnd");
			}
		}
		#endregion

		#region CTor
		public DocumentEntryBaseFilter()
		{
		}

		public DocumentEntryBaseFilter(JToken node) : base(node)
		{
			if(node["documentTypeEqual"] != null)
			{
				this._DocumentTypeEqual = (DocumentType)ParseEnum(typeof(DocumentType), node["documentTypeEqual"].Value<string>());
			}
			if(node["documentTypeIn"] != null)
			{
				this._DocumentTypeIn = node["documentTypeIn"].Value<string>();
			}
			if(node["assetParamsIdsMatchOr"] != null)
			{
				this._AssetParamsIdsMatchOr = node["assetParamsIdsMatchOr"].Value<string>();
			}
			if(node["assetParamsIdsMatchAnd"] != null)
			{
				this._AssetParamsIdsMatchAnd = node["assetParamsIdsMatchAnd"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDocumentEntryBaseFilter");
			kparams.AddIfNotNull("documentTypeEqual", this._DocumentTypeEqual);
			kparams.AddIfNotNull("documentTypeIn", this._DocumentTypeIn);
			kparams.AddIfNotNull("assetParamsIdsMatchOr", this._AssetParamsIdsMatchOr);
			kparams.AddIfNotNull("assetParamsIdsMatchAnd", this._AssetParamsIdsMatchAnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DOCUMENT_TYPE_EQUAL:
					return "DocumentTypeEqual";
				case DOCUMENT_TYPE_IN:
					return "DocumentTypeIn";
				case ASSET_PARAMS_IDS_MATCH_OR:
					return "AssetParamsIdsMatchOr";
				case ASSET_PARAMS_IDS_MATCH_AND:
					return "AssetParamsIdsMatchAnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

