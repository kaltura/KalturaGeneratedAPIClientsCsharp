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
	public class IndexAdvancedFilter : SearchItem
	{
		#region Constants
		public const string INDEX_ID_GREATER_THAN = "indexIdGreaterThan";
		public const string DEPTH_GREATER_THAN_EQUAL = "depthGreaterThanEqual";
		#endregion

		#region Private Fields
		private int _IndexIdGreaterThan = Int32.MinValue;
		private int _DepthGreaterThanEqual = Int32.MinValue;
		#endregion

		#region Properties
		public int IndexIdGreaterThan
		{
			get { return _IndexIdGreaterThan; }
			set 
			{ 
				_IndexIdGreaterThan = value;
				OnPropertyChanged("IndexIdGreaterThan");
			}
		}
		public int DepthGreaterThanEqual
		{
			get { return _DepthGreaterThanEqual; }
			set 
			{ 
				_DepthGreaterThanEqual = value;
				OnPropertyChanged("DepthGreaterThanEqual");
			}
		}
		#endregion

		#region CTor
		public IndexAdvancedFilter()
		{
		}

		public IndexAdvancedFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "indexIdGreaterThan":
						this._IndexIdGreaterThan = ParseInt(txt);
						continue;
					case "depthGreaterThanEqual":
						this._DepthGreaterThanEqual = ParseInt(txt);
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
				kparams.AddReplace("objectType", "KalturaIndexAdvancedFilter");
			kparams.AddIfNotNull("indexIdGreaterThan", this._IndexIdGreaterThan);
			kparams.AddIfNotNull("depthGreaterThanEqual", this._DepthGreaterThanEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case INDEX_ID_GREATER_THAN:
					return "IndexIdGreaterThan";
				case DEPTH_GREATER_THAN_EQUAL:
					return "DepthGreaterThanEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

