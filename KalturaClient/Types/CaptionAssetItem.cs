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
	public class CaptionAssetItem : ObjectBase
	{
		#region Constants
		public const string ASSET = "asset";
		public const string ENTRY = "entry";
		public const string START_TIME = "startTime";
		public const string END_TIME = "endTime";
		public const string CONTENT = "content";
		#endregion

		#region Private Fields
		private CaptionAsset _Asset;
		private BaseEntry _Entry;
		private int _StartTime = Int32.MinValue;
		private int _EndTime = Int32.MinValue;
		private string _Content = null;
		#endregion

		#region Properties
		public CaptionAsset Asset
		{
			get { return _Asset; }
			set 
			{ 
				_Asset = value;
				OnPropertyChanged("Asset");
			}
		}
		public BaseEntry Entry
		{
			get { return _Entry; }
			set 
			{ 
				_Entry = value;
				OnPropertyChanged("Entry");
			}
		}
		public int StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		public int EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		public string Content
		{
			get { return _Content; }
			set 
			{ 
				_Content = value;
				OnPropertyChanged("Content");
			}
		}
		#endregion

		#region CTor
		public CaptionAssetItem()
		{
		}

		public CaptionAssetItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "asset":
						this._Asset = ObjectFactory.Create<CaptionAsset>(propertyNode);
						continue;
					case "entry":
						this._Entry = ObjectFactory.Create<BaseEntry>(propertyNode);
						continue;
					case "startTime":
						this._StartTime = ParseInt(propertyNode.InnerText);
						continue;
					case "endTime":
						this._EndTime = ParseInt(propertyNode.InnerText);
						continue;
					case "content":
						this._Content = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaCaptionAssetItem");
			kparams.AddIfNotNull("asset", this._Asset);
			kparams.AddIfNotNull("entry", this._Entry);
			kparams.AddIfNotNull("startTime", this._StartTime);
			kparams.AddIfNotNull("endTime", this._EndTime);
			kparams.AddIfNotNull("content", this._Content);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET:
					return "Asset";
				case ENTRY:
					return "Entry";
				case START_TIME:
					return "StartTime";
				case END_TIME:
					return "EndTime";
				case CONTENT:
					return "Content";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

