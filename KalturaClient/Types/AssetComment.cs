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
	public class AssetComment : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string ASSET_ID = "assetId";
		public const string ASSET_TYPE = "assetType";
		public const string HEADER = "header";
		public const string SUB_HEADER = "subHeader";
		public const string TEXT = "text";
		public const string CREATE_DATE = "createDate";
		public const string WRITER = "writer";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _AssetId = null;
		private AssetType _AssetType = null;
		private string _Header = null;
		private string _SubHeader = null;
		private string _Text = null;
		private long _CreateDate = long.MinValue;
		private string _Writer = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		public AssetType AssetType
		{
			get { return _AssetType; }
			set 
			{ 
				_AssetType = value;
				OnPropertyChanged("AssetType");
			}
		}
		public string Header
		{
			get { return _Header; }
			set 
			{ 
				_Header = value;
				OnPropertyChanged("Header");
			}
		}
		public string SubHeader
		{
			get { return _SubHeader; }
			set 
			{ 
				_SubHeader = value;
				OnPropertyChanged("SubHeader");
			}
		}
		public string Text
		{
			get { return _Text; }
			set 
			{ 
				_Text = value;
				OnPropertyChanged("Text");
			}
		}
		public long CreateDate
		{
			get { return _CreateDate; }
			set 
			{ 
				_CreateDate = value;
				OnPropertyChanged("CreateDate");
			}
		}
		public string Writer
		{
			get { return _Writer; }
			set 
			{ 
				_Writer = value;
				OnPropertyChanged("Writer");
			}
		}
		#endregion

		#region CTor
		public AssetComment()
		{
		}

		public AssetComment(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "assetId":
						this._AssetId = propertyNode.InnerText;
						continue;
					case "assetType":
						this._AssetType = (AssetType)StringEnum.Parse(typeof(AssetType), propertyNode.InnerText);
						continue;
					case "header":
						this._Header = propertyNode.InnerText;
						continue;
					case "subHeader":
						this._SubHeader = propertyNode.InnerText;
						continue;
					case "text":
						this._Text = propertyNode.InnerText;
						continue;
					case "createDate":
						this._CreateDate = ParseLong(propertyNode.InnerText);
						continue;
					case "writer":
						this._Writer = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaAssetComment");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("assetType", this._AssetType);
			kparams.AddIfNotNull("header", this._Header);
			kparams.AddIfNotNull("subHeader", this._SubHeader);
			kparams.AddIfNotNull("text", this._Text);
			kparams.AddIfNotNull("createDate", this._CreateDate);
			kparams.AddIfNotNull("writer", this._Writer);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case ASSET_ID:
					return "AssetId";
				case ASSET_TYPE:
					return "AssetType";
				case HEADER:
					return "Header";
				case SUB_HEADER:
					return "SubHeader";
				case TEXT:
					return "Text";
				case CREATE_DATE:
					return "CreateDate";
				case WRITER:
					return "Writer";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

