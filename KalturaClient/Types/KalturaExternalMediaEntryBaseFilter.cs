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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaExternalMediaEntryBaseFilter : KalturaMediaEntryFilter
	{
		#region Private Fields
		private KalturaExternalMediaSourceType _ExternalSourceTypeEqual = null;
		private string _ExternalSourceTypeIn = null;
		private string _AssetParamsIdsMatchOr = null;
		private string _AssetParamsIdsMatchAnd = null;
		#endregion

		#region Properties
		public KalturaExternalMediaSourceType ExternalSourceTypeEqual
		{
			get { return _ExternalSourceTypeEqual; }
			set 
			{ 
				_ExternalSourceTypeEqual = value;
				OnPropertyChanged("ExternalSourceTypeEqual");
			}
		}
		public string ExternalSourceTypeIn
		{
			get { return _ExternalSourceTypeIn; }
			set 
			{ 
				_ExternalSourceTypeIn = value;
				OnPropertyChanged("ExternalSourceTypeIn");
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
		public KalturaExternalMediaEntryBaseFilter()
		{
		}

		public KalturaExternalMediaEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "externalSourceTypeEqual":
						this.ExternalSourceTypeEqual = (KalturaExternalMediaSourceType)KalturaStringEnum.Parse(typeof(KalturaExternalMediaSourceType), txt);
						continue;
					case "externalSourceTypeIn":
						this.ExternalSourceTypeIn = txt;
						continue;
					case "assetParamsIdsMatchOr":
						this.AssetParamsIdsMatchOr = txt;
						continue;
					case "assetParamsIdsMatchAnd":
						this.AssetParamsIdsMatchAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaExternalMediaEntryBaseFilter");
			kparams.AddStringEnumIfNotNull("externalSourceTypeEqual", this.ExternalSourceTypeEqual);
			kparams.AddStringIfNotNull("externalSourceTypeIn", this.ExternalSourceTypeIn);
			kparams.AddStringIfNotNull("assetParamsIdsMatchOr", this.AssetParamsIdsMatchOr);
			kparams.AddStringIfNotNull("assetParamsIdsMatchAnd", this.AssetParamsIdsMatchAnd);
			return kparams;
		}
		#endregion
	}
}

