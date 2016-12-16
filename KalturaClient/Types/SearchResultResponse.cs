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
	public class SearchResultResponse : ObjectBase
	{
		#region Constants
		public const string OBJECTS = "objects";
		public const string NEED_MEDIA_INFO = "needMediaInfo";
		#endregion

		#region Private Fields
		private IList<SearchResult> _Objects;
		private bool? _NeedMediaInfo = null;
		#endregion

		#region Properties
		public IList<SearchResult> Objects
		{
			get { return _Objects; }
		}
		public bool? NeedMediaInfo
		{
			get { return _NeedMediaInfo; }
		}
		#endregion

		#region CTor
		public SearchResultResponse()
		{
		}

		public SearchResultResponse(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "objects":
						this._Objects = new List<SearchResult>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Objects.Add(ObjectFactory.Create<SearchResult>(arrayNode));
						}
						continue;
					case "needMediaInfo":
						this._NeedMediaInfo = ParseBool(txt);
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
				kparams.AddReplace("objectType", "KalturaSearchResultResponse");
			kparams.AddIfNotNull("objects", this._Objects);
			kparams.AddIfNotNull("needMediaInfo", this._NeedMediaInfo);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OBJECTS:
					return "Objects";
				case NEED_MEDIA_INFO:
					return "NeedMediaInfo";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

