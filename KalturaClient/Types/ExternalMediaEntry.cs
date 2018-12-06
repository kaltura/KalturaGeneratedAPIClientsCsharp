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
	public class ExternalMediaEntry : MediaEntry
	{
		#region Constants
		public const string EXTERNAL_SOURCE_TYPE = "externalSourceType";
		public const string ASSET_PARAMS_IDS = "assetParamsIds";
		#endregion

		#region Private Fields
		private ExternalMediaSourceType _ExternalSourceType = null;
		private string _AssetParamsIds = null;
		#endregion

		#region Properties
		public ExternalMediaSourceType ExternalSourceType
		{
			get { return _ExternalSourceType; }
			set 
			{ 
				_ExternalSourceType = value;
				OnPropertyChanged("ExternalSourceType");
			}
		}
		public string AssetParamsIds
		{
			get { return _AssetParamsIds; }
		}
		#endregion

		#region CTor
		public ExternalMediaEntry()
		{
		}

		public ExternalMediaEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "externalSourceType":
						this._ExternalSourceType = (ExternalMediaSourceType)StringEnum.Parse(typeof(ExternalMediaSourceType), propertyNode.InnerText);
						continue;
					case "assetParamsIds":
						this._AssetParamsIds = propertyNode.InnerText;
						continue;
				}
			}
		}

		public ExternalMediaEntry(IDictionary<string,object> data) : base(data)
		{
			    this._ExternalSourceType = (ExternalMediaSourceType)StringEnum.Parse(typeof(ExternalMediaSourceType), data.TryGetValueSafe<string>("externalSourceType"));
			    this._AssetParamsIds = data.TryGetValueSafe<string>("assetParamsIds");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaExternalMediaEntry");
			kparams.AddIfNotNull("externalSourceType", this._ExternalSourceType);
			kparams.AddIfNotNull("assetParamsIds", this._AssetParamsIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EXTERNAL_SOURCE_TYPE:
					return "ExternalSourceType";
				case ASSET_PARAMS_IDS:
					return "AssetParamsIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

