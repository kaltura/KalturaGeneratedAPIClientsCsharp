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
	public class EntryCaptionAssetSearchItem : SearchItem
	{
		#region Constants
		public const string CONTENT_LIKE = "contentLike";
		public const string CONTENT_MULTI_LIKE_OR = "contentMultiLikeOr";
		public const string CONTENT_MULTI_LIKE_AND = "contentMultiLikeAnd";
		#endregion

		#region Private Fields
		private string _ContentLike = null;
		private string _ContentMultiLikeOr = null;
		private string _ContentMultiLikeAnd = null;
		#endregion

		#region Properties
		public string ContentLike
		{
			get { return _ContentLike; }
			set 
			{ 
				_ContentLike = value;
				OnPropertyChanged("ContentLike");
			}
		}
		public string ContentMultiLikeOr
		{
			get { return _ContentMultiLikeOr; }
			set 
			{ 
				_ContentMultiLikeOr = value;
				OnPropertyChanged("ContentMultiLikeOr");
			}
		}
		public string ContentMultiLikeAnd
		{
			get { return _ContentMultiLikeAnd; }
			set 
			{ 
				_ContentMultiLikeAnd = value;
				OnPropertyChanged("ContentMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public EntryCaptionAssetSearchItem()
		{
		}

		public EntryCaptionAssetSearchItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "contentLike":
						this._ContentLike = txt;
						continue;
					case "contentMultiLikeOr":
						this._ContentMultiLikeOr = txt;
						continue;
					case "contentMultiLikeAnd":
						this._ContentMultiLikeAnd = txt;
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
				kparams.AddReplace("objectType", "KalturaEntryCaptionAssetSearchItem");
			kparams.AddIfNotNull("contentLike", this._ContentLike);
			kparams.AddIfNotNull("contentMultiLikeOr", this._ContentMultiLikeOr);
			kparams.AddIfNotNull("contentMultiLikeAnd", this._ContentMultiLikeAnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONTENT_LIKE:
					return "ContentLike";
				case CONTENT_MULTI_LIKE_OR:
					return "ContentMultiLikeOr";
				case CONTENT_MULTI_LIKE_AND:
					return "ContentMultiLikeAnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

