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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class OperationResource : ContentResource
	{
		#region Constants
		public const string RESOURCE = "resource";
		public const string OPERATION_ATTRIBUTES = "operationAttributes";
		public const string ASSET_PARAMS_ID = "assetParamsId";
		#endregion

		#region Private Fields
		private ContentResource _Resource;
		private IList<OperationAttributes> _OperationAttributes;
		private int _AssetParamsId = Int32.MinValue;
		#endregion

		#region Properties
		public ContentResource Resource
		{
			get { return _Resource; }
			set 
			{ 
				_Resource = value;
				OnPropertyChanged("Resource");
			}
		}
		public IList<OperationAttributes> OperationAttributes
		{
			get { return _OperationAttributes; }
			set 
			{ 
				_OperationAttributes = value;
				OnPropertyChanged("OperationAttributes");
			}
		}
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
			set 
			{ 
				_AssetParamsId = value;
				OnPropertyChanged("AssetParamsId");
			}
		}
		#endregion

		#region CTor
		public OperationResource()
		{
		}

		public OperationResource(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "resource":
						this._Resource = ObjectFactory.Create<ContentResource>(propertyNode);
						continue;
					case "operationAttributes":
						this._OperationAttributes = new List<OperationAttributes>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._OperationAttributes.Add(ObjectFactory.Create<OperationAttributes>(arrayNode));
						}
						continue;
					case "assetParamsId":
						this._AssetParamsId = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaOperationResource");
			kparams.AddIfNotNull("resource", this._Resource);
			kparams.AddIfNotNull("operationAttributes", this._OperationAttributes);
			kparams.AddIfNotNull("assetParamsId", this._AssetParamsId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RESOURCE:
					return "Resource";
				case OPERATION_ATTRIBUTES:
					return "OperationAttributes";
				case ASSET_PARAMS_ID:
					return "AssetParamsId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

