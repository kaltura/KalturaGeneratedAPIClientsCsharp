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
	public class KalturaFeedItemInfo : KalturaObjectBase
	{
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
		public KalturaFeedItemInfo()
		{
		}

		public KalturaFeedItemInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "itemXPath":
						this.ItemXPath = txt;
						continue;
					case "itemPublishDateXPath":
						this.ItemPublishDateXPath = txt;
						continue;
					case "itemUniqueIdentifierXPath":
						this.ItemUniqueIdentifierXPath = txt;
						continue;
					case "itemContentFileSizeXPath":
						this.ItemContentFileSizeXPath = txt;
						continue;
					case "itemContentUrlXPath":
						this.ItemContentUrlXPath = txt;
						continue;
					case "itemContentBitrateXPath":
						this.ItemContentBitrateXPath = txt;
						continue;
					case "itemHashXPath":
						this.ItemHashXPath = txt;
						continue;
					case "itemContentXpath":
						this.ItemContentXpath = txt;
						continue;
					case "contentBitrateAttributeName":
						this.ContentBitrateAttributeName = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFeedItemInfo");
			kparams.AddIfNotNull("itemXPath", this.ItemXPath);
			kparams.AddIfNotNull("itemPublishDateXPath", this.ItemPublishDateXPath);
			kparams.AddIfNotNull("itemUniqueIdentifierXPath", this.ItemUniqueIdentifierXPath);
			kparams.AddIfNotNull("itemContentFileSizeXPath", this.ItemContentFileSizeXPath);
			kparams.AddIfNotNull("itemContentUrlXPath", this.ItemContentUrlXPath);
			kparams.AddIfNotNull("itemContentBitrateXPath", this.ItemContentBitrateXPath);
			kparams.AddIfNotNull("itemHashXPath", this.ItemHashXPath);
			kparams.AddIfNotNull("itemContentXpath", this.ItemContentXpath);
			kparams.AddIfNotNull("contentBitrateAttributeName", this.ContentBitrateAttributeName);
			return kparams;
		}
		#endregion
	}
}

