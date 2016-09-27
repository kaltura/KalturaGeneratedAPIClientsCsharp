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

namespace Kaltura
{
	public class KalturaDocumentEntryBaseFilter : KalturaBaseEntryFilter
	{
		#region Private Fields
		private KalturaDocumentType _DocumentTypeEqual = (KalturaDocumentType)Int32.MinValue;
		private string _DocumentTypeIn = null;
		private string _AssetParamsIdsMatchOr = null;
		private string _AssetParamsIdsMatchAnd = null;
		#endregion

		#region Properties
		public KalturaDocumentType DocumentTypeEqual
		{
			get { return _DocumentTypeEqual; }
			set 
			{ 
				_DocumentTypeEqual = value;
				OnPropertyChanged("DocumentTypeEqual");
			}
		}
		public string DocumentTypeIn
		{
			get { return _DocumentTypeIn; }
			set 
			{ 
				_DocumentTypeIn = value;
				OnPropertyChanged("DocumentTypeIn");
			}
		}
		public string AssetParamsIdsMatchOr
		{
			get { return _AssetParamsIdsMatchOr; }
			set 
			{ 
				_AssetParamsIdsMatchOr = value;
				OnPropertyChanged("AssetParamsIdsMatchOr");
			}
		}
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
		public KalturaDocumentEntryBaseFilter()
		{
		}

		public KalturaDocumentEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "documentTypeEqual":
						this._DocumentTypeEqual = (KalturaDocumentType)ParseEnum(typeof(KalturaDocumentType), txt);
						continue;
					case "documentTypeIn":
						this._DocumentTypeIn = txt;
						continue;
					case "assetParamsIdsMatchOr":
						this._AssetParamsIdsMatchOr = txt;
						continue;
					case "assetParamsIdsMatchAnd":
						this._AssetParamsIdsMatchAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDocumentEntryBaseFilter");
			kparams.AddIfNotNull("documentTypeEqual", this._DocumentTypeEqual);
			kparams.AddIfNotNull("documentTypeIn", this._DocumentTypeIn);
			kparams.AddIfNotNull("assetParamsIdsMatchOr", this._AssetParamsIdsMatchOr);
			kparams.AddIfNotNull("assetParamsIdsMatchAnd", this._AssetParamsIdsMatchAnd);
			return kparams;
		}
		#endregion
	}
}

