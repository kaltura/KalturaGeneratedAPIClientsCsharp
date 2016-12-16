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
	public class FeedItemInfo : ObjectBase
	{
		#region Constants
		public const string ITEM_XPATH = "itemXPath";
		public const string ITEM_PUBLISH_DATE_XPATH = "itemPublishDateXPath";
		public const string ITEM_UNIQUE_IDENTIFIER_XPATH = "itemUniqueIdentifierXPath";
		public const string ITEM_CONTENT_FILE_SIZE_XPATH = "itemContentFileSizeXPath";
		public const string ITEM_CONTENT_URL_XPATH = "itemContentUrlXPath";
		public const string ITEM_CONTENT_BITRATE_XPATH = "itemContentBitrateXPath";
		public const string ITEM_HASH_XPATH = "itemHashXPath";
		public const string ITEM_CONTENT_XPATH = "itemContentXpath";
		public const string CONTENT_BITRATE_ATTRIBUTE_NAME = "contentBitrateAttributeName";
		#endregion

		#region Private Fields
		private string _ItemXPath = null;
		private string _ItemPublishDateXPath = null;
		private string _ItemUniqueIdentifierXPath = null;
		private string _ItemContentFileSizeXPath = null;
		private string _ItemContentUrlXPath = null;
		private string _ItemContentBitrateXPath = null;
		private string _ItemHashXPath = null;
		private string _ItemContentXpath = null;
		private string _ContentBitrateAttributeName = null;
		#endregion

		#region Properties
		public string ItemXPath
		{
			get { return _ItemXPath; }
			set 
			{ 
				_ItemXPath = value;
				OnPropertyChanged("ItemXPath");
			}
		}
		public string ItemPublishDateXPath
		{
			get { return _ItemPublishDateXPath; }
			set 
			{ 
				_ItemPublishDateXPath = value;
				OnPropertyChanged("ItemPublishDateXPath");
			}
		}
		public string ItemUniqueIdentifierXPath
		{
			get { return _ItemUniqueIdentifierXPath; }
			set 
			{ 
				_ItemUniqueIdentifierXPath = value;
				OnPropertyChanged("ItemUniqueIdentifierXPath");
			}
		}
		public string ItemContentFileSizeXPath
		{
			get { return _ItemContentFileSizeXPath; }
			set 
			{ 
				_ItemContentFileSizeXPath = value;
				OnPropertyChanged("ItemContentFileSizeXPath");
			}
		}
		public string ItemContentUrlXPath
		{
			get { return _ItemContentUrlXPath; }
			set 
			{ 
				_ItemContentUrlXPath = value;
				OnPropertyChanged("ItemContentUrlXPath");
			}
		}
		public string ItemContentBitrateXPath
		{
			get { return _ItemContentBitrateXPath; }
			set 
			{ 
				_ItemContentBitrateXPath = value;
				OnPropertyChanged("ItemContentBitrateXPath");
			}
		}
		public string ItemHashXPath
		{
			get { return _ItemHashXPath; }
			set 
			{ 
				_ItemHashXPath = value;
				OnPropertyChanged("ItemHashXPath");
			}
		}
		public string ItemContentXpath
		{
			get { return _ItemContentXpath; }
			set 
			{ 
				_ItemContentXpath = value;
				OnPropertyChanged("ItemContentXpath");
			}
		}
		public string ContentBitrateAttributeName
		{
			get { return _ContentBitrateAttributeName; }
			set 
			{ 
				_ContentBitrateAttributeName = value;
				OnPropertyChanged("ContentBitrateAttributeName");
			}
		}
		#endregion

		#region CTor
		public FeedItemInfo()
		{
		}

		public FeedItemInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "itemXPath":
						this._ItemXPath = txt;
						continue;
					case "itemPublishDateXPath":
						this._ItemPublishDateXPath = txt;
						continue;
					case "itemUniqueIdentifierXPath":
						this._ItemUniqueIdentifierXPath = txt;
						continue;
					case "itemContentFileSizeXPath":
						this._ItemContentFileSizeXPath = txt;
						continue;
					case "itemContentUrlXPath":
						this._ItemContentUrlXPath = txt;
						continue;
					case "itemContentBitrateXPath":
						this._ItemContentBitrateXPath = txt;
						continue;
					case "itemHashXPath":
						this._ItemHashXPath = txt;
						continue;
					case "itemContentXpath":
						this._ItemContentXpath = txt;
						continue;
					case "contentBitrateAttributeName":
						this._ContentBitrateAttributeName = txt;
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
				kparams.AddReplace("objectType", "KalturaFeedItemInfo");
			kparams.AddIfNotNull("itemXPath", this._ItemXPath);
			kparams.AddIfNotNull("itemPublishDateXPath", this._ItemPublishDateXPath);
			kparams.AddIfNotNull("itemUniqueIdentifierXPath", this._ItemUniqueIdentifierXPath);
			kparams.AddIfNotNull("itemContentFileSizeXPath", this._ItemContentFileSizeXPath);
			kparams.AddIfNotNull("itemContentUrlXPath", this._ItemContentUrlXPath);
			kparams.AddIfNotNull("itemContentBitrateXPath", this._ItemContentBitrateXPath);
			kparams.AddIfNotNull("itemHashXPath", this._ItemHashXPath);
			kparams.AddIfNotNull("itemContentXpath", this._ItemContentXpath);
			kparams.AddIfNotNull("contentBitrateAttributeName", this._ContentBitrateAttributeName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ITEM_XPATH:
					return "ItemXPath";
				case ITEM_PUBLISH_DATE_XPATH:
					return "ItemPublishDateXPath";
				case ITEM_UNIQUE_IDENTIFIER_XPATH:
					return "ItemUniqueIdentifierXPath";
				case ITEM_CONTENT_FILE_SIZE_XPATH:
					return "ItemContentFileSizeXPath";
				case ITEM_CONTENT_URL_XPATH:
					return "ItemContentUrlXPath";
				case ITEM_CONTENT_BITRATE_XPATH:
					return "ItemContentBitrateXPath";
				case ITEM_HASH_XPATH:
					return "ItemHashXPath";
				case ITEM_CONTENT_XPATH:
					return "ItemContentXpath";
				case CONTENT_BITRATE_ATTRIBUTE_NAME:
					return "ContentBitrateAttributeName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

