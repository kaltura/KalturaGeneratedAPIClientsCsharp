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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class DocumentEntry : BaseEntry
	{
		#region Constants
		public const string DOCUMENT_TYPE = "documentType";
		public const string ASSET_PARAMS_IDS = "assetParamsIds";
		#endregion

		#region Private Fields
		private DocumentType _DocumentType = (DocumentType)Int32.MinValue;
		private string _AssetParamsIds = null;
		#endregion

		#region Properties
		public DocumentType DocumentType
		{
			get { return _DocumentType; }
			set 
			{ 
				_DocumentType = value;
				OnPropertyChanged("DocumentType");
			}
		}
		public string AssetParamsIds
		{
			get { return _AssetParamsIds; }
		}
		#endregion

		#region CTor
		public DocumentEntry()
		{
		}

		public DocumentEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "documentType":
						this._DocumentType = (DocumentType)ParseEnum(typeof(DocumentType), propertyNode.InnerText);
						continue;
					case "assetParamsIds":
						this._AssetParamsIds = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaDocumentEntry");
			kparams.AddIfNotNull("documentType", this._DocumentType);
			kparams.AddIfNotNull("assetParamsIds", this._AssetParamsIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DOCUMENT_TYPE:
					return "DocumentType";
				case ASSET_PARAMS_IDS:
					return "AssetParamsIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

