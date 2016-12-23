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
	public class IndexJobData : JobData
	{
		#region Constants
		public const string FILTER = "filter";
		public const string LAST_INDEX_ID = "lastIndexId";
		public const string LAST_INDEX_DEPTH = "lastIndexDepth";
		public const string SHOULD_UPDATE = "shouldUpdate";
		#endregion

		#region Private Fields
		private Filter _Filter;
		private int _LastIndexId = Int32.MinValue;
		private int _LastIndexDepth = Int32.MinValue;
		private bool? _ShouldUpdate = null;
		#endregion

		#region Properties
		public Filter Filter
		{
			get { return _Filter; }
			set 
			{ 
				_Filter = value;
				OnPropertyChanged("Filter");
			}
		}
		public int LastIndexId
		{
			get { return _LastIndexId; }
			set 
			{ 
				_LastIndexId = value;
				OnPropertyChanged("LastIndexId");
			}
		}
		public int LastIndexDepth
		{
			get { return _LastIndexDepth; }
			set 
			{ 
				_LastIndexDepth = value;
				OnPropertyChanged("LastIndexDepth");
			}
		}
		public bool? ShouldUpdate
		{
			get { return _ShouldUpdate; }
			set 
			{ 
				_ShouldUpdate = value;
				OnPropertyChanged("ShouldUpdate");
			}
		}
		#endregion

		#region CTor
		public IndexJobData()
		{
		}

		public IndexJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "filter":
						this._Filter = ObjectFactory.Create<Filter>(propertyNode);
						continue;
					case "lastIndexId":
						this._LastIndexId = ParseInt(propertyNode.InnerText);
						continue;
					case "lastIndexDepth":
						this._LastIndexDepth = ParseInt(propertyNode.InnerText);
						continue;
					case "shouldUpdate":
						this._ShouldUpdate = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaIndexJobData");
			kparams.AddIfNotNull("filter", this._Filter);
			kparams.AddIfNotNull("lastIndexId", this._LastIndexId);
			kparams.AddIfNotNull("lastIndexDepth", this._LastIndexDepth);
			kparams.AddIfNotNull("shouldUpdate", this._ShouldUpdate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILTER:
					return "Filter";
				case LAST_INDEX_ID:
					return "LastIndexId";
				case LAST_INDEX_DEPTH:
					return "LastIndexDepth";
				case SHOULD_UPDATE:
					return "ShouldUpdate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

